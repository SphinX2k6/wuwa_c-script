using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200245D RID: 9309
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractInfoData
{
	// Token: 0x06012AEA RID: 76522 RVA: 0x0049CAE5 File Offset: 0x0049ACE5
	private int GridSortFunc(IPhantomInteractGridData a, IPhantomInteractGridData b)
	{
		return a.SortId - b.SortId;
	}

	// Token: 0x06012AEB RID: 76523 RVA: 0x0049CAF4 File Offset: 0x0049ACF4
	public void LoadFromProto(PhantomInteractionUnlockNotify proto)
	{
		this.EquippedMonsterIdMap.Clear();
		this.GridItemDataMap.Clear();
		this.EquippedVisionData.Clear();
		this.GridItemDataList.Clear();
		List<int> list = new List<int>();
		foreach (int item in proto.EquipedMonsterIds)
		{
			list.Add(item);
		}
		if (list.Count <= 0)
		{
			list = new List<int>
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
		}
		foreach (int num in list)
		{
			if (num <= 0)
			{
				PhantomInteractItemData phantomInteractItemData = new PhantomInteractItemData();
				phantomInteractItemData.LoadEmpty(this.EquippedVisionData.Count);
				this.EquippedVisionData.Add(phantomInteractItemData);
			}
			else
			{
				PhantomInteractItemData phantomInteractItemData2 = new PhantomInteractItemData();
				int count = this.EquippedVisionData.Count;
				phantomInteractItemData2.LoadData(count, num);
				this.EquippedVisionData.Add(phantomInteractItemData2);
				this.EquippedMonsterIdMap[num] = count;
			}
		}
		foreach (UnlockIllustratedPhantom unlockIllustratedPhantom in proto.UnlockIllustratedPhantoms)
		{
			PhantomInteractGridData phantomInteractGridData = new PhantomInteractGridData();
			int monsterId = unlockIllustratedPhantom.MonsterId;
			int num2;
			int inSlotIndex = this.EquippedMonsterIdMap.TryGetValue(monsterId, out num2) ? num2 : -1;
			phantomInteractGridData.LoadData(unlockIllustratedPhantom);
			phantomInteractGridData.InSlotIndex = inSlotIndex;
			this.GridItemDataList.Add(phantomInteractGridData);
			this.GridItemDataMap[monsterId] = phantomInteractGridData;
		}
	}

	// Token: 0x06012AEC RID: 76524 RVA: 0x0049CCEC File Offset: 0x0049AEEC
	public bool UpdateFromProto(PhantomInteractionInfoUpdateNotify proto)
	{
		UnlockIllustratedPhantom unlockIllustratedPhantom = proto.UnlockIllustratedPhantom;
		if (unlockIllustratedPhantom == null)
		{
			return false;
		}
		int monsterId = unlockIllustratedPhantom.MonsterId;
		PhantomInteractGridData phantomInteractGridData;
		if (this.GridItemDataMap.TryGetValue(monsterId, out phantomInteractGridData) && phantomInteractGridData != null)
		{
			phantomInteractGridData.LoadData(unlockIllustratedPhantom);
			return false;
		}
		PhantomInteractGridData phantomInteractGridData2 = new PhantomInteractGridData();
		phantomInteractGridData2.LoadData(unlockIllustratedPhantom);
		this.GridItemDataMap[monsterId] = phantomInteractGridData2;
		this.GridItemDataList.Add(phantomInteractGridData2);
		this.GridItemDataList.Sort(new Comparison<IPhantomInteractGridData>(this.GridSortFunc));
		return true;
	}

	// Token: 0x04008CB1 RID: 36017
	public Dictionary<int, int> EquippedMonsterIdMap = new Dictionary<int, int>();

	// Token: 0x04008CB2 RID: 36018
	public List<PhantomInteractItemData> EquippedVisionData = new List<PhantomInteractItemData>();

	// Token: 0x04008CB3 RID: 36019
	public List<IPhantomInteractGridData> GridItemDataList = new List<IPhantomInteractGridData>();

	// Token: 0x04008CB4 RID: 36020
	public Dictionary<int, PhantomInteractGridData> GridItemDataMap = new Dictionary<int, PhantomInteractGridData>();
}
