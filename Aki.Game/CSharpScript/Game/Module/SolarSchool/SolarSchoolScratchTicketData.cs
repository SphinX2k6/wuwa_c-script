using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005938 RID: 22840
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketData
	{
		// Token: 0x17006BD9 RID: 27609
		// (get) Token: 0x06038485 RID: 230533 RVA: 0x00FBC8F3 File Offset: 0x00FBAAF3
		public bool IsFinish
		{
			get
			{
				return this.RevealedCount >= this.Capacity;
			}
		}

		// Token: 0x06038486 RID: 230534 RVA: 0x00FBC908 File Offset: 0x00FBAB08
		[NullableContext(2)]
		public bool Init(SolarSchoolScratchTicketCo config, IReadOnlyList<SolarSchoolScratchTicketRe> rewards)
		{
			this.Config = new SolarSchoolScratchTicketCo?(config);
			this.Capacity = config.Size * config.Size;
			this.BoardSize = config.Size;
			if (this.Capacity <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.HHJ;
				string message = "[SolarSchool][ScratchTicket] 刮卡边长非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("size", config.Size);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.InitCellDataList();
			this.InitReward(rewards);
			return true;
		}

		// Token: 0x06038487 RID: 230535 RVA: 0x00FBC994 File Offset: 0x00FBAB94
		private void InitCellDataList()
		{
			this.CellDataList.Clear();
			for (int i = 0; i < this.Capacity; i++)
			{
				this.CellDataList.Add(new SolarSchoolScratchTicketCellData(i));
			}
		}

		// Token: 0x06038488 RID: 230536 RVA: 0x00FBC9D0 File Offset: 0x00FBABD0
		[NullableContext(2)]
		private unsafe void InitReward(IReadOnlyList<SolarSchoolScratchTicketRe> rewards)
		{
			if (rewards == null)
			{
				return;
			}
			for (int i = 0; i < rewards.Count; i++)
			{
				SolarSchoolScratchTicketRe solarSchoolScratchTicketRe = rewards[i];
				if (solarSchoolScratchTicketRe.RewardId > 0 && solarSchoolScratchTicketRe.Weight > 0)
				{
					this.RewardPool.PutItem(new int[]
					{
						i,
						solarSchoolScratchTicketRe.Weight
					});
					if (!this.RewardOrder.Contains(solarSchoolScratchTicketRe.RewardId))
					{
						this.RewardOrder.Add(solarSchoolScratchTicketRe.RewardId);
					}
				}
			}
			for (int j = 0; j < this.Capacity; j++)
			{
				if (!this.RewardPool.HasItem())
				{
					return;
				}
				int[] item = this.RewardPool.GetItem();
				if (item == null)
				{
					return;
				}
				int rewardId = rewards[item[0]].RewardId;
				SolarSchoolReward? reward = SolarSchoolConfig.Instance.GetReward(rewardId);
				if (reward != null)
				{
					ESolarSchoolRewardType rewardType = (ESolarSchoolRewardType)reward.Value.RewardType;
					if (rewardType != ESolarSchoolRewardType.Item && rewardType != ESolarSchoolRewardType.PlayerAttr)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.HHJ;
						string message = "[SolarSchool][ScratchTicket] 刮卡仅支持物品/属性奖励，跳过";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rewardId", rewardId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rewardType", reward.Value.RewardType);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						SolarSchoolScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(j);
						if (cellDataByIndex != null)
						{
							cellDataByIndex.SetReward(reward.Value);
						}
					}
				}
			}
		}

		// Token: 0x06038489 RID: 230537 RVA: 0x00FBCB5F File Offset: 0x00FBAD5F
		public IReadOnlyList<SolarSchoolScratchTicketCellData> GetCellDataList()
		{
			return this.CellDataList;
		}

		// Token: 0x0603848A RID: 230538 RVA: 0x00FBCB67 File Offset: 0x00FBAD67
		[NullableContext(2)]
		public SolarSchoolScratchTicketCellData GetCellDataByIndex(int index)
		{
			if (!this.CheckIndexValid(index))
			{
				return null;
			}
			return this.CellDataList[index];
		}

		// Token: 0x0603848B RID: 230539 RVA: 0x00FBCB80 File Offset: 0x00FBAD80
		public EScratchTicketRewardType DecideRevealType()
		{
			EScratchTicketRewardType pityType = this.GetPityType();
			int minCondition = this.Config.Value.MinCondition;
			int maxCondition = this.Config.Value.MaxCondition;
			int probability = this.Config.Value.Probability;
			if (this.Counter >= minCondition)
			{
				return this.HitPityType(pityType);
			}
			if (Random.Shared.Next(0, 100) >= probability)
			{
				return this.HitNormalType();
			}
			if (this.RevCounter >= maxCondition)
			{
				return this.HitNormalType();
			}
			return this.HitPityType(pityType);
		}

		// Token: 0x0603848C RID: 230540 RVA: 0x00FBCC14 File Offset: 0x00FBAE14
		private EScratchTicketRewardType GetPityType()
		{
			int type = this.Config.Value.Type;
			if (!Enum.IsDefined(typeof(EScratchTicketRewardType), type))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.HHJ;
				string message = "[SolarSchool][ScratchTicket] 保底类型非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return EScratchTicketRewardType.Center;
			}
			return (EScratchTicketRewardType)type;
		}

		// Token: 0x0603848D RID: 230541 RVA: 0x00FBCC7E File Offset: 0x00FBAE7E
		private EScratchTicketRewardType HitPityType(EScratchTicketRewardType pityType)
		{
			this.RevCounter++;
			this.Counter = 0;
			return pityType;
		}

		// Token: 0x0603848E RID: 230542 RVA: 0x00FBCC96 File Offset: 0x00FBAE96
		private EScratchTicketRewardType HitNormalType()
		{
			this.Counter++;
			this.RevCounter = 0;
			return EScratchTicketRewardType.Center;
		}

		// Token: 0x0603848F RID: 230543 RVA: 0x00FBCCB0 File Offset: 0x00FBAEB0
		public List<SolarSchoolReward> ApplyReveal(List<ScratchTicketRoundResult> results)
		{
			List<SolarSchoolReward> list = new List<SolarSchoolReward>();
			foreach (ScratchTicketRoundResult scratchTicketRoundResult in results)
			{
				foreach (ScratchTicketRewardResult scratchTicketRewardResult in scratchTicketRoundResult.RewardList)
				{
					if (this.Unlock(scratchTicketRewardResult.Index))
					{
						SolarSchoolScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(scratchTicketRewardResult.Index);
						if (cellDataByIndex != null && cellDataByIndex.PlacedReward != null)
						{
							list.Add(cellDataByIndex.PlacedReward.Value);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06038490 RID: 230544 RVA: 0x00FBCD84 File Offset: 0x00FBAF84
		private bool Unlock(int index)
		{
			SolarSchoolScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(index);
			if (cellDataByIndex == null || !cellDataByIndex.IsLock())
			{
				return false;
			}
			cellDataByIndex.Reveal();
			this.RevealedCount++;
			return true;
		}

		// Token: 0x06038491 RID: 230545 RVA: 0x00FBCDBC File Offset: 0x00FBAFBC
		public List<ScratchTicketRoundResult> GetRewardResultList(int index, EScratchTicketRewardType rewardType)
		{
			if (!this.CheckIndexValid(index))
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

		// Token: 0x06038492 RID: 230546 RVA: 0x00FBCE44 File Offset: 0x00FBB044
		private List<ScratchTicketRoundResult> GetRewardCenterResult(int index, float delayInterval, string sequenceName)
		{
			List<ScratchTicketRoundResult> list = new List<ScratchTicketRoundResult>();
			if (!this.CheckIndexValid(index))
			{
				return list;
			}
			ScratchTicketRewardResult rewardResultData = this.GetRewardResultData(index, EScratchDirectionType.Center, true);
			list.Add(this.GetRoundResultData(new List<ScratchTicketRewardResult>
			{
				rewardResultData
			}, delayInterval, sequenceName));
			return list;
		}

		// Token: 0x06038493 RID: 230547 RVA: 0x00FBCE88 File Offset: 0x00FBB088
		private List<ScratchTicketRoundResult> GetRewardCrossResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
			this.PushRewardCrossRoundResult(rewardCenterResult, index, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardCrossRoundResult(rewardCenterResult, index, true);
			return rewardCenterResult;
		}

		// Token: 0x06038494 RID: 230548 RVA: 0x00FBCECC File Offset: 0x00FBB0CC
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
			result.Add(this.GetRoundResultData(list, (float)delayInterval));
		}

		// Token: 0x06038495 RID: 230549 RVA: 0x00FBCF2C File Offset: 0x00FBB12C
		private List<ScratchTicketRoundResult> GetRewardNineGridCellResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
			this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardNineGridCellRoundResult(rewardCenterResult, index, true);
			return rewardCenterResult;
		}

		// Token: 0x06038496 RID: 230550 RVA: 0x00FBCF70 File Offset: 0x00FBB170
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
			result.Add(this.GetRoundResultData(list, (float)delayInterval));
		}

		// Token: 0x06038497 RID: 230551 RVA: 0x00FBCFF8 File Offset: 0x00FBB1F8
		private List<ScratchTicketRoundResult> GetRewardRowResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
			this.PushRewardRowRoundResult(rewardCenterResult, index, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardRowRoundResult(rewardCenterResult, index, true);
			return rewardCenterResult;
		}

		// Token: 0x06038498 RID: 230552 RVA: 0x00FBD03C File Offset: 0x00FBB23C
		private void PushRewardRowRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
		{
			List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
			this.PushRewardResultAlongDirection(result, list, checkLock);
		}

		// Token: 0x06038499 RID: 230553 RVA: 0x00FBD06C File Offset: 0x00FBB26C
		private List<ScratchTicketRoundResult> GetRewardColumnResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
			this.PushRewardColumnRoundResult(rewardCenterResult, index, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardColumnRoundResult(rewardCenterResult, index, true);
			return rewardCenterResult;
		}

		// Token: 0x0603849A RID: 230554 RVA: 0x00FBD0B0 File Offset: 0x00FBB2B0
		private void PushRewardColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
		{
			List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
			this.PushRewardResultAlongDirection(result, list, checkLock);
		}

		// Token: 0x0603849B RID: 230555 RVA: 0x00FBD0E0 File Offset: 0x00FBB2E0
		private List<ScratchTicketRoundResult> GetRewardRowAndColumnResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 700f, "HamsterB");
			this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardRowAndColumnRoundResult(rewardCenterResult, index, true);
			return rewardCenterResult;
		}

		// Token: 0x0603849C RID: 230556 RVA: 0x00FBD124 File Offset: 0x00FBB324
		private void PushRewardRowAndColumnRoundResult(List<ScratchTicketRoundResult> result, int index, bool checkLock)
		{
			List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Top, checkLock);
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Bottom, checkLock);
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Left, checkLock);
			this.PushDirectionFirstReward(list, index, EScratchDirectionType.Right, checkLock);
			this.PushRewardResultAlongDirection(result, list, checkLock);
		}

		// Token: 0x0603849D RID: 230557 RVA: 0x00FBD168 File Offset: 0x00FBB368
		private List<ScratchTicketRoundResult> GetRemainingRewardResult(int index)
		{
			List<ScratchTicketRoundResult> rewardCenterResult = this.GetRewardCenterResult(index, 1000f, "HamsterC");
			this.PushRewardRemainingRoundResult(rewardCenterResult, false);
			this.PushSequenceRoundResult(rewardCenterResult, 250, "InnerGlow");
			this.PushRewardRemainingRoundResult(rewardCenterResult, true);
			return rewardCenterResult;
		}

		// Token: 0x0603849E RID: 230558 RVA: 0x00FBD1AC File Offset: 0x00FBB3AC
		private void PushRewardRemainingRoundResult(List<ScratchTicketRoundResult> result, bool checkLock)
		{
			List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>();
			foreach (SolarSchoolScratchTicketCellData solarSchoolScratchTicketCellData in this.CellDataList)
			{
				if (!checkLock || solarSchoolScratchTicketCellData.IsLock())
				{
					list.Add(this.GetRewardResultData(solarSchoolScratchTicketCellData.Index, EScratchDirectionType.Center, true));
				}
			}
			if (list.Count > 0)
			{
				int delayInterval = this.GetDelayInterval(false, !checkLock);
				result.Add(this.GetRoundResultData(list, (float)delayInterval));
			}
		}

		// Token: 0x0603849F RID: 230559 RVA: 0x00FBD244 File Offset: 0x00FBB444
		private void PushRewardResultAlongDirection(List<ScratchTicketRoundResult> result, List<ScratchTicketRewardResult> rewardResultList, bool checkLock)
		{
			List<ScratchTicketRewardResult> list = new List<ScratchTicketRewardResult>(rewardResultList);
			int delayInterval = this.GetDelayInterval(false, !checkLock);
			while (list.Count > 0)
			{
				result.Add(this.GetRoundResultData(list, (float)delayInterval));
				List<ScratchTicketRewardResult> list2 = new List<ScratchTicketRewardResult>();
				foreach (ScratchTicketRewardResult scratchTicketRewardResult in list)
				{
					this.PushDirectionFirstReward(list2, scratchTicketRewardResult.Index, scratchTicketRewardResult.DirectionType, checkLock);
				}
				list = list2;
			}
		}

		// Token: 0x060384A0 RID: 230560 RVA: 0x00FBD2D8 File Offset: 0x00FBB4D8
		private void PushDirectionFirstReward(List<ScratchTicketRewardResult> roundResult, int index, EScratchDirectionType direction, bool checkLock)
		{
			int num = index;
			for (;;)
			{
				num = this.GetCellDataIndexByDirection(num, direction);
				SolarSchoolScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(num);
				if (cellDataByIndex != null && (!checkLock || cellDataByIndex.IsLock()))
				{
					break;
				}
				if (num < 0)
				{
					return;
				}
			}
			roundResult.Add(this.GetRewardResultData(num, direction, checkLock));
		}

		// Token: 0x060384A1 RID: 230561 RVA: 0x00FBD31C File Offset: 0x00FBB51C
		private void PushRewardResult(List<ScratchTicketRewardResult> roundResult, int index, EScratchDirectionType direction, bool checkLock)
		{
			int cellDataIndexByDirection = this.GetCellDataIndexByDirection(index, direction);
			SolarSchoolScratchTicketCellData cellDataByIndex = this.GetCellDataByIndex(cellDataIndexByDirection);
			if (cellDataByIndex == null)
			{
				return;
			}
			if (checkLock && !cellDataByIndex.IsLock())
			{
				return;
			}
			roundResult.Add(this.GetRewardResultData(cellDataIndexByDirection, direction, checkLock));
		}

		// Token: 0x060384A2 RID: 230562 RVA: 0x00FBD35B File Offset: 0x00FBB55B
		private void PushSequenceRoundResult(List<ScratchTicketRoundResult> result, int delayInterval, string sequenceName)
		{
			result.Add(this.GetRoundResultData(new List<ScratchTicketRewardResult>(), (float)delayInterval, sequenceName));
		}

		// Token: 0x060384A3 RID: 230563 RVA: 0x00FBD371 File Offset: 0x00FBB571
		private bool CheckIndexValid(int index)
		{
			return index >= 0 && index < this.Capacity;
		}

		// Token: 0x060384A4 RID: 230564 RVA: 0x00FBD382 File Offset: 0x00FBB582
		private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, float delayInterval)
		{
			return this.GetRoundResultData(rewardList, delayInterval, "Empty");
		}

		// Token: 0x060384A5 RID: 230565 RVA: 0x00FBD391 File Offset: 0x00FBB591
		private ScratchTicketRoundResult GetRoundResultData(List<ScratchTicketRewardResult> rewardList, float delayInterval, string sequenceName)
		{
			return new ScratchTicketRoundResult
			{
				RewardList = rewardList,
				DelayInterval = delayInterval,
				SequenceName = sequenceName
			};
		}

		// Token: 0x060384A6 RID: 230566 RVA: 0x00FBD3B0 File Offset: 0x00FBB5B0
		private ScratchTicketRewardResult GetRewardResultData(int index, EScratchDirectionType directionType, bool checkLock)
		{
			ECellSequenceType sequenceType = ECellSequenceType.Warning;
			if (checkLock)
			{
				SolarSchoolScratchTicketDefine.DirectionToSequenceMap.TryGetValue(directionType, out sequenceType);
			}
			return new ScratchTicketRewardResult
			{
				Index = index,
				DirectionType = directionType,
				SequenceType = sequenceType
			};
		}

		// Token: 0x060384A7 RID: 230567 RVA: 0x00FBD3EA File Offset: 0x00FBB5EA
		private int GetDelayInterval(bool isFirst, bool isWarning)
		{
			if (isFirst)
			{
				return 700;
			}
			if (isWarning)
			{
				return 50;
			}
			return 100;
		}

		// Token: 0x060384A8 RID: 230568 RVA: 0x00FBD400 File Offset: 0x00FBB600
		private int GetCellDataIndex(int row, int column)
		{
			int boardSize = this.BoardSize;
			if (column < 0 || column >= boardSize || row < 0 || row >= boardSize)
			{
				return -1;
			}
			return row * boardSize + column;
		}

		// Token: 0x060384A9 RID: 230569 RVA: 0x00FBD42C File Offset: 0x00FBB62C
		private int GetCellDataIndexByDirection(int index, EScratchDirectionType directionType)
		{
			int boardSize = this.BoardSize;
			int num = index % boardSize;
			int num2 = index / boardSize;
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

		// Token: 0x060384AA RID: 230570 RVA: 0x00FBD4BC File Offset: 0x00FBB6BC
		public List<SolarSchoolScratchTicketRewardShow> GetRemainRewardList()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (SolarSchoolScratchTicketCellData solarSchoolScratchTicketCellData in this.CellDataList)
			{
				if (solarSchoolScratchTicketCellData.IsLock())
				{
					SolarSchoolReward? placedReward = solarSchoolScratchTicketCellData.PlacedReward;
					if (placedReward != null)
					{
						int id = placedReward.Value.Id;
						int num;
						dictionary.TryGetValue(id, out num);
						dictionary[id] = num + placedReward.Value.Value;
					}
				}
			}
			List<SolarSchoolScratchTicketRewardShow> list = new List<SolarSchoolScratchTicketRewardShow>();
			foreach (int num2 in this.RewardOrder)
			{
				int num3;
				if (dictionary.TryGetValue(num2, out num3) && num3 > 0)
				{
					SolarSchoolScratchTicketRewardShow solarSchoolScratchTicketRewardShow = new SolarSchoolScratchTicketRewardShow();
					SolarSchoolScratchTicketRewardShow solarSchoolScratchTicketRewardShow2 = solarSchoolScratchTicketRewardShow;
					SolarSchoolScratchTicketRewardShow solarSchoolScratchTicketRewardShow3 = solarSchoolScratchTicketRewardShow;
					SolarSchoolScratchTicketRewardShow solarSchoolScratchTicketRewardShow4 = solarSchoolScratchTicketRewardShow;
					ValueTuple<ESolarSchoolRewardType, int, string> rewardData = this.GetRewardData(num2);
					solarSchoolScratchTicketRewardShow2.RewardType = rewardData.Item1;
					solarSchoolScratchTicketRewardShow3.TargetId = rewardData.Item2;
					solarSchoolScratchTicketRewardShow4.IconPath = rewardData.Item3;
					solarSchoolScratchTicketRewardShow.Count = num3;
					list.Add(solarSchoolScratchTicketRewardShow);
				}
			}
			return list;
		}

		// Token: 0x060384AB RID: 230571 RVA: 0x00FBD608 File Offset: 0x00FBB808
		[return: TupleElementNames(new string[]
		{
			"RewardType",
			"TargetId",
			"IconPath"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<ESolarSchoolRewardType, int, string> GetRewardData(int RewardId)
		{
			SolarSchoolReward? reward = SolarSchoolConfig.Instance.GetReward(RewardId);
			if (reward == null)
			{
				return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.Item, -1, "");
			}
			ESolarSchoolRewardType rewardType = (ESolarSchoolRewardType)reward.Value.RewardType;
			if (rewardType != ESolarSchoolRewardType.PlayerAttr)
			{
				if (rewardType != ESolarSchoolRewardType.Item)
				{
					return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.Item, -1, "");
				}
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(reward.Value.TargetId);
				if (item == null)
				{
					return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.Item, -1, "");
				}
				return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.Item, reward.Value.TargetId, item.Value.Icon);
			}
			else
			{
				SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(reward.Value.TargetId);
				if (attr == null)
				{
					return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.PlayerAttr, -1, "");
				}
				return new ValueTuple<ESolarSchoolRewardType, int, string>(ESolarSchoolRewardType.PlayerAttr, reward.Value.TargetId, attr.Value.YellowIconSmall);
			}
		}

		// Token: 0x0401DA3B RID: 121403
		public SolarSchoolScratchTicketCo? Config;

		// Token: 0x0401DA3C RID: 121404
		private readonly SolarSchoolScratchTicketRewardPool RewardPool = new SolarSchoolScratchTicketRewardPool();

		// Token: 0x0401DA3D RID: 121405
		private readonly List<SolarSchoolScratchTicketCellData> CellDataList = new List<SolarSchoolScratchTicketCellData>();

		// Token: 0x0401DA3E RID: 121406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ScratchTicketRoundResult> DiagonalResultList;

		// Token: 0x0401DA3F RID: 121407
		private readonly List<int> RewardOrder = new List<int>();

		// Token: 0x0401DA40 RID: 121408
		private int RevealedCount;

		// Token: 0x0401DA41 RID: 121409
		private int Capacity;

		// Token: 0x0401DA42 RID: 121410
		private int BoardSize;

		// Token: 0x0401DA43 RID: 121411
		private int Counter;

		// Token: 0x0401DA44 RID: 121412
		private int RevCounter;
	}
}
