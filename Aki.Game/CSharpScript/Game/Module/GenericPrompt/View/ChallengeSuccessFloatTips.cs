using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004976 RID: 18806
	public class ChallengeSuccessFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F27F RID: 193151 RVA: 0x00D24979 File Offset: 0x00D22B79
		[NullableContext(1)]
		public ChallengeSuccessFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F280 RID: 193152 RVA: 0x00D24982 File Offset: 0x00D22B82
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> parameters)
		{
		}
	}
}
