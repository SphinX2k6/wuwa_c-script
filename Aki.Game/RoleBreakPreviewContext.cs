using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF8 RID: 7672
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewContext
{
	// Token: 0x06012F42 RID: 77634 RVA: 0x0058D71C File Offset: 0x0058B91C
	public RoleBreakPreviewContext(RoleBreakPreviewViewModel vm, RoleBreakPreviewView view)
	{
		this.Vm = vm;
		this.CachedView = view;
	}

	// Token: 0x06012F43 RID: 77635 RVA: 0x0058D74C File Offset: 0x0058B94C
	public void Dispose()
	{
	}

	// Token: 0x17001CD0 RID: 7376
	// (get) Token: 0x06012F44 RID: 77636 RVA: 0x0058D74E File Offset: 0x0058B94E
	// (set) Token: 0x06012F45 RID: 77637 RVA: 0x0058D756 File Offset: 0x0058B956
	public int LevelContent
	{
		get
		{
			return this.LevelContentCore;
		}
		set
		{
			this.LevelContentCore = value;
			this.CachedView.RefreshLevelContent(value);
		}
	}

	// Token: 0x17001CD1 RID: 7377
	// (get) Token: 0x06012F46 RID: 77638 RVA: 0x0058D76B File Offset: 0x0058B96B
	// (set) Token: 0x06012F47 RID: 77639 RVA: 0x0058D773 File Offset: 0x0058B973
	public ILevelLayoutGridData[] LevelLayout
	{
		get
		{
			return this.LevelLayoutCore;
		}
		set
		{
			this.LevelLayoutCore = value;
			this.CachedView.RefreshLevelLayout(value);
		}
	}

	// Token: 0x17001CD2 RID: 7378
	// (get) Token: 0x06012F48 RID: 77640 RVA: 0x0058D788 File Offset: 0x0058B988
	// (set) Token: 0x06012F49 RID: 77641 RVA: 0x0058D790 File Offset: 0x0058B990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ISelectedData[] ItemLayout
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.ItemLayoutCore;
		}
		[param: Nullable(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.ItemLayoutCore = value;
			if (value != null)
			{
				this.CachedView.RefreshItemLayout(value);
			}
		}
	}

	// Token: 0x17001CD3 RID: 7379
	// (get) Token: 0x06012F4A RID: 77642 RVA: 0x0058D7A8 File Offset: 0x0058B9A8
	// (set) Token: 0x06012F4B RID: 77643 RVA: 0x0058D7B0 File Offset: 0x0058B9B0
	public int ChosenLevel
	{
		get
		{
			return this.ChosenLevelCore;
		}
		set
		{
			this.ChosenLevelCore = value;
			RoleLevelData levelData = this.Vm.CachedRoleInstance.GetLevelData();
			int breachLevel = levelData.GetBreachLevel();
			int maxBreachLevel = levelData.GetMaxBreachLevel();
			int maxLevel = levelData.GetBreachConfig(value).Value.MaxLevel;
			if (breachLevel >= value)
			{
				this.CachedView.RefreshLevelContentItem(false);
				this.CachedView.RefreshHasBrokenTip(true);
			}
			else
			{
				this.CachedView.RefreshLevelContentItem(true);
				this.CachedView.RefreshHasBrokenTip(false);
				this.LevelContent = maxLevel;
			}
			this.CachedView.RefreshLeftButton(value != 1);
			this.CachedView.RefreshRightButton(value != maxBreachLevel);
			this.LevelLayout = this.Vm.BuildLevelLayoutData(value);
			this.ItemLayout = this.Vm.BuildItemLayoutData(value);
		}
	}

	// Token: 0x0400A344 RID: 41796
	[Nullable(2)]
	private readonly RoleBreakPreviewViewModel Vm;

	// Token: 0x0400A345 RID: 41797
	[Nullable(2)]
	private readonly RoleBreakPreviewView CachedView;

	// Token: 0x0400A346 RID: 41798
	private int LevelContentCore = -1;

	// Token: 0x0400A347 RID: 41799
	private ILevelLayoutGridData[] LevelLayoutCore = new ILevelLayoutGridData[0];

	// Token: 0x0400A348 RID: 41800
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ISelectedData[] ItemLayoutCore;

	// Token: 0x0400A349 RID: 41801
	private int ChosenLevelCore = -1;
}
