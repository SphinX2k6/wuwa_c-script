using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004BFE RID: 19454
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBuffTitleItemData : MultiTemplateGridDataBase<int, BossPilingBuffTitleItem>
	{
		// Token: 0x060308A6 RID: 198822 RVA: 0x00D86569 File Offset: 0x00D84769
		public BossPilingBuffTitleItemData(int data)
		{
			base.Data = data;
		}

		// Token: 0x060308A7 RID: 198823 RVA: 0x00D86578 File Offset: 0x00D84778
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060308A8 RID: 198824 RVA: 0x00D8657B File Offset: 0x00D8477B
		public override BossPilingBuffTitleItem CreateProxy()
		{
			return new BossPilingBuffTitleItem();
		}
	}
}
