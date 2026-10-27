using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02004723 RID: 18211
	public class WuWaGoPopupView : UiViewBase
	{
		// Token: 0x0602F96B RID: 194923 RVA: 0x00B05BFD File Offset: 0x00B03DFD
		[NullableContext(1)]
		public WuWaGoPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F96C RID: 194924 RVA: 0x00B05C06 File Offset: 0x00B03E06
		protected override void OnAfterPlayStartSequence()
		{
			this.LastHide = true;
			base.CloseMe(null);
		}
	}
}
