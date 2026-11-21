using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Qte.View
{
	// Token: 0x02003F9A RID: 16282
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonQteViewBase : UiTickViewBase
	{
		// Token: 0x060292F5 RID: 168693 RVA: 0x00B906EC File Offset: 0x00B8E8EC
		protected CommonQteViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060292F6 RID: 168694
		public abstract void SetQteContext(CommonQteContextBase context);

		// Token: 0x060292F7 RID: 168695
		public abstract void PlayQteStart();

		// Token: 0x060292F8 RID: 168696
		public abstract void OnInputTest();
	}
}
