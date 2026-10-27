using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005159 RID: 20825
	public class PhantomArenaActivityOpen : GenericPromptFloatTipsBase
	{
		// Token: 0x060353D7 RID: 218071 RVA: 0x00C9ADE5 File Offset: 0x00C98FE5
		[NullableContext(1)]
		public PhantomArenaActivityOpen(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060353D8 RID: 218072 RVA: 0x00C9ADEE File Offset: 0x00C98FEE
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x060353D9 RID: 218073 RVA: 0x00C9ADF0 File Offset: 0x00C98FF0
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
