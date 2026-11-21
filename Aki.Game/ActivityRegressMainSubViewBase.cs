using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000925 RID: 2341
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainSubViewBase : UiPanelBase
{
	// Token: 0x060067AC RID: 26540 RVA: 0x00207A98 File Offset: 0x00205C98
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem rootItem = base.GetRootItem();
		this.SequencePlayer = new UiSequencePlayer(rootItem);
	}

	// Token: 0x060067AD RID: 26541 RVA: 0x00207ABE File Offset: 0x00205CBE
	[NullableContext(1)]
	public void BindPassRecallBaseCallBack(TRegressOnPassRecallBaseCallback callBack)
	{
		this.PassRecallBaseCallBack = callBack;
	}

	// Token: 0x060067AE RID: 26542 RVA: 0x00207AC7 File Offset: 0x00205CC7
	public void UnBindPassRecallBaseCallBack()
	{
		this.PassRecallBaseCallBack = null;
	}

	// Token: 0x060067AF RID: 26543 RVA: 0x00207AD0 File Offset: 0x00205CD0
	protected void InvokePassRecallBaseCallBack(RegressBase config, EActivityMainSubViewNewType subViewType)
	{
		TRegressOnPassRecallBaseCallback passRecallBaseCallBack = this.PassRecallBaseCallBack;
		if (passRecallBaseCallBack == null)
		{
			return;
		}
		passRecallBaseCallBack(config, subViewType);
	}

	// Token: 0x060067B0 RID: 26544 RVA: 0x00207AE4 File Offset: 0x00205CE4
	public void Update(int subTabIndex = 0)
	{
		this.OnUpdate(subTabIndex);
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x00207AED File Offset: 0x00205CED
	protected virtual void OnUpdate(int subTabIndex)
	{
	}

	// Token: 0x060067B2 RID: 26546 RVA: 0x00207AF0 File Offset: 0x00205CF0
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.SequencePlayer.StopSequenceByKey("Start", false, false);
		CustomPromise<bool> stopPromise = new CustomPromise<bool>();
		this.SequencePlayer.PlaySequenceAsync("Start", stopPromise, false, false, null);
	}

	// Token: 0x060067B3 RID: 26547 RVA: 0x00207B38 File Offset: 0x00205D38
	public virtual void OnParentShow()
	{
		this.SequencePlayer.StopSequenceByKey("Start", false, false);
		CustomPromise<bool> stopPromise = new CustomPromise<bool>();
		this.SequencePlayer.PlaySequenceAsync("Start", stopPromise, false, false, null);
	}

	// Token: 0x04004249 RID: 16969
	protected TRegressOnPassRecallBaseCallback PassRecallBaseCallBack;

	// Token: 0x0400424A RID: 16970
	protected UiSequencePlayer SequencePlayer;
}
