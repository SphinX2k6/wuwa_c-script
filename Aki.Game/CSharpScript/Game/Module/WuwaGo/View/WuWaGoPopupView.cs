using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02003654 RID: 13908
	public class WuWaGoPopupView : UiViewBase
	{
		// Token: 0x06024135 RID: 147765 RVA: 0x00A35A89 File Offset: 0x00A33C89
		[NullableContext(1)]
		public WuWaGoPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06024136 RID: 147766 RVA: 0x00A35A92 File Offset: 0x00A33C92
		protected override void OnAfterPlayStartSequence()
		{
			this.LastHide = true;
			base.CloseMe(null);
		}
	}
}
