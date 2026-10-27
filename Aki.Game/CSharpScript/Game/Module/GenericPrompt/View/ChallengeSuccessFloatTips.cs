using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200599D RID: 22941
	public class ChallengeSuccessFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A359 RID: 238425 RVA: 0x00DD54E9 File Offset: 0x00DD36E9
		[NullableContext(1)]
		public ChallengeSuccessFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A35A RID: 238426 RVA: 0x00DD54F2 File Offset: 0x00DD36F2
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> parameters)
		{
		}
	}
}
