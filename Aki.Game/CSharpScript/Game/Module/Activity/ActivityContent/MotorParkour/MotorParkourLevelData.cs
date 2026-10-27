using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063E7 RID: 25575
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourLevelData
	{
		// Token: 0x06040539 RID: 263481 RVA: 0x00F8F350 File Offset: 0x00F8D550
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

		// Token: 0x0604053A RID: 263482 RVA: 0x00F8F48C File Offset: 0x00F8D68C
		public void UpdateTaskStatus(IReadOnlyList<MotorParkourRewardState> taskStatusList)
		{
			for (int i = 0; i < taskStatusList.Count; i++)
			{
				this.TaskList[i].Status = TaskStateResolver.TaskState[(ActivityTaskState)taskStatusList[i]];
			}
		}

		// Token: 0x1700940C RID: 37900
		// (get) Token: 0x0604053B RID: 263483 RVA: 0x00F8F4CC File Offset: 0x00F8D6CC
		// (set) Token: 0x0604053C RID: 263484 RVA: 0x00F8F4D4 File Offset: 0x00F8D6D4
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

		// Token: 0x0604053D RID: 263485 RVA: 0x00F8F4E0 File Offset: 0x00F8D6E0
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x1700940D RID: 37901
		// (get) Token: 0x0604053E RID: 263486 RVA: 0x00F8F50C File Offset: 0x00F8D70C
		public bool IsUnLock
		{
			get
			{
				return (this.PreMotorParkourLevelData == null || this.PreMotorParkourLevelData.IsPass) && this.IsReachUnlockTime();
			}
		}

		// Token: 0x1700940E RID: 37902
		// (get) Token: 0x0604053F RID: 263487 RVA: 0x00F8F52B File Offset: 0x00F8D72B
		// (set) Token: 0x06040540 RID: 263488 RVA: 0x00F8F534 File Offset: 0x00F8D734
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

		// Token: 0x1700940F RID: 37903
		// (get) Token: 0x06040541 RID: 263489 RVA: 0x00F8F581 File Offset: 0x00F8D781
		public bool IsPass
		{
			get
			{
				return this.BestRecordTime != 0;
			}
		}

		// Token: 0x17009410 RID: 37904
		// (get) Token: 0x06040542 RID: 263490 RVA: 0x00F8F58C File Offset: 0x00F8D78C
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

		// Token: 0x17009411 RID: 37905
		// (get) Token: 0x06040543 RID: 263491 RVA: 0x00F8F5E8 File Offset: 0x00F8D7E8
		public int AllTaskNum
		{
			get
			{
				return this.TaskList.Count;
			}
		}

		// Token: 0x17009412 RID: 37906
		// (get) Token: 0x06040544 RID: 263492 RVA: 0x00F8F5F8 File Offset: 0x00F8D7F8
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

		// Token: 0x17009413 RID: 37907
		// (get) Token: 0x06040545 RID: 263493 RVA: 0x00F8F654 File Offset: 0x00F8D854
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

		// Token: 0x17009414 RID: 37908
		// (get) Token: 0x06040546 RID: 263494 RVA: 0x00F8F6BC File Offset: 0x00F8D8BC
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

		// Token: 0x06040547 RID: 263495 RVA: 0x00F8F700 File Offset: 0x00F8D900
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

		// Token: 0x06040548 RID: 263496 RVA: 0x00F8F770 File Offset: 0x00F8D970
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

		// Token: 0x17009415 RID: 37909
		// (get) Token: 0x06040549 RID: 263497 RVA: 0x00F8F848 File Offset: 0x00F8DA48
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

		// Token: 0x0604054A RID: 263498 RVA: 0x00F8F888 File Offset: 0x00F8DA88
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

		// Token: 0x17009416 RID: 37910
		// (get) Token: 0x0604054B RID: 263499 RVA: 0x00F8F8DC File Offset: 0x00F8DADC
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

		// Token: 0x0604054C RID: 263500 RVA: 0x00F8F938 File Offset: 0x00F8DB38
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

		// Token: 0x17009417 RID: 37911
		// (get) Token: 0x0604054D RID: 263501 RVA: 0x00F8F97C File Offset: 0x00F8DB7C
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17009418 RID: 37912
		// (get) Token: 0x0604054E RID: 263502 RVA: 0x00F8F989 File Offset: 0x00F8DB89
		public string SmallBgTexture
		{
			get
			{
				return this.Config.SmallBgTexture;
			}
		}

		// Token: 0x17009419 RID: 37913
		// (get) Token: 0x0604054F RID: 263503 RVA: 0x00F8F996 File Offset: 0x00F8DB96
		public string SelectedSmallBgTexture
		{
			get
			{
				return this.Config.SelectedSmallBgTexture;
			}
		}

		// Token: 0x1700941A RID: 37914
		// (get) Token: 0x06040550 RID: 263504 RVA: 0x00F8F9A3 File Offset: 0x00F8DBA3
		public string RaceTrackTexture
		{
			get
			{
				return this.Config.RaceTrackTexture;
			}
		}

		// Token: 0x1700941B RID: 37915
		// (get) Token: 0x06040551 RID: 263505 RVA: 0x00F8F9B0 File Offset: 0x00F8DBB0
		public string MapTexture
		{
			get
			{
				return this.Config.MapTexture;
			}
		}

		// Token: 0x1700941C RID: 37916
		// (get) Token: 0x06040552 RID: 263506 RVA: 0x00F8F9BD File Offset: 0x00F8DBBD
		public string LevelName
		{
			get
			{
				return this.Config.LevelName;
			}
		}

		// Token: 0x1700941D RID: 37917
		// (get) Token: 0x06040553 RID: 263507 RVA: 0x00F8F9CA File Offset: 0x00F8DBCA
		public string RomanNum
		{
			get
			{
				return this.Config.RomanNum;
			}
		}

		// Token: 0x1700941E RID: 37918
		// (get) Token: 0x06040554 RID: 263508 RVA: 0x00F8F9D7 File Offset: 0x00F8DBD7
		[Nullable(0)]
		public Span<float> UiOffset
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetUiOffsetBytes();
			}
		}

		// Token: 0x1700941F RID: 37919
		// (get) Token: 0x06040555 RID: 263509 RVA: 0x00F8F9E4 File Offset: 0x00F8DBE4
		[Nullable(0)]
		public Span<float> CenterOffset
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetCenterOffsetBytes();
			}
		}

		// Token: 0x17009420 RID: 37920
		// (get) Token: 0x06040556 RID: 263510 RVA: 0x00F8F9F1 File Offset: 0x00F8DBF1
		public float MapScale
		{
			get
			{
				return this.Config.MapScale;
			}
		}

		// Token: 0x17009421 RID: 37921
		// (get) Token: 0x06040557 RID: 263511 RVA: 0x00F8F9FE File Offset: 0x00F8DBFE
		public int SplineId
		{
			get
			{
				return this.Config.SplineId;
			}
		}

		// Token: 0x17009422 RID: 37922
		// (get) Token: 0x06040558 RID: 263512 RVA: 0x00F8FA0B File Offset: 0x00F8DC0B
		public int SplineStartIndex
		{
			get
			{
				return this.Config.SplineStartIndex;
			}
		}

		// Token: 0x17009423 RID: 37923
		// (get) Token: 0x06040559 RID: 263513 RVA: 0x00F8FA18 File Offset: 0x00F8DC18
		public int SplineEndIndex
		{
			get
			{
				return this.Config.SplineEndIndex;
			}
		}

		// Token: 0x17009424 RID: 37924
		// (get) Token: 0x0604055A RID: 263514 RVA: 0x00F8FA25 File Offset: 0x00F8DC25
		public int RouteTextureRotation
		{
			get
			{
				return this.Config.RouteTextureRotation;
			}
		}

		// Token: 0x17009425 RID: 37925
		// (get) Token: 0x0604055B RID: 263515 RVA: 0x00F8FA32 File Offset: 0x00F8DC32
		public string RouteName
		{
			get
			{
				return this.Config.RouteName;
			}
		}

		// Token: 0x17009426 RID: 37926
		// (get) Token: 0x0604055C RID: 263516 RVA: 0x00F8FA3F File Offset: 0x00F8DC3F
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x0402176A RID: 137066
		private MotorParkour Config;

		// Token: 0x0402176B RID: 137067
		[Nullable(2)]
		public MotorParkourLevelData PreMotorParkourLevelData;

		// Token: 0x0402176C RID: 137068
		public readonly List<MotorParkourTaskData> TaskList = new List<MotorParkourTaskData>();

		// Token: 0x0402176D RID: 137069
		public List<MotorParkourRankData> RecordList = new List<MotorParkourRankData>();

		// Token: 0x0402176E RID: 137070
		[Nullable(2)]
		private MotorParkourRankData MyRankData;

		// Token: 0x0402176F RID: 137071
		private int BestRecordTimeInternal;

		// Token: 0x04021770 RID: 137072
		private long UnlockTimeInterval;
	}
}
