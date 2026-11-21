using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CombatMessage;

// Token: 0x020023D0 RID: 9168
[NullableContext(1)]
[Nullable(0)]
public class ActiveBuffInternal : IActiveBuff, IStaticVariableResetter
{
	// Token: 0x06016FF7 RID: 94199 RVA: 0x006B8524 File Offset: 0x006B6724
	static ActiveBuffInternal()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActiveBuffInternal.CreateStaticDefaultValue), new Action(ActiveBuffInternal.ResetStaticDefaultValue));
	}

	// Token: 0x06016FF8 RID: 94200 RVA: 0x006B8600 File Offset: 0x006B6800
	private ActiveBuffInternal(BuffDefinition configInternal)
	{
		this.ConfigInternal = configInternal;
	}

	// Token: 0x1700238B RID: 9099
	// (get) Token: 0x06016FF9 RID: 94201 RVA: 0x006B86B8 File Offset: 0x006B68B8
	public static List<ActiveBuffInternal> BuffPool
	{
		get
		{
			return ActiveBuffInternal._buffPool;
		}
	}

	// Token: 0x06016FFA RID: 94202 RVA: 0x006B86C0 File Offset: 0x006B68C0
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

	// Token: 0x06016FFB RID: 94203 RVA: 0x006B872F File Offset: 0x006B692F
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

	// Token: 0x06016FFC RID: 94204 RVA: 0x006B875C File Offset: 0x006B695C
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

	// Token: 0x06016FFD RID: 94205 RVA: 0x006B88BC File Offset: 0x006B6ABC
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

	// Token: 0x06016FFE RID: 94206 RVA: 0x006B8974 File Offset: 0x006B6B74
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

	// Token: 0x1700238C RID: 9100
	// (get) Token: 0x06016FFF RID: 94207 RVA: 0x006B89C6 File Offset: 0x006B6BC6
	public BuffDefinition Config
	{
		get
		{
			return this.ConfigInternal;
		}
	}

	// Token: 0x1700238D RID: 9101
	// (get) Token: 0x06017000 RID: 94208 RVA: 0x006B89CE File Offset: 0x006B6BCE
	public int Handle
	{
		get
		{
			return this.HandleInternal;
		}
	}

	// Token: 0x1700238E RID: 9102
	// (get) Token: 0x06017001 RID: 94209 RVA: 0x006B89D6 File Offset: 0x006B6BD6
	public long? PreMessageId
	{
		get
		{
			return this._preMessageId;
		}
	}

	// Token: 0x1700238F RID: 9103
	// (get) Token: 0x06017002 RID: 94210 RVA: 0x006B89DE File Offset: 0x006B6BDE
	public long? MessageId
	{
		get
		{
			return new long?(this._messageId);
		}
	}

	// Token: 0x06017003 RID: 94211 RVA: 0x006B89EB File Offset: 0x006B6BEB
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

	// Token: 0x06017004 RID: 94212 RVA: 0x006B89FE File Offset: 0x006B6BFE
	public string GetOwnerDebugName()
	{
		return this.OwnerDebugName;
	}

	// Token: 0x06017005 RID: 94213 RVA: 0x006B8A06 File Offset: 0x006B6C06
	[NullableContext(2)]
	public IBuffComponent GetOwnerBuffComponent()
	{
		return this.OwnerBuffCompInternal;
	}

	// Token: 0x17002390 RID: 9104
	// (get) Token: 0x06017006 RID: 94214 RVA: 0x006B8A0E File Offset: 0x006B6C0E
	public long? InstigatorId
	{
		get
		{
			return new long?(this.InstigatorIdInternal);
		}
	}

	// Token: 0x06017007 RID: 94215 RVA: 0x006B8A1C File Offset: 0x006B6C1C
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

	// Token: 0x06017008 RID: 94216 RVA: 0x006B8A60 File Offset: 0x006B6C60
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

	// Token: 0x06017009 RID: 94217 RVA: 0x006B8AB0 File Offset: 0x006B6CB0
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

	// Token: 0x0601700A RID: 94218 RVA: 0x006B8B00 File Offset: 0x006B6D00
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

	// Token: 0x0601700B RID: 94219 RVA: 0x006B8B4D File Offset: 0x006B6D4D
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

	// Token: 0x17002391 RID: 9105
	// (get) Token: 0x0601700C RID: 94220 RVA: 0x006B8B6B File Offset: 0x006B6D6B
	public long Id
	{
		get
		{
			return this.OriginalBuffIdInternal;
		}
	}

	// Token: 0x17002392 RID: 9106
	// (get) Token: 0x0601700D RID: 94221 RVA: 0x006B8B73 File Offset: 0x006B6D73
	public int ServerId
	{
		get
		{
			return this.ServerIdInternal;
		}
	}

	// Token: 0x17002393 RID: 9107
	// (get) Token: 0x0601700E RID: 94222 RVA: 0x006B8B7B File Offset: 0x006B6D7B
	public long OriginalBuffId
	{
		get
		{
			return this.OriginalBuffIdInternal;
		}
	}

	// Token: 0x0601700F RID: 94223 RVA: 0x006B8B83 File Offset: 0x006B6D83
	public int? GetConfigOverrideListenerId()
	{
		return this.ConfigOverrideListenerId;
	}

	// Token: 0x06017010 RID: 94224 RVA: 0x006B8B8B File Offset: 0x006B6D8B
	public void SetConfigOverrideListenerId(int listenerId)
	{
		this.ConfigOverrideListenerId = new int?(listenerId);
	}

	// Token: 0x06017011 RID: 94225 RVA: 0x006B8B9C File Offset: 0x006B6D9C
	public void OnConfigOverrideChanged()
	{
		BaseBuffComponent ownerBuffCompInternal = this.OwnerBuffCompInternal;
		if (ownerBuffCompInternal == null)
		{
			return;
		}
		ownerBuffCompInternal.RemoveBuffByHandle(this.Handle, -1, "配置覆盖条件变化", null, null, null);
	}

	// Token: 0x06017012 RID: 94226 RVA: 0x006B8BE1 File Offset: 0x006B6DE1
	public bool IsInstantBuff()
	{
		return this.Config.DurationPolicy == EBuffDurationType.Instant;
	}

	// Token: 0x06017013 RID: 94227 RVA: 0x006B8BF1 File Offset: 0x006B6DF1
	public void SetBuffTimeScale(int buffHandle, float timeScale)
	{
		this.BuffTimeScaleMap[buffHandle] = timeScale;
		this.RefreshBuffTimeScale();
	}

	// Token: 0x06017014 RID: 94228 RVA: 0x006B8C06 File Offset: 0x006B6E06
	public void RemoveBuffTimeScale(int buffHandle)
	{
		if (this.BuffTimeScaleMap.ContainsKey(buffHandle))
		{
			this.BuffTimeScaleMap.Remove(buffHandle);
			this.RefreshBuffTimeScale();
		}
	}

	// Token: 0x06017015 RID: 94229 RVA: 0x006B8C2C File Offset: 0x006B6E2C
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

	// Token: 0x06017016 RID: 94230 RVA: 0x006B8CCC File Offset: 0x006B6ECC
	private void ClearBuffTimeScale()
	{
		this.BuffTimeScale = 1f;
		this.BuffTimeScaleMap.Clear();
	}

	// Token: 0x17002394 RID: 9108
	// (get) Token: 0x06017017 RID: 94231 RVA: 0x006B8CE4 File Offset: 0x006B6EE4
	public float Duration
	{
		get
		{
			return this.DurationInternal;
		}
	}

	// Token: 0x06017018 RID: 94232 RVA: 0x006B8CEC File Offset: 0x006B6EEC
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

	// Token: 0x06017019 RID: 94233 RVA: 0x006B8D20 File Offset: 0x006B6F20
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

	// Token: 0x17002395 RID: 9109
	// (get) Token: 0x0601701A RID: 94234 RVA: 0x006B8DCB File Offset: 0x006B6FCB
	public float CreateTimestamp
	{
		get
		{
			return this.InnerCreateTimestamp;
		}
	}

	// Token: 0x0601701B RID: 94235 RVA: 0x006B8DD3 File Offset: 0x006B6FD3
	protected float GetCurrentTime()
	{
		return (float)Time.Instance.Now;
	}

	// Token: 0x0601701C RID: 94236 RVA: 0x006B8DE0 File Offset: 0x006B6FE0
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

	// Token: 0x0601701D RID: 94237 RVA: 0x006B9171 File Offset: 0x006B7371
	public void SetRemainDuration(float remainDuration)
	{
		if (this.Config.DurationPolicy != EBuffDurationType.HasDuration)
		{
			return;
		}
		this.ResetDurationTimer((remainDuration > 0f) ? remainDuration : 0.034f);
	}

	// Token: 0x0601701E RID: 94238 RVA: 0x006B9198 File Offset: 0x006B7398
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

	// Token: 0x0601701F RID: 94239 RVA: 0x006B9238 File Offset: 0x006B7438
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

	// Token: 0x06017020 RID: 94240 RVA: 0x006B927C File Offset: 0x006B747C
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

	// Token: 0x06017021 RID: 94241 RVA: 0x006B941C File Offset: 0x006B761C
	protected bool SetPeriod()
	{
		this.RefreshPeriodInternal();
		this.ResetPeriodTimer(this.PeriodInternal);
		return true;
	}

	// Token: 0x17002396 RID: 9110
	// (get) Token: 0x06017022 RID: 94242 RVA: 0x006B9431 File Offset: 0x006B7631
	public float Period
	{
		get
		{
			return this.PeriodInternal;
		}
	}

	// Token: 0x06017023 RID: 94243 RVA: 0x006B943C File Offset: 0x006B763C
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

	// Token: 0x06017024 RID: 94244 RVA: 0x006B95AC File Offset: 0x006B77AC
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

	// Token: 0x06017025 RID: 94245 RVA: 0x006B95D4 File Offset: 0x006B77D4
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

	// Token: 0x06017026 RID: 94246 RVA: 0x006B9608 File Offset: 0x006B7808
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

	// Token: 0x06017027 RID: 94247 RVA: 0x006B96AC File Offset: 0x006B78AC
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

	// Token: 0x06017028 RID: 94248 RVA: 0x006B9734 File Offset: 0x006B7934
	public float? GetRemainPeriod()
	{
		float num = (this.GetCurrentTime() - this.PeriodUpdateTimestamp) * this.Timescale;
		if (this.PeriodInternal < 0f)
		{
			return null;
		}
		return new float?(this.LastRemainingPeriod - num / 1000f);
	}

	// Token: 0x06017029 RID: 94249 RVA: 0x006B9780 File Offset: 0x006B7980
	public bool IsActive()
	{
		return this.IsActiveInternal;
	}

	// Token: 0x0601702A RID: 94250 RVA: 0x006B9788 File Offset: 0x006B7988
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

	// Token: 0x17002397 RID: 9111
	// (get) Token: 0x0601702B RID: 94251 RVA: 0x006B9953 File Offset: 0x006B7B53
	public int StackCount
	{
		get
		{
			return this.StackCountInternal;
		}
	}

	// Token: 0x0601702C RID: 94252 RVA: 0x006B995C File Offset: 0x006B7B5C
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

	// Token: 0x17002398 RID: 9112
	// (get) Token: 0x0601702D RID: 94253 RVA: 0x006B9AA5 File Offset: 0x006B7CA5
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x0601702E RID: 94254 RVA: 0x006B9AB0 File Offset: 0x006B7CB0
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

	// Token: 0x0601702F RID: 94255 RVA: 0x006B9B48 File Offset: 0x006B7D48
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

	// Token: 0x06017030 RID: 94256 RVA: 0x006B9BA8 File Offset: 0x006B7DA8
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

	// Token: 0x06017031 RID: 94257 RVA: 0x006B9D34 File Offset: 0x006B7F34
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

	// Token: 0x06017032 RID: 94258 RVA: 0x006BA0C0 File Offset: 0x006B82C0
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

	// Token: 0x06017033 RID: 94259 RVA: 0x006BA3D3 File Offset: 0x006B85D3
	public static void CreateStaticDefaultValue()
	{
		ActiveBuffInternal._buffPool = new List<ActiveBuffInternal>();
	}

	// Token: 0x06017034 RID: 94260 RVA: 0x006BA3DF File Offset: 0x006B85DF
	public static void ResetStaticDefaultValue()
	{
		ActiveBuffInternal._buffPool = null;
	}

	// Token: 0x0400C0DD RID: 49373
	private const int MAX_POOL_COUNT = 100;

	// Token: 0x0400C0DE RID: 49374
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<ActiveBuffInternal> _buffPool;

	// Token: 0x0400C0DF RID: 49375
	private BuffDefinition ConfigInternal;

	// Token: 0x0400C0E0 RID: 49376
	private int HandleInternal = -1;

	// Token: 0x0400C0E1 RID: 49377
	private long? _preMessageId;

	// Token: 0x0400C0E2 RID: 49378
	private long _messageId = -1L;

	// Token: 0x0400C0E3 RID: 49379
	private string OwnerDebugName = "";

	// Token: 0x0400C0E4 RID: 49380
	[Nullable(2)]
	private BaseBuffComponent OwnerBuffCompInternal;

	// Token: 0x0400C0E5 RID: 49381
	private bool RemoveBuffWhenTimeout = true;

	// Token: 0x0400C0E6 RID: 49382
	private long InstigatorIdInternal;

	// Token: 0x0400C0E7 RID: 49383
	private int ServerIdInternal = -1;

	// Token: 0x0400C0E8 RID: 49384
	private long OriginalBuffIdInternal;

	// Token: 0x0400C0E9 RID: 49385
	private int? ConfigOverrideListenerId;

	// Token: 0x0400C0EA RID: 49386
	protected Dictionary<int, float> BuffTimeScaleMap = new Dictionary<int, float>();

	// Token: 0x0400C0EB RID: 49387
	protected float BuffTimeScale = 1f;

	// Token: 0x0400C0EC RID: 49388
	[Nullable(2)]
	protected TimerHandle DurationTimer;

	// Token: 0x0400C0ED RID: 49389
	private float DurationInternal = 1f;

	// Token: 0x0400C0EE RID: 49390
	private readonly Stat ResetDurationTimerStat = Stat.Create("ActiveBuff.ResetDurationTimer", "", "");

	// Token: 0x0400C0EF RID: 49391
	private float InnerCreateTimestamp;

	// Token: 0x0400C0F0 RID: 49392
	private float LastTimestamp;

	// Token: 0x0400C0F1 RID: 49393
	private float LastRemainingDuration;

	// Token: 0x0400C0F2 RID: 49394
	private float Timescale = 1f;

	// Token: 0x0400C0F3 RID: 49395
	private bool PrepareToDestroy;

	// Token: 0x0400C0F4 RID: 49396
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, HashSet<int>> ExecutionStateData;

	// Token: 0x0400C0F5 RID: 49397
	private float PeriodUpdateTimestamp;

	// Token: 0x0400C0F6 RID: 49398
	private float LastRemainingPeriod;

	// Token: 0x0400C0F7 RID: 49399
	protected float PeriodInternal;

	// Token: 0x0400C0F8 RID: 49400
	[Nullable(2)]
	private TimerHandle PeriodTimer;

	// Token: 0x0400C0F9 RID: 49401
	private readonly Stat ResetPeriodTimerStat = Stat.Create("ActiveBuff.ResetPeriodTimer", "", "");

	// Token: 0x0400C0FA RID: 49402
	private bool IsActiveInternal;

	// Token: 0x0400C0FB RID: 49403
	[StaticVariableRuleIgnore]
	private static readonly Stat SetActivateEnableStat = Stat.Create("ActiveBuffInternal.SetActivate_Enable", "", "");

	// Token: 0x0400C0FC RID: 49404
	[StaticVariableRuleIgnore]
	private static readonly Stat SetActivateDisableStat = Stat.Create("ActiveBuffInternal.SetActivate_Disable", "", "");

	// Token: 0x0400C0FD RID: 49405
	protected int StackCountInternal;

	// Token: 0x0400C0FE RID: 49406
	public int StackLimitCount;

	// Token: 0x0400C0FF RID: 49407
	private int LevelInternal;

	// Token: 0x0400C100 RID: 49408
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

	// Token: 0x0400C101 RID: 49409
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

	// Token: 0x0400C102 RID: 49410
	[StaticVariableRuleIgnore]
	private static readonly Stat ClearModifiersStat = Stat.Create("ActiveBuffInternal.ClearModifiers", "", "");

	// Token: 0x0400C103 RID: 49411
	[StaticVariableRuleIgnore]
	private static readonly Stat ResetModifiersStat = Stat.Create("ActiveBuffInternal.ResetModifiers", "", "");

	// Token: 0x0400C104 RID: 49412
	[StaticVariableRuleIgnore]
	private static readonly Stat SetStateModifiersStat = Stat.Create("ActiveBuffInternal.SetStateModifier", "", "");

	// Token: 0x0400C105 RID: 49413
	[StaticVariableRuleIgnore]
	private static readonly Stat SetNonStateModifierStat = Stat.Create("ActiveBuffInternal.SetNonStateModifier", "", "");

	// Token: 0x0400C106 RID: 49414
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyStateAttributeStat = Stat.Create("ActiveBuffInternal.ModifyStateAttribute", "", "");
}
