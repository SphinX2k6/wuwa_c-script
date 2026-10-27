using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B75 RID: 23413
	public class CommonMultiInputView : CommonInputViewBase
	{
		// Token: 0x0603B3F1 RID: 242673 RVA: 0x00E20052 File Offset: 0x00E1E252
		[NullableContext(1)]
		public CommonMultiInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3F2 RID: 242674 RVA: 0x00E2005B File Offset: 0x00E1E25B
		protected override int GetMaxLimit()
		{
			return 40;
		}

		// Token: 0x0603B3F3 RID: 242675 RVA: 0x00E2005F File Offset: 0x00E1E25F
		protected override bool IsAllowMultiLine()
		{
			return !Info.Instance.IsIosPlatform();
		}
	}
}
