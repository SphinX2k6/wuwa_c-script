using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x0200571F RID: 22303
	public class KurotatoShopOpenTipView : UiViewBase
	{
		// Token: 0x06038B5B RID: 232283 RVA: 0x00D751D3 File Offset: 0x00D733D3
		[NullableContext(1)]
		public KurotatoShopOpenTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038B5C RID: 232284 RVA: 0x00D751DC File Offset: 0x00D733DC
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}
	}
}
