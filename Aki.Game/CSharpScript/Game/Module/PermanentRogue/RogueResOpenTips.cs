using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005328 RID: 21288
	public class RogueResOpenTips : GenericPromptFloatTipsBase
	{
		// Token: 0x060366F7 RID: 222967 RVA: 0x00CE2C27 File Offset: 0x00CE0E27
		[NullableContext(1)]
		public RogueResOpenTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060366F8 RID: 222968 RVA: 0x00CE2C30 File Offset: 0x00CE0E30
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x060366F9 RID: 222969 RVA: 0x00CE2C32 File Offset: 0x00CE0E32
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
