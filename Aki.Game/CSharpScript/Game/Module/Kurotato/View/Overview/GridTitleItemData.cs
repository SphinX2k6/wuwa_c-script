using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005750 RID: 22352
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridTitleItemData : MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem>
	{
		// Token: 0x06038D01 RID: 232705 RVA: 0x00D7E5DC File Offset: 0x00D7C7DC
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038D02 RID: 232706 RVA: 0x00D7E5DF File Offset: 0x00D7C7DF
		public override GridTitleItem CreateProxy()
		{
			return new GridTitleItem();
		}
	}
}
