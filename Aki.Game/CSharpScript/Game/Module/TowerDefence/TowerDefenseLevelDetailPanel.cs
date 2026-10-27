using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B4C RID: 19276
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerDefenseLevelDetailPanel : UiPanelBase
	{
		// Token: 0x06031EA0 RID: 204448 RVA: 0x00B936EC File Offset: 0x00B918EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnBuffTips));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickBtnBestRecord));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031EA1 RID: 204449 RVA: 0x00B93A38 File Offset: 0x00B91C38
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseLevelDetailPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseLevelDetailPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031EA2 RID: 204450 RVA: 0x00B93A7C File Offset: 0x00B91C7C
		protected override void OnStart()
		{
			this.ElementScroll = new GenericScrollViewNew<TowerDefenseLevelDetailElementItem, string>(base.GetScrollViewWithScrollbar(5), () => new TowerDefenseLevelDetailElementItem(), null, false, null);
			this.PhantomScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(8), () => new CommonItemSmallItemGrid(), null, false, null);
			this.BossScroll = new GenericScrollViewNew<TowerDefenseLevelBossItem, int>(base.GetScrollViewWithScrollbar(11), () => new TowerDefenseLevelBossItem(), null, false, null);
			this.MultiChallengeBtn = new ButtonItem(base.GetItem(18));
			this.MultiChallengeBtn.SetFunction(delegate(int _)
			{
				this.OnClickBtnMultiChallenge();
			});
			this.SingleChallengeBtn = new ButtonItem(base.GetItem(19));
			this.SingleChallengeBtn.SetFunction(delegate(int _)
			{
				this.OnClickBtnSingleChallenge();
			});
		}

		// Token: 0x06031EA3 RID: 204451 RVA: 0x00B93B7C File Offset: 0x00B91D7C
		public void RefreshItem(int instanceId)
		{
			this.CurrentInstanceId = instanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.MapName, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.DungeonDesc, Array.Empty<object>());
			}
			TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId);
			bool unlocked = (towerDefenseInstanceByInstance != null) ? TowerDefenseController.Instance.CheckStageUnlockById(towerDefenseInstanceByInstance.Value.Id) : TowerDefenseController.Instance.CheckIsInstanceUnlock(instanceId);
			this.RefreshLockPanel(instanceId, unlocked);
			TowerDefenseRecommendLevel towerDefenseRecommendLevel = TowerDefenseController.Instance.BuildRecommendLevelForInstanceDungeonEntranceData(instanceId);
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(towerDefenseRecommendLevel.Level > 0);
			}
			if (towerDefenseRecommendLevel.Level > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(17), towerDefenseRecommendLevel.TextId, new <>z__ReadOnlySingleElementList<object>(towerDefenseRecommendLevel.Level));
			}
			this.RefreshBestRecordPanel(instanceId);
			this.RefreshBuffPanel(instanceId);
			this.RefreshPhantomPanel(instanceId);
			this.RefreshBossPanel(instanceId);
		}

		// Token: 0x06031EA4 RID: 204452 RVA: 0x00B93CAC File Offset: 0x00B91EAC
		private void RefreshLockPanel(int instanceId, bool unlocked)
		{
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(!unlocked);
			}
			this.RefreshChallengeButtonsVisibility(instanceId, unlocked);
			this.RefreshChallengeBtnMatchingState();
			if (unlocked || this.LockPanel == null)
			{
				return;
			}
			this.LockPanel.SetSpriteVisible(true);
			this.LockPanel.SetButtonVisible(false);
			string unlockConditionGroupHintText = InstanceDungeonConfig.Instance.GetUnlockConditionGroupHintText(instanceId);
			if (!string.IsNullOrEmpty(unlockConditionGroupHintText))
			{
				this.LockPanel.SetTextByTextId(unlockConditionGroupHintText, Array.Empty<string>());
			}
		}

		// Token: 0x06031EA5 RID: 204453 RVA: 0x00B93D28 File Offset: 0x00B91F28
		private void RefreshChallengeButtonsVisibility(int instanceId, bool unlocked)
		{
			if (!unlocked)
			{
				this.ShouldShowSingleChallengeBtn = false;
				ButtonItem multiChallengeBtn = this.MultiChallengeBtn;
				if (multiChallengeBtn != null)
				{
					multiChallengeBtn.SetUiActive(false);
				}
				ButtonItem singleChallengeBtn = this.SingleChallengeBtn;
				if (singleChallengeBtn == null)
				{
					return;
				}
				singleChallengeBtn.SetUiActive(false);
				return;
			}
			else
			{
				if (!GameModeModel.Instance.IsMulti || OnlineModel.Instance.GetIsMyTeam())
				{
					InstanceDungeon? instanceDungeon;
					InstOnlineType instOnlineType = (InstanceDungeonConfig.Instance.GetConfig(instanceId) != null) ? instanceDungeon.GetValueOrDefault().OnlineType : InstOnlineType.Single;
					bool isMulti = GameModeModel.Instance.IsMulti;
					bool uiActive;
					bool flag;
					if (instOnlineType == InstOnlineType.Single)
					{
						uiActive = false;
						flag = true;
					}
					else if (instOnlineType == InstOnlineType.Multi)
					{
						uiActive = true;
						flag = isMulti;
					}
					else
					{
						uiActive = true;
						flag = true;
					}
					this.ShouldShowSingleChallengeBtn = flag;
					ButtonItem multiChallengeBtn2 = this.MultiChallengeBtn;
					if (multiChallengeBtn2 != null)
					{
						multiChallengeBtn2.SetUiActive(uiActive);
					}
					ButtonItem singleChallengeBtn2 = this.SingleChallengeBtn;
					if (singleChallengeBtn2 != null)
					{
						singleChallengeBtn2.SetUiActive(flag);
					}
					if (flag && isMulti)
					{
						ButtonItem singleChallengeBtn3 = this.SingleChallengeBtn;
						if (singleChallengeBtn3 == null)
						{
							return;
						}
						singleChallengeBtn3.SetLocalTextNew("AbyssMPChallenge", Array.Empty<object>());
					}
					return;
				}
				this.ShouldShowSingleChallengeBtn = false;
				ButtonItem multiChallengeBtn3 = this.MultiChallengeBtn;
				if (multiChallengeBtn3 != null)
				{
					multiChallengeBtn3.SetUiActive(false);
				}
				ButtonItem singleChallengeBtn4 = this.SingleChallengeBtn;
				if (singleChallengeBtn4 == null)
				{
					return;
				}
				singleChallengeBtn4.SetUiActive(false);
				return;
			}
		}

		// Token: 0x06031EA6 RID: 204454 RVA: 0x00B93E44 File Offset: 0x00B92044
		public void RefreshChallengeBtnMatchingState()
		{
			bool flag = InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching;
			ButtonItem singleChallengeBtn = this.SingleChallengeBtn;
			if (singleChallengeBtn != null)
			{
				singleChallengeBtn.SetUiActive(this.ShouldShowSingleChallengeBtn && !flag);
			}
			ButtonItem multiChallengeBtn = this.MultiChallengeBtn;
			if (multiChallengeBtn != null)
			{
				multiChallengeBtn.SetLocalTextNew(flag ? "MultRacing_Button_Matching" : "MultRacing_Button_Match", Array.Empty<object>());
			}
			ButtonItem multiChallengeBtn2 = this.MultiChallengeBtn;
			if (multiChallengeBtn2 != null)
			{
				multiChallengeBtn2.SetEnableClick(!flag);
			}
			ButtonItem singleChallengeBtn2 = this.SingleChallengeBtn;
			if (singleChallengeBtn2 == null)
			{
				return;
			}
			singleChallengeBtn2.SetEnableClick(!flag);
		}

		// Token: 0x06031EA7 RID: 204455 RVA: 0x00B93ED0 File Offset: 0x00B920D0
		private void RefreshBestRecordPanel(int instanceId)
		{
			TowerDefenseRankGlobalData rankData = TowerDefenseModel.Instance.RankData;
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (!rankData.HasOwnRecord(instanceId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "ChallengeOL_Norecord", Array.Empty<object>());
				return;
			}
			string bestRecordText = rankData.GetBestRecordText(instanceId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "ChallengeOL_Bestrecord", new <>z__ReadOnlySingleElementList<object>(bestRecordText));
		}

		// Token: 0x06031EA8 RID: 204456 RVA: 0x00B93F48 File Offset: 0x00B92148
		private void RefreshBossPanel(int instanceId)
		{
			TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId);
			bool flag = towerDefenseInstanceByInstance != null && towerDefenseInstanceByInstance.Value.BossRush;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			List<int> list = new List<int>();
			if (flag && config != null)
			{
				for (int i = 0; i < config.Value.MonsterPreviewLength; i++)
				{
					list.Add(config.Value.MonsterPreview(i));
				}
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(list.Count > 0);
			}
			GenericScrollViewNew<TowerDefenseLevelBossItem, int> bossScroll = this.BossScroll;
			if (bossScroll == null)
			{
				return;
			}
			bossScroll.RefreshByData(list, null, false);
		}

		// Token: 0x06031EA9 RID: 204457 RVA: 0x00B94000 File Offset: 0x00B92200
		private void RefreshPhantomPanel(int instanceId)
		{
			TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId);
			List<TItem> list = (towerDefenseInstanceByInstance != null && towerDefenseInstanceByInstance.Value.BossRush) ? new List<TItem>() : TowerDefenseController.Instance.BuildPhantomForInstanceDungeonEntranceData(instanceId);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(list.Count > 0);
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> phantomScroll = this.PhantomScroll;
			if (phantomScroll == null)
			{
				return;
			}
			phantomScroll.RefreshByData(list, delegate
			{
				foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.PhantomScroll.GetScrollItemList())
				{
					commonItemSmallItemGrid.SetQuality(null);
					commonItemSmallItemGrid.SetExtendToggleEnable(false, false);
				}
			}, false);
		}

		// Token: 0x06031EAA RID: 204458 RVA: 0x00B94084 File Offset: 0x00B92284
		private void RefreshBuffPanel(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			string text = (config != null) ? (config.Value.MonsterTips ?? "") : "";
			bool flag = config != null && config.Value.MonsterPreviewLength > 0;
			List<string> list = (from line in text.Split('\n', StringSplitOptions.None)
			where line.Length > 0
			select line).ToList<string>();
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(list.Count > 0 || flag);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "PrefabTextItem_2611535427_Text", Array.Empty<object>());
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
			GenericScrollViewNew<TowerDefenseLevelDetailElementItem, string> elementScroll = this.ElementScroll;
			if (elementScroll == null)
			{
				return;
			}
			elementScroll.RefreshByData(list, null, false);
		}

		// Token: 0x06031EAB RID: 204459 RVA: 0x00B94188 File Offset: 0x00B92388
		private void OnClickBtnBuffTips()
		{
			if (this.CurrentInstanceId <= 0)
			{
				return;
			}
			InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam param = new InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam
			{
				InstanceId = this.CurrentInstanceId,
				InfoType = new InstanceDungeonBuffItem.EBuffInfoType?(InstanceDungeonBuffItem.EBuffInfoType.Buff)
			};
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, param, null);
		}

		// Token: 0x06031EAC RID: 204460 RVA: 0x00B941D0 File Offset: 0x00B923D0
		private void OnClickBtnBestRecord()
		{
			if (this.CurrentInstanceId <= 0)
			{
				return;
			}
			TowerDefenseRankViewModelV2 towerDefenseRankViewModelV = new TowerDefenseRankViewModelV2();
			towerDefenseRankViewModelV.InstanceId = this.CurrentInstanceId;
			UiManager.Instance.OpenView(EUiViewName.TowerDefenseRankViewV2, towerDefenseRankViewModelV, null);
		}

		// Token: 0x06031EAD RID: 204461 RVA: 0x00B9420A File Offset: 0x00B9240A
		private bool GetIsAllowedClickBegin()
		{
			if (this.NextCanClickButtonTime > TimeUtil.Instance.GetServerTimeStamp())
			{
				return false;
			}
			this.NextCanClickButtonTime = TimeUtil.Instance.GetServerTimeStamp() + 500.0;
			return true;
		}

		// Token: 0x06031EAE RID: 204462 RVA: 0x00B9423C File Offset: 0x00B9243C
		private bool CheckOnlineChallengeGuard()
		{
			if (!OnlineController.Instance.ShowTipsWhenOnlineDisabled(null))
			{
				return false;
			}
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(this.CurrentInstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonLackChallengeTimes", Array.Empty<object>());
				return false;
			}
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return false;
			}
			if (!FunctionModel.Instance.IsOpen(EFunctionType.Online))
			{
				ScrollingTipsController.Instance.ShowTipsById("IsNotOpenOnline", Array.Empty<object>());
				return false;
			}
			if (InstanceDungeonController.Instance.IsForbidDungeon(this.CurrentInstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06031EAF RID: 204463 RVA: 0x00B942F4 File Offset: 0x00B924F4
		private bool CheckSoloChallengeGuard()
		{
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(this.CurrentInstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonLackChallengeTimes", Array.Empty<object>());
				return false;
			}
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return false;
			}
			if (InstanceDungeonController.Instance.IsForbidDungeon(this.CurrentInstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06031EB0 RID: 204464 RVA: 0x00B94374 File Offset: 0x00B92574
		private void OnClickBtnMultiChallenge()
		{
			if (this.CurrentInstanceId <= 0 || !this.GetIsAllowedClickBegin())
			{
				return;
			}
			if (!this.CheckOnlineChallengeGuard())
			{
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			InstanceDungeonModel.Instance.InstanceContinue = false;
			if (!GameModeModel.Instance.IsMulti)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(this.CurrentInstanceId, false, true);
				return;
			}
			int currentTeamSize = OnlineModel.Instance.GetCurrentTeamSize();
			if (currentTeamSize <= 1)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(this.CurrentInstanceId, false, true);
				return;
			}
			if (currentTeamSize < OnlineModel.Instance.TeamMaxSize)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMatchStart);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.StartMatchRequest(this.CurrentInstanceId, true, true);
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					InstanceDungeonEntranceController.Instance.StartMatchRequest(this.CurrentInstanceId, false, true);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("CanNotMatching", Array.Empty<object>());
		}

		// Token: 0x06031EB1 RID: 204465 RVA: 0x00B9446C File Offset: 0x00B9266C
		private void OnClickBtnSingleChallenge()
		{
			if (this.CurrentInstanceId <= 0 || !this.GetIsAllowedClickBegin())
			{
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				if (!this.CheckOnlineChallengeGuard())
				{
					return;
				}
				BattleTeamModel.Instance.Context.SetMultiEntry(true);
				InstanceDungeonModel.Instance.InstanceContinue = false;
				InstanceDungeonEntranceModel.Instance.SetMatchingId(this.CurrentInstanceId);
				if (OnlineModel.Instance.GetCurrentTeamSize() <= 1)
				{
					InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.CurrentInstanceId, false);
					return;
				}
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMultiStart);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.CurrentInstanceId, true);
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.CurrentInstanceId, false);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			else
			{
				if (!this.CheckSoloChallengeGuard())
				{
					return;
				}
				BattleTeamModel.Instance.Context.SetMultiEntry(false);
				InstanceDungeonModel.Instance.InstanceContinue = false;
				InstanceDungeonEntranceModel.Instance.InstanceId = this.CurrentInstanceId;
				InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
				return;
			}
		}

		// Token: 0x0401A9EA RID: 109034
		private const int CLICK_INSTANCE_BEGIN_BUTTON_CD = 500;

		// Token: 0x0401A9EB RID: 109035
		private int CurrentInstanceId;

		// Token: 0x0401A9EC RID: 109036
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TowerDefenseLevelDetailElementItem, string> ElementScroll;

		// Token: 0x0401A9ED RID: 109037
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> PhantomScroll;

		// Token: 0x0401A9EE RID: 109038
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<TowerDefenseLevelBossItem, int> BossScroll;

		// Token: 0x0401A9EF RID: 109039
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0401A9F0 RID: 109040
		private ButtonItem MultiChallengeBtn;

		// Token: 0x0401A9F1 RID: 109041
		private ButtonItem SingleChallengeBtn;

		// Token: 0x0401A9F2 RID: 109042
		private bool ShouldShowSingleChallengeBtn;

		// Token: 0x0401A9F3 RID: 109043
		private double NextCanClickButtonTime;

		// Token: 0x0200ACCA RID: 44234
		[NullableContext(0)]
		private class ELevelDetailComponent
		{
			// Token: 0x040347EC RID: 215020
			public const int TitleTxt = 0;

			// Token: 0x040347ED RID: 215021
			public const int TopDescTxt = 1;

			// Token: 0x040347EE RID: 215022
			public const int BuffPnl = 2;

			// Token: 0x040347EF RID: 215023
			public const int BuffTitleTxt = 3;

			// Token: 0x040347F0 RID: 215024
			public const int BuffTipsBtn = 4;

			// Token: 0x040347F1 RID: 215025
			public const int ElementScorll = 5;

			// Token: 0x040347F2 RID: 215026
			public const int ElementItem = 6;

			// Token: 0x040347F3 RID: 215027
			public const int PhantomPnl = 7;

			// Token: 0x040347F4 RID: 215028
			public const int PhantomScroll = 8;

			// Token: 0x040347F5 RID: 215029
			public const int PhantomItem = 9;

			// Token: 0x040347F6 RID: 215030
			public const int BossPnl = 10;

			// Token: 0x040347F7 RID: 215031
			public const int BossScroll = 11;

			// Token: 0x040347F8 RID: 215032
			public const int BossItem = 12;

			// Token: 0x040347F9 RID: 215033
			public const int BestRecordPnl = 13;

			// Token: 0x040347FA RID: 215034
			public const int BestRecordBtn = 14;

			// Token: 0x040347FB RID: 215035
			public const int BestRecordTxt = 15;

			// Token: 0x040347FC RID: 215036
			public const int LevelTipsPnl = 16;

			// Token: 0x040347FD RID: 215037
			public const int LevelTipsTxt = 17;

			// Token: 0x040347FE RID: 215038
			public const int MultiChallengeBtn = 18;

			// Token: 0x040347FF RID: 215039
			public const int SingleChallengeBtn = 19;

			// Token: 0x04034800 RID: 215040
			public const int LockPnl = 20;
		}
	}
}
