using System;
using System.Runtime.CompilerServices;

// Token: 0x0200287E RID: 10366
[NullableContext(2)]
[Nullable(0)]
public class CostContentItemContext
{
	// Token: 0x0601554E RID: 87374 RVA: 0x00562B23 File Offset: 0x00560D23
	[NullableContext(1)]
	public CostContentItemContext(RoleBreakPreviewViewModel vm, CostContentItem item)
	{
		this.Vm = vm;
		this.CachedPanel = item;
	}

	// Token: 0x0601554F RID: 87375 RVA: 0x00562B47 File Offset: 0x00560D47
	public void Dispose()
	{
	}

	// Token: 0x17001C7C RID: 7292
	// (get) Token: 0x06015550 RID: 87376 RVA: 0x00562B49 File Offset: 0x00560D49
	// (set) Token: 0x06015551 RID: 87377 RVA: 0x00562B51 File Offset: 0x00560D51
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

	// Token: 0x17001C7D RID: 7293
	// (get) Token: 0x06015552 RID: 87378 RVA: 0x00562B6C File Offset: 0x00560D6C
	// (set) Token: 0x06015553 RID: 87379 RVA: 0x00562B74 File Offset: 0x00560D74
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

	// Token: 0x17001C7E RID: 7294
	// (get) Token: 0x06015554 RID: 87380 RVA: 0x00562B89 File Offset: 0x00560D89
	// (set) Token: 0x06015555 RID: 87381 RVA: 0x00562B94 File Offset: 0x00560D94
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

	// Token: 0x04009F61 RID: 40801
	private readonly RoleBreakPreviewViewModel Vm;

	// Token: 0x04009F62 RID: 40802
	private readonly CostContentItem CachedPanel;

	// Token: 0x04009F63 RID: 40803
	private int CostNumberCore;

	// Token: 0x04009F64 RID: 40804
	private EItemId MoneyIconCore = EItemId.Gold;

	// Token: 0x04009F65 RID: 40805
	private int ChosenLevelCore = -1;
}
