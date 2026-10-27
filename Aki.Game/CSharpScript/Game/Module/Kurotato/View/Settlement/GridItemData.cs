using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572C RID: 22316
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridItemData : MultiTemplateGridDataBase<GridItemCellData, GridItem>
	{
		// Token: 0x06038BC8 RID: 232392 RVA: 0x00D774E2 File Offset: 0x00D756E2
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038BC9 RID: 232393 RVA: 0x00D774E5 File Offset: 0x00D756E5
		public override GridItem CreateProxy()
		{
			return new GridItem();
		}
	}
}
