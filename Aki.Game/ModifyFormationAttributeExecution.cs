using System;
using System.Runtime.CompilerServices;

// Token: 0x020024DB RID: 9435
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeExecution : PeriodExecution
{
	// Token: 0x0601769A RID: 95898 RVA: 0x006E549E File Offset: 0x006E369E
	public ModifyFormationAttributeExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x0601769B RID: 95899 RVA: 0x006E54A8 File Offset: 0x006E36A8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.AttributeId = ((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0]) : 0);
		this.Rate = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f) * 0.0001f;
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		this.Overlay = (extraEffectParameters_ != null && extraEffectParameters_.Length > 1 && int.Parse(extraEffectParameters_[1]) == 1);
	}

	// Token: 0x0601769C RID: 95900 RVA: 0x006E5530 File Offset: 0x006E3730
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		EFormationAttributeId attributeId = (EFormationAttributeId)this.AttributeId;
		float max = FormationAttributeController.Instance.GetMax(attributeId);
		if (this.Overlay)
		{
			FormationAttributeController.Instance.SetValue(attributeId, max * this.Rate + this.Value);
		}
		else
		{
			FormationAttributeController.Instance.AddValue(attributeId, max * this.Rate + this.Value);
		}
		return null;
	}

	// Token: 0x0400C6D4 RID: 50900
	public int AttributeId;

	// Token: 0x0400C6D5 RID: 50901
	public float Rate;

	// Token: 0x0400C6D6 RID: 50902
	public float Value;

	// Token: 0x0400C6D7 RID: 50903
	public bool Overlay;
}
