using System;

// Token: 0x0200328D RID: 12941
public class DamageOptimizationStrategy : BaseOptimizationStrategy
{
	// Token: 0x0601C047 RID: 114759 RVA: 0x007C9CEC File Offset: 0x007C7EEC
	protected override void OnEnable()
	{
		Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "DamageUIOptimizationStrategy Enable", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DamageOptimizationId = DamageUiController.Instance.EnableDamageViewOptimization();
	}

	// Token: 0x0601C048 RID: 114760 RVA: 0x007C9D28 File Offset: 0x007C7F28
	protected override void OnDisable()
	{
		Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "DamageUIOptimizationStrategy Disable", default(ReadOnlySpan<ValueTuple<string, object>>));
		DamageUiController.Instance.DisableDamageViewOptimization(this.DamageOptimizationId);
	}

	// Token: 0x0400DD85 RID: 56709
	private int DamageOptimizationId;
}
