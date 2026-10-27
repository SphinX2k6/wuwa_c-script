using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F94 RID: 24468
	public abstract class TotalTopUpPreviewSubView : UiPanelBase, ITotalTopUpPreviewSubView
	{
		// Token: 0x0603E129 RID: 254249
		[NullableContext(1)]
		public abstract void ShowPreview(ITotalTopUpPreviewViewParam param);
	}
}
