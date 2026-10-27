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
	// Token: 0x0200616E RID: 24942
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeMainView : UiViewBase
	{
		// Token: 0x170091BB RID: 37307
		// (get) Token: 0x0603F0C3 RID: 258243 RVA: 0x00F3C34F File Offset: 0x00F3A54F
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603F0C4 RID: 258244 RVA: 0x00F3C35B File Offset: 0x00F3A55B
		[NullableContext(1)]
		public RoverlikeMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F0C5 RID: 258245 RVA: 0x00F3C364 File Offset: 0x00F3A564
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

		// Token: 0x0603F0C6 RID: 258246 RVA: 0x00F3C560 File Offset: 0x00F3A760
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Add(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603F0C7 RID: 258247 RVA: 0x00F3C5C4 File Offset: 0x00F3A7C4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F0C8 RID: 258248 RVA: 0x00F3C608 File Offset: 0x00F3A808
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

		// Token: 0x0603F0C9 RID: 258249 RVA: 0x00F3C688 File Offset: 0x00F3A888
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

		// Token: 0x0603F0CA RID: 258250 RVA: 0x00F3C6FC File Offset: 0x00F3A8FC
		protected override void OnAfterShow()
		{
			RoverlikeController.Instance.PlayMainViewUnlockFlow();
		}

		// Token: 0x0603F0CB RID: 258251 RVA: 0x00F3C708 File Offset: 0x00F3A908
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

		// Token: 0x0603F0CC RID: 258252 RVA: 0x00F3C72C File Offset: 0x00F3A92C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Remove(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603F0CD RID: 258253 RVA: 0x00F3C78D File Offset: 0x00F3A98D
		private void OnEquippedLootChange(int lootId)
		{
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x0603F0CE RID: 258254 RVA: 0x00F3C79F File Offset: 0x00F3A99F
		private void OnLootInfoUpdate()
		{
			RoverlikeEquipmentPanel equipmentPanel = this.EquipmentPanel;
			if (equipmentPanel == null)
			{
				return;
			}
			equipmentPanel.Refresh();
		}

		// Token: 0x0603F0CF RID: 258255 RVA: 0x00F3C7B4 File Offset: 0x00F3A9B4
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

		// Token: 0x0603F0D0 RID: 258256 RVA: 0x00F3C818 File Offset: 0x00F3AA18
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

		// Token: 0x0603F0D1 RID: 258257 RVA: 0x00F3C850 File Offset: 0x00F3AA50
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

		// Token: 0x0603F0D2 RID: 258258 RVA: 0x00F3C881 File Offset: 0x00F3AA81
		private void RefreshEntranceRedDot()
		{
			RoverlikeEntranceButton btnEntrance = this.BtnEntrance;
			if (btnEntrance == null)
			{
				return;
			}
			btnEntrance.RefreshNewLevelUnlockRedDot(this.ActivityData);
		}

		// Token: 0x0603F0D3 RID: 258259 RVA: 0x00F3C89C File Offset: 0x00F3AA9C
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

		// Token: 0x0603F0D4 RID: 258260 RVA: 0x00F3C8E7 File Offset: 0x00F3AAE7
		private void RefreshEntranceButton()
		{
			this.BtnEntrance.RefreshSaveInfo(this.ActivityData);
		}

		// Token: 0x0603F0D5 RID: 258261 RVA: 0x00F3C8FA File Offset: 0x00F3AAFA
		private bool HasSaveProgress()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.HasSaveProgress();
		}

		// Token: 0x0603F0D6 RID: 258262 RVA: 0x00F3C910 File Offset: 0x00F3AB10
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

		// Token: 0x0603F0D7 RID: 258263 RVA: 0x00F3C9CA File Offset: 0x00F3ABCA
		private void RefreshRewardProgress()
		{
			this.RefreshQuestProgress();
			this.RefreshShopProgress();
		}

		// Token: 0x0603F0D8 RID: 258264 RVA: 0x00F3C9D8 File Offset: 0x00F3ABD8
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

		// Token: 0x0603F0D9 RID: 258265 RVA: 0x00F3CA18 File Offset: 0x00F3AC18
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

		// Token: 0x0603F0DA RID: 258266 RVA: 0x00F3CA55 File Offset: 0x00F3AC55
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603F0DB RID: 258267 RVA: 0x00F3CA5E File Offset: 0x00F3AC5E
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(642);
		}

		// Token: 0x0603F0DC RID: 258268 RVA: 0x00F3CA6F File Offset: 0x00F3AC6F
		private void OnClickTalentTree()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeTalentTreeView, null, null);
		}

		// Token: 0x0603F0DD RID: 258269 RVA: 0x00F3CA82 File Offset: 0x00F3AC82
		private void OnClickHandBook()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeHandBookView, EUiTabViewName.RoverlikeOutsideBlessTabView, null);
		}

		// Token: 0x0603F0DE RID: 258270 RVA: 0x00F3CAA0 File Offset: 0x00F3ACA0
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

		// Token: 0x0603F0DF RID: 258271 RVA: 0x00F3CB64 File Offset: 0x00F3AD64
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

		// Token: 0x0603F0E0 RID: 258272 RVA: 0x00F3CB9C File Offset: 0x00F3AD9C
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

		// Token: 0x0603F0E1 RID: 258273 RVA: 0x00F3CC24 File Offset: 0x00F3AE24
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

		// Token: 0x04020E27 RID: 134695
		private PopupCaptionItem Caption;

		// Token: 0x04020E28 RID: 134696
		private RoverlikeShopRewardButton ShopRewardBtn;

		// Token: 0x04020E29 RID: 134697
		private RoverlikeQuestRewardButton QuestRewardBtn;

		// Token: 0x04020E2A RID: 134698
		private ButtonItem BtnSkillTree;

		// Token: 0x04020E2B RID: 134699
		private ButtonItem BtnAchieve;

		// Token: 0x04020E2C RID: 134700
		private RoverlikeEntranceButton BtnEntrance;

		// Token: 0x04020E2D RID: 134701
		private RoverlikeEquipmentPanel EquipmentPanel;

		// Token: 0x0200C3D5 RID: 50133
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B17D RID: 242045
			public const int UiItemCaption = 0;

			// Token: 0x0403B17E RID: 242046
			public const int UiItemBtnReward = 1;

			// Token: 0x0403B17F RID: 242047
			public const int UiItemBtnShop = 2;

			// Token: 0x0403B180 RID: 242048
			public const int BtnSkillTree = 3;

			// Token: 0x0403B181 RID: 242049
			public const int BtnAchieve = 4;

			// Token: 0x0403B182 RID: 242050
			public const int PnlEquippment = 5;

			// Token: 0x0403B183 RID: 242051
			public const int BtnEntrance = 6;

			// Token: 0x0403B184 RID: 242052
			public const int PnlLight = 7;

			// Token: 0x0403B185 RID: 242053
			public const int PnlDark = 8;

			// Token: 0x0403B186 RID: 242054
			public const int TxtTime = 9;

			// Token: 0x0403B187 RID: 242055
			public const int PnlLightMale = 10;

			// Token: 0x0403B188 RID: 242056
			public const int PnlLightFemale = 11;

			// Token: 0x0403B189 RID: 242057
			public const int PnlDarkMale = 12;

			// Token: 0x0403B18A RID: 242058
			public const int PnlDarkFemale = 13;
		}
	}
}
