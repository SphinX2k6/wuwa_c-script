using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004974 RID: 18804
	public class ChallengeAchieveFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F27B RID: 193147 RVA: 0x00D24963 File Offset: 0x00D22B63
		[NullableContext(1)]
		public ChallengeAchieveFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F27C RID: 193148 RVA: 0x00D2496C File Offset: 0x00D22B6C
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
