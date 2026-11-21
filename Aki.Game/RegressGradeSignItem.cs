using System;

// Token: 0x0200092C RID: 2348
public class RegressGradeSignItem : RegressGradeUiItem
{
	// Token: 0x060067CF RID: 26575 RVA: 0x00207CE3 File Offset: 0x00205EE3
	public RegressGradeSignItem(IRegressGradeSignContext normalContext, IRegressGradeSignContext hyperContext)
	{
		this.NormalContext = normalContext;
		this.HyperContext = hyperContext;
	}

	// Token: 0x060067D0 RID: 26576 RVA: 0x00207CF9 File Offset: 0x00205EF9
	public override void BindRedDot(ERedDotName dotName)
	{
		RedDotController.Instance.BindRedDot(dotName, this.NormalContext.RedDotItem, null, 0);
		RedDotController.Instance.BindRedDot(dotName, this.HyperContext.RedDotItem, null, 0);
		this.BindRedDotName = new ERedDotName?(dotName);
	}

	// Token: 0x060067D1 RID: 26577 RVA: 0x00207D38 File Offset: 0x00205F38
	public void UnBindRedDot()
	{
		if (this.BindRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.BindRedDotName.Value, this.NormalContext.RedDotItem, 0);
			RedDotController.Instance.UnBindGivenUi(this.BindRedDotName.Value, this.HyperContext.RedDotItem, 0);
			this.BindRedDotName = null;
		}
	}

	// Token: 0x060067D2 RID: 26578 RVA: 0x00207DA0 File Offset: 0x00205FA0
	public void Clear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060067D3 RID: 26579 RVA: 0x00207DA8 File Offset: 0x00205FA8
	protected override void OnSetToNormal()
	{
		this.UpdateContextVisibleByGrade();
	}

	// Token: 0x060067D4 RID: 26580 RVA: 0x00207DB0 File Offset: 0x00205FB0
	protected override void OnSetToHyper()
	{
		this.UpdateContextVisibleByGrade();
	}

	// Token: 0x060067D5 RID: 26581 RVA: 0x00207DB8 File Offset: 0x00205FB8
	private void UpdateContextVisibleByGrade()
	{
		this.UpdateContextVisibility(this.NormalContext, ERegressGrade.Normal);
		this.UpdateContextVisibility(this.HyperContext, ERegressGrade.Hyper);
	}

	// Token: 0x060067D6 RID: 26582 RVA: 0x00207DD4 File Offset: 0x00205FD4
	private void UpdateContextVisibility(IRegressGradeSignContext context, ERegressGrade targetGrade)
	{
		context.Btn.RootUIComp.Get().SetUIActive(targetGrade == base.Grade);
		context.CurrencyTexNode.SetUIActive(targetGrade == base.Grade);
		context.BubbleNode.SetUIActive(targetGrade == base.Grade);
	}

	// Token: 0x060067D7 RID: 26583 RVA: 0x00207E2D File Offset: 0x0020602D
	public IRegressGradeSignContext GetActivateContext()
	{
		if (base.Grade == ERegressGrade.Normal)
		{
			return this.NormalContext;
		}
		return this.HyperContext;
	}

	// Token: 0x060067D8 RID: 26584 RVA: 0x00207E48 File Offset: 0x00206048
	public void SetClaimRewardBubbleActive(bool active)
	{
		this.GetActivateContext().BubbleNode.SetUIActive(active);
	}

	// Token: 0x0400425B RID: 16987
	private ERedDotName? BindRedDotName;

	// Token: 0x0400425C RID: 16988
	public IRegressGradeSignContext NormalContext;

	// Token: 0x0400425D RID: 16989
	public IRegressGradeSignContext HyperContext;
}
