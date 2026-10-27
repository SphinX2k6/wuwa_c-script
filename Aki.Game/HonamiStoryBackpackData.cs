using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E6B RID: 7787
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackData : IHonamiStoryBackpackData
{
	// Token: 0x0600ED01 RID: 60673 RVA: 0x003876D4 File Offset: 0x003858D4
	public void Init(HonamiStoryBagInfo bagInfo)
	{
		this.Width = bagInfo.Width;
		this.Capacity = bagInfo.BagSize;
		this.ClearBackpack();
		this.SelfBackpackId = bagInfo.BagConfigId;
		this.SelfBackpackType = (EHonamiStoryBackpackType)HonamiStoryConfig.Instance.GetHonamiStoryBackPack(bagInfo.BagConfigId).Value.Type;
		this.InitData(bagInfo.HonamiStoryBagItemInfos.ToList<HonamiStoryBagItemInfo>());
	}

	// Token: 0x0600ED02 RID: 60674 RVA: 0x00387744 File Offset: 0x00385944
	private void InitData(List<HonamiStoryBagItemInfo> itemInfo)
	{
		foreach (HonamiStoryBagItemInfo itemInfo2 in itemInfo)
		{
			this.UpdateItemData(itemInfo2);
		}
		this.RefreshOverflowCapacity();
	}

	// Token: 0x0600ED03 RID: 60675 RVA: 0x0038779C File Offset: 0x0038599C
	public void Update(List<HonamiStoryBagItemInfo> updateInfo)
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

	// Token: 0x0600ED04 RID: 60676 RVA: 0x00387800 File Offset: 0x00385A00
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

	// Token: 0x0600ED05 RID: 60677 RVA: 0x003878CC File Offset: 0x00385ACC
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

	// Token: 0x0600ED06 RID: 60678 RVA: 0x00387950 File Offset: 0x00385B50
	public void UpdateByContext(List<HonamiStoryBagUpdateInfo> updateInfoList)
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

	// Token: 0x0600ED07 RID: 60679 RVA: 0x003879EC File Offset: 0x00385BEC
	public void AddItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		HonamiStoryItemDataBase itemData = HonamiStoryModel.Instance.GetItemData(updateInfo.ItemIncrId);
		itemData.UpdatePositionInfo(updateInfo.HonamiStoryPosInfo);
		itemData.SetBackpackWidth(this.Width);
		this.RefreshItemMapByAddItem(itemData);
	}

	// Token: 0x0600ED08 RID: 60680 RVA: 0x00387A2C File Offset: 0x00385C2C
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

	// Token: 0x0600ED09 RID: 60681 RVA: 0x00387AD8 File Offset: 0x00385CD8
	public virtual bool PushItemData(HonamiStoryItemDataBase itemData)
	{
		return false;
	}

	// Token: 0x0600ED0A RID: 60682 RVA: 0x00387ADC File Offset: 0x00385CDC
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

	// Token: 0x170012A3 RID: 4771
	// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x00387B8C File Offset: 0x00385D8C
	public int BackpackId
	{
		get
		{
			return this.SelfBackpackId;
		}
	}

	// Token: 0x170012A4 RID: 4772
	// (get) Token: 0x0600ED0C RID: 60684 RVA: 0x00387B94 File Offset: 0x00385D94
	public EHonamiStoryBackpackType BackpackType
	{
		get
		{
			return this.SelfBackpackType;
		}
	}

	// Token: 0x0600ED0D RID: 60685 RVA: 0x00387B9C File Offset: 0x00385D9C
	public List<HonamiStoryItemDataBase> GetItemDataList()
	{
		List<HonamiStoryItemDataBase> list = new List<HonamiStoryItemDataBase>();
		foreach (HonamiStoryItemDataBase item in this.ItemList)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600ED0E RID: 60686 RVA: 0x00387BF8 File Offset: 0x00385DF8
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

	// Token: 0x0600ED0F RID: 60687 RVA: 0x00387C5C File Offset: 0x00385E5C
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

	// Token: 0x0600ED10 RID: 60688 RVA: 0x00387C7C File Offset: 0x00385E7C
	public int GetWidthCount()
	{
		return this.Width;
	}

	// Token: 0x0600ED11 RID: 60689 RVA: 0x00387C84 File Offset: 0x00385E84
	public int GetHeightCount()
	{
		return this.GetHeightCount(false);
	}

	// Token: 0x0600ED12 RID: 60690 RVA: 0x00387C8D File Offset: 0x00385E8D
	public int GetHeightCount(bool needOverflow = false)
	{
		return (int)Math.Floor((double)(needOverflow ? (this.GetCapacity() + this.OverflowCapacity) : this.GetCapacity()) / (double)this.GetWidthCount());
	}

	// Token: 0x0600ED13 RID: 60691 RVA: 0x00387CB6 File Offset: 0x00385EB6
	public int GetCellWidth()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600ED14 RID: 60692 RVA: 0x00387CC7 File Offset: 0x00385EC7
	public int GetCellHeight()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600ED15 RID: 60693 RVA: 0x00387CD8 File Offset: 0x00385ED8
	public int GetCellHorizontalInterval()
	{
		HonamiStoryUtil.IsMobileView();
		return 2;
	}

	// Token: 0x0600ED16 RID: 60694 RVA: 0x00387CE1 File Offset: 0x00385EE1
	public int GetCellVerticalInterval()
	{
		HonamiStoryUtil.IsMobileView();
		return 2;
	}

	// Token: 0x0600ED17 RID: 60695 RVA: 0x00387CEA File Offset: 0x00385EEA
	public void SetCapacity(int value)
	{
		this.Capacity = value;
	}

	// Token: 0x0600ED18 RID: 60696 RVA: 0x00387CF3 File Offset: 0x00385EF3
	public int GetCapacity()
	{
		return this.Capacity;
	}

	// Token: 0x0600ED19 RID: 60697 RVA: 0x00387CFB File Offset: 0x00385EFB
	public int GetOverflowCapacity()
	{
		return this.OverflowCapacity;
	}

	// Token: 0x0600ED1A RID: 60698 RVA: 0x00387D04 File Offset: 0x00385F04
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

	// Token: 0x0600ED1B RID: 60699 RVA: 0x00387E90 File Offset: 0x00386090
	public int GetOccupy()
	{
		int num = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			num += honamiStoryItemDataBase.GetGridHeight() * honamiStoryItemDataBase.GetGridWidth();
		}
		return num;
	}

	// Token: 0x0600ED1C RID: 60700 RVA: 0x00387EF0 File Offset: 0x003860F0
	public int GetTotalValue()
	{
		int num = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			num += honamiStoryItemDataBase.GetSellPrice();
		}
		return num;
	}

	// Token: 0x0600ED1D RID: 60701 RVA: 0x00387F48 File Offset: 0x00386148
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

	// Token: 0x0600ED1E RID: 60702 RVA: 0x00387FA4 File Offset: 0x003861A4
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

	// Token: 0x0600ED1F RID: 60703 RVA: 0x00388000 File Offset: 0x00386200
	public HashSet<int> GetEmptyGridSet()
	{
		return this.EmptyGridSet;
	}

	// Token: 0x04006E0C RID: 28172
	protected int Width;

	// Token: 0x04006E0D RID: 28173
	protected int Capacity;

	// Token: 0x04006E0E RID: 28174
	private int OverflowCapacity;

	// Token: 0x04006E0F RID: 28175
	protected EHonamiStoryBackpackType SelfBackpackType;

	// Token: 0x04006E10 RID: 28176
	protected int SelfBackpackId = -1;

	// Token: 0x04006E11 RID: 28177
	protected List<HonamiStoryItemDataBase> ItemList = new List<HonamiStoryItemDataBase>();

	// Token: 0x04006E12 RID: 28178
	private readonly Dictionary<int, HonamiStoryItemDataBase> ItemMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006E13 RID: 28179
	protected Dictionary<int, HonamiStoryItemDataBase> ItemPosMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006E14 RID: 28180
	protected HashSet<int> EmptyGridSet = new HashSet<int>();
}
