using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F7B RID: 20347
	public abstract class TotalTopUpPreviewSubView : UiPanelBase, ITotalTopUpPreviewSubView
	{
		// Token: 0x060330C3 RID: 209091
		[NullableContext(1)]
		public abstract void ShowPreview(ITotalTopUpPreviewViewParam param);
	}
}
