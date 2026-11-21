using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044DD RID: 17629
	public class EnrichmentCollectProductItemView : ServerMarkItemView
	{
		// Token: 0x0602C87F RID: 182399 RVA: 0x00C81796 File Offset: 0x00C7F996
		[NullableContext(1)]
		public EnrichmentCollectProductItemView(EnrichmentCollectProductItem holder) : base(holder)
		{
		}

		// Token: 0x0602C880 RID: 182400 RVA: 0x00C8179F File Offset: 0x00C7F99F
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
