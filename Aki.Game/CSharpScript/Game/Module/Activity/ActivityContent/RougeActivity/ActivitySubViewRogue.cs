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
	// Token: 0x020061B2 RID: 25010
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRogue : ActivitySubViewBase
	{
		// Token: 0x0603F289 RID: 258697 RVA: 0x00F41B04 File Offset: 0x00F3FD04
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

		// Token: 0x0603F28A RID: 258698 RVA: 0x00F41C4C File Offset: 0x00F3FE4C
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

		// Token: 0x0603F28B RID: 258699 RVA: 0x00F41CD0 File Offset: 0x00F3FED0
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

		// Token: 0x0603F28C RID: 258700 RVA: 0x00F41D8E File Offset: 0x00F3FF8E
		protected override void OnSetData()
		{
		}

		// Token: 0x0603F28D RID: 258701 RVA: 0x00F41D90 File Offset: 0x00F3FF90
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRogue.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRogue.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F28E RID: 258702 RVA: 0x00F41DD4 File Offset: 0x00F3FFD4
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

		// Token: 0x0603F28F RID: 258703 RVA: 0x00F41F40 File Offset: 0x00F40140
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivitySubViewRogue.<OnBeforeHideSelfAsync>d__11 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewRogue.<OnBeforeHideSelfAsync>d__11>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F290 RID: 258704 RVA: 0x00F41F7C File Offset: 0x00F4017C
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

		// Token: 0x0603F291 RID: 258705 RVA: 0x00F41FFC File Offset: 0x00F401FC
		protected override void OnTimer(float gap)
		{
			this.RefreshCondition();
			this.RefreshTimerText();
			this.RefreshRedDot();
		}

		// Token: 0x0603F292 RID: 258706 RVA: 0x00F42010 File Offset: 0x00F40210
		private void RefreshRedDot()
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			functionalComponent.SetFunctionRedDotVisible((this.ActivityBaseData as ActivityRogueData).RedPointShowState);
		}

		// Token: 0x0603F293 RID: 258707 RVA: 0x00F42034 File Offset: 0x00F40234
		private void RefreshTimerText()
		{
			string item = this.GetTimeVisibleAndRemainTime().Item2;
			this.TitleComponent.SetTimeTextByText(item);
		}

		// Token: 0x0603F294 RID: 258708 RVA: 0x00F42059 File Offset: 0x00F40259
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

		// Token: 0x0603F295 RID: 258709 RVA: 0x00F42078 File Offset: 0x00F40278
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

		// Token: 0x04020EC1 RID: 134849
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04020EC2 RID: 134850
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04020EC3 RID: 134851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04020EC4 RID: 134852
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x04020EC5 RID: 134853
		private RoguelikeBlackFlowerItem BlackFlowerComponent;
	}
}
