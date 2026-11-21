using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024C8 RID: 9416
[NullableContext(1)]
[Nullable(0)]
public class CommonSnapshotModify : ModifierCalculator
{
	// Token: 0x0601762B RID: 95787 RVA: 0x006E2B85 File Offset: 0x006E0D85
	public CommonSnapshotModify(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601762C RID: 95788 RVA: 0x006E2B94 File Offset: 0x006E0D94
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		float[] extraEffectGrowParameters2 = parameters.ExtraEffectGrowParameters2;
		int level = this.Level;
		this.TargetType = new ESnapTargetType?((ESnapTargetType)int.Parse(extraEffectParameters_[0]));
		this.AttrId = (EAttributeType)int.Parse(extraEffectParameters_[1]);
		this.CalculationPolicy = (ESnapCalculateType)int.Parse(extraEffectParameters_[2]);
		if (extraEffectParameters_.Length > 3 && !string.IsNullOrEmpty(extraEffectParameters_[3]))
		{
			string[] array = extraEffectParameters_[3].Split('#', StringSplitOptions.None);
			this.RefAttrId = (EAttributeType)int.Parse(array[0]);
			this.AttributeThreshold = (float)((array.Length > 1) ? int.Parse(array[1]) : 0);
			this.ModifierMax = (float)((array.Length > 2) ? int.Parse(array[2]) : 0);
		}
		if (this.CalculationPolicy == ESnapCalculateType.AddPerTenThousand)
		{
			this.RefAttrId = this.AttrId;
		}
		this.RefTargetType = (ESnapAttributeSourceType)int.Parse(extraEffectParameters_[4]);
		this.RefValueType = (EAttributeRefType)int.Parse(extraEffectParameters_[5]);
		if (extraEffectParameters_.Length > 6)
		{
			string[] array2 = extraEffectParameters_[6].Split('#', StringSplitOptions.None);
			this.StackParam = new long[array2.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				this.StackParam[i] = long.Parse(array2[i]);
			}
		}
		else
		{
			this.StackParam = new long[1];
		}
		this.RefParam1 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, level, 0f);
		this.RefParam2 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, level, 0f);
		this.NeedCheckCritical = false;
		for (int j = 0; j < this.RequireAndLimits.Requirements.Length; j++)
		{
			if (this.RequireAndLimits.Requirements[j].Type == EExtraEffectRequire.ShouldCritical)
			{
				this.NeedCheckCritical = true;
				return;
			}
		}
	}

	// Token: 0x0601762D RID: 95789 RVA: 0x006E2D38 File Offset: 0x006E0F38
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length < 2)
		{
			return false;
		}
		this.OnExecuteSnap((Dictionary<EAttributeType, float>)parameters[0], (SnapshotPayload)parameters[1]);
		return true;
	}

	// Token: 0x0601762E RID: 95790 RVA: 0x006E2D64 File Offset: 0x006E0F64
	protected override void OnExecuteSnap(Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		EAttributeType attrId = this.AttrId;
		float num2;
		float num = resultMap.TryGetValue(attrId, out num2) ? num2 : 0f;
		float num3 = base.CalculateValue(snapshots);
		resultMap[attrId] = num + num3;
	}

	// Token: 0x0400C690 RID: 50832
	public EAttributeType AttrId;
}
