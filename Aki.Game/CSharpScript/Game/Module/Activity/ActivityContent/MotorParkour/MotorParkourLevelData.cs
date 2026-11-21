using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005365 RID: 21349
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourLevelData
	{
		// Token: 0x060351FA RID: 217594 RVA: 0x00ED62E8 File Offset: 0x00ED44E8
		public MotorParkourLevelData(MotorParkour config)
		{
			this.Config = config;
			foreach (int id in config.RewardIdsIter())
			{
				MotorParkourTaskData motorParkourTaskData = new MotorParkourTaskData(id);
				motorParkourTaskData.LevelId = config.Id;
				MotorParkourRecord? motorParkourRecordById = MotorParkourConfig.Instance.GetMotorParkourRecordById(motorParkourTaskData.RecordId);
				if (motorParkourRecordById != null)
				{
					MotorParkourNPC? motorParkourNpcById = MotorParkourConfig.Instance.GetMotorParkourNpcById(motorParkourRecordById.Value.NPCId);
					if (motorParkourNpcById != null)
					{
						MotorParkourRankData item = new MotorParkourRankData(motorParkourNpcById.Value.Name, (float)motorParkourRecordById.Value.Record, Array.ConvertAll<int, float>(motorParkourRecordById.Value.LapRecord(), (int x) => (float)x), false);
						this.RecordList.Add(item);
						this.TaskList.Add(motorParkourTaskData);
					}
				}
			}
		}

		// Token: 0x060351FB RID: 217595 RVA: 0x00ED6424 File Offset: 0x00ED4624
		public void UpdateTaskStatus(IReadOnlyList<MotorParkourRewardState> taskStatusList)
		{
			for (int i = 0; i < taskStatusList.Count; i++)
			{
				this.TaskList[i].Status = TaskStateResolver.TaskState[(ActivityTaskState)taskStatusList[i]];
			}
		}

		// Token: 0x1700676E RID: 26478
		// (get) Token: 0x060351FC RID: 217596 RVA: 0x00ED6464 File Offset: 0x00ED4664
		// (set) Token: 0x060351FD RID: 217597 RVA: 0x00ED646C File Offset: 0x00ED466C
		public long UnlockTime
		{
			get
			{
				return this.UnlockTimeInterval;
			}
			set
			{
				this.UnlockTimeInterval = value;
			}
		}

		// Token: 0x060351FE RID: 217598 RVA: 0x00ED6478 File Offset: 0x00ED4678
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x1700676F RID: 26479
		// (get) Token: 0x060351FF RID: 217599 RVA: 0x00ED64A4 File Offset: 0x00ED46A4
		public bool IsUnLock
		{
			get
			{
				return (this.PreMotorParkourLevelData == null || this.PreMotorParkourLevelData.IsPass) && this.IsReachUnlockTime();
			}
		}

		// Token: 0x17006770 RID: 26480
		// (get) Token: 0x06035200 RID: 217600 RVA: 0x00ED64C3 File Offset: 0x00ED46C3
		// (set) Token: 0x06035201 RID: 217601 RVA: 0x00ED64CC File Offset: 0x00ED46CC
		public int BestRecordTime
		{
			get
			{
				return this.BestRecordTimeInternal;
			}
			set
			{
				this.BestRecordTimeInternal = value;
				if (value == 0)
				{
					return;
				}
				if (this.MyRankData == null)
				{
					string playerName = FunctionModel.Instance.GetPlayerName();
					this.MyRankData = new MotorParkourRankData(playerName, (float)value, Array.Empty<float>(), true);
					return;
				}
				this.MyRankData.Time = (float)value;
			}
		}

		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x06035202 RID: 217602 RVA: 0x00ED6519 File Offset: 0x00ED4719
		public bool IsPass
		{
			get
			{
				return this.BestRecordTime != 0;
			}
		}

		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x06035203 RID: 217603 RVA: 0x00ED6524 File Offset: 0x00ED4724
		public bool IsFinished
		{
			get
			{
				bool result = true;
				using (List<MotorParkourTaskData>.Enumerator enumerator = this.TaskList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsReceived)
						{
							result = false;
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x06035204 RID: 217604 RVA: 0x00ED6580 File Offset: 0x00ED4780
		public int AllTaskNum
		{
			get
			{
				return this.TaskList.Count;
			}
		}

		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x06035205 RID: 217605 RVA: 0x00ED6590 File Offset: 0x00ED4790
		public int FinishedTaskNum
		{
			get
			{
				int num = 0;
				using (List<MotorParkourTaskData>.Enumerator enumerator = this.TaskList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsReceived)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x06035206 RID: 217606 RVA: 0x00ED65EC File Offset: 0x00ED47EC
		public List<MotorParkourRankData> HistoryRankList
		{
			get
			{
				List<MotorParkourRankData> list = new List<MotorParkourRankData>(this.RecordList);
				if (this.MyRankData != null)
				{
					list.Add(this.MyRankData);
				}
				list.Sort(delegate(MotorParkourRankData a, MotorParkourRankData b)
				{
					if (a.Time - b.Time >= 0f)
					{
						return 1;
					}
					return -1;
				});
				return list.GetRange(0, Math.Min(3, list.Count));
			}
		}

		// Token: 0x17006776 RID: 26486
		// (get) Token: 0x06035207 RID: 217607 RVA: 0x00ED6654 File Offset: 0x00ED4854
		public int BestRank
		{
			get
			{
				int num = this.HistoryRankList.FindIndex((MotorParkourRankData record) => record.IsOwn);
				if (num != -1)
				{
					return num + 1;
				}
				return 4;
			}
		}

		// Token: 0x06035208 RID: 217608 RVA: 0x00ED6698 File Offset: 0x00ED4898
		public List<MotorParkourRankData> GetNewRankList(int newTime)
		{
			MotorParkourRankData item = new MotorParkourRankData(FunctionModel.Instance.GetPlayerName(), (float)newTime, Array.Empty<float>(), true);
			List<MotorParkourRankData> list = new List<MotorParkourRankData>(this.RecordList);
			list.Add(item);
			list.Sort(delegate(MotorParkourRankData a, MotorParkourRankData b)
			{
				if (a.Time - b.Time >= 0f)
				{
					return 1;
				}
				return -1;
			});
			return list.GetRange(0, Math.Min(3, list.Count));
		}

		// Token: 0x06035209 RID: 217609 RVA: 0x00ED6708 File Offset: 0x00ED4908
		public List<MotorParkourRankData> GetLapRankList(int lap, float playerTime)
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			MotorParkourRankData myRank = new MotorParkourRankData(playerName, playerTime, Array.Empty<float>(), true);
			myRank.LapTime[lap - 1] = playerTime;
			List<MotorParkourRankData> list = new List<MotorParkourRankData>(this.RecordList);
			list.Add(myRank);
			list.Sort(delegate(MotorParkourRankData a, MotorParkourRankData b)
			{
				if (a.LapTime[lap - 1] - b.LapTime[lap - 1] >= 0f)
				{
					return 1;
				}
				return -1;
			});
			int num = list.FindIndex((MotorParkourRankData data) => data == myRank);
			for (int i = 0; i < list.Count; i++)
			{
				bool isNeedShowGap = Math.Abs(i - num) == 1;
				list[i].UpdateShowTimeString(lap, playerTime, isNeedShowGap);
			}
			return list.GetRange(0, Math.Min(3, list.Count));
		}

		// Token: 0x17006777 RID: 26487
		// (get) Token: 0x0603520A RID: 217610 RVA: 0x00ED67E0 File Offset: 0x00ED49E0
		public bool HasLevelRedDot
		{
			get
			{
				if (!this.IsUnLock || this.IsFinished)
				{
					return false;
				}
				HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorParkourLevelClicked, null);
				return player == null || !player.Contains(this.Id);
			}
		}

		// Token: 0x0603520B RID: 217611 RVA: 0x00ED6820 File Offset: 0x00ED4A20
		public void ReadLevelRedDot()
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorParkourLevelClicked, null);
			if (player != null)
			{
				player.Add(this.Id);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorParkourLevelClicked, player);
				return;
			}
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorParkourLevelClicked, new HashSet<int>
			{
				this.Id
			});
		}

		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x0603520C RID: 217612 RVA: 0x00ED6874 File Offset: 0x00ED4A74
		public bool HasRewardRedDot
		{
			get
			{
				bool result = false;
				using (List<MotorParkourTaskData>.Enumerator enumerator = this.TaskList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsFinished)
						{
							result = true;
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x0603520D RID: 217613 RVA: 0x00ED68D0 File Offset: 0x00ED4AD0
		public List<int> GetCanReceiveRewardIndex()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < this.TaskList.Count; i++)
			{
				if (this.TaskList[i].IsFinished)
				{
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x0603520E RID: 217614 RVA: 0x00ED6914 File Offset: 0x00ED4B14
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x0603520F RID: 217615 RVA: 0x00ED6921 File Offset: 0x00ED4B21
		public string SmallBgTexture
		{
			get
			{
				return this.Config.SmallBgTexture;
			}
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x06035210 RID: 217616 RVA: 0x00ED692E File Offset: 0x00ED4B2E
		public string SelectedSmallBgTexture
		{
			get
			{
				return this.Config.SelectedSmallBgTexture;
			}
		}

		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x06035211 RID: 217617 RVA: 0x00ED693B File Offset: 0x00ED4B3B
		public string RaceTrackTexture
		{
			get
			{
				return this.Config.RaceTrackTexture;
			}
		}

		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x06035212 RID: 217618 RVA: 0x00ED6948 File Offset: 0x00ED4B48
		public string MapTexture
		{
			get
			{
				return this.Config.MapTexture;
			}
		}

		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x06035213 RID: 217619 RVA: 0x00ED6955 File Offset: 0x00ED4B55
		public string LevelName
		{
			get
			{
				return this.Config.LevelName;
			}
		}

		// Token: 0x1700677F RID: 26495
		// (get) Token: 0x06035214 RID: 217620 RVA: 0x00ED6962 File Offset: 0x00ED4B62
		public string RomanNum
		{
			get
			{
				return this.Config.RomanNum;
			}
		}

		// Token: 0x17006780 RID: 26496
		// (get) Token: 0x06035215 RID: 217621 RVA: 0x00ED696F File Offset: 0x00ED4B6F
		[Nullable(0)]
		public Span<float> UiOffset
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetUiOffsetBytes();
			}
		}

		// Token: 0x17006781 RID: 26497
		// (get) Token: 0x06035216 RID: 217622 RVA: 0x00ED697C File Offset: 0x00ED4B7C
		[Nullable(0)]
		public Span<float> CenterOffset
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetCenterOffsetBytes();
			}
		}

		// Token: 0x17006782 RID: 26498
		// (get) Token: 0x06035217 RID: 217623 RVA: 0x00ED6989 File Offset: 0x00ED4B89
		public float MapScale
		{
			get
			{
				return this.Config.MapScale;
			}
		}

		// Token: 0x17006783 RID: 26499
		// (get) Token: 0x06035218 RID: 217624 RVA: 0x00ED6996 File Offset: 0x00ED4B96
		public int SplineId
		{
			get
			{
				return this.Config.SplineId;
			}
		}

		// Token: 0x17006784 RID: 26500
		// (get) Token: 0x06035219 RID: 217625 RVA: 0x00ED69A3 File Offset: 0x00ED4BA3
		public int SplineStartIndex
		{
			get
			{
				return this.Config.SplineStartIndex;
			}
		}

		// Token: 0x17006785 RID: 26501
		// (get) Token: 0x0603521A RID: 217626 RVA: 0x00ED69B0 File Offset: 0x00ED4BB0
		public int SplineEndIndex
		{
			get
			{
				return this.Config.SplineEndIndex;
			}
		}

		// Token: 0x17006786 RID: 26502
		// (get) Token: 0x0603521B RID: 217627 RVA: 0x00ED69BD File Offset: 0x00ED4BBD
		public int RouteTextureRotation
		{
			get
			{
				return this.Config.RouteTextureRotation;
			}
		}

		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x0603521C RID: 217628 RVA: 0x00ED69CA File Offset: 0x00ED4BCA
		public string RouteName
		{
			get
			{
				return this.Config.RouteName;
			}
		}

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x0603521D RID: 217629 RVA: 0x00ED69D7 File Offset: 0x00ED4BD7
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x0401C099 RID: 114841
		private MotorParkour Config;

		// Token: 0x0401C09A RID: 114842
		[Nullable(2)]
		public MotorParkourLevelData PreMotorParkourLevelData;

		// Token: 0x0401C09B RID: 114843
		public readonly List<MotorParkourTaskData> TaskList = new List<MotorParkourTaskData>();

		// Token: 0x0401C09C RID: 114844
		public List<MotorParkourRankData> RecordList = new List<MotorParkourRankData>();

		// Token: 0x0401C09D RID: 114845
		[Nullable(2)]
		private MotorParkourRankData MyRankData;

		// Token: 0x0401C09E RID: 114846
		private int BestRecordTimeInternal;

		// Token: 0x0401C09F RID: 114847
		private long UnlockTimeInterval;
	}
}
