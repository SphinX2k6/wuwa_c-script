using System;
using System.Runtime.CompilerServices;

// Token: 0x0200092B RID: 2347
[NullableContext(1)]
[Nullable(0)]
public class RegressGradeButtonItem : RegressGradeUiItem
{
	// Token: 0x060067C3 RID: 26563 RVA: 0x00207BD8 File Offset: 0x00205DD8
	public RegressGradeButtonItem(ButtonItem normalButtonItem, ButtonItem hyperButtonItem)
	{
		this.NormalButtonItem = normalButtonItem;
		this.HyperButtonItem = hyperButtonItem;
		this.NormalButtonItem.SetFunction(delegate(int _)
		{
			this.OnNormalBtnClick();
		});
		this.HyperButtonItem.SetFunction(delegate(int _)
		{
			this.OnHyperBtnClick();
		});
	}

	// Token: 0x060067C4 RID: 26564 RVA: 0x00207C27 File Offset: 0x00205E27
	public void Bind(TRegressGradeButtonClickCallBack cb)
	{
		this.ClickCallBack = cb;
	}

	// Token: 0x060067C5 RID: 26565 RVA: 0x00207C30 File Offset: 0x00205E30
	public override void BindRedDot(ERedDotName dotName)
	{
		this.NormalButtonItem.BindRedDot(dotName, 0);
		this.HyperButtonItem.BindRedDot(dotName, 0);
	}

	// Token: 0x060067C6 RID: 26566 RVA: 0x00207C4C File Offset: 0x00205E4C
	public void UnBind()
	{
		this.ClickCallBack = null;
	}

	// Token: 0x060067C7 RID: 26567 RVA: 0x00207C55 File Offset: 0x00205E55
	public void Clear()
	{
		this.NormalButtonItem.UnBindRedDot();
		this.HyperButtonItem.UnBindRedDot();
		this.UnBind();
	}

	// Token: 0x060067C8 RID: 26568 RVA: 0x00207C73 File Offset: 0x00205E73
	private void OnNormalBtnClick()
	{
		TRegressGradeButtonClickCallBack clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(ERegressGrade.Normal);
	}

	// Token: 0x060067C9 RID: 26569 RVA: 0x00207C86 File Offset: 0x00205E86
	private void OnHyperBtnClick()
	{
		TRegressGradeButtonClickCallBack clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(ERegressGrade.Hyper);
	}

	// Token: 0x060067CA RID: 26570 RVA: 0x00207C99 File Offset: 0x00205E99
	protected override void OnSetToNormal()
	{
		this.UpdateItemsVisibility();
	}

	// Token: 0x060067CB RID: 26571 RVA: 0x00207CA1 File Offset: 0x00205EA1
	protected override void OnSetToHyper()
	{
		this.UpdateItemsVisibility();
	}

	// Token: 0x060067CC RID: 26572 RVA: 0x00207CA9 File Offset: 0x00205EA9
	private void UpdateItemsVisibility()
	{
		this.NormalButtonItem.SetUiActive(base.Grade == ERegressGrade.Normal);
		this.HyperButtonItem.SetUiActive(base.Grade == ERegressGrade.Hyper);
	}

	// Token: 0x04004258 RID: 16984
	public ButtonItem NormalButtonItem;

	// Token: 0x04004259 RID: 16985
	public ButtonItem HyperButtonItem;

	// Token: 0x0400425A RID: 16986
	[Nullable(2)]
	private TRegressGradeButtonClickCallBack ClickCallBack;
}
