using System;

// Token: 0x020027FE RID: 10238
public class DamageOptimizationStrategy : BaseOptimizationStrategy
{
	// Token: 0x06019C59 RID: 105561 RVA: 0x007F0F44 File Offset: 0x007EF144
	protected override void OnEnable()
	{
		Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "DamageUIOptimizationStrategy Enable", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DamageOptimizationId = DamageUiController.Instance.EnableDamageViewOptimization();
	}

	// Token: 0x06019C5A RID: 105562 RVA: 0x007F0F80 File Offset: 0x007EF180
	protected override void OnDisable()
	{
		Log.Instance.Info(ELogModule.Optimization, ELogAuthor.LJM, "DamageUIOptimizationStrategy Disable", default(ReadOnlySpan<ValueTuple<string, object>>));
		DamageUiController.Instance.DisableDamageViewOptimization(this.DamageOptimizationId);
	}

	// Token: 0x1700297C RID: 10620
	// (get) Token: 0x06019C5B RID: 105563 RVA: 0x007F0FBC File Offset: 0x007EF1BC
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700297D RID: 10621
	// (get) Token: 0x06019C5C RID: 105564 RVA: 0x007F0FBF File Offset: 0x007EF1BF
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E22C RID: 57900
	private int DamageOptimizationId;
}
