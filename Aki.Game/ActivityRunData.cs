using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x020014D6 RID: 5334
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunData : ActivityExData
{
	// Token: 0x0600979F RID: 38815 RVA: 0x0020C19D File Offset: 0x0020A39D
	public ActivityRunData(int activityId) : base(activityId)
	{
	}

	// Token: 0x17000D15 RID: 3349
	// (get) Token: 0x060097A0 RID: 38816 RVA: 0x0020C1B1 File Offset: 0x0020A3B1
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x060097A1 RID: 38817 RVA: 0x0020C1B9 File Offset: 0x0020A3B9
	public int GetMaxScore()
	{
		return this.MaxScore;
	}

	// Token: 0x060097A2 RID: 38818 RVA: 0x0020C1C1 File Offset: 0x0020A3C1
	public int GetMiniTime()
	{
		return this.MinTime;
	}

	// Token: 0x060097A3 RID: 38819 RVA: 0x0020C1C9 File Offset: 0x0020A3C9
	public bool GetRedPoint()
	{
		return this.GetIsShow() && (this.GetChallengeNewLocalRedPoint() || this.GetScoreRedPoint());
	}

	// Token: 0x060097A4 RID: 38820 RVA: 0x0020C1EC File Offset: 0x0020A3EC
	public List<int> GetScoreArray()
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			foreach (ValueTuple<int, int> valueTuple in this.ScoreRewardMap.Values)
			{
				list.Add(valueTuple.Item1);
			}
		}
		return list;
	}

	// Token: 0x060097A5 RID: 38821 RVA: 0x0020C258 File Offset: 0x0020A458
	public int GetScoreIndexScore(int scoreIndex)
	{
		ValueTuple<int, int> valueTuple;
		if (this.ScoreRewardMap != null && this.ScoreRewardMap.TryGetValue(scoreIndex, out valueTuple))
		{
			return valueTuple.Item1;
		}
		return 0;
	}

	// Token: 0x060097A6 RID: 38822 RVA: 0x0020C288 File Offset: 0x0020A488
	public List<TItem> GetScoreIndexPreviewItem(int index)
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			list = new List<int>(this.ScoreRewardMap.Keys);
		}
		int count = list.Count;
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			if (list[i] == index)
			{
				num = this.ScoreRewardMap[list[i]].Item2;
				break;
			}
		}
		List<TItem> list2 = new List<TItem>();
		if (num > 0)
		{
			DropPackage? dropPackage;
			Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(num) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					int num2;
					int num3;
					keyValuePair.Deconstruct(out num2, out num3);
					int itemId = num2;
					int count2 = num3;
					TItem item = new TItem(new InventoryDefine.GetItemData(itemId, 0), count2);
					list2.Add(item);
				}
			}
		}
		return list2;
	}

	// Token: 0x060097A7 RID: 38823 RVA: 0x0020C39C File Offset: 0x0020A59C
	public int GetScoreIndex(int score)
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			list = new List<int>(this.ScoreRewardMap.Keys);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			ValueTuple<int, int> valueTuple;
			if (this.ScoreRewardMap != null && this.ScoreRewardMap.TryGetValue(i, out valueTuple) && score == valueTuple.Item1)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x060097A8 RID: 38824 RVA: 0x0020C400 File Offset: 0x0020A600
	public EActivityRunStateEnum GetScoreIndexCannotGetReward(int index)
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			list = new List<int>(this.ScoreRewardMap.Keys);
		}
		long num = 0L;
		ValueTuple<int, int> valueTuple;
		if (this.ScoreRewardMap != null && this.ScoreRewardMap.TryGetValue(index, out valueTuple))
		{
			num = (long)valueTuple.Item1;
		}
		if ((long)this.MaxScore < num)
		{
			return EActivityRunStateEnum.UnFinished;
		}
		if (!this.TakenScoresIndex.Contains(list[index]))
		{
			return EActivityRunStateEnum.CanGetReward;
		}
		return EActivityRunStateEnum.HaveGetReward;
	}

	// Token: 0x060097A9 RID: 38825 RVA: 0x0020C474 File Offset: 0x0020A674
	private bool GetScoreRedPoint()
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			list = new List<int>(this.ScoreRewardMap.Keys);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.GetScoreIndexCannotGetReward(i) == EActivityRunStateEnum.CanGetReward)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060097AA RID: 38826 RVA: 0x0020C4C0 File Offset: 0x0020A6C0
	public bool GetIfRewardAllFinished()
	{
		List<int> list = new List<int>();
		if (this.ScoreRewardMap != null)
		{
			list = new List<int>(this.ScoreRewardMap.Keys);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.GetScoreIndexCannotGetReward(i) != EActivityRunStateEnum.HaveGetReward)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060097AB RID: 38827 RVA: 0x0020C50C File Offset: 0x0020A70C
	public string GetTitle()
	{
		return ActivityRunConfig.Instance.GetActivityRunTitle(this.IdInternal);
	}

	// Token: 0x060097AC RID: 38828 RVA: 0x0020C51E File Offset: 0x0020A71E
	public long GetMarkId()
	{
		return (long)ActivityRunConfig.Instance.GetActivityRunMarkId(this.IdInternal);
	}

	// Token: 0x060097AD RID: 38829 RVA: 0x0020C531 File Offset: 0x0020A731
	public string GetBackgroundTexturePath()
	{
		return ActivityRunConfig.Instance.GetActivityRunTexture(this.IdInternal);
	}

	// Token: 0x060097AE RID: 38830 RVA: 0x0020C543 File Offset: 0x0020A743
	public void SetChallengeLocalRedPointState(bool state)
	{
		ActivityModel.Instance.SaveActivityData(this.ActivityId, this.IdInternal, 0, 0, (state > false) ? 1 : 0);
		EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
		base.RefreshActivityRedPoint();
	}

	// Token: 0x060097AF RID: 38831 RVA: 0x0020C57D File Offset: 0x0020A77D
	public bool GetChallengeNewLocalRedPoint()
	{
		return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 1, this.IdInternal, 0, 0) == 1;
	}

	// Token: 0x060097B0 RID: 38832 RVA: 0x0020C59B File Offset: 0x0020A79B
	public bool GetIsShow()
	{
		return this.IsOpen && this.CheckIfInShowTime();
	}

	// Token: 0x060097B1 RID: 38833 RVA: 0x0020C5B0 File Offset: 0x0020A7B0
	public void SetIsOpen(bool state)
	{
		this.IsOpen = state;
	}

	// Token: 0x17000D16 RID: 3350
	// (get) Token: 0x060097B2 RID: 38834 RVA: 0x0020C5B9 File Offset: 0x0020A7B9
	public long BeginOpenTime
	{
		get
		{
			return this.BeginOpenTimeInternal;
		}
	}

	// Token: 0x17000D17 RID: 3351
	// (get) Token: 0x060097B3 RID: 38835 RVA: 0x0020C5C1 File Offset: 0x0020A7C1
	public long EndOpenTime
	{
		get
		{
			return this.EndOpenTimeInternal;
		}
	}

	// Token: 0x060097B4 RID: 38836 RVA: 0x0020C5C9 File Offset: 0x0020A7C9
	public void OnGetScoreReward(int scoreIndex)
	{
		if (!this.TakenScoresIndex.Contains(scoreIndex))
		{
			this.TakenScoresIndex.Add(scoreIndex);
			EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
			base.RefreshActivityRedPoint();
		}
	}

	// Token: 0x060097B5 RID: 38837 RVA: 0x0020C604 File Offset: 0x0020A804
	public bool CheckIfInShowTime()
	{
		if (this.BeginOpenTime == 0L && this.EndOpenTime == 0L)
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)this.BeginOpenTime && serverTime <= (double)this.EndOpenTime;
	}

	// Token: 0x060097B6 RID: 38838 RVA: 0x0020C648 File Offset: 0x0020A848
	public void OnChallengeEnd(ParkourChallengeEndNotify data)
	{
		this.CurrentScore = data.Score;
		this.CurrentTime = data.Duration;
		if (this.CurrentScore > this.MaxScore)
		{
			this.MaxScore = this.CurrentScore;
		}
		if (this.CurrentTime < this.MinTime || this.MinTime == 0)
		{
			this.MinTime = this.CurrentTime;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
		base.RefreshActivityRedPoint();
	}

	// Token: 0x060097B7 RID: 38839 RVA: 0x0020C6C8 File Offset: 0x0020A8C8
	public void Phrase(object data)
	{
		Aki.Protocol.ParkourChallenge parkourChallenge = data as Aki.Protocol.ParkourChallenge;
		if (parkourChallenge != null)
		{
			this.IdInternal = parkourChallenge.ChallengeId;
			this.TakenScoresIndex = new List<int>();
			if (parkourChallenge.TakenScoreIndex != null)
			{
				foreach (int item in parkourChallenge.TakenScoreIndex)
				{
					this.TakenScoresIndex.Add(item);
				}
			}
			this.MaxScore = parkourChallenge.MaxScore;
			this.MinTime = parkourChallenge.MinDuration;
		}
		else
		{
			ParkourActivityChallenge parkourActivityChallenge = data as ParkourActivityChallenge;
			if (parkourActivityChallenge != null)
			{
				this.IdInternal = parkourActivityChallenge.ChallengeId;
				this.BeginOpenTimeInternal = parkourActivityChallenge.BeginTime;
				this.EndOpenTimeInternal = parkourActivityChallenge.EndTime;
			}
		}
		if (this.ScoreRewardMap == null)
		{
			this.ScoreRewardMap = ActivityRunConfig.Instance.GetActivityRunScoreMap(this.IdInternal);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
		base.RefreshActivityRedPoint();
	}

	// Token: 0x040042BB RID: 17083
	private int IdInternal;

	// Token: 0x040042BC RID: 17084
	private List<int> TakenScoresIndex = new List<int>();

	// Token: 0x040042BD RID: 17085
	private int MaxScore;

	// Token: 0x040042BE RID: 17086
	private int MinTime;

	// Token: 0x040042BF RID: 17087
	private int CurrentScore;

	// Token: 0x040042C0 RID: 17088
	private int CurrentTime;

	// Token: 0x040042C1 RID: 17089
	private bool IsOpen;

	// Token: 0x040042C2 RID: 17090
	private long BeginOpenTimeInternal;

	// Token: 0x040042C3 RID: 17091
	private long EndOpenTimeInternal;

	// Token: 0x040042C4 RID: 17092
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private Dictionary<int, ValueTuple<int, int>> ScoreRewardMap;
}
