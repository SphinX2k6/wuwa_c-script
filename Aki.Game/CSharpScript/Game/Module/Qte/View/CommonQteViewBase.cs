using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Qte.View
{
	// Token: 0x02004FD1 RID: 20433
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonQteViewBase : UiTickViewBase
	{
		// Token: 0x06034487 RID: 214151 RVA: 0x00C46F34 File Offset: 0x00C45134
		protected CommonQteViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034488 RID: 214152
		public abstract void SetQteContext(CommonQteContextBase context);

		// Token: 0x06034489 RID: 214153
		public abstract void PlayQteStart();

		// Token: 0x0603448A RID: 214154
		public abstract void OnInputTest();
	}
}
