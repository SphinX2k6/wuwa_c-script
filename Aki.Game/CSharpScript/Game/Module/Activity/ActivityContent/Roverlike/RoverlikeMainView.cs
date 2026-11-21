using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050EC RID: 20716
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeMainView : UiViewBase
	{
		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x06033D83 RID: 212355 RVA: 0x00E83223 File Offset: 0x00E81423
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x06033D84 RID: 212356 RVA: 0x00E8322F File Offset: 0x00E8142F
		[NullableContext(1)]
		public RoverlikeMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033D85 RID: 212357 RVA: 0x00E83238 File Offset: 0x00E81438
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033D86 RID: 212358 RVA: 0x00E83434 File Offset: 0x00E81634
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Add(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033D87 RID: 212359 RVA: 0x00E83498 File Offset: 0x00E81698
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D88 RID: 212360 RVA: 0x00E834DC File Offset: 0x00E816DC
		protected override void OnStart()
		{
			this.Caption.SetCloseCallBack(new Action(this.OnClickClose));
			this.Caption.SetHelpCallBack(new Action(this.OnClickHelp));
			this.BtnSkillTree.SetFunction(delegate(int _)
			{
				this.OnClickTalentTree();
			});
			this.BtnAchieve.SetFunction(delegate(int _)
			{
				this.OnClickHandBook();
			});
			this.BtnEntrance.SetFunction(delegate(int _)
			{
				this.OnClickEntrance();
			});
		}

		// Token: 0x06033D89 RID: 212361 RVA: 0x00E8355C File Offset: 0x00E8175C
		protected override void OnBeforeShow()
		{
			this.RefreshRemainTime();
			this.RefreshEntranceButton();
			this.RefreshRoleStand();
			this.RefreshRewardProgress();
			this.RefreshTalentTreeRedDot();
			this.RefreshEntranceRedDot();
			this.RefreshHandBookRedDot();
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn != null)
			{
				questRewardBtn.BindRedDot();
			}
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn != null)
			{
				shopRewardBtn.BindRedDot();
			}
			SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x06033D8A RID: 212362 RVA: 0x00E835D0 File Offset: 0x00E817D0
		protected override void OnAfterShow()
		{
			RoverlikeController.Instance.PlayMainViewUnlockFlow();
		}

		// Token: 0x06033D8B RID: 212363 RVA: 0x00E835DC File Offset: 0x00E817DC
		protected override void OnBeforeHide()
		{
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn != null)
			{
				questRewardBtn.UnBindRedDot();
			}
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn == null)
			{
				return;
			}
			shopRewardBtn.UnBindRedDot();
		}

		// Token: 0x06033D8C RID: 212364 RVA: 0x00E83600 File Offset: 0x00E81800
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Remove(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033D8D RID: 212365 RVA: 0x00E83661 File Offset: 0x00E81861
		private void OnEquippedLootChange(int lootId)
		{
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x06033D8E RID: 212366 RVA: 0x00E83673 File Offset: 0x00E81873
		private void OnLootInfoUpdate()
		{
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x06033D8F RID: 212367 RVA: 0x00E83688 File Offset: 0x00E81888
		private void OnRefreshCommonActivityRedDot(int activityId)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			int? num = (activityData != null) ? new int?(activityData.Id) : null;
			if (!(activityId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshTalentTreeRedDot();
			this.RefreshEntranceRedDot();
			this.RefreshHandBookRedDot();
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x06033D90 RID: 212368 RVA: 0x00E836EC File Offset: 0x00E818EC
		private void RefreshTalentTreeRedDot()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			bool redDotVisible = activityData != null && activityData.TalentTreeData.IsTalentTreeHasRedDot();
			ButtonItem btnSkillTree = this.BtnSkillTree;
			if (btnSkillTree == null)
			{
				return;
			}
			btnSkillTree.SetRedDotVisible(redDotVisible);
		}

		// Token: 0x06033D91 RID: 212369 RVA: 0x00E83724 File Offset: 0x00E81924
		private void RefreshHandBookRedDot()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			bool redDotVisible = activityData != null && activityData.HasNewBlessUnlockRedDot();
			ButtonItem btnAchieve = this.BtnAchieve;
			if (btnAchieve == null)
			{
				return;
			}
			btnAchieve.SetRedDotVisible(redDotVisible);
		}

		// Token: 0x06033D92 RID: 212370 RVA: 0x00E83755 File Offset: 0x00E81955
		private void RefreshEntranceRedDot()
		{
			RoverlikeEntranceButton btnEntrance = this.BtnEntrance;
			if (btnEntrance == null)
			{
				return;
			}
			btnEntrance.RefreshNewLevelUnlockRedDot(this.ActivityData);
		}

		// Token: 0x06033D93 RID: 212371 RVA: 0x00E83770 File Offset: 0x00E81970
		private void RefreshRemainTime()
		{
			UUIText text = base.GetText(9);
			if (text == null)
			{
				return;
			}
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				text.SetText("", true);
				return;
			}
			string item = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityData, null).Item2;
			text.SetText(item, true);
		}

		// Token: 0x06033D94 RID: 212372 RVA: 0x00E837BB File Offset: 0x00E819BB
		private void RefreshEntranceButton()
		{
			this.BtnEntrance.RefreshSaveInfo(this.ActivityData);
		}

		// Token: 0x06033D95 RID: 212373 RVA: 0x00E837CE File Offset: 0x00E819CE
		private bool HasSaveProgress()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.HasSaveProgress();
		}

		// Token: 0x06033D96 RID: 212374 RVA: 0x00E837E4 File Offset: 0x00E819E4
		private void RefreshRoleStand()
		{
			bool flag = RoverlikeModel.Instance.GetLastPassRoleTypeId() == 2;
			bool flag2 = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(10);
			if (item3 != null)
			{
				item3.SetUIActive(!flag && flag2);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 != null)
			{
				item4.SetUIActive(!flag && !flag2);
			}
			UUIItem item5 = base.GetItem(12);
			if (item5 != null)
			{
				item5.SetUIActive(flag && flag2);
			}
			UUIItem item6 = base.GetItem(13);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(flag && !flag2);
		}

		// Token: 0x06033D97 RID: 212375 RVA: 0x00E8389E File Offset: 0x00E81A9E
		private void RefreshRewardProgress()
		{
			this.RefreshQuestProgress();
			this.RefreshShopProgress();
		}

		// Token: 0x06033D98 RID: 212376 RVA: 0x00E838AC File Offset: 0x00E81AAC
		private void RefreshQuestProgress()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			ValueTuple<int, int> questProgress = activityData.GetQuestProgress();
			int item = questProgress.Item1;
			int item2 = questProgress.Item2;
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn == null)
			{
				return;
			}
			questRewardBtn.SetProgressNumText(item, item2);
		}

		// Token: 0x06033D99 RID: 212377 RVA: 0x00E838EC File Offset: 0x00E81AEC
		private void RefreshShopProgress()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			ValueTuple<int, int> shopProgress = activityData.GetShopProgress();
			int item = shopProgress.Item1;
			int item2 = shopProgress.Item2;
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn == null)
			{
				return;
			}
			shopRewardBtn.SetProgressNumText(item, item2);
		}

		// Token: 0x06033D9A RID: 212378 RVA: 0x00E83929 File Offset: 0x00E81B29
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033D9B RID: 212379 RVA: 0x00E83932 File Offset: 0x00E81B32
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(642);
		}

		// Token: 0x06033D9C RID: 212380 RVA: 0x00E83943 File Offset: 0x00E81B43
		private void OnClickTalentTree()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeTalentTreeView, null, null);
		}

		// Token: 0x06033D9D RID: 212381 RVA: 0x00E83956 File Offset: 0x00E81B56
		private void OnClickHandBook()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeHandBookView, EUiTabViewName.RoverlikeOutsideBlessTabView, null);
		}

		// Token: 0x06033D9E RID: 212382 RVA: 0x00E83974 File Offset: 0x00E81B74
		private void OnClickEntrance()
		{
			RoverlikeMainView.<>c__DisplayClass36_0 CS$<>8__locals1 = new RoverlikeMainView.<>c__DisplayClass36_0();
			CS$<>8__locals1.<>4__this = this;
			RoverlikeMainView.<>c__DisplayClass36_0 CS$<>8__locals2 = CS$<>8__locals1;
			RoverlikeActivityData activityData = this.ActivityData;
			int? num;
			if (activityData == null)
			{
				num = null;
			}
			else
			{
				RoverRogueHistoryInsInfo historyInsInfo = activityData.HistoryInsInfo;
				num = ((historyInsInfo != null) ? new int?(historyInsInfo.CurInsId) : null);
			}
			int? num2 = num;
			CS$<>8__locals2.saveInsId = num2.GetValueOrDefault();
			if (this.HasSaveProgress() && CS$<>8__locals1.saveInsId > 0)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoverRogueSaveEnterConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					CS$<>8__locals1.<>4__this.ContinueWithSave(CS$<>8__locals1.saveInsId);
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					CS$<>8__locals1.<>4__this.SettleSave(CS$<>8__locals1.saveInsId);
				};
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.EnterNewGame();
		}

		// Token: 0x06033D9F RID: 212383 RVA: 0x00E83A38 File Offset: 0x00E81C38
		private void ContinueWithSave(int saveInsId)
		{
			RoverlikeController.Instance.RoverRogueReChallengeRequest(saveInsId, delegate(bool success)
			{
				if (!success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.SWC;
					string message = "RoverlikeMainView 续档进入失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", saveInsId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			});
		}

		// Token: 0x06033DA0 RID: 212384 RVA: 0x00E83A70 File Offset: 0x00E81C70
		private void SettleSave(int saveInsId)
		{
			int? currentActivityId = RoverlikeActivityController.Instance.GetCurrentActivityId();
			if (currentActivityId != null)
			{
				int? num = currentActivityId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					RoverlikeController.Instance.RoverRogueResultRequest(currentActivityId.Value, saveInsId, delegate(bool success)
					{
						if (!success)
						{
							return;
						}
						this.RefreshEntranceButton();
					});
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "RoverlikeMainView 存档结算失败:无活动Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", saveInsId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06033DA1 RID: 212385 RVA: 0x00E83AF8 File Offset: 0x00E81CF8
		private void EnterNewGame()
		{
			if (RoverlikeActivityController.Instance == null)
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeLevelSelectView, null, null);
				return;
			}
			RoverlikeController.Instance.RequestInsList(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeLevelSelectView, null, null);
			});
		}

		// Token: 0x0401B754 RID: 112468
		private PopupCaptionItem Caption;

		// Token: 0x0401B755 RID: 112469
		private RoverlikeShopRewardButton ShopRewardBtn;

		// Token: 0x0401B756 RID: 112470
		private RoverlikeQuestRewardButton QuestRewardBtn;

		// Token: 0x0401B757 RID: 112471
		private ButtonItem BtnSkillTree;

		// Token: 0x0401B758 RID: 112472
		private ButtonItem BtnAchieve;

		// Token: 0x0401B759 RID: 112473
		private RoverlikeEntranceButton BtnEntrance;

		// Token: 0x0401B75A RID: 112474
		private RoverlikeEquipmentPanel EquipmentPanel;

		// Token: 0x0200ADBC RID: 44476
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035ADE RID: 219870
			public const int UiItemCaption = 0;

			// Token: 0x04035ADF RID: 219871
			public const int UiItemBtnReward = 1;

			// Token: 0x04035AE0 RID: 219872
			public const int UiItemBtnShop = 2;

			// Token: 0x04035AE1 RID: 219873
			public const int BtnSkillTree = 3;

			// Token: 0x04035AE2 RID: 219874
			public const int BtnAchieve = 4;

			// Token: 0x04035AE3 RID: 219875
			public const int PnlEquippment = 5;

			// Token: 0x04035AE4 RID: 219876
			public const int BtnEntrance = 6;

			// Token: 0x04035AE5 RID: 219877
			public const int PnlLight = 7;

			// Token: 0x04035AE6 RID: 219878
			public const int PnlDark = 8;

			// Token: 0x04035AE7 RID: 219879
			public const int TxtTime = 9;

			// Token: 0x04035AE8 RID: 219880
			public const int PnlLightMale = 10;

			// Token: 0x04035AE9 RID: 219881
			public const int PnlLightFemale = 11;

			// Token: 0x04035AEA RID: 219882
			public const int PnlDarkMale = 12;

			// Token: 0x04035AEB RID: 219883
			public const int PnlDarkFemale = 13;
		}
	}
}
