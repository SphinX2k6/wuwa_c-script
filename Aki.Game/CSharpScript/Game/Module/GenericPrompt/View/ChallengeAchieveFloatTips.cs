using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200599B RID: 22939
	public class ChallengeAchieveFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A355 RID: 238421 RVA: 0x00DD54D3 File Offset: 0x00DD36D3
		[NullableContext(1)]
		public ChallengeAchieveFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A356 RID: 238422 RVA: 0x00DD54DC File Offset: 0x00DD36DC
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
