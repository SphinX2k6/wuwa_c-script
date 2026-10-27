using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x020063A1 RID: 25505
	[NullableContext(2)]
	[Nullable(0)]
	public class MultiMotorSubView : ActivitySubViewBase
	{
		// Token: 0x06040256 RID: 262742 RVA: 0x00F87C10 File Offset: 0x00F85E10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040257 RID: 262743 RVA: 0x00F87E04 File Offset: 0x00F86004
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040258 RID: 262744 RVA: 0x00F87E47 File Offset: 0x00F86047
		protected override void OnStart()
		{
		}

		// Token: 0x06040259 RID: 262745 RVA: 0x00F87E4C File Offset: 0x00F8604C
		protected override void OnRefreshView()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshReward();
			this.RefreshFunctionalComponent();
			this.RefreshState();
			this.RefreshRewardRedDot();
			this.RefreshLevelCount();
			this.RefreshRecommendQuestTips();
			this.RefreshRewardText();
		}

		// Token: 0x0604025A RID: 262746 RVA: 0x00F87EA8 File Offset: 0x00F860A8
		private void RefreshRecommendQuestTips()
		{
			bool flag = this.IsShowPreOpenTips();
			this.RecommendQuestTipsSubPanelInst.SetUiActive(flag);
			if (flag)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("MultiMotorPreQuestTips");
				this.RecommendQuestTipsSubPanelInst.SetTipsTxtByTextId(stringConfig, Array.Empty<string>());
			}
		}

		// Token: 0x0604025B RID: 262747 RVA: 0x00F87EE8 File Offset: 0x00F860E8
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x0604025C RID: 262748 RVA: 0x00F87F14 File Offset: 0x00F86114
		private void RefreshLevelCount()
		{
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(multiMotorData.FinishedLevelCount.ToString(), true);
			}
			UUIText text2 = base.GetText(6);
			if (text2 == null)
			{
				return;
			}
			text2.SetText("/" + multiMotorData.TotalLevelCount.ToString(), true);
		}

		// Token: 0x0604025D RID: 262749 RVA: 0x00F87F78 File Offset: 0x00F86178
		private void RefreshRewardRedDot()
		{
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(multiMotorData != null && multiMotorData.HasAnyRewardRedDot);
		}

		// Token: 0x0604025E RID: 262750 RVA: 0x00F87FB0 File Offset: 0x00F861B0
		private void RefreshRewardText()
		{
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			Dictionary<int, MultiMotorTaskData> dictionary = (multiMotorData != null) ? multiMotorData.TaskDataMap : null;
			int num = 0;
			int num2 = 0;
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in dictionary)
				{
					num++;
					if (keyValuePair.Value.IsReceived)
					{
						num2++;
					}
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "MultRacing_RewardCollectedlAmount", new <>z__ReadOnlySingleElementList<object>(num2.ToString()));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "MultRacing_RewardTotalAmount", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
		}

		// Token: 0x0604025F RID: 262751 RVA: 0x00F88074 File Offset: 0x00F86274
		private void RefreshDesc()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			string descTheme = localConfig.Value.DescTheme;
			string desc = localConfig.Value.Desc;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		}

		// Token: 0x06040260 RID: 262752 RVA: 0x00F880EC File Offset: 0x00F862EC
		private void RefreshTitle()
		{
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06040261 RID: 262753 RVA: 0x00F88150 File Offset: 0x00F86350
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06040262 RID: 262754 RVA: 0x00F88190 File Offset: 0x00F86390
		private void RefreshFunctionalComponent()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData != null && activityBaseData.GetPreGuideQuestFinishState();
			this.FunctionalComponent.SetFunctionRedDotVisible(flag && (multiMotorData.HasAnyLevelRedDot || multiMotorData.HasAnyRewardRedDot));
		}

		// Token: 0x06040263 RID: 262755 RVA: 0x00F881FB File Offset: 0x00F863FB
		protected override void OnTimer(float gap)
		{
			base.OnTimer(gap);
			this.RefreshTitle();
		}

		// Token: 0x06040264 RID: 262756 RVA: 0x00F8820A File Offset: 0x00F8640A
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("MultiMotorOnlineDisable", Array.Empty<object>());
					return;
				}
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.MultiMotorChoseLevelView, null, null);
			});
		}

		// Token: 0x06040265 RID: 262757 RVA: 0x00F88228 File Offset: 0x00F86428
		private void OnClickBtnReward()
		{
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			List<MultiMotorLevelData> levelDataList = multiMotorData.GetLevelDataList();
			if (levelDataList.Count > 0)
			{
				IMultiMotorParkourRewardViewData param = new IMultiMotorParkourRewardViewData
				{
					ActivityData = multiMotorData,
					SelectLevelData = levelDataList[0]
				};
				UiManager.Instance.OpenView(EUiViewName.MultiMotorRewardView, param, null);
			}
		}

		// Token: 0x06040266 RID: 262758 RVA: 0x00F8827C File Offset: 0x00F8647C
		private void RefreshState()
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			bool flag = this.ActivityBaseData.IsUnLock();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			this.FunctionalComponent.FunctionButton.SetUiActive(flag);
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
			base.GetButton(4).RootUIComp.Get().SetUIActive(flag);
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(flag);
		}

		// Token: 0x06040267 RID: 262759 RVA: 0x00F8832C File Offset: 0x00F8652C
		private void OnRecommendBtnClick()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("MultiMotorPreQuestId");
			if (QuestNewModel.Instance.GetQuest(intConfig.Value) == null)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("MultiMotorPreQuestTips");
				ScrollingTipsController.Instance.ShowTipsByTextId(stringConfig, Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, intConfig, null);
		}

		// Token: 0x040216B9 RID: 136889
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x040216BA RID: 136890
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x040216BB RID: 136891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x040216BC RID: 136892
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x040216BD RID: 136893
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanelInst;

		// Token: 0x0200C5BE RID: 50622
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BB47 RID: 244551
			public const int TitleItem = 0;

			// Token: 0x0403BB48 RID: 244552
			public const int DescItem = 1;

			// Token: 0x0403BB49 RID: 244553
			public const int RewardItem = 2;

			// Token: 0x0403BB4A RID: 244554
			public const int FunctionalAreaItem = 3;

			// Token: 0x0403BB4B RID: 244555
			public const int RewardBtn = 4;

			// Token: 0x0403BB4C RID: 244556
			public const int FinishLevelText = 5;

			// Token: 0x0403BB4D RID: 244557
			public const int MaxLevelText = 6;

			// Token: 0x0403BB4E RID: 244558
			public const int RewardRedDotItem = 7;

			// Token: 0x0403BB4F RID: 244559
			public const int PreOpenTipsItem = 8;

			// Token: 0x0403BB50 RID: 244560
			public const int RewardBtnText1 = 9;

			// Token: 0x0403BB51 RID: 244561
			public const int RewardBtnText2 = 10;

			// Token: 0x0403BB52 RID: 244562
			public const int FinishLevelItem = 11;
		}
	}
}
