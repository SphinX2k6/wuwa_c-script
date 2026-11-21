using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020009A6 RID: 2470
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketRoundData
{
	// Token: 0x06006C6B RID: 27755 RVA: 0x00218FB4 File Offset: 0x002171B4
	public void Init(ScratchCardRoundInfo roundInfo)
	{
		this.Id = roundInfo.RoundId;
		this.Config = ActivityScratchTicketConfig.Instance.GetScratchTicketRoundConfig(this.Id);
		if (this.Config == null)
		{
			return;
		}
		this.Capacity = this.Config.Value.Size * this.Config.Value.Size;
		this.UnlockTime = roundInfo.UnlockTime;
		this.InitCellDataList();
		this.InitRewardSortMap();
		this.UpdateCellDataReward(roundInfo.RewardIds);
		this.UpdateRemainReward(roundInfo.LeftRewardItem);
	}

	// Token: 0x06006C6C RID: 27756 RVA: 0x00219050 File Offset: 0x00217250
	private void InitCellDataList()
	{
		this.CellDataList.Clear();
		for (int i = 0; i < this.Capacity; i++)
		{
			ScratchTicketCellData item = new ScratchTicketCellData(i);
			this.CellDataList.Add(item);
		}
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x0021908C File Offset: 0x0021728C
	private void InitRewardSortMap()
	{
		this.RewardSortMap.Clear();
		for (int i = 0; i < this.Config.Value.RewardSortList().Length; i++)
		{
			int key = this.Config.Value.RewardSortList()[i];
			this.RewardSortMap[key] = i;
		}
	}

	// Token: 0x06006C6E RID: 27758 RVA: 0x002190E8 File Offset: 0x002172E8
	public void UpdateCellDataReward([Nullable(new byte[]
	{
		1,
		0,
		1
	})] IEnumerable<KeyValuePair<int, ScratchCardRewardData>> rewardMap)
	{
		foreach (KeyValuePair<int, ScratchCardRewardData> keyValuePair in rewardMap)
		{
			int key = keyValuePair.Key;
			if (key >= 0 && key < this.CellDataList.Count)
			{
				this.CellDataList[key].SetRewardItem(keyValuePair.Value);
				this.RewardCount++;
			}
		}
	}

	// Token: 0x06006C6F RID: 27759 RVA: 0x0021916C File Offset: 0x0021736C
	public void UpdateRemainReward([Nullable(new byte[]
	{
		1,
		0
	})] IEnumerable<KeyValuePair<int, int>> rewardList)
	{
		this.RemainRewardList.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in rewardList)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
			this.RemainRewardList.Add(item);
		}
		this.RemainRewardList.Sort(delegate(TItem a, TItem b)
		{
			int num2;
			int num = this.RewardSortMap.TryGetValue(a.ItemData.ItemId, out num2) ? num2 : int.MaxValue;
			int num4;
			int num3 = this.RewardSortMap.TryGetValue(b.ItemData.ItemId, out num4) ? num4 : int.MaxValue;
			return num - num3;
		});
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x002191FC File Offset: 0x002173FC
	public void UpdateRoundState(EScratchTicketRoundState preState)
	{
		if (TimeUtil.Instance.GetServerTimeStamp() <= (double)this.UnlockTime || preState != EScratchTicketRoundState.Finish)
		{
			this.RoundState = EScratchTicketRoundState.Lock;
			return;
		}
		if (this.RewardCount >= this.Config.Value.Size * this.Config.Value.Size)
		{
			this.RoundState = EScratchTicketRoundState.Finish;
			return;
		}
		this.RoundState = EScratchTicketRoundState.InProgress;
	}

	// Token: 0x06006C71 RID: 27761 RVA: 0x00219266 File Offset: 0x00217466
	public long GetUnlockTime()
	{
		return this.UnlockTime;
	}

	// Token: 0x06006C72 RID: 27762 RVA: 0x00219270 File Offset: 0x00217470
	public EScratchTicketRoundState GetPreRoundState()
	{
		ScratchTicketRoundData scratchRoundData = ActivityScratchTicketModel.Instance.GetScratchRoundData(this.Config.Value.PreRoundId);
		if (scratchRoundData == null)
		{
			return EScratchTicketRoundState.Finish;
		}
		return scratchRoundData.GetRoundState();
	}

	// Token: 0x06006C73 RID: 27763 RVA: 0x002192A6 File Offset: 0x002174A6
	public EScratchTicketRoundState GetRoundState()
	{
		return this.RoundState;
	}

	// Token: 0x06006C74 RID: 27764 RVA: 0x002192AE File Offset: 0x002174AE
	public List<ScratchTicketCellData> GetCellDataList()
	{
		return this.CellDataList;
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x002192B6 File Offset: 0x002174B6
	public List<TItem> GetRemainRewardList()
	{
		return this.RemainRewardList;
	}

	// Token: 0x06006C76 RID: 27766 RVA: 0x002192C0 File Offset: 0x002174C0
	public List<RewardItemData> GetRewardDataList([Nullable(new byte[]
	{
		1,
		0
	})] IEnumerable<KeyValuePair<int, int>> itemMap)
	{
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (KeyValuePair<int, int> keyValuePair in itemMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			RewardItemData item = new RewardItemData(key, value, null, EDropItemType.Normal);
			list.Add(item);
		}
		list.Sort(delegate(RewardItemData a, RewardItemData b)
		{
			int num2;
			int num = this.RewardSortMap.TryGetValue(a.ConfigId, out num2) ? num2 : int.MaxValue;
			int num4;
			int num3 = this.RewardSortMap.TryGetValue(b.ConfigId, out num4) ? num4 : int.MaxValue;
			return num - num3;
		});
		return list;
	}

	// Token: 0x06006C77 RID: 27767 RVA: 0x00219344 File Offset: 0x00217544
	public List<ScratchTicketRoundResult> GetRewardResultList(int index, EScratchTicketRewardType rewardType)
	{
		if (!this.CheckIndexValid(index, true))
		{
			return new List<ScratchTicketRoundResult>();
		}
		switch (rewardType)
		{
		case EScratchTicketRewardType.Center:
			return this.GetRewardCenterResult(index, 700f, "HamsterA");
		case EScratchTicketRewardType.Cross:
			return this.GetRewardCrossResult(index);
		case EScratchTicketRewardType.Column:
			return this.GetRewardColumnResult(index);
		case EScratchTicketRewardType.Row:
			return this.GetRewardRowResult(index);
		case EScratchTicketRewardType.NineGridCell:
			return this.GetRewardNineGridCellResult(index);
		case EScratchTicketRewardType.ColumnAndRow:
			return this.GetRewardRowAndColumnResult(index);
		case EScratchTicketRewardType.AllGrid:
			return this.GetRemainingRewardResult(index);
		default:
			return new List<ScratchTicketRoundResult>();
		}
	}

	// Token: 0x06006C78 RID: 27768 RVA: 0x002193CC File Offset: 0x002175CC
	private List<ScratchTicketRoundResult> GetRewardCenterResult(int index, float delayInterval, string sequenceName)
	{
		List<ScratchTicketRoundResult> list = new List<ScratchTicketRoundResult>();
		if (!this.CheckIndexValid(index, true))
		{
			return list;
		}
		ScratchTicketRewardResult rewardResultData = this.GetRewardResultData(index, EScratchDirectionType.Center, true);
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(new List<ScratchTicketRewardResult>
		{
			rewardResultData
		}, delayInterval, sequenceName);
		list.Add(roundResultData);
		return list;
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x00219414 File Offset: 0x00217614
	private List<ScratchTicketRoundResult> GetRewardCrossResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardCrossRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardCrossRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x00219458 File Offset: 0x00217658
	private void PushRewardCrossRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushRewardResult(list, index, EScratchDirectionType.Left, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Top, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Bottom, checkLock);
		if (list.Count <= 0)
		{
			return;
		}
		int delayInterval = this.GetDelayInterval(false, !checkLock);
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(list, delayInterval);
		result.Add(roundResultData);
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x002194BC File Offset: 0x002176BC
	private List<ScratchTicketRoundResult> GetRewardNineGridCellResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C7C RID: 27772 RVA: 0x00219500 File Offset: 0x00217700
	private void PushRewardNineGridCellRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushRewardResult(list, index, EScratchDirectionType.Left, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Top, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.Bottom, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.LeftTop, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.LeftBottom, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.RightTop, checkLock);
		this.PushRewardResult(list, index, EScratchDirectionType.RightBottom, checkLock);
		if (list.Count <= 0)
		{
			return;
		}
		int delayInterval = this.GetDelayInterval(false, !checkLock);
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(list, delayInterval);
		result.Add(roundResultData);
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x0021958C File Offset: 0x0021778C
	private List<ScratchTicketRoundResult> GetRewardRowResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardRowRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRowRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x002195D0 File Offset: 0x002177D0
	private void PushRewardRowRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x06006C7F RID: 27775 RVA: 0x00219600 File Offset: 0x00217800
	private List<ScratchTicketRoundResult> GetRewardColumnResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardColumnRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardColumnRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C80 RID: 27776 RVA: 0x00219644 File Offset: 0x00217844
	private void PushRewardColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x00219674 File Offset: 0x00217874
	private List<ScratchTicketRoundResult> GetRewardRowAndColumnResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x002196B8 File Offset: 0x002178B8
	private void PushRewardRowAndColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x002196FC File Offset: 0x002178FC
	private List<ScratchTicketRoundResult> GetRemainingRewardResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 1000f, "HamsterC");
		this.PushRewardRemainingRoundResult(rewardCenterResult, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRemainingRoundResult(rewardCenterResult, true);
		return rewardCenterResult;
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x00219740 File Offset: 0x00217940
	private void PushRewardRemainingRoundResult(List<ScratchTicketRoundResult> result, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		foreach (ScratchTicketCellData scratchTicketCellData in this.GetCellDataList())
		{
			if (!checkLock || scratchTicketCellData.IsLock())
			{
				ScratchTicketRewardResult rewardResultData = this.GetRewardResultData(scratchTicketCellData.Index, EScratchDirectionType.Center, true);
				list.Add(rewardResultData);
			}
		}
		if (list.Count > 0)
		{
			int delayInterval = this.GetDelayInterval(false, !checkLock);
			ScratchTicketRoundResult roundResultData = this.GetRoundResultData(list, delayInterval);
			result.Add(roundResultData);
		}
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x002197DC File Offset: 0x002179DC
	private void PushRewardResultAlongDirection(List<ScratchTicketRoundResult> result, List<ScratchTicketRewardResult> rewardResultList, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>(rewardResultList);
		int delayInterval = this.GetDelayInterval(false, !checkLock);
		while (list.Count > 0)
		{
			ScratchTicketRoundResult roundResultData = this.GetRoundResultData(list, delayInterval);
			result.Add(roundResultData);
			List<ScratchTicketRewardResult> list2 = new List<ScratchTicketRewardResult>();
			foreach (ScratchTicketRewardResult scratchTicketRewardResult in list)
			{
				this.PushDirectionFirstReward(list2, scratchTicketRewardResult.Index, scratchTicketRewardResult.DirectionType, checkLock);
			}
			list = list2;
		}
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x00219874 File Offset: 0x00217A74
	private void PushDirectionFirstReward(List<ScratchTicketRewardResult> roundResult, int index, EScratchDirectionType direction, bool checkLock)
	{
		int num = index;
		for (;;)
		{
			num = this.GetCellDataIndexByDirection(num, direction);
			ScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(num);
			if (cellDataByIndex != null && (!checkLock || cellDataByIndex.IsLock()))
			{
				break;
			}
			if (num < 0)
			{
				return;
			}
		}
		ScratchTicketRewardResult rewardResultData = this.GetRewardResultData(num, direction, checkLock);
		roundResult.Add(rewardResultData);
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x002198BC File Offset: 0x00217ABC
	private void PushRewardResult(List<ScratchTicketRewardResult> roundResult, int index, EScratchDirectionType direction, bool checkLock)
	{
		int cellDataIndexByDirection = this.GetCellDataIndexByDirection(index, direction);
		ScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(cellDataIndexByDirection);
		if (cellDataByIndex == null)
		{
			return;
		}
		if (checkLock && !cellDataByIndex.IsLock())
		{
			return;
		}
		ScratchTicketRewardResult rewardResultData = this.GetRewardResultData(cellDataIndexByDirection, direction, checkLock);
		roundResult.Add(rewardResultData);
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x00219900 File Offset: 0x00217B00
	private void PushSequenceRoundResult(List<ScratchTicketRoundResult> result, int delayInterval, string sequenceName)
	{
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(new List<ScratchTicketRewardResult>(), (float)delayInterval, sequenceName);
		result.Add(roundResultData);
	}

	// Token: 0x06006C89 RID: 27785 RVA: 0x00219924 File Offset: 0x00217B24
	public List<ScratchTicketRoundResult> GetDiagonalResultList()
	{
		if (this.DiagonalResultList != null)
		{
			return this.DiagonalResultList;
		}
		this.DiagonalResultList = new List<ScratchTicketRoundResult>();
		int size = this.Config.Value.Size;
		for (int i = 0; i < size * 2; i++)
		{
			this.PushDiagonalRoundResult(this.DiagonalResultList, i);
		}
		return this.DiagonalResultList;
	}

	// Token: 0x06006C8A RID: 27786 RVA: 0x00219980 File Offset: 0x00217B80
	private void PushDiagonalRoundResult(List<ScratchTicketRoundResult> result, int roundIndex)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		for (int i = 0; i <= roundIndex; i++)
		{
			int column = roundIndex - i;
			int cellDataIndex = this.GetCellDataIndex(i, column);
			if (cellDataIndex >= 0)
			{
				ScratchTicketRewardResult item = new ScratchTicketRewardResult
				{
					Index = cellDataIndex,
					DirectionType = EScratchDirectionType.Center,
					SequenceType = ECellSequenceType.Reveal
				};
				list.Add(item);
			}
		}
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(list, 30);
		result.Add(roundResultData);
	}

	// Token: 0x06006C8B RID: 27787 RVA: 0x002199E8 File Offset: 0x00217BE8
	private bool CheckIndexValid(int index, bool needLog = true)
	{
		return index >= 0 && index < this.Capacity;
	}

	// Token: 0x06006C8C RID: 27788 RVA: 0x002199F9 File Offset: 0x00217BF9
	private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, int delayInterval)
	{
		return this.GetRoundResultData(rewardList, (float)delayInterval, "Empty");
	}

	// Token: 0x06006C8D RID: 27789 RVA: 0x00219A09 File Offset: 0x00217C09
	private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, float delayInterval, string sequenceName)
	{
		return new ScratchTicketRoundResult
		{
			RewardList = rewardList,
			DelayInterval = delayInterval,
			SequenceName = sequenceName
		};
	}

	// Token: 0x06006C8E RID: 27790 RVA: 0x00219A28 File Offset: 0x00217C28
	private ScratchTicketRewardResult GetRewardResultData(int index, EScratchDirectionType directionType, bool checkLock)
	{
		ECellSequenceType sequenceType = ECellSequenceType.Warning;
		if (checkLock)
		{
			ActivityScratchTicketDefine.DirectionToSequenceMap.TryGetValue(directionType, out sequenceType);
		}
		return new ScratchTicketRewardResult
		{
			Index = index,
			DirectionType = directionType,
			SequenceType = sequenceType
		};
	}

	// Token: 0x06006C8F RID: 27791 RVA: 0x00219A62 File Offset: 0x00217C62
	private int GetDelayInterval(bool isFirst, bool isWaring)
	{
		if (isFirst)
		{
			return 700;
		}
		if (isWaring)
		{
			return 50;
		}
		return 100;
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x00219A75 File Offset: 0x00217C75
	public ScratchTicketCellData GetCellDataByIndex(int index)
	{
		if (!this.CheckIndexValid(index, true))
		{
			return null;
		}
		return this.CellDataList[index];
	}

	// Token: 0x06006C91 RID: 27793 RVA: 0x00219A90 File Offset: 0x00217C90
	private int GetCellDataIndex(int row, int column)
	{
		int size = this.Config.Value.Size;
		if (column < 0 || column >= size || row < 0 || row >= size)
		{
			return -1;
		}
		return row * size + column;
	}

	// Token: 0x06006C92 RID: 27794 RVA: 0x00219AC8 File Offset: 0x00217CC8
	private int GetCellDataIndexByDirection(int index, EScratchDirectionType directionType)
	{
		int size = this.Config.Value.Size;
		int num = index % size;
		int num2 = index / size;
		switch (directionType)
		{
		case EScratchDirectionType.Left:
			num--;
			break;
		case EScratchDirectionType.Right:
			num++;
			break;
		case EScratchDirectionType.Top:
			num2--;
			break;
		case EScratchDirectionType.Bottom:
			num2++;
			break;
		case EScratchDirectionType.LeftTop:
			num2--;
			num--;
			break;
		case EScratchDirectionType.LeftBottom:
			num2++;
			num--;
			break;
		case EScratchDirectionType.RightTop:
			num2--;
			num++;
			break;
		case EScratchDirectionType.RightBottom:
			num2++;
			num++;
			break;
		}
		return this.GetCellDataIndex(num2, num);
	}

	// Token: 0x040043D0 RID: 17360
	public int Id;

	// Token: 0x040043D1 RID: 17361
	private long UnlockTime;

	// Token: 0x040043D2 RID: 17362
	public ScratchCardRoundRe? Config;

	// Token: 0x040043D3 RID: 17363
	private List<ScratchTicketCellData> CellDataList = new List<ScratchTicketCellData>();

	// Token: 0x040043D4 RID: 17364
	private int RewardCount;

	// Token: 0x040043D5 RID: 17365
	private List<TItem> RemainRewardList = new List<TItem>();

	// Token: 0x040043D6 RID: 17366
	private EScratchTicketRoundState RoundState;

	// Token: 0x040043D7 RID: 17367
	private readonly Dictionary<int, int> RewardSortMap = new Dictionary<int, int>();

	// Token: 0x040043D8 RID: 17368
	private int Capacity;

	// Token: 0x040043D9 RID: 17369
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ScratchTicketRoundResult> DiagonalResultList;
}
