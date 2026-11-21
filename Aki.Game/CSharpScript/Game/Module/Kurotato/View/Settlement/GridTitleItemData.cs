using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004700 RID: 18176
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridTitleItemData : MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem>
	{
		// Token: 0x0602DACB RID: 187083 RVA: 0x00CC5A10 File Offset: 0x00CC3C10
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0602DACC RID: 187084 RVA: 0x00CC5A13 File Offset: 0x00CC3C13
		public override GridTitleItem CreateProxy()
		{
			return new GridTitleItem();
		}
	}
}
