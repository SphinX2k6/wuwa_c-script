using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf.Collections;

// Token: 0x02002802 RID: 10242
[NullableContext(1)]
[Nullable(0)]
public class PlayerBuffComponent : BaseBuffComponent
{
	// Token: 0x06019C69 RID: 105577 RVA: 0x007F1149 File Offset: 0x007EF349
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		base.BuffEffectManager = new ExtraEffectManager(this);
		return true;
	}

	// Token: 0x06019C6A RID: 105578 RVA: 0x007F1158 File Offset: 0x007EF358
	protected override bool OnInit()
	{
		base.OnInit();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		base.SetBuffComponentType(EBuffComponentType.TeamBuffComponent);
		return true;
	}

	// Token: 0x06019C6B RID: 105579 RVA: 0x007F117C File Offset: 0x007EF37C
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

	// Token: 0x06019C6C RID: 105580 RVA: 0x007F11EC File Offset: 0x007EF3EC
	protected override bool OnStart()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		return true;
	}

	// Token: 0x06019C6D RID: 105581 RVA: 0x007F1227 File Offset: 0x007EF427
	protected override void OnActivate()
	{
		this.InitBornBuff();
	}

	// Token: 0x06019C6E RID: 105582 RVA: 0x007F1230 File Offset: 0x007EF430
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

	// Token: 0x06019C6F RID: 105583 RVA: 0x007F12AC File Offset: 0x007EF4AC
	protected override bool OnEnd()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		return true;
	}

	// Token: 0x06019C70 RID: 105584 RVA: 0x007F12E7 File Offset: 0x007EF4E7
	public override bool IsPaused()
	{
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		return currentBuffComponent != null && currentBuffComponent.IsPaused();
	}

	// Token: 0x06019C71 RID: 105585 RVA: 0x007F12FC File Offset: 0x007EF4FC
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

	// Token: 0x06019C72 RID: 105586 RVA: 0x007F1550 File Offset: 0x007EF750
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

	// Token: 0x06019C73 RID: 105587 RVA: 0x007F15B2 File Offset: 0x007EF7B2
	private void OnAnyBuffInhibitionChangedInternal(IActiveBuff buff)
	{
		if (buff.IsActive())
		{
			base.CreateGameplayCueByBuff(buff);
			return;
		}
		base.DestroyGameplayCueByBuff(buff);
	}

	// Token: 0x06019C74 RID: 105588 RVA: 0x007F15CC File Offset: 0x007EF7CC
	public override string GetDebugName()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("player_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PlayerId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06019C75 RID: 105589 RVA: 0x007F1604 File Offset: 0x007EF804
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

	// Token: 0x06019C76 RID: 105590 RVA: 0x007F1680 File Offset: 0x007EF880
	public override float GetTimeScale()
	{
		Entity entity = base.Entity;
		float? num = (entity != null) ? new float?(entity.TimeDilation) : null;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return (num * ((timeScaleComponent != null) ? timeScaleComponent.CurrentTimeScale : 1f)).GetValueOrDefault();
	}

	// Token: 0x06019C77 RID: 105591 RVA: 0x007F16EE File Offset: 0x007EF8EE
	public override float GetLogicTimeScale()
	{
		float timeDilation = base.Entity.TimeDilation;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return timeDilation * ((timeScaleComponent != null) ? timeScaleComponent.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView)) : 1f);
	}

	// Token: 0x06019C78 RID: 105592 RVA: 0x007F1718 File Offset: 0x007EF918
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

	// Token: 0x06019C79 RID: 105593 RVA: 0x007F172B File Offset: 0x007EF92B
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

	// Token: 0x06019C7A RID: 105594 RVA: 0x007F173E File Offset: 0x007EF93E
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

	// Token: 0x06019C7B RID: 105595 RVA: 0x007F1751 File Offset: 0x007EF951
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

	// Token: 0x06019C7C RID: 105596 RVA: 0x007F1764 File Offset: 0x007EF964
	protected override bool CheckAdd(BuffDefinition config, long instigatorId, bool fromServer)
	{
		return this.GetTagComponent() == null || base.CheckAdd(config, instigatorId, fromServer);
	}

	// Token: 0x06019C7D RID: 105597 RVA: 0x007F1779 File Offset: 0x007EF979
	protected override bool CheckActivate(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		return this.GetTagComponent() == null || base.CheckActivate(config, instigator);
	}

	// Token: 0x06019C7E RID: 105598 RVA: 0x007F178D File Offset: 0x007EF98D
	public override bool HasBuffRoutineExpirationLock(long buffId)
	{
		if (this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) <= 0)
		{
			CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
			return ((currentBuffComponent != null) ? currentBuffComponent.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) : 0) > 0;
		}
		return true;
	}

	// Token: 0x06019C7F RID: 105599 RVA: 0x007F17BD File Offset: 0x007EF9BD
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

	// Token: 0x06019C80 RID: 105600 RVA: 0x007F17D0 File Offset: 0x007EF9D0
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

	// Token: 0x06019C81 RID: 105601 RVA: 0x007F180A File Offset: 0x007EFA0A
	[NullableContext(2)]
	public override BaseGameplayCueComponent GetCueComponent()
	{
		return base.Entity.GetComponent<BaseGameplayCueComponent>();
	}

	// Token: 0x06019C82 RID: 105602 RVA: 0x007F1817 File Offset: 0x007EFA17
	public int GetFormationBuffTotalStackById(long buffId, bool onlyActiveBuff = false)
	{
		return base.GetBuffTotalStackById(buffId, onlyActiveBuff);
	}

	// Token: 0x06019C83 RID: 105603 RVA: 0x007F1821 File Offset: 0x007EFA21
	public override int GetBuffTotalStackById(long buffId, bool onlyActiveBuff = false)
	{
		CharacterBuffComponent currentBuffComponent = this.GetCurrentBuffComponent();
		return ((currentBuffComponent != null) ? currentBuffComponent.GetBuffTotalStackById(buffId, onlyActiveBuff) : 0) + base.GetBuffTotalStackById(buffId, onlyActiveBuff);
	}

	// Token: 0x06019C84 RID: 105604 RVA: 0x007F1840 File Offset: 0x007EFA40
	public override bool HasBuffAuthority()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = this.PlayerId;
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x06019C85 RID: 105605 RVA: 0x007F1874 File Offset: 0x007EFA74
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

	// Token: 0x06019C86 RID: 105606 RVA: 0x007F1920 File Offset: 0x007EFB20
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

	// Token: 0x06019C87 RID: 105607 RVA: 0x007F1ACC File Offset: 0x007EFCCC
	protected override void OnBuffRemoved(ActiveBuffInternal buff, bool isPrematureRemoval, [Nullable(2)] string reason, bool? isServerRequest = null, long? preMessageId = null, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		this.BroadcastRemoveBuff(buff, isPrematureRemoval, isServerRequest, preMessageId, reason, instigatorId);
		base.OnBuffRemoved(buff, isPrematureRemoval, reason, isServerRequest, preMessageId, instigatorId);
		base.DestroyGameplayCueByBuff(buff);
	}

	// Token: 0x06019C88 RID: 105608 RVA: 0x007F1AF8 File Offset: 0x007EFCF8
	protected override void OnBuffStackIncreased(ActiveBuffInternal buff, int oldStack, int newStack, long? instigatorId, int level, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId, bool isIterable, bool isServerOrder, [Nullable(2)] string reason, EBuffStackDurationOverride stackDurationRefreshPolicy = EBuffStackDurationOverride.Default, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackIncreased(buff, oldStack, newStack, instigatorId, level, outerStackCount, applyType, preMessageId, duration, serverId, isIterable, isServerOrder, reason, stackDurationRefreshPolicy, stackPeriodResetPolicy);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, false, stackDurationRefreshPolicy, stackPeriodResetPolicy, reason, instigatorId);
	}

	// Token: 0x06019C89 RID: 105609 RVA: 0x007F1B3C File Offset: 0x007EFD3C
	protected override void OnBuffStackDecreased(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, [Nullable(2)] string reason, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackDecreased(buff, oldStack, newStack, isPrematureRemoval, reason, stackPeriodResetPolicy, instigatorId);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, isPrematureRemoval, EBuffStackDurationOverride.Default, stackPeriodResetPolicy, reason, instigatorId);
	}

	// Token: 0x06019C8A RID: 105610 RVA: 0x007F1B70 File Offset: 0x007EFD70
	[NullableContext(2)]
	protected override void OnBuffActiveChanged(ActiveBuffInternal buff, bool isActive, bool? syncedActive = null)
	{
		base.OnBuffActiveChanged(buff, isActive, syncedActive);
	}

	// Token: 0x06019C8B RID: 105611 RVA: 0x007F1B7C File Offset: 0x007EFD7C
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

	// Token: 0x06019C8C RID: 105612 RVA: 0x007F1CFC File Offset: 0x007EFEFC
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

	// Token: 0x06019C8D RID: 105613 RVA: 0x007F1D4C File Offset: 0x007EFF4C
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

	// Token: 0x06019C8E RID: 105614 RVA: 0x007F1EA8 File Offset: 0x007F00A8
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

	// Token: 0x06019C8F RID: 105615 RVA: 0x007F1F18 File Offset: 0x007F0118
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

	// Token: 0x06019C90 RID: 105616 RVA: 0x007F1FC8 File Offset: 0x007F01C8
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

	// Token: 0x06019C91 RID: 105617 RVA: 0x007F208C File Offset: 0x007F028C
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

	// Token: 0x06019C92 RID: 105618 RVA: 0x007F2118 File Offset: 0x007F0318
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

	// Token: 0x06019C93 RID: 105619 RVA: 0x007F21A0 File Offset: 0x007F03A0
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

	// Token: 0x06019C94 RID: 105620 RVA: 0x007F2220 File Offset: 0x007F0420
	protected void FormationBuffApplyRequest()
	{
	}

	// Token: 0x06019C95 RID: 105621 RVA: 0x007F2224 File Offset: 0x007F0424
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

	// Token: 0x06019C96 RID: 105622 RVA: 0x007F22B0 File Offset: 0x007F04B0
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

	// Token: 0x06019C97 RID: 105623 RVA: 0x007F233C File Offset: 0x007F053C
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

	// Token: 0x06019C98 RID: 105624 RVA: 0x007F2374 File Offset: 0x007F0574
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

	// Token: 0x06019C99 RID: 105625 RVA: 0x007F23B0 File Offset: 0x007F05B0
	public override bool HasBuffRefEntityId(long buffId)
	{
		HashSet<int> hashSet;
		return this.BuffRefEntityIdMap.TryGetValue(buffId, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x06019C9A RID: 105626 RVA: 0x007F23D8 File Offset: 0x007F05D8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerBuffComponent playerBuffComponent = (PlayerBuffComponent)componentTemplate;
		this.PlayerId = playerBuffComponent.PlayerId;
		if (playerBuffComponent.TimeScaleComponent == null)
		{
			this.TimeScaleComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComponent), "TimeScaleComponent"))
		{
			return false;
		}
		if (playerBuffComponent.DelayAddCueBuffIds == null)
		{
			this.DelayAddCueBuffIds = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelayAddCueBuffIds), "DelayAddCueBuffIds"))
		{
			return false;
		}
		if (playerBuffComponent.BuffRefEntityIdMap == null)
		{
			this.BuffRefEntityIdMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffRefEntityIdMap), "BuffRefEntityIdMap"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002982 RID: 10626
	// (get) Token: 0x06019C9B RID: 105627 RVA: 0x007F2485 File Offset: 0x007F0685
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002983 RID: 10627
	// (get) Token: 0x06019C9C RID: 105628 RVA: 0x007F2488 File Offset: 0x007F0688
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002984 RID: 10628
	// (get) Token: 0x06019C9D RID: 105629 RVA: 0x007F248B File Offset: 0x007F068B
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002985 RID: 10629
	// (get) Token: 0x06019C9E RID: 105630 RVA: 0x007F248E File Offset: 0x007F068E
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002986 RID: 10630
	// (get) Token: 0x06019C9F RID: 105631 RVA: 0x007F2491 File Offset: 0x007F0691
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002987 RID: 10631
	// (get) Token: 0x06019CA0 RID: 105632 RVA: 0x007F2494 File Offset: 0x007F0694
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002988 RID: 10632
	// (get) Token: 0x06019CA1 RID: 105633 RVA: 0x007F2497 File Offset: 0x007F0697
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002989 RID: 10633
	// (get) Token: 0x06019CA2 RID: 105634 RVA: 0x007F249A File Offset: 0x007F069A
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E22F RID: 57903
	public int PlayerId;

	// Token: 0x0400E230 RID: 57904
	[Nullable(2)]
	public PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400E231 RID: 57905
	[Nullable(2)]
	private long[] DelayAddCueBuffIds;

	// Token: 0x0400E232 RID: 57906
	private Dictionary<long, HashSet<int>> BuffRefEntityIdMap = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400E233 RID: 57907
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyBuffInhibitionChangedStat = Stat.Create("PlayerBuffComponent.OnAnyBuffInhibitionChangedInternal", "", "");

	// Token: 0x0400E234 RID: 57908
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffAddedStat = Stat.Create("PlayerBuffComponent.OnBuffAdded", "", "");

	// Token: 0x0400E235 RID: 57909
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffRemovedStat = Stat.Create("PlayerBuffComponent.OnBuffRemoved", "", "");

	// Token: 0x0400E236 RID: 57910
	[StaticVariableRuleIgnore]
	private static readonly Stat OnPlayerBuffStackIncreasedStat = Stat.Create("PlayerBuffComponent.OnBuffStackIncreased", "", "");

	// Token: 0x0400E237 RID: 57911
	[StaticVariableRuleIgnore]
	private static readonly Stat OnPlayerBuffStackDecreasedStat = Stat.Create("PlayerBuffComponent.OnBuffStackDecreased", "", "");

	// Token: 0x0400E238 RID: 57912
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffActiveChangedStat = Stat.Create("PlayerBuffComponent.OnBuffActiveChanged", "", "");

	// Token: 0x0400E239 RID: 57913
	[StaticVariableRuleIgnore]
	private static readonly Stat BroadcastActivateBuffStat = Stat.Create("PlayerBuffComponent.BroadcastActivateBuff", "", "");
}
