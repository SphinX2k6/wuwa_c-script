using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FFA RID: 8186
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ItemHintModel : ModelBase
{
	// Token: 0x1700136A RID: 4970
	// (get) Token: 0x06010093 RID: 65683 RVA: 0x003E908B File Offset: 0x003E728B
	// (set) Token: 0x06010094 RID: 65684 RVA: 0x003E9093 File Offset: 0x003E7293
	public bool Visibility
	{
		get
		{
			return this.VisibilityInternal;
		}
		set
		{
			this.VisibilityInternal = value;
		}
	}

	// Token: 0x06010095 RID: 65685 RVA: 0x003E909C File Offset: 0x003E729C
	protected override bool OnInit()
	{
		this.VisibilityInternal = true;
		return true;
	}

	// Token: 0x06010096 RID: 65686 RVA: 0x003E90A6 File Offset: 0x003E72A6
	protected override bool OnClear()
	{
		this.MainInterfaceData.Clear();
		this.PriorInterfaceData.Clear();
		this.ItemRewardDataArray = new List<ItemRewardData>();
		return true;
	}

	// Token: 0x06010097 RID: 65687 RVA: 0x003E90CC File Offset: 0x003E72CC
	public void AddItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemRewardData itemRewardData = new ItemRewardData();
		itemRewardData.ItemReward = itemRewardInfo;
		this.ItemRewardDataArray.Add(itemRewardData);
	}

	// Token: 0x06010098 RID: 65688 RVA: 0x003E90F4 File Offset: 0x003E72F4
	public void AddAchievementItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemRewardData itemRewardData = new ItemRewardData();
		itemRewardData.ItemReward = itemRewardInfo;
		this.AchievementItemRewardDataArray.Add(itemRewardData);
	}

	// Token: 0x06010099 RID: 65689 RVA: 0x003E911C File Offset: 0x003E731C
	public void AddItemRewardTest()
	{
		ItemRewardNotify itemRewardNotify = ItemRewardNotify.Create();
		RewardItemInfo rewardItemInfo = RewardItemInfo.Create();
		rewardItemInfo.Count = 1;
		rewardItemInfo.ItemId = 21010014;
		rewardItemInfo.ShowPlanId = 3;
		RewardItemInfoList rewardItemInfoList = new RewardItemInfoList();
		rewardItemInfoList.ItemList.Add(rewardItemInfo);
		itemRewardNotify.RewardItems.Add(0, rewardItemInfoList);
		ItemRewardData itemRewardData = new ItemRewardData();
		itemRewardData.ItemReward = itemRewardNotify;
		this.ItemRewardDataArray.Add(itemRewardData);
	}

	// Token: 0x0601009A RID: 65690 RVA: 0x003E9186 File Offset: 0x003E7386
	[NullableContext(2)]
	public ItemRewardData ShiftItemRewardListFirst()
	{
		if (this.ItemRewardDataArray.Count > 0)
		{
			ItemRewardData result = this.ItemRewardDataArray[0];
			this.ItemRewardDataArray.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0601009B RID: 65691 RVA: 0x003E91B0 File Offset: 0x003E73B0
	[NullableContext(2)]
	public ItemRewardData ShiftAchievementItemRewardListFirst()
	{
		if (this.AchievementItemRewardDataArray.Count > 0)
		{
			ItemRewardData result = this.AchievementItemRewardDataArray[0];
			this.AchievementItemRewardDataArray.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0601009C RID: 65692 RVA: 0x003E91DA File Offset: 0x003E73DA
	public ItemRewardData PeekItemRewardListFirst()
	{
		return this.ItemRewardDataArray[0];
	}

	// Token: 0x0601009D RID: 65693 RVA: 0x003E91E8 File Offset: 0x003E73E8
	public void CleanItemRewardList()
	{
		this.ItemRewardDataArray = new List<ItemRewardData>();
	}

	// Token: 0x1700136B RID: 4971
	// (get) Token: 0x0601009E RID: 65694 RVA: 0x003E91F5 File Offset: 0x003E73F5
	public bool IsItemRewardListEmpty
	{
		get
		{
			return this.ItemRewardDataArray.Count <= 0;
		}
	}

	// Token: 0x1700136C RID: 4972
	// (get) Token: 0x0601009F RID: 65695 RVA: 0x003E9208 File Offset: 0x003E7408
	public bool IsAchievementItemRewardListEmpty
	{
		get
		{
			return this.AchievementItemRewardDataArray.Count <= 0;
		}
	}

	// Token: 0x060100A0 RID: 65696 RVA: 0x003E921C File Offset: 0x003E741C
	public void MainInterfaceInsertItemRewardInfo(AddCountItemInfo[] addCountItemInfo)
	{
		foreach (AddCountItemInfo addCountItemInfo2 in addCountItemInfo)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(addCountItemInfo2.Id);
			if (itemConfigData != null && itemConfigData.ShowInBag)
			{
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemCount = new int?(addCountItemInfo2.Count);
				itemRewardInfo.ItemId = new int?(addCountItemInfo2.Id);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				if (itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Phantom)
				{
					this.PriorInterfaceData.AddItemRewardInfo(itemRewardInfo);
				}
				else if (itemRewardInfo.Quality >= 4)
				{
					this.PriorInterfaceData.AddItemRewardInfo(itemRewardInfo);
				}
				else
				{
					this.MainInterfaceData.AddItemRewardInfo(itemRewardInfo);
				}
			}
		}
		this.MainInterfaceData.SortWaitList();
		this.PriorInterfaceData.SortWaitList();
	}

	// Token: 0x060100A1 RID: 65697 RVA: 0x003E92F4 File Offset: 0x003E74F4
	public void AddItemToPriorInterfaceData(int itemId, int count, int qualityId)
	{
		ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
		itemRewardInfo.ItemId = new int?(itemId);
		itemRewardInfo.ItemCount = new int?(count);
		itemRewardInfo.Quality = qualityId;
		this.PriorInterfaceData.AddItemRewardInfo(itemRewardInfo);
	}

	// Token: 0x1700136D RID: 4973
	// (get) Token: 0x060100A2 RID: 65698 RVA: 0x003E9332 File Offset: 0x003E7532
	public bool IsMainInterfaceDataEmpty
	{
		get
		{
			return this.MainInterfaceData.WaitList.Count <= 0;
		}
	}

	// Token: 0x1700136E RID: 4974
	// (get) Token: 0x060100A3 RID: 65699 RVA: 0x003E934A File Offset: 0x003E754A
	public bool IsPriorInterfaceDataEmpty
	{
		get
		{
			return this.PriorInterfaceData.WaitList.Count <= 0;
		}
	}

	// Token: 0x060100A4 RID: 65700 RVA: 0x003E9362 File Offset: 0x003E7562
	[NullableContext(2)]
	public ItemRewardInfo ShiftMainInterfaceData()
	{
		if (this.MainInterfaceData.WaitList.Count > 0)
		{
			ItemRewardInfo result = this.MainInterfaceData.WaitList[0];
			this.MainInterfaceData.WaitList.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060100A5 RID: 65701 RVA: 0x003E939B File Offset: 0x003E759B
	[NullableContext(2)]
	public ItemRewardInfo ShiftPriorInterfaceData()
	{
		if (this.PriorInterfaceData.WaitList.Count > 0)
		{
			ItemRewardInfo result = this.PriorInterfaceData.WaitList[0];
			this.PriorInterfaceData.WaitList.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060100A6 RID: 65702 RVA: 0x003E93D4 File Offset: 0x003E75D4
	public void GmClear()
	{
		this.MainInterfaceData.WaitList.Clear();
		this.PriorInterfaceData.WaitList.Clear();
		this.CleanItemRewardList();
		this.AchievementItemRewardDataArray.Clear();
	}

	// Token: 0x1700136F RID: 4975
	// (get) Token: 0x060100A7 RID: 65703 RVA: 0x003E9407 File Offset: 0x003E7607
	public static ItemHintModel Instance
	{
		get
		{
			return ItemHintModel._Instance;
		}
	}

	// Token: 0x060100A8 RID: 65704 RVA: 0x003E940E File Offset: 0x003E760E
	public static ItemHintModel GetOrCreateInstance()
	{
		if (ItemHintModel._Instance == null)
		{
			ItemHintModel.CreateInstance();
		}
		return ItemHintModel._Instance;
	}

	// Token: 0x060100A9 RID: 65705 RVA: 0x003E9422 File Offset: 0x003E7622
	public static bool CreateInstance()
	{
		if (ItemHintModel._Instance != null)
		{
			return true;
		}
		ItemHintModel._Instance = new ItemHintModel();
		return true;
	}

	// Token: 0x060100AA RID: 65706 RVA: 0x003E9438 File Offset: 0x003E7638
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060100AB RID: 65707 RVA: 0x003E943A File Offset: 0x003E763A
	public static void ResetStaticDefaultValue()
	{
		ItemHintModel._Instance = null;
	}

	// Token: 0x060100AC RID: 65708 RVA: 0x003E9442 File Offset: 0x003E7642
	static ItemHintModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemHintModel.CreateStaticDefaultValue), new Action(ItemHintModel.ResetStaticDefaultValue));
	}

	// Token: 0x040076B3 RID: 30387
	private const int HIGH_QUALITY = 4;

	// Token: 0x040076B4 RID: 30388
	private readonly MainInterfaceData MainInterfaceData = new MainInterfaceData();

	// Token: 0x040076B5 RID: 30389
	private readonly MainInterfaceData PriorInterfaceData = new MainInterfaceData();

	// Token: 0x040076B6 RID: 30390
	private List<ItemRewardData> ItemRewardDataArray = new List<ItemRewardData>();

	// Token: 0x040076B7 RID: 30391
	private readonly List<ItemRewardData> AchievementItemRewardDataArray = new List<ItemRewardData>();

	// Token: 0x040076B8 RID: 30392
	private bool VisibilityInternal;

	// Token: 0x040076B9 RID: 30393
	[Nullable(2)]
	private static ItemHintModel _Instance;
}
