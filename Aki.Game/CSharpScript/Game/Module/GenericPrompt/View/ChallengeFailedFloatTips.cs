using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004975 RID: 18805
	public class ChallengeFailedFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F27D RID: 193149 RVA: 0x00D2496E File Offset: 0x00D22B6E
		[NullableContext(1)]
		public ChallengeFailedFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F27E RID: 193150 RVA: 0x00D24977 File Offset: 0x00D22B77
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
