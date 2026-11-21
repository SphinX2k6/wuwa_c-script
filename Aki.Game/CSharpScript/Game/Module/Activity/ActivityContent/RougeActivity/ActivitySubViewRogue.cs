using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x02005130 RID: 20784
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRogue : ActivitySubViewBase
	{
		// Token: 0x06033F49 RID: 212809 RVA: 0x00E889D0 File Offset: 0x00E86BD0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnBtnAchievement)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnBtnShop))
			};
		}

		// Token: 0x06033F4A RID: 212810 RVA: 0x00E88B18 File Offset: 0x00E86D18
		protected void OnBtnAchievement()
		{
			if (ActivityRogueController.Instance.GetCurrentActivityData().GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			ActivityRogueData activityRogueData = this.ActivityBaseData as ActivityRogueData;
			RogueSeasonData rogueSeasonData = (activityRogueData != null) ? activityRogueData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			if (RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId).Value.Achievement == 0)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeAchievementView, null, null);
		}

		// Token: 0x06033F4B RID: 212811 RVA: 0x00E88B9C File Offset: 0x00E86D9C
		protected void OnBtnShop()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			if (currentActivityData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
			if (rogueSeasonConfigById.Value.ShopId == 0)
			{
				return;
			}
			PayShopViewData payShopViewData = new PayShopViewData();
			payShopViewData.ShowShopIdList = new List<int>
			{
				rogueSeasonConfigById.Value.ShopId
			};
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)rogueSeasonConfigById.Value.ShopId;
			RoguelikeModel.Instance.RecordRoguelikeShopRedDot();
			PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		}

		// Token: 0x06033F4C RID: 212812 RVA: 0x00E88C5A File Offset: 0x00E86E5A
		protected override void OnSetData()
		{
		}

		// Token: 0x06033F4D RID: 212813 RVA: 0x00E88C5C File Offset: 0x00E86E5C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRogue.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRogue.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F4E RID: 212814 RVA: 0x00E88CA0 File Offset: 0x00E86EA0
		protected override void OnStart()
		{
			Activity? localConfig = (this.ActivityBaseData as ActivityRogueData).LocalConfig;
			RogueActivity? extraConfig = (this.ActivityBaseData as ActivityRogueData).GetExtraConfig();
			if (localConfig == null || extraConfig == null)
			{
				return;
			}
			string descTheme = localConfig.Value.DescTheme;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData as ActivityRogueData);
			this.TitleComponent.SetTitleByText((this.ActivityBaseData as ActivityRogueData).GetTitle());
			string desc = localConfig.Value.Desc;
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
			List<TItem> previewReward = (this.ActivityBaseData as ActivityRogueData).GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			this.OnRefreshView();
		}

		// Token: 0x06033F4F RID: 212815 RVA: 0x00E88E0C File Offset: 0x00E8700C
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivitySubViewRogue.<OnBeforeHideSelfAsync>d__11 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewRogue.<OnBeforeHideSelfAsync>d__11>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F50 RID: 212816 RVA: 0x00E88E48 File Offset: 0x00E87048
		protected override void OnRefreshView()
		{
			this.RefreshCondition();
			this.RefreshTimerText();
			this.RefreshRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.RoguelikeAchievement, base.GetItem(6), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RoguelikeShop, base.GetItem(7), delegate(bool newState, int _)
			{
				UUIItem item = base.GetItem(7);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(newState);
			}, 0);
			bool preGuideQuestFinishState = (this.ActivityBaseData as ActivityRogueData).GetPreGuideQuestFinishState();
			base.GetItem(8).SetUIActive(preGuideQuestFinishState);
			base.GetItem(9).SetUIActive(preGuideQuestFinishState);
		}

		// Token: 0x06033F51 RID: 212817 RVA: 0x00E88EC8 File Offset: 0x00E870C8
		protected override void OnTimer(float gap)
		{
			this.RefreshCondition();
			this.RefreshTimerText();
			this.RefreshRedDot();
		}

		// Token: 0x06033F52 RID: 212818 RVA: 0x00E88EDC File Offset: 0x00E870DC
		private void RefreshRedDot()
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			functionalComponent.SetFunctionRedDotVisible((this.ActivityBaseData as ActivityRogueData).RedPointShowState);
		}

		// Token: 0x06033F53 RID: 212819 RVA: 0x00E88F00 File Offset: 0x00E87100
		private void RefreshTimerText()
		{
			string item = this.GetTimeVisibleAndRemainTime().Item2;
			this.TitleComponent.SetTimeTextByText(item);
		}

		// Token: 0x06033F54 RID: 212820 RVA: 0x00E88F25 File Offset: 0x00E87125
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				bool preGuideQuestFinishState = (this.ActivityBaseData as ActivityRogueData).GetPreGuideQuestFinishState();
				ERogueActivityState rogueActivityState = (this.ActivityBaseData as ActivityRogueData).GetRogueActivityState();
				if (!preGuideQuestFinishState && rogueActivityState == ERogueActivityState.Open)
				{
					int unFinishPreGuideQuestId = (this.ActivityBaseData as ActivityRogueData).GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				}
				else
				{
					ActivityRogueController.Instance.ActivityFunctionExecute((this.ActivityBaseData as ActivityRogueData).Id);
				}
				(this.ActivityBaseData as ActivityRogueData).FunctionBtnRedDot = false;
			});
		}

		// Token: 0x06033F55 RID: 212821 RVA: 0x00E88F44 File Offset: 0x00E87144
		private void RefreshCondition()
		{
			RogueActivity? extraConfig = (this.ActivityBaseData as ActivityRogueData).GetExtraConfig();
			if (extraConfig == null)
			{
				return;
			}
			bool flag = (this.ActivityBaseData as ActivityRogueData).IsUnLock();
			bool flag2 = extraConfig.Value.FunctionType == 0;
			if (!flag)
			{
				ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetUiActive(false);
				}
				this.FunctionalComponent.SetPerformanceConditionLock((this.ActivityBaseData as ActivityRogueData).ConditionGroupId, (this.ActivityBaseData as ActivityRogueData).Id);
				return;
			}
			if (flag2)
			{
				ActivityButtonItem functionButton2 = this.FunctionalComponent.FunctionButton;
				if (functionButton2 != null)
				{
					functionButton2.SetUiActive(false);
				}
				this.FunctionalComponent.SetPanelConditionVisible(false);
				return;
			}
			ERogueActivityState rogueActivityState = (this.ActivityBaseData as ActivityRogueData).GetRogueActivityState();
			ActivityButtonItem functionButton3 = this.FunctionalComponent.FunctionButton;
			if (functionButton3 != null)
			{
				functionButton3.SetUiActive(rogueActivityState != ERogueActivityState.Close);
			}
			this.FunctionalComponent.SetPanelConditionVisible(rogueActivityState == ERogueActivityState.Close);
			this.FunctionalComponent.SetLockTextByTextId("Rogue_Function_End_Tip", Array.Empty<string>());
		}

		// Token: 0x0401B7EE RID: 112622
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401B7EF RID: 112623
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401B7F0 RID: 112624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401B7F1 RID: 112625
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401B7F2 RID: 112626
		private RoguelikeBlackFlowerItem BlackFlowerComponent;
	}
}
