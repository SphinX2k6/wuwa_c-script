using System;
using System.Runtime.CompilerServices;

// Token: 0x02001477 RID: 5239
[NullableContext(1)]
[Nullable(0)]
public class RegressGradeButtonItem : RegressGradeUiItem
{
	// Token: 0x0600942E RID: 37934 RVA: 0x001FEC74 File Offset: 0x001FCE74
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

	// Token: 0x0600942F RID: 37935 RVA: 0x001FECC3 File Offset: 0x001FCEC3
	public void Bind(TRegressGradeButtonClickCallBack cb)
	{
		this.ClickCallBack = cb;
	}

	// Token: 0x06009430 RID: 37936 RVA: 0x001FECCC File Offset: 0x001FCECC
	public override void BindRedDot(ERedDotName dotName)
	{
		this.NormalButtonItem.BindRedDot(dotName, 0);
		this.HyperButtonItem.BindRedDot(dotName, 0);
	}

	// Token: 0x06009431 RID: 37937 RVA: 0x001FECE8 File Offset: 0x001FCEE8
	public void UnBind()
	{
		this.ClickCallBack = null;
	}

	// Token: 0x06009432 RID: 37938 RVA: 0x001FECF1 File Offset: 0x001FCEF1
	public void Clear()
	{
		this.NormalButtonItem.UnBindRedDot();
		this.HyperButtonItem.UnBindRedDot();
		this.UnBind();
	}

	// Token: 0x06009433 RID: 37939 RVA: 0x001FED0F File Offset: 0x001FCF0F
	private void OnNormalBtnClick()
	{
		TRegressGradeButtonClickCallBack clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(ERegressGrade.Normal);
	}

	// Token: 0x06009434 RID: 37940 RVA: 0x001FED22 File Offset: 0x001FCF22
	private void OnHyperBtnClick()
	{
		TRegressGradeButtonClickCallBack clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(ERegressGrade.Hyper);
	}

	// Token: 0x06009435 RID: 37941 RVA: 0x001FED35 File Offset: 0x001FCF35
	protected override void OnSetToNormal()
	{
		this.UpdateItemsVisibility();
	}

	// Token: 0x06009436 RID: 37942 RVA: 0x001FED3D File Offset: 0x001FCF3D
	protected override void OnSetToHyper()
	{
		this.UpdateItemsVisibility();
	}

	// Token: 0x06009437 RID: 37943 RVA: 0x001FED45 File Offset: 0x001FCF45
	private void UpdateItemsVisibility()
	{
		this.NormalButtonItem.SetUiActive(base.Grade == ERegressGrade.Normal);
		this.HyperButtonItem.SetUiActive(base.Grade == ERegressGrade.Hyper);
	}

	// Token: 0x040041C0 RID: 16832
	public ButtonItem NormalButtonItem;

	// Token: 0x040041C1 RID: 16833
	public ButtonItem HyperButtonItem;

	// Token: 0x040041C2 RID: 16834
	[Nullable(2)]
	private TRegressGradeButtonClickCallBack ClickCallBack;
}
