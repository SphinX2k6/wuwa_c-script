using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000762 RID: 1890
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewSevenHills : ActivitySubViewBase
{
	// Token: 0x060056E0 RID: 22240 RVA: 0x001C8303 File Offset: 0x001C6503
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x001C8318 File Offset: 0x001C6518
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x001C8408 File Offset: 0x001C6608
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewSevenHills.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewSevenHills.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060056E3 RID: 22243 RVA: 0x001C844C File Offset: 0x001C664C
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			string descThemeIcon = localConfig.Value.DescThemeIcon;
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			if (descThemeIcon != null)
			{
				ActivityTitleTypeA titleComponent = this.TitleComponent;
				if (titleComponent != null)
				{
					titleComponent.SetSubTitleIconByPath(descThemeIcon, null);
				}
			}
		}
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		this.FunctionalComponent.FunctionButton.SetLocalTextNew("CollectActivity_reward", Array.Empty<object>());
		this.OnRefreshView();
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x001C85AA File Offset: 0x001C67AA
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x060056E5 RID: 22245 RVA: 0x001C85B4 File Offset: 0x001C67B4
	public void RefreshFunction()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent != null)
		{
			ActivityButtonItem functionButton = functionalComponent.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetUiActive(flag);
			}
		}
		ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
		if (functionalComponent2 != null)
		{
			functionalComponent2.SetPanelConditionVisible(!flag);
		}
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x060056E6 RID: 22246 RVA: 0x001C8624 File Offset: 0x001C6824
	protected void RefreshTimerText()
	{
		if (this.HideRemainTimeInternal)
		{
			this.TitleComponent.SetTimeTextVisible(false);
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x060056E7 RID: 22247 RVA: 0x001C8676 File Offset: 0x001C6876
	public void HideRemainTime()
	{
		this.HideRemainTimeInternal = true;
		this.TitleComponent.SetTimeTextVisible(false);
	}

	// Token: 0x060056E8 RID: 22248 RVA: 0x001C868B File Offset: 0x001C688B
	[NullableContext(1)]
	public void SetBtnText(string textId, params object[] args)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		ActivityButtonItem functionButton = functionalComponent.FunctionButton;
		if (functionButton == null)
		{
			return;
		}
		functionButton.SetLocalTextNew(textId, args);
	}

	// Token: 0x060056E9 RID: 22249 RVA: 0x001C86A9 File Offset: 0x001C68A9
	public void SetClickFunc([Nullable(new byte[]
	{
		1,
		2
	})] Action<ActivityBaseData> clickFunc)
	{
		this.ClickFunc = clickFunc;
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x001C86B2 File Offset: 0x001C68B2
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			Action<ActivityBaseData> clickFunc = this.ClickFunc;
			if (clickFunc == null)
			{
				return;
			}
			clickFunc(this.ActivityBaseData);
		});
	}

	// Token: 0x060056EB RID: 22251 RVA: 0x001C86D0 File Offset: 0x001C68D0
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetFunctionRedDotVisible(bVisible);
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x001C86E3 File Offset: 0x001C68E3
	[NullableContext(1)]
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetRewardButtonFunction(buttonFunction);
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x001C86F6 File Offset: 0x001C68F6
	public void SetPanelTipVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetPanelTipVisible(bVisible);
	}

	// Token: 0x060056EE RID: 22254 RVA: 0x001C8709 File Offset: 0x001C6909
	[NullableContext(1)]
	public void SetSubTitleTextById(string textId)
	{
		this.TitleComponent.SetSubTitleVisible(true);
		this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
	}

	// Token: 0x060056EF RID: 22255 RVA: 0x001C8728 File Offset: 0x001C6928
	public ActivityFunctionalTypeA GetFunctional()
	{
		return this.FunctionalComponent;
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x001C8730 File Offset: 0x001C6930
	protected override void OnBeforeShow()
	{
		this.SetClickFunc(delegate(ActivityBaseData _)
		{
			this.OnConfirmBtnClick();
		});
		this.SetBtnText("LongShanStage_Join01", Array.Empty<object>());
		this.RefreshRedDot();
		this.RefreshScoreNum();
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x001C8760 File Offset: 0x001C6960
	private void RefreshScoreNum()
	{
		int scoreItemCount = this.ActivityData.GetScoreItemCount();
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(scoreItemCount.ToString(), true);
		}
		int scoreItemTotal = this.ActivityData.ScoreItemTotal;
		UUIText text2 = base.GetText(5);
		if (text2 == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(scoreItemTotal);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060056F2 RID: 22258 RVA: 0x001C87D5 File Offset: 0x001C69D5
	protected override void OnRefreshView()
	{
		this.RefreshFunction();
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshScoreNum();
	}

	// Token: 0x060056F3 RID: 22259 RVA: 0x001C87F0 File Offset: 0x001C69F0
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.CheckAnyStageRed() || this.ActivityData.CheckScoreRewardRedDot();
		this.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x060056F4 RID: 22260 RVA: 0x001C8820 File Offset: 0x001C6A20
	protected virtual void OnConfirmBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SevenHillsMainView, this.ActivityData, null);
	}

	// Token: 0x04003BBF RID: 15295
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003BC0 RID: 15296
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003BC1 RID: 15297
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003BC2 RID: 15298
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003BC3 RID: 15299
	private Action<ActivityBaseData> ClickFunc;

	// Token: 0x04003BC4 RID: 15300
	private bool HideRemainTimeInternal;

	// Token: 0x04003BC5 RID: 15301
	protected ActivityLongShanData ActivityData;

	// Token: 0x02006A58 RID: 27224
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022FFC RID: 143356
		public const int TitleItem = 0;

		// Token: 0x04022FFD RID: 143357
		public const int DescriptionItem = 1;

		// Token: 0x04022FFE RID: 143358
		public const int RewardListItem = 2;

		// Token: 0x04022FFF RID: 143359
		public const int FunctionArea = 3;

		// Token: 0x04023000 RID: 143360
		public const int TextCount = 4;

		// Token: 0x04023001 RID: 143361
		public const int TextTotal = 5;
	}
}
