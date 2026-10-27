using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005785 RID: 22405
	public class KurotatoActivityOpen : UiViewBase
	{
		// Token: 0x06038EA1 RID: 233121 RVA: 0x00D86D24 File Offset: 0x00D84F24
		[NullableContext(1)]
		public KurotatoActivityOpen(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038EA2 RID: 233122 RVA: 0x00D86D2D File Offset: 0x00D84F2D
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}
	}
}
