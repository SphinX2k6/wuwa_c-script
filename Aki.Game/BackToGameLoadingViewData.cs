using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.Module.Loading.View;

// Token: 0x02002085 RID: 8325
public class BackToGameLoadingViewData
{
	// Token: 0x06010640 RID: 67136 RVA: 0x003FF275 File Offset: 0x003FD475
	public void RebootFinished()
	{
		this.LoadingWidget.RebootFinished();
	}

	// Token: 0x06010641 RID: 67137 RVA: 0x003FF282 File Offset: 0x003FD482
	public void SetProgress(float progress)
	{
		this.LoadingWidget.UpdateOtherLoadingProgerss(progress);
	}

	// Token: 0x06010642 RID: 67138 RVA: 0x003FF290 File Offset: 0x003FD490
	public void Close()
	{
		WBP_UILoading_C loadingWidget = this.LoadingWidget;
		if (loadingWidget == null || !loadingWidget.IsValid())
		{
			return;
		}
		this.LoadingWidget.RemoveFromParent();
	}

	// Token: 0x0400790F RID: 30991
	[Nullable(2)]
	public WBP_UILoading_C LoadingWidget;
}
