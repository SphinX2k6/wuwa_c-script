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
	// Token: 0x02003B05 RID: 15109
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerDefenseSubView : ActivitySubViewBase
	{
		// Token: 0x06026CCE RID: 158926 RVA: 0x00ADBB08 File Offset: 0x00AD9D08
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

		// Token: 0x06026CCF RID: 158927 RVA: 0x00ADBC37 File Offset: 0x00AD9E37
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshRewardRedDot));
		}

		// Token: 0x06026CD0 RID: 158928 RVA: 0x00ADBC55 File Offset: 0x00AD9E55
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshRewardRedDot));
		}

		// Token: 0x06026CD1 RID: 158929 RVA: 0x00ADBC74 File Offset: 0x00AD9E74
		private UniTask LoadBgResource()
		{
			TowerDefenseSubView.<LoadBgResource>d__8 <LoadBgResource>d__;
			<LoadBgResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBgResource>d__.<>4__this = this;
			<LoadBgResource>d__.<>1__state = -1;
			<LoadBgResource>d__.<>t__builder.Start<TowerDefenseSubView.<LoadBgResource>d__8>(ref <LoadBgResource>d__);
			return <LoadBgResource>d__.<>t__builder.Task;
		}

		// Token: 0x06026CD2 RID: 158930 RVA: 0x00ADBCB8 File Offset: 0x00AD9EB8
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CD3 RID: 158931 RVA: 0x00ADBCFC File Offset: 0x00AD9EFC
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

		// Token: 0x06026CD4 RID: 158932 RVA: 0x00ADBD50 File Offset: 0x00AD9F50
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
			this.RefreshFunctionalComponent();
		}

		// Token: 0x06026CD5 RID: 158933 RVA: 0x00ADBD60 File Offset: 0x00AD9F60
		private void TryShowNewUnlockTips()
		{
			if (TowerDefenseController.Instance.GetIsFirstOpen())
			{
				DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
				difficultUnlockTipsData.Text = "BossRushUnlockTips";
				UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
			}
		}

		// Token: 0x06026CD6 RID: 158934 RVA: 0x00ADBD9C File Offset: 0x00AD9F9C
		private void RefreshTitle()
		{
			string activitySubViewTitle = TowerDefenseController.Instance.GetActivitySubViewTitle();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(activitySubViewTitle);
		}

		// Token: 0x06026CD7 RID: 158935 RVA: 0x00ADBDD4 File Offset: 0x00AD9FD4
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

		// Token: 0x06026CD8 RID: 158936 RVA: 0x00ADBE10 File Offset: 0x00ADA010
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

		// Token: 0x06026CD9 RID: 158937 RVA: 0x00ADBE74 File Offset: 0x00ADA074
		private void RefreshReward()
		{
			List<TItem> activityPreviewReward = TowerDefenseController.Instance.GetActivityPreviewReward();
			this.RewardListComponent.SetTitleByTextId("FragmentMemoryCollectReward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(activityPreviewReward, null);
		}

		// Token: 0x06026CDA RID: 158938 RVA: 0x00ADBEC8 File Offset: 0x00ADA0C8
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

		// Token: 0x06026CDB RID: 158939 RVA: 0x00ADBFD2 File Offset: 0x00ADA1D2
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

		// Token: 0x06026CDC RID: 158940 RVA: 0x00ADBFF0 File Offset: 0x00ADA1F0
		[NullableContext(1)]
		private void RefreshRewardRedDot(IActivityRewardViewData activityRewardViewData = null)
		{
			this.RewardButtonItem.SetRedDotVisible(TowerDefenseController.Instance.CheckHasReward());
		}

		// Token: 0x06026CDD RID: 158941 RVA: 0x00ADC007 File Offset: 0x00ADA207
		private void RefreshButtonRedDot()
		{
			this.FunctionalComponent.SetFunctionRedDotVisible(TowerDefenseController.Instance.CheckHasNewStage());
		}

		// Token: 0x0401537D RID: 86909
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401537E RID: 86910
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401537F RID: 86911
		private ActivityButtonItem RewardButtonItem;

		// Token: 0x04015380 RID: 86912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04015381 RID: 86913
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0200970B RID: 38667
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F255 RID: 193109
			public const int TitleItem = 0;

			// Token: 0x0402F256 RID: 193110
			public const int DescItem = 1;

			// Token: 0x0402F257 RID: 193111
			public const int RewardItem = 2;

			// Token: 0x0402F258 RID: 193112
			public const int FunctionalAreaItem = 3;

			// Token: 0x0402F259 RID: 193113
			public const int BgAttachItem = 4;

			// Token: 0x0402F25A RID: 193114
			public const int RewardButtonItem = 5;

			// Token: 0x0402F25B RID: 193115
			public const int TipsItem = 6;

			// Token: 0x0402F25C RID: 193116
			public const int TipsText = 7;
		}
	}
}
