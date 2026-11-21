using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200098E RID: 2446
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunData : ActivityExData
{
	// Token: 0x06006B79 RID: 27513 RVA: 0x00215EDD File Offset: 0x002140DD
	public ActivityRunData(int activityId) : base(activityId)
	{
	}

	// Token: 0x17000D36 RID: 3382
	// (get) Token: 0x06006B7A RID: 27514 RVA: 0x00215EF1 File Offset: 0x002140F1
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x06006B7B RID: 27515 RVA: 0x00215EF9 File Offset: 0x002140F9
	public int GetMaxScore()
	{
		return this.MaxScore;
	}

	// Token: 0x06006B7C RID: 27516 RVA: 0x00215F01 File Offset: 0x00214101
	public int GetMiniTime()
	{
		return this.MinTime;
	}

	// Token: 0x06006B7D RID: 27517 RVA: 0x00215F09 File Offset: 0x00214109
	public bool GetRedPoint()
	{
		return this.GetIsShow() && (this.GetChallengeNewLocalRedPoint() || this.GetScoreRedPoint());
	}

	// Token: 0x06006B7E RID: 27518 RVA: 0x00215F2C File Offset: 0x0021412C
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

	// Token: 0x06006B7F RID: 27519 RVA: 0x00215F98 File Offset: 0x00214198
	public int GetScoreIndexScore(int scoreIndex)
	{
		ValueTuple<int, int> valueTuple;
		if (this.ScoreRewardMap != null && this.ScoreRewardMap.TryGetValue(scoreIndex, out valueTuple))
		{
			return valueTuple.Item1;
		}
		return 0;
	}

	// Token: 0x06006B80 RID: 27520 RVA: 0x00215FC8 File Offset: 0x002141C8
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

	// Token: 0x06006B81 RID: 27521 RVA: 0x002160DC File Offset: 0x002142DC
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

	// Token: 0x06006B82 RID: 27522 RVA: 0x00216140 File Offset: 0x00214340
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

	// Token: 0x06006B83 RID: 27523 RVA: 0x002161B4 File Offset: 0x002143B4
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

	// Token: 0x06006B84 RID: 27524 RVA: 0x00216200 File Offset: 0x00214400
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

	// Token: 0x06006B85 RID: 27525 RVA: 0x0021624C File Offset: 0x0021444C
	public string GetTitle()
	{
		return ActivityRunConfig.Instance.GetActivityRunTitle(this.IdInternal);
	}

	// Token: 0x06006B86 RID: 27526 RVA: 0x0021625E File Offset: 0x0021445E
	public long GetMarkId()
	{
		return (long)ActivityRunConfig.Instance.GetActivityRunMarkId(this.IdInternal);
	}

	// Token: 0x06006B87 RID: 27527 RVA: 0x00216271 File Offset: 0x00214471
	public string GetBackgroundTexturePath()
	{
		return ActivityRunConfig.Instance.GetActivityRunTexture(this.IdInternal);
	}

	// Token: 0x06006B88 RID: 27528 RVA: 0x00216283 File Offset: 0x00214483
	public void SetChallengeLocalRedPointState(bool state)
	{
		ActivityModel.Instance.SaveActivityData(this.ActivityId, this.IdInternal, 0, 0, (state > false) ? 1 : 0);
		EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
		base.RefreshActivityRedPoint();
	}

	// Token: 0x06006B89 RID: 27529 RVA: 0x002162BD File Offset: 0x002144BD
	public bool GetChallengeNewLocalRedPoint()
	{
		return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 1, this.IdInternal, 0, 0) == 1;
	}

	// Token: 0x06006B8A RID: 27530 RVA: 0x002162DB File Offset: 0x002144DB
	public bool GetIsShow()
	{
		return this.IsOpen && this.CheckIfInShowTime();
	}

	// Token: 0x06006B8B RID: 27531 RVA: 0x002162F0 File Offset: 0x002144F0
	public void SetIsOpen(bool state)
	{
		this.IsOpen = state;
	}

	// Token: 0x17000D37 RID: 3383
	// (get) Token: 0x06006B8C RID: 27532 RVA: 0x002162F9 File Offset: 0x002144F9
	public long BeginOpenTime
	{
		get
		{
			return this.BeginOpenTimeInternal;
		}
	}

	// Token: 0x17000D38 RID: 3384
	// (get) Token: 0x06006B8D RID: 27533 RVA: 0x00216301 File Offset: 0x00214501
	public long EndOpenTime
	{
		get
		{
			return this.EndOpenTimeInternal;
		}
	}

	// Token: 0x06006B8E RID: 27534 RVA: 0x00216309 File Offset: 0x00214509
	public void OnGetScoreReward(int scoreIndex)
	{
		if (!this.TakenScoresIndex.Contains(scoreIndex))
		{
			this.TakenScoresIndex.Add(scoreIndex);
			EventSystem.Instance.Emit<int>(EEventName.RefreshRunActivityRedDot, this.IdInternal);
			base.RefreshActivityRedPoint();
		}
	}

	// Token: 0x06006B8F RID: 27535 RVA: 0x00216344 File Offset: 0x00214544
	public bool CheckIfInShowTime()
	{
		if (this.BeginOpenTime == 0L && this.EndOpenTime == 0L)
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)this.BeginOpenTime && serverTime <= (double)this.EndOpenTime;
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x00216388 File Offset: 0x00214588
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

	// Token: 0x06006B91 RID: 27537 RVA: 0x00216408 File Offset: 0x00214608
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

	// Token: 0x04004360 RID: 17248
	private int IdInternal;

	// Token: 0x04004361 RID: 17249
	private List<int> TakenScoresIndex = new List<int>();

	// Token: 0x04004362 RID: 17250
	private int MaxScore;

	// Token: 0x04004363 RID: 17251
	private int MinTime;

	// Token: 0x04004364 RID: 17252
	private int CurrentScore;

	// Token: 0x04004365 RID: 17253
	private int CurrentTime;

	// Token: 0x04004366 RID: 17254
	private bool IsOpen;

	// Token: 0x04004367 RID: 17255
	private long BeginOpenTimeInternal;

	// Token: 0x04004368 RID: 17256
	private long EndOpenTimeInternal;

	// Token: 0x04004369 RID: 17257
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private Dictionary<int, ValueTuple<int, int>> ScoreRewardMap;
}
