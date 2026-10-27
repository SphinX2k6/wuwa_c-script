using System;

// Token: 0x02001478 RID: 5240
public class RegressGradeSignItem : RegressGradeUiItem
{
	// Token: 0x0600943A RID: 37946 RVA: 0x001FED7F File Offset: 0x001FCF7F
	public RegressGradeSignItem(IRegressGradeSignContext normalContext, IRegressGradeSignContext hyperContext)
	{
		this.NormalContext = normalContext;
		this.HyperContext = hyperContext;
	}

	// Token: 0x0600943B RID: 37947 RVA: 0x001FED95 File Offset: 0x001FCF95
	public override void BindRedDot(ERedDotName dotName)
	{
		RedDotController.Instance.BindRedDot(dotName, this.NormalContext.RedDotItem, null, 0);
		RedDotController.Instance.BindRedDot(dotName, this.HyperContext.RedDotItem, null, 0);
		this.BindRedDotName = new ERedDotName?(dotName);
	}

	// Token: 0x0600943C RID: 37948 RVA: 0x001FEDD4 File Offset: 0x001FCFD4
	public void UnBindRedDot()
	{
		if (this.BindRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.BindRedDotName.Value, this.NormalContext.RedDotItem, 0);
			RedDotController.Instance.UnBindGivenUi(this.BindRedDotName.Value, this.HyperContext.RedDotItem, 0);
			this.BindRedDotName = null;
		}
	}

	// Token: 0x0600943D RID: 37949 RVA: 0x001FEE3C File Offset: 0x001FD03C
	public void Clear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600943E RID: 37950 RVA: 0x001FEE44 File Offset: 0x001FD044
	protected override void OnSetToNormal()
	{
		this.UpdateContextVisibleByGrade();
	}

	// Token: 0x0600943F RID: 37951 RVA: 0x001FEE4C File Offset: 0x001FD04C
	protected override void OnSetToHyper()
	{
		this.UpdateContextVisibleByGrade();
	}

	// Token: 0x06009440 RID: 37952 RVA: 0x001FEE54 File Offset: 0x001FD054
	private void UpdateContextVisibleByGrade()
	{
		this.UpdateContextVisibility(this.NormalContext, ERegressGrade.Normal);
		this.UpdateContextVisibility(this.HyperContext, ERegressGrade.Hyper);
	}

	// Token: 0x06009441 RID: 37953 RVA: 0x001FEE70 File Offset: 0x001FD070
	private void UpdateContextVisibility(IRegressGradeSignContext context, ERegressGrade targetGrade)
	{
		context.Btn.RootUIComp.Get().SetUIActive(targetGrade == base.Grade);
		context.CurrencyTexNode.SetUIActive(targetGrade == base.Grade);
		context.BubbleNode.SetUIActive(targetGrade == base.Grade);
	}

	// Token: 0x06009442 RID: 37954 RVA: 0x001FEEC9 File Offset: 0x001FD0C9
	public IRegressGradeSignContext GetActivateContext()
	{
		if (base.Grade == ERegressGrade.Normal)
		{
			return this.NormalContext;
		}
		return this.HyperContext;
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x001FEEE4 File Offset: 0x001FD0E4
	public void SetClaimRewardBubbleActive(bool active)
	{
		this.GetActivateContext().BubbleNode.SetUIActive(active);
	}

	// Token: 0x040041C3 RID: 16835
	private ERedDotName? BindRedDotName;

	// Token: 0x040041C4 RID: 16836
	public IRegressGradeSignContext NormalContext;

	// Token: 0x040041C5 RID: 16837
	public IRegressGradeSignContext HyperContext;
}
