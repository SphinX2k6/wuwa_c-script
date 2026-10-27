using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200127B RID: 4731
public class FightPhotoLoadingView : UiViewBase
{
	// Token: 0x0600810E RID: 33038 RVA: 0x001B582B File Offset: 0x001B3A2B
	[NullableContext(1)]
	public FightPhotoLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600810F RID: 33039 RVA: 0x001B5834 File Offset: 0x001B3A34
	protected override void OnAfterShow()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoMainView, this.OpenParam, delegate(bool _, int _)
		{
			base.CloseMe(null);
		});
	}
}
