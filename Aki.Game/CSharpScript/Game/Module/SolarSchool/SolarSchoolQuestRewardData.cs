using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058DA RID: 22746
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestRewardData
	{
		// Token: 0x06038085 RID: 229509 RVA: 0x00FA9F2C File Offset: 0x00FA812C
		public SolarSchoolQuestRewardData(int questRewardId)
		{
			this.QuestRewardId = questRewardId;
			SolarSchoolQuestReward? questReward = SolarSchoolConfig.Instance.GetQuestReward(questRewardId);
			this.ConditionId = ((questReward != null) ? questReward.GetValueOrDefault().ConditionId : 0);
			this.IsLocalCondition = (questReward != null && questReward.GetValueOrDefault().LocalCondition);
		}

		// Token: 0x17006B76 RID: 27510
		// (get) Token: 0x06038086 RID: 229510 RVA: 0x00FA9F94 File Offset: 0x00FA8194
		public int QuestRewardId { get; }

		// Token: 0x17006B77 RID: 27511
		// (get) Token: 0x06038087 RID: 229511 RVA: 0x00FA9F9C File Offset: 0x00FA819C
		public int ConditionId { get; }

		// Token: 0x17006B78 RID: 27512
		// (get) Token: 0x06038088 RID: 229512 RVA: 0x00FA9FA4 File Offset: 0x00FA81A4
		public bool IsLocalCondition { get; }

		// Token: 0x17006B79 RID: 27513
		// (get) Token: 0x06038089 RID: 229513 RVA: 0x00FA9FAC File Offset: 0x00FA81AC
		// (set) Token: 0x0603808A RID: 229514 RVA: 0x00FA9FB4 File Offset: 0x00FA81B4
		public bool Rewarded { get; private set; }

		// Token: 0x0603808B RID: 229515 RVA: 0x00FA9FC0 File Offset: 0x00FA81C0
		public bool IsListening()
		{
			ActivityConditionBase activityConditionBase;
			return this.TryGetRunningCondition(out activityConditionBase);
		}

		// Token: 0x0603808C RID: 229516 RVA: 0x00FA9FD5 File Offset: 0x00FA81D5
		public bool TryStartListening(Action onReached)
		{
			if (this.Rewarded || this.IsListening())
			{
				return false;
			}
			if (this.IsConditionReached())
			{
				onReached();
				return false;
			}
			return this.RegisterConditionListener(onReached);
		}

		// Token: 0x0603808D RID: 229517 RVA: 0x00FAA000 File Offset: 0x00FA8200
		public void StopListening()
		{
			if (this.ConditionHandleId == 0L)
			{
				return;
			}
			long conditionHandleId = this.ConditionHandleId;
			try
			{
				this.SaveRunningProgress();
			}
			finally
			{
				ActivityConditionCenter.Instance.Unregister(conditionHandleId);
				this.ConditionHandleId = 0L;
			}
		}

		// Token: 0x0603808E RID: 229518 RVA: 0x00FAA04C File Offset: 0x00FA824C
		public int GetProgress(out int target)
		{
			if (this.Rewarded || this.IsConditionReached())
			{
				target = this.GetTarget();
				return target;
			}
			ActivityConditionBase condition;
			if (this.TryGetRunningCondition(out condition))
			{
				ValueTuple<int, int> valueTuple = this.ReadProgress(condition);
				target = valueTuple.Item2;
				return valueTuple.Item1;
			}
			target = this.GetTarget();
			if (!this.IsLocalCondition)
			{
				return 0;
			}
			return Math.Min(this.SavedProgress, target);
		}

		// Token: 0x0603808F RID: 229519 RVA: 0x00FAA0B4 File Offset: 0x00FA82B4
		public int GetSaveProgress()
		{
			if (!this.IsLocalCondition)
			{
				return 0;
			}
			this.SaveRunningProgress();
			return this.SavedProgress;
		}

		// Token: 0x06038090 RID: 229520 RVA: 0x00FAA0CC File Offset: 0x00FA82CC
		public void MarkRewarded()
		{
			this.Rewarded = true;
		}

		// Token: 0x06038091 RID: 229521 RVA: 0x00FAA0D5 File Offset: 0x00FA82D5
		public void Restore(bool rewarded, int progress)
		{
			this.Rewarded = rewarded;
			this.SavedProgress = progress;
		}

		// Token: 0x06038092 RID: 229522 RVA: 0x00FAA0E5 File Offset: 0x00FA82E5
		public void ResetProgress()
		{
			this.StopListening();
			this.Rewarded = false;
			this.SavedProgress = 0;
		}

		// Token: 0x06038093 RID: 229523 RVA: 0x00FAA0FB File Offset: 0x00FA82FB
		private bool IsConditionReached()
		{
			return this.ConditionId == 0 || ActivityConditionCenter.Instance.CheckCondition(this.ConditionId, this.IsLocalCondition ? new Func<ActivityConditionBase, bool>(this.TryRestoreLocalProgress) : null);
		}

		// Token: 0x06038094 RID: 229524 RVA: 0x00FAA130 File Offset: 0x00FA8330
		private bool RegisterConditionListener(Action onReached)
		{
			long num = this.IsLocalCondition ? ActivityConditionCenter.Instance.RegisterCondition(this.ConditionId, delegate
			{
				this.OnConditionReached(onReached);
			}, new Func<ActivityConditionBase, bool>(this.TryRestoreLocalProgress)) : ActivityConditionCenter.Instance.RegisterCondition(this.ConditionId, delegate
			{
				this.OnConditionReached(onReached);
			}, null);
			if (num == 0L)
			{
				return false;
			}
			this.ConditionHandleId = num;
			ActivityConditionBase condition;
			if (ActivityConditionCenter.Instance.TryGetCondition(num, out condition))
			{
				this.CachedTarget = new int?(ActivityConditionCenter.Instance.GetConditionTarget(condition));
			}
			return true;
		}

		// Token: 0x06038095 RID: 229525 RVA: 0x00FAA1D3 File Offset: 0x00FA83D3
		private void OnConditionReached(Action onReached)
		{
			this.ConditionHandleId = 0L;
			onReached();
		}

		// Token: 0x06038096 RID: 229526 RVA: 0x00FAA1E3 File Offset: 0x00FA83E3
		private bool TryGetRunningCondition(out ActivityConditionBase condition)
		{
			if (this.ConditionHandleId != 0L && ActivityConditionCenter.Instance.TryGetCondition(this.ConditionHandleId, out condition))
			{
				return true;
			}
			this.ConditionHandleId = 0L;
			condition = null;
			return false;
		}

		// Token: 0x06038097 RID: 229527 RVA: 0x00FAA210 File Offset: 0x00FA8410
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Current",
			"Target"
		})]
		private ValueTuple<int, int> ReadProgress([Nullable(1)] ActivityConditionBase condition)
		{
			int conditionTarget = ActivityConditionCenter.Instance.GetConditionTarget(condition);
			this.CachedTarget = new int?(conditionTarget);
			return new ValueTuple<int, int>(Math.Min(ActivityConditionCenter.Instance.GetConditionCurrent(condition), conditionTarget), conditionTarget);
		}

		// Token: 0x06038098 RID: 229528 RVA: 0x00FAA24C File Offset: 0x00FA844C
		private unsafe bool TryRestoreLocalProgress(ActivityConditionBase condition)
		{
			ISolarSchoolProgressCondition solarSchoolProgressCondition = condition as ISolarSchoolProgressCondition;
			if (solarSchoolProgressCondition != null)
			{
				solarSchoolProgressCondition.RestoreProgress(this.SavedProgress);
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.BB;
			string message = "[SolarSchool] 任务奖励局部条件未实现进度接口";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questRewardId", this.QuestRewardId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionId", this.ConditionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionType", condition.GetType().Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}

		// Token: 0x06038099 RID: 229529 RVA: 0x00FAA300 File Offset: 0x00FA8500
		private int GetTarget()
		{
			if (this.CachedTarget != null)
			{
				return this.CachedTarget.Value;
			}
			ActivityConditionBase condition;
			if (this.TryGetRunningCondition(out condition))
			{
				this.CachedTarget = new int?(ActivityConditionCenter.Instance.GetConditionTarget(condition));
				return this.CachedTarget.Value;
			}
			int num;
			if (ActivityConditionCenter.Instance.TryGetConditionTarget(this.ConditionId, out num))
			{
				this.CachedTarget = new int?(num);
				return num;
			}
			return 0;
		}

		// Token: 0x0603809A RID: 229530 RVA: 0x00FAA378 File Offset: 0x00FA8578
		private void SaveRunningProgress()
		{
			ActivityConditionBase condition;
			if (this.IsLocalCondition && this.TryGetRunningCondition(out condition))
			{
				this.SaveLocalProgress(condition);
			}
		}

		// Token: 0x0603809B RID: 229531 RVA: 0x00FAA3A0 File Offset: 0x00FA85A0
		private void SaveLocalProgress(ActivityConditionBase condition)
		{
			ISolarSchoolProgressCondition solarSchoolProgressCondition = condition as ISolarSchoolProgressCondition;
			if (solarSchoolProgressCondition != null)
			{
				this.SavedProgress = solarSchoolProgressCondition.GetSaveProgress();
			}
		}

		// Token: 0x0401D8A3 RID: 120995
		private long ConditionHandleId;

		// Token: 0x0401D8A4 RID: 120996
		private int SavedProgress;

		// Token: 0x0401D8A5 RID: 120997
		private int? CachedTarget;
	}
}
