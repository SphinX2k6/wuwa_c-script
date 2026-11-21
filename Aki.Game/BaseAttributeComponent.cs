using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023B2 RID: 9138
[NullableContext(1)]
[Nullable(0)]
public class BaseAttributeComponent : EntityComponent, IAttributeSet, IStaticVariableResetter
{
	// Token: 0x06016DBB RID: 93627 RVA: 0x006A929C File Offset: 0x006A749C
	static BaseAttributeComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAttributeComponent.CreateStaticDefaultValue), new Action(BaseAttributeComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06016DBC RID: 93628 RVA: 0x006A937F File Offset: 0x006A757F
	public static void CreateStaticDefaultValue()
	{
		BaseAttributeComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x06016DBD RID: 93629 RVA: 0x006A9388 File Offset: 0x006A7588
	public static void ResetStaticDefaultValue()
	{
		BaseAttributeComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x06016DBE RID: 93630 RVA: 0x006A9391 File Offset: 0x006A7591
	protected override bool OnInit()
	{
		base.OnInit();
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.BuffComponent = base.Entity.GetComponent<BaseBuffComponent>();
		return true;
	}

	// Token: 0x06016DBF RID: 93631 RVA: 0x006A93C0 File Offset: 0x006A75C0
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		for (int i = 0; i < 143; i++)
		{
			this.BaseValues[i] = 0f;
		}
		for (int j = 0; j < 143; j++)
		{
			this.CurrentValues[j] = 0f;
		}
		for (int k = 0; k < 143; k++)
		{
			this.ModifierLists[k] = new Dictionary<int, CharacterAttributeTypes.IModifier>();
		}
		return true;
	}

	// Token: 0x06016DC0 RID: 93632 RVA: 0x006A9425 File Offset: 0x006A7625
	protected override void OnTick(float delta)
	{
		this.AutoRecoverAttr(delta);
	}

	// Token: 0x06016DC1 RID: 93633 RVA: 0x006A9430 File Offset: 0x006A7630
	public bool IsWritableAttribute(EAttributeType attrId)
	{
		return CharacterAttributeTypes.attrsAutoRecoverSpeedMap.ContainsKey(attrId) || CharacterAttributeTypes.attrsAutoRecoverMaxMap.ContainsKey(attrId) || (attrId == EAttributeType.Tough || attrId == EAttributeType.Jump) || (CharacterAttributeTypes.specialEnergyIds.Contains(attrId) && (this.BuffComponent == null || this.BuffComponent.HasBuffAuthority()));
	}

	// Token: 0x06016DC2 RID: 93634 RVA: 0x006A948C File Offset: 0x006A768C
	public bool IsLocalAttribute(EAttributeType attrId)
	{
		return attrId == EAttributeType.Jump || (CharacterAttributeTypes.specialEnergyIds.Contains(attrId) && (this.BuffComponent == null || this.BuffComponent.HasBuffAuthority()));
	}

	// Token: 0x06016DC3 RID: 93635 RVA: 0x006A94BC File Offset: 0x006A76BC
	public void SetBaseValue(EAttributeType attrId, float value)
	{
		if (!this.IsWritableAttribute(attrId))
		{
			return;
		}
		float num = value;
		float? maxValue = this.GetMaxValue(attrId);
		if (maxValue != null && CharacterAttributeTypes.stateAttributeIds.Contains(attrId))
		{
			num = this.RefreshBounds(attrId, num, maxValue.Value);
		}
		if (Array.IndexOf<EAttributeType>(CharacterAttributeTypes.attrsNotClampZero, attrId) < 0)
		{
			num = Math.Max(num, 0f);
		}
		num = (float)Math.Floor((double)num);
		this.BaseValues[(int)attrId] = num;
		float oldValue = this.CurrentValues[(int)attrId];
		this.UpdateCurrentValue(attrId);
		float newValue = this.CurrentValues[(int)attrId];
		this.DispatchCurrentValueEvent(attrId, newValue, oldValue);
	}

	// Token: 0x06016DC4 RID: 93636 RVA: 0x006A9555 File Offset: 0x006A7755
	public void AddBaseValue(EAttributeType attrId, float value)
	{
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId] + value);
	}

	// Token: 0x06016DC5 RID: 93637 RVA: 0x006A9568 File Offset: 0x006A7768
	public float GetBaseValue(EAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x06016DC6 RID: 93638 RVA: 0x006A9572 File Offset: 0x006A7772
	public float GetCurrentValue(EAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x06016DC7 RID: 93639 RVA: 0x006A957C File Offset: 0x006A777C
	public virtual void SeamlessTravelingRefresh()
	{
	}

	// Token: 0x06016DC8 RID: 93640 RVA: 0x006A957E File Offset: 0x006A777E
	public virtual void ClearSpecialEnergy()
	{
	}

	// Token: 0x06016DC9 RID: 93641 RVA: 0x006A9580 File Offset: 0x006A7780
	private float? GetMaxValue(EAttributeType attrId)
	{
		EAttributeType attrId2;
		if (CharacterAttributeTypes.attributeIdsWithMax.TryGetValue(attrId, out attrId2))
		{
			return new float?(this.GetCurrentValue(attrId2));
		}
		return null;
	}

	// Token: 0x06016DCA RID: 93642 RVA: 0x006A95B4 File Offset: 0x006A77B4
	public unsafe void SyncValueFromServer(EAttributeType attrId, float baseValue, float currentValue)
	{
		if (this.IsLocalAttribute(attrId))
		{
			return;
		}
		if (attrId < EAttributeType.None || attrId >= EAttributeType.Max)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "[属性同步]服务端下发越界属性Id，已跳过";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			ptr = new ValueTuple<string, object>(item, (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureDataComponent2 = this.CreatureDataComponent;
			ptr2 = new ValueTuple<string, object>(item2, (creatureDataComponent2 != null) ? new int?(creatureDataComponent2.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AttributeType", (int)attrId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BaseValue", baseValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("CurrentValue", currentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Max", 143);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return;
		}
		if (this.BaseValues[(int)attrId] != baseValue)
		{
			this.BaseValues[(int)attrId] = baseValue;
			this.AutoRecoverFractions.Remove(attrId);
		}
		float oldValue = this.CurrentValues[(int)attrId];
		this.CurrentValues[(int)attrId] = currentValue;
		this.DispatchCurrentValueEvent(attrId, currentValue, oldValue);
		EAttributeType eattributeType;
		if (CharacterAttributeTypes.AttributeIdsMaxToAttrId.TryGetValue(attrId, out eattributeType))
		{
			this.SetBaseValue(eattributeType, this.BaseValues[(int)eattributeType]);
		}
	}

	// Token: 0x06016DCB RID: 93643 RVA: 0x006A974C File Offset: 0x006A794C
	public virtual void UpdateCurrentValue(EAttributeType attrId)
	{
		if (!this.IsWritableAttribute(attrId))
		{
			return;
		}
		float num = CharacterAttributeTypes.stateAttributeIds.Contains(attrId) ? this.BaseValues[(int)attrId] : this.RefreshNonStateBounds(attrId, this.EvaluateModifiers(attrId));
		int num2;
		if (CharacterAttributeTypes.attrsCurrentValueClamp.TryGetValue(attrId, out num2))
		{
			num = Math.Min(num, (float)num2);
		}
		if (Array.IndexOf<EAttributeType>(CharacterAttributeTypes.attrsNotClampZero, attrId) < 0)
		{
			num = Math.Max(num, 0f);
		}
		if (this.CurrentValues[(int)attrId] == num)
		{
			return;
		}
		this.CurrentValues[(int)attrId] = num;
	}

	// Token: 0x06016DCC RID: 93644 RVA: 0x006A97D4 File Offset: 0x006A79D4
	public AttributeSnapshot TakeSnapshot()
	{
		AttributeSnapshot attributeSnapshot = new AttributeSnapshot();
		Array.Copy(this.BaseValues, attributeSnapshot.BaseValues, 143);
		Array.Copy(this.CurrentValues, attributeSnapshot.CurrentValues, 143);
		return attributeSnapshot;
	}

	// Token: 0x06016DCD RID: 93645 RVA: 0x006A9814 File Offset: 0x006A7A14
	public int AddModifier(EAttributeType attrId, CharacterAttributeTypes.IModifier modifier)
	{
		if (!this.IsWritableAttribute(attrId))
		{
			return -1;
		}
		if (attrId <= EAttributeType.None || attrId >= EAttributeType.Max)
		{
			return -1;
		}
		if (CharacterAttributeTypes.stateAttributeIds.Contains(attrId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "禁止给状态属性添加Modifier（状态属性CurrentValue直接取BaseValue，Modifier不会生效）";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attrId", attrId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		int num = BaseAttributeComponent.ModifierHandleGenerator++;
		this.ModifierLists[(int)attrId] = (this.ModifierLists[(int)attrId] ?? new Dictionary<int, CharacterAttributeTypes.IModifier>());
		this.ModifierLists[(int)attrId][num] = modifier;
		float oldValue = this.CurrentValues[(int)attrId];
		this.UpdateCurrentValue(attrId);
		float newValue = this.CurrentValues[(int)attrId];
		this.DispatchCurrentValueEvent(attrId, newValue, oldValue);
		return num;
	}

	// Token: 0x06016DCE RID: 93646 RVA: 0x006A98D0 File Offset: 0x006A7AD0
	public void RemoveModifier(EAttributeType attrId, int handle)
	{
		if (this.ModifierLists[(int)attrId] == null || !this.ModifierLists[(int)attrId].Remove(handle))
		{
			return;
		}
		float oldValue = this.CurrentValues[(int)attrId];
		this.UpdateCurrentValue(attrId);
		float newValue = this.CurrentValues[(int)attrId];
		this.DispatchCurrentValueEvent(attrId, newValue, oldValue);
	}

	// Token: 0x06016DCF RID: 93647 RVA: 0x006A991C File Offset: 0x006A7B1C
	public virtual void CollectModifiers(EAttributeType attrId, List<CharacterAttributeTypes.IModifier> output)
	{
		Dictionary<int, CharacterAttributeTypes.IModifier> dictionary = this.ModifierLists[(int)attrId];
		if (dictionary == null)
		{
			return;
		}
		foreach (CharacterAttributeTypes.IModifier item in dictionary.Values)
		{
			output.Add(item);
		}
	}

	// Token: 0x06016DD0 RID: 93648 RVA: 0x006A997C File Offset: 0x006A7B7C
	private float EvaluateModifiers(EAttributeType attrId)
	{
		float num = this.BaseValues[(int)attrId];
		if (this.ModifierLists[(int)attrId] == null)
		{
			return num;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 1f;
		bool flag = this.CheckIfNeedAdvanceMultiply(attrId);
		this.ModifierScratch.Clear();
		this.CollectModifiers(attrId, this.ModifierScratch);
		foreach (CharacterAttributeTypes.IModifier modifier in this.ModifierScratch)
		{
			CharacterAttributeTypes.AttributeModifier attributeModifier = modifier as CharacterAttributeTypes.AttributeModifier;
			if (attributeModifier != null)
			{
				float num5 = 0f;
				switch (attributeModifier.Type)
				{
				case ECalculationPolicyType.AdvancedMultiplyMagnitude1:
					num4 *= attributeModifier.Value1 * 0.0001f;
					break;
				case ECalculationPolicyType.AddValue:
					num5 = attributeModifier.Value1;
					break;
				case ECalculationPolicyType.AddRate:
					num3 += attributeModifier.Value1;
					break;
				case ECalculationPolicyType.AddFromAttr:
				case ECalculationPolicyType.OverrideFromAttr:
				case ECalculationPolicyType.AddFromAttrRate:
				{
					float num6 = attributeModifier.SnapshotSource.GetValueOrDefault();
					if (num6 == 0f)
					{
						IAttributeSet attrSet;
						if (attributeModifier.SourceEntity != 0L)
						{
							EntityHandle entity = CreatureModel.Instance.GetEntity(attributeModifier.SourceEntity);
							if (entity == null)
							{
								attrSet = null;
							}
							else
							{
								WorldEntity entity2 = entity.Entity;
								attrSet = ((entity2 != null) ? entity2.GetComponent<BaseAttributeComponent>() : null);
							}
						}
						else
						{
							attrSet = this;
						}
						num6 = AbilityUtils.GetAttrValue(attrSet, attributeModifier.SourceAttributeId, attributeModifier.SourceCalculationType);
					}
					float valueOrDefault = attributeModifier.Min.GetValueOrDefault();
					if (valueOrDefault != 0f)
					{
						num6 -= valueOrDefault;
						if (num6 <= 0f)
						{
							break;
						}
					}
					float valueOrDefault2 = attributeModifier.Ratio.GetValueOrDefault();
					if (valueOrDefault2 != 0f)
					{
						num6 /= valueOrDefault2;
						if (attributeModifier.FloorAfterRatio)
						{
							num6 = (float)Math.Floor((double)num6);
						}
					}
					if (attributeModifier.Type == ECalculationPolicyType.AddFromAttrRate)
					{
						num3 += num6 * attributeModifier.Value1 * 0.0001f;
					}
					else
					{
						num5 = num6 * attributeModifier.Value1 * 0.0001f + attributeModifier.Value2;
						float valueOrDefault3 = attributeModifier.Max.GetValueOrDefault();
						if (valueOrDefault3 != 0f && num5 > valueOrDefault3)
						{
							num5 = valueOrDefault3;
						}
						if (attributeModifier.Type == ECalculationPolicyType.OverrideFromAttr)
						{
							return num5;
						}
					}
					break;
				}
				case ECalculationPolicyType.OverrideValue:
					return attributeModifier.Value1;
				}
				if (num5 != 0f)
				{
					if (!flag)
					{
						num2 += num5;
					}
					else
					{
						num4 *= num5 * 0.0001f + 1f;
					}
				}
			}
		}
		return (float)Math.Floor((double)((num * (num3 * 0.0001f + 1f) + num2) * num4));
	}

	// Token: 0x06016DD1 RID: 93649 RVA: 0x006A9C34 File Offset: 0x006A7E34
	public void SyncRecoverPropFromServer(EAttributeType attrId, float currentValue, float maxValue, float speed, double deltaTime)
	{
		EAttributeType attrId2;
		EAttributeType attrId3;
		if (!CharacterAttributeTypes.attrsAutoRecoverSpeedMap.TryGetValue(attrId, out attrId2) || !CharacterAttributeTypes.attrsAutoRecoverMaxMap.TryGetValue(attrId, out attrId3))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "自动属性未注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("属性", attrId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SyncValueFromServer(attrId2, speed, speed);
		this.SyncValueFromServer(attrId3, maxValue, maxValue);
		float num = (float)((double)currentValue + (double)speed * deltaTime * 0.0010000000474974513);
		this.SyncValueFromServer(attrId, num, num);
	}

	// Token: 0x06016DD2 RID: 93650 RVA: 0x006A9CC0 File Offset: 0x006A7EC0
	public void AutoRecoverAttr(float deltaTime)
	{
		float flowTimeDilation = Time.Instance.FlowTimeDilation;
		float num = deltaTime * flowTimeDilation * 0.001f;
		foreach (KeyValuePair<EAttributeType, EAttributeType> keyValuePair in CharacterAttributeTypes.attrsAutoRecoverSpeedMap)
		{
			EAttributeType key = keyValuePair.Key;
			EAttributeType value = keyValuePair.Value;
			float currentValue = this.GetCurrentValue(value);
			if (currentValue != 0f)
			{
				float num3;
				float num2 = currentValue * num + (this.AutoRecoverFractions.TryGetValue(key, out num3) ? num3 : 0f);
				float num4 = (float)Math.Floor((double)num2);
				this.AutoRecoverFractions[key] = num2 - num4;
				if (num4 != 0f)
				{
					this.AddBaseValue(key, num4);
				}
			}
		}
	}

	// Token: 0x06016DD3 RID: 93651 RVA: 0x006A9D9C File Offset: 0x006A7F9C
	protected unsafe int AddBoundsLocker(EAttributeType attrId, IBoundsLocker locker, int lockerHandle)
	{
		if (!this.IsWritableAttribute(attrId))
		{
			return -1;
		}
		Dictionary<int, IBoundsLocker> dictionary;
		if (!this.BoundsLockerMap.TryGetValue(attrId, out dictionary))
		{
			dictionary = new Dictionary<int, IBoundsLocker>();
			this.BoundsLockerMap[attrId] = dictionary;
		}
		if (dictionary.ContainsKey(lockerHandle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQ;
			string message = "重复添加属性BoundsLock";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attrId", attrId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", lockerHandle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return lockerHandle;
		}
		dictionary[lockerHandle] = locker;
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId]);
		return lockerHandle;
	}

	// Token: 0x06016DD4 RID: 93652 RVA: 0x006A9E58 File Offset: 0x006A8058
	public bool RemoveBoundsLocker(EAttributeType attrId, int lockerHandle)
	{
		Dictionary<int, IBoundsLocker> dictionary;
		if (!this.BoundsLockerMap.TryGetValue(attrId, out dictionary))
		{
			return false;
		}
		if (dictionary.Remove(lockerHandle))
		{
			this.SetBaseValue(attrId, this.BaseValues[(int)attrId]);
			return true;
		}
		return false;
	}

	// Token: 0x06016DD5 RID: 93653 RVA: 0x006A9E94 File Offset: 0x006A8094
	public bool UpdateBoundsLocker(EAttributeIntervalLockType lockType, int lockerHandle, EAttributeType attrId, float percent, float offset)
	{
		Dictionary<int, IBoundsLocker> dictionary;
		if (!this.BoundsLockerMap.TryGetValue(attrId, out dictionary))
		{
			return false;
		}
		IBoundsLocker boundsLocker;
		if (!dictionary.TryGetValue(lockerHandle, out boundsLocker))
		{
			return false;
		}
		float num = CharacterAttributeTypes.stateAttributeIds.Contains(attrId) ? percent : 0f;
		if (lockType == EAttributeIntervalLockType.UpperBoundLock)
		{
			boundsLocker.LockUpperBounds = true;
			boundsLocker.LockLowerBounds = false;
			boundsLocker.UpperPercent = num;
			boundsLocker.UpperOffset = offset;
			boundsLocker.LowerPercent = 0f;
			boundsLocker.LowerOffset = 0f;
		}
		else
		{
			boundsLocker.LockUpperBounds = false;
			boundsLocker.LockLowerBounds = true;
			boundsLocker.UpperPercent = (float)(CharacterAttributeTypes.stateAttributeIds.Contains(attrId) ? 10000 : 0);
			boundsLocker.UpperOffset = 0f;
			boundsLocker.LowerPercent = num;
			boundsLocker.LowerOffset = offset;
		}
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId]);
		return true;
	}

	// Token: 0x06016DD6 RID: 93654 RVA: 0x006A9F64 File Offset: 0x006A8164
	public virtual void CollectBoundsLockers(EAttributeType attrId, List<IBoundsLocker> output)
	{
		Dictionary<int, IBoundsLocker> dictionary;
		if (!this.BoundsLockerMap.TryGetValue(attrId, out dictionary))
		{
			return;
		}
		foreach (IBoundsLocker item in dictionary.Values)
		{
			output.Add(item);
		}
	}

	// Token: 0x06016DD7 RID: 93655 RVA: 0x006A9FC8 File Offset: 0x006A81C8
	private float RefreshBounds(EAttributeType attrId, float baseValue, float maxValue)
	{
		float num = baseValue;
		float? num2 = null;
		float val = maxValue;
		this.BoundsLockerScratch.Clear();
		this.CollectBoundsLockers(attrId, this.BoundsLockerScratch);
		foreach (IBoundsLocker boundsLocker in this.BoundsLockerScratch)
		{
			if (boundsLocker.LockLowerBounds)
			{
				float num3 = (float)((double)boundsLocker.LowerPercent * (double)maxValue / 10000.0 + (double)boundsLocker.LowerOffset);
				num2 = new float?(Math.Max(num2.GetValueOrDefault(num3), num3));
			}
			if (boundsLocker.LockUpperBounds)
			{
				float val2 = (float)((double)boundsLocker.UpperPercent * (double)maxValue / 10000.0 + (double)boundsLocker.UpperOffset);
				val = Math.Min(val, val2);
			}
		}
		if (num2 != null)
		{
			num = Math.Max(num2.Value, num);
		}
		num = Math.Min(val, num);
		return num;
	}

	// Token: 0x06016DD8 RID: 93656 RVA: 0x006AA0D0 File Offset: 0x006A82D0
	public void AddIntervalLock(EAttributeIntervalLockType lockType, int handleId, EAttributeType attributeId, float percent, float offset)
	{
		if (attributeId == EAttributeType.Life)
		{
			return;
		}
		float num = CharacterAttributeTypes.stateAttributeIds.Contains(attributeId) ? percent : 0f;
		BoundsLocker boundsLocker = new BoundsLocker
		{
			LockUpperBounds = true,
			LockLowerBounds = false,
			UpperPercent = num,
			UpperOffset = offset,
			LowerPercent = 0f,
			LowerOffset = 0f
		};
		BoundsLocker boundsLocker2 = new BoundsLocker
		{
			LockUpperBounds = false,
			LockLowerBounds = true,
			UpperPercent = (float)(CharacterAttributeTypes.stateAttributeIds.Contains(attributeId) ? 10000 : 0),
			UpperOffset = 0f,
			LowerPercent = num,
			LowerOffset = offset
		};
		BoundsLocker locker = (lockType == EAttributeIntervalLockType.UpperBoundLock) ? boundsLocker : boundsLocker2;
		this.AddBoundsLocker(attributeId, locker, handleId);
	}

	// Token: 0x06016DD9 RID: 93657 RVA: 0x006AA18E File Offset: 0x006A838E
	public void RemoveIntervalLock(EAttributeIntervalLockType lockType, int handleId, EAttributeType attributeId)
	{
		this.RemoveBoundsLocker(attributeId, handleId);
	}

	// Token: 0x06016DDA RID: 93658 RVA: 0x006AA19C File Offset: 0x006A839C
	public void AddAttributeValueLock(int handleId, EAttributeType attributeId, float percent, float offset)
	{
		float num = CharacterAttributeTypes.stateAttributeIds.Contains(attributeId) ? percent : 0f;
		BoundsLocker locker = new BoundsLocker
		{
			LockUpperBounds = true,
			LockLowerBounds = true,
			UpperPercent = num,
			UpperOffset = offset,
			LowerPercent = num,
			LowerOffset = offset
		};
		this.AddBoundsLocker(attributeId, locker, handleId);
	}

	// Token: 0x06016DDB RID: 93659 RVA: 0x006AA1FB File Offset: 0x006A83FB
	public void RemoveAttributeValueLock(int handleId, EAttributeType attributeId)
	{
		this.RemoveBoundsLocker(attributeId, handleId);
	}

	// Token: 0x06016DDC RID: 93660 RVA: 0x006AA208 File Offset: 0x006A8408
	private float RefreshNonStateBounds(EAttributeType attrId, float originValue)
	{
		Dictionary<int, IBoundsLocker> dictionary;
		if (!this.BoundsLockerMap.TryGetValue(attrId, out dictionary) || dictionary.Count == 0)
		{
			return originValue;
		}
		float num = originValue;
		float? num2 = null;
		float? num3 = null;
		this.BoundsLockerScratch.Clear();
		this.CollectBoundsLockers(attrId, this.BoundsLockerScratch);
		foreach (IBoundsLocker boundsLocker in this.BoundsLockerScratch)
		{
			if (boundsLocker.LockLowerBounds)
			{
				float lowerOffset = boundsLocker.LowerOffset;
				num2 = new float?(Math.Max(num2.GetValueOrDefault(lowerOffset), lowerOffset));
			}
			if (boundsLocker.LockUpperBounds)
			{
				float upperOffset = boundsLocker.UpperOffset;
				num3 = new float?(Math.Min(num3.GetValueOrDefault(upperOffset), upperOffset));
			}
		}
		if (num2 != null)
		{
			num = Math.Max(num2.Value, num);
		}
		if (num3 != null)
		{
			num = Math.Min(num3.Value, num);
		}
		return num;
	}

	// Token: 0x06016DDD RID: 93661 RVA: 0x006AA31C File Offset: 0x006A851C
	public void AddListener(EAttributeType attrId, Action<EAttributeType, float, float> callback, [Nullable(2)] string profileLabel = null)
	{
		HashSet<Action<EAttributeType, float, float>> hashSet;
		if (!this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet))
		{
			hashSet = new HashSet<Action<EAttributeType, float, float>>();
			this.CurrentValueListenerMap[attrId] = hashSet;
		}
		hashSet.Add(callback);
	}

	// Token: 0x06016DDE RID: 93662 RVA: 0x006AA354 File Offset: 0x006A8554
	public void AddListeners(EAttributeType[] attrIds, Action<EAttributeType, float, float> callback, [Nullable(2)] string profileLabel = null)
	{
		foreach (EAttributeType attrId in attrIds)
		{
			this.AddListener(attrId, callback, profileLabel);
		}
	}

	// Token: 0x06016DDF RID: 93663 RVA: 0x006AA380 File Offset: 0x006A8580
	public bool RemoveListener(EAttributeType attrId, Action<EAttributeType, float, float> callback)
	{
		HashSet<Action<EAttributeType, float, float>> hashSet;
		if (!this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet))
		{
			return false;
		}
		hashSet.Remove(callback);
		return true;
	}

	// Token: 0x06016DE0 RID: 93664 RVA: 0x006AA3A8 File Offset: 0x006A85A8
	public void RemoveListeners(EAttributeType[] attrIds, Action<EAttributeType, float, float> callback)
	{
		foreach (EAttributeType attrId in attrIds)
		{
			this.RemoveListener(attrId, callback);
		}
	}

	// Token: 0x06016DE1 RID: 93665 RVA: 0x006AA3D2 File Offset: 0x006A85D2
	public void AddGeneralListener(Action<EAttributeType, float, float> listener)
	{
		this.AnyCurrentValueListenerSet.Add(listener);
	}

	// Token: 0x06016DE2 RID: 93666 RVA: 0x006AA3E1 File Offset: 0x006A85E1
	public void RemoveGeneralListener(Action<EAttributeType, float, float> listener)
	{
		this.AnyCurrentValueListenerSet.Remove(listener);
	}

	// Token: 0x06016DE3 RID: 93667 RVA: 0x006AA3F0 File Offset: 0x006A85F0
	public void DispatchCurrentValueEvent(EAttributeType attrId, float newValue, float oldValue)
	{
		if (oldValue == newValue)
		{
			return;
		}
		this.DispatchCurrentValueEventImplement(attrId, newValue, oldValue);
	}

	// Token: 0x06016DE4 RID: 93668 RVA: 0x006AA400 File Offset: 0x006A8600
	protected virtual void DispatchCurrentValueEventImplement(EAttributeType attrId, float newValue, float oldValue)
	{
		HashSet<Action<EAttributeType, float, float>> hashSet;
		if (this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet))
		{
			Stat value;
			if (!BaseAttributeComponent.StatCurrentAttrEventMap.TryGetValue(attrId, out value))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("CurrentAttr#");
				defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(attrId);
				defaultInterpolatedStringHandler.AppendLiteral(" event");
				value = Stat.CreateNoFlameGraph(defaultInterpolatedStringHandler.ToStringAndClear(), "STATGROUP_KuroBattle", "");
				BaseAttributeComponent.StatCurrentAttrEventMap[attrId] = value;
			}
			Action<EAttributeType, float, float>[] array = new Action<EAttributeType, float, float>[hashSet.Count];
			hashSet.CopyTo(array);
			foreach (Action<EAttributeType, float, float> action in array)
			{
				if (hashSet.Contains(action))
				{
					try
					{
						action(attrId, newValue, oldValue);
					}
					catch (Exception ex)
					{
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.Attribute;
						Entity entity = base.Entity;
						string message = "属性回调异常";
						Exception e = ex;
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("属性", attrId);
						instance.ErrorWithStack(flag, entity, message, e, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
		}
		Action<EAttributeType, float, float>[] array3 = new Action<EAttributeType, float, float>[this.AnyCurrentValueListenerSet.Count];
		this.AnyCurrentValueListenerSet.CopyTo(array3);
		foreach (Action<EAttributeType, float, float> action2 in array3)
		{
			if (this.AnyCurrentValueListenerSet.Contains(action2))
			{
				try
				{
					action2(attrId, newValue, oldValue);
				}
				catch (Exception ex2)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Attribute;
					Entity entity2 = base.Entity;
					string message2 = "全局属性回调异常";
					Exception e2 = ex2;
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("属性", attrId);
					instance2.ErrorWithStack(flag2, entity2, message2, e2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
		}
	}

	// Token: 0x06016DE5 RID: 93669 RVA: 0x006AA5A8 File Offset: 0x006A87A8
	public bool CheckIfNeedAdvanceMultiply(EAttributeType attributeId)
	{
		if (attributeId <= EAttributeType.ToughChange)
		{
			if (attributeId != EAttributeType.CdReduse && attributeId != EAttributeType.ToughChange)
			{
				return false;
			}
		}
		else if (attributeId != EAttributeType.SkillToughRatio && attributeId != EAttributeType.SpeedRatio && attributeId - EAttributeType.AutoAttackSpeed > 1)
		{
			return false;
		}
		return true;
	}

	// Token: 0x06016DE6 RID: 93670 RVA: 0x006AA5D0 File Offset: 0x006A87D0
	public string GetDebugString()
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 143; i++)
		{
			EAttributeType value = (EAttributeType)i;
			if (this.BaseValues[i] != 0f || this.CurrentValues[i] != 0f)
			{
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(value);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.BaseValues[i]);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CurrentValues[i]);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		return string.Join("|", list);
	}

	// Token: 0x06016DE7 RID: 93671 RVA: 0x006AA674 File Offset: 0x006A8874
	public string GetLockDebugString(string[] filters)
	{
		string text = "";
		foreach (KeyValuePair<EAttributeType, Dictionary<int, IBoundsLocker>> keyValuePair in this.BoundsLockerMap)
		{
			EAttributeType key = keyValuePair.Key;
			Dictionary<int, IBoundsLocker> value = keyValuePair.Value;
			bool flag = CharacterAttributeTypes.stateAttributeIds.Contains(key);
			foreach (KeyValuePair<int, IBoundsLocker> keyValuePair2 in value)
			{
				int key2 = keyValuePair2.Key;
				IBoundsLocker value2 = keyValuePair2.Value;
				if (filters.Length != 0)
				{
					bool flag2 = false;
					foreach (string value3 in filters)
					{
						int num = (int)key;
						if (num.ToString().StartsWith(value3))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						continue;
					}
				}
				if (flag)
				{
					if (value2.LockLowerBounds)
					{
						string str = text;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 4);
						defaultInterpolatedStringHandler.AppendLiteral("属性:");
						defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(key);
						defaultInterpolatedStringHandler.AppendLiteral(" 下限:");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.LowerPercent / 100f);
						defaultInterpolatedStringHandler.AppendLiteral("%+");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.LowerOffset);
						defaultInterpolatedStringHandler.AppendLiteral(" handle:");
						defaultInterpolatedStringHandler.AppendFormatted<int>(key2);
						defaultInterpolatedStringHandler.AppendLiteral("\n");
						text = str + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (value2.LockUpperBounds)
					{
						string str2 = text;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 4);
						defaultInterpolatedStringHandler.AppendLiteral("属性:");
						defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(key);
						defaultInterpolatedStringHandler.AppendLiteral(" 上限:");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.UpperPercent / 100f);
						defaultInterpolatedStringHandler.AppendLiteral("%+");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.UpperOffset);
						defaultInterpolatedStringHandler.AppendLiteral(" handle:");
						defaultInterpolatedStringHandler.AppendFormatted<int>(key2);
						defaultInterpolatedStringHandler.AppendLiteral("\n");
						text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
				else
				{
					if (value2.LockLowerBounds)
					{
						string str3 = text;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
						defaultInterpolatedStringHandler.AppendLiteral("[非状态]属性:");
						defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(key);
						defaultInterpolatedStringHandler.AppendLiteral(" 下限固定值:");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.LowerOffset);
						defaultInterpolatedStringHandler.AppendLiteral(" handle:");
						defaultInterpolatedStringHandler.AppendFormatted<int>(key2);
						defaultInterpolatedStringHandler.AppendLiteral("\n");
						text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (value2.LockUpperBounds)
					{
						string str4 = text;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
						defaultInterpolatedStringHandler.AppendLiteral("[非状态]属性:");
						defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(key);
						defaultInterpolatedStringHandler.AppendLiteral(" 上限固定值:");
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.UpperOffset);
						defaultInterpolatedStringHandler.AppendLiteral(" handle:");
						defaultInterpolatedStringHandler.AppendFormatted<int>(key2);
						defaultInterpolatedStringHandler.AppendLiteral("\n");
						text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
		}
		return text;
	}

	// Token: 0x06016DE8 RID: 93672 RVA: 0x006AA9A8 File Offset: 0x006A8BA8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAttributeComponent baseAttributeComponent = (BaseAttributeComponent)componentTemplate;
		if (baseAttributeComponent.ModifierScratch != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ModifierScratch), "ModifierScratch"))
		{
			return false;
		}
		if (baseAttributeComponent.BoundsLockerScratch != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BoundsLockerScratch), "BoundsLockerScratch"))
		{
			return false;
		}
		if (baseAttributeComponent.BoundsLockerMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BoundsLockerMap), "BoundsLockerMap"))
		{
			return false;
		}
		if (baseAttributeComponent.AutoRecoverFractions != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AutoRecoverFractions), "AutoRecoverFractions"))
		{
			return false;
		}
		if (baseAttributeComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (baseAttributeComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		return (baseAttributeComponent.CurrentValueListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentValueListenerMap), "CurrentValueListenerMap")) && (baseAttributeComponent.AnyCurrentValueListenerSet == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Action<EAttributeType, float, float>>(this.AnyCurrentValueListenerSet), "AnyCurrentValueListenerSet"));
	}

	// Token: 0x17002317 RID: 8983
	// (get) Token: 0x06016DE9 RID: 93673 RVA: 0x006AAAEA File Offset: 0x006A8CEA
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002318 RID: 8984
	// (get) Token: 0x06016DEA RID: 93674 RVA: 0x006AAAED File Offset: 0x006A8CED
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002319 RID: 8985
	// (get) Token: 0x06016DEB RID: 93675 RVA: 0x006AAAF0 File Offset: 0x006A8CF0
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BFC6 RID: 49094
	protected readonly float[] BaseValues = new float[143];

	// Token: 0x0400BFC7 RID: 49095
	protected readonly float[] CurrentValues = new float[143];

	// Token: 0x0400BFC8 RID: 49096
	protected readonly Dictionary<int, CharacterAttributeTypes.IModifier>[] ModifierLists = new Dictionary<int, CharacterAttributeTypes.IModifier>[143];

	// Token: 0x0400BFC9 RID: 49097
	private readonly List<CharacterAttributeTypes.IModifier> ModifierScratch = new List<CharacterAttributeTypes.IModifier>();

	// Token: 0x0400BFCA RID: 49098
	private readonly List<IBoundsLocker> BoundsLockerScratch = new List<IBoundsLocker>();

	// Token: 0x0400BFCB RID: 49099
	protected readonly Dictionary<EAttributeType, Dictionary<int, IBoundsLocker>> BoundsLockerMap = new Dictionary<EAttributeType, Dictionary<int, IBoundsLocker>>();

	// Token: 0x0400BFCC RID: 49100
	protected readonly Dictionary<EAttributeType, float> AutoRecoverFractions = new Dictionary<EAttributeType, float>();

	// Token: 0x0400BFCD RID: 49101
	[Nullable(2)]
	protected CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400BFCE RID: 49102
	[Nullable(2)]
	protected BaseBuffComponent BuffComponent;

	// Token: 0x0400BFCF RID: 49103
	public static int ModifierHandleGenerator;

	// Token: 0x0400BFD0 RID: 49104
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateCurrentValueStat = Stat.Create("BaseAttributeComponent.UpdateCurrentValue", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD1 RID: 49105
	[StaticVariableRuleIgnore]
	private static readonly Stat AddModifierStat = Stat.Create("BaseAttributeComponent.AddModifier", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD2 RID: 49106
	[StaticVariableRuleIgnore]
	private static readonly Stat RemoveModifierStat = Stat.Create("BaseAttributeComponent.RemoveModifier", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD3 RID: 49107
	[StaticVariableRuleIgnore]
	private static readonly Stat EvaluateModifiersStat = Stat.Create("BaseAttributeComponent.EvaluateModifiers", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD4 RID: 49108
	[StaticVariableRuleIgnore]
	private static readonly Stat AutoRecoverAttrStat = Stat.Create("BaseAttributeComponent.AutoRecoverAttr", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD5 RID: 49109
	protected readonly Dictionary<EAttributeType, HashSet<Action<EAttributeType, float, float>>> CurrentValueListenerMap = new Dictionary<EAttributeType, HashSet<Action<EAttributeType, float, float>>>();

	// Token: 0x0400BFD6 RID: 49110
	protected readonly HashSet<Action<EAttributeType, float, float>> AnyCurrentValueListenerSet = new HashSet<Action<EAttributeType, float, float>>();

	// Token: 0x0400BFD7 RID: 49111
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchCurrentValueEventStat = Stat.Create("BaseAttributeComponent.DispatchCurrentValueEvent", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BFD8 RID: 49112
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EAttributeType, Stat> StatCurrentAttrEventMap = new Dictionary<EAttributeType, Stat>();

	// Token: 0x0400BFD9 RID: 49113
	[StaticVariableRuleIgnore]
	private static readonly Stat StatAnyCurrentAttrEvent = Stat.Create("AnyCurrentAttr event", "STATGROUP_KuroBattle", "");
}
