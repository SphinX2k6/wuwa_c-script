using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B5D RID: 19293
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerDefenseSubView : ActivitySubViewBase
	{
		// Token: 0x06031F3F RID: 204607 RVA: 0x00B978CC File Offset: 0x00B95ACC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F40 RID: 204608 RVA: 0x00B979FB File Offset: 0x00B95BFB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshRewardRedDot));
		}

		// Token: 0x06031F41 RID: 204609 RVA: 0x00B97A19 File Offset: 0x00B95C19
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshRewardRedDot));
		}

		// Token: 0x06031F42 RID: 204610 RVA: 0x00B97A38 File Offset: 0x00B95C38
		private UniTask LoadBgResource()
		{
			TowerDefenseSubView.<LoadBgResource>d__8 <LoadBgResource>d__;
			<LoadBgResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBgResource>d__.<>4__this = this;
			<LoadBgResource>d__.<>1__state = -1;
			<LoadBgResource>d__.<>t__builder.Start<TowerDefenseSubView.<LoadBgResource>d__8>(ref <LoadBgResource>d__);
			return <LoadBgResource>d__.<>t__builder.Task;
		}

		// Token: 0x06031F43 RID: 204611 RVA: 0x00B97A7C File Offset: 0x00B95C7C
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F44 RID: 204612 RVA: 0x00B97AC0 File Offset: 0x00B95CC0
		protected override void OnRefreshView()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshTimerText();
			this.RefreshReward();
			this.RefreshFunctionalComponent();
			this.TryShowNewUnlockTips();
			this.RefreshRewardRedDot(null);
			this.RefreshButtonRedDot();
		}

		// Token: 0x06031F45 RID: 204613 RVA: 0x00B97B14 File Offset: 0x00B95D14
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
			this.RefreshFunctionalComponent();
		}

		// Token: 0x06031F46 RID: 204614 RVA: 0x00B97B24 File Offset: 0x00B95D24
		private void TryShowNewUnlockTips()
		{
			if (TowerDefenseController.Instance.GetIsFirstOpen())
			{
				DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
				difficultUnlockTipsData.Text = "BossRushUnlockTips";
				UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
			}
		}

		// Token: 0x06031F47 RID: 204615 RVA: 0x00B97B60 File Offset: 0x00B95D60
		private void RefreshTitle()
		{
			string activitySubViewTitle = TowerDefenseController.Instance.GetActivitySubViewTitle();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(activitySubViewTitle);
		}

		// Token: 0x06031F48 RID: 204616 RVA: 0x00B97B98 File Offset: 0x00B95D98
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06031F49 RID: 204617 RVA: 0x00B97BD4 File Offset: 0x00B95DD4
		private void RefreshDesc()
		{
			Activity activityCfg = TowerDefenseController.Instance.GetActivityCfg();
			string descTheme = activityCfg.DescTheme;
			string desc = activityCfg.Desc;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.DescriptionComponent.SetContentVisible(flag);
			if (flag)
			{
				this.DescriptionComponent.SetContentByTextId(descTheme, Array.Empty<string>());
			}
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		}

		// Token: 0x06031F4A RID: 204618 RVA: 0x00B97C38 File Offset: 0x00B95E38
		private void RefreshReward()
		{
			List<TItem> activityPreviewReward = TowerDefenseController.Instance.GetActivityPreviewReward();
			this.RewardListComponent.SetTitleByTextId("FragmentMemoryCollectReward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(activityPreviewReward, null);
		}

		// Token: 0x06031F4B RID: 204619 RVA: 0x00B97C8C File Offset: 0x00B95E8C
		private void RefreshFunctionalComponent()
		{
			if (!TowerDefenseController.Instance.CheckActivityUnlockByMulti())
			{
				this.FunctionalComponent.SetPanelConditionVisible(true);
				this.FunctionalComponent.SetLockTextByTextId("TowerDefence_Cantplay", Array.Empty<string>());
				this.RewardButtonItem.SetUiActive(false);
				this.FunctionalComponent.FunctionButton.SetUiActive(false);
				return;
			}
			bool flag = TowerDefenseController.Instance.CheckActivityUnlockByCondition();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			this.FunctionalComponent.FunctionButton.SetUiActive(flag);
			if (flag)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
				this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			}
			else
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
			ValueTuple<int, int> previewRewardCount = TowerDefenseModel.Instance.GetPreviewRewardCount();
			this.RewardButtonItem.SetText(previewRewardCount.Item1.ToString() + "/" + previewRewardCount.Item2.ToString());
			this.RewardButtonItem.SetUiActive(flag);
		}

		// Token: 0x06031F4C RID: 204620 RVA: 0x00B97D96 File Offset: 0x00B95F96
		private void HandleOnClickConfirm()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				TowerDefenseModel.Instance.IsEnterInActivityClicked = true;
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				TowerDefenseConfig? towerDefenseConfigByActivityId = InstanceDungeonConfig.Instance.GetTowerDefenseConfigByActivityId(this.ActivityBaseData.Id);
				if (towerDefenseConfigByActivityId.Value.EntranceId != 0)
				{
					InstanceDungeonEntranceController.Instance.EnterEntrance(towerDefenseConfigByActivityId.Value.EntranceId, 0, null);
					return;
				}
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkId = new int?(TowerDefenseController.Instance.GetMarkIdByActivityId(this.ActivityBaseData.Id)),
					MarkType = EMarkType.None,
					OpenFogId = new int?(0)
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			});
		}

		// Token: 0x06031F4D RID: 204621 RVA: 0x00B97DB4 File Offset: 0x00B95FB4
		[NullableContext(1)]
		private void RefreshRewardRedDot(IActivityRewardViewData activityRewardViewData = null)
		{
			this.RewardButtonItem.SetRedDotVisible(TowerDefenseController.Instance.CheckHasReward());
		}

		// Token: 0x06031F4E RID: 204622 RVA: 0x00B97DCB File Offset: 0x00B95FCB
		private void RefreshButtonRedDot()
		{
			this.FunctionalComponent.SetFunctionRedDotVisible(TowerDefenseController.Instance.CheckHasNewStage());
		}

		// Token: 0x0401AA2B RID: 109099
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401AA2C RID: 109100
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401AA2D RID: 109101
		private ActivityButtonItem RewardButtonItem;

		// Token: 0x0401AA2E RID: 109102
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401AA2F RID: 109103
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0200ACEC RID: 44268
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040348AC RID: 215212
			public const int TitleItem = 0;

			// Token: 0x040348AD RID: 215213
			public const int DescItem = 1;

			// Token: 0x040348AE RID: 215214
			public const int RewardItem = 2;

			// Token: 0x040348AF RID: 215215
			public const int FunctionalAreaItem = 3;

			// Token: 0x040348B0 RID: 215216
			public const int BgAttachItem = 4;

			// Token: 0x040348B1 RID: 215217
			public const int RewardButtonItem = 5;

			// Token: 0x040348B2 RID: 215218
			public const int TipsItem = 6;

			// Token: 0x040348B3 RID: 215219
			public const int TipsText = 7;
		}
	}
}
