using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006091 RID: 24721
	public class SpringManorActivityOpenView : UiViewBase
	{
		// Token: 0x0603E7DF RID: 255967 RVA: 0x00F1AE97 File Offset: 0x00F19097
		[NullableContext(1)]
		public SpringManorActivityOpenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E7E0 RID: 255968 RVA: 0x00F1AEA0 File Offset: 0x00F190A0
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}
	}
}
