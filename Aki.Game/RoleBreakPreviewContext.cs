using System;
using System.Runtime.CompilerServices;

// Token: 0x0200287D RID: 10365
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewContext
{
	// Token: 0x06015544 RID: 87364 RVA: 0x005629C0 File Offset: 0x00560BC0
	public RoleBreakPreviewContext(RoleBreakPreviewViewModel vm, RoleBreakPreviewView view)
	{
		this.Vm = vm;
		this.CachedView = view;
	}

	// Token: 0x06015545 RID: 87365 RVA: 0x005629F0 File Offset: 0x00560BF0
	public void Dispose()
	{
	}

	// Token: 0x17001C78 RID: 7288
	// (get) Token: 0x06015546 RID: 87366 RVA: 0x005629F2 File Offset: 0x00560BF2
	// (set) Token: 0x06015547 RID: 87367 RVA: 0x005629FA File Offset: 0x00560BFA
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

	// Token: 0x17001C79 RID: 7289
	// (get) Token: 0x06015548 RID: 87368 RVA: 0x00562A0F File Offset: 0x00560C0F
	// (set) Token: 0x06015549 RID: 87369 RVA: 0x00562A17 File Offset: 0x00560C17
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

	// Token: 0x17001C7A RID: 7290
	// (get) Token: 0x0601554A RID: 87370 RVA: 0x00562A2C File Offset: 0x00560C2C
	// (set) Token: 0x0601554B RID: 87371 RVA: 0x00562A34 File Offset: 0x00560C34
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

	// Token: 0x17001C7B RID: 7291
	// (get) Token: 0x0601554C RID: 87372 RVA: 0x00562A4C File Offset: 0x00560C4C
	// (set) Token: 0x0601554D RID: 87373 RVA: 0x00562A54 File Offset: 0x00560C54
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

	// Token: 0x04009F5B RID: 40795
	[Nullable(2)]
	private readonly RoleBreakPreviewViewModel Vm;

	// Token: 0x04009F5C RID: 40796
	[Nullable(2)]
	private readonly RoleBreakPreviewView CachedView;

	// Token: 0x04009F5D RID: 40797
	private int LevelContentCore = -1;

	// Token: 0x04009F5E RID: 40798
	private ILevelLayoutGridData[] LevelLayoutCore = new ILevelLayoutGridData[0];

	// Token: 0x04009F5F RID: 40799
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ISelectedData[] ItemLayoutCore;

	// Token: 0x04009F60 RID: 40800
	private int ChosenLevelCore = -1;
}
