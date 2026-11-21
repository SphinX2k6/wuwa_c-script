using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.Module.Loading.View;

// Token: 0x02001558 RID: 5464
public class BackToGameLoadingViewData
{
	// Token: 0x0600DAA8 RID: 55976 RVA: 0x0040B6BD File Offset: 0x004098BD
	public void RebootFinished()
	{
		this.LoadingWidget.RebootFinished();
	}

	// Token: 0x0600DAA9 RID: 55977 RVA: 0x0040B6CA File Offset: 0x004098CA
	public void SetProgress(float progress)
	{
		this.LoadingWidget.UpdateOtherLoadingProgerss(progress);
	}

	// Token: 0x0600DAAA RID: 55978 RVA: 0x0040B6D8 File Offset: 0x004098D8
	public void Close()
	{
		WBP_UILoading_C loadingWidget = this.LoadingWidget;
		if (loadingWidget == null || !loadingWidget.IsValid())
		{
			return;
		}
		this.LoadingWidget.RemoveFromParent();
	}

	// Token: 0x040079F8 RID: 31224
	[Nullable(2)]
	public WBP_UILoading_C LoadingWidget;
}
