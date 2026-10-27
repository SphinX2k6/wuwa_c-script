using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Protocol;
using Aki.Protocol.BattleDefine;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002EA8 RID: 11944
[NullableContext(1)]
[Nullable(0)]
public class CharacterBuffComponent : BaseBuffComponent
{
	// Token: 0x0601981B RID: 104475 RVA: 0x00695794 File Offset: 0x00693994
	public override string GetDebugName()
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		long num;
		if (creatureDataComponent == null)
		{
			Entity entity = base.Entity;
			num = (long)((entity != null) ? entity.Id : 0);
		}
		else
		{
			num = creatureDataComponent.GetCreatureDataId();
		}
		long num2 = num;
		return num2.ToString() ?? "";
	}

	// Token: 0x0601981C RID: 104476 RVA: 0x006957D6 File Offset: 0x006939D6
	public override Entity GetEntity()
	{
		return base.Entity;
	}

	// Token: 0x0601981D RID: 104477 RVA: 0x006957E0 File Offset: 0x006939E0
	public virtual void AddPauseLock(string key, float timeScale = 0f)
	{
		if (timeScale <= 0f)
		{
			this.PauseLocks.Add(key);
			this.PauseRateLocks.Remove(key);
		}
		else
		{
			this.PauseLocks.Remove(key);
			this.PauseRateLocks[key] = MathUtils.Instance.Clamp(timeScale, 0f, 1f);
		}
		base.RefreshTimeScale();
	}

	// Token: 0x0601981E RID: 104478 RVA: 0x00695845 File Offset: 0x00693A45
	public virtual void RemovePauseLock(string key)
	{
		this.PauseLocks.Remove(key);
		this.PauseRateLocks.Remove(key);
		base.RefreshTimeScale();
	}

	// Token: 0x0601981F RID: 104479 RVA: 0x00695867 File Offset: 0x00693A67
	public override bool IsPaused()
	{
		return this.PauseLocks.Count > 0;
	}

	// Token: 0x06019820 RID: 104480 RVA: 0x00695878 File Offset: 0x00693A78
	private float GetPauseRate()
	{
		float num = 1f;
		foreach (float val in this.PauseRateLocks.Values)
		{
			num = Math.Min(num, val);
		}
		return num;
	}

	// Token: 0x06019821 RID: 104481 RVA: 0x006958D8 File Offset: 0x00693AD8
	public override float GetTimeScale()
	{
		float timeDilation = base.Entity.TimeDilation;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return timeDilation * ((timeScaleComponent != null) ? timeScaleComponent.CurrentTimeScale : 1f) * this.GetPauseRate();
	}

	// Token: 0x06019822 RID: 104482 RVA: 0x00695903 File Offset: 0x00693B03
	public override float GetLogicTimeScale()
	{
		float timeDilation = base.Entity.TimeDilation;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		return timeDilation * ((timeScaleComponent != null) ? timeScaleComponent.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView)) : 1f) * this.GetPauseRate();
	}

	// Token: 0x06019823 RID: 104483 RVA: 0x00695934 File Offset: 0x00693B34
	[NullableContext(2)]
	public override BaseAttributeComponent GetAttributeComponent()
	{
		return this.AttributeComponent;
	}

	// Token: 0x06019824 RID: 104484 RVA: 0x0069593C File Offset: 0x00693B3C
	[NullableContext(2)]
	public override BaseTagComponent GetTagComponent()
	{
		return this.TagComponent;
	}

	// Token: 0x06019825 RID: 104485 RVA: 0x00695944 File Offset: 0x00693B44
	[NullableContext(2)]
	public override BaseSkillComponent GetSkillComponent()
	{
		return base.Entity.GetComponent<BaseSkillComponent>();
	}

	// Token: 0x06019826 RID: 104486 RVA: 0x00695951 File Offset: 0x00693B51
	[NullableContext(2)]
	public override BaseActorComponent GetActorComponent()
	{
		return this.ActorComponent;
	}

	// Token: 0x06019827 RID: 104487 RVA: 0x00695959 File Offset: 0x00693B59
	[NullableContext(2)]
	public override BaseGameplayCueComponent GetCueComponent()
	{
		return this.CueComponent;
	}

	// Token: 0x06019828 RID: 104488 RVA: 0x00695961 File Offset: 0x00693B61
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		base.BuffEffectManager = new ExtraEffectManager(this);
		return true;
	}

	// Token: 0x06019829 RID: 104489 RVA: 0x00695970 File Offset: 0x00693B70
	protected override bool OnInit()
	{
		base.OnInit();
		this.ActorComponent = base.Entity.CheckGetComponent<BaseActorComponent>();
		this.AttributeComponent = base.Entity.CheckGetComponent<BaseAttributeComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.CueComponent = base.Entity.GetComponent<CharacterGameplayCueComponent>();
		this.DeathComponent = base.Entity.GetComponent<BaseDeathComponent>();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		return true;
	}

	// Token: 0x0601982A RID: 104490 RVA: 0x006959EB File Offset: 0x00693BEB
	protected override bool OnStart()
	{
		ExtraEffectManager buffEffectManager = base.BuffEffectManager;
		if (buffEffectManager != null)
		{
			buffEffectManager.Clear();
		}
		return true;
	}

	// Token: 0x0601982B RID: 104491 RVA: 0x00695A00 File Offset: 0x00693C00
	protected override void InitBornBuff()
	{
		Dictionary<string, EntityComponentPb> componentDataMap = this.CreatureDataComponent.ComponentDataMap;
		EntityComponentPb entityComponentPb;
		componentDataMap.TryGetValue("SysBuffComponent", out entityComponentPb);
		RepeatedField<SysBuffInformation> repeatedField;
		if (entityComponentPb == null)
		{
			repeatedField = null;
		}
		else
		{
			SysBuffComponentPb sysBuffComponent = entityComponentPb.SysBuffComponent;
			repeatedField = ((sysBuffComponent != null) ? sysBuffComponent.SysBuffInfos : null);
		}
		RepeatedField<SysBuffInformation> repeatedField2 = repeatedField;
		if (repeatedField2 != null && this.HasBuffAuthority())
		{
			foreach (SysBuffInformation sysBuffInformation in repeatedField2)
			{
				long instigatorId = sysBuffInformation.InstigatorId;
				long? num = (sysBuffInformation.MessageId != 0L) ? new long?(MathUtils.Instance.LongToBigInt(sysBuffInformation.MessageId)) : null;
				long buffId = sysBuffInformation.BuffId;
				long buffId2 = buffId;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = instigatorId;
				addBuffParam.Level = new int?(sysBuffInformation.Level);
				addBuffParam.ApplyType = new ApplyGEType?(sysBuffInformation.ApplyType);
				addBuffParam.PreMessageId = num;
				addBuffParam.Duration = new float?(sysBuffInformation.Duration);
				addBuffParam.IsIterable = new bool?(sysBuffInformation.IsIterable);
				addBuffParam.OuterStackCount = new int?(sysBuffInformation.StackCount);
				addBuffParam.ServerId = new int?(sysBuffInformation.ServerId);
				addBuffParam.IsServerOrder = new bool?(true);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendLiteral("服务端或其它客户端请求添加Buff(缓冲) messageId=");
				defaultInterpolatedStringHandler.AppendFormatted<long?>(num);
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam.BornBuff = new bool?(true);
				this.AddBuffLocal(buffId2, addBuffParam);
			}
		}
		EntityComponentPb entityComponentPb2;
		componentDataMap.TryGetValue("FightBuffComponent", out entityComponentPb2);
		FightBuffComponentPb fightBuffComponentPb = (entityComponentPb2 != null) ? entityComponentPb2.FightBuffComponent : null;
		if (fightBuffComponentPb == null)
		{
			return;
		}
		RepeatedField<BuffEffectCd> listBuffEffectCd = fightBuffComponentPb.ListBuffEffectCd;
		RepeatedField<FightBuffInformation> fightBuffInfos = fightBuffComponentPb.FightBuffInfos;
		if (listBuffEffectCd != null)
		{
			foreach (BuffEffectCd buffEffectCd in listBuffEffectCd)
			{
				long buffId3 = buffEffectCd.BuffId;
				for (int i = 0; i < buffEffectCd.ListCdRemaining.Count; i++)
				{
					this.SetBuffEffectCd(buffId3, i, (float)(buffEffectCd.ListCdRemaining[i] * 1000));
				}
			}
		}
		if (fightBuffInfos != null)
		{
			foreach (FightBuffInformation fightBuffInformation in fightBuffInfos)
			{
				long buffId4 = fightBuffInformation.BuffId;
				long instigatorId2 = fightBuffInformation.InstigatorId;
				int handleId = fightBuffInformation.HandleId;
				long overrideConfigId = 0L;
				if (fightBuffInformation.ConfBuffId != 0L)
				{
					overrideConfigId = fightBuffInformation.ConfBuffId;
				}
				base.AddBuffRemote(buffId4, handleId, overrideConfigId, new AddBuffParam
				{
					Level = new int?(fightBuffInformation.Level),
					InstigatorId = instigatorId2,
					ApplyType = new ApplyGEType?(fightBuffInformation.ApplyType),
					Duration = new float?(fightBuffInformation.Duration),
					RemainDuration = new float?(fightBuffInformation.LeftDuration),
					IsActive = new bool?(fightBuffInformation.IsActive),
					ServerId = new int?(fightBuffInformation.ServerId),
					OuterStackCount = new int?(fightBuffInformation.StackCount),
					Reason = "服务器通过通知FightBuffComponent恢复Buff",
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
		RepeatedField<long> needClientApplyBuffIds = fightBuffComponentPb.NeedClientApplyBuffIds;
		long value = MathUtils.Instance.LongToBigInt(fightBuffComponentPb.NeedClientApplyBuffIdsMessageId);
		if (needClientApplyBuffIds != null)
		{
			foreach (long buffId5 in needClientApplyBuffIds)
			{
				this.AddBuff(buffId5, new AddBuffParam
				{
					InstigatorId = base.CreatureDataId,
					Reason = "客户端出生buff",
					PreMessageId = new long?(value)
				});
			}
		}
	}

	// Token: 0x0601982C RID: 104492 RVA: 0x00695E68 File Offset: 0x00694068
	protected override bool OnClear()
	{
		this.TriggerMap.Clear();
		List<ActiveBuffInternal> list = new List<ActiveBuffInternal>(this.BuffContainer.Values);
		this.PauseLocks.Clear();
		this.PauseRateLocks.Clear();
		base.OnClear();
		foreach (ActiveBuffInternal activeBuffInternal in list)
		{
			activeBuffInternal.Destroy();
		}
		return true;
	}

	// Token: 0x0601982D RID: 104493 RVA: 0x00695EEC File Offset: 0x006940EC
	protected override void OnActivate()
	{
		foreach (IActiveBuff buff in base.GetAllBuffs())
		{
			base.CreateGameplayCueByBuff(buff);
		}
		this.CueInited = true;
		this.InitBornBuff();
	}

	// Token: 0x0601982E RID: 104494 RVA: 0x00695F26 File Offset: 0x00694126
	protected override void OnAnyBuffInhibitionChanged(IActiveBuff buff)
	{
		if (!this.CueInited)
		{
			return;
		}
		base.OnAnyBuffInhibitionChanged(buff);
	}

	// Token: 0x0601982F RID: 104495 RVA: 0x00695F38 File Offset: 0x00694138
	public override bool HasBuffAuthority()
	{
		if (this.CreatureDataComponent != null)
		{
			if (this.CreatureDataComponent.GetEntityType() == EEntityType.Monster)
			{
				BaseDeathComponent deathComponent = this.DeathComponent;
				if (deathComponent != null && deathComponent.IsDead())
				{
					return true;
				}
			}
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetSummonerPlayerId()) : null;
			int? id = PlayerInfoModel.Instance.GetId();
			int? num2 = num;
			return id.GetValueOrDefault() == num2.GetValueOrDefault() & id != null == (num2 != null);
		}
		return true;
	}

	// Token: 0x06019830 RID: 104496 RVA: 0x00695FC0 File Offset: 0x006941C0
	protected override bool NeedAddBuffOrder(long buffId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		if (buffDefinition == null)
		{
			return false;
		}
		if (buffDefinition.FormationPolicy == EBuffFormationPolicy.FormationBuff)
		{
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			if (creatureDataComponent != null && creatureDataComponent.IsMonster())
			{
				CreatureDataComponent creatureDataComponent2 = this.CreatureDataComponent;
				if (creatureDataComponent2 != null && creatureDataComponent2.GetSummonerPlayerId() == 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06019831 RID: 104497 RVA: 0x00696018 File Offset: 0x00694218
	public unsafe void AddBuffWithServerId(long buffId, int level, int addTimes, int serverId, string reason)
	{
		if (buffId <= 0L)
		{
			return;
		}
		for (int i = 0; i < addTimes; i++)
		{
			int num = this.AddBuffLocal(buffId, new AddBuffParam
			{
				InstigatorId = base.CreatureDataId,
				Level = new int?(level),
				Duration = new float?((float)-1),
				ServerId = new int?(serverId),
				Reason = reason
			});
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, reason);
			if (num == -1)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity = base.Entity;
				string message = "系统buff添加失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("serverId", serverId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("说明", (buffDefinition != null) ? buffDefinition.Desc : null);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
	}

	// Token: 0x06019832 RID: 104498 RVA: 0x00696138 File Offset: 0x00694338
	public void RemoveBuffByTagName(string tagName, [Nullable(2)] string reason = null)
	{
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		this.RemoveBuffByTag(new int?(tagIdByName), reason, null);
	}

	// Token: 0x06019833 RID: 104499 RVA: 0x00696164 File Offset: 0x00694364
	[NullableContext(2)]
	public void RemoveBuffByTag(int? tagId, string reason = null, long? instigatorId = null)
	{
		if (tagId == null)
		{
			return;
		}
		if (this.HasBuffAuthority())
		{
			this.RemoveBuffByTagLocal(tagId.Value, reason, instigatorId);
			return;
		}
		OrderRemoveBuffByTagsRequest orderRemoveBuffByTagsRequest = OrderRemoveBuffByTagsRequest.Create();
		orderRemoveBuffByTagsRequest.TagIds.Add(tagId.Value);
		orderRemoveBuffByTagsRequest.InstigatorId = MathUtils.Instance.NumberToLong(instigatorId.GetValueOrDefault());
		CombatNet.Instance.Call(ERequestMessageId.OrderRemoveBuffByTagsRequest, base.Entity, orderRemoveBuffByTagsRequest, delegate(IMessage msg)
		{
			OrderRemoveBuffByTagsResponse orderRemoveBuffByTagsResponse = (OrderRemoveBuffByTagsResponse)msg;
			if (orderRemoveBuffByTagsResponse != null && orderRemoveBuffByTagsResponse.ErrorCode == ErrorCode.ErrSceneEntityNotExist)
			{
				string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId.Value);
				foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
				{
					if (activeBuffInternal.Config.GrantedTags != null)
					{
						bool flag = false;
						int[] grantedTags = activeBuffInternal.Config.GrantedTags;
						for (int i = 0; i < grantedTags.Length; i++)
						{
							if (GameplayTagUtils.IsChildTag(grantedTags[i], tagId.Value))
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							this.RemoveBuffInner(activeBuffInternal.Handle, -1, true, reason ?? ("移除tag " + nameByTagId), null, new bool?(false), instigatorId);
						}
					}
				}
			}
		}, null, null, null, null);
	}

	// Token: 0x06019834 RID: 104500 RVA: 0x00696248 File Offset: 0x00694448
	public void RemoveAllBuffs(string reason)
	{
		if (this.HasBuffAuthority())
		{
			using (List<int>.Enumerator enumerator = new List<int>(this.BuffContainer.Keys).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int handle = enumerator.Current;
					this.RemoveBuffByHandle(handle, -1, reason, null, null, null);
				}
				return;
			}
		}
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			if (activeBuffInternal != null && activeBuffInternal.IsValid())
			{
				this.RemoveBuffOrder(activeBuffInternal.Id, -1, reason, null);
			}
		}
	}

	// Token: 0x06019835 RID: 104501 RVA: 0x00696334 File Offset: 0x00694534
	public void RemoveAllBuffsByInstigator(CharacterBuffComponent instigator, string reason)
	{
		long? num = (instigator != null) ? new long?(instigator.CreatureDataId) : null;
		List<int> list = new List<int>(this.BuffContainer.Keys);
		if (this.HasBuffAuthority())
		{
			using (List<int>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int handle = enumerator.Current;
					IActiveBuff buffByHandle = base.GetBuffByHandle(handle);
					bool flag;
					if (buffByHandle == null)
					{
						flag = (num == null);
					}
					else
					{
						long? num2 = buffByHandle.InstigatorId;
						long? num3 = num;
						flag = (num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null));
					}
					if (flag)
					{
						this.RemoveBuffByHandle(handle, -1, reason, null, null, null);
					}
				}
				return;
			}
		}
		foreach (int handle2 in list)
		{
			IActiveBuff buffByHandle2 = base.GetBuffByHandle(handle2);
			bool flag2;
			if (buffByHandle2 == null)
			{
				flag2 = (num == null);
			}
			else
			{
				long? num3 = buffByHandle2.InstigatorId;
				long? num2 = num;
				flag2 = (num3.GetValueOrDefault() == num2.GetValueOrDefault() & num3 != null == (num2 != null));
			}
			if (flag2)
			{
				this.RemoveBuffOrder(buffByHandle2.Id, -1, reason, null);
			}
		}
	}

	// Token: 0x06019836 RID: 104502 RVA: 0x006964BC File Offset: 0x006946BC
	public void RemoveAllDurationBuffs(string reason)
	{
		List<int> list = new List<int>();
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			if (activeBuffInternal.Config.DurationPolicy == EBuffDurationType.HasDuration && activeBuffInternal.Config.DeadRemove)
			{
				list.Add(activeBuffInternal.Handle);
			}
		}
		foreach (int handle in list)
		{
			this.RemoveBuffByHandle(handle, -1, reason, null, null, null);
		}
	}

	// Token: 0x06019837 RID: 104503 RVA: 0x0069659C File Offset: 0x0069479C
	public override int? GetBuffLevel(long buffId)
	{
		RoleGrowComponent component = base.Entity.GetComponent<RoleGrowComponent>();
		int? num = (component != null) ? new int?(component.GetSkillLevelByBuffId(buffId)) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				return num;
			}
		}
		CharacterVisionComponent component2 = base.Entity.GetComponent<CharacterVisionComponent>();
		int? num4 = (component2 != null) ? new int?(component2.GetVisionLevelByBuffId(buffId)) : null;
		if (num4 != null)
		{
			int? num2 = num4;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				return num4;
			}
		}
		return null;
	}

	// Token: 0x06019838 RID: 104504 RVA: 0x00696644 File Offset: 0x00694844
	protected override void OnBuffAdded(ActiveBuffInternal buff, int? stackCount, ApplyGEType applyType, long? preMessageId, float? duration, bool? isActive, int serverId, bool fromServer, bool isIterable, bool isServerRequest, string reason)
	{
		if (buff == null)
		{
			return;
		}
		this.BroadcastAddBuff(buff, applyType, isServerRequest, fromServer, reason);
		BuffDefinition config = buff.Config;
		base.OnBuffAdded(buff, stackCount, applyType, preMessageId, duration, isActive, serverId, fromServer, isIterable, isServerRequest, reason);
		if (config.RemoveBuffWithTags != null && config.RemoveBuffWithTags.Length != 0)
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
				if (this.HasBuffAuthority())
				{
					this.RemoveBuffByTag(new int?(value), reason2, null);
				}
				this.TagComponent.RemoveTag(new int?(value));
			}
		}
		if (isIterable)
		{
			this.ShareApplyBuffInner(buff, stackCount, applyType, buff.MessageId, duration, serverId);
		}
	}

	// Token: 0x06019839 RID: 104505 RVA: 0x00696754 File Offset: 0x00694954
	protected virtual void ShareApplyBuffInner(ActiveBuffInternal newBuff, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId)
	{
		if (!this.HasBuffAuthority())
		{
			return;
		}
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetSummonerId()) : null;
		if (num != null)
		{
			BuffDefinition config = newBuff.Config;
			if (config != null && config.FormationPolicy == EBuffFormationPolicy.SharedToSummoner)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
				CharacterBuffComponent characterBuffComponent;
				if (entity == null)
				{
					characterBuffComponent = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					characterBuffComponent = ((entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null);
				}
				CharacterBuffComponent characterBuffComponent2 = characterBuffComponent;
				if (characterBuffComponent2 != null)
				{
					long id = newBuff.Id;
					int handle = newBuff.Handle;
					BaseBuffComponent baseBuffComponent = characterBuffComponent2;
					long buffId = id;
					AddBuffParam addBuffParam = new AddBuffParam();
					addBuffParam.InstigatorId = newBuff.InstigatorId.GetValueOrDefault();
					addBuffParam.Level = new int?(newBuff.Level);
					addBuffParam.OuterStackCount = outerStackCount;
					addBuffParam.ApplyType = new ApplyGEType?(applyType);
					addBuffParam.PreMessageId = preMessageId;
					addBuffParam.Duration = duration;
					addBuffParam.ServerId = new int?(serverId);
					addBuffParam.IsIterable = new bool?(false);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
					defaultInterpolatedStringHandler.AppendLiteral("因为buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(id);
					defaultInterpolatedStringHandler.AppendLiteral("(handle=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
					defaultInterpolatedStringHandler.AppendLiteral(")的队伍共享机制导致的buff添加");
					addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
					baseBuffComponent.AddBuffLocal(buffId, addBuffParam);
				}
			}
		}
	}

	// Token: 0x0601983A RID: 104506 RVA: 0x006968AC File Offset: 0x00694AAC
	protected override void OnBuffRemoved(ActiveBuffInternal buff, bool isPrematureRemoval, [Nullable(2)] string reason, bool? isServerRequest = null, long? preMessageId = null, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		this.BroadcastRemoveBuff(buff, isPrematureRemoval, isServerRequest, preMessageId, reason, instigatorId);
		base.OnBuffRemoved(buff, isPrematureRemoval, reason, isServerRequest, preMessageId, instigatorId);
		if (this.CueInited)
		{
			base.DestroyGameplayCueByBuff(buff);
		}
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

	// Token: 0x0601983B RID: 104507 RVA: 0x00696924 File Offset: 0x00694B24
	protected override void OnBuffStackIncreased(ActiveBuffInternal buff, int oldStack, int newStack, long? instigatorId, int level, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId, bool isIterable, bool isServerOrder, [Nullable(2)] string reason, EBuffStackDurationOverride stackDurationRefreshPolicy = EBuffStackDurationOverride.Default, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackIncreased(buff, oldStack, newStack, instigatorId, level, outerStackCount, applyType, preMessageId, duration, serverId, isIterable, isServerOrder, reason, stackDurationRefreshPolicy, stackPeriodResetPolicy);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, false, stackDurationRefreshPolicy, stackPeriodResetPolicy, reason, instigatorId);
		if (this.HasBuffAuthority() && isIterable)
		{
			this.ShareApplyBuffInner(buff, outerStackCount, applyType, buff.MessageId, duration, serverId);
		}
	}

	// Token: 0x0601983C RID: 104508 RVA: 0x00696988 File Offset: 0x00694B88
	protected override void OnBuffStackDecreased(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, [Nullable(2)] string reason, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		base.OnBuffStackDecreased(buff, oldStack, newStack, isPrematureRemoval, reason, stackPeriodResetPolicy, instigatorId);
		this.BroadcastBuffStackChanged(buff, oldStack, newStack, isPrematureRemoval, EBuffStackDurationOverride.Default, stackPeriodResetPolicy, reason, instigatorId);
	}

	// Token: 0x0601983D RID: 104509 RVA: 0x006969BC File Offset: 0x00694BBC
	[NullableContext(2)]
	protected override void OnBuffActiveChanged(ActiveBuffInternal buff, bool isActive, bool? syncedActive = null)
	{
		base.OnBuffActiveChanged(buff, isActive, syncedActive);
	}

	// Token: 0x0601983E RID: 104510 RVA: 0x006969C8 File Offset: 0x00694BC8
	protected void BroadcastAddBuff(ActiveBuffInternal buff, ApplyGEType applyType, bool isServerRequest, bool fromServer, string reason)
	{
		if (buff.Id < 0L || !this.NeedBroadcastBuff(buff, fromServer))
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
		applyGameplayEffectPush.Reason = reason;
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

	// Token: 0x0601983F RID: 104511 RVA: 0x00696B28 File Offset: 0x00694D28
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

	// Token: 0x06019840 RID: 104512 RVA: 0x00696B98 File Offset: 0x00694D98
	protected void BroadcastBuffStackChanged(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, EBuffStackDurationOverride stackDurationRefreshPolicy, EBuffStackPeriodResetOverride stackPeriodResetPolicy, [Nullable(2)] string reason, long? instigatorId = null)
	{
		if (buff == null || buff.Id < 0L || !this.NeedBroadcastBuff(buff, false))
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
		buffStackCountPush.Reason = (reason ?? "");
		CombatNet.Instance.Send(EPushMessageId.BuffStackCountPush, base.Entity, buffStackCountPush, null, null, null);
	}

	// Token: 0x06019841 RID: 104513 RVA: 0x00696C5C File Offset: 0x00694E5C
	protected void BroadcastRemoveBuff(ActiveBuffInternal buff, bool isPrematureRemoval, bool? isServerRequest = null, long? preMessageId = null, [Nullable(2)] string reason = null, long? instigatorId = null)
	{
		if (buff.Id < 0L || !this.NeedBroadcastBuff(buff, false))
		{
			return;
		}
		RemoveGameplayEffectPush removeGameplayEffectPush = RemoveGameplayEffectPush.Create();
		removeGameplayEffectPush.Handle = buff.Handle;
		removeGameplayEffectPush.EntityId = MathUtils.Instance.NumberToLong(base.CreatureDataId);
		removeGameplayEffectPush.IsPrematureRemoval = isPrematureRemoval;
		removeGameplayEffectPush.Reason = (reason ?? "");
		removeGameplayEffectPush.InstigatorId = MathUtils.Instance.NumberToLong(instigatorId.GetValueOrDefault());
		CombatNet.Instance.Send(EPushMessageId.RemoveGameplayEffectPush, base.Entity, removeGameplayEffectPush, preMessageId, null, isServerRequest);
	}

	// Token: 0x06019842 RID: 104514 RVA: 0x00696CF8 File Offset: 0x00694EF8
	[NullableContext(2)]
	protected override void RemoveBuffOrder(long buffId, int stackCount, string reason, long? instigatorId = null)
	{
		if (buffId <= 0L)
		{
			return;
		}
		BuffController.Instance.GetBuffDefinition(buffId, reason);
		OrderRemoveBuffRequest orderRemoveBuffRequest = OrderRemoveBuffRequest.Create();
		orderRemoveBuffRequest.Id = MathUtils.Instance.NumberToLong(buffId);
		orderRemoveBuffRequest.StackCount = stackCount;
		orderRemoveBuffRequest.Reason = (reason ?? "");
		orderRemoveBuffRequest.InstigatorId = MathUtils.Instance.NumberToLong(instigatorId.GetValueOrDefault());
		this.WaitRemoveBuffResponse[buffId] = this.WaitRemoveBuffResponse.GetValueOrDefault(buffId, 0) + 1;
		CombatNet.Instance.Call(ERequestMessageId.OrderRemoveBuffRequest, base.Entity, orderRemoveBuffRequest, delegate(IMessage msg)
		{
			OrderRemoveBuffResponse orderRemoveBuffResponse = (OrderRemoveBuffResponse)msg;
			int num = this.WaitRemoveBuffResponse.GetValueOrDefault(buffId, 0) - 1;
			if (num <= 0)
			{
				this.WaitRemoveBuffResponse.Remove(buffId);
			}
			else
			{
				this.WaitRemoveBuffResponse[buffId] = num;
			}
			if (orderRemoveBuffResponse != null && orderRemoveBuffResponse.ErrorCode == ErrorCode.ErrSceneEntityNotExist)
			{
				ActiveBuffInternal buffById = this.GetBuffById(buffId);
				if (buffById != null)
				{
					this.RemoveBuffInner(buffById.Handle, stackCount, true, reason, null, new bool?(false), instigatorId);
				}
			}
		}, null, null, null, null);
	}

	// Token: 0x06019843 RID: 104515 RVA: 0x00696E18 File Offset: 0x00695018
	protected override void AddBuffOrder(long buffId, AddBuffParam param)
	{
		if (buffId <= 0L)
		{
			return;
		}
		this.PendingAddBuff[buffId] = Time.Instance.Now;
		OrderApplyBuffRequest orderApplyBuffRequest = OrderApplyBuffRequest.Create();
		orderApplyBuffRequest.Id = MathUtils.Instance.NumberToLong(buffId);
		orderApplyBuffRequest.Level = param.Level.GetValueOrDefault(1);
		orderApplyBuffRequest.StackCount = param.OuterStackCount.GetValueOrDefault();
		orderApplyBuffRequest.InstigatorId = MathUtils.Instance.NumberToLong(param.InstigatorId);
		orderApplyBuffRequest.ApplyType = param.ApplyType.GetValueOrDefault();
		if (param.Duration != null)
		{
			orderApplyBuffRequest.Duration = param.Duration.Value;
		}
		orderApplyBuffRequest.ServerId = param.ServerId.GetValueOrDefault();
		orderApplyBuffRequest.IsIterable = param.IsIterable.GetValueOrDefault(true);
		orderApplyBuffRequest.Reason = (param.Reason ?? "");
		if (param.BulletMessageId != null)
		{
			orderApplyBuffRequest.TransferContextId = new TransferContextId
			{
				BulletContextId = MathUtils.Instance.BigIntToLong(param.BulletMessageId.Value)
			};
		}
		CombatNet.Instance.Call(ERequestMessageId.OrderApplyBuffRequest, base.Entity, orderApplyBuffRequest, delegate(IMessage msg)
		{
			OrderApplyBuffResponse orderApplyBuffResponse = (OrderApplyBuffResponse)msg;
			this.PendingAddBuff.Remove(buffId);
			if (orderApplyBuffResponse != null && orderApplyBuffResponse.ErrorCode == ErrorCode.ErrSceneEntityNotExist)
			{
				this.AddBuffInner(buffId, BuffController.Instance.GetBuffDefinition(buffId, param.Reason), new long?(param.InstigatorId), param.Level.GetValueOrDefault(1), param.OuterStackCount, new ApplyGEType?(param.ApplyType.GetValueOrDefault()), param.PreMessageId, null, param.Duration, null, param.ServerId.GetValueOrDefault(), param.Reason, false, param.IsIterable.GetValueOrDefault(true), false, null, param.BulletMessageId, null);
			}
			if ((orderApplyBuffResponse == null || orderApplyBuffResponse.ErrorCode > ErrorCode.Success) && param.InstigatorId != 0L)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(param.InstigatorId);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, param.Reason);
				if (worldEntity != null && buffDefinition != null)
				{
					SceneTeamController instance = SceneTeamController.Instance;
					Entity target = worldEntity;
					EAbilityEventName name = EAbilityEventName.AddBuffFailure;
					long buffId2 = buffId;
					long buffId3 = buffId;
					Entity entity2 = this.Entity;
					Entity arg = worldEntity;
					int arg2;
					if (param.OuterStackCount != null)
					{
						int? outerStackCount = param.OuterStackCount;
						int num = 0;
						if (outerStackCount.GetValueOrDefault() > num & outerStackCount != null)
						{
							arg2 = param.OuterStackCount.Value;
							goto IL_20B;
						}
					}
					arg2 = buffDefinition.DefaultStackCount;
					IL_20B:
					instance.EmitAbilityEvent<long, Entity, Entity, int, long?>(target, name, buffId2, buffId3, entity2, arg, arg2, param.BulletMessageId);
				}
			}
		}, param.PreMessageId, null, null, null);
	}

	// Token: 0x06019844 RID: 104516 RVA: 0x00696FF8 File Offset: 0x006951F8
	protected override void RefreshBuffDurationOrder(long[] buffIds, [Nullable(2)] string reason)
	{
		RefreshBuffDurationPush refreshBuffDurationPush = RefreshBuffDurationPush.Create();
		refreshBuffDurationPush.BuffIds.AddRange(buffIds);
		CombatNet.Instance.Send(EPushMessageId.RefreshBuffDurationPush, base.Entity, refreshBuffDurationPush, null, null, null);
	}

	// Token: 0x06019845 RID: 104517 RVA: 0x0069704C File Offset: 0x0069524C
	public void UpdateSysGrowBuff(Dictionary<EAttributeType, float> growList)
	{
		if (this.SystemGrowBuffHandle >= 0)
		{
			base.RemoveBuffByHandleLocal(this.SystemGrowBuffHandle, -1, "更新系统成长值", null, null, null);
		}
		BuffDefinition buffDefinition = BuffController.Instance.CreateDynamicBuffRef();
		buffDefinition.StackingType = EBuffStackingType.None;
		buffDefinition.DurationPolicy = EBuffDurationType.Infinite;
		buffDefinition.Modifiers = Array.Empty<IBuffModifierData>();
		buffDefinition.Desc = "系统成长buff";
		List<IBuffModifierData> list = new List<IBuffModifierData>();
		foreach (KeyValuePair<EAttributeType, float> keyValuePair in growList)
		{
			EAttributeType key = keyValuePair.Key;
			float value = keyValuePair.Value;
			if (value != 0f)
			{
				list.Add(new BuffModifierData
				{
					AttributeId = key,
					Value1 = new float[]
					{
						value
					},
					Value2 = new float[1],
					CalculationPolicy = new int[1]
				});
			}
		}
		buffDefinition.Modifiers = list.ToArray();
		this.SystemGrowBuffHandle = this.AddBuffInner(-3L, buffDefinition, new long?(base.CreatureDataId), 1, null, new ApplyGEType?(ApplyGEType.Common), null, null, ActiveBuffConfigs.USE_INTERNAL_DURATION, null, -1, "更新系统成长值", false, true, false, null, null, null);
	}

	// Token: 0x06019846 RID: 104518 RVA: 0x006971E0 File Offset: 0x006953E0
	public int AddAttributeRateModifierLocal(EAttributeType attributeId, float rate, string reason)
	{
		if (rate == 0f)
		{
			return -1;
		}
		BuffDefinition buffDefinition = BuffController.Instance.CreateDynamicBuffRef();
		buffDefinition.StackingType = EBuffStackingType.None;
		buffDefinition.DurationPolicy = EBuffDurationType.Infinite;
		buffDefinition.Modifiers = new IBuffModifierData[]
		{
			new BuffModifierData
			{
				AttributeId = attributeId,
				Value1 = new float[]
				{
					rate * 10000f
				},
				Value2 = new float[1],
				CalculationPolicy = new int[]
				{
					1
				}
			}
		};
		buffDefinition.Desc = reason;
		return this.AddBuffInner(-3L, buffDefinition, new long?(base.CreatureDataId), 1, null, new ApplyGEType?(ApplyGEType.Common), null, null, ActiveBuffConfigs.USE_INTERNAL_DURATION, null, -1, reason, false, true, false, null, null, null);
	}

	// Token: 0x06019847 RID: 104519 RVA: 0x006972D0 File Offset: 0x006954D0
	[NullableContext(2)]
	public int AddTagWithReturnHandle(IReadOnlyList<int> tags, float duration = -1f)
	{
		if (tags == null || tags.Count <= 0)
		{
			return -1;
		}
		BuffDefinition buffDefinition = BuffController.Instance.CreateDynamicBuffRef();
		buffDefinition.GrantedTags = tags.ToArray<int>();
		buffDefinition.StackingType = EBuffStackingType.None;
		buffDefinition.DurationPolicy = EBuffDurationType.Infinite;
		if (duration > 0f)
		{
			buffDefinition.DurationPolicy = EBuffDurationType.HasDuration;
			buffDefinition.DurationCalculationPolicy = new int[1];
			buffDefinition.DurationMagnitude = new float[]
			{
				duration
			};
		}
		buffDefinition.Desc = "AddTagWithReturnHandle";
		return this.AddBuffInner(-3L, buffDefinition, new long?(base.CreatureDataId), 1, null, new ApplyGEType?(ApplyGEType.Common), null, null, new float?(duration), null, -1, "添加tag", false, true, false, null, null, null);
	}

	// Token: 0x06019848 RID: 104520 RVA: 0x006973B0 File Offset: 0x006955B0
	public override void SetBuffEffectCd(long buffId, int index, float remainCd)
	{
		base.SetBuffEffectCd(buffId, index, remainCd);
		ActiveBuffInternal buffById = base.GetBuffById(buffId);
		int num = (buffById != null) ? buffById.Handle : -1;
		if (this.HasBuffAuthority() && num != -1 && (double)remainCd > 10000.0)
		{
			BuffEffectPush buffEffectPush = BuffEffectPush.Create();
			buffEffectPush.HandleId = num;
			buffEffectPush.Index = index;
			CombatNet.Instance.Send(EPushMessageId.BuffEffectPush, base.Entity, buffEffectPush, null, null, null);
		}
	}

	// Token: 0x06019849 RID: 104521 RVA: 0x0069743C File Offset: 0x0069563C
	public string GetDebugBuffString(string filterStr = "")
	{
		string text = "";
		List<string> list = new List<string>();
		foreach (object obj in Regex.Matches(filterStr, "[0-9]+"))
		{
			Match match = (Match)obj;
			list.Add(match.Value ?? "");
		}
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			string text2 = activeBuffInternal.Id.ToString();
			if (list.Count > 0)
			{
				bool flag = false;
				foreach (string value in list)
				{
					if (text2.StartsWith(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 9);
			defaultInterpolatedStringHandler.AppendFormatted((activeBuffInternal.Id == -3L) ? "系统buff" : ((this.HasBuffAuthority() ? "RemoteBuff_" : "Buff_") + text2));
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(this.BuffGarbageSet.Contains(activeBuffInternal.Handle) ? "销毁" : (activeBuffInternal.IsActive() ? "激活" : "失效"));
			defaultInterpolatedStringHandler.AppendLiteral(")  handle: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuffInternal.Handle);
			defaultInterpolatedStringHandler.AppendLiteral(",  层数: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuffInternal.StackCount);
			defaultInterpolatedStringHandler.AppendLiteral(",  等级: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuffInternal.Level);
			defaultInterpolatedStringHandler.AppendLiteral(" \n    施加者: ");
			CharacterActorComponent instigatorActorComponent = activeBuffInternal.GetInstigatorActorComponent();
			defaultInterpolatedStringHandler.AppendFormatted((instigatorActorComponent != null) ? instigatorActorComponent.Actor.GetName() : null);
			defaultInterpolatedStringHandler.AppendLiteral(",  时长: ");
			string value2;
			if (activeBuffInternal.Duration >= 0f)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler2.AppendFormatted<float>(activeBuffInternal.GetRemainDuration(), "F1");
				defaultInterpolatedStringHandler2.AppendLiteral("/");
				defaultInterpolatedStringHandler2.AppendFormatted<float>(activeBuffInternal.Duration, "F1");
				value2 = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			else
			{
				value2 = "无限";
			}
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",  ");
			string value3;
			if (activeBuffInternal.Period <= 0f)
			{
				value3 = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("周期: ");
				float? num;
				defaultInterpolatedStringHandler2.AppendFormatted((activeBuffInternal.GetRemainPeriod() != null) ? num.GetValueOrDefault().ToString("F1") : null);
				defaultInterpolatedStringHandler2.AppendLiteral("/");
				defaultInterpolatedStringHandler2.AppendFormatted<float>(activeBuffInternal.Period, "F1");
				value3 = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("\n    说明: ");
			BuffDefinition config = activeBuffInternal.Config;
			defaultInterpolatedStringHandler.AppendFormatted((config != null) ? config.Desc : null);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (activeBuffInternal.Config.GrantedTags != null)
			{
				foreach (int tagId in activeBuffInternal.Config.GrantedTags)
				{
					text3 = text3 + "    +附加标签 " + GameplayTagUtils.GetNameByTagId(tagId) + "\n";
				}
			}
			foreach (BuffEffect buffEffect in base.BuffEffectManager.GetEffectsByHandle(activeBuffInternal.Handle))
			{
				string str = text3;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
				defaultInterpolatedStringHandler.AppendLiteral("    +持续效果 ");
				defaultInterpolatedStringHandler.AppendFormatted(buffEffect.GetDebugString());
				defaultInterpolatedStringHandler.AppendLiteral("(cd:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(base.GetBuffEffectCd(activeBuffInternal.Id, buffEffect.Index) / 1000.0, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("s");
				defaultInterpolatedStringHandler.AppendFormatted(base.GetTargetCdDebugStr(activeBuffInternal.Id, buffEffect.Index));
				defaultInterpolatedStringHandler.AppendLiteral(")\n");
				text3 = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ExtraEffectParameters[] effectInfos = activeBuffInternal.Config.EffectInfos;
			for (int i = 0; i < effectInfos.Length; i++)
			{
				BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
				if (executionEffect != null)
				{
					text3 = text3 + "    +周期效果 " + executionEffect.GetDebugString() + "\n";
				}
			}
			text = text + text3 + "\n";
		}
		return text;
	}

	// Token: 0x0601984A RID: 104522 RVA: 0x00697968 File Offset: 0x00695B68
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterBuffComponent characterBuffComponent = (CharacterBuffComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (characterBuffComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (characterBuffComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (characterBuffComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TimeScaleComponent"))
		{
			if (characterBuffComponent.TimeScaleComponent == null)
			{
				this.TimeScaleComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComponent), "TimeScaleComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CueComponent"))
		{
			if (characterBuffComponent.CueComponent == null)
			{
				this.CueComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterGameplayCueComponent>(this.CueComponent), "CueComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PauseLocks"))
		{
			if (characterBuffComponent.PauseLocks == null)
			{
				this.PauseLocks = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.PauseLocks), "PauseLocks"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PauseRateLocks") && characterBuffComponent.PauseRateLocks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, float>>(this.PauseRateLocks), "PauseRateLocks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CueInited"))
		{
			this.CueInited = characterBuffComponent.CueInited;
		}
		if (base.CanResetComponentProperty("SystemGrowBuffHandle"))
		{
			this.SystemGrowBuffHandle = characterBuffComponent.SystemGrowBuffHandle;
		}
		return true;
	}

	// Token: 0x0400BE59 RID: 48729
	private const double NO_BROADCAST_CD_THRESHOLD = 10000.0;

	// Token: 0x0400BE5A RID: 48730
	[Nullable(2)]
	public BaseActorComponent ActorComponent;

	// Token: 0x0400BE5B RID: 48731
	[Nullable(2)]
	public BaseAttributeComponent AttributeComponent;

	// Token: 0x0400BE5C RID: 48732
	[Nullable(2)]
	public BaseTagComponent TagComponent;

	// Token: 0x0400BE5D RID: 48733
	[Nullable(2)]
	public PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400BE5E RID: 48734
	[Nullable(2)]
	protected CharacterGameplayCueComponent CueComponent;

	// Token: 0x0400BE5F RID: 48735
	protected HashSet<string> PauseLocks = new HashSet<string>();

	// Token: 0x0400BE60 RID: 48736
	protected readonly Dictionary<string, float> PauseRateLocks = new Dictionary<string, float>();

	// Token: 0x0400BE61 RID: 48737
	[StaticVariableRuleIgnore]
	private static readonly Stat AddBuffBornStat = Stat.Create("AddBuff_Born", "", "");

	// Token: 0x0400BE62 RID: 48738
	private bool CueInited;

	// Token: 0x0400BE63 RID: 48739
	[StaticVariableRuleIgnore]
	private static readonly Stat OnCharacterBuffAddedStat = Stat.Create("CharacterBuffComponent.OnBuffAdded", "", "");

	// Token: 0x0400BE64 RID: 48740
	[StaticVariableRuleIgnore]
	private static readonly Stat OnCharacterBuffRemovedStat = Stat.Create("CharacterBuffComponent.OnBuffRemoved", "", "");

	// Token: 0x0400BE65 RID: 48741
	[StaticVariableRuleIgnore]
	private static readonly Stat OnCharacterBuffStackIncreasedStat = Stat.Create("CharacterBuffComponent.OnBuffStackIncreased", "", "");

	// Token: 0x0400BE66 RID: 48742
	[StaticVariableRuleIgnore]
	private static readonly Stat OnCharacterBuffStackDecreasedStat = Stat.Create("CharacterBuffComponent.OnBuffStackDecreased", "", "");

	// Token: 0x0400BE67 RID: 48743
	[StaticVariableRuleIgnore]
	private static readonly Stat OnCharacterBuffActiveChangedStat = Stat.Create("CharacterBuffComponent.OnBuffActiveChanged", "", "");

	// Token: 0x0400BE68 RID: 48744
	[StaticVariableRuleIgnore]
	private static readonly Stat BroadcastActivateBuffStat = Stat.Create("CharacterBuffComponent.BroadcastActivateBuff", "", "");

	// Token: 0x0400BE69 RID: 48745
	private int SystemGrowBuffHandle = -1;

	// Token: 0x0400BE6A RID: 48746
	[StaticVariableRuleIgnore]
	private static readonly Stat AddBuffSysGrowStat = Stat.Create("AddBuff_SysGrow", "", "");

	// Token: 0x0400BE6B RID: 48747
	[StaticVariableRuleIgnore]
	private static readonly Stat AttributeRateModifierStat = Stat.Create("AddBuff_AttributeRateModifier", "", "");

	// Token: 0x0400BE6C RID: 48748
	[StaticVariableRuleIgnore]
	private static readonly Stat AddTagStat = Stat.Create("AddBuff_AddTag", "", "");
}
