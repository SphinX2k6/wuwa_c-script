using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200498F RID: 18831
	public class WhiteCatWarningFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2D7 RID: 193239 RVA: 0x00D261F5 File Offset: 0x00D243F5
		[NullableContext(1)]
		public WhiteCatWarningFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2D8 RID: 193240 RVA: 0x00D261FE File Offset: 0x00D243FE
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
