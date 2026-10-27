using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCC RID: 23500
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalActivityData
	{
		// Token: 0x0603B679 RID: 243321 RVA: 0x00E2B128 File Offset: 0x00E29328
		public CiacconaGalActivityData(CiacconaActivityConfig config)
		{
			this.Config = config;
		}

		// Token: 0x17008D03 RID: 36099
		// (get) Token: 0x0603B67A RID: 243322 RVA: 0x00E2B137 File Offset: 0x00E29337
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D04 RID: 36100
		// (get) Token: 0x0603B67B RID: 243323 RVA: 0x00E2B144 File Offset: 0x00E29344
		public int[] SlotIds
		{
			get
			{
				return this.Config.Slots();
			}
		}

		// Token: 0x17008D05 RID: 36101
		// (get) Token: 0x0603B67C RID: 243324 RVA: 0x00E2B151 File Offset: 0x00E29351
		public int InspirationCount
		{
			get
			{
				return this.Inspiration;
			}
		}

		// Token: 0x17008D06 RID: 36102
		// (get) Token: 0x0603B67D RID: 243325 RVA: 0x00E2B159 File Offset: 0x00E29359
		public int MaxInspirationCount
		{
			get
			{
				return this.Config.InspirationMaxValue;
			}
		}

		// Token: 0x17008D07 RID: 36103
		// (get) Token: 0x0603B67E RID: 243326 RVA: 0x00E2B166 File Offset: 0x00E29366
		public long RefreshTime
		{
			get
			{
				return this.RefreshTimestamp.GetValueOrDefault();
			}
		}

		// Token: 0x17008D08 RID: 36104
		// (get) Token: 0x0603B67F RID: 243327 RVA: 0x00E2B173 File Offset: 0x00E29373
		public bool State2Unlock
		{
			get
			{
				return this.State2Unlocked;
			}
		}

		// Token: 0x17008D09 RID: 36105
		// (get) Token: 0x0603B680 RID: 243328 RVA: 0x00E2B17B File Offset: 0x00E2937B
		public bool State3Unlock
		{
			get
			{
				return this.State3Unlocked;
			}
		}

		// Token: 0x17008D0A RID: 36106
		// (get) Token: 0x0603B681 RID: 243329 RVA: 0x00E2B183 File Offset: 0x00E29383
		public long EndTime
		{
			get
			{
				return this.EndTimeInternal;
			}
		}

		// Token: 0x17008D0B RID: 36107
		// (get) Token: 0x0603B682 RID: 243330 RVA: 0x00E2B18B File Offset: 0x00E2938B
		public int RecommendQuestId
		{
			get
			{
				return this.Config.RecommendQuestId;
			}
		}

		// Token: 0x17008D0C RID: 36108
		// (get) Token: 0x0603B683 RID: 243331 RVA: 0x00E2B198 File Offset: 0x00E29398
		public string RecommendQuestTipsTextId
		{
			get
			{
				return this.Config.RecommendQuestTips;
			}
		}

		// Token: 0x17008D0D RID: 36109
		// (get) Token: 0x0603B684 RID: 243332 RVA: 0x00E2B1A5 File Offset: 0x00E293A5
		public long RewardEndTime
		{
			get
			{
				return this.RewardEndTimeInternal;
			}
		}

		// Token: 0x17008D0E RID: 36110
		// (get) Token: 0x0603B685 RID: 243333 RVA: 0x00E2B1AD File Offset: 0x00E293AD
		public long RewardStartTime
		{
			get
			{
				return this.RewardStartTimeInternal;
			}
		}

		// Token: 0x17008D0F RID: 36111
		// (get) Token: 0x0603B686 RID: 243334 RVA: 0x00E2B1B5 File Offset: 0x00E293B5
		public bool IsInRewardTime
		{
			get
			{
				return TimeUtil.Instance.IsInTimeSpan((double)this.RewardStartTime, (double)this.RewardEndTime);
			}
		}

		// Token: 0x17008D10 RID: 36112
		// (get) Token: 0x0603B687 RID: 243335 RVA: 0x00E2B1D0 File Offset: 0x00E293D0
		[Nullable(2)]
		public string RewardRemainTimeStr
		{
			[NullableContext(2)]
			get
			{
				double remainTime = (double)this.RewardEndTime - TimeUtil.Instance.GetServerTimeStamp() * TimeUtil.Instance.Millisecond;
				return TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime).CountDownText;
			}
		}

		// Token: 0x17008D11 RID: 36113
		// (get) Token: 0x0603B688 RID: 243336 RVA: 0x00E2B20B File Offset: 0x00E2940B
		public ECiacconaGalActivityState State
		{
			get
			{
				if (this.State3Unlock)
				{
					return ECiacconaGalActivityState.SubEndingFinish;
				}
				if (this.State2Unlock)
				{
					return ECiacconaGalActivityState.TaskFinish;
				}
				return ECiacconaGalActivityState.Init;
			}
		}

		// Token: 0x17008D12 RID: 36114
		// (get) Token: 0x0603B689 RID: 243337 RVA: 0x00E2B224 File Offset: 0x00E29424
		public int FinishedSubEndingCount
		{
			get
			{
				int num = 0;
				if (this.ServerData == null)
				{
					return num;
				}
				foreach (CiacconaChapterPbData ciacconaChapterPbData in this.ServerData.ChapterDatas)
				{
					using (IEnumerator<CiacconaChapterResultPbData> enumerator2 = ciacconaChapterPbData.ResultDatas.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.Finish)
							{
								num++;
							}
						}
					}
				}
				return num;
			}
		}

		// Token: 0x17008D13 RID: 36115
		// (get) Token: 0x0603B68A RID: 243338 RVA: 0x00E2B2BC File Offset: 0x00E294BC
		public int TotalSubEndingCount
		{
			get
			{
				int num = 1;
				if (this.ServerData == null)
				{
					return num;
				}
				foreach (CiacconaChapterPbData ciacconaChapterPbData in this.ServerData.ChapterDatas)
				{
					num += ciacconaChapterPbData.ResultDatas.Count;
				}
				return num;
			}
		}

		// Token: 0x17008D14 RID: 36116
		// (get) Token: 0x0603B68B RID: 243339 RVA: 0x00E2B324 File Offset: 0x00E29524
		[Nullable(2)]
		public string RemainTimeToNextRefreshStr
		{
			[NullableContext(2)]
			get
			{
				double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
				double num = (double)this.RefreshTime - serverTimeStamp * TimeUtil.Instance.Millisecond;
				if (num < TimeUtil.Instance.Hour)
				{
					return TimeUtil.Instance.GetRemainTimeDataFormat4(num).CountDownText;
				}
				return TimeUtil.Instance.GetRemainTimeDataFormat3(num).CountDownText;
			}
		}

		// Token: 0x0603B68C RID: 243340 RVA: 0x00E2B380 File Offset: 0x00E29580
		public void UpdateByServerData(CiacconaActivityPbData data)
		{
			this.ServerData = data;
			this.UpdateInspirationData(data.InspirationData);
			this.State2Unlocked = data.State1Unlock;
			this.State3Unlocked = data.State2Unlock;
			this.RewardStartTimeInternal = data.LimitedStartTime;
			this.RewardEndTimeInternal = data.LimitedEndTime;
		}

		// Token: 0x0603B68D RID: 243341 RVA: 0x00E2B3D0 File Offset: 0x00E295D0
		[NullableContext(2)]
		public void UpdateInspirationData(CiacconaInspirationPbData data)
		{
			if (data == null)
			{
				return;
			}
			this.Inspiration = data.Inspiration;
			this.RefreshTimestamp = new long?(data.RefreshTime);
		}

		// Token: 0x0603B68E RID: 243342 RVA: 0x00E2B3F3 File Offset: 0x00E295F3
		public void UpdateState(CiacconaActivityStateUnlockUpdateNotify data)
		{
			this.State2Unlocked = data.State1Unlock;
			this.State3Unlocked = data.State2Unlock;
		}

		// Token: 0x0603B68F RID: 243343 RVA: 0x00E2B40D File Offset: 0x00E2960D
		public void UpdateEndTime(long endTime)
		{
			this.EndTimeInternal = endTime;
		}

		// Token: 0x0401EF5F RID: 126815
		private int Inspiration;

		// Token: 0x0401EF60 RID: 126816
		private long? RefreshTimestamp;

		// Token: 0x0401EF61 RID: 126817
		private bool State2Unlocked;

		// Token: 0x0401EF62 RID: 126818
		private bool State3Unlocked;

		// Token: 0x0401EF63 RID: 126819
		private long EndTimeInternal;

		// Token: 0x0401EF64 RID: 126820
		private long RewardEndTimeInternal;

		// Token: 0x0401EF65 RID: 126821
		private long RewardStartTimeInternal;

		// Token: 0x0401EF66 RID: 126822
		[Nullable(2)]
		private CiacconaActivityPbData ServerData;

		// Token: 0x0401EF67 RID: 126823
		private CiacconaActivityConfig Config;
	}
}
