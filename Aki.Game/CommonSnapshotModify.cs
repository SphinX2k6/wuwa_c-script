using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F74 RID: 12148
[NullableContext(1)]
[Nullable(0)]
public class CommonSnapshotModify : ModifierCalculator
{
	// Token: 0x06019D19 RID: 105753 RVA: 0x006BC299 File Offset: 0x006BA499
	public CommonSnapshotModify(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D1A RID: 105754 RVA: 0x006BC2A8 File Offset: 0x006BA4A8
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
		long[] stackParam;
		if (extraEffectParameters_.Length <= 6)
		{
			stackParam = new long[1];
		}
		else
		{
			IEnumerable<string> source = extraEffectParameters_[6].Split('#', StringSplitOptions.None);
			Func<string, long> selector;
			if ((selector = CommonSnapshotModify.<>O.<0>__Parse) == null)
			{
				selector = (CommonSnapshotModify.<>O.<0>__Parse = new Func<string, long>(long.Parse));
			}
			stackParam = source.Select(selector).ToArray<long>();
		}
		this.StackParam = stackParam;
		this.RefParam1 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, level, 0f);
		this.RefParam2 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, level, 0f);
		this.NeedCheckCritical = this.RequireAndLimits.Requirements.Any((IRequirement require) => require.Type == EExtraEffectRequire.ShouldCritical);
	}

	// Token: 0x06019D1B RID: 105755 RVA: 0x006BC42E File Offset: 0x006BA62E
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

	// Token: 0x06019D1C RID: 105756 RVA: 0x006BC45C File Offset: 0x006BA65C
	protected override void OnExecuteSnap(Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		EAttributeType attrId = this.AttrId;
		float num2;
		float num = resultMap.TryGetValue(attrId, out num2) ? num2 : 0f;
		float num3 = base.CalculateValue(snapshots);
		resultMap[attrId] = num + num3;
	}

	// Token: 0x0400C2E7 RID: 49895
	public EAttributeType AttrId;

	// Token: 0x02009607 RID: 38407
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0403026E RID: 197230
		[Nullable(0)]
		public static Func<string, long> <0>__Parse;
	}
}
