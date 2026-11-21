using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200500F RID: 20495
	public class SpringManorActivityOpenView : UiViewBase
	{
		// Token: 0x060334A3 RID: 210083 RVA: 0x00E61C5B File Offset: 0x00E5FE5B
		[NullableContext(1)]
		public SpringManorActivityOpenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060334A4 RID: 210084 RVA: 0x00E61C64 File Offset: 0x00E5FE64
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}
	}
}
