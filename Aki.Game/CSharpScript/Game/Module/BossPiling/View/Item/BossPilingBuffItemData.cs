using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C20 RID: 23584
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class BossPilingBuffItemData : MultiTemplateGridDataBase<BossPilingBuffCountInfo, BossPilingBuffItem>
	{
		// Token: 0x0603B961 RID: 244065 RVA: 0x00E3630B File Offset: 0x00E3450B
		public BossPilingBuffItemData(BossPilingBuffCountInfo data)
		{
			base.Data = data;
		}

		// Token: 0x0603B962 RID: 244066 RVA: 0x00E3631A File Offset: 0x00E3451A
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603B963 RID: 244067 RVA: 0x00E3631D File Offset: 0x00E3451D
		public override BossPilingBuffItem CreateProxy()
		{
			return new BossPilingBuffItem
			{
				OnToggleClicked = this.OnToggleClicked,
				IsSelectedCb = this.IsSelectedCb
			};
		}

		// Token: 0x0401F05D RID: 127069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingBuffCountInfo> OnToggleClicked;

		// Token: 0x0401F05E RID: 127070
		[Nullable(2)]
		public Func<int, bool> IsSelectedCb;
	}
}
