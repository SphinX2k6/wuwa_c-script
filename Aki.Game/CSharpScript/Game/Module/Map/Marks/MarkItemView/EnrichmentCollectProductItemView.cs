using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200550A RID: 21770
	public class EnrichmentCollectProductItemView : ServerMarkItemView
	{
		// Token: 0x060379B1 RID: 227761 RVA: 0x00D338C2 File Offset: 0x00D31AC2
		[NullableContext(1)]
		public EnrichmentCollectProductItemView(EnrichmentCollectProductItem holder) : base(holder)
		{
		}

		// Token: 0x060379B2 RID: 227762 RVA: 0x00D338CB File Offset: 0x00D31ACB
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
