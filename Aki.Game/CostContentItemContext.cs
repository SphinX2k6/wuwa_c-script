using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF9 RID: 7673
[NullableContext(2)]
[Nullable(0)]
public class CostContentItemContext
{
	// Token: 0x06012F4C RID: 77644 RVA: 0x0058D87F File Offset: 0x0058BA7F
	[NullableContext(1)]
	public CostContentItemContext(RoleBreakPreviewViewModel vm, CostContentItem item)
	{
		this.Vm = vm;
		this.CachedPanel = item;
	}

	// Token: 0x06012F4D RID: 77645 RVA: 0x0058D8A3 File Offset: 0x0058BAA3
	public void Dispose()
	{
	}

	// Token: 0x17001CD4 RID: 7380
	// (get) Token: 0x06012F4E RID: 77646 RVA: 0x0058D8A5 File Offset: 0x0058BAA5
	// (set) Token: 0x06012F4F RID: 77647 RVA: 0x0058D8AD File Offset: 0x0058BAAD
	public int CostNumber
	{
		get
		{
			return this.CostNumberCore;
		}
		set
		{
			this.CostNumberCore = value;
			this.CachedPanel.RefreshCostNumber(value.ToString());
		}
	}

	// Token: 0x17001CD5 RID: 7381
	// (get) Token: 0x06012F50 RID: 77648 RVA: 0x0058D8C8 File Offset: 0x0058BAC8
	// (set) Token: 0x06012F51 RID: 77649 RVA: 0x0058D8D0 File Offset: 0x0058BAD0
	public EItemId MoneyIcon
	{
		get
		{
			return this.MoneyIconCore;
		}
		set
		{
			this.MoneyIconCore = value;
			this.CachedPanel.RefreshMoneyIcon(value);
		}
	}

	// Token: 0x17001CD6 RID: 7382
	// (get) Token: 0x06012F52 RID: 77650 RVA: 0x0058D8E5 File Offset: 0x0058BAE5
	// (set) Token: 0x06012F53 RID: 77651 RVA: 0x0058D8F0 File Offset: 0x0058BAF0
	public int ChosenLevel
	{
		get
		{
			return this.ChosenLevelCore;
		}
		set
		{
			this.ChosenLevelCore = value;
			ICostContentItemData costContentItemData = this.Vm.BuildCostContentItemData(value);
			if (costContentItemData != null)
			{
				this.CostNumber = costContentItemData.CostNum;
				this.MoneyIcon = costContentItemData.CostType;
				this.CachedPanel.Show(null);
				return;
			}
			this.CachedPanel.Hide(null);
		}
	}

	// Token: 0x0400A34A RID: 41802
	private readonly RoleBreakPreviewViewModel Vm;

	// Token: 0x0400A34B RID: 41803
	private readonly CostContentItem CachedPanel;

	// Token: 0x0400A34C RID: 41804
	private int CostNumberCore;

	// Token: 0x0400A34D RID: 41805
	private EItemId MoneyIconCore = EItemId.Gold;

	// Token: 0x0400A34E RID: 41806
	private int ChosenLevelCore = -1;
}
