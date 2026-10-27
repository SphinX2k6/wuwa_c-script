using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200599A RID: 22938
	public class BlackCatWarningFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A353 RID: 238419 RVA: 0x00DD54C8 File Offset: 0x00DD36C8
		[NullableContext(1)]
		public BlackCatWarningFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A354 RID: 238420 RVA: 0x00DD54D1 File Offset: 0x00DD36D1
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> parameters)
		{
		}
	}
}
