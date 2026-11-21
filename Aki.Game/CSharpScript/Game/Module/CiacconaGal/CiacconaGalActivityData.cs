using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAC RID: 19372
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalActivityData
	{
		// Token: 0x060305C5 RID: 198085 RVA: 0x00D7B41C File Offset: 0x00D7961C
		public CiacconaGalActivityData(CiacconaActivityConfig config)
		{
			this.Config = config;
		}

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x060305C6 RID: 198086 RVA: 0x00D7B42B File Offset: 0x00D7962B
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x060305C7 RID: 198087 RVA: 0x00D7B438 File Offset: 0x00D79638
		public int[] SlotIds
		{
			get
			{
				return this.Config.Slots();
			}
		}

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x060305C8 RID: 198088 RVA: 0x00D7B445 File Offset: 0x00D79645
		public int InspirationCount
		{
			get
			{
				return this.Inspiration;
			}
		}

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x060305C9 RID: 198089 RVA: 0x00D7B44D File Offset: 0x00D7964D
		public int MaxInspirationCount
		{
			get
			{
				return this.Config.InspirationMaxValue;
			}
		}

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x060305CA RID: 198090 RVA: 0x00D7B45A File Offset: 0x00D7965A
		public long RefreshTime
		{
			get
			{
				return this.RefreshTimestamp.GetValueOrDefault();
			}
		}

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x060305CB RID: 198091 RVA: 0x00D7B467 File Offset: 0x00D79667
		public bool State2Unlock
		{
			get
			{
				return this.State2Unlocked;
			}
		}

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x060305CC RID: 198092 RVA: 0x00D7B46F File Offset: 0x00D7966F
		public bool State3Unlock
		{
			get
			{
				return this.State3Unlocked;
			}
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x060305CD RID: 198093 RVA: 0x00D7B477 File Offset: 0x00D79677
		public long EndTime
		{
			get
			{
				return this.EndTimeInternal;
			}
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x060305CE RID: 198094 RVA: 0x00D7B47F File Offset: 0x00D7967F
		public int RecommendQuestId
		{
			get
			{
				return this.Config.RecommendQuestId;
			}
		}

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x060305CF RID: 198095 RVA: 0x00D7B48C File Offset: 0x00D7968C
		public string RecommendQuestTipsTextId
		{
			get
			{
				return this.Config.RecommendQuestTips;
			}
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x060305D0 RID: 198096 RVA: 0x00D7B499 File Offset: 0x00D79699
		public long RewardEndTime
		{
			get
			{
				return this.RewardEndTimeInternal;
			}
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x060305D1 RID: 198097 RVA: 0x00D7B4A1 File Offset: 0x00D796A1
		public long RewardStartTime
		{
			get
			{
				return this.RewardStartTimeInternal;
			}
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x060305D2 RID: 198098 RVA: 0x00D7B4A9 File Offset: 0x00D796A9
		public bool IsInRewardTime
		{
			get
			{
				return TimeUtil.Instance.IsInTimeSpan((double)this.RewardStartTime, (double)this.RewardEndTime);
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x060305D3 RID: 198099 RVA: 0x00D7B4C4 File Offset: 0x00D796C4
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

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x060305D4 RID: 198100 RVA: 0x00D7B4FF File Offset: 0x00D796FF
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

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x060305D5 RID: 198101 RVA: 0x00D7B518 File Offset: 0x00D79718
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

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x060305D6 RID: 198102 RVA: 0x00D7B5B0 File Offset: 0x00D797B0
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

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x060305D7 RID: 198103 RVA: 0x00D7B618 File Offset: 0x00D79818
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

		// Token: 0x060305D8 RID: 198104 RVA: 0x00D7B674 File Offset: 0x00D79874
		public void UpdateByServerData(CiacconaActivityPbData data)
		{
			this.ServerData = data;
			this.UpdateInspirationData(data.InspirationData);
			this.State2Unlocked = data.State1Unlock;
			this.State3Unlocked = data.State2Unlock;
			this.RewardStartTimeInternal = data.LimitedStartTime;
			this.RewardEndTimeInternal = data.LimitedEndTime;
		}

		// Token: 0x060305D9 RID: 198105 RVA: 0x00D7B6C4 File Offset: 0x00D798C4
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

		// Token: 0x060305DA RID: 198106 RVA: 0x00D7B6E7 File Offset: 0x00D798E7
		public void UpdateState(CiacconaActivityStateUnlockUpdateNotify data)
		{
			this.State2Unlocked = data.State1Unlock;
			this.State3Unlocked = data.State2Unlock;
		}

		// Token: 0x060305DB RID: 198107 RVA: 0x00D7B701 File Offset: 0x00D79901
		public void UpdateEndTime(long endTime)
		{
			this.EndTimeInternal = endTime;
		}

		// Token: 0x04019A10 RID: 104976
		private int Inspiration;

		// Token: 0x04019A11 RID: 104977
		private long? RefreshTimestamp;

		// Token: 0x04019A12 RID: 104978
		private bool State2Unlocked;

		// Token: 0x04019A13 RID: 104979
		private bool State3Unlocked;

		// Token: 0x04019A14 RID: 104980
		private long EndTimeInternal;

		// Token: 0x04019A15 RID: 104981
		private long RewardEndTimeInternal;

		// Token: 0x04019A16 RID: 104982
		private long RewardStartTimeInternal;

		// Token: 0x04019A17 RID: 104983
		[Nullable(2)]
		private CiacconaActivityPbData ServerData;

		// Token: 0x04019A18 RID: 104984
		private CiacconaActivityConfig Config;
	}
}
