using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B55 RID: 19285
	public class CommonMultiInputView : CommonInputViewBase
	{
		// Token: 0x0603033E RID: 197438 RVA: 0x00D705C6 File Offset: 0x00D6E7C6
		[NullableContext(1)]
		public CommonMultiInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603033F RID: 197439 RVA: 0x00D705CF File Offset: 0x00D6E7CF
		protected override int GetMaxLimit()
		{
			return 40;
		}

		// Token: 0x06030340 RID: 197440 RVA: 0x00D705D3 File Offset: 0x00D6E7D3
		protected override bool IsAllowMultiLine()
		{
			return !Info.Instance.IsIosPlatform();
		}
	}
}
