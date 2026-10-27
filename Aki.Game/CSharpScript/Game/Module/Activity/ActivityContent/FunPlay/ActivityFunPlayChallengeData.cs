using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006569 RID: 25961
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayChallengeData : ActivityExData
	{
		// Token: 0x060410F1 RID: 266481 RVA: 0x00FC484F File Offset: 0x00FC2A4F
		public ActivityFunPlayChallengeData(int id) : base(id)
		{
		}

		// Token: 0x060410F2 RID: 266482 RVA: 0x00FC486C File Offset: 0x00FC2A6C
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

		// Token: 0x060410F3 RID: 266483 RVA: 0x00FC4988 File Offset: 0x00FC2B88
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x060410F4 RID: 266484 RVA: 0x00FC4994 File Offset: 0x00FC2B94
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

		// Token: 0x060410F5 RID: 266485 RVA: 0x00FC49FC File Offset: 0x00FC2BFC
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

		// Token: 0x060410F6 RID: 266486 RVA: 0x00FC4A64 File Offset: 0x00FC2C64
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

		// Token: 0x060410F7 RID: 266487 RVA: 0x00FC4ACC File Offset: 0x00FC2CCC
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

		// Token: 0x060410F8 RID: 266488 RVA: 0x00FC4B33 File Offset: 0x00FC2D33
		public bool GetIsUnlock()
		{
			return TimeUtil.Instance.GetServerTime() >= (double)this.UnlockTime;
		}

		// Token: 0x060410F9 RID: 266489 RVA: 0x00FC4B4C File Offset: 0x00FC2D4C
		public string GetLeftTimeText()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			double remainTime = Math.Max((double)this.UnlockTime - serverTime, 1.0);
			return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? string.Empty;
		}

		// Token: 0x060410FA RID: 266490 RVA: 0x00FC4B95 File Offset: 0x00FC2D95
		public bool CheckRewardStatus(FunPlayChallengeRewardStatus status)
		{
			return this.RewardStatus == status;
		}

		// Token: 0x060410FB RID: 266491 RVA: 0x00FC4BA0 File Offset: 0x00FC2DA0
		public List<FunPlaySharpComment> GetSharpComments()
		{
			return this.SharpCommentList;
		}

		// Token: 0x060410FC RID: 266492 RVA: 0x00FC4BA8 File Offset: 0x00FC2DA8
		public int GetChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x060410FD RID: 266493 RVA: 0x00FC4BB0 File Offset: 0x00FC2DB0
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

		// Token: 0x060410FE RID: 266494 RVA: 0x00FC4BE4 File Offset: 0x00FC2DE4
		public long GetUnlockTime()
		{
			return this.UnlockTime;
		}

		// Token: 0x060410FF RID: 266495 RVA: 0x00FC4BEC File Offset: 0x00FC2DEC
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

		// Token: 0x06041100 RID: 266496 RVA: 0x00FC4C70 File Offset: 0x00FC2E70
		public bool GetRedPoint()
		{
			return this.GetUnlockRedDot() || this.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward);
		}

		// Token: 0x06041101 RID: 266497 RVA: 0x00FC4C88 File Offset: 0x00FC2E88
		private bool GetUnlockRedDot()
		{
			return this.GetIsUnlock() && this.GetLockCache() == 1;
		}

		// Token: 0x06041102 RID: 266498 RVA: 0x00FC4CA0 File Offset: 0x00FC2EA0
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

		// Token: 0x06041103 RID: 266499 RVA: 0x00FC4CFD File Offset: 0x00FC2EFD
		private int GetLockCache()
		{
			return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, -1, this.ChallengeId, 10, 0);
		}

		// Token: 0x06041104 RID: 266500 RVA: 0x00FC4D19 File Offset: 0x00FC2F19
		public void RefreshUnlockRedDot()
		{
			if (this.GetIsUnlock())
			{
				ActivityModel.Instance.SaveActivityData(this.ActivityId, this.ChallengeId, 10, 0, 0);
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityFunPlayRedDot, this.ChallengeId);
				base.RefreshActivityRedPoint();
			}
		}

		// Token: 0x04021E85 RID: 138885
		private int ChallengeId;

		// Token: 0x04021E86 RID: 138886
		private long UnlockTime;

		// Token: 0x04021E87 RID: 138887
		private FunPlayChallengeRewardStatus RewardStatus;

		// Token: 0x04021E88 RID: 138888
		private FunPlayActivityChallenge? Config;

		// Token: 0x04021E89 RID: 138889
		private readonly List<FunPlaySharpComment> SharpCommentList = new List<FunPlaySharpComment>();

		// Token: 0x04021E8A RID: 138890
		private long FinishTime;

		// Token: 0x04021E8B RID: 138891
		public int Index = -1;

		// Token: 0x04021E8C RID: 138892
		private const int CLICKQUESTKEY = 200;

		// Token: 0x04021E8D RID: 138893
		private const int LOCKKEY = 10;
	}
}
