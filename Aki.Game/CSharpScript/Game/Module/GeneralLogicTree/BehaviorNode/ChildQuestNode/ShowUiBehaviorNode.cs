using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E1 RID: 23009
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowUiBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4FE RID: 238846 RVA: 0x00DDE911 File Offset: 0x00DDCB11
		public ShowUiBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4FF RID: 238847 RVA: 0x00DDE928 File Offset: 0x00DDCB28
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

		// Token: 0x0603A500 RID: 238848 RVA: 0x00DDE97E File Offset: 0x00DDCB7E
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.UiType = null;
			this.KeepUiOpen = false;
		}

		// Token: 0x0603A501 RID: 238849 RVA: 0x00DDE994 File Offset: 0x00DDCB94
		protected override void OnNodeActive()
		{
			base.OnNodeActive();
			if (this.KeepUiOpen && this.UiType.Type == EShowUiType.RogueAbilitySelect)
			{
				RoguelikeController.Instance.OpenBuffSelectViewByIdAsync(((IRogueAbilitySelect)this.UiType).BindId);
			}
		}

		// Token: 0x0603A502 RID: 238850 RVA: 0x00DDE9D0 File Offset: 0x00DDCBD0
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

		// Token: 0x0603A503 RID: 238851 RVA: 0x00DDEA7C File Offset: 0x00DDCC7C
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

		// Token: 0x0603A504 RID: 238852 RVA: 0x00DDEB32 File Offset: 0x00DDCD32
		private void OnViewDone()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0603A505 RID: 238853 RVA: 0x00DDEB3C File Offset: 0x00DDCD3C
		private void OnCiacconaChapterFinish(int chapterId, int subEndingId)
		{
			int valueOrDefault = ((ICiacconaAvgBoard)this.UiType).EndingId.GetValueOrDefault();
			if (subEndingId == valueOrDefault || valueOrDefault == 0)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0603A506 RID: 238854 RVA: 0x00DDEB70 File Offset: 0x00DDCD70
		private void OnRewardViewShow()
		{
			ItemRewardModel instance = ItemRewardModel.Instance;
			RewardData<IRewardInfo> rewardData = (instance != null) ? instance.GetCurrentRewardData() : null;
			List<RewardItemData> source = ((rewardData != null) ? rewardData.GetItemList() : null) ?? new List<RewardItemData>();
			this.ItemIdsSnapshot = (from item in source
			select item.ConfigId).ToList<int>();
		}

		// Token: 0x0603A507 RID: 238855 RVA: 0x00DDEBD4 File Offset: 0x00DDCDD4
		private void OnItemObtainViewClose(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.QuestRewardView)
			{
				return;
			}
			IItemObtain itemObtain = (IItemObtain)this.UiType;
			if (itemObtain.ItemIds != null && itemObtain.ItemIds.Count > 0 && !itemObtain.ItemIds.All((int id) => this.ItemIdsSnapshot.Contains(id)))
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x0401E671 RID: 124529
		[Nullable(2)]
		private IShowUi UiType;

		// Token: 0x0401E672 RID: 124530
		private bool KeepUiOpen;

		// Token: 0x0401E673 RID: 124531
		private List<int> ItemIdsSnapshot = new List<int>();
	}
}
