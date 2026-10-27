using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D5A RID: 11610
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueSubView : ActivitySubViewBase
{
	// Token: 0x170020E5 RID: 8421
	// (get) Token: 0x0601866D RID: 99949 RVA: 0x006369D7 File Offset: 0x00634BD7
	protected new WeeklyRogueData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as WeeklyRogueData;
		}
	}

	// Token: 0x0601866E RID: 99950 RVA: 0x006369E4 File Offset: 0x00634BE4
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

	// Token: 0x0601866F RID: 99951 RVA: 0x00636AAC File Offset: 0x00634CAC
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018670 RID: 99952 RVA: 0x00636AF0 File Offset: 0x00634CF0
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

	// Token: 0x06018671 RID: 99953 RVA: 0x00636CCD File Offset: 0x00634ECD
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshCondition();
		this.RefreshScore();
	}

	// Token: 0x06018672 RID: 99954 RVA: 0x00636CE7 File Offset: 0x00634EE7
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06018673 RID: 99955 RVA: 0x00636CF0 File Offset: 0x00634EF0
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

	// Token: 0x06018674 RID: 99956 RVA: 0x00636D3C File Offset: 0x00634F3C
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

	// Token: 0x06018675 RID: 99957 RVA: 0x00636D8C File Offset: 0x00634F8C
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

	// Token: 0x06018676 RID: 99958 RVA: 0x00636E10 File Offset: 0x00635010
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

	// Token: 0x06018677 RID: 99959 RVA: 0x00636E83 File Offset: 0x00635083
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

	// Token: 0x0400B501 RID: 46337
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400B502 RID: 46338
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400B503 RID: 46339
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x0400B504 RID: 46340
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02009300 RID: 37632
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402F82C RID: 194604
		TitleItem,
		// Token: 0x0402F82D RID: 194605
		DescriptionItem,
		// Token: 0x0402F82E RID: 194606
		RewardListItem,
		// Token: 0x0402F82F RID: 194607
		FunctionArea,
		// Token: 0x0402F830 RID: 194608
		BtnScore,
		// Token: 0x0402F831 RID: 194609
		ScoreRedDotItem,
		// Token: 0x0402F832 RID: 194610
		TxtScore,
		// Token: 0x0402F833 RID: 194611
		TextureBg
	}
}
