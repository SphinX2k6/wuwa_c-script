using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004703 RID: 18179
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridItemData : MultiTemplateGridDataBase<GridItemCellData, GridItem>
	{
		// Token: 0x0602DAD8 RID: 187096 RVA: 0x00CC5B8E File Offset: 0x00CC3D8E
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0602DAD9 RID: 187097 RVA: 0x00CC5B91 File Offset: 0x00CC3D91
		public override GridItem CreateProxy()
		{
			return new GridItem();
		}
	}
}
