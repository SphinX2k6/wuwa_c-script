using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005729 RID: 22313
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridTitleItemData : MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem>
	{
		// Token: 0x06038BBB RID: 232379 RVA: 0x00D77364 File Offset: 0x00D75564
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038BBC RID: 232380 RVA: 0x00D77367 File Offset: 0x00D75567
		public override GridTitleItem CreateProxy()
		{
			return new GridTitleItem();
		}
	}
}
