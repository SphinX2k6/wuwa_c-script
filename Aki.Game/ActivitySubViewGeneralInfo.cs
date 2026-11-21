using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B40 RID: 2880
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewGeneralInfo : ActivitySubViewBase
{
	// Token: 0x0600775C RID: 30556 RVA: 0x0024CB58 File Offset: 0x0024AD58
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600775D RID: 30557 RVA: 0x0024CC03 File Offset: 0x0024AE03
	protected override void OnSetData()
	{
	}

	// Token: 0x0600775E RID: 30558 RVA: 0x0024CC08 File Offset: 0x0024AE08
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600775F RID: 30559 RVA: 0x0024CC4C File Offset: 0x0024AE4C
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
			if (!StringUtils.IsEmpty(descThemeIcon))
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
		this.RewardListComponent.ShowReceivedCallBack = this.ShowReceivedCallBack;
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		this.FunctionalComponent.FunctionButton.SetLocalTextNew("CollectActivity_reward", Array.Empty<object>());
		this.OnRefreshView();
	}

	// Token: 0x06007760 RID: 30560 RVA: 0x0024CDC0 File Offset: 0x0024AFC0
	public new void OnRefreshView()
	{
		this.RefreshFunction();
		this.RefreshTimerText();
	}

	// Token: 0x06007761 RID: 30561 RVA: 0x0024CDCE File Offset: 0x0024AFCE
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007762 RID: 30562 RVA: 0x0024CDD8 File Offset: 0x0024AFD8
	public void RefreshFunction()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		bool togActPlayTypeInteractive = false;
		if (localConfig != null)
		{
			foreach (EActivityShowActType eactivityShowActType in localConfig.Value.ShowActTypeIds())
			{
				if (eactivityShowActType == EActivityShowActType.Permanent || eactivityShowActType == EActivityShowActType.LimitedTime || eactivityShowActType == EActivityShowActType.Periodic)
				{
					togActPlayTypeInteractive = true;
					break;
				}
			}
		}
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
		ActivityTitleTypeA titleComponent = this.TitleComponent;
		if (titleComponent == null)
		{
			return;
		}
		titleComponent.SetTogActPlayTypeInteractive(togActPlayTypeInteractive);
	}

	// Token: 0x06007763 RID: 30563 RVA: 0x0024CEAC File Offset: 0x0024B0AC
	private void RefreshTimerText()
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

	// Token: 0x06007764 RID: 30564 RVA: 0x0024CEFE File Offset: 0x0024B0FE
	public void HideRemainTime()
	{
		this.HideRemainTimeInternal = true;
		this.TitleComponent.SetTimeTextVisible(false);
	}

	// Token: 0x06007765 RID: 30565 RVA: 0x0024CF13 File Offset: 0x0024B113
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

	// Token: 0x06007766 RID: 30566 RVA: 0x0024CF31 File Offset: 0x0024B131
	public void SetClickFunc([Nullable(new byte[]
	{
		1,
		2
	})] Action<ActivityBaseData> clickFunc)
	{
		this.ClickFunc = clickFunc;
	}

	// Token: 0x06007767 RID: 30567 RVA: 0x0024CF3A File Offset: 0x0024B13A
	[NullableContext(1)]
	public void SetShowReceivedCallBack(Func<TItem, bool> showReceivedCallBack)
	{
		this.ShowReceivedCallBack = showReceivedCallBack;
	}

	// Token: 0x06007768 RID: 30568 RVA: 0x0024CF43 File Offset: 0x0024B143
	private void FunctionExecute()
	{
		Action<ActivityBaseData> clickFunc = this.ClickFunc;
		if (clickFunc == null)
		{
			return;
		}
		clickFunc(this.ActivityBaseData);
	}

	// Token: 0x06007769 RID: 30569 RVA: 0x0024CF5B File Offset: 0x0024B15B
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetFunctionRedDotVisible(bVisible);
	}

	// Token: 0x0600776A RID: 30570 RVA: 0x0024CF6E File Offset: 0x0024B16E
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

	// Token: 0x0600776B RID: 30571 RVA: 0x0024CF81 File Offset: 0x0024B181
	public void SetPanelTipVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetPanelTipVisible(bVisible);
	}

	// Token: 0x0600776C RID: 30572 RVA: 0x0024CF94 File Offset: 0x0024B194
	[NullableContext(1)]
	public void SetSubTitleTextById(string textId)
	{
		this.TitleComponent.SetSubTitleVisible(true);
		this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
	}

	// Token: 0x0600776D RID: 30573 RVA: 0x0024CFB3 File Offset: 0x0024B1B3
	public ActivityFunctionalTypeA GetFunctional()
	{
		return this.FunctionalComponent;
	}

	// Token: 0x0600776E RID: 30574 RVA: 0x0024CFBB File Offset: 0x0024B1BB
	public UUIItem GetFunctionalButtonItem()
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return null;
		}
		return functionalComponent.GetFunctionButtonItem();
	}

	// Token: 0x0600776F RID: 30575 RVA: 0x0024CFCE File Offset: 0x0024B1CE
	public void SetRewardComponentVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x04004AEA RID: 19178
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004AEB RID: 19179
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04004AEC RID: 19180
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04004AED RID: 19181
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04004AEE RID: 19182
	private Action<ActivityBaseData> ClickFunc;

	// Token: 0x04004AEF RID: 19183
	private Func<TItem, bool> ShowReceivedCallBack;

	// Token: 0x04004AF0 RID: 19184
	private bool HideRemainTimeInternal;

	// Token: 0x02006DDA RID: 28122
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023FEF RID: 147439
		public const int TitleItem = 0;

		// Token: 0x04023FF0 RID: 147440
		public const int DescriptionItem = 1;

		// Token: 0x04023FF1 RID: 147441
		public const int RewardListItem = 2;

		// Token: 0x04023FF2 RID: 147442
		public const int FunctionArea = 3;
	}
}
