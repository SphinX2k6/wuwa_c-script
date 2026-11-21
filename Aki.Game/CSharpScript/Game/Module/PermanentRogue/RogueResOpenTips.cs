using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042F8 RID: 17144
	public class RogueResOpenTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602B5F3 RID: 177651 RVA: 0x00C305F7 File Offset: 0x00C2E7F7
		[NullableContext(1)]
		public RogueResOpenTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B5F4 RID: 177652 RVA: 0x00C30600 File Offset: 0x00C2E800
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0602B5F5 RID: 177653 RVA: 0x00C30602 File Offset: 0x00C2E802
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
