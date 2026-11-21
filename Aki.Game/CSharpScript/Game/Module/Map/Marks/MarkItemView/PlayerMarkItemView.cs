using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F0 RID: 17648
	public class PlayerMarkItemView : MarkItemView
	{
		// Token: 0x0602C925 RID: 182565 RVA: 0x00C83607 File Offset: 0x00C81807
		[NullableContext(1)]
		public PlayerMarkItemView(PlayerMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C926 RID: 182566 RVA: 0x00C83610 File Offset: 0x00C81810
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
