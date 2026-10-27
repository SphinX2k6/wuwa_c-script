using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02006391 RID: 25489
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorLevelData
	{
		// Token: 0x060401B6 RID: 262582 RVA: 0x00F8413D File Offset: 0x00F8233D
		public MultiMotorLevelData(int levelId)
		{
			this.LevelIdInternal = levelId;
		}

		// Token: 0x060401B7 RID: 262583 RVA: 0x00F84157 File Offset: 0x00F82357
		public void RefreshByLevelInfo(OnlineMotorLevelInfo levelInfo)
		{
			this.BestRecordTime = levelInfo.TimeCost;
			this.BestRanking = levelInfo.Ranking;
		}

		// Token: 0x1700935A RID: 37722
		// (get) Token: 0x060401B8 RID: 262584 RVA: 0x00F84171 File Offset: 0x00F82371
		public int LevelId
		{
			get
			{
				return this.LevelIdInternal;
			}
		}

		// Token: 0x1700935B RID: 37723
		// (get) Token: 0x060401B9 RID: 262585 RVA: 0x00F84179 File Offset: 0x00F82379
		public bool IsUnLock
		{
			get
			{
				return (this.PreMultiMotorParkourLevelData == null || this.PreMultiMotorParkourLevelData.IsPass) && this.IsReachUnlockTime();
			}
		}

		// Token: 0x060401BA RID: 262586 RVA: 0x00F84198 File Offset: 0x00F82398
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTime == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x1700935C RID: 37724
		// (get) Token: 0x060401BB RID: 262587 RVA: 0x00F841C4 File Offset: 0x00F823C4
		public OnlineMotorLevel? Config
		{
			get
			{
				return MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.LevelId);
			}
		}

		// Token: 0x1700935D RID: 37725
		// (get) Token: 0x060401BC RID: 262588 RVA: 0x00F841D6 File Offset: 0x00F823D6
		public bool IsPass
		{
			get
			{
				return this.BestRecordTime != 0;
			}
		}

		// Token: 0x1700935E RID: 37726
		// (get) Token: 0x060401BD RID: 262589 RVA: 0x00F841E1 File Offset: 0x00F823E1
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

		// Token: 0x1700935F RID: 37727
		// (get) Token: 0x060401BE RID: 262590 RVA: 0x00F8421C File Offset: 0x00F8241C
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

		// Token: 0x17009360 RID: 37728
		// (get) Token: 0x060401BF RID: 262591 RVA: 0x00F84278 File Offset: 0x00F82478
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

		// Token: 0x060401C0 RID: 262592 RVA: 0x00F842B4 File Offset: 0x00F824B4
		public void ReadLevelRedDot()
		{
			int activityId = MultiMotorModel.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 1, this.LevelId, 0, 1);
		}

		// Token: 0x04021659 RID: 136793
		private const int MULTI_MOTOR_LEVEL_CLICKED_KEY = 1;

		// Token: 0x0402165A RID: 136794
		private readonly int LevelIdInternal;

		// Token: 0x0402165B RID: 136795
		[Nullable(2)]
		public MultiMotorLevelData PreMultiMotorParkourLevelData;

		// Token: 0x0402165C RID: 136796
		public readonly List<MultiMotorTaskData> TaskList = new List<MultiMotorTaskData>();

		// Token: 0x0402165D RID: 136797
		public long UnlockTime;

		// Token: 0x0402165E RID: 136798
		public int BestRecordTime;

		// Token: 0x0402165F RID: 136799
		public int BestRanking;
	}
}
