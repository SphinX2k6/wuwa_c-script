using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059B6 RID: 22966
	public class WhiteCatWarningFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A3B0 RID: 238512 RVA: 0x00DD6D1D File Offset: 0x00DD4F1D
		[NullableContext(1)]
		public WhiteCatWarningFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3B1 RID: 238513 RVA: 0x00DD6D26 File Offset: 0x00DD4F26
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
