using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014CD RID: 5325
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ItemHintModel : ModelBase
{
	// Token: 0x17001397 RID: 5015
	// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x003F5683 File Offset: 0x003F3883
	// (set) Token: 0x0600D4FC RID: 54524 RVA: 0x003F568B File Offset: 0x003F388B
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

	// Token: 0x0600D4FD RID: 54525 RVA: 0x003F5694 File Offset: 0x003F3894
	protected override bool OnInit()
	{
		this.VisibilityInternal = true;
		return true;
	}

	// Token: 0x0600D4FE RID: 54526 RVA: 0x003F569E File Offset: 0x003F389E
	protected override bool OnClear()
	{
		this.MainInterfaceData.Clear();
		this.PriorInterfaceData.Clear();
		this.ItemRewardDataArray = new List<ItemRewardData>();
		return true;
	}

	// Token: 0x0600D4FF RID: 54527 RVA: 0x003F56C4 File Offset: 0x003F38C4
	public void AddItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemRewardData itemRewardData = new ItemRewardData();
		itemRewardData.ItemReward = itemRewardInfo;
		this.ItemRewardDataArray.Add(itemRewardData);
	}

	// Token: 0x0600D500 RID: 54528 RVA: 0x003F56EC File Offset: 0x003F38EC
	public void AddAchievementItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemRewardData itemRewardData = new ItemRewardData();
		itemRewardData.ItemReward = itemRewardInfo;
		this.AchievementItemRewardDataArray.Add(itemRewardData);
	}

	// Token: 0x0600D501 RID: 54529 RVA: 0x003F5714 File Offset: 0x003F3914
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

	// Token: 0x0600D502 RID: 54530 RVA: 0x003F577E File Offset: 0x003F397E
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

	// Token: 0x0600D503 RID: 54531 RVA: 0x003F57A8 File Offset: 0x003F39A8
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

	// Token: 0x0600D504 RID: 54532 RVA: 0x003F57D2 File Offset: 0x003F39D2
	public ItemRewardData PeekItemRewardListFirst()
	{
		return this.ItemRewardDataArray[0];
	}

	// Token: 0x0600D505 RID: 54533 RVA: 0x003F57E0 File Offset: 0x003F39E0
	public void CleanItemRewardList()
	{
		this.ItemRewardDataArray = new List<ItemRewardData>();
	}

	// Token: 0x17001398 RID: 5016
	// (get) Token: 0x0600D506 RID: 54534 RVA: 0x003F57ED File Offset: 0x003F39ED
	public bool IsItemRewardListEmpty
	{
		get
		{
			return this.ItemRewardDataArray.Count <= 0;
		}
	}

	// Token: 0x17001399 RID: 5017
	// (get) Token: 0x0600D507 RID: 54535 RVA: 0x003F5800 File Offset: 0x003F3A00
	public bool IsAchievementItemRewardListEmpty
	{
		get
		{
			return this.AchievementItemRewardDataArray.Count <= 0;
		}
	}

	// Token: 0x0600D508 RID: 54536 RVA: 0x003F5814 File Offset: 0x003F3A14
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

	// Token: 0x0600D509 RID: 54537 RVA: 0x003F58EC File Offset: 0x003F3AEC
	public void AddItemToPriorInterfaceData(int itemId, int count, int qualityId)
	{
		ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
		itemRewardInfo.ItemId = new int?(itemId);
		itemRewardInfo.ItemCount = new int?(count);
		itemRewardInfo.Quality = qualityId;
		this.PriorInterfaceData.AddItemRewardInfo(itemRewardInfo);
	}

	// Token: 0x1700139A RID: 5018
	// (get) Token: 0x0600D50A RID: 54538 RVA: 0x003F592A File Offset: 0x003F3B2A
	public bool IsMainInterfaceDataEmpty
	{
		get
		{
			return this.MainInterfaceData.WaitList.Count <= 0;
		}
	}

	// Token: 0x1700139B RID: 5019
	// (get) Token: 0x0600D50B RID: 54539 RVA: 0x003F5942 File Offset: 0x003F3B42
	public bool IsPriorInterfaceDataEmpty
	{
		get
		{
			return this.PriorInterfaceData.WaitList.Count <= 0;
		}
	}

	// Token: 0x0600D50C RID: 54540 RVA: 0x003F595A File Offset: 0x003F3B5A
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

	// Token: 0x0600D50D RID: 54541 RVA: 0x003F5993 File Offset: 0x003F3B93
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

	// Token: 0x0600D50E RID: 54542 RVA: 0x003F59CC File Offset: 0x003F3BCC
	public void GmClear()
	{
		this.MainInterfaceData.WaitList.Clear();
		this.PriorInterfaceData.WaitList.Clear();
		this.CleanItemRewardList();
		this.AchievementItemRewardDataArray.Clear();
	}

	// Token: 0x1700139C RID: 5020
	// (get) Token: 0x0600D50F RID: 54543 RVA: 0x003F59FF File Offset: 0x003F3BFF
	public static ItemHintModel Instance
	{
		get
		{
			return ItemHintModel._Instance;
		}
	}

	// Token: 0x0600D510 RID: 54544 RVA: 0x003F5A06 File Offset: 0x003F3C06
	public static ItemHintModel GetOrCreateInstance()
	{
		if (ItemHintModel._Instance == null)
		{
			ItemHintModel.CreateInstance();
		}
		return ItemHintModel._Instance;
	}

	// Token: 0x0600D511 RID: 54545 RVA: 0x003F5A1A File Offset: 0x003F3C1A
	public static bool CreateInstance()
	{
		if (ItemHintModel._Instance != null)
		{
			return true;
		}
		ItemHintModel._Instance = new ItemHintModel();
		return true;
	}

	// Token: 0x0600D512 RID: 54546 RVA: 0x003F5A30 File Offset: 0x003F3C30
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D513 RID: 54547 RVA: 0x003F5A32 File Offset: 0x003F3C32
	public static void ResetStaticDefaultValue()
	{
		ItemHintModel._Instance = null;
	}

	// Token: 0x0600D514 RID: 54548 RVA: 0x003F5A3A File Offset: 0x003F3C3A
	static ItemHintModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemHintModel.CreateStaticDefaultValue), new Action(ItemHintModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400779C RID: 30620
	private const int HIGH_QUALITY = 4;

	// Token: 0x0400779D RID: 30621
	private readonly MainInterfaceData MainInterfaceData = new MainInterfaceData();

	// Token: 0x0400779E RID: 30622
	private readonly MainInterfaceData PriorInterfaceData = new MainInterfaceData();

	// Token: 0x0400779F RID: 30623
	private List<ItemRewardData> ItemRewardDataArray = new List<ItemRewardData>();

	// Token: 0x040077A0 RID: 30624
	private readonly List<ItemRewardData> AchievementItemRewardDataArray = new List<ItemRewardData>();

	// Token: 0x040077A1 RID: 30625
	private bool VisibilityInternal;

	// Token: 0x040077A2 RID: 30626
	[Nullable(2)]
	private static ItemHintModel _Instance;
}
