using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001688 RID: 5768
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewGeneralInfo : ActivitySubViewBase
{
	// Token: 0x0600A37E RID: 41854 RVA: 0x00242AF0 File Offset: 0x00240CF0
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

	// Token: 0x0600A37F RID: 41855 RVA: 0x00242B9B File Offset: 0x00240D9B
	protected override void OnSetData()
	{
	}

	// Token: 0x0600A380 RID: 41856 RVA: 0x00242BA0 File Offset: 0x00240DA0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A381 RID: 41857 RVA: 0x00242BE4 File Offset: 0x00240DE4
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

	// Token: 0x0600A382 RID: 41858 RVA: 0x00242D58 File Offset: 0x00240F58
	public new void OnRefreshView()
	{
		this.RefreshFunction();
		this.RefreshTimerText();
	}

	// Token: 0x0600A383 RID: 41859 RVA: 0x00242D66 File Offset: 0x00240F66
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600A384 RID: 41860 RVA: 0x00242D70 File Offset: 0x00240F70
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

	// Token: 0x0600A385 RID: 41861 RVA: 0x00242E44 File Offset: 0x00241044
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

	// Token: 0x0600A386 RID: 41862 RVA: 0x00242E96 File Offset: 0x00241096
	public void HideRemainTime()
	{
		this.HideRemainTimeInternal = true;
		this.TitleComponent.SetTimeTextVisible(false);
	}

	// Token: 0x0600A387 RID: 41863 RVA: 0x00242EAB File Offset: 0x002410AB
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

	// Token: 0x0600A388 RID: 41864 RVA: 0x00242EC9 File Offset: 0x002410C9
	public void SetClickFunc([Nullable(new byte[]
	{
		1,
		2
	})] Action<ActivityBaseData> clickFunc)
	{
		this.ClickFunc = clickFunc;
	}

	// Token: 0x0600A389 RID: 41865 RVA: 0x00242ED2 File Offset: 0x002410D2
	[NullableContext(1)]
	public void SetShowReceivedCallBack(Func<TItem, bool> showReceivedCallBack)
	{
		this.ShowReceivedCallBack = showReceivedCallBack;
	}

	// Token: 0x0600A38A RID: 41866 RVA: 0x00242EDB File Offset: 0x002410DB
	private void FunctionExecute()
	{
		Action<ActivityBaseData> clickFunc = this.ClickFunc;
		if (clickFunc == null)
		{
			return;
		}
		clickFunc(this.ActivityBaseData);
	}

	// Token: 0x0600A38B RID: 41867 RVA: 0x00242EF3 File Offset: 0x002410F3
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetFunctionRedDotVisible(bVisible);
	}

	// Token: 0x0600A38C RID: 41868 RVA: 0x00242F06 File Offset: 0x00241106
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

	// Token: 0x0600A38D RID: 41869 RVA: 0x00242F19 File Offset: 0x00241119
	public void SetPanelTipVisible(bool bVisible)
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return;
		}
		functionalComponent.SetPanelTipVisible(bVisible);
	}

	// Token: 0x0600A38E RID: 41870 RVA: 0x00242F2C File Offset: 0x0024112C
	[NullableContext(1)]
	public void SetSubTitleTextById(string textId)
	{
		this.TitleComponent.SetSubTitleVisible(true);
		this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
	}

	// Token: 0x0600A38F RID: 41871 RVA: 0x00242F4B File Offset: 0x0024114B
	public ActivityFunctionalTypeA GetFunctional()
	{
		return this.FunctionalComponent;
	}

	// Token: 0x0600A390 RID: 41872 RVA: 0x00242F53 File Offset: 0x00241153
	public UUIItem GetFunctionalButtonItem()
	{
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent == null)
		{
			return null;
		}
		return functionalComponent.GetFunctionButtonItem();
	}

	// Token: 0x0600A391 RID: 41873 RVA: 0x00242F66 File Offset: 0x00241166
	public void SetRewardComponentVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x04004A43 RID: 19011
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004A44 RID: 19012
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04004A45 RID: 19013
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04004A46 RID: 19014
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04004A47 RID: 19015
	private Action<ActivityBaseData> ClickFunc;

	// Token: 0x04004A48 RID: 19016
	private Func<TItem, bool> ShowReceivedCallBack;

	// Token: 0x04004A49 RID: 19017
	private bool HideRemainTimeInternal;

	// Token: 0x02007C55 RID: 31829
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028CC5 RID: 167109
		public const int TitleItem = 0;

		// Token: 0x04028CC6 RID: 167110
		public const int DescriptionItem = 1;

		// Token: 0x04028CC7 RID: 167111
		public const int RewardListItem = 2;

		// Token: 0x04028CC8 RID: 167112
		public const int FunctionArea = 3;
	}
}
