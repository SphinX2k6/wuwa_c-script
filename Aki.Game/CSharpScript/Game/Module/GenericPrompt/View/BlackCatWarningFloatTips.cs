using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004973 RID: 18803
	public class BlackCatWarningFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F279 RID: 193145 RVA: 0x00D24958 File Offset: 0x00D22B58
		[NullableContext(1)]
		public BlackCatWarningFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F27A RID: 193146 RVA: 0x00D24961 File Offset: 0x00D22B61
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> parameters)
		{
		}
	}
}
