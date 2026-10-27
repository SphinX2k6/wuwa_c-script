using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E60 RID: 11872
[NullableContext(1)]
[Nullable(0)]
public class BaseAttributeComponent : EntityComponent, IAttributeSet, IStaticVariableResetter
{
	// Token: 0x060194FD RID: 103677 RVA: 0x00682F50 File Offset: 0x00681150
	static BaseAttributeComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAttributeComponent.CreateStaticDefaultValue), new Action(BaseAttributeComponent.ResetStaticDefaultValue));
	}

	// Token: 0x060194FE RID: 103678 RVA: 0x00683033 File Offset: 0x00681233
	public static void CreateStaticDefaultValue()
	{
		BaseAttributeComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x060194FF RID: 103679 RVA: 0x0068303C File Offset: 0x0068123C
	public static void ResetStaticDefaultValue()
	{
		BaseAttributeComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x06019500 RID: 103680 RVA: 0x00683045 File Offset: 0x00681245
	protected override bool OnInit()
	{
		base.OnInit();
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.BuffComponent = base.Entity.GetComponent<BaseBuffComponent>();
		return true;
	}

	// Token: 0x06019501 RID: 103681 RVA: 0x00683074 File Offset: 0x00681274
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

	// Token: 0x06019502 RID: 103682 RVA: 0x006830D9 File Offset: 0x006812D9
	protected override void OnTick(float delta)
	{
		this.AutoRecoverAttr(delta);
	}

	// Token: 0x06019503 RID: 103683 RVA: 0x006830E4 File Offset: 0x006812E4
	public bool IsWritableAttribute(EAttributeType attrId)
	{
		return CharacterAttributeTypes.attrsAutoRecoverSpeedMap.ContainsKey(attrId) || CharacterAttributeTypes.attrsAutoRecoverMaxMap.ContainsKey(attrId) || (attrId == EAttributeType.Tough || attrId == EAttributeType.Jump) || (CharacterAttributeTypes.specialEnergyIds.Contains(attrId) && (this.BuffComponent == null || this.BuffComponent.HasBuffAuthority()));
	}

	// Token: 0x06019504 RID: 103684 RVA: 0x00683140 File Offset: 0x00681340
	public bool IsLocalAttribute(EAttributeType attrId)
	{
		return attrId == EAttributeType.Jump || (CharacterAttributeTypes.specialEnergyIds.Contains(attrId) && (this.BuffComponent == null || this.BuffComponent.HasBuffAuthority()));
	}

	// Token: 0x06019505 RID: 103685 RVA: 0x00683170 File Offset: 0x00681370
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
		if (!CharacterAttributeTypes.attrsNotClampZero.Contains(attrId))
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

	// Token: 0x06019506 RID: 103686 RVA: 0x00683208 File Offset: 0x00681408
	public void AddBaseValue(EAttributeType attrId, float value)
	{
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId] + value);
	}

	// Token: 0x06019507 RID: 103687 RVA: 0x0068321B File Offset: 0x0068141B
	public float GetBaseValue(EAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x06019508 RID: 103688 RVA: 0x00683225 File Offset: 0x00681425
	public float GetCurrentValue(EAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x06019509 RID: 103689 RVA: 0x0068322F File Offset: 0x0068142F
	public virtual void SeamlessTravelingRefresh()
	{
	}

	// Token: 0x0601950A RID: 103690 RVA: 0x00683231 File Offset: 0x00681431
	public virtual void ClearSpecialEnergy()
	{
	}

	// Token: 0x0601950B RID: 103691 RVA: 0x00683234 File Offset: 0x00681434
	private float? GetMaxValue(EAttributeType attrId)
	{
		EAttributeType attrId2;
		if (CharacterAttributeTypes.attributeIdsWithMax.TryGetValue(attrId, out attrId2))
		{
			return new float?(this.GetCurrentValue(attrId2));
		}
		return null;
	}

	// Token: 0x0601950C RID: 103692 RVA: 0x00683268 File Offset: 0x00681468
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

	// Token: 0x0601950D RID: 103693 RVA: 0x006833F4 File Offset: 0x006815F4
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
		if (!CharacterAttributeTypes.attrsNotClampZero.Contains(attrId))
		{
			num = Math.Max(num, 0f);
		}
		if (this.CurrentValues[(int)attrId] == num)
		{
			return;
		}
		this.CurrentValues[(int)attrId] = num;
	}

	// Token: 0x0601950E RID: 103694 RVA: 0x0068347C File Offset: 0x0068167C
	public AttributeSnapshot TakeSnapshot()
	{
		AttributeSnapshot attributeSnapshot = new AttributeSnapshot();
		Array.Copy(this.BaseValues, attributeSnapshot.BaseValues, 143);
		Array.Copy(this.CurrentValues, attributeSnapshot.CurrentValues, 143);
		return attributeSnapshot;
	}

	// Token: 0x0601950F RID: 103695 RVA: 0x006834BC File Offset: 0x006816BC
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

	// Token: 0x06019510 RID: 103696 RVA: 0x00683578 File Offset: 0x00681778
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

	// Token: 0x06019511 RID: 103697 RVA: 0x006835C4 File Offset: 0x006817C4
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

	// Token: 0x06019512 RID: 103698 RVA: 0x00683624 File Offset: 0x00681824
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

	// Token: 0x06019513 RID: 103699 RVA: 0x006838DC File Offset: 0x00681ADC
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

	// Token: 0x06019514 RID: 103700 RVA: 0x00683968 File Offset: 0x00681B68
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
				this.AddBaseValue(key, currentValue * num);
			}
		}
	}

	// Token: 0x06019515 RID: 103701 RVA: 0x006839FC File Offset: 0x00681BFC
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

	// Token: 0x06019516 RID: 103702 RVA: 0x00683AB8 File Offset: 0x00681CB8
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

	// Token: 0x06019517 RID: 103703 RVA: 0x00683AF4 File Offset: 0x00681CF4
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
			boundsLocker.UpperPercent = num * 0.0001f;
			boundsLocker.UpperOffset = offset;
			boundsLocker.LowerPercent = 0f;
			boundsLocker.LowerOffset = 0f;
		}
		else
		{
			boundsLocker.LockUpperBounds = false;
			boundsLocker.LockLowerBounds = true;
			boundsLocker.UpperPercent = (CharacterAttributeTypes.stateAttributeIds.Contains(attrId) > false);
			boundsLocker.UpperOffset = 0f;
			boundsLocker.LowerPercent = num * 0.0001f;
			boundsLocker.LowerOffset = offset;
		}
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId]);
		return true;
	}

	// Token: 0x06019518 RID: 103704 RVA: 0x00683BC8 File Offset: 0x00681DC8
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

	// Token: 0x06019519 RID: 103705 RVA: 0x00683C2C File Offset: 0x00681E2C
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
				float num3 = boundsLocker.LowerPercent * maxValue + boundsLocker.LowerOffset;
				num2 = new float?(Math.Max(num2.GetValueOrDefault(num3), num3));
			}
			if (boundsLocker.LockUpperBounds)
			{
				float val2 = boundsLocker.UpperPercent * maxValue + boundsLocker.UpperOffset;
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

	// Token: 0x0601951A RID: 103706 RVA: 0x00683D14 File Offset: 0x00681F14
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
			UpperPercent = num * 0.0001f,
			UpperOffset = offset,
			LowerPercent = 0f,
			LowerOffset = 0f
		};
		BoundsLocker boundsLocker2 = new BoundsLocker
		{
			LockUpperBounds = false,
			LockLowerBounds = true,
			UpperPercent = (CharacterAttributeTypes.stateAttributeIds.Contains(attributeId) > false),
			UpperOffset = 0f,
			LowerPercent = num * 0.0001f,
			LowerOffset = offset
		};
		BoundsLocker locker = (lockType == EAttributeIntervalLockType.UpperBoundLock) ? boundsLocker : boundsLocker2;
		this.AddBoundsLocker(attributeId, locker, handleId);
	}

	// Token: 0x0601951B RID: 103707 RVA: 0x00683DD7 File Offset: 0x00681FD7
	public void RemoveIntervalLock(EAttributeIntervalLockType lockType, int handleId, EAttributeType attributeId)
	{
		this.RemoveBoundsLocker(attributeId, handleId);
	}

	// Token: 0x0601951C RID: 103708 RVA: 0x00683DE4 File Offset: 0x00681FE4
	public void AddAttributeValueLock(int handleId, EAttributeType attributeId, float percent, float offset)
	{
		float num = CharacterAttributeTypes.stateAttributeIds.Contains(attributeId) ? percent : 0f;
		BoundsLocker locker = new BoundsLocker
		{
			LockUpperBounds = true,
			LockLowerBounds = true,
			UpperPercent = num * 0.0001f,
			UpperOffset = offset,
			LowerPercent = num * 0.0001f,
			LowerOffset = offset
		};
		this.AddBoundsLocker(attributeId, locker, handleId);
	}

	// Token: 0x0601951D RID: 103709 RVA: 0x00683E4F File Offset: 0x0068204F
	public void RemoveAttributeValueLock(int handleId, EAttributeType attributeId)
	{
		this.RemoveBoundsLocker(attributeId, handleId);
	}

	// Token: 0x0601951E RID: 103710 RVA: 0x00683E5C File Offset: 0x0068205C
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

	// Token: 0x0601951F RID: 103711 RVA: 0x00683F70 File Offset: 0x00682170
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

	// Token: 0x06019520 RID: 103712 RVA: 0x00683FA8 File Offset: 0x006821A8
	public void AddListeners(EAttributeType[] attrIds, Action<EAttributeType, float, float> callback, [Nullable(2)] string profileLabel = null)
	{
		foreach (EAttributeType attrId in attrIds)
		{
			this.AddListener(attrId, callback, profileLabel);
		}
	}

	// Token: 0x06019521 RID: 103713 RVA: 0x00683FD4 File Offset: 0x006821D4
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

	// Token: 0x06019522 RID: 103714 RVA: 0x00683FFC File Offset: 0x006821FC
	public void RemoveListeners(EAttributeType[] attrIds, Action<EAttributeType, float, float> callback)
	{
		foreach (EAttributeType attrId in attrIds)
		{
			this.RemoveListener(attrId, callback);
		}
	}

	// Token: 0x06019523 RID: 103715 RVA: 0x00684026 File Offset: 0x00682226
	public void AddGeneralListener(Action<EAttributeType, float, float> listener)
	{
		this.AnyCurrentValueListenerSet.Add(listener);
	}

	// Token: 0x06019524 RID: 103716 RVA: 0x00684035 File Offset: 0x00682235
	public void RemoveGeneralListener(Action<EAttributeType, float, float> listener)
	{
		this.AnyCurrentValueListenerSet.Remove(listener);
	}

	// Token: 0x06019525 RID: 103717 RVA: 0x00684044 File Offset: 0x00682244
	public void DispatchCurrentValueEvent(EAttributeType attrId, float newValue, float oldValue)
	{
		if (oldValue == newValue)
		{
			return;
		}
		this.DispatchCurrentValueEventImplement(attrId, newValue, oldValue);
	}

	// Token: 0x06019526 RID: 103718 RVA: 0x00684054 File Offset: 0x00682254
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

	// Token: 0x06019527 RID: 103719 RVA: 0x006841FC File Offset: 0x006823FC
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

	// Token: 0x06019528 RID: 103720 RVA: 0x00684224 File Offset: 0x00682424
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

	// Token: 0x06019529 RID: 103721 RVA: 0x006842C8 File Offset: 0x006824C8
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
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.LowerPercent * 100f);
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
						defaultInterpolatedStringHandler.AppendFormatted<float>(value2.UpperPercent * 100f);
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

	// Token: 0x0601952A RID: 103722 RVA: 0x006845FC File Offset: 0x006827FC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAttributeComponent baseAttributeComponent = (BaseAttributeComponent)componentTemplate;
		if (base.CanResetComponentProperty("ModifierScratch") && baseAttributeComponent.ModifierScratch != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<CharacterAttributeTypes.IModifier>>(this.ModifierScratch), "ModifierScratch"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("BoundsLockerScratch") && baseAttributeComponent.BoundsLockerScratch != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<IBoundsLocker>>(this.BoundsLockerScratch), "BoundsLockerScratch"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("BoundsLockerMap") && baseAttributeComponent.BoundsLockerMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EAttributeType, Dictionary<int, IBoundsLocker>>>(this.BoundsLockerMap), "BoundsLockerMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (baseAttributeComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (baseAttributeComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		return (!base.CanResetComponentProperty("CurrentValueListenerMap") || baseAttributeComponent.CurrentValueListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EAttributeType, HashSet<Action<EAttributeType, float, float>>>>(this.CurrentValueListenerMap), "CurrentValueListenerMap")) && (!base.CanResetComponentProperty("AnyCurrentValueListenerSet") || baseAttributeComponent.AnyCurrentValueListenerSet == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Action<EAttributeType, float, float>>(this.AnyCurrentValueListenerSet), "AnyCurrentValueListenerSet"));
	}

	// Token: 0x0400BC32 RID: 48178
	protected readonly float[] BaseValues = new float[143];

	// Token: 0x0400BC33 RID: 48179
	protected readonly float[] CurrentValues = new float[143];

	// Token: 0x0400BC34 RID: 48180
	protected readonly Dictionary<int, CharacterAttributeTypes.IModifier>[] ModifierLists = new Dictionary<int, CharacterAttributeTypes.IModifier>[143];

	// Token: 0x0400BC35 RID: 48181
	private readonly List<CharacterAttributeTypes.IModifier> ModifierScratch = new List<CharacterAttributeTypes.IModifier>();

	// Token: 0x0400BC36 RID: 48182
	private readonly List<IBoundsLocker> BoundsLockerScratch = new List<IBoundsLocker>();

	// Token: 0x0400BC37 RID: 48183
	protected readonly Dictionary<EAttributeType, Dictionary<int, IBoundsLocker>> BoundsLockerMap = new Dictionary<EAttributeType, Dictionary<int, IBoundsLocker>>();

	// Token: 0x0400BC38 RID: 48184
	[Nullable(2)]
	protected CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400BC39 RID: 48185
	[Nullable(2)]
	protected BaseBuffComponent BuffComponent;

	// Token: 0x0400BC3A RID: 48186
	public static int ModifierHandleGenerator;

	// Token: 0x0400BC3B RID: 48187
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateCurrentValueStat = Stat.Create("BaseAttributeComponent.UpdateCurrentValue", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC3C RID: 48188
	[StaticVariableRuleIgnore]
	private static readonly Stat AddModifierStat = Stat.Create("BaseAttributeComponent.AddModifier", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC3D RID: 48189
	[StaticVariableRuleIgnore]
	private static readonly Stat RemoveModifierStat = Stat.Create("BaseAttributeComponent.RemoveModifier", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC3E RID: 48190
	[StaticVariableRuleIgnore]
	private static readonly Stat EvaluateModifiersStat = Stat.Create("BaseAttributeComponent.EvaluateModifiers", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC3F RID: 48191
	[StaticVariableRuleIgnore]
	private static readonly Stat AutoRecoverAttrStat = Stat.Create("BaseAttributeComponent.AutoRecoverAttr", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC40 RID: 48192
	protected readonly Dictionary<EAttributeType, HashSet<Action<EAttributeType, float, float>>> CurrentValueListenerMap = new Dictionary<EAttributeType, HashSet<Action<EAttributeType, float, float>>>();

	// Token: 0x0400BC41 RID: 48193
	protected readonly HashSet<Action<EAttributeType, float, float>> AnyCurrentValueListenerSet = new HashSet<Action<EAttributeType, float, float>>();

	// Token: 0x0400BC42 RID: 48194
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchCurrentValueEventStat = Stat.Create("BaseAttributeComponent.DispatchCurrentValueEvent", "STATGROUP_KuroBattle", "");

	// Token: 0x0400BC43 RID: 48195
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EAttributeType, Stat> StatCurrentAttrEventMap = new Dictionary<EAttributeType, Stat>();

	// Token: 0x0400BC44 RID: 48196
	[StaticVariableRuleIgnore]
	private static readonly Stat StatAnyCurrentAttrEvent = Stat.Create("AnyCurrentAttr event", "STATGROUP_KuroBattle", "");
}
