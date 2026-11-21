using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004727 RID: 18215
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class GridTitleItemData : MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem>
	{
		// Token: 0x0602DC11 RID: 187409 RVA: 0x00CCCFBC File Offset: 0x00CCB1BC
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0602DC12 RID: 187410 RVA: 0x00CCCFBF File Offset: 0x00CCB1BF
		public override GridTitleItem CreateProxy()
		{
			return new GridTitleItem();
		}
	}
}
