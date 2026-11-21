using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B56 RID: 19286
	public class CommonSingleInputView : CommonInputViewBase
	{
		// Token: 0x06030341 RID: 197441 RVA: 0x00D705E4 File Offset: 0x00D6E7E4
		[NullableContext(1)]
		public CommonSingleInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030342 RID: 197442 RVA: 0x00D705ED File Offset: 0x00D6E7ED
		protected override int GetMaxLimit()
		{
			return 12;
		}

		// Token: 0x06030343 RID: 197443 RVA: 0x00D705F1 File Offset: 0x00D6E7F1
		protected override bool IsAllowMultiLine()
		{
			return false;
		}
	}
}
