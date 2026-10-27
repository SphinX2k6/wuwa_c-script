using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F87 RID: 12167
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeExecution : PeriodExecution
{
	// Token: 0x06019D88 RID: 105864 RVA: 0x006BEBBE File Offset: 0x006BCDBE
	public ModifyFormationAttributeExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D89 RID: 105865 RVA: 0x006BEBC8 File Offset: 0x006BCDC8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.AttributeId = ((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0]) : 0);
		this.Rate = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f) * 0.0001f;
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		this.Overlay = (extraEffectParameters_ != null && extraEffectParameters_.Length > 1 && int.Parse(extraEffectParameters_[1]) == 1);
	}

	// Token: 0x06019D8A RID: 105866 RVA: 0x006BEC50 File Offset: 0x006BCE50
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

	// Token: 0x0400C32B RID: 49963
	public int AttributeId;

	// Token: 0x0400C32C RID: 49964
	public float Rate;

	// Token: 0x0400C32D RID: 49965
	public float Value;

	// Token: 0x0400C32E RID: 49966
	public bool Overlay;
}
