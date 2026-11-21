using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054E7 RID: 21735
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayChallengeData : ActivityExData
	{
		// Token: 0x06035DB6 RID: 220598 RVA: 0x00F0B833 File Offset: 0x00F09A33
		public ActivityFunPlayChallengeData(int id) : base(id)
		{
		}

		// Token: 0x06035DB7 RID: 220599 RVA: 0x00F0B850 File Offset: 0x00F09A50
		public void Phrase(FunPlayChallengeInfo data)
		{
			this.ChallengeId = data.ChallengeId;
			this.Config = ActivityFunPlayConfig.Instance.GetFunPlayActivityChallenge(this.ChallengeId);
			this.UnlockTime = data.UnlockTime / 1000L;
			this.RewardStatus = data.RewardStatus;
			this.SharpCommentList.Clear();
			if (data.SharpCommentIds != null)
			{
				foreach (int commentId in data.SharpCommentIds)
				{
					FunPlaySharpComment? funPlaySharpComment = ActivityFunPlayConfig.Instance.GetFunPlaySharpComment(commentId);
					if (funPlaySharpComment != null)
					{
						this.SharpCommentList.Add(funPlaySharpComment.Value);
					}
				}
			}
			this.SharpCommentList.Sort((FunPlaySharpComment a, FunPlaySharpComment b) => a.VarPriority - b.VarPriority);
			this.FinishTime = data.FinishTime;
			this.SaveUnlockState();
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityFunPlayRedDot, this.ChallengeId);
			base.RefreshActivityRedPoint();
		}

		// Token: 0x06035DB8 RID: 220600 RVA: 0x00F0B96C File Offset: 0x00F09B6C
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x06035DB9 RID: 220601 RVA: 0x00F0B978 File Offset: 0x00F09B78
		public string GetTitle()
		{
			if (this.Config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应的趣味活动挑战配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.ChallengeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			return this.Config.Value.Title;
		}

		// Token: 0x06035DBA RID: 220602 RVA: 0x00F0B9E0 File Offset: 0x00F09BE0
		public string GetDesc()
		{
			if (this.Config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应的趣味活动挑战配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.ChallengeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			return this.Config.Value.Desc;
		}

		// Token: 0x06035DBB RID: 220603 RVA: 0x00F0BA48 File Offset: 0x00F09C48
		public string GetTabTitle()
		{
			if (this.Config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应的趣味活动挑战配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.ChallengeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			return this.Config.Value.TabTitle;
		}

		// Token: 0x06035DBC RID: 220604 RVA: 0x00F0BAB0 File Offset: 0x00F09CB0
		public string GetBackgroundTexturePath()
		{
			if (this.Config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应的趣味活动挑战配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.ChallengeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			return this.Config.Value.BackGroundTexture;
		}

		// Token: 0x06035DBD RID: 220605 RVA: 0x00F0BB17 File Offset: 0x00F09D17
		public bool GetIsUnlock()
		{
			return TimeUtil.Instance.GetServerTime() >= (double)this.UnlockTime;
		}

		// Token: 0x06035DBE RID: 220606 RVA: 0x00F0BB30 File Offset: 0x00F09D30
		public string GetLeftTimeText()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			double remainTime = Math.Max((double)this.UnlockTime - serverTime, 1.0);
			return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? string.Empty;
		}

		// Token: 0x06035DBF RID: 220607 RVA: 0x00F0BB79 File Offset: 0x00F09D79
		public bool CheckRewardStatus(FunPlayChallengeRewardStatus status)
		{
			return this.RewardStatus == status;
		}

		// Token: 0x06035DC0 RID: 220608 RVA: 0x00F0BB84 File Offset: 0x00F09D84
		public List<FunPlaySharpComment> GetSharpComments()
		{
			return this.SharpCommentList;
		}

		// Token: 0x06035DC1 RID: 220609 RVA: 0x00F0BB8C File Offset: 0x00F09D8C
		public int GetChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x06035DC2 RID: 220610 RVA: 0x00F0BB94 File Offset: 0x00F09D94
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Month",
			"Day"
		})]
		public ValueTuple<int, int> GetFinishMonthAndDay()
		{
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(this.FinishTime).LocalDateTime;
			return new ValueTuple<int, int>(localDateTime.Month, localDateTime.Day);
		}

		// Token: 0x06035DC3 RID: 220611 RVA: 0x00F0BBC8 File Offset: 0x00F09DC8
		public long GetUnlockTime()
		{
			return this.UnlockTime;
		}

		// Token: 0x06035DC4 RID: 220612 RVA: 0x00F0BBD0 File Offset: 0x00F09DD0
		[NullableContext(2)]
		public List<TItem> GetPreviewReward()
		{
			if (this.Config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应的趣味活动挑战配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.ChallengeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (this.Config.Value.RewardId == 0)
			{
				return null;
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Config.Value.RewardId);
		}

		// Token: 0x06035DC5 RID: 220613 RVA: 0x00F0BC54 File Offset: 0x00F09E54
		public bool GetRedPoint()
		{
			return this.GetUnlockRedDot() || this.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward);
		}

		// Token: 0x06035DC6 RID: 220614 RVA: 0x00F0BC6C File Offset: 0x00F09E6C
		private bool GetUnlockRedDot()
		{
			return this.GetIsUnlock() && this.GetLockCache() == 1;
		}

		// Token: 0x06035DC7 RID: 220615 RVA: 0x00F0BC84 File Offset: 0x00F09E84
		private void SaveUnlockState()
		{
			bool isUnlock = this.GetIsUnlock();
			int lockCache = this.GetLockCache();
			if (!isUnlock)
			{
				if (lockCache == -1)
				{
					ActivityModel.Instance.SaveActivityData(this.ActivityId, this.ChallengeId, 10, 0, 1);
				}
				return;
			}
			if (lockCache == 1)
			{
				ActivityModel.Instance.SaveActivityData(this.ActivityId, 0, 200, 0, 0);
				base.RefreshActivityRedPoint();
			}
		}

		// Token: 0x06035DC8 RID: 220616 RVA: 0x00F0BCE1 File Offset: 0x00F09EE1
		private int GetLockCache()
		{
			return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, -1, this.ChallengeId, 10, 0);
		}

		// Token: 0x06035DC9 RID: 220617 RVA: 0x00F0BCFD File Offset: 0x00F09EFD
		public void RefreshUnlockRedDot()
		{
			if (this.GetIsUnlock())
			{
				ActivityModel.Instance.SaveActivityData(this.ActivityId, this.ChallengeId, 10, 0, 0);
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityFunPlayRedDot, this.ChallengeId);
				base.RefreshActivityRedPoint();
			}
		}

		// Token: 0x0401C7B6 RID: 116662
		private int ChallengeId;

		// Token: 0x0401C7B7 RID: 116663
		private long UnlockTime;

		// Token: 0x0401C7B8 RID: 116664
		private FunPlayChallengeRewardStatus RewardStatus;

		// Token: 0x0401C7B9 RID: 116665
		private FunPlayActivityChallenge? Config;

		// Token: 0x0401C7BA RID: 116666
		private readonly List<FunPlaySharpComment> SharpCommentList = new List<FunPlaySharpComment>();

		// Token: 0x0401C7BB RID: 116667
		private long FinishTime;

		// Token: 0x0401C7BC RID: 116668
		public int Index = -1;

		// Token: 0x0401C7BD RID: 116669
		private const int CLICKQUESTKEY = 200;

		// Token: 0x0401C7BE RID: 116670
		private const int LOCKKEY = 10;
	}
}
