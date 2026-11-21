using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C00 RID: 19456
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class BossPilingBuffItemData : MultiTemplateGridDataBase<BossPilingBuffCountInfo, BossPilingBuffItem>
	{
		// Token: 0x060308AC RID: 198828 RVA: 0x00D86667 File Offset: 0x00D84867
		public BossPilingBuffItemData(BossPilingBuffCountInfo data)
		{
			base.Data = data;
		}

		// Token: 0x060308AD RID: 198829 RVA: 0x00D86676 File Offset: 0x00D84876
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060308AE RID: 198830 RVA: 0x00D86679 File Offset: 0x00D84879
		public override BossPilingBuffItem CreateProxy()
		{
			return new BossPilingBuffItem
			{
				OnToggleClicked = this.OnToggleClicked,
				IsSelectedCb = this.IsSelectedCb
			};
		}

		// Token: 0x04019B0E RID: 105230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingBuffCountInfo> OnToggleClicked;

		// Token: 0x04019B0F RID: 105231
		[Nullable(2)]
		public Func<int, bool> IsSelectedCb;
	}
}
