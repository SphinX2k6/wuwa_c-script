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
	// Token: 0x0200531F RID: 21279
	[NullableContext(2)]
	[Nullable(0)]
	public class MultiMotorSubView : ActivitySubViewBase
	{
		// Token: 0x06034F17 RID: 216855 RVA: 0x00ECEB48 File Offset: 0x00ECCD48
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

		// Token: 0x06034F18 RID: 216856 RVA: 0x00ECED3C File Offset: 0x00ECCF3C
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F19 RID: 216857 RVA: 0x00ECED7F File Offset: 0x00ECCF7F
		protected override void OnStart()
		{
		}

		// Token: 0x06034F1A RID: 216858 RVA: 0x00ECED84 File Offset: 0x00ECCF84
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

		// Token: 0x06034F1B RID: 216859 RVA: 0x00ECEDE0 File Offset: 0x00ECCFE0
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

		// Token: 0x06034F1C RID: 216860 RVA: 0x00ECEE20 File Offset: 0x00ECD020
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x06034F1D RID: 216861 RVA: 0x00ECEE4C File Offset: 0x00ECD04C
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

		// Token: 0x06034F1E RID: 216862 RVA: 0x00ECEEB0 File Offset: 0x00ECD0B0
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

		// Token: 0x06034F1F RID: 216863 RVA: 0x00ECEEE8 File Offset: 0x00ECD0E8
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

		// Token: 0x06034F20 RID: 216864 RVA: 0x00ECEFAC File Offset: 0x00ECD1AC
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

		// Token: 0x06034F21 RID: 216865 RVA: 0x00ECF024 File Offset: 0x00ECD224
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

		// Token: 0x06034F22 RID: 216866 RVA: 0x00ECF088 File Offset: 0x00ECD288
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06034F23 RID: 216867 RVA: 0x00ECF0C8 File Offset: 0x00ECD2C8
		private void RefreshFunctionalComponent()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			MultiMotorData multiMotorData = this.ActivityBaseData as MultiMotorData;
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData != null && activityBaseData.GetPreGuideQuestFinishState();
			this.FunctionalComponent.SetFunctionRedDotVisible(flag && (multiMotorData.HasAnyLevelRedDot || multiMotorData.HasAnyRewardRedDot));
		}

		// Token: 0x06034F24 RID: 216868 RVA: 0x00ECF133 File Offset: 0x00ECD333
		protected override void OnTimer(float gap)
		{
			base.OnTimer(gap);
			this.RefreshTitle();
		}

		// Token: 0x06034F25 RID: 216869 RVA: 0x00ECF142 File Offset: 0x00ECD342
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

		// Token: 0x06034F26 RID: 216870 RVA: 0x00ECF160 File Offset: 0x00ECD360
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

		// Token: 0x06034F27 RID: 216871 RVA: 0x00ECF1B4 File Offset: 0x00ECD3B4
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

		// Token: 0x06034F28 RID: 216872 RVA: 0x00ECF264 File Offset: 0x00ECD464
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

		// Token: 0x0401BFE8 RID: 114664
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401BFE9 RID: 114665
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401BFEA RID: 114666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401BFEB RID: 114667
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401BFEC RID: 114668
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanelInst;

		// Token: 0x0200AFA5 RID: 44965
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040364A6 RID: 222374
			public const int TitleItem = 0;

			// Token: 0x040364A7 RID: 222375
			public const int DescItem = 1;

			// Token: 0x040364A8 RID: 222376
			public const int RewardItem = 2;

			// Token: 0x040364A9 RID: 222377
			public const int FunctionalAreaItem = 3;

			// Token: 0x040364AA RID: 222378
			public const int RewardBtn = 4;

			// Token: 0x040364AB RID: 222379
			public const int FinishLevelText = 5;

			// Token: 0x040364AC RID: 222380
			public const int MaxLevelText = 6;

			// Token: 0x040364AD RID: 222381
			public const int RewardRedDotItem = 7;

			// Token: 0x040364AE RID: 222382
			public const int PreOpenTipsItem = 8;

			// Token: 0x040364AF RID: 222383
			public const int RewardBtnText1 = 9;

			// Token: 0x040364B0 RID: 222384
			public const int RewardBtnText2 = 10;

			// Token: 0x040364B1 RID: 222385
			public const int FinishLevelItem = 11;
		}
	}
}
