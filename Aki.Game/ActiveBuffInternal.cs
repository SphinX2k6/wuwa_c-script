using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CombatMessage;

// Token: 0x02002E7E RID: 11902
[NullableContext(1)]
[Nullable(0)]
public class ActiveBuffInternal : IActiveBuff, IStaticVariableResetter
{
	// Token: 0x06019721 RID: 104225 RVA: 0x00692168 File Offset: 0x00690368
	static ActiveBuffInternal()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActiveBuffInternal.CreateStaticDefaultValue), new Action(ActiveBuffInternal.ResetStaticDefaultValue));
	}

	// Token: 0x06019722 RID: 104226 RVA: 0x00692244 File Offset: 0x00690444
	private ActiveBuffInternal(BuffDefinition configInternal)
	{
		this.ConfigInternal = configInternal;
	}

	// Token: 0x17002300 RID: 8960
	// (get) Token: 0x06019723 RID: 104227 RVA: 0x006922FC File Offset: 0x006904FC
	public static List<ActiveBuffInternal> BuffPool
	{
		get
		{
			return ActiveBuffInternal._buffPool;
		}
	}

	// Token: 0x06019724 RID: 104228 RVA: 0x00692304 File Offset: 0x00690504
	public static ActiveBuffInternal AllocBuff(BuffDefinition config, int handle, long? instigatorId, BaseBuffComponent ownerBuffComp, int serverId, long? preMessageId, long? messageId, int level, int stackCount, float? duration, ApplyGEType applyType, long originalBuffId)
	{
		ActiveBuffInternal activeBuffInternal = null;
		if (ActiveBuffInternal.BuffPool.Count > 0)
		{
			activeBuffInternal = ActiveBuffInternal.BuffPool[ActiveBuffInternal.BuffPool.Count - 1];
			ActiveBuffInternal.BuffPool.RemoveAt(ActiveBuffInternal.BuffPool.Count - 1);
		}
		if (activeBuffInternal == null)
		{
			activeBuffInternal = new ActiveBuffInternal(config);
		}
		activeBuffInternal.Init(config, handle, instigatorId, ownerBuffComp, serverId, preMessageId, messageId, level, stackCount, duration, applyType, originalBuffId);
		return activeBuffInternal;
	}

	// Token: 0x06019725 RID: 104229 RVA: 0x00692373 File Offset: 0x00690573
	public static void ReleaseBuff(ActiveBuffInternal buff)
	{
		if (buff.IsValid())
		{
			buff.Destroy();
		}
		if (buff != null && ActiveBuffInternal.BuffPool.Count < 100)
		{
			ActiveBuffInternal.BuffPool.Add(buff);
		}
	}

	// Token: 0x06019726 RID: 104230 RVA: 0x006923A0 File Offset: 0x006905A0
	private ActiveBuffInternal Init(BuffDefinition config, int handle, long? instigatorId, BaseBuffComponent ownerBuffComp, int serverId, long? preMessageId, long? messageId, int level, int stackCount, float? duration, ApplyGEType applyType, long originalBuffId)
	{
		this.ConfigInternal = config;
		this.HandleInternal = handle;
		this.InstigatorIdInternal = instigatorId.GetValueOrDefault();
		this.OwnerBuffCompInternal = ownerBuffComp;
		this.OwnerDebugName = (((ownerBuffComp != null) ? ownerBuffComp.GetDebugName() : null) ?? "unknown");
		this.RemoveBuffWhenTimeout = (applyType == ApplyGEType.Common && ownerBuffComp.NeedCheck(config));
		this.ServerIdInternal = serverId;
		this._messageId = (messageId ?? CombatMessageModel.Instance.GenMessageId());
		this._preMessageId = preMessageId;
		this.LevelInternal = level;
		this.StackCountInternal = stackCount;
		this.IsActiveInternal = false;
		this.PrepareToDestroy = false;
		Dictionary<int, HashSet<int>> executionStateData = this.ExecutionStateData;
		if (executionStateData != null)
		{
			executionStateData.Clear();
		}
		this.ExecutionStateData = null;
		this.ConfigOverrideListenerId = null;
		this.OriginalBuffIdInternal = originalBuffId;
		this.StackLimitCount = config.StackLimitCount;
		this.InnerCreateTimestamp = this.GetCurrentTime();
		this.SetDuration(duration);
		this.SetPeriod();
		if (this.IsInstantBuff())
		{
			foreach (IBuffModifierData buffModifierData in this.Config.Modifiers)
			{
				EAttributeType attributeId = buffModifierData.AttributeId;
				if (CharacterAttributeTypes.stateAttributeIds.Contains(attributeId))
				{
					this.SetStateModifier(buffModifierData);
				}
				else
				{
					this.SetNonStateModifier(buffModifierData);
				}
			}
		}
		else
		{
			this.ResetModifiers();
		}
		return this;
	}

	// Token: 0x06019727 RID: 104231 RVA: 0x00692500 File Offset: 0x00690700
	public void Destroy()
	{
		if (this.IsActive())
		{
			IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
			BaseTagComponent baseTagComponent;
			if (ownerBuffComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity exactEntity = ownerBuffComponent.GetExactEntity();
				baseTagComponent = ((exactEntity != null) ? exactEntity.CheckGetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 != null && baseTagComponent2.Valid)
			{
				foreach (int tagId in this.Config.GrantedTags ?? Array.Empty<int>())
				{
					baseTagComponent2.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, tagId, -this.StackCount);
				}
			}
		}
		this.PrepareToDestroy = true;
		this.ClearDurationTimer();
		this.ClearPeriodCallback();
		this.ClearModifiers();
		this.ClearBuffTimeScale();
		Dictionary<int, HashSet<int>> executionStateData = this.ExecutionStateData;
		if (executionStateData != null)
		{
			executionStateData.Clear();
		}
		this.ExecutionStateData = null;
		this.StackCountInternal = 0;
	}

	// Token: 0x06019728 RID: 104232 RVA: 0x006925B8 File Offset: 0x006907B8
	public bool IsValid()
	{
		if (!this.PrepareToDestroy)
		{
			IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
			bool? flag;
			if (ownerBuffComponent == null)
			{
				flag = null;
			}
			else
			{
				Entity exactEntity = ownerBuffComponent.GetExactEntity();
				flag = ((exactEntity != null) ? new bool?(exactEntity.Valid) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}
		return false;
	}

	// Token: 0x17002301 RID: 8961
	// (get) Token: 0x06019729 RID: 104233 RVA: 0x0069260A File Offset: 0x0069080A
	public BuffDefinition Config
	{
		get
		{
			return this.ConfigInternal;
		}
	}

	// Token: 0x17002302 RID: 8962
	// (get) Token: 0x0601972A RID: 104234 RVA: 0x00692612 File Offset: 0x00690812
	public int Handle
	{
		get
		{
			return this.HandleInternal;
		}
	}

	// Token: 0x17002303 RID: 8963
	// (get) Token: 0x0601972B RID: 104235 RVA: 0x0069261A File Offset: 0x0069081A
	public long? PreMessageId
	{
		get
		{
			return this._preMessageId;
		}
	}

	// Token: 0x17002304 RID: 8964
	// (get) Token: 0x0601972C RID: 104236 RVA: 0x00692622 File Offset: 0x00690822
	public long? MessageId
	{
		get
		{
			return new long?(this._messageId);
		}
	}

	// Token: 0x0601972D RID: 104237 RVA: 0x0069262F File Offset: 0x0069082F
	[NullableContext(2)]
	public Entity GetOwner()
	{
		BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
		if (ownerBuffCompInternal == null)
		{
			return null;
		}
		return ownerBuffCompInternal.Entity;
	}

	// Token: 0x0601972E RID: 104238 RVA: 0x00692642 File Offset: 0x00690842
	public string GetOwnerDebugName()
	{
		return this.OwnerDebugName;
	}

	// Token: 0x0601972F RID: 104239 RVA: 0x0069264A File Offset: 0x0069084A
	[NullableContext(2)]
	public IBuffComponent GetOwnerBuffComponent()
	{
		return this.OwnerBuffCompInternal;
	}

	// Token: 0x17002305 RID: 8965
	// (get) Token: 0x06019730 RID: 104240 RVA: 0x00692652 File Offset: 0x00690852
	public long? InstigatorId
	{
		get
		{
			return new long?(this.InstigatorIdInternal);
		}
	}

	// Token: 0x06019731 RID: 104241 RVA: 0x00692660 File Offset: 0x00690860
	[NullableContext(2)]
	public Entity GetInstigator()
	{
		if (this.InstigatorId == null)
		{
			return null;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.InstigatorId.Value);
		if (entity == null)
		{
			return null;
		}
		return entity.Entity;
	}

	// Token: 0x06019732 RID: 104242 RVA: 0x006926A4 File Offset: 0x006908A4
	[NullableContext(2)]
	public CharacterBuffComponent GetInstigatorBuffComponent()
	{
		if (this.InstigatorId == null)
		{
			return null;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.InstigatorId.Value);
		if (entity == null)
		{
			return null;
		}
		WorldEntity entity2 = entity.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.GetComponent<CharacterBuffComponent>();
	}

	// Token: 0x06019733 RID: 104243 RVA: 0x006926F4 File Offset: 0x006908F4
	[NullableContext(2)]
	public CharacterActorComponent GetInstigatorActorComponent()
	{
		if (this.InstigatorId == null)
		{
			return null;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.InstigatorId.Value);
		if (entity == null)
		{
			return null;
		}
		WorldEntity entity2 = entity.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.GetComponent<CharacterActorComponent>();
	}

	// Token: 0x06019734 RID: 104244 RVA: 0x00692744 File Offset: 0x00690944
	[NullableContext(2)]
	public BaseAttributeComponent GetInstigatorAttributeSet()
	{
		if (this.InstigatorId == null)
		{
			return null;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.InstigatorId.Value);
		if (entity == null)
		{
			return null;
		}
		WorldEntity entity2 = entity.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.GetComponent<BaseAttributeComponent>();
	}

	// Token: 0x06019735 RID: 104245 RVA: 0x00692791 File Offset: 0x00690991
	[NullableContext(2)]
	public BaseAttributeComponent GetOwnerAttributeSet()
	{
		BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
		if (ownerBuffCompInternal == null)
		{
			return null;
		}
		Entity entity = ownerBuffCompInternal.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseAttributeComponent>();
	}

	// Token: 0x17002306 RID: 8966
	// (get) Token: 0x06019736 RID: 104246 RVA: 0x006927AF File Offset: 0x006909AF
	public long Id
	{
		get
		{
			return this.OriginalBuffIdInternal;
		}
	}

	// Token: 0x17002307 RID: 8967
	// (get) Token: 0x06019737 RID: 104247 RVA: 0x006927B7 File Offset: 0x006909B7
	public int ServerId
	{
		get
		{
			return this.ServerIdInternal;
		}
	}

	// Token: 0x17002308 RID: 8968
	// (get) Token: 0x06019738 RID: 104248 RVA: 0x006927BF File Offset: 0x006909BF
	public long OriginalBuffId
	{
		get
		{
			return this.OriginalBuffIdInternal;
		}
	}

	// Token: 0x06019739 RID: 104249 RVA: 0x006927C7 File Offset: 0x006909C7
	public int? GetConfigOverrideListenerId()
	{
		return this.ConfigOverrideListenerId;
	}

	// Token: 0x0601973A RID: 104250 RVA: 0x006927CF File Offset: 0x006909CF
	public void SetConfigOverrideListenerId(int listenerId)
	{
		this.ConfigOverrideListenerId = new int?(listenerId);
	}

	// Token: 0x0601973B RID: 104251 RVA: 0x006927E0 File Offset: 0x006909E0
	public void OnConfigOverrideChanged()
	{
		BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
		if (ownerBuffCompInternal == null)
		{
			return;
		}
		ownerBuffCompInternal.RemoveBuffByHandle(this.Handle, -1, "配置覆盖条件变化", null, null, null);
	}

	// Token: 0x0601973C RID: 104252 RVA: 0x00692825 File Offset: 0x00690A25
	public bool IsInstantBuff()
	{
		return this.Config.DurationPolicy == EBuffDurationType.Instant;
	}

	// Token: 0x0601973D RID: 104253 RVA: 0x00692835 File Offset: 0x00690A35
	public void SetBuffTimeScale(int buffHandle, float timeScale)
	{
		this.BuffTimeScaleMap[buffHandle] = timeScale;
		this.RefreshBuffTimeScale();
	}

	// Token: 0x0601973E RID: 104254 RVA: 0x0069284A File Offset: 0x00690A4A
	public void RemoveBuffTimeScale(int buffHandle)
	{
		if (this.BuffTimeScaleMap.ContainsKey(buffHandle))
		{
			this.BuffTimeScaleMap.Remove(buffHandle);
			this.RefreshBuffTimeScale();
		}
	}

	// Token: 0x0601973F RID: 104255 RVA: 0x00692870 File Offset: 0x00690A70
	private void RefreshBuffTimeScale()
	{
		float num = 1f;
		foreach (float num2 in this.BuffTimeScaleMap.Values)
		{
			num *= num2;
		}
		if (num != this.BuffTimeScale)
		{
			this.BuffTimeScale = num;
			BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
			float newSpeed = (ownerBuffCompInternal != null) ? ownerBuffCompInternal.GetTimeScale() : 1f;
			BaseBuffComponent ownerBuffCompInternal2 = this.OwnerBuffCompInternal;
			bool forcePaused = ownerBuffCompInternal2 != null && ownerBuffCompInternal2.IsPaused();
			this.OnTimeScaleChanged(newSpeed, forcePaused);
		}
	}

	// Token: 0x06019740 RID: 104256 RVA: 0x00692910 File Offset: 0x00690B10
	private void ClearBuffTimeScale()
	{
		this.BuffTimeScale = 1f;
		this.BuffTimeScaleMap.Clear();
	}

	// Token: 0x17002309 RID: 8969
	// (get) Token: 0x06019741 RID: 104257 RVA: 0x00692928 File Offset: 0x00690B28
	public float Duration
	{
		get
		{
			return this.DurationInternal;
		}
	}

	// Token: 0x06019742 RID: 104258 RVA: 0x00692930 File Offset: 0x00690B30
	private void ClearDurationTimer()
	{
		if (this.DurationTimer != null)
		{
			if (TimerSystem.Instance.Has(this.DurationTimer))
			{
				TimerSystem.Instance.Remove(this.DurationTimer);
			}
			this.DurationTimer = null;
		}
	}

	// Token: 0x06019743 RID: 104259 RVA: 0x00692964 File Offset: 0x00690B64
	private void ResetDurationTimer(float remainingTime)
	{
		this.ClearDurationTimer();
		if (this.DurationInternal <= 0f)
		{
			return;
		}
		this.LastRemainingDuration = remainingTime;
		this.LastTimestamp = this.GetCurrentTime();
		if (this.RemoveBuffWhenTimeout && this.Timescale > 0f)
		{
			float num = this.LastRemainingDuration / this.Timescale * 1000f;
			Stat resetDurationTimerStat = this.ResetDurationTimerStat;
			this.DurationTimer = ((num >= 20f) ? TimerSystem.Instance.Delay(new TTimerAction(this.DurationCallback), num, resetDurationTimerStat, null, false, 1f) : TimerSystem.Instance.Next(new TTimerAction(this.DurationCallback), resetDurationTimerStat, null));
		}
	}

	// Token: 0x1700230A RID: 8970
	// (get) Token: 0x06019744 RID: 104260 RVA: 0x00692A0F File Offset: 0x00690C0F
	public float CreateTimestamp
	{
		get
		{
			return this.InnerCreateTimestamp;
		}
	}

	// Token: 0x06019745 RID: 104261 RVA: 0x00692A17 File Offset: 0x00690C17
	protected float GetCurrentTime()
	{
		return (float)Time.Instance.Now;
	}

	// Token: 0x06019746 RID: 104262 RVA: 0x00692A24 File Offset: 0x00690C24
	public unsafe void SetDuration(float? duration = null)
	{
		BuffDefinition config = this.Config;
		float num;
		if (config.DurationPolicy == EBuffDurationType.Infinite)
		{
			num = -1f;
		}
		else if (duration != null)
		{
			num = duration.Value;
		}
		else if (config.DurationMagnitude.Length == 0 || config.DurationCalculationPolicy.Length == 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity owner = this.GetOwner();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(76, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Buff 配置为hasDuration 但未配置DurationMagnitude或DurationCalculationPolicy, 强制将时间设为");
			defaultInterpolatedStringHandler.AppendFormatted<float>(0.034f);
			string message = defaultInterpolatedStringHandler.ToStringAndClear();
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BuffId", this.Id);
			instance.Error(flag, owner, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			num = 0.034f;
		}
		else
		{
			float levelValue = AbilityUtils.GetLevelValue<float>(this.Config.DurationMagnitude, this.Level, 0f);
			BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
			float num2 = (ownerBuffCompInternal != null) ? ownerBuffCompInternal.CalculateDurationRate(this.Id, this.GetInstigatorBuffComponent()) : 1f;
			int[] durationCalculationPolicy = config.DurationCalculationPolicy;
			int? num3 = (durationCalculationPolicy != null) ? new int?(durationCalculationPolicy[0]) : null;
			if (num3 != null)
			{
				int valueOrDefault = num3.GetValueOrDefault();
				if (valueOrDefault != 0 && valueOrDefault == 1)
				{
					if (durationCalculationPolicy.Length < 4)
					{
						CombatLog instance2 = CombatLog.Instance;
						CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
						Entity owner2 = this.GetOwner();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Buff 配置为hasDuration 但未配置DurationMagnitude或DurationCalculationPolicy, 将被重设为");
						defaultInterpolatedStringHandler.AppendFormatted<float>(0.034f);
						string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", this.Handle);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
						string item = "持有者";
						BaseBuffComponent ownerBuffCompInternal2 = this.OwnerBuffCompInternal;
						ptr = new ValueTuple<string, object>(item, (ownerBuffCompInternal2 != null) ? ownerBuffCompInternal2.GetDebugName() : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("释放者", this.InstigatorId);
						instance2.Error(flag2, owner2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						num = 0.034f;
						goto IL_376;
					}
					float levelValue2 = AbilityUtils.GetLevelValue<float>(config.DurationMagnitude2, this.Level, 0f);
					int attrId = durationCalculationPolicy[1];
					EBuffAttributeCaptureSource ebuffAttributeCaptureSource = (EBuffAttributeCaptureSource)durationCalculationPolicy[2];
					EAttributeBasedFloatCalculationType attrCalcPolicy = (EAttributeBasedFloatCalculationType)durationCalculationPolicy[3];
					BaseAttributeComponent baseAttributeComponent = (ebuffAttributeCaptureSource == EBuffAttributeCaptureSource.Instigator) ? this.GetInstigatorAttributeSet() : this.GetOwnerAttributeSet();
					if (baseAttributeComponent == null)
					{
						CombatLog instance3 = CombatLog.Instance;
						CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Buff;
						Entity owner3 = this.GetOwner();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Buff 找不到周期计算属性来源, 周期将被重设为");
						defaultInterpolatedStringHandler.AppendFormatted<float>(0.034f);
						string message3 = defaultInterpolatedStringHandler.ToStringAndClear();
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("BuffId", this.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("handle", this.Handle);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
						string item2 = "持有者";
						BaseBuffComponent ownerBuffCompInternal3 = this.OwnerBuffCompInternal;
						ptr2 = new ValueTuple<string, object>(item2, (ownerBuffCompInternal3 != null) ? ownerBuffCompInternal3.GetDebugName() : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("释放者", this.InstigatorId);
						instance3.Error(flag3, owner3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
						num = 0.034f;
						goto IL_376;
					}
					num = Math.Max((AbilityUtils.GetAttrValue(baseAttributeComponent, (EAttributeType)attrId, attrCalcPolicy) * levelValue * 0.0001f + levelValue2) * num2, 0.034f);
					goto IL_376;
				}
			}
			num = levelValue * num2;
		}
		IL_376:
		this.DurationInternal = num;
		this.ResetDurationTimer(num);
	}

	// Token: 0x06019747 RID: 104263 RVA: 0x00692DB5 File Offset: 0x00690FB5
	public void SetRemainDuration(float remainDuration)
	{
		if (this.Config.DurationPolicy != EBuffDurationType.HasDuration)
		{
			return;
		}
		this.ResetDurationTimer((remainDuration > 0f) ? remainDuration : 0.034f);
	}

	// Token: 0x06019748 RID: 104264 RVA: 0x00692DDC File Offset: 0x00690FDC
	public float GetRemainDuration()
	{
		if (!this.IsValid())
		{
			return 0f;
		}
		BuffDefinition config = this.Config;
		EBuffDurationType? ebuffDurationType = (config != null) ? new EBuffDurationType?(config.DurationPolicy) : null;
		if (ebuffDurationType != null)
		{
			EBuffDurationType valueOrDefault = ebuffDurationType.GetValueOrDefault();
			if (valueOrDefault == EBuffDurationType.Instant)
			{
				return 0f;
			}
			if (valueOrDefault == EBuffDurationType.Infinite)
			{
				return -1f;
			}
		}
		float num = (this.GetCurrentTime() - this.LastTimestamp) * this.Timescale / 1000f;
		if (this.DurationInternal >= 0f)
		{
			return Math.Max(this.LastRemainingDuration - num, 0f);
		}
		return -1f;
	}

	// Token: 0x06019749 RID: 104265 RVA: 0x00692E7C File Offset: 0x0069107C
	public HashSet<int> GetOrCreateExecutionState(int index)
	{
		if (this.ExecutionStateData == null)
		{
			this.ExecutionStateData = new Dictionary<int, HashSet<int>>();
		}
		HashSet<int> hashSet;
		if (!this.ExecutionStateData.TryGetValue(index, out hashSet))
		{
			hashSet = new HashSet<int>();
			this.ExecutionStateData[index] = hashSet;
		}
		return hashSet;
	}

	// Token: 0x0601974A RID: 104266 RVA: 0x00692EC0 File Offset: 0x006910C0
	protected void RefreshPeriodInternal()
	{
		this.PeriodInternal = this.Config.Period;
		if (this.PeriodInternal > 0f)
		{
			BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
			float num = (ownerBuffCompInternal != null) ? ownerBuffCompInternal.CalculatePeriodRate(this.Id, this.GetInstigatorBuffComponent()) : 1f;
			this.PeriodInternal *= num;
			if (this.Config.HasBuffPeriodExecution)
			{
				if (this.PeriodInternal < 0.2f)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
					Entity owner = this.GetOwner();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
					defaultInterpolatedStringHandler.AppendLiteral("目前限制带周期型额外效果的Buff周期最短为");
					defaultInterpolatedStringHandler.AppendFormatted<float>(0.2f);
					defaultInterpolatedStringHandler.AppendLiteral("，配置周期");
					defaultInterpolatedStringHandler.AppendFormatted<float>(this.PeriodInternal);
					defaultInterpolatedStringHandler.AppendLiteral("，已强制修改周期");
					string message = defaultInterpolatedStringHandler.ToStringAndClear();
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BuffId", this.Id);
					instance.Error(flag, owner, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.PeriodInternal = 0.2f;
					return;
				}
			}
			else if (this.PeriodInternal < 0.034f)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
				Entity owner2 = this.GetOwner();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("目前限制Buff周期最短为");
				defaultInterpolatedStringHandler.AppendFormatted<float>(0.034f);
				defaultInterpolatedStringHandler.AppendLiteral("，配置周期");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.PeriodInternal);
				defaultInterpolatedStringHandler.AppendLiteral("，已强制修改周期");
				string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BuffId", this.Id);
				instance2.Error(flag2, owner2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.PeriodInternal = 0.034f;
			}
		}
	}

	// Token: 0x0601974B RID: 104267 RVA: 0x00693060 File Offset: 0x00691260
	protected bool SetPeriod()
	{
		this.RefreshPeriodInternal();
		this.ResetPeriodTimer(this.PeriodInternal);
		return true;
	}

	// Token: 0x1700230B RID: 8971
	// (get) Token: 0x0601974C RID: 104268 RVA: 0x00693075 File Offset: 0x00691275
	public float Period
	{
		get
		{
			return this.PeriodInternal;
		}
	}

	// Token: 0x0601974D RID: 104269 RVA: 0x00693080 File Offset: 0x00691280
	public void OnTimeScaleChanged(float newSpeed, bool forcePaused)
	{
		if (forcePaused)
		{
			newSpeed = 0f;
		}
		else if (!this.Config.DurationAffectedByBulletTime)
		{
			IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
			newSpeed = ((ownerBuffComponent != null) ? ownerBuffComponent.GetLogicTimeScale() : 1f);
		}
		else
		{
			bool flag = false;
			foreach (ExtraEffectParameters extraEffectParameters in this.Config.EffectInfos)
			{
				if (extraEffectParameters.ExtraEffectId == EExtraEffectId.ModifyLife || extraEffectParameters.ExtraEffectId == EExtraEffectId.PeriodicExtraEffect || extraEffectParameters.ExtraEffectId == EExtraEffectId.SetTimeScale)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
				Entity owner = this.GetOwner();
				string message = "带额外效果4、5、17的buff不应受子弹顿帧影响";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.Id);
				instance.Warn(flag2, owner, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Entity owner2 = this.GetOwner();
				newSpeed = ((owner2 != null) ? owner2.TimeDilation : 1f);
			}
		}
		newSpeed *= this.BuffTimeScale;
		if (newSpeed == this.Timescale)
		{
			return;
		}
		float currentTime = this.GetCurrentTime();
		float timescale = this.Timescale;
		this.Timescale = newSpeed;
		if (this.DurationInternal > 0f)
		{
			float num = (currentTime - this.LastTimestamp) * timescale / 1000f;
			float remainingTime = this.LastRemainingDuration - num;
			this.ResetDurationTimer(remainingTime);
		}
		if (this.PeriodInternal > 0f)
		{
			float num2 = (currentTime - this.PeriodUpdateTimestamp) * timescale / 1000f;
			float remainingTime2 = this.LastRemainingPeriod - num2;
			this.ResetPeriodTimer(remainingTime2);
		}
	}

	// Token: 0x0601974E RID: 104270 RVA: 0x006931F0 File Offset: 0x006913F0
	protected void DurationCallback(float delta)
	{
		if (!this.IsValid())
		{
			return;
		}
		IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
		if (ownerBuffComponent == null)
		{
			return;
		}
		ownerBuffComponent.RemoveBuffWhenTimeout(this);
	}

	// Token: 0x0601974F RID: 104271 RVA: 0x00693218 File Offset: 0x00691418
	private void ClearPeriodCallback()
	{
		if (this.PeriodTimer != null)
		{
			if (TimerSystem.Instance.Has(this.PeriodTimer))
			{
				TimerSystem.Instance.Remove(this.PeriodTimer);
			}
			this.PeriodTimer = null;
		}
	}

	// Token: 0x06019750 RID: 104272 RVA: 0x0069324C File Offset: 0x0069144C
	public void ResetPeriodTimer(float remainingTime)
	{
		this.ClearPeriodCallback();
		if (this.PeriodInternal <= 0f)
		{
			return;
		}
		this.LastRemainingPeriod = remainingTime;
		this.PeriodUpdateTimestamp = this.GetCurrentTime();
		if (this.Timescale > 0f)
		{
			float num = this.LastRemainingPeriod / this.Timescale * 1000f;
			Stat resetPeriodTimerStat = this.ResetPeriodTimerStat;
			this.PeriodTimer = ((num >= 20f) ? TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.PeriodCallback();
			}, num, resetPeriodTimerStat, null, false, 1f) : TimerSystem.Instance.Next(delegate(float delta)
			{
				this.PeriodCallback();
			}, resetPeriodTimerStat, null));
		}
	}

	// Token: 0x06019751 RID: 104273 RVA: 0x006932F0 File Offset: 0x006914F0
	private void PeriodCallback()
	{
		if (!this.IsValid())
		{
			return;
		}
		float periodInternal = this.PeriodInternal;
		float value = this.GetRemainPeriod().Value;
		int num = (int)Math.Floor((double)(1f - value / periodInternal));
		float remainingTime = (value % periodInternal + periodInternal) % periodInternal;
		this.RefreshPeriodInternal();
		if (!this.IsActive())
		{
			this.ResetPeriodTimer(remainingTime);
			return;
		}
		this.ResetPeriodTimer(remainingTime);
		IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
		for (int i = 0; i < num; i++)
		{
			if (ownerBuffComponent != null)
			{
				ownerBuffComponent.ApplyPeriodExecution(this);
			}
		}
	}

	// Token: 0x06019752 RID: 104274 RVA: 0x00693378 File Offset: 0x00691578
	public float? GetRemainPeriod()
	{
		float num = (this.GetCurrentTime() - this.PeriodUpdateTimestamp) * this.Timescale;
		if (this.PeriodInternal < 0f)
		{
			return null;
		}
		return new float?(this.LastRemainingPeriod - num / 1000f);
	}

	// Token: 0x06019753 RID: 104275 RVA: 0x006933C4 File Offset: 0x006915C4
	public bool IsActive()
	{
		return this.IsActiveInternal;
	}

	// Token: 0x06019754 RID: 104276 RVA: 0x006933CC File Offset: 0x006915CC
	public unsafe bool SetActivate(bool isActive)
	{
		if (this.IsActiveInternal == isActive)
		{
			return false;
		}
		this.IsActiveInternal = isActive;
		IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
		BaseTagComponent baseTagComponent;
		if (ownerBuffComponent == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity exactEntity = ownerBuffComponent.GetExactEntity();
			baseTagComponent = ((exactEntity != null) ? exactEntity.CheckGetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity owner = this.GetOwner();
			string message = "buff更改激活状态时无法获取到持有者";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.Handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", this.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "持有者";
			BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
			ptr = new ValueTuple<string, object>(item, (ownerBuffCompInternal != null) ? ownerBuffCompInternal.GetDebugName() : null);
			instance.Error(flag, owner, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		if (isActive)
		{
			this.ResetModifiers();
			foreach (int tagId in this.Config.GrantedTags ?? Array.Empty<int>())
			{
				if (GameplayTagUtils.GetGameplayTagById(tagId) != null)
				{
					baseTagComponent2.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, tagId, this.StackCount);
				}
			}
			if (this.PeriodInternal > 0f)
			{
				EBuffPeriodicInhibitionPolicy periodicInhibitionPolicy = this.Config.PeriodicInhibitionPolicy;
				if (periodicInhibitionPolicy != EBuffPeriodicInhibitionPolicy.Reset)
				{
					if (periodicInhibitionPolicy == EBuffPeriodicInhibitionPolicy.ResetAndExecute)
					{
						this.ResetPeriodTimer(0.02f);
					}
				}
				else
				{
					this.ResetPeriodTimer(this.PeriodInternal);
				}
			}
		}
		else
		{
			this.ClearModifiers();
			foreach (int tagId2 in this.Config.GrantedTags ?? Array.Empty<int>())
			{
				if (GameplayTagUtils.GetGameplayTagById(tagId2) != null)
				{
					baseTagComponent2.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, tagId2, -this.StackCount);
				}
			}
		}
		return true;
	}

	// Token: 0x1700230C RID: 8972
	// (get) Token: 0x06019755 RID: 104277 RVA: 0x00693597 File Offset: 0x00691797
	public int StackCount
	{
		get
		{
			return this.StackCountInternal;
		}
	}

	// Token: 0x06019756 RID: 104278 RVA: 0x006935A0 File Offset: 0x006917A0
	public unsafe void SetStackCount(int newStack, EBuffStackPeriodResetOverride stackPeriodResetPolicy)
	{
		BuffDefinition config = this.Config;
		int stackCountInternal = this.StackCountInternal;
		this.StackCountInternal = newStack;
		IBuffComponent ownerBuffComponent = this.GetOwnerBuffComponent();
		BaseTagComponent baseTagComponent;
		if (ownerBuffComponent == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity exactEntity = ownerBuffComponent.GetExactEntity();
			baseTagComponent = ((exactEntity != null) ? exactEntity.CheckGetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity owner = this.GetOwner();
			string message = "buff更改层数时无法获取到持有者";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.Handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", this.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "持有者";
			BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
			ptr = new ValueTuple<string, object>(item, (ownerBuffCompInternal != null) ? ownerBuffCompInternal.GetDebugName() : null);
			instance.Error(flag, owner, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (stackPeriodResetPolicy == EBuffStackPeriodResetOverride.Default && config.StackPeriodResetPolicy == EBuffStackPeriodResetPolicy.Refresh)
		{
			this.SetPeriod();
		}
		this.ResetModifiers();
		if (this.IsActiveInternal)
		{
			foreach (int tagId in config.GrantedTags ?? Array.Empty<int>())
			{
				if (GameplayTagUtils.GetGameplayTagById(tagId) != null)
				{
					baseTagComponent2.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, tagId, newStack - stackCountInternal);
				}
			}
		}
	}

	// Token: 0x1700230D RID: 8973
	// (get) Token: 0x06019757 RID: 104279 RVA: 0x006936E9 File Offset: 0x006918E9
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x06019758 RID: 104280 RVA: 0x006936F4 File Offset: 0x006918F4
	public void ClearModifiers()
	{
		this.StateModifiers.Clear();
		Entity owner = this.GetOwner();
		BaseAttributeComponent baseAttributeComponent = (owner != null) ? owner.GetComponent<BaseAttributeComponent>() : null;
		if (this.NonStateModifierHandles.Count > 0 && baseAttributeComponent != null)
		{
			foreach (ValueTuple<int, int> valueTuple in this.NonStateModifierHandles)
			{
				baseAttributeComponent.RemoveModifier((EAttributeType)valueTuple.Item1, valueTuple.Item2);
			}
			this.NonStateModifierHandles.Clear();
		}
	}

	// Token: 0x06019759 RID: 104281 RVA: 0x0069378C File Offset: 0x0069198C
	public void ResetModifiers()
	{
		this.ClearModifiers();
		if (this.IsActiveInternal)
		{
			foreach (IBuffModifierData buffModifierData in this.Config.Modifiers)
			{
				EAttributeType attributeId = buffModifierData.AttributeId;
				if (CharacterAttributeTypes.stateAttributeIds.Contains(attributeId))
				{
					this.SetStateModifier(buffModifierData);
				}
				else
				{
					this.SetNonStateModifier(buffModifierData);
				}
			}
		}
	}

	// Token: 0x0601975A RID: 104282 RVA: 0x006937EC File Offset: 0x006919EC
	private unsafe void SetStateModifier(IBuffModifierData modifier)
	{
		ECalculationPolicyType ecalculationPolicyType = (ECalculationPolicyType)modifier.CalculationPolicy[0];
		if (ecalculationPolicyType == ECalculationPolicyType.AddFromAttr || ecalculationPolicyType == ECalculationPolicyType.OverrideFromAttr || ecalculationPolicyType == ECalculationPolicyType.AddFromAttrRate)
		{
			int attrId = modifier.CalculationPolicy[1];
			EBuffAttributeCaptureSource ebuffAttributeCaptureSource = (EBuffAttributeCaptureSource)modifier.CalculationPolicy[2];
			EAttributeBasedFloatCalculationType attrCalcPolicy = (EAttributeBasedFloatCalculationType)modifier.CalculationPolicy[3];
			object obj = modifier.CalculationPolicy.Length > 4 && modifier.CalculationPolicy[4] != 0;
			BaseAttributeComponent baseAttributeComponent = (ebuffAttributeCaptureSource == EBuffAttributeCaptureSource.Instigator) ? this.GetInstigatorAttributeSet() : this.GetOwnerAttributeSet();
			object obj2 = obj;
			if (obj2 != null && baseAttributeComponent == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity owner = this.GetOwner();
				string message = "buff找不到属性来源，快照将被取值为0";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", this.Handle);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "持有者";
				BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
				ptr = new ValueTuple<string, object>(item, (ownerBuffCompInternal != null) ? ownerBuffCompInternal.GetDebugName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("施加者", this.InstigatorId);
				instance.Warn(flag, owner, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			float? item2 = (obj2 != null) ? new float?((baseAttributeComponent != null) ? AbilityUtils.GetAttrValue(baseAttributeComponent, (EAttributeType)attrId, attrCalcPolicy) : 0f) : null;
			this.StateModifiers.Add(new ValueTuple<IBuffModifierData, float?>(modifier, item2));
			return;
		}
		this.StateModifiers.Add(new ValueTuple<IBuffModifierData, float?>(modifier, null));
	}

	// Token: 0x0601975B RID: 104283 RVA: 0x00693978 File Offset: 0x00691B78
	private unsafe void SetNonStateModifier(IBuffModifierData modifier)
	{
		int num = (this.StackCountInternal != 0) ? this.StackCountInternal : 1;
		Entity owner = this.GetOwner();
		BaseAttributeComponent baseAttributeComponent = (owner != null) ? owner.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		int item = 0;
		EAttributeType attributeId = modifier.AttributeId;
		float levelValue = AbilityUtils.GetLevelValue<float>(modifier.Value1, this.LevelInternal, 0f);
		float levelValue2 = AbilityUtils.GetLevelValue<float>(modifier.Value2, this.LevelInternal, 0f);
		switch (modifier.CalculationPolicy[0])
		{
		case 0:
		case 1:
		case 3:
			item = baseAttributeComponent.AddModifier(attributeId, new CharacterAttributeTypes.AttributeModifier
			{
				Type = (ECalculationPolicyType)modifier.CalculationPolicy[0],
				Value1 = levelValue * (float)num
			});
			break;
		case 2:
		case 4:
		case 9:
		{
			ECalculationPolicyType type = (ECalculationPolicyType)modifier.CalculationPolicy[0];
			int num2 = modifier.CalculationPolicy[1];
			int num3 = modifier.CalculationPolicy[2];
			EAttributeBasedFloatCalculationType eattributeBasedFloatCalculationType = (EAttributeBasedFloatCalculationType)modifier.CalculationPolicy[3];
			bool flag = modifier.CalculationPolicy.Length > 4 && modifier.CalculationPolicy[4] != 0;
			float? min = (modifier.CalculationPolicy.Length > 5) ? new float?((float)modifier.CalculationPolicy[5]) : null;
			float? ratio = (modifier.CalculationPolicy.Length > 6) ? new float?((float)modifier.CalculationPolicy[6]) : null;
			float? max = (modifier.CalculationPolicy.Length > 7) ? new float?((float)modifier.CalculationPolicy[7]) : null;
			bool floorAfterRatio = modifier.CalculationPolicy.Length > 8 && modifier.CalculationPolicy[8] == 1;
			BaseAttributeComponent baseAttributeComponent2 = (num3 == 1) ? this.GetInstigatorAttributeSet() : this.GetOwnerAttributeSet();
			long? num4 = (num3 == 1) ? this.InstigatorId : new long?(0L);
			if (baseAttributeComponent2 == null || num4 == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
				Entity owner2 = this.GetOwner();
				string message = "持续型buff设置属性modifier时缺少来源";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", this.Handle);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "持有者";
				BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
				ptr = new ValueTuple<string, object>(item2, (ownerBuffCompInternal != null) ? ownerBuffCompInternal.GetDebugName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("施加者", this.InstigatorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("attrId", attributeId);
				instance.Error(flag2, owner2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				return;
			}
			item = baseAttributeComponent.AddModifier(attributeId, new CharacterAttributeTypes.AttributeModifier
			{
				Type = type,
				Value1 = levelValue * (float)num,
				Value2 = levelValue2 * (float)num,
				SourceEntity = num4.Value,
				SourceAttributeId = (EAttributeType)num2,
				SourceCalculationType = eattributeBasedFloatCalculationType,
				SnapshotSource = (flag ? new float?(AbilityUtils.GetAttrValue(baseAttributeComponent2, (EAttributeType)num2, eattributeBasedFloatCalculationType)) : null),
				Min = min,
				Ratio = ratio,
				Max = max,
				FloorAfterRatio = floorAfterRatio
			});
			break;
		}
		case 5:
		case 6:
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Buff;
			Entity owner3 = this.GetOwner();
			string message2 = "不能对非状态属性使用时间膨胀类属性修改";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.Id);
			instance2.Error(flag3, owner3, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			break;
		}
		}
		this.NonStateModifierHandles.Add(new ValueTuple<int, int>((int)attributeId, item));
	}

	// Token: 0x0601975C RID: 104284 RVA: 0x00693D04 File Offset: 0x00691F04
	public static void ModifyStateAttribute([Nullable(2)] IAttributeSet instigator, BaseAttributeComponent owner, IBuffModifierData modifier, int level, float timeDilation, int stackCount, float? snapshot = null)
	{
		EAttributeType attributeId = modifier.AttributeId;
		if (!CharacterAttributeTypes.stateAttributeIds.Contains(attributeId))
		{
			return;
		}
		float levelValue = AbilityUtils.GetLevelValue<float>(modifier.Value1, level, 0f);
		float levelValue2 = AbilityUtils.GetLevelValue<float>(modifier.Value2, level, 0f);
		switch (modifier.CalculationPolicy[0])
		{
		case 0:
			owner.AddBaseValue(attributeId, levelValue * (float)stackCount);
			return;
		case 1:
		{
			float baseValue = owner.GetBaseValue(attributeId);
			double num = (double)levelValue * (double)stackCount / 10000.0 + 1.0;
			owner.SetBaseValue(attributeId, (float)((double)baseValue * num));
			return;
		}
		case 2:
		case 4:
		case 9:
		{
			ECalculationPolicyType ecalculationPolicyType = (ECalculationPolicyType)modifier.CalculationPolicy[0];
			int attrId = modifier.CalculationPolicy[1];
			int num2 = modifier.CalculationPolicy[2];
			EAttributeBasedFloatCalculationType attrCalcPolicy = (EAttributeBasedFloatCalculationType)modifier.CalculationPolicy[3];
			float? num3 = (modifier.CalculationPolicy.Length > 5) ? new float?((float)modifier.CalculationPolicy[5]) : null;
			float? num4 = (modifier.CalculationPolicy.Length > 6) ? new float?((float)modifier.CalculationPolicy[6]) : null;
			float? num5 = (modifier.CalculationPolicy.Length > 7) ? new float?((float)modifier.CalculationPolicy[7]) : null;
			bool flag = modifier.CalculationPolicy.Length > 8 && modifier.CalculationPolicy[8] == 1;
			IAttributeSet attributeSet = (num2 == 1) ? instigator : owner;
			if (attributeSet == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
				Entity entity = owner.Entity;
				string message = "瞬间/周期buff属性修改时缺少来源";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attrId", attributeId);
				instance.Error(flag2, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			float num6 = snapshot ?? AbilityUtils.GetAttrValue(attributeSet, (EAttributeType)attrId, attrCalcPolicy);
			if (num3 != null)
			{
				num6 -= num3.Value;
				if (num6 <= 0f)
				{
					return;
				}
			}
			if (num4 != null)
			{
				num6 /= num4.Value;
				if (flag)
				{
					num6 = (float)Math.Floor((double)num6);
				}
			}
			if (ecalculationPolicyType == ECalculationPolicyType.AddFromAttrRate)
			{
				float baseValue2 = owner.GetBaseValue(attributeId);
				owner.AddBaseValue(attributeId, (float)((double)levelValue * (double)num6 / 10000.0 * (double)baseValue2 / 10000.0 * (double)stackCount));
				return;
			}
			float num7 = (float)((double)levelValue * (double)num6 / 10000.0 + (double)levelValue2);
			if (num5 != null && num7 > num5.Value)
			{
				num7 = num5.Value;
			}
			if (ecalculationPolicyType == ECalculationPolicyType.AddFromAttr)
			{
				owner.AddBaseValue(attributeId, num7 * (float)stackCount);
				return;
			}
			owner.SetBaseValue(attributeId, num7);
			return;
		}
		case 3:
			owner.SetBaseValue(attributeId, levelValue);
			return;
		case 5:
			owner.AddBaseValue(attributeId, levelValue * timeDilation * (float)stackCount);
			return;
		case 6:
		{
			int attrId2 = modifier.CalculationPolicy[1];
			EAttributeBasedFloatCalculationType attrCalcPolicy2 = EAttributeBasedFloatCalculationType.BaseValue;
			float num8 = snapshot ?? AbilityUtils.GetAttrValue(owner, (EAttributeType)attrId2, attrCalcPolicy2);
			owner.AddBaseValue(attributeId, (float)(((double)levelValue * (double)num8 / 10000.0 + (double)levelValue2) * (double)timeDilation * (double)stackCount));
			break;
		}
		case 7:
		case 8:
			break;
		default:
			return;
		}
	}

	// Token: 0x0601975D RID: 104285 RVA: 0x00694017 File Offset: 0x00692217
	public static void CreateStaticDefaultValue()
	{
		ActiveBuffInternal._buffPool = new List<ActiveBuffInternal>();
	}

	// Token: 0x0601975E RID: 104286 RVA: 0x00694023 File Offset: 0x00692223
	public static void ResetStaticDefaultValue()
	{
		ActiveBuffInternal._buffPool = null;
	}

	// Token: 0x0400BD46 RID: 48454
	private const int MAX_POOL_COUNT = 100;

	// Token: 0x0400BD47 RID: 48455
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<ActiveBuffInternal> _buffPool;

	// Token: 0x0400BD48 RID: 48456
	private BuffDefinition ConfigInternal;

	// Token: 0x0400BD49 RID: 48457
	private int HandleInternal = -1;

	// Token: 0x0400BD4A RID: 48458
	private long? _preMessageId;

	// Token: 0x0400BD4B RID: 48459
	private long _messageId = -1L;

	// Token: 0x0400BD4C RID: 48460
	private string OwnerDebugName = "";

	// Token: 0x0400BD4D RID: 48461
	[Nullable(2)]
	private BaseBuffComponent OwnerBuffCompInternal;

	// Token: 0x0400BD4E RID: 48462
	private bool RemoveBuffWhenTimeout = true;

	// Token: 0x0400BD4F RID: 48463
	private long InstigatorIdInternal;

	// Token: 0x0400BD50 RID: 48464
	private int ServerIdInternal = -1;

	// Token: 0x0400BD51 RID: 48465
	private long OriginalBuffIdInternal;

	// Token: 0x0400BD52 RID: 48466
	private int? ConfigOverrideListenerId;

	// Token: 0x0400BD53 RID: 48467
	protected Dictionary<int, float> BuffTimeScaleMap = new Dictionary<int, float>();

	// Token: 0x0400BD54 RID: 48468
	protected float BuffTimeScale = 1f;

	// Token: 0x0400BD55 RID: 48469
	[Nullable(2)]
	protected TimerHandle DurationTimer;

	// Token: 0x0400BD56 RID: 48470
	private float DurationInternal = 1f;

	// Token: 0x0400BD57 RID: 48471
	private readonly Stat ResetDurationTimerStat = Stat.Create("ActiveBuff.ResetDurationTimer", "", "");

	// Token: 0x0400BD58 RID: 48472
	private float InnerCreateTimestamp;

	// Token: 0x0400BD59 RID: 48473
	private float LastTimestamp;

	// Token: 0x0400BD5A RID: 48474
	private float LastRemainingDuration;

	// Token: 0x0400BD5B RID: 48475
	private float Timescale = 1f;

	// Token: 0x0400BD5C RID: 48476
	private bool PrepareToDestroy;

	// Token: 0x0400BD5D RID: 48477
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, HashSet<int>> ExecutionStateData;

	// Token: 0x0400BD5E RID: 48478
	private float PeriodUpdateTimestamp;

	// Token: 0x0400BD5F RID: 48479
	private float LastRemainingPeriod;

	// Token: 0x0400BD60 RID: 48480
	protected float PeriodInternal;

	// Token: 0x0400BD61 RID: 48481
	[Nullable(2)]
	private TimerHandle PeriodTimer;

	// Token: 0x0400BD62 RID: 48482
	private readonly Stat ResetPeriodTimerStat = Stat.Create("ActiveBuff.ResetPeriodTimer", "", "");

	// Token: 0x0400BD63 RID: 48483
	private bool IsActiveInternal;

	// Token: 0x0400BD64 RID: 48484
	[StaticVariableRuleIgnore]
	private static readonly Stat SetActivateEnableStat = Stat.Create("ActiveBuffInternal.SetActivate_Enable", "", "");

	// Token: 0x0400BD65 RID: 48485
	[StaticVariableRuleIgnore]
	private static readonly Stat SetActivateDisableStat = Stat.Create("ActiveBuffInternal.SetActivate_Disable", "", "");

	// Token: 0x0400BD66 RID: 48486
	protected int StackCountInternal;

	// Token: 0x0400BD67 RID: 48487
	public int StackLimitCount;

	// Token: 0x0400BD68 RID: 48488
	private int LevelInternal;

	// Token: 0x0400BD69 RID: 48489
	[TupleElementNames(new string[]
	{
		"AttributeId",
		"ModifierHandle"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<int, int>> NonStateModifierHandles = new List<ValueTuple<int, int>>();

	// Token: 0x0400BD6A RID: 48490
	[TupleElementNames(new string[]
	{
		"Modifier",
		"Snapshot"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public readonly List<ValueTuple<IBuffModifierData, float?>> StateModifiers = new List<ValueTuple<IBuffModifierData, float?>>();

	// Token: 0x0400BD6B RID: 48491
	[StaticVariableRuleIgnore]
	private static readonly Stat ClearModifiersStat = Stat.Create("ActiveBuffInternal.ClearModifiers", "", "");

	// Token: 0x0400BD6C RID: 48492
	[StaticVariableRuleIgnore]
	private static readonly Stat ResetModifiersStat = Stat.Create("ActiveBuffInternal.ResetModifiers", "", "");

	// Token: 0x0400BD6D RID: 48493
	[StaticVariableRuleIgnore]
	private static readonly Stat SetStateModifiersStat = Stat.Create("ActiveBuffInternal.SetStateModifier", "", "");

	// Token: 0x0400BD6E RID: 48494
	[StaticVariableRuleIgnore]
	private static readonly Stat SetNonStateModifierStat = Stat.Create("ActiveBuffInternal.SetNonStateModifier", "", "");

	// Token: 0x0400BD6F RID: 48495
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyStateAttributeStat = Stat.Create("ActiveBuffInternal.ModifyStateAttribute", "", "");
}
