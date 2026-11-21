using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x0200132D RID: 4909
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackData : IHonamiStoryBackpackData
{
	// Token: 0x0600C120 RID: 49440 RVA: 0x00393300 File Offset: 0x00391500
	public void Init(HonamiStoryBagInfo bagInfo)
	{
		this.Width = bagInfo.Width;
		this.Capacity = bagInfo.BagSize;
		this.ClearBackpack();
		this.SelfBackpackId = bagInfo.BagConfigId;
		this.SelfBackpackType = (EHonamiStoryBackpackType)HonamiStoryConfig.Instance.GetHonamiStoryBackPack(bagInfo.BagConfigId).Value.Type;
		this.InitData(bagInfo.HonamiStoryBagItemInfos);
	}

	// Token: 0x0600C121 RID: 49441 RVA: 0x0039336C File Offset: 0x0039156C
	private void InitData(IEnumerable<HonamiStoryBagItemInfo> itemInfo)
	{
		foreach (HonamiStoryBagItemInfo itemInfo2 in itemInfo)
		{
			this.UpdateItemData(itemInfo2);
		}
		this.RefreshOverflowCapacity();
	}

	// Token: 0x0600C122 RID: 49442 RVA: 0x003933BC File Offset: 0x003915BC
	public void Update(IEnumerable<HonamiStoryBagItemInfo> updateInfo)
	{
		foreach (HonamiStoryBagItemInfo itemInfo in updateInfo)
		{
			HonamiStoryItemDataBase honamiStoryItemDataBase = this.UpdateItemData(itemInfo);
			if (honamiStoryItemDataBase != null)
			{
				honamiStoryItemDataBase.SetNewInBackpack(true);
			}
		}
		this.RefreshOverflowCapacity();
	}

	// Token: 0x0600C123 RID: 49443 RVA: 0x00393418 File Offset: 0x00391618
	[return: Nullable(2)]
	private HonamiStoryItemDataBase UpdateItemData(HonamiStoryBagItemInfo itemInfo)
	{
		HonamiStoryItemDataBase honamiStoryItemDataBase = null;
		HonamiStoryItemDataBase honamiStoryItemDataBase2;
		if (this.ItemMap.TryGetValue(itemInfo.HonamiStoryItemInfo.IncrId, out honamiStoryItemDataBase2))
		{
			honamiStoryItemDataBase = honamiStoryItemDataBase2;
			foreach (int num in honamiStoryItemDataBase.GetGridFillPositionList())
			{
				this.ItemPosMap.Remove(num);
				this.EmptyGridSet.Add(num);
			}
			honamiStoryItemDataBase.Init(itemInfo.HonamiStoryItemInfo);
			honamiStoryItemDataBase.UpdatePositionInfo(itemInfo.HonamiStoryPosInfo);
		}
		else
		{
			honamiStoryItemDataBase = HonamiStoryModel.Instance.CreateHonamiStoryItemData(itemInfo.HonamiStoryItemInfo, itemInfo.HonamiStoryPosInfo);
		}
		honamiStoryItemDataBase.SetBackpackWidth(this.Width);
		this.RefreshItemMapByAddItem(honamiStoryItemDataBase);
		return honamiStoryItemDataBase;
	}

	// Token: 0x0600C124 RID: 49444 RVA: 0x003934E4 File Offset: 0x003916E4
	protected void RefreshItemMapByAddItem(HonamiStoryItemDataBase itemData)
	{
		foreach (int num in itemData.GetGridFillPositionList())
		{
			this.ItemPosMap[num] = itemData;
			this.EmptyGridSet.Remove(num);
		}
		this.ItemList.Add(itemData);
		this.ItemMap[itemData.GetIncId()] = itemData;
	}

	// Token: 0x0600C125 RID: 49445 RVA: 0x00393568 File Offset: 0x00391768
	public void UpdateByContext(IEnumerable<HonamiStoryBagUpdateInfo> updateInfoList)
	{
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo in updateInfoList)
		{
			if (honamiStoryBagUpdateInfo.Type != 0)
			{
				this.RemoveItemData(honamiStoryBagUpdateInfo);
			}
		}
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo2 in updateInfoList)
		{
			if (honamiStoryBagUpdateInfo2.Type != 2)
			{
				this.AddItemData(honamiStoryBagUpdateInfo2);
			}
		}
	}

	// Token: 0x0600C126 RID: 49446 RVA: 0x003935F8 File Offset: 0x003917F8
	public void AddItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		HonamiStoryItemDataBase itemData = HonamiStoryModel.Instance.GetItemData(updateInfo.ItemIncrId);
		itemData.UpdatePositionInfo(updateInfo.HonamiStoryPosInfo);
		itemData.SetBackpackWidth(this.Width);
		this.RefreshItemMapByAddItem(itemData);
	}

	// Token: 0x0600C127 RID: 49447 RVA: 0x00393638 File Offset: 0x00391838
	private void RemoveItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		HonamiStoryItemDataBase itemDataByInstanceId = this.GetItemDataByInstanceId(updateInfo.ItemIncrId, true);
		foreach (int num in itemDataByInstanceId.GetGridFillPositionByPosition(updateInfo.OriHonamiStoryPosInfo.Position, updateInfo.OriHonamiStoryPosInfo.IsCross))
		{
			this.ItemPosMap.Remove(num);
			this.EmptyGridSet.Add(num);
		}
		this.ItemList.Remove(itemDataByInstanceId);
		this.ItemMap.Remove(itemDataByInstanceId.GetIncId());
	}

	// Token: 0x0600C128 RID: 49448 RVA: 0x003936E4 File Offset: 0x003918E4
	public virtual bool PushItemData(HonamiStoryItemDataBase itemData)
	{
		return false;
	}

	// Token: 0x0600C129 RID: 49449 RVA: 0x003936E8 File Offset: 0x003918E8
	public void ClearBackpack()
	{
		foreach (KeyValuePair<int, HonamiStoryItemDataBase> keyValuePair in this.ItemMap)
		{
			HonamiStoryModel.Instance.RemoveItemData(keyValuePair.Key);
		}
		this.EmptyGridSet.Clear();
		for (int i = 0; i < this.GetCapacity(); i++)
		{
			this.EmptyGridSet.Add(i);
		}
		this.OverflowCapacity = 0;
		this.ItemList.Clear();
		this.ItemMap.Clear();
		this.ItemPosMap.Clear();
	}

	// Token: 0x170012CD RID: 4813
	// (get) Token: 0x0600C12A RID: 49450 RVA: 0x00393798 File Offset: 0x00391998
	public int BackpackId
	{
		get
		{
			return this.SelfBackpackId;
		}
	}

	// Token: 0x170012CE RID: 4814
	// (get) Token: 0x0600C12B RID: 49451 RVA: 0x003937A0 File Offset: 0x003919A0
	public EHonamiStoryBackpackType BackpackType
	{
		get
		{
			return this.SelfBackpackType;
		}
	}

	// Token: 0x0600C12C RID: 49452 RVA: 0x003937A8 File Offset: 0x003919A8
	public List<HonamiStoryItemDataBase> GetItemDataList()
	{
		List<HonamiStoryItemDataBase> list = new List<HonamiStoryItemDataBase>();
		foreach (HonamiStoryItemDataBase item in this.ItemList)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600C12D RID: 49453 RVA: 0x00393804 File Offset: 0x00391A04
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetItemDataByInstanceId(int instanceId, bool needLog = true)
	{
		HonamiStoryItemDataBase result;
		if (this.ItemMap.TryGetValue(instanceId, out result))
		{
			return result;
		}
		if (needLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ItemDataMap not found instanceId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(instanceId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return null;
	}

	// Token: 0x0600C12E RID: 49454 RVA: 0x00393868 File Offset: 0x00391A68
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetItemDataByPosition(int position)
	{
		HonamiStoryItemDataBase result;
		if (this.ItemPosMap.TryGetValue(position, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600C12F RID: 49455 RVA: 0x00393888 File Offset: 0x00391A88
	public int GetWidthCount()
	{
		return this.Width;
	}

	// Token: 0x0600C130 RID: 49456 RVA: 0x00393890 File Offset: 0x00391A90
	public int GetHeightCount()
	{
		return this.GetHeightCount(false);
	}

	// Token: 0x0600C131 RID: 49457 RVA: 0x00393899 File Offset: 0x00391A99
	public int GetHeightCount(bool needOverflow = false)
	{
		return (int)Math.Floor((double)(needOverflow ? (this.GetCapacity() + this.OverflowCapacity) : this.GetCapacity()) / (double)this.GetWidthCount());
	}

	// Token: 0x0600C132 RID: 49458 RVA: 0x003938C2 File Offset: 0x00391AC2
	public int GetCellWidth()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600C133 RID: 49459 RVA: 0x003938D3 File Offset: 0x00391AD3
	public int GetCellHeight()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600C134 RID: 49460 RVA: 0x003938E4 File Offset: 0x00391AE4
	public int GetCellHorizontalInterval()
	{
		HonamiStoryUtil.IsMobileView();
		return 2;
	}

	// Token: 0x0600C135 RID: 49461 RVA: 0x003938ED File Offset: 0x00391AED
	public int GetCellVerticalInterval()
	{
		HonamiStoryUtil.IsMobileView();
		return 2;
	}

	// Token: 0x0600C136 RID: 49462 RVA: 0x003938F6 File Offset: 0x00391AF6
	public void SetCapacity(int value)
	{
		this.Capacity = value;
	}

	// Token: 0x0600C137 RID: 49463 RVA: 0x003938FF File Offset: 0x00391AFF
	public int GetCapacity()
	{
		return this.Capacity;
	}

	// Token: 0x0600C138 RID: 49464 RVA: 0x00393907 File Offset: 0x00391B07
	public int GetOverflowCapacity()
	{
		return this.OverflowCapacity;
	}

	// Token: 0x0600C139 RID: 49465 RVA: 0x00393910 File Offset: 0x00391B10
	public int RefreshOverflowCapacity()
	{
		if (this.BackpackType != EHonamiStoryBackpackType.Inventory)
		{
			this.OverflowCapacity = 0;
			return 0;
		}
		int num = this.Capacity / this.Width;
		int overflowCapacity = this.OverflowCapacity;
		int num2 = 0;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			int num3 = (int)Math.Floor((double)honamiStoryItemDataBase.GetPosition() / (double)this.Width);
			if (num3 + honamiStoryItemDataBase.GetGridHeight() > num)
			{
				num2 = Math.Max(num2, num3 + honamiStoryItemDataBase.GetGridHeight() - num);
				foreach (int num4 in honamiStoryItemDataBase.GetGridFillPositionList())
				{
					if (num4 >= this.Capacity)
					{
						hashSet.Add(num4);
					}
				}
			}
		}
		this.OverflowCapacity = num2 * this.Width;
		int capacity = this.GetCapacity();
		if (overflowCapacity > this.OverflowCapacity)
		{
			for (int i = this.OverflowCapacity; i < overflowCapacity; i++)
			{
				this.EmptyGridSet.Remove(capacity + i);
			}
		}
		else
		{
			for (int j = overflowCapacity; j < this.OverflowCapacity; j++)
			{
				if (!hashSet.Contains(capacity + j))
				{
					this.EmptyGridSet.Add(capacity + j);
				}
			}
		}
		return this.OverflowCapacity;
	}

	// Token: 0x0600C13A RID: 49466 RVA: 0x00393A9C File Offset: 0x00391C9C
	public int GetOccupy()
	{
		int num = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			num += honamiStoryItemDataBase.GetGridHeight() * honamiStoryItemDataBase.GetGridWidth();
		}
		return num;
	}

	// Token: 0x0600C13B RID: 49467 RVA: 0x00393AFC File Offset: 0x00391CFC
	public int GetTotalValue()
	{
		int num = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			num += honamiStoryItemDataBase.GetSellPrice();
		}
		return num;
	}

	// Token: 0x0600C13C RID: 49468 RVA: 0x00393B54 File Offset: 0x00391D54
	public bool CheckIsNewInBackpack()
	{
		using (List<HonamiStoryItemDataBase>.Enumerator enumerator = this.ItemList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetNewInBackpack())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600C13D RID: 49469 RVA: 0x00393BB0 File Offset: 0x00391DB0
	public void ClearNewInBackpack()
	{
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			if (honamiStoryItemDataBase.GetNewInBackpack())
			{
				honamiStoryItemDataBase.SetNewInBackpack(false);
			}
		}
	}

	// Token: 0x0600C13E RID: 49470 RVA: 0x00393C0C File Offset: 0x00391E0C
	public HashSet<int> GetEmptyGridSet()
	{
		return this.EmptyGridSet;
	}

	// Token: 0x04006EED RID: 28397
	protected int Width;

	// Token: 0x04006EEE RID: 28398
	protected int Capacity;

	// Token: 0x04006EEF RID: 28399
	private int OverflowCapacity;

	// Token: 0x04006EF0 RID: 28400
	protected EHonamiStoryBackpackType SelfBackpackType;

	// Token: 0x04006EF1 RID: 28401
	protected int SelfBackpackId = -1;

	// Token: 0x04006EF2 RID: 28402
	protected List<HonamiStoryItemDataBase> ItemList = new List<HonamiStoryItemDataBase>();

	// Token: 0x04006EF3 RID: 28403
	private readonly Dictionary<int, HonamiStoryItemDataBase> ItemMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006EF4 RID: 28404
	protected Dictionary<int, HonamiStoryItemDataBase> ItemPosMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006EF5 RID: 28405
	protected HashSet<int> EmptyGridSet = new HashSet<int>();
}
