using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using Cysharp.Threading.Tasks;

// Token: 0x02001DF7 RID: 7671
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewViewModel
{
	// Token: 0x06012F2B RID: 77611 RVA: 0x0058D352 File Offset: 0x0058B552
	public void Dispose()
	{
		this.ChosenLevelCore = -1;
		this.UnbindView();
		this.UnbindCostContentItem();
	}

	// Token: 0x17001CCE RID: 7374
	// (get) Token: 0x06012F2C RID: 77612 RVA: 0x0058D367 File Offset: 0x0058B567
	// (set) Token: 0x06012F2D RID: 77613 RVA: 0x0058D36F File Offset: 0x0058B56F
	public RoleDataBase CachedRoleInstance
	{
		get
		{
			return this.CachedRoleInstanceCore;
		}
		set
		{
			if (this.CachedRoleInstanceCore != null && value != null)
			{
				return;
			}
			this.CachedRoleInstanceCore = value;
		}
	}

	// Token: 0x17001CCF RID: 7375
	// (get) Token: 0x06012F2E RID: 77614 RVA: 0x0058D384 File Offset: 0x0058B584
	// (set) Token: 0x06012F2F RID: 77615 RVA: 0x0058D38C File Offset: 0x0058B58C
	public int ChosenLevel
	{
		get
		{
			return this.ChosenLevelCore;
		}
		set
		{
			int maxBreachLevel = this.CachedRoleInstance.GetLevelData().GetMaxBreachLevel();
			int num = value;
			if (num < 1)
			{
				num = 1;
			}
			else if (num > maxBreachLevel)
			{
				num = maxBreachLevel;
			}
			this.ChosenLevelCore = num;
			this.CachedViewContextCore.ChosenLevel = num;
			this.CachedCostContentItemContextCore.ChosenLevel = num;
		}
	}

	// Token: 0x06012F30 RID: 77616 RVA: 0x0058D3D9 File Offset: 0x0058B5D9
	public LevelLayoutGrid CreateLevelLayoutGrid()
	{
		return new LevelLayoutGrid(this);
	}

	// Token: 0x06012F31 RID: 77617 RVA: 0x0058D3E4 File Offset: 0x0058B5E4
	private void ExtendToggleClickedCallback(MediumItemGridExtendCallback callbackParam)
	{
		ISelectedData selectedData = callbackParam.Data as ISelectedData;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null, false);
		callbackParam.MediumItemGrid.SetSelected(true, true);
	}

	// Token: 0x06012F32 RID: 77618 RVA: 0x0058D41D File Offset: 0x0058B61D
	public CostMediumItemGrid CreateItemLayoutGrid()
	{
		CostMediumItemGrid costMediumItemGrid = new CostMediumItemGrid();
		costMediumItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.ExtendToggleClickedCallback));
		return costMediumItemGrid;
	}

	// Token: 0x06012F33 RID: 77619 RVA: 0x0058D436 File Offset: 0x0058B636
	public void BindView(RoleBreakPreviewView view)
	{
		this.CachedViewContextCore = new RoleBreakPreviewContext(this, view);
	}

	// Token: 0x06012F34 RID: 77620 RVA: 0x0058D445 File Offset: 0x0058B645
	public void UnbindView()
	{
		RoleBreakPreviewContext cachedViewContextCore = this.CachedViewContextCore;
		if (cachedViewContextCore != null)
		{
			cachedViewContextCore.Dispose();
		}
		this.CachedViewContextCore = null;
	}

	// Token: 0x06012F35 RID: 77621 RVA: 0x0058D45F File Offset: 0x0058B65F
	public void BindCostContentItem(CostContentItem item)
	{
		this.CachedCostContentItemContextCore = new CostContentItemContext(this, item);
	}

	// Token: 0x06012F36 RID: 77622 RVA: 0x0058D46E File Offset: 0x0058B66E
	public void UnbindCostContentItem()
	{
		CostContentItemContext cachedCostContentItemContextCore = this.CachedCostContentItemContextCore;
		if (cachedCostContentItemContextCore != null)
		{
			cachedCostContentItemContextCore.Dispose();
		}
		this.CachedCostContentItemContextCore = null;
	}

	// Token: 0x06012F37 RID: 77623 RVA: 0x0058D488 File Offset: 0x0058B688
	public void HandleViewOnStart()
	{
		int breachLevel = this.CachedRoleInstance.GetLevelData().GetBreachLevel();
		this.ChosenLevel = breachLevel + 1;
	}

	// Token: 0x06012F38 RID: 77624 RVA: 0x0058D4B0 File Offset: 0x0058B6B0
	public void HandleCostContentItemOnStart()
	{
		RoleLevelData levelData = this.CachedRoleInstance.GetLevelData();
		this.CachedCostContentItemContextCore.ChosenLevel = levelData.GetBreachLevel();
	}

	// Token: 0x06012F39 RID: 77625 RVA: 0x0058D4DA File Offset: 0x0058B6DA
	[NullableContext(0)]
	public void HandleViewClosePromise(UniTask<bool> booleanPromise)
	{
		booleanPromise.ContinueWith(delegate(bool _)
		{
			this.CachedRoleInstance = null;
		}).Forget();
	}

	// Token: 0x06012F3A RID: 77626 RVA: 0x0058D4F3 File Offset: 0x0058B6F3
	public void HandleItemOnClickToggle(int gridIndex)
	{
		this.ChosenLevel = gridIndex + 1;
	}

	// Token: 0x06012F3B RID: 77627 RVA: 0x0058D4FE File Offset: 0x0058B6FE
	public void HandleClickLeft()
	{
		this.ChosenLevel--;
	}

	// Token: 0x06012F3C RID: 77628 RVA: 0x0058D50E File Offset: 0x0058B70E
	public void HandleClickRight()
	{
		this.ChosenLevel++;
	}

	// Token: 0x06012F3D RID: 77629 RVA: 0x0058D520 File Offset: 0x0058B720
	public ILevelLayoutGridData[] BuildLevelLayoutData(int chosenBreakLevel)
	{
		List<ILevelLayoutGridData> list = new List<ILevelLayoutGridData>();
		RoleLevelData levelData = this.CachedRoleInstance.GetLevelData();
		int breachLevel = levelData.GetBreachLevel();
		for (int i = 0; i < levelData.GetMaxBreachLevel(); i++)
		{
			int num = i + 1;
			list.Add(new LevelLayoutGridData
			{
				IsChosen = (num == chosenBreakLevel),
				IsAvailable = (i < breachLevel),
				LevelContent = num
			});
		}
		return list.ToArray();
	}

	// Token: 0x06012F3E RID: 77630 RVA: 0x0058D58C File Offset: 0x0058B78C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public ISelectedData[] BuildItemLayoutData(int chosenLevel)
	{
		RoleLevelData levelData = this.CachedRoleInstance.GetLevelData();
		bool flag = levelData.GetBreachLevel() >= chosenLevel;
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (KeyValuePair<int, int> keyValuePair in levelData.GetBreachConfig(chosenLevel).Value.BreachConsume())
		{
			if (keyValuePair.Key != 2)
			{
				list.Add(new SelectedData
				{
					ItemId = keyValuePair.Key,
					Count = keyValuePair.Value,
					IncId = 0,
					SelectedCount = (flag ? 0 : InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0)),
					OnlyTextFlag = new bool?(flag)
				});
			}
		}
		return list.ToArray();
	}

	// Token: 0x06012F3F RID: 77631 RVA: 0x0058D670 File Offset: 0x0058B870
	[NullableContext(2)]
	public ICostContentItemData BuildCostContentItemData(int chosenLevel)
	{
		Dictionary<int, int> dictionary = this.CachedRoleInstance.GetLevelData().GetBreachConfig(chosenLevel).Value.BreachConsume();
		int costNum = 0;
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			if (keyValuePair.Key == 2)
			{
				costNum = keyValuePair.Value;
				break;
			}
		}
		return new CostContentItemData
		{
			CostNum = costNum,
			CostType = EItemId.Gold
		};
	}

	// Token: 0x0400A340 RID: 41792
	[Nullable(2)]
	private RoleBreakPreviewContext CachedViewContextCore;

	// Token: 0x0400A341 RID: 41793
	[Nullable(2)]
	private CostContentItemContext CachedCostContentItemContextCore;

	// Token: 0x0400A342 RID: 41794
	[Nullable(2)]
	private RoleDataBase CachedRoleInstanceCore;

	// Token: 0x0400A343 RID: 41795
	private int ChosenLevelCore = -1;
}
