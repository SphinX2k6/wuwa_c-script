using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf.Collections;

// Token: 0x02003291 RID: 12945
[NullableContext(1)]
[Nullable(0)]
public class PlayerBuffComponent : BaseBuffComponent
{
	// Token: 0x0601C051 RID: 114769 RVA: 0x007C9EED File Offset: 0x007C80ED
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		base.BuffEffectManager = new ExtraEffectManager(this);
		return true;
	}

	// Token: 0x0601C052 RID: 114770 RVA: 0x007C9EFC File Offset: 0x007C80FC
	protected override bool OnInit()
	{
		base.OnInit();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		base.SetBuffComponentType(EBuffComponentType.TeamBuffComponent);
		return true;
	}

	// Token: 0x0601C053 RID: 114771 RVA: 0x007C9F20 File Offset: 0x007C8120
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		if (this.PlayerId == 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Actor;
			Entity entity = base.Entity;
			string message = "PlayerId为0";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x0601C054 RID: 114772 RVA: 0x007C9F90 File Offset: 0x007C8190
	protected override bool OnStart()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		return true;
	}

	// Token: 0x0601C055 RID: 114773 RVA: 0x007C9FCB File Offset: 0x007C81CB
	protected override void OnActivate()
	{
		this.InitBornBuff();
	}

	// Token: 0x0601C056 RID: 114774 RVA: 0x007C9FD4 File Offset: 0x007C81D4
	protected override bool OnClear()
	{
		this.TriggerMap.Clear();
		this.BuffRefEntityIdMap.Clear();
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			activeBuffInternal.Destroy();
		}
		this.DelayAddCueBuffIds = null;
		base.OnClear();
		return true;
	}

	// Token: 0x0601C057 RID: 114775 RVA: 0x007CA050 File Offset: 0x007C8250
	protected override bool OnEnd()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		return true;
	}

	// Token: 0x0601C058 RID: 114776 RVA: 0x007CA08B File Offset: 0x007C828B
	public override bool IsPaused()
	{
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		return currentBuffComponent != null && currentBuffComponent.IsPaused();
	}

	// Token: 0x0601C059 RID: 114777 RVA: 0x007CA0A0 File Offset: 0x007C82A0
	protected override void InitBornBuff()
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		if (creatureDataComponent == null)
		{
			return;
		}
		EntityComponentPb entityComponentPb;
		creatureDataComponent.ComponentDataMap.TryGetValue("FightBuffComponent", out entityComponentPb);
		FightBuffComponentPb fightBuffComponentPb = (entityComponentPb != null) ? entityComponentPb.FightBuffComponent : null;
		if (fightBuffComponentPb == null)
		{
			return;
		}
		RepeatedField<BuffEffectCd> listBuffEffectCd = fightBuffComponentPb.ListBuffEffectCd;
		if (listBuffEffectCd != null)
		{
			foreach (BuffEffectCd buffEffectCd in listBuffEffectCd)
			{
				long buffId = MathUtils.Instance.LongToNumber(buffEffectCd.BuffId);
				for (int i = 0; i < buffEffectCd.ListCdRemaining.Count; i++)
				{
					this.SetBuffEffectCd(buffId, i, (float)(buffEffectCd.ListCdRemaining[i] * 1000));
				}
			}
		}
		RepeatedField<FightBuffInformation> fightBuffInfos = fightBuffComponentPb.FightBuffInfos;
		if (fightBuffInfos != null)
		{
			foreach (FightBuffInformation fightBuffInformation in fightBuffInfos)
			{
				long buffId2 = fightBuffInformation.BuffId;
				long instigatorId = fightBuffInformation.InstigatorId;
				int handleId = fightBuffInformation.HandleId;
				long overrideConfigId = 0L;
				if (fightBuffInformation.ConfBuffId != 0L)
				{
					overrideConfigId = fightBuffInformation.ConfBuffId;
				}
				base.AddBuffRemote(buffId2, handleId, overrideConfigId, new AddBuffParam
				{
					Level = new int?(fightBuffInformation.Level),
					InstigatorId = instigatorId,
					ApplyType = new ApplyGEType?(fightBuffInformation.ApplyType),
					Duration = new float?(fightBuffInformation.Duration),
					RemainDuration = new float?(fightBuffInformation.LeftDuration),
					IsActive = new bool?(fightBuffInformation.IsActive),
					ServerId = new int?(fightBuffInformation.ServerId),
					OuterStackCount = new int?(fightBuffInformation.StackCount),
					Reason = "服务器通过通知FightBuffComponent恢复PlayerBuff",
					MessageId = new long?(MathUtils.Instance.LongToBigInt(fightBuffInformation.MessageId)),
					BornBuff = new bool?(true)
				});
				ActiveBuffInternal activeBuffInternal;
				this.BuffContainer.TryGetValue(handleId, out activeBuffInternal);
				if (activeBuffInternal != null)
				{
					activeBuffInternal.SetRemainDuration(fightBuffInformation.LeftDuration);
				}
			}
		}
	}

	// Token: 0x0601C05A RID: 114778 RVA: 0x007CA2F4 File Offset: 0x007C84F4
	protected override void OnAnyBuffInhibitionChanged(IActiveBuff buff)
	{
		if (buff.Config.FormationPolicy == EBuffFormationPolicy.FormationBuff && !SceneTeamModel.Instance.IsTeamReady)
		{
			List<long> list = (this.DelayAddCueBuffIds != null) ? new List<long>(this.DelayAddCueBuffIds) : new List<long>();
			list.Add(buff.Id);
			this.DelayAddCueBuffIds = list.ToArray();
			return;
		}
		this.OnAnyBuffInhibitionChangedInternal(buff);
	}

	// Token: 0x0601C05B RID: 114779 RVA: 0x007CA356 File Offset: 0x007C8556
	private void OnAnyBuffInhibitionChangedInternal(IActiveBuff buff)
	{
		if (buff.IsActive())
		{
			base.CreateGameplayCueByBuff(buff);
			return;
		}
		base.DestroyGameplayCueByBuff(buff);
	}

	// Token: 0x0601C05C RID: 114780 RVA: 0x007CA370 File Offset: 0x007C8570
	public override string GetDebugName()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("player_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PlayerId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601C05D RID: 114781 RVA: 0x007CA3A8 File Offset: 0x007C85A8
	[NullableContext(2)]
	public override Entity GetEntity()
	{
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
		long? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
			}
		}
		long? num2 = num;
		EntityHandle entity = CreatureModel.Instance.GetEntity(num2.GetValueOrDefault());
		if (entity == null)
		{
			return null;
		}
		return entity.Entity;
	}

	// Token: 0x0601C05E RID: 114782 RVA: 0x007CA424 File Offset: 0x007C8624
	public override float GetTimeScale()
	{
		Entity entity = base.Entity;
		float? num = (entity != null) ? new float?(entity.TimeDilation) : null;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return (num * ((timeScaleComponent != null) ? timeScaleComponent.CurrentTimeScale : 1f)).GetValueOrDefault();
	}

	// Token: 0x0601C05F RID: 114783 RVA: 0x007CA492 File Offset: 0x007C8692
	public override float GetLogicTimeScale()
	{
		float timeDilation = base.Entity.TimeDilation;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return timeDilation * ((timeScaleComponent != null) ? timeScaleComponent.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView)) : 1f);
	}

	// Token: 0x0601C060 RID: 114784 RVA: 0x007CA4BC File Offset: 0x007C86BC
	[NullableContext(2)]
	public CharacterBuffComponent GetCurrentBuffComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<CharacterBuffComponent>();
	}

	// Token: 0x0601C061 RID: 114785 RVA: 0x007CA4CF File Offset: 0x007C86CF
	[NullableContext(2)]
	public override BaseSkillComponent GetSkillComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseSkillComponent>();
	}

	// Token: 0x0601C062 RID: 114786 RVA: 0x007CA4E2 File Offset: 0x007C86E2
	[NullableContext(2)]
	public override BaseAttributeComponent GetAttributeComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseAttributeComponent>();
	}

	// Token: 0x0601C063 RID: 114787 RVA: 0x007CA4F5 File Offset: 0x007C86F5
	[NullableContext(2)]
	public override BaseTagComponent GetTagComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseTagComponent>();
	}

	// Token: 0x0601C064 RID: 114788 RVA: 0x007CA508 File Offset: 0x007C8708
	protected override bool CheckAdd(BuffDefinition config, long instigatorId, bool fromServer)
	{
		return this.GetTagComponent() == null || base.CheckAdd(config, instigatorId, fromServer);
	}

	// Token: 0x0601C065 RID: 114789 RVA: 0x007CA51D File Offset: 0x007C871D
	protected override bool CheckActivate(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		return this.GetTagComponent() == null || base.CheckActivate(config, instigator);
	}

	// Token: 0x0601C066 RID: 114790 RVA: 0x007CA531 File Offset: 0x007C8731
	public override bool HasBuffRoutineExpirationLock(long buffId)
	{
		if (this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) <= 0)
		{
			CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
			return ((currentBuffComponent != null) ? currentBuffComponent.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) : 0) > 0;
		}
		return true;
	}

	// Token: 0x0601C067 RID: 114791 RVA: 0x007CA561 File Offset: 0x007C8761
	[NullableContext(2)]
	public override BaseActorComponent GetActorComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseActorComponent>();
	}

	// Token: 0x0601C068 RID: 114792 RVA: 0x007CA574 File Offset: 0x007C8774
	public override int? GetBuffLevel(long buffId)
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
		if (component == null)
		{
			return null;
		}
		return component.GetBuffLevel(buffId);
	}

	// Token: 0x0601C069 RID: 114793 RVA: 0x007CA5AE File Offset: 0x007C87AE
	[NullableContext(2)]
	public override BaseGameplayCueComponent GetCueComponent()
	{
		return base.Entity.GetComponent<BaseGameplayCueComponent>();
	}

	// Token: 0x0601C06A RID: 114794 RVA: 0x007CA5BB File Offset: 0x007C87BB
	public int GetFormationBuffTotalStackById(long buffId, bool onlyActiveBuff = false)
	{
		return base.GetBuffTotalStackById(buffId, onlyActiveBuff);
	}

	// Token: 0x0601C06B RID: 114795 RVA: 0x007CA5C5 File Offset: 0x007C87C5
	public override int GetBuffTotalStackById(long buffId, bool onlyActiveBuff = false)
	{
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		return ((currentBuffComponent != null) ? currentBuffComponent.GetBuffTotalStackById(buffId, onlyActiveBuff) : 0) + base.GetBuffTotalStackById(buffId, onlyActiveBuff);
	}

	// Token: 0x0601C06C RID: 114796 RVA: 0x007CA5E4 File Offset: 0x007C87E4
	public override bool HasBuffAuthority()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = this.PlayerId;
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x0601C06D RID: 114797 RVA: 0x007CA618 File Offset: 0x007C8818
	public unsafe override int AddBuffInner(long buffId, [Nullable(2)] BuffDefinition config, long? instigatorId, int level, int? outerStackCount, ApplyGEType? applyType, long? preMessageId, long? messageId, float? duration, bool? isActive, int serverId, string reason, bool fromServer, bool isIterable, bool isServerOrder, int? handle, long? bulletMessageId = null, bool? bornBuff = null)
	{
		if ((config == null || config.FormationPolicy != EBuffFormationPolicy.FormationBuff) && buffId != -3L)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "暂不支持对编队实体增删非编队buff";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return -1;
		}
		return base.AddBuffInner(buffId, config, instigatorId, level, outerStackCount, applyType, preMessageId, messageId, duration, isActive, serverId, reason, fromServer, isIterable, isServerOrder, handle, bulletMessageId, bornBuff);
	}

	// Token: 0x0601C06E RID: 114798 RVA: 0x007CA6C4 File Offset: 0x007C88C4
	protected override void OnBuffAdded(ActiveBuffInternal buff, int? stackCount, ApplyGEType applyType, long? preMessageId, float? duration, bool? isActive, int serverId, bool fromServer, bool isIterable, bool isServerRequest, string reason)
	{
		if (buff == null)
		{
			return;
		}
		this.BroadcastAddBuff(buff, applyType, isServerRequest, fromServer, reason);
		BuffDefinition config = buff.Config;
		base.OnBuffAdded(buff, stackCount, applyType, preMessageId, duration, isActive, serverId, fromServer, isIterable, isServerRequest, reason);
		SceneTeamModel instance = SceneTeamModel.Instance;
		foreach (SceneTeamItem sceneTeamItem in (((instance != null) ? instance.GetTeamItemsByPlayer(this.PlayerId) : null) ?? new List<SceneTeamItem>()))
		{
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			EntityHandle entityHandle2 = sceneTeamItem.EntityHandle;
			if (entityHandle2 != null && entityHandle2.Valid && worldEntity != null)
			{
				CharacterBuffComponent characterBuffComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterBuffComponent>() : null;
				if (characterBuffComponent != null && config.RemoveBuffWithTags != null && config.RemoveBuffWithTags.Length != 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
					defaultInterpolatedStringHandler.AppendLiteral("因为buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(buff.Id);
					defaultInterpolatedStringHandler.AppendLiteral("(handle=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(buff.Handle);
					defaultInterpolatedStringHandler.AppendLiteral(")的RemoveBuffWithTags导致移除");
					string reason2 = defaultInterpolatedStringHandler.ToStringAndClear();
					foreach (int value in config.RemoveBuffWithTags)
					{
						if (characterBuffComponent.HasBuffAuthority())
						{
							characterBuffComponent.RemoveBuffByTag(new int?(value), reason2, null);
						}
						characterBuffComponent.TagComponent.RemoveTag(new int?(value));
					}
				}
			}
		}
	}

	// Token: 0x0601C06F RID: 114799 RVA: 0x007CA870 File Offset: 0x007C8A70
	protected override void OnBuffRemoved(ActiveBuffInternal buff, bool isPrematureRemoval, [Nullable(2)] string reason, bool? isServerRequest = null, long? preMessageId = null, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		this.BroadcastRemoveBuff(buff, isPrematureRemoval, isServerRequest, preMessageId, reason, instigatorId);
		base.OnBuffRemoved(buff, isPrematureRemoval, reason, isServerRequest, preMessageId, instigatorId);
		base.DestroyGameplayCueByBuff(buff);
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			CharacterStatisticsComponent component = base.Entity.GetComponent<CharacterStatisticsComponent>();
			if (component != null)
			{
				component.OnBuffRemoved(buff);
			}
			CharacterGasDebugComponent component2 = base.Entity.GetComponent<CharacterGasDebugComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.OnBuffRemoved(buff);
		}
	}

	// Token: 0x0601C070 RID: 114800 RVA: 0x007CA8E0 File Offset: 0x007C8AE0
	protected override void OnBuffStackIncreased(ActiveBuffInternal buff, int oldStack, int newStack, long? instigatorId, int level, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId, bool isIterable, bool isServerOrder, [Nullable(2)] string reason, EBuffStackDurationOverride stackDurationRefreshPolicy = EBuffStackDurationOverride.Default, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackIncreased(buff, oldStack, newStack, instigatorId, level, outerStackCount, applyType, preMessageId, duration, serverId, isIterable, isServerOrder, reason, stackDurationRefreshPolicy, stackPeriodResetPolicy);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, false, stackDurationRefreshPolicy, stackPeriodResetPolicy, reason, instigatorId);
	}

	// Token: 0x0601C071 RID: 114801 RVA: 0x007CA924 File Offset: 0x007C8B24
	protected override void OnBuffStackDecreased(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, [Nullable(2)] string reason, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackDecreased(buff, oldStack, newStack, isPrematureRemoval, reason, stackPeriodResetPolicy, instigatorId);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, isPrematureRemoval, EBuffStackDurationOverride.Default, stackPeriodResetPolicy, reason, instigatorId);
	}

	// Token: 0x0601C072 RID: 114802 RVA: 0x007CA958 File Offset: 0x007C8B58
	[NullableContext(2)]
	protected override void OnBuffActiveChanged(ActiveBuffInternal buff, bool isActive, bool? syncedActive = null)
	{
		base.OnBuffActiveChanged(buff, isActive, syncedActive);
	}

	// Token: 0x0601C073 RID: 114803 RVA: 0x007CA964 File Offset: 0x007C8B64
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		int buffLock = base.BuffLock;
		base.BuffLock = buffLock + 1;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (HashSet<int> hashSet2 in this.TagListenerDict.Values)
		{
			foreach (int item in hashSet2)
			{
				hashSet.Add(item);
			}
		}
		foreach (int handle in hashSet)
		{
			ActiveBuffInternal activeBuffInternal = base.GetBuffByHandle(handle) as ActiveBuffInternal;
			if (activeBuffInternal != null)
			{
				if (this.CheckRemove(activeBuffInternal.Config, activeBuffInternal.GetInstigator()))
				{
					this.RemoveBuffInner(handle, -1, true, "因为切人导致不满足tag条件", null, null, null);
				}
				else
				{
					bool flag = this.CheckActivate(activeBuffInternal.Config, activeBuffInternal.GetInstigator());
					if (flag != activeBuffInternal.IsActive())
					{
						this.OnBuffActiveChanged(activeBuffInternal, flag, null);
					}
				}
			}
		}
		buffLock = base.BuffLock;
		base.BuffLock = buffLock - 1;
	}

	// Token: 0x0601C074 RID: 114804 RVA: 0x007CAAE4 File Offset: 0x007C8CE4
	private void OnUpdateSceneTeam()
	{
		if (this.DelayAddCueBuffIds != null)
		{
			foreach (long buffId in this.DelayAddCueBuffIds)
			{
				ActiveBuffInternal buffById = base.GetBuffById(buffId);
				if (buffById != null && buffById.IsValid())
				{
					this.OnAnyBuffInhibitionChangedInternal(buffById);
				}
			}
			this.DelayAddCueBuffIds = null;
		}
	}

	// Token: 0x0601C075 RID: 114805 RVA: 0x007CAB34 File Offset: 0x007C8D34
	protected void BroadcastAddBuff(ActiveBuffInternal buff, ApplyGEType applyType, bool isServerRequest, bool fromServer, string reason)
	{
		if (buff == null || buff.Id < 0L || !this.NeedBroadcastBuff(buff, fromServer))
		{
			return;
		}
		if (!buff.IsInstantBuff() && buff.Handle < 0)
		{
			return;
		}
		ApplyGameplayEffectPush applyGameplayEffectPush = ApplyGameplayEffectPush.Create();
		applyGameplayEffectPush.Handle = buff.Handle;
		applyGameplayEffectPush.Id = MathUtils.Instance.NumberToLong(buff.Id);
		applyGameplayEffectPush.Level = buff.Level;
		if (buff.InstigatorId != null)
		{
			applyGameplayEffectPush.InstigatorId = MathUtils.Instance.NumberToLong(buff.InstigatorId.Value);
		}
		applyGameplayEffectPush.ApplyType = applyType;
		applyGameplayEffectPush.Duration = buff.GetRemainDuration();
		applyGameplayEffectPush.ServerId = buff.ServerId;
		applyGameplayEffectPush.StackCount = buff.StackCount;
		applyGameplayEffectPush.ConfBuffId = MathUtils.Instance.NumberToLong(0L);
		if (buff.GetConfigOverrideListenerId() != null)
		{
			long? id = buff.Config.Id;
			if (id != null)
			{
				long? num = id;
				long id2 = buff.Id;
				if (!(num.GetValueOrDefault() == id2 & num != null))
				{
					applyGameplayEffectPush.ConfBuffId = MathUtils.Instance.NumberToLong(id.Value);
				}
			}
		}
		CombatNet.Instance.Send(EPushMessageId.ApplyGameplayEffectPush, base.Entity, applyGameplayEffectPush, buff.PreMessageId, buff.MessageId, new bool?(isServerRequest));
	}

	// Token: 0x0601C076 RID: 114806 RVA: 0x007CAC90 File Offset: 0x007C8E90
	protected override void BroadcastActivateBuff(ActiveBuffInternal buff, bool on)
	{
		if (buff.Id < 0L || !this.NeedBroadcastBuff(buff, false))
		{
			return;
		}
		ActivateBuffPush activateBuffPush = ActivateBuffPush.Create();
		activateBuffPush.Handle = buff.Handle;
		activateBuffPush.On = on;
		CombatNet.Instance.Send(EPushMessageId.ActivateBuffPush, base.Entity, activateBuffPush, null, null, null);
	}

	// Token: 0x0601C077 RID: 114807 RVA: 0x007CAD00 File Offset: 0x007C8F00
	protected void BroadcastBuffStackChanged(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, EBuffStackDurationOverride stackDurationRefreshPolicy, EBuffStackPeriodResetOverride stackPeriodResetPolicy, [Nullable(2)] string reason, long? instigatorId = null)
	{
		if (buff.Id < 0L || !this.NeedBroadcastBuff(buff, false))
		{
			return;
		}
		BuffStackCountPush buffStackCountPush = BuffStackCountPush.Create();
		buffStackCountPush.HandleId = buff.Handle;
		buffStackCountPush.NewStackCount = newStack;
		buffStackCountPush.IsPrematureRemoval = isPrematureRemoval;
		buffStackCountPush.InstigatorId = instigatorId.GetValueOrDefault();
		buffStackCountPush.NotRefreshDuration = (stackDurationRefreshPolicy == EBuffStackDurationOverride.ForceNoRefresh);
		buffStackCountPush.NotRefreshPeriod = (stackPeriodResetPolicy == EBuffStackPeriodResetOverride.ForceNoRefresh);
		float remainDuration = buff.GetRemainDuration();
		if (remainDuration > 0f)
		{
			buffStackCountPush.Duration = remainDuration;
		}
		CombatNet.Instance.Send(EPushMessageId.BuffStackCountPush, base.Entity, buffStackCountPush, null, null, null);
	}

	// Token: 0x0601C078 RID: 114808 RVA: 0x007CADB0 File Offset: 0x007C8FB0
	protected void BroadcastRemoveBuff(ActiveBuffInternal buff, bool isPrematureRemoval, bool? isServerRequest = null, long? preMessageId = null, [Nullable(2)] string reason = null, long? instigatorId = null)
	{
		if (buff.Id < 0L || !this.NeedBroadcastBuff(buff, false))
		{
			return;
		}
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component != null) ? new long?(component.GetCreatureDataId()) : null;
		RemoveGameplayEffectPush removeGameplayEffectPush = RemoveGameplayEffectPush.Create();
		removeGameplayEffectPush.Handle = buff.Handle;
		removeGameplayEffectPush.EntityId = MathUtils.Instance.NumberToLong(num.GetValueOrDefault());
		removeGameplayEffectPush.IsPrematureRemoval = isPrematureRemoval;
		removeGameplayEffectPush.Reason = (reason ?? "");
		removeGameplayEffectPush.InstigatorId = MathUtils.Instance.NumberToLong(instigatorId.GetValueOrDefault());
		CombatNet.Instance.Send(EPushMessageId.RemoveGameplayEffectPush, base.Entity, removeGameplayEffectPush, preMessageId, null, isServerRequest);
	}

	// Token: 0x0601C079 RID: 114809 RVA: 0x007CAE74 File Offset: 0x007C9074
	protected unsafe override void AddBuffOrder(long buffId, AddBuffParam @params)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "[buffComp] 客户端暂不能给其它玩家添加队伍buff";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", @params.Reason);
		instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601C07A RID: 114810 RVA: 0x007CAF00 File Offset: 0x007C9100
	[NullableContext(2)]
	protected unsafe override void RemoveBuffOrder(long buffId, int stackCount, string reason, long? instigatorId = null)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "[buffComp] 客户端暂不能给其它玩家移除队伍buff";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", reason);
		instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601C07B RID: 114811 RVA: 0x007CAF88 File Offset: 0x007C9188
	protected unsafe override void RefreshBuffDurationOrder(long[] buffIds, [Nullable(2)] string reason)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "[buffComp] 客户端暂不能刷新其他玩家队伍buff的持续时长";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffIds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", reason);
		instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601C07C RID: 114812 RVA: 0x007CB008 File Offset: 0x007C9208
	protected void FormationBuffApplyRequest()
	{
	}

	// Token: 0x0601C07D RID: 114813 RVA: 0x007CB00C File Offset: 0x007C920C
	public override float CalculateDurationExtraRate(long buffId, bool asInstigator)
	{
		float num = base.CalculateDurationExtraRate(buffId, asInstigator);
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		if (currentBuffComponent != null)
		{
			Dictionary<int, ValueTuple<float, float>> dictionary;
			(asInstigator ? currentBuffComponent.InstigatorBuffTimeModifiers : currentBuffComponent.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary);
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, ValueTuple<float, float>> keyValuePair in dictionary)
				{
					float item = keyValuePair.Value.Item2;
					num += item;
				}
			}
		}
		return num;
	}

	// Token: 0x0601C07E RID: 114814 RVA: 0x007CB098 File Offset: 0x007C9298
	public override float CalculatePeriodExtraRate(long buffId, bool asInstigator)
	{
		float num = base.CalculatePeriodExtraRate(buffId, asInstigator);
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		if (currentBuffComponent != null)
		{
			Dictionary<int, ValueTuple<float, float>> dictionary;
			(asInstigator ? currentBuffComponent.InstigatorBuffTimeModifiers : currentBuffComponent.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary);
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, ValueTuple<float, float>> keyValuePair in dictionary)
				{
					float item = keyValuePair.Value.Item1;
					num += item;
				}
			}
		}
		return num;
	}

	// Token: 0x0601C07F RID: 114815 RVA: 0x007CB124 File Offset: 0x007C9324
	public override void AddBuffRefEntityId(long buffId, int entityId)
	{
		HashSet<int> hashSet;
		if (!this.BuffRefEntityIdMap.TryGetValue(buffId, out hashSet))
		{
			hashSet = new HashSet<int>();
			this.BuffRefEntityIdMap[buffId] = hashSet;
		}
		hashSet.Add(entityId);
	}

	// Token: 0x0601C080 RID: 114816 RVA: 0x007CB15C File Offset: 0x007C935C
	public override void RemoveBuffRefEntityId(long buffId, int entityId)
	{
		HashSet<int> hashSet;
		if (!this.BuffRefEntityIdMap.TryGetValue(buffId, out hashSet))
		{
			return;
		}
		hashSet.Remove(entityId);
		if (hashSet.Count == 0)
		{
			this.BuffRefEntityIdMap.Remove(buffId);
		}
	}

	// Token: 0x0601C081 RID: 114817 RVA: 0x007CB198 File Offset: 0x007C9398
	public override bool HasBuffRefEntityId(long buffId)
	{
		HashSet<int> hashSet;
		return this.BuffRefEntityIdMap.TryGetValue(buffId, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x0601C082 RID: 114818 RVA: 0x007CB1C0 File Offset: 0x007C93C0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerBuffComponent playerBuffComponent = (PlayerBuffComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = playerBuffComponent.PlayerId;
		}
		if (base.CanResetComponentProperty("TimeScaleComponent"))
		{
			if (playerBuffComponent.TimeScaleComponent == null)
			{
				this.TimeScaleComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComponent), "TimeScaleComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DelayAddCueBuffIds"))
		{
			if (playerBuffComponent.DelayAddCueBuffIds == null)
			{
				this.DelayAddCueBuffIds = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<long[]>(this.DelayAddCueBuffIds), "DelayAddCueBuffIds"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffRefEntityIdMap"))
		{
			if (playerBuffComponent.BuffRefEntityIdMap == null)
			{
				this.BuffRefEntityIdMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, HashSet<int>>>(this.BuffRefEntityIdMap), "BuffRefEntityIdMap"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DD88 RID: 56712
	public int PlayerId;

	// Token: 0x0400DD89 RID: 56713
	[Nullable(2)]
	public PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400DD8A RID: 56714
	[Nullable(2)]
	private long[] DelayAddCueBuffIds;

	// Token: 0x0400DD8B RID: 56715
	private Dictionary<long, HashSet<int>> BuffRefEntityIdMap = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400DD8C RID: 56716
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyBuffInhibitionChangedStat = Stat.Create("PlayerBuffComponent.OnAnyBuffInhibitionChangedInternal", "", "");

	// Token: 0x0400DD8D RID: 56717
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffAddedStat = Stat.Create("PlayerBuffComponent.OnBuffAdded", "", "");

	// Token: 0x0400DD8E RID: 56718
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffRemovedStat = Stat.Create("PlayerBuffComponent.OnBuffRemoved", "", "");

	// Token: 0x0400DD8F RID: 56719
	[StaticVariableRuleIgnore]
	private static readonly Stat OnPlayerBuffStackIncreasedStat = Stat.Create("PlayerBuffComponent.OnBuffStackIncreased", "", "");

	// Token: 0x0400DD90 RID: 56720
	[StaticVariableRuleIgnore]
	private static readonly Stat OnPlayerBuffStackDecreasedStat = Stat.Create("PlayerBuffComponent.OnBuffStackDecreased", "", "");

	// Token: 0x0400DD91 RID: 56721
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffActiveChangedStat = Stat.Create("PlayerBuffComponent.OnBuffActiveChanged", "", "");

	// Token: 0x0400DD92 RID: 56722
	[StaticVariableRuleIgnore]
	private static readonly Stat BroadcastActivateBuffStat = Stat.Create("PlayerBuffComponent.BroadcastActivateBuff", "", "");
}
