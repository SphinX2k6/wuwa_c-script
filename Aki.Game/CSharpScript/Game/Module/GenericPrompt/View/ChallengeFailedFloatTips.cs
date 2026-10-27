using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200599C RID: 22940
	public class ChallengeFailedFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A357 RID: 238423 RVA: 0x00DD54DE File Offset: 0x00DD36DE
		[NullableContext(1)]
		public ChallengeFailedFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A358 RID: 238424 RVA: 0x00DD54E7 File Offset: 0x00DD36E7
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
