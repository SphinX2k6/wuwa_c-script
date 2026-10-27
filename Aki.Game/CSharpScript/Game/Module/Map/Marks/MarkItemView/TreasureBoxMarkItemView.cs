using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005528 RID: 21800
	public class TreasureBoxMarkItemView : ServerMarkItemView
	{
		// Token: 0x06037A9A RID: 227994 RVA: 0x00D3667E File Offset: 0x00D3487E
		[NullableContext(1)]
		public TreasureBoxMarkItemView(TreasureBoxMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A9B RID: 227995 RVA: 0x00D36687 File Offset: 0x00D34887
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
