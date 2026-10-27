using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012AE RID: 4782
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewSevenHills : ActivitySubViewBase
{
	// Token: 0x06008349 RID: 33609 RVA: 0x001BF573 File Offset: 0x001BD773
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x0600834A RID: 33610 RVA: 0x001BF588 File Offset: 0x001BD788
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

	// Token: 0x0600834B RID: 33611 RVA: 0x001BF678 File Offset: 0x001BD878
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewSevenHills.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewSevenHills.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600834C RID: 33612 RVA: 0x001BF6BC File Offset: 0x001BD8BC
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

	// Token: 0x0600834D RID: 33613 RVA: 0x001BF81A File Offset: 0x001BDA1A
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600834E RID: 33614 RVA: 0x001BF824 File Offset: 0x001BDA24
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

	// Token: 0x0600834F RID: 33615 RVA: 0x001BF894 File Offset: 0x001BDA94
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

	// Token: 0x06008350 RID: 33616 RVA: 0x001BF8E6 File Offset: 0x001BDAE6
	public void HideRemainTime()
	{
		this.HideRemainTimeInternal = true;
		this.TitleComponent.SetTimeTextVisible(false);
	}

	// Token: 0x06008351 RID: 33617 RVA: 0x001BF8FB File Offset: 0x001BDAFB
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

	// Token: 0x06008352 RID: 33618 RVA: 0x001BF919 File Offset: 0x001BDB19
	public void SetClickFunc([Nullable(new byte[]
	{
		1,
		2
	})] Action<ActivityBaseData> clickFunc)
	{
		this.ClickFunc = clickFunc;
	}

	// Token: 0x06008353 RID: 33619 RVA: 0x001BF922 File Offset: 0x001BDB22
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

	// Token: 0x06008354 RID: 33620 RVA: 0x001BF940 File Offset: 0x001BDB40
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetFunctionRedDotVisible(bVisible);
	}

	// Token: 0x06008355 RID: 33621 RVA: 0x001BF953 File Offset: 0x001BDB53
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

	// Token: 0x06008356 RID: 33622 RVA: 0x001BF966 File Offset: 0x001BDB66
	public void SetPanelTipVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetPanelTipVisible(bVisible);
	}

	// Token: 0x06008357 RID: 33623 RVA: 0x001BF979 File Offset: 0x001BDB79
	[NullableContext(1)]
	public void SetSubTitleTextById(string textId)
	{
		this.TitleComponent.SetSubTitleVisible(true);
		this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
	}

	// Token: 0x06008358 RID: 33624 RVA: 0x001BF998 File Offset: 0x001BDB98
	public ActivityFunctionalTypeA GetFunctional()
	{
		return this.FunctionalComponent;
	}

	// Token: 0x06008359 RID: 33625 RVA: 0x001BF9A0 File Offset: 0x001BDBA0
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

	// Token: 0x0600835A RID: 33626 RVA: 0x001BF9D0 File Offset: 0x001BDBD0
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

	// Token: 0x0600835B RID: 33627 RVA: 0x001BFA45 File Offset: 0x001BDC45
	protected override void OnRefreshView()
	{
		this.RefreshFunction();
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshScoreNum();
	}

	// Token: 0x0600835C RID: 33628 RVA: 0x001BFA60 File Offset: 0x001BDC60
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.CheckAnyStageRed() || this.ActivityData.CheckScoreRewardRedDot();
		this.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x0600835D RID: 33629 RVA: 0x001BFA90 File Offset: 0x001BDC90
	protected virtual void OnConfirmBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SevenHillsMainView, this.ActivityData, null);
	}

	// Token: 0x04003B27 RID: 15143
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003B28 RID: 15144
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003B29 RID: 15145
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003B2A RID: 15146
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003B2B RID: 15147
	private Action<ActivityBaseData> ClickFunc;

	// Token: 0x04003B2C RID: 15148
	private bool HideRemainTimeInternal;

	// Token: 0x04003B2D RID: 15149
	protected ActivityLongShanData ActivityData;

	// Token: 0x020078CE RID: 30926
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CCE RID: 163022
		public const int TitleItem = 0;

		// Token: 0x04027CCF RID: 163023
		public const int DescriptionItem = 1;

		// Token: 0x04027CD0 RID: 163024
		public const int RewardListItem = 2;

		// Token: 0x04027CD1 RID: 163025
		public const int FunctionArea = 3;

		// Token: 0x04027CD2 RID: 163026
		public const int TextCount = 4;

		// Token: 0x04027CD3 RID: 163027
		public const int TextTotal = 5;
	}
}
