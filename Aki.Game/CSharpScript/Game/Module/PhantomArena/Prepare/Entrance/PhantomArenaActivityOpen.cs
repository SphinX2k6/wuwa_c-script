using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004129 RID: 16681
	public class PhantomArenaActivityOpen : GenericPromptFloatTipsBase
	{
		// Token: 0x0602A2D3 RID: 172755 RVA: 0x00BE82E5 File Offset: 0x00BE64E5
		[NullableContext(1)]
		public PhantomArenaActivityOpen(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A2D4 RID: 172756 RVA: 0x00BE82EE File Offset: 0x00BE64EE
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0602A2D5 RID: 172757 RVA: 0x00BE82F0 File Offset: 0x00BE64F0
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}
	}
}
