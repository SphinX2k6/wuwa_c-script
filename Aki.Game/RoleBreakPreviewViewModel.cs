using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using Cysharp.Threading.Tasks;

// Token: 0x0200287C RID: 10364
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewViewModel
{
	// Token: 0x0601552D RID: 87341 RVA: 0x005625F6 File Offset: 0x005607F6
	public void Dispose()
	{
		this.ChosenLevelCore = -1;
		this.UnbindView();
		this.UnbindCostContentItem();
	}

	// Token: 0x17001C76 RID: 7286
	// (get) Token: 0x0601552E RID: 87342 RVA: 0x0056260B File Offset: 0x0056080B
	// (set) Token: 0x0601552F RID: 87343 RVA: 0x00562613 File Offset: 0x00560813
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

	// Token: 0x17001C77 RID: 7287
	// (get) Token: 0x06015530 RID: 87344 RVA: 0x00562628 File Offset: 0x00560828
	// (set) Token: 0x06015531 RID: 87345 RVA: 0x00562630 File Offset: 0x00560830
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

	// Token: 0x06015532 RID: 87346 RVA: 0x0056267D File Offset: 0x0056087D
	public LevelLayoutGrid CreateLevelLayoutGrid()
	{
		return new LevelLayoutGrid(this);
	}

	// Token: 0x06015533 RID: 87347 RVA: 0x00562688 File Offset: 0x00560888
	private void ExtendToggleClickedCallback(MediumItemGridExtendCallback callbackParam)
	{
		ISelectedData selectedData = callbackParam.Data as ISelectedData;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null);
		callbackParam.MediumItemGrid.SetSelected(true, true);
	}

	// Token: 0x06015534 RID: 87348 RVA: 0x005626C0 File Offset: 0x005608C0
	public CostMediumItemGrid CreateItemLayoutGrid()
	{
		CostMediumItemGrid costMediumItemGrid = new CostMediumItemGrid();
		costMediumItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.ExtendToggleClickedCallback));
		return costMediumItemGrid;
	}

	// Token: 0x06015535 RID: 87349 RVA: 0x005626D9 File Offset: 0x005608D9
	public void BindView(RoleBreakPreviewView view)
	{
		this.CachedViewContextCore = new RoleBreakPreviewContext(this, view);
	}

	// Token: 0x06015536 RID: 87350 RVA: 0x005626E8 File Offset: 0x005608E8
	public void UnbindView()
	{
		RoleBreakPreviewContext cachedViewContextCore = this.CachedViewContextCore;
		if (cachedViewContextCore != null)
		{
			cachedViewContextCore.Dispose();
		}
		this.CachedViewContextCore = null;
	}

	// Token: 0x06015537 RID: 87351 RVA: 0x00562702 File Offset: 0x00560902
	public void BindCostContentItem(CostContentItem item)
	{
		this.CachedCostContentItemContextCore = new CostContentItemContext(this, item);
	}

	// Token: 0x06015538 RID: 87352 RVA: 0x00562711 File Offset: 0x00560911
	public void UnbindCostContentItem()
	{
		CostContentItemContext cachedCostContentItemContextCore = this.CachedCostContentItemContextCore;
		if (cachedCostContentItemContextCore != null)
		{
			cachedCostContentItemContextCore.Dispose();
		}
		this.CachedCostContentItemContextCore = null;
	}

	// Token: 0x06015539 RID: 87353 RVA: 0x0056272C File Offset: 0x0056092C
	public void HandleViewOnStart()
	{
		int breachLevel = this.CachedRoleInstance.GetLevelData().GetBreachLevel();
		this.ChosenLevel = breachLevel + 1;
	}

	// Token: 0x0601553A RID: 87354 RVA: 0x00562754 File Offset: 0x00560954
	public void HandleCostContentItemOnStart()
	{
		RoleLevelData levelData = this.CachedRoleInstance.GetLevelData();
		this.CachedCostContentItemContextCore.ChosenLevel = levelData.GetBreachLevel();
	}

	// Token: 0x0601553B RID: 87355 RVA: 0x0056277E File Offset: 0x0056097E
	[NullableContext(0)]
	public void HandleViewClosePromise(UniTask<bool> booleanPromise)
	{
		booleanPromise.ContinueWith(delegate(bool _)
		{
			this.CachedRoleInstance = null;
		}).Forget();
	}

	// Token: 0x0601553C RID: 87356 RVA: 0x00562797 File Offset: 0x00560997
	public void HandleItemOnClickToggle(int gridIndex)
	{
		this.ChosenLevel = gridIndex + 1;
	}

	// Token: 0x0601553D RID: 87357 RVA: 0x005627A2 File Offset: 0x005609A2
	public void HandleClickLeft()
	{
		this.ChosenLevel--;
	}

	// Token: 0x0601553E RID: 87358 RVA: 0x005627B2 File Offset: 0x005609B2
	public void HandleClickRight()
	{
		this.ChosenLevel++;
	}

	// Token: 0x0601553F RID: 87359 RVA: 0x005627C4 File Offset: 0x005609C4
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

	// Token: 0x06015540 RID: 87360 RVA: 0x00562830 File Offset: 0x00560A30
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

	// Token: 0x06015541 RID: 87361 RVA: 0x00562914 File Offset: 0x00560B14
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

	// Token: 0x04009F57 RID: 40791
	[Nullable(2)]
	private RoleBreakPreviewContext CachedViewContextCore;

	// Token: 0x04009F58 RID: 40792
	[Nullable(2)]
	private CostContentItemContext CachedCostContentItemContextCore;

	// Token: 0x04009F59 RID: 40793
	[Nullable(2)]
	private RoleDataBase CachedRoleInstanceCore;

	// Token: 0x04009F5A RID: 40794
	private int ChosenLevelCore = -1;
}
