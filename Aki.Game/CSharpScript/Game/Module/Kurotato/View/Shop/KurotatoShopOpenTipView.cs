using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x020046F6 RID: 18166
	public class KurotatoShopOpenTipView : UiViewBase
	{
		// Token: 0x0602DA6A RID: 186986 RVA: 0x00CC3807 File Offset: 0x00CC1A07
		[NullableContext(1)]
		public KurotatoShopOpenTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DA6B RID: 186987 RVA: 0x00CC3810 File Offset: 0x00CC1A10
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}
	}
}
