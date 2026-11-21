using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200530F RID: 21263
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorLevelData
	{
		// Token: 0x06034E77 RID: 216695 RVA: 0x00ECB0B1 File Offset: 0x00EC92B1
		public MultiMotorLevelData(int levelId)
		{
			this.LevelIdInternal = levelId;
		}

		// Token: 0x06034E78 RID: 216696 RVA: 0x00ECB0CB File Offset: 0x00EC92CB
		public void RefreshByLevelInfo(OnlineMotorLevelInfo levelInfo)
		{
			this.BestRecordTime = levelInfo.TimeCost;
			this.BestRanking = levelInfo.Ranking;
		}

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x06034E79 RID: 216697 RVA: 0x00ECB0E5 File Offset: 0x00EC92E5
		public int LevelId
		{
			get
			{
				return this.LevelIdInternal;
			}
		}

		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x06034E7A RID: 216698 RVA: 0x00ECB0ED File Offset: 0x00EC92ED
		public bool IsUnLock
		{
			get
			{
				return (this.PreMultiMotorParkourLevelData == null || this.PreMultiMotorParkourLevelData.IsPass) && this.IsReachUnlockTime();
			}
		}

		// Token: 0x06034E7B RID: 216699 RVA: 0x00ECB10C File Offset: 0x00EC930C
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTime == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x06034E7C RID: 216700 RVA: 0x00ECB138 File Offset: 0x00EC9338
		public OnlineMotorLevel? Config
		{
			get
			{
				return MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.LevelId);
			}
		}

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x06034E7D RID: 216701 RVA: 0x00ECB14A File Offset: 0x00EC934A
		public bool IsPass
		{
			get
			{
				return this.BestRecordTime != 0;
			}
		}

		// Token: 0x170066C0 RID: 26304
		// (get) Token: 0x06034E7E RID: 216702 RVA: 0x00ECB155 File Offset: 0x00EC9355
		public bool IsFinish
		{
			get
			{
				if (this.TaskList.Count == 0)
				{
					return false;
				}
				return this.TaskList.TrueForAll((MultiMotorTaskData task) => task.IsFinished || task.IsReceived);
			}
		}

		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x06034E7F RID: 216703 RVA: 0x00ECB190 File Offset: 0x00EC9390
		public bool HasRewardRedDot
		{
			get
			{
				using (List<MultiMotorTaskData>.Enumerator enumerator = this.TaskList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsFinished)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x06034E80 RID: 216704 RVA: 0x00ECB1EC File Offset: 0x00EC93EC
		public bool HasLevelRedDot
		{
			get
			{
				if (!this.IsUnLock)
				{
					return false;
				}
				int activityId = MultiMotorModel.Instance.ActivityId;
				return ActivityModel.Instance.GetActivityCacheData(activityId, 0, 1, this.LevelId, 0) != 1;
			}
		}

		// Token: 0x06034E81 RID: 216705 RVA: 0x00ECB228 File Offset: 0x00EC9428
		public void ReadLevelRedDot()
		{
			int activityId = MultiMotorModel.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 1, this.LevelId, 0, 1);
		}

		// Token: 0x0401BF88 RID: 114568
		private const int MULTI_MOTOR_LEVEL_CLICKED_KEY = 1;

		// Token: 0x0401BF89 RID: 114569
		private readonly int LevelIdInternal;

		// Token: 0x0401BF8A RID: 114570
		[Nullable(2)]
		public MultiMotorLevelData PreMultiMotorParkourLevelData;

		// Token: 0x0401BF8B RID: 114571
		public readonly List<MultiMotorTaskData> TaskList = new List<MultiMotorTaskData>();

		// Token: 0x0401BF8C RID: 114572
		public long UnlockTime;

		// Token: 0x0401BF8D RID: 114573
		public int BestRecordTime;

		// Token: 0x0401BF8E RID: 114574
		public int BestRanking;
	}
}
