using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044FB RID: 17659
	public class TreasureBoxMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C96A RID: 182634 RVA: 0x00C843AA File Offset: 0x00C825AA
		[NullableContext(1)]
		public TreasureBoxMarkItemView(TreasureBoxMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C96B RID: 182635 RVA: 0x00C843B3 File Offset: 0x00C825B3
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
