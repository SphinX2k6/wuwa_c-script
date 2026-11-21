using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022B4 RID: 8884
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueSubView : ActivitySubViewBase
{
	// Token: 0x17002140 RID: 8512
	// (get) Token: 0x06015F0F RID: 89871 RVA: 0x0065C9E7 File Offset: 0x0065ABE7
	protected new WeeklyRogueData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as WeeklyRogueData;
		}
	}

	// Token: 0x06015F10 RID: 89872 RVA: 0x0065C9F4 File Offset: 0x0065ABF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture))
		};
	}

	// Token: 0x06015F11 RID: 89873 RVA: 0x0065CABC File Offset: 0x0065ACBC
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015F12 RID: 89874 RVA: 0x0065CB00 File Offset: 0x0065AD00
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
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
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		WeeklyRogueData activityBaseData = this.ActivityBaseData;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityBaseData != null) ? activityBaseData.GetCycleConfig() : null;
		base.SetTextureByPath(rogueWeeklyCycle.Value.ViewBackground, base.GetTexture(7), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "PrefabTextItem_1382682910_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.ActivityBaseData.Score.ToString(),
			rogueWeeklyCycle.Value.MaxScore
		}));
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.OnRefreshView();
	}

	// Token: 0x06015F13 RID: 89875 RVA: 0x0065CCDD File Offset: 0x0065AEDD
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshCondition();
		this.RefreshScore();
	}

	// Token: 0x06015F14 RID: 89876 RVA: 0x0065CCF7 File Offset: 0x0065AEF7
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06015F15 RID: 89877 RVA: 0x0065CD00 File Offset: 0x0065AF00
	private void RefreshRedDot()
	{
		bool flag = this.ActivityBaseData.HasNewCycle();
		if (flag)
		{
			this.FunctionalComponent.SetPanelTipByTextId("WeRougeCycleUpdateBubbleText", Array.Empty<string>());
		}
		this.FunctionalComponent.SetPanelTipVisible(flag);
		this.FunctionalComponent.SetFunctionRedDotVisible(flag);
	}

	// Token: 0x06015F16 RID: 89878 RVA: 0x0065CD4C File Offset: 0x0065AF4C
	private void RefreshTimerText()
	{
		WeeklyRogueData activityBaseData = this.ActivityBaseData;
		CommonDefine.ICountDown countDown = (activityBaseData != null) ? activityBaseData.GetCycleCountDownData() : null;
		if (countDown == null)
		{
			return;
		}
		string timeTextByText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("WeeklyRogue_Activity_Time", null), new string[]
		{
			countDown.CountDownText
		});
		this.TitleComponent.SetTimeTextByText(timeTextByText);
	}

	// Token: 0x06015F17 RID: 89879 RVA: 0x0065CD9C File Offset: 0x0065AF9C
	private void RefreshCondition()
	{
		if (!this.ActivityBaseData.IsUnLock())
		{
			this.FunctionalComponent.SetPanelTipVisible(false);
			ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetUiActive(false);
			}
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			return;
		}
		ActivityButtonItem functionButton2 = this.FunctionalComponent.FunctionButton;
		if (functionButton2 != null)
		{
			functionButton2.SetUiActive(true);
		}
		this.FunctionalComponent.SetPanelConditionVisible(false);
	}

	// Token: 0x06015F18 RID: 89880 RVA: 0x0065CE20 File Offset: 0x0065B020
	private void RefreshScore()
	{
		WeeklyRogueData activityBaseData = this.ActivityBaseData;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityBaseData != null) ? activityBaseData.GetCycleConfig() : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "PrefabTextItem_1382682910_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.ActivityBaseData.Score.ToString(),
			rogueWeeklyCycle.Value.MaxScore
		}));
	}

	// Token: 0x06015F19 RID: 89881 RVA: 0x0065CE93 File Offset: 0x0065B093
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			WeeklyRogueData activityBaseData = this.ActivityBaseData;
			bool? flag = (activityBaseData != null) ? new bool?(activityBaseData.GetPreGuideQuestFinishState()) : null;
			bool flag2 = false;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				if (unFinishPreGuideQuestId > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				}
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueActivityView, EWeeklyRogueOpenWay.UI, null);
		});
	}

	// Token: 0x0400B876 RID: 47222
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400B877 RID: 47223
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400B878 RID: 47224
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x0400B879 RID: 47225
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02008527 RID: 34087
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402AEB4 RID: 175796
		TitleItem,
		// Token: 0x0402AEB5 RID: 175797
		DescriptionItem,
		// Token: 0x0402AEB6 RID: 175798
		RewardListItem,
		// Token: 0x0402AEB7 RID: 175799
		FunctionArea,
		// Token: 0x0402AEB8 RID: 175800
		BtnScore,
		// Token: 0x0402AEB9 RID: 175801
		ScoreRedDotItem,
		// Token: 0x0402AEBA RID: 175802
		TxtScore,
		// Token: 0x0402AEBB RID: 175803
		TextureBg
	}
}
