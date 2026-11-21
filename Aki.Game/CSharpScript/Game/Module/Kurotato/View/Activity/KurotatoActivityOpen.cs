using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200475C RID: 18268
	public class KurotatoActivityOpen : UiViewBase
	{
		// Token: 0x0602DDB1 RID: 187825 RVA: 0x00CD5A68 File Offset: 0x00CD3C68
		[NullableContext(1)]
		public KurotatoActivityOpen(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DDB2 RID: 187826 RVA: 0x00CD5A71 File Offset: 0x00CD3C71
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}
	}
}
