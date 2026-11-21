using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000662 RID: 1634
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewBlackCoast : ActivitySubViewBase
{
	// Token: 0x06004B93 RID: 19347 RVA: 0x0019A519 File Offset: 0x00198719
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityBlackCoastData)this.ActivityBaseData;
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x0019A52C File Offset: 0x0019872C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x0019A63C File Offset: 0x0019883C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewBlackCoast.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewBlackCoast.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x0019A680 File Offset: 0x00198880
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityData.LocalConfig;
		this.TitleComponent.SetActivityBaseData(this.ActivityData);
		this.TitleComponent.SetTitleByText(this.ActivityData.GetTitle());
		this.TitleComponent.SetSubTitleVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null));
		if (((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null) != null)
		{
			this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null));
		if (((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null) != null)
		{
			this.DescriptionComponent.SetContentByTextId(localConfig.Value.Desc, Array.Empty<string>());
		}
		UUITexture textureIcon = base.GetTexture(6);
		textureIcon.SetUIActive(false);
		base.SetItemIcon(textureIcon, this.ActivityData.GetProgressItemId, null, delegate(bool _)
		{
			textureIcon.SetUIActive(true);
		});
		List<TItem> previewReward = this.ActivityData.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.ButtonFunction));
		this.OnRefreshView();
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x0019A841 File Offset: 0x00198A41
	protected override void OnRefreshView()
	{
		this.RefreshCount();
		this.RefreshState();
		this.RefreshRedDot();
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x0019A855 File Offset: 0x00198A55
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x0019A860 File Offset: 0x00198A60
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06004B9A RID: 19354 RVA: 0x0019A8A0 File Offset: 0x00198AA0
	private void RefreshCount()
	{
		base.GetText(4).SetText(this.ActivityData.GetProgressItemCount().ToString() + "/", true);
		base.GetText(5).SetText(this.ActivityData.GetProgressItemTotal().ToString(), true);
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x0019A8F8 File Offset: 0x00198AF8
	private void RefreshState()
	{
		bool flag = this.ActivityData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityData.ConditionGroupId, this.ActivityData.Id);
		}
		this.FunctionalComponent.FunctionButton.SetActive(flag);
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x0019A958 File Offset: 0x00198B58
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.RewardRedDotState();
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x0019A97D File Offset: 0x00198B7D
	private void ButtonFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.BlackCoastActivityMainView, this.ActivityData, null);
		});
	}

	// Token: 0x040037D5 RID: 14293
	protected ActivityBlackCoastData ActivityData;

	// Token: 0x040037D6 RID: 14294
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040037D7 RID: 14295
	private ActivityDescriptionTypeB DescriptionComponent;

	// Token: 0x040037D8 RID: 14296
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x040037D9 RID: 14297
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02006918 RID: 26904
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040229EC RID: 141804
		public const int TitleItem = 0;

		// Token: 0x040229ED RID: 141805
		public const int TextItem = 1;

		// Token: 0x040229EE RID: 141806
		public const int RewardItem = 2;

		// Token: 0x040229EF RID: 141807
		public const int PanelBottom = 3;

		// Token: 0x040229F0 RID: 141808
		public const int DataCount = 4;

		// Token: 0x040229F1 RID: 141809
		public const int DataTotal = 5;

		// Token: 0x040229F2 RID: 141810
		public const int DataIcon = 6;
	}
}
