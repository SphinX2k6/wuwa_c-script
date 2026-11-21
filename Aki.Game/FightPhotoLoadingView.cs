using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200072F RID: 1839
public class FightPhotoLoadingView : UiViewBase
{
	// Token: 0x060054A5 RID: 21669 RVA: 0x001BE4FB File Offset: 0x001BC6FB
	[NullableContext(1)]
	public FightPhotoLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x001BE504 File Offset: 0x001BC704
	protected override void OnAfterShow()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoMainView, this.OpenParam, delegate(bool _, int _)
		{
			base.CloseMe(null);
		});
	}
}
