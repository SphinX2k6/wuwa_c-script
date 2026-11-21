using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005946 RID: 22854
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolScratchTicketGameplay : SolarSchoolGameplayBase, ISolarSchoolScratchTicketViewHandler
	{
		// Token: 0x060384FB RID: 230651 RVA: 0x00FBE504 File Offset: 0x00FBC704
		protected override void OnGameplayStart()
		{
			this.Data = SolarSchoolGamePlayModel.Instance.ScratchTicketData.GetCurrentData(base.GameplayId);
			if (this.Data == null)
			{
				base.MarkFailed();
				return;
			}
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("WaitScratch", new Action(this.EnterWaitScratch));
			base.AddState("PlayReveal", new Action(this.EnterPlayReveal));
			base.AddState("ShowResult", new Action(this.EnterShowResult));
		}

		// Token: 0x060384FC RID: 230652 RVA: 0x00FBE597 File Offset: 0x00FBC797
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x060384FD RID: 230653 RVA: 0x00FBE59F File Offset: 0x00FBC79F
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolScratchTicketView, this, null);
		}

		// Token: 0x060384FE RID: 230654 RVA: 0x00FBE5B2 File Offset: 0x00FBC7B2
		private void EnterWaitScratch()
		{
		}

		// Token: 0x060384FF RID: 230655 RVA: 0x00FBE5B4 File Offset: 0x00FBC7B4
		private void EnterPlayReveal()
		{
			if (this.Data == null || !this.CheckCellClickable(this.PendingIndex))
			{
				base.GotoState("WaitScratch");
				return;
			}
			EScratchTicketRewardType rewardType = this.Data.DecideRevealType();
			List<ScratchTicketRoundResult> rewardResultList = this.Data.GetRewardResultList(this.PendingIndex, rewardType);
			this.PendingRewards.Clear();
			this.PendingRewards.AddRange(this.Data.ApplyReveal(rewardResultList));
			SolarSchoolScratchTicketView view = this.View;
			if (view == null)
			{
				return;
			}
			view.PlayRevealAnim(this.Data, rewardResultList);
		}

		// Token: 0x06038500 RID: 230656 RVA: 0x00FBE63B File Offset: 0x00FBC83B
		private void EnterShowResult()
		{
			SolarSchoolScratchTicketView view = this.View;
			if (view != null)
			{
				view.ShowResult();
			}
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x06038501 RID: 230657 RVA: 0x00FBE65C File Offset: 0x00FBC85C
		private void GiveRewards(List<SolarSchoolReward> rewards)
		{
			if (rewards.Count == 0)
			{
				return;
			}
			string item;
			if (!SolarSchoolRewardCenter.Instance.TryGiveReward(rewards, out item))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.HHJ;
				string message = "[SolarSchool][ScratchTicket] 发奖失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06038502 RID: 230658 RVA: 0x00FBE6AC File Offset: 0x00FBC8AC
		private bool CheckCellClickable(int index)
		{
			if (this.Data == null)
			{
				return false;
			}
			SolarSchoolScratchTicketCellData cellDataByIndex = this.Data.GetCellDataByIndex(index);
			return cellDataByIndex != null && cellDataByIndex.IsLock() && !this.Data.IsFinish;
		}

		// Token: 0x06038503 RID: 230659 RVA: 0x00FBE6EC File Offset: 0x00FBC8EC
		private void HandleCostAndReveal(int index)
		{
			SolarSchoolScratchTicketData data = this.Data;
			SolarSchoolScratchTicketCo? solarSchoolScratchTicketCo = (data != null) ? data.Config : null;
			if (solarSchoolScratchTicketCo == null)
			{
				this.StartReveal(index);
				return;
			}
			ValueTuple<bool, ESolarSchoolRewardType, int, int> valueTuple = this.ReadCost(solarSchoolScratchTicketCo.Value.CostId1);
			ValueTuple<bool, ESolarSchoolRewardType, int, int> cost2 = this.ReadCost(solarSchoolScratchTicketCo.Value.CostId2);
			if (!valueTuple.Item1 && !cost2.Item1)
			{
				this.StartReveal(index);
				return;
			}
			if (valueTuple.Item1 && this.CanConsume(valueTuple.Item2, valueTuple.Item3, valueTuple.Item4))
			{
				this.Consume(valueTuple.Item2, valueTuple.Item3, valueTuple.Item4);
				this.StartReveal(index);
				return;
			}
			if (cost2.Item1 && this.CanConsume(cost2.Item2, cost2.Item3, cost2.Item4))
			{
				this.ShowCostItem1Confirm(cost2.Item2, cost2.Item3, cost2.Item4, delegate
				{
					if (!this.CheckCellClickable(index) || !this.CanConsume(cost2.Item2, cost2.Item3, cost2.Item4))
					{
						return;
					}
					this.Consume(cost2.Item2, cost2.Item3, cost2.Item4);
					this.StartReveal(index);
				});
				return;
			}
			this.ShowCostItem2Confirm();
		}

		// Token: 0x06038504 RID: 230660 RVA: 0x00FBE84A File Offset: 0x00FBCA4A
		private void StartReveal(int index)
		{
			this.PendingIndex = index;
			base.GotoState("PlayReveal");
		}

		// Token: 0x06038505 RID: 230661 RVA: 0x00FBE860 File Offset: 0x00FBCA60
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"has",
			"type",
			"id",
			"amount"
		})]
		private ValueTuple<bool, ESolarSchoolRewardType, int, int> ReadCost(int costId)
		{
			SolarSchoolReward? reward = SolarSchoolConfig.Instance.GetReward(costId);
			return new ValueTuple<bool, ESolarSchoolRewardType, int, int>(reward != null, (ESolarSchoolRewardType)reward.Value.RewardType, reward.Value.TargetId, reward.Value.Value);
		}

		// Token: 0x06038506 RID: 230662 RVA: 0x00FBE8B4 File Offset: 0x00FBCAB4
		private bool CanConsume(ESolarSchoolRewardType type, int id, int amount)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int num = Math.Abs(amount);
			bool result;
			if (type != ESolarSchoolRewardType.PlayerAttr)
			{
				result = (type == ESolarSchoolRewardType.Item && instance.InventoryData.GetItemCount(id) >= num);
			}
			else
			{
				result = (instance.PlayerData.GetAttr((ESolarSchoolSecondAttr)id) >= num);
			}
			return result;
		}

		// Token: 0x06038507 RID: 230663 RVA: 0x00FBE904 File Offset: 0x00FBCB04
		private void Consume(ESolarSchoolRewardType type, int id, int amount)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (type == ESolarSchoolRewardType.PlayerAttr)
			{
				instance.PlayerData.AddAttr((ESolarSchoolSecondAttr)id, amount);
				return;
			}
			if (type != ESolarSchoolRewardType.Item)
			{
				return;
			}
			instance.AddItem(id, amount);
		}

		// Token: 0x06038508 RID: 230664 RVA: 0x00FBE938 File Offset: 0x00FBCB38
		private void ShowCostItem1Confirm(ESolarSchoolRewardType type, int id, int amount, Action onConfirm)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)SolarSchoolConfig.Instance.GetScratchTicket(SolarSchoolGamePlayModel.Instance.ScratchTicketData.CurrentRoundId).Value.CostItem1ConfirmId);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				(-1 * amount).ToString()
			});
			confirmBoxDataNew.FunctionMap[2] = onConfirm;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038509 RID: 230665 RVA: 0x00FBE9A8 File Offset: 0x00FBCBA8
		private void ShowCostItem2Confirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)SolarSchoolConfig.Instance.GetScratchTicket(SolarSchoolGamePlayModel.Instance.ScratchTicketData.CurrentRoundId).Value.CostItem2ConfirmId);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603850A RID: 230666 RVA: 0x00FBE9F0 File Offset: 0x00FBCBF0
		[NullableContext(2)]
		public SolarSchoolScratchTicketData GetData()
		{
			return this.Data;
		}

		// Token: 0x0603850B RID: 230667 RVA: 0x00FBE9F8 File Offset: 0x00FBCBF8
		public void OnViewReady(SolarSchoolScratchTicketView view)
		{
			this.View = view;
			base.GotoState("WaitScratch");
			base.FinishActionEarly();
		}

		// Token: 0x0603850C RID: 230668 RVA: 0x00FBEA12 File Offset: 0x00FBCC12
		public void OnCellClicked(int index)
		{
			if (!this.CheckCellClickable(index))
			{
				return;
			}
			this.HandleCostAndReveal(index);
		}

		// Token: 0x0603850D RID: 230669 RVA: 0x00FBEA28 File Offset: 0x00FBCC28
		public void OnRevealAnimFinished()
		{
			this.GiveRewards(this.PendingRewards);
			this.PendingRewards.Clear();
			if (this.Data != null && this.Data.IsFinish)
			{
				base.GotoState("ShowResult");
				return;
			}
			base.GotoState("WaitScratch");
		}

		// Token: 0x0603850E RID: 230670 RVA: 0x00FBEA78 File Offset: 0x00FBCC78
		public void OnRequestClose()
		{
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x0603850F RID: 230671 RVA: 0x00FBEA86 File Offset: 0x00FBCC86
		public void OnViewClosed()
		{
			this.View = null;
			base.FinishGameplay();
		}

		// Token: 0x06038510 RID: 230672 RVA: 0x00FBEA95 File Offset: 0x00FBCC95
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolScratchTicketView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401DA86 RID: 121478
		[Nullable(2)]
		private SolarSchoolScratchTicketView View;

		// Token: 0x0401DA87 RID: 121479
		[Nullable(2)]
		private SolarSchoolScratchTicketData Data;

		// Token: 0x0401DA88 RID: 121480
		private int PendingIndex = -1;

		// Token: 0x0401DA89 RID: 121481
		private readonly List<SolarSchoolReward> PendingRewards = new List<SolarSchoolReward>();

		// Token: 0x0200B4FC RID: 46332
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037F60 RID: 229216
			public const string OpenView = "OpenView";

			// Token: 0x04037F61 RID: 229217
			public const string WaitScratch = "WaitScratch";

			// Token: 0x04037F62 RID: 229218
			public const string PlayReveal = "PlayReveal";

			// Token: 0x04037F63 RID: 229219
			public const string ShowResult = "ShowResult";
		}
	}
}
