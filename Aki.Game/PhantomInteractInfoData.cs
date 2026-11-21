using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001942 RID: 6466
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractInfoData
{
	// Token: 0x0600FFA2 RID: 65442 RVA: 0x004AA251 File Offset: 0x004A8451
	private int GridSortFunc(IPhantomInteractGridData a, IPhantomInteractGridData b)
	{
		return a.SortId - b.SortId;
	}

	// Token: 0x0600FFA3 RID: 65443 RVA: 0x004AA260 File Offset: 0x004A8460
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

	// Token: 0x0600FFA4 RID: 65444 RVA: 0x004AA458 File Offset: 0x004A8658
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

	// Token: 0x04008DF8 RID: 36344
	public Dictionary<int, int> EquippedMonsterIdMap = new Dictionary<int, int>();

	// Token: 0x04008DF9 RID: 36345
	public List<PhantomInteractItemData> EquippedVisionData = new List<PhantomInteractItemData>();

	// Token: 0x04008DFA RID: 36346
	public List<IPhantomInteractGridData> GridItemDataList = new List<IPhantomInteractGridData>();

	// Token: 0x04008DFB RID: 36347
	public Dictionary<int, PhantomInteractGridData> GridItemDataMap = new Dictionary<int, PhantomInteractGridData>();
}
