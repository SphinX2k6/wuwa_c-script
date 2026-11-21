using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000974 RID: 2420
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewRoleGive : ActivitySubViewBase
{
	// Token: 0x06006A2E RID: 27182 RVA: 0x00211568 File Offset: 0x0020F768
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickPreview));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006A2F RID: 27183 RVA: 0x002116D4 File Offset: 0x0020F8D4
	protected override void OnSetData()
	{
		this.Data = (this.ActivityBaseData as ActivityRoleGiveData);
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x002116E8 File Offset: 0x0020F8E8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewRoleGive.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleGive.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006A31 RID: 27185 RVA: 0x0021172C File Offset: 0x0020F92C
	protected override void OnStart()
	{
		Activity? localConfig = this.Data.LocalConfig;
		TrackMoonPhaseActivity? extraConfig = this.Data.GetExtraConfig();
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
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
		if (functionButton != null)
		{
			functionButton.SetFunction(new Action(this.FunctionExecute));
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		TrialRoleInfo? trialRoleConfig = TrialRoleConfig.Instance.GetTrialRoleConfig(extraConfig.Value.RoleTrialId);
		if (trialRoleConfig != null)
		{
			RoleDescribeComponent roleDescComponent = this.RoleDescComponent;
			if (roleDescComponent != null)
			{
				roleDescComponent.Update(trialRoleConfig.Value.ParentId, false);
			}
		}
		if (trialRoleConfig != null)
		{
			CommonItemSmallItemGrid commonItemGrid = this.CommonItemGrid;
			if (commonItemGrid != null)
			{
				commonItemGrid.RefreshByConfigId(trialRoleConfig.Value.ParentId, null, null, false, false);
			}
		}
		this.OnRefreshView();
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x002118AF File Offset: 0x0020FAAF
	protected override void OnTimer(float gap)
	{
		this.OnRefreshView();
	}

	// Token: 0x06006A33 RID: 27187 RVA: 0x002118B7 File Offset: 0x0020FAB7
	protected override void OnRefreshView()
	{
		this.RefreshCondition();
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshProgress();
	}

	// Token: 0x06006A34 RID: 27188 RVA: 0x002118D4 File Offset: 0x0020FAD4
	private void RefreshProgress()
	{
		TrackMoonPhaseActivity? extraConfig = this.Data.GetExtraConfig();
		if (extraConfig == null)
		{
			return;
		}
		MoonChasingModel instance = MoonChasingModel.Instance;
		int num = (instance != null) ? instance.GetPopularityValue() : 0;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Moonfiesta_PopularityProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			extraConfig.Value.PopularityNeed
		}));
		UUISprite sprite = base.GetSprite(7);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount((float)num / (float)extraConfig.Value.PopularityNeed);
	}

	// Token: 0x06006A35 RID: 27189 RVA: 0x00211970 File Offset: 0x0020FB70
	private void RefreshTimerText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		this.TitleComponent.SetTimeTextByText(item);
	}

	// Token: 0x06006A36 RID: 27190 RVA: 0x00211998 File Offset: 0x0020FB98
	protected void RefreshCondition()
	{
		TrackMoonPhaseActivity? extraConfig = this.Data.GetExtraConfig();
		if (extraConfig == null)
		{
			return;
		}
		if (!this.ActivityBaseData.IsUnLock())
		{
			ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetUiActive(false);
			}
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			return;
		}
		ActivityRoleGiveData data = this.Data;
		if (data != null && data.IsGetReward)
		{
			ActivityButtonItem functionButton2 = this.FunctionalComponent.FunctionButton;
			if (functionButton2 != null)
			{
				functionButton2.SetUiActive(false);
			}
			this.FunctionalComponent.SetActivatePanelConditionVisible(true);
			this.FunctionalComponent.SetPanelConditionVisible(false);
		}
		else
		{
			ActivityButtonItem functionButton3 = this.FunctionalComponent.FunctionButton;
			if (functionButton3 != null)
			{
				functionButton3.SetUiActive(true);
			}
			this.FunctionalComponent.SetActivatePanelConditionVisible(false);
			this.FunctionalComponent.SetPanelConditionVisible(false);
		}
		ActivityRoleGiveData data2 = this.Data;
		if (data2 == null || !data2.IsGetReward)
		{
			MoonChasingModel instance = MoonChasingModel.Instance;
			if (((instance != null) ? instance.GetPopularityValue() : 0) >= extraConfig.Value.PopularityNeed)
			{
				ActivityButtonItem functionButton4 = this.FunctionalComponent.FunctionButton;
				if (functionButton4 == null)
				{
					return;
				}
				functionButton4.SetText(ConfigMultiTextLang.GetLocalTextNew("CollectActivity_state_CanRecive", null));
				return;
			}
		}
		ActivityButtonItem functionButton5 = this.FunctionalComponent.FunctionButton;
		if (functionButton5 == null)
		{
			return;
		}
		functionButton5.SetText(ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null));
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x00211AEF File Offset: 0x0020FCEF
	private void RefreshRedDot()
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetFunctionRedDotVisible(this.Data.RedPointShowState);
	}

	// Token: 0x06006A38 RID: 27192 RVA: 0x00211B0C File Offset: 0x0020FD0C
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			Log.Instance.Info(ELogModule.MoonChasing, ELogAuthor.LPH, "点击领取奖励", default(ReadOnlySpan<ValueTuple<string, object>>));
			ActivityRoleGiveData data = this.Data;
			if (data == null || !data.RedPointShowState)
			{
				foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetActivitiesByType(17))
				{
					ActivityMoonChasingData activityMoonChasingData = activityBaseData as ActivityMoonChasingData;
					if (activityMoonChasingData != null && activityMoonChasingData.ActivityFlowState == EMoonChasingActivityFlow.Activity)
					{
						if (!activityMoonChasingData.GetPreGuideQuestFinishState())
						{
							UiManager.Instance.OpenView(EUiViewName.QuestView, activityMoonChasingData.GetUnFinishPreGuideQuestId(), null);
							return;
						}
						TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(activityBaseData.Id);
						if (activityMoonChasingConfig != null)
						{
							WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
							{
								MarkId = new int?(activityMoonChasingConfig.Value.FocusMarkId),
								MarkType = EMarkType.SmallTeleport
							};
							WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
							return;
						}
					}
				}
				return;
			}
			ActivityRoleGiveData data3 = this.Data;
			TrackMoonPhaseActivity? trackMoonPhaseActivity = (data3 != null) ? data3.GetExtraConfig() : null;
			MoonChasingModel instance = MoonChasingModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetPopularityValue()) : null;
			if (trackMoonPhaseActivity == null)
			{
				return;
			}
			if (num == null)
			{
				return;
			}
			if (num.Value < trackMoonPhaseActivity.Value.PopularityNeed)
			{
				return;
			}
			ActivityRoleGiveController.Instance.TrackMoonActivityRewardRequest();
		});
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x00211B2C File Offset: 0x0020FD2C
	private unsafe void OnClickPreview()
	{
		TrackMoonPhaseActivity? extraConfig = this.Data.GetExtraConfig();
		if (extraConfig != null)
		{
			RoleController instance = RoleController.Instance;
			ERoleAgentType agentType = ERoleAgentType.Preview;
			int selectRoleId = 0;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = extraConfig.Value.RoleTrialId;
			instance.OpenRoleMainView(agentType, selectRoleId, list, null, null);
		}
	}

	// Token: 0x04004308 RID: 17160
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004309 RID: 17161
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400430A RID: 17162
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x0400430B RID: 17163
	private RoleDescribeComponent RoleDescComponent;

	// Token: 0x0400430C RID: 17164
	private CommonItemSmallItemGrid CommonItemGrid;

	// Token: 0x0400430D RID: 17165
	private ActivityRoleGiveData Data;

	// Token: 0x02006C7C RID: 27772
	[NullableContext(0)]
	private class EActivitySubViewRoleGiveDefine
	{
		// Token: 0x04023A47 RID: 145991
		public const int TitleItem = 0;

		// Token: 0x04023A48 RID: 145992
		public const int DescItem = 1;

		// Token: 0x04023A49 RID: 145993
		public const int RoleDescriptionItem = 2;

		// Token: 0x04023A4A RID: 145994
		public const int BtnPreview = 3;

		// Token: 0x04023A4B RID: 145995
		public const int FunctionItem = 4;

		// Token: 0x04023A4C RID: 145996
		public const int RewardItem = 5;

		// Token: 0x04023A4D RID: 145997
		public const int TxtProgress = 6;

		// Token: 0x04023A4E RID: 145998
		public const int SpriteProgress = 7;
	}
}
