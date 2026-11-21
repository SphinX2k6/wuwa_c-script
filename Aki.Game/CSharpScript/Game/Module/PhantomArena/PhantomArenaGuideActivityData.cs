using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200410C RID: 16652
	public class PhantomArenaGuideActivityData : ActivityBaseData
	{
		// Token: 0x0602A06A RID: 172138 RVA: 0x00BE16C8 File Offset: 0x00BDF8C8
		protected override bool GetExDataFinishShowState()
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = instance.GetPhantomArenaActivityData(this.PhantomArenaActivityId).GetTaskMap().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != ActivityTaskState.ActivityTaskTaken)
					{
						return false;
					}
				}
			}
			PhantomArenaActivityData phantomArenaActivityData = instance.GetPhantomArenaActivityData(this.PhantomArenaActivityId);
			foreach (int rewardId in instance.GetCardRewardConfigList(this.PhantomArenaActivityId))
			{
				if (!phantomArenaActivityData.GetCardRewardInfoById(rewardId).IsRewarded)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602A06B RID: 172139 RVA: 0x00BE179C File Offset: 0x00BDF99C
		public override bool GetExDataRedPointShowState()
		{
			return ActivityModel.Instance.IsActivityOpen(this.PhantomArenaActivityId) && PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityRedDot(this.PhantomArenaActivityId);
		}

		// Token: 0x0602A06C RID: 172140 RVA: 0x00BE17C4 File Offset: 0x00BDF9C4
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			PhantomBattleGuideActivity phantomBattleGuideActivity = data.PhantomBattleGuideActivity;
			if (phantomBattleGuideActivity == null)
			{
				return;
			}
			this.QuestId = phantomBattleGuideActivity.QuestId;
			this.DropId = phantomBattleGuideActivity.DropId;
			this.TargetNum = phantomBattleGuideActivity.RewardTotalNum;
			this.IsReceiveReward = phantomBattleGuideActivity.SendReward;
			this.PhantomArenaActivityId = phantomBattleGuideActivity.RecordActId;
		}

		// Token: 0x0602A06D RID: 172141 RVA: 0x00BE1818 File Offset: 0x00BDFA18
		public void UpdateReceiveState(bool isReceive)
		{
			this.IsReceiveReward = isReceive;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0602A06E RID: 172142 RVA: 0x00BE1837 File Offset: 0x00BDFA37
		public int GetQuestId()
		{
			return this.QuestId;
		}

		// Token: 0x0602A06F RID: 172143 RVA: 0x00BE183F File Offset: 0x00BDFA3F
		public int GetDropId()
		{
			return this.DropId;
		}

		// Token: 0x0602A070 RID: 172144 RVA: 0x00BE1847 File Offset: 0x00BDFA47
		public int GetTargetNum()
		{
			return this.TargetNum;
		}

		// Token: 0x0602A071 RID: 172145 RVA: 0x00BE184F File Offset: 0x00BDFA4F
		public bool GetIsReceiveReward()
		{
			return this.IsReceiveReward;
		}

		// Token: 0x0602A072 RID: 172146 RVA: 0x00BE1857 File Offset: 0x00BDFA57
		public int GetPhantomArenaActivityId()
		{
			return this.PhantomArenaActivityId;
		}

		// Token: 0x04016F0D RID: 93965
		private int QuestId;

		// Token: 0x04016F0E RID: 93966
		private int DropId;

		// Token: 0x04016F0F RID: 93967
		private int TargetNum;

		// Token: 0x04016F10 RID: 93968
		private bool IsReceiveReward;

		// Token: 0x04016F11 RID: 93969
		private int PhantomArenaActivityId;
	}
}
