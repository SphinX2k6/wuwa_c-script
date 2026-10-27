using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F73 RID: 12147
[NullableContext(1)]
[Nullable(0)]
public abstract class ModifierCalculator : SnapModifyBuffEffect
{
	// Token: 0x06019D16 RID: 105750 RVA: 0x006BC0EC File Offset: 0x006BA2EC
	protected ModifierCalculator(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D17 RID: 105751 RVA: 0x006BC10E File Offset: 0x006BA30E
	private float GetAttrValueWithThreshold(SnapshotPayload snapshots, EAttributeType attrId, EAttributeRefType attributeType, ESnapAttributeSourceType targetType)
	{
		if (this.AttributeThreshold > 0f)
		{
			return Math.Max(base.GetAttrValue(snapshots, attrId, attributeType, targetType) - this.AttributeThreshold, 0f);
		}
		return base.GetAttrValue(snapshots, attrId, attributeType, targetType);
	}

	// Token: 0x06019D18 RID: 105752 RVA: 0x006BC148 File Offset: 0x006BA348
	protected float CalculateValue(SnapshotPayload snapshots)
	{
		float num = this.RefParam1;
		if (this.StackParam.Length != 0 && this.StackParam[0] == 1L)
		{
			float num2 = num;
			IActiveBuff buff = base.Buff;
			num = num2 * (float)((buff != null) ? buff.StackCount : 1);
		}
		else if (this.StackParam.Length != 0 && this.StackParam[0] == 2L)
		{
			BaseDamageComponent baseDamageComponent = (this.StackParam[1] == 0L) ? snapshots.Attacker : snapshots.Target;
			float num3 = num;
			int? num4;
			if (baseDamageComponent == null)
			{
				num4 = null;
			}
			else
			{
				CharacterBuffComponent ownerBuffComponent = baseDamageComponent.OwnerBuffComponent;
				num4 = ((ownerBuffComponent != null) ? new int?(ownerBuffComponent.GetBuffTotalStackById(this.StackParam[2], false)) : null);
			}
			int? num5 = num4;
			num = num3 * (float)num5.GetValueOrDefault(1);
		}
		float refParam = this.RefParam2;
		float num6 = 0f;
		switch (this.CalculationPolicy)
		{
		case ESnapCalculateType.Add:
			num6 = num;
			break;
		case ESnapCalculateType.AddPerTenThousand:
		{
			float num7 = num * 0.0001f;
			num6 = this.GetAttrValueWithThreshold(snapshots, this.RefAttrId, this.RefValueType, this.RefTargetType) * num7;
			break;
		}
		case ESnapCalculateType.AddAttributeMultiPerTenThousand:
		{
			float num8 = num * 0.0001f;
			num6 = this.GetAttrValueWithThreshold(snapshots, this.RefAttrId, this.RefValueType, this.RefTargetType) * num8 + refParam;
			break;
		}
		}
		if (this.ModifierMax > 0f && num6 > this.ModifierMax)
		{
			num6 = this.ModifierMax;
		}
		return num6;
	}

	// Token: 0x0400C2DE RID: 49886
	public ESnapCalculateType CalculationPolicy;

	// Token: 0x0400C2DF RID: 49887
	public EAttributeType RefAttrId;

	// Token: 0x0400C2E0 RID: 49888
	public EAttributeRefType RefValueType;

	// Token: 0x0400C2E1 RID: 49889
	public long[] StackParam = new long[0];

	// Token: 0x0400C2E2 RID: 49890
	public ESnapAttributeSourceType RefTargetType = ESnapAttributeSourceType.Attacker;

	// Token: 0x0400C2E3 RID: 49891
	public float AttributeThreshold;

	// Token: 0x0400C2E4 RID: 49892
	public float ModifierMax;

	// Token: 0x0400C2E5 RID: 49893
	public float RefParam1;

	// Token: 0x0400C2E6 RID: 49894
	public float RefParam2;
}
