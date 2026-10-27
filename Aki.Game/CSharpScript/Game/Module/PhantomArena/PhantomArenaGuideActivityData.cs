using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200513C RID: 20796
	public class PhantomArenaGuideActivityData : ActivityBaseData
	{
		// Token: 0x06035171 RID: 217457 RVA: 0x00C942B4 File Offset: 0x00C924B4
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

		// Token: 0x06035172 RID: 217458 RVA: 0x00C94388 File Offset: 0x00C92588
		public override bool GetExDataRedPointShowState()
		{
			return ActivityModel.Instance.IsActivityOpen(this.PhantomArenaActivityId) && PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityRedDot(this.PhantomArenaActivityId);
		}

		// Token: 0x06035173 RID: 217459 RVA: 0x00C943B0 File Offset: 0x00C925B0
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

		// Token: 0x06035174 RID: 217460 RVA: 0x00C94404 File Offset: 0x00C92604
		public void UpdateReceiveState(bool isReceive)
		{
			this.IsReceiveReward = isReceive;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06035175 RID: 217461 RVA: 0x00C94423 File Offset: 0x00C92623
		public int GetQuestId()
		{
			return this.QuestId;
		}

		// Token: 0x06035176 RID: 217462 RVA: 0x00C9442B File Offset: 0x00C9262B
		public int GetDropId()
		{
			return this.DropId;
		}

		// Token: 0x06035177 RID: 217463 RVA: 0x00C94433 File Offset: 0x00C92633
		public int GetTargetNum()
		{
			return this.TargetNum;
		}

		// Token: 0x06035178 RID: 217464 RVA: 0x00C9443B File Offset: 0x00C9263B
		public bool GetIsReceiveReward()
		{
			return this.IsReceiveReward;
		}

		// Token: 0x06035179 RID: 217465 RVA: 0x00C94443 File Offset: 0x00C92643
		public int GetPhantomArenaActivityId()
		{
			return this.PhantomArenaActivityId;
		}

		// Token: 0x0401C4D8 RID: 115928
		private int QuestId;

		// Token: 0x0401C4D9 RID: 115929
		private int DropId;

		// Token: 0x0401C4DA RID: 115930
		private int TargetNum;

		// Token: 0x0401C4DB RID: 115931
		private bool IsReceiveReward;

		// Token: 0x0401C4DC RID: 115932
		private int PhantomArenaActivityId;
	}
}
