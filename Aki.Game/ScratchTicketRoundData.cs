using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020014EE RID: 5358
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketRoundData
{
	// Token: 0x06009891 RID: 39057 RVA: 0x0020F2AC File Offset: 0x0020D4AC
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
		this.UpdateCellDataReward(roundInfo.RewardIds.ToDictionary<int, ScratchCardRewardData>());
		this.UpdateRemainReward(roundInfo.LeftRewardItem.ToDictionary<int, int>());
	}

	// Token: 0x06009892 RID: 39058 RVA: 0x0020F350 File Offset: 0x0020D550
	private void InitCellDataList()
	{
		this.CellDataList.Clear();
		for (int i = 0; i < this.Capacity; i++)
		{
			ScratchTicketCellData item = new ScratchTicketCellData(i);
			this.CellDataList.Add(item);
		}
	}

	// Token: 0x06009893 RID: 39059 RVA: 0x0020F38C File Offset: 0x0020D58C
	private void InitRewardSortMap()
	{
		this.RewardSortMap.Clear();
		for (int i = 0; i < this.Config.Value.RewardSortList().Length; i++)
		{
			int key = this.Config.Value.RewardSortList()[i];
			this.RewardSortMap[key] = i;
		}
	}

	// Token: 0x06009894 RID: 39060 RVA: 0x0020F3E8 File Offset: 0x0020D5E8
	public void UpdateCellDataReward(Dictionary<int, ScratchCardRewardData> rewardMap)
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

	// Token: 0x06009895 RID: 39061 RVA: 0x0020F470 File Offset: 0x0020D670
	public void UpdateRemainReward(Dictionary<int, int> rewardList)
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

	// Token: 0x06009896 RID: 39062 RVA: 0x0020F508 File Offset: 0x0020D708
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

	// Token: 0x06009897 RID: 39063 RVA: 0x0020F572 File Offset: 0x0020D772
	public long GetUnlockTime()
	{
		return this.UnlockTime;
	}

	// Token: 0x06009898 RID: 39064 RVA: 0x0020F57C File Offset: 0x0020D77C
	public EScratchTicketRoundState GetPreRoundState()
	{
		ScratchTicketRoundData scratchRoundData = ActivityScratchTicketModel.Instance.GetScratchRoundData(this.Config.Value.PreRoundId);
		if (scratchRoundData == null)
		{
			return EScratchTicketRoundState.Finish;
		}
		return scratchRoundData.GetRoundState();
	}

	// Token: 0x06009899 RID: 39065 RVA: 0x0020F5B2 File Offset: 0x0020D7B2
	public EScratchTicketRoundState GetRoundState()
	{
		return this.RoundState;
	}

	// Token: 0x0600989A RID: 39066 RVA: 0x0020F5BA File Offset: 0x0020D7BA
	public List<ScratchTicketCellData> GetCellDataList()
	{
		return this.CellDataList;
	}

	// Token: 0x0600989B RID: 39067 RVA: 0x0020F5C2 File Offset: 0x0020D7C2
	public List<TItem> GetRemainRewardList()
	{
		return this.RemainRewardList;
	}

	// Token: 0x0600989C RID: 39068 RVA: 0x0020F5CC File Offset: 0x0020D7CC
	public List<RewardItemData> GetRewardDataList(Dictionary<int, int> itemMap)
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

	// Token: 0x0600989D RID: 39069 RVA: 0x0020F658 File Offset: 0x0020D858
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

	// Token: 0x0600989E RID: 39070 RVA: 0x0020F6E0 File Offset: 0x0020D8E0
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

	// Token: 0x0600989F RID: 39071 RVA: 0x0020F728 File Offset: 0x0020D928
	private List<ScratchTicketRoundResult> GetRewardCrossResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardCrossRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardCrossRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x060098A0 RID: 39072 RVA: 0x0020F76C File Offset: 0x0020D96C
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

	// Token: 0x060098A1 RID: 39073 RVA: 0x0020F7D0 File Offset: 0x0020D9D0
	private List<ScratchTicketRoundResult> GetRewardNineGridCellResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x060098A2 RID: 39074 RVA: 0x0020F814 File Offset: 0x0020DA14
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

	// Token: 0x060098A3 RID: 39075 RVA: 0x0020F8A0 File Offset: 0x0020DAA0
	private List<ScratchTicketRoundResult> GetRewardRowResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardRowRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRowRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x060098A4 RID: 39076 RVA: 0x0020F8E4 File Offset: 0x0020DAE4
	private void PushRewardRowRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x060098A5 RID: 39077 RVA: 0x0020F914 File Offset: 0x0020DB14
	private List<ScratchTicketRoundResult> GetRewardColumnResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardColumnRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardColumnRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x060098A6 RID: 39078 RVA: 0x0020F958 File Offset: 0x0020DB58
	private void PushRewardColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x060098A7 RID: 39079 RVA: 0x0020F988 File Offset: 0x0020DB88
	private List<ScratchTicketRoundResult> GetRewardRowAndColumnResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
		this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, true);
		return rewardCenterResult;
	}

	// Token: 0x060098A8 RID: 39080 RVA: 0x0020F9CC File Offset: 0x0020DBCC
	private void PushRewardRowAndColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
	{
		List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
		this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
		this.PushRewardResultAlongDirection(result, list, checkLock);
	}

	// Token: 0x060098A9 RID: 39081 RVA: 0x0020FA10 File Offset: 0x0020DC10
	private List<ScratchTicketRoundResult> GetRemainingRewardResult(int index)
	{
		List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 1000f, "HamsterC");
		this.PushRewardRemainingRoundResult(rewardCenterResult, false);
		this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
		this.PushRewardRemainingRoundResult(rewardCenterResult, true);
		return rewardCenterResult;
	}

	// Token: 0x060098AA RID: 39082 RVA: 0x0020FA54 File Offset: 0x0020DC54
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

	// Token: 0x060098AB RID: 39083 RVA: 0x0020FAF0 File Offset: 0x0020DCF0
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

	// Token: 0x060098AC RID: 39084 RVA: 0x0020FB88 File Offset: 0x0020DD88
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

	// Token: 0x060098AD RID: 39085 RVA: 0x0020FBD0 File Offset: 0x0020DDD0
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

	// Token: 0x060098AE RID: 39086 RVA: 0x0020FC14 File Offset: 0x0020DE14
	private void PushSequenceRoundResult(List<ScratchTicketRoundResult> result, int delayInterval, string sequenceName)
	{
		ScratchTicketRoundResult roundResultData = this.GetRoundResultData(new List<ScratchTicketRewardResult>(), (float)delayInterval, sequenceName);
		result.Add(roundResultData);
	}

	// Token: 0x060098AF RID: 39087 RVA: 0x0020FC38 File Offset: 0x0020DE38
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

	// Token: 0x060098B0 RID: 39088 RVA: 0x0020FC94 File Offset: 0x0020DE94
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

	// Token: 0x060098B1 RID: 39089 RVA: 0x0020FCFC File Offset: 0x0020DEFC
	private bool CheckIndexValid(int index, bool needLog = true)
	{
		return index >= 0 && index < this.Capacity;
	}

	// Token: 0x060098B2 RID: 39090 RVA: 0x0020FD0D File Offset: 0x0020DF0D
	private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, int delayInterval)
	{
		return this.GetRoundResultData(rewardList, (float)delayInterval, "Empty");
	}

	// Token: 0x060098B3 RID: 39091 RVA: 0x0020FD1D File Offset: 0x0020DF1D
	private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, float delayInterval, string sequenceName)
	{
		return new ScratchTicketRoundResult
		{
			RewardList = rewardList,
			DelayInterval = delayInterval,
			SequenceName = sequenceName
		};
	}

	// Token: 0x060098B4 RID: 39092 RVA: 0x0020FD3C File Offset: 0x0020DF3C
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

	// Token: 0x060098B5 RID: 39093 RVA: 0x0020FD76 File Offset: 0x0020DF76
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

	// Token: 0x060098B6 RID: 39094 RVA: 0x0020FD89 File Offset: 0x0020DF89
	public ScratchTicketCellData GetCellDataByIndex(int index)
	{
		if (!this.CheckIndexValid(index, true))
		{
			return null;
		}
		return this.CellDataList[index];
	}

	// Token: 0x060098B7 RID: 39095 RVA: 0x0020FDA4 File Offset: 0x0020DFA4
	private int GetCellDataIndex(int row, int column)
	{
		int size = this.Config.Value.Size;
		if (column < 0 || column >= size || row < 0 || row >= size)
		{
			return -1;
		}
		return row * size + column;
	}

	// Token: 0x060098B8 RID: 39096 RVA: 0x0020FDDC File Offset: 0x0020DFDC
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

	// Token: 0x0400432B RID: 17195
	public int Id;

	// Token: 0x0400432C RID: 17196
	private long UnlockTime;

	// Token: 0x0400432D RID: 17197
	public ScratchCardRoundRe? Config;

	// Token: 0x0400432E RID: 17198
	private List<ScratchTicketCellData> CellDataList = new List<ScratchTicketCellData>();

	// Token: 0x0400432F RID: 17199
	private int RewardCount;

	// Token: 0x04004330 RID: 17200
	private List<TItem> RemainRewardList = new List<TItem>();

	// Token: 0x04004331 RID: 17201
	private EScratchTicketRoundState RoundState;

	// Token: 0x04004332 RID: 17202
	private readonly Dictionary<int, int> RewardSortMap = new Dictionary<int, int>();

	// Token: 0x04004333 RID: 17203
	private int Capacity;

	// Token: 0x04004334 RID: 17204
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ScratchTicketRoundResult> DiagonalResultList;
}
