using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BA RID: 18874
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowUiBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F426 RID: 193574 RVA: 0x00D2E131 File Offset: 0x00D2C331
		public ShowUiBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F427 RID: 193575 RVA: 0x00D2E148 File Offset: 0x00D2C348
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IShowUiCondition showUiCondition = childQuestBtNode.Condition as IShowUiCondition;
			if (showUiCondition == null)
			{
				return false;
			}
			this.UiType = showUiCondition.UiType;
			this.KeepUiOpen = showUiCondition.KeepUiOpen.GetValueOrDefault();
			return true;
		}

		// Token: 0x0602F428 RID: 193576 RVA: 0x00D2E19E File Offset: 0x00D2C39E
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.UiType = null;
			this.KeepUiOpen = false;
		}

		// Token: 0x0602F429 RID: 193577 RVA: 0x00D2E1B4 File Offset: 0x00D2C3B4
		protected override void OnNodeActive()
		{
			base.OnNodeActive();
			if (this.KeepUiOpen && this.UiType.Type == EShowUiType.RogueAbilitySelect)
			{
				RoguelikeController.Instance.OpenBuffSelectViewByIdAsync(((IRogueAbilitySelect)this.UiType).BindId);
			}
		}

		// Token: 0x0602F42A RID: 193578 RVA: 0x00D2E1F0 File Offset: 0x00D2C3F0
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			if (this.UiType.Type == EShowUiType.All)
			{
				EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnViewDone));
			}
			if (this.UiType.Type == EShowUiType.CiacconaAvgBoard)
			{
				EventSystem.Instance.Add<int, int>(EEventName.NotifyBtCiacconaChapterFinish, new Action<int, int>(this.OnCiacconaChapterFinish));
			}
			if (this.UiType.Type == EShowUiType.ItemObtain)
			{
				EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnItemObtainViewClose));
				EventSystem.Instance.Add(EEventName.OnShowRewardView, new Action(this.OnRewardViewShow));
			}
		}

		// Token: 0x0602F42B RID: 193579 RVA: 0x00D2E29C File Offset: 0x00D2C49C
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			if (this.UiType.Type == EShowUiType.All)
			{
				EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnViewDone));
			}
			if (this.UiType.Type == EShowUiType.CiacconaAvgBoard)
			{
				EventSystem.Instance.Remove<int, int>(EEventName.NotifyBtCiacconaChapterFinish, new Action<int, int>(this.OnCiacconaChapterFinish));
			}
			if (this.UiType.Type == EShowUiType.ItemObtain)
			{
				EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnItemObtainViewClose));
				EventSystem.Instance.Remove(EEventName.OnShowRewardView, new Action(this.OnRewardViewShow));
				this.ItemIdsSnapshot = new List<int>();
			}
		}

		// Token: 0x0602F42C RID: 193580 RVA: 0x00D2E352 File Offset: 0x00D2C552
		private void OnViewDone()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0602F42D RID: 193581 RVA: 0x00D2E35C File Offset: 0x00D2C55C
		private void OnCiacconaChapterFinish(int chapterId, int subEndingId)
		{
			int valueOrDefault = ((ICiacconaAvgBoard)this.UiType).EndingId.GetValueOrDefault();
			if (subEndingId == valueOrDefault || valueOrDefault == 0)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F42E RID: 193582 RVA: 0x00D2E390 File Offset: 0x00D2C590
		private void OnRewardViewShow()
		{
			ItemRewardModel instance = ItemRewardModel.Instance;
			RewardData<IRewardInfo> rewardData = (instance != null) ? instance.GetCurrentRewardData() : null;
			List<RewardItemData> list = ((rewardData != null) ? rewardData.GetItemList() : null) ?? new List<RewardItemData>();
			this.ItemIdsSnapshot.Clear();
			foreach (RewardItemData rewardItemData in list)
			{
				this.ItemIdsSnapshot.Add(rewardItemData.ConfigId);
			}
		}

		// Token: 0x0602F42F RID: 193583 RVA: 0x00D2E418 File Offset: 0x00D2C618
		private void OnItemObtainViewClose(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.QuestRewardView)
			{
				return;
			}
			IItemObtain itemObtain = (IItemObtain)this.UiType;
			if (itemObtain.ItemIds != null && itemObtain.ItemIds.Count > 0)
			{
				foreach (int item in itemObtain.ItemIds)
				{
					if (!this.ItemIdsSnapshot.Contains(item))
					{
						return;
					}
				}
			}
			this.SubmitNode(null);
		}

		// Token: 0x04019110 RID: 102672
		[Nullable(2)]
		private IShowUi UiType;

		// Token: 0x04019111 RID: 102673
		private bool KeepUiOpen;

		// Token: 0x04019112 RID: 102674
		private List<int> ItemIdsSnapshot = new List<int>();
	}
}
