using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C1E RID: 23582
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBuffTitleItemData : MultiTemplateGridDataBase<int, BossPilingBuffTitleItem>
	{
		// Token: 0x0603B95B RID: 244059 RVA: 0x00E3620D File Offset: 0x00E3440D
		public BossPilingBuffTitleItemData(int data)
		{
			base.Data = data;
		}

		// Token: 0x0603B95C RID: 244060 RVA: 0x00E3621C File Offset: 0x00E3441C
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603B95D RID: 244061 RVA: 0x00E3621F File Offset: 0x00E3441F
		public override BossPilingBuffTitleItem CreateProxy()
		{
			return new BossPilingBuffTitleItem();
		}
	}
}
