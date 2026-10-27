using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001471 RID: 5233
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainSubViewBase : UiPanelBase
{
	// Token: 0x06009417 RID: 37911 RVA: 0x001FEB34 File Offset: 0x001FCD34
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem rootItem = base.GetRootItem();
		this.SequencePlayer = new UiSequencePlayer(rootItem);
	}

	// Token: 0x06009418 RID: 37912 RVA: 0x001FEB5A File Offset: 0x001FCD5A
	[NullableContext(1)]
	public void BindPassRecallBaseCallBack(TRegressOnPassRecallBaseCallback callBack)
	{
		this.PassRecallBaseCallBack = callBack;
	}

	// Token: 0x06009419 RID: 37913 RVA: 0x001FEB63 File Offset: 0x001FCD63
	public void UnBindPassRecallBaseCallBack()
	{
		this.PassRecallBaseCallBack = null;
	}

	// Token: 0x0600941A RID: 37914 RVA: 0x001FEB6C File Offset: 0x001FCD6C
	protected void InvokePassRecallBaseCallBack(RegressBase config, EActivityMainSubViewNewType subViewType)
	{
		TRegressOnPassRecallBaseCallback passRecallBaseCallBack = this.PassRecallBaseCallBack;
		if (passRecallBaseCallBack == null)
		{
			return;
		}
		passRecallBaseCallBack(config, subViewType);
	}

	// Token: 0x0600941B RID: 37915 RVA: 0x001FEB80 File Offset: 0x001FCD80
	public void Update(int subTabIndex = 0)
	{
		this.OnUpdate(subTabIndex);
	}

	// Token: 0x0600941C RID: 37916 RVA: 0x001FEB89 File Offset: 0x001FCD89
	protected virtual void OnUpdate(int subTabIndex)
	{
	}

	// Token: 0x0600941D RID: 37917 RVA: 0x001FEB8C File Offset: 0x001FCD8C
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.SequencePlayer.StopSequenceByKey("Start", false, false);
		CustomPromise<bool> stopPromise = new CustomPromise<bool>();
		this.SequencePlayer.PlaySequenceAsync("Start", stopPromise, false, false, null);
	}

	// Token: 0x0600941E RID: 37918 RVA: 0x001FEBD4 File Offset: 0x001FCDD4
	public virtual void OnParentShow()
	{
		this.SequencePlayer.StopSequenceByKey("Start", false, false);
		CustomPromise<bool> stopPromise = new CustomPromise<bool>();
		this.SequencePlayer.PlaySequenceAsync("Start", stopPromise, false, false, null);
	}

	// Token: 0x040041B1 RID: 16817
	protected TRegressOnPassRecallBaseCallback PassRecallBaseCallBack;

	// Token: 0x040041B2 RID: 16818
	protected UiSequencePlayer SequencePlayer;
}
