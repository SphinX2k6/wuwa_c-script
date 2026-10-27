using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B76 RID: 23414
	public class CommonSingleInputView : CommonInputViewBase
	{
		// Token: 0x0603B3F4 RID: 242676 RVA: 0x00E20070 File Offset: 0x00E1E270
		[NullableContext(1)]
		public CommonSingleInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3F5 RID: 242677 RVA: 0x00E20079 File Offset: 0x00E1E279
		protected override int GetMaxLimit()
		{
			return 12;
		}

		// Token: 0x0603B3F6 RID: 242678 RVA: 0x00E2007D File Offset: 0x00E1E27D
		protected override bool IsAllowMultiLine()
		{
			return false;
		}
	}
}
