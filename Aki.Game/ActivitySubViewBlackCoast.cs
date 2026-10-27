using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011AE RID: 4526
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewBlackCoast : ActivitySubViewBase
{
	// Token: 0x060077FC RID: 30716 RVA: 0x0019193D File Offset: 0x0018FB3D
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityBlackCoastData)this.ActivityBaseData;
	}

	// Token: 0x060077FD RID: 30717 RVA: 0x00191950 File Offset: 0x0018FB50
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

	// Token: 0x060077FE RID: 30718 RVA: 0x00191A60 File Offset: 0x0018FC60
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewBlackCoast.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewBlackCoast.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060077FF RID: 30719 RVA: 0x00191AA4 File Offset: 0x0018FCA4
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

	// Token: 0x06007800 RID: 30720 RVA: 0x00191C65 File Offset: 0x0018FE65
	protected override void OnRefreshView()
	{
		this.RefreshCount();
		this.RefreshState();
		this.RefreshRedDot();
	}

	// Token: 0x06007801 RID: 30721 RVA: 0x00191C79 File Offset: 0x0018FE79
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007802 RID: 30722 RVA: 0x00191C84 File Offset: 0x0018FE84
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

	// Token: 0x06007803 RID: 30723 RVA: 0x00191CC4 File Offset: 0x0018FEC4
	private void RefreshCount()
	{
		base.GetText(4).SetText(this.ActivityData.GetProgressItemCount().ToString() + "/", true);
		base.GetText(5).SetText(this.ActivityData.GetProgressItemTotal().ToString(), true);
	}

	// Token: 0x06007804 RID: 30724 RVA: 0x00191D1C File Offset: 0x0018FF1C
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

	// Token: 0x06007805 RID: 30725 RVA: 0x00191D7C File Offset: 0x0018FF7C
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.RewardRedDotState();
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x06007806 RID: 30726 RVA: 0x00191DA1 File Offset: 0x0018FFA1
	private void ButtonFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.BlackCoastActivityMainView, this.ActivityData, null);
		});
	}

	// Token: 0x0400373C RID: 14140
	protected ActivityBlackCoastData ActivityData;

	// Token: 0x0400373D RID: 14141
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400373E RID: 14142
	private ActivityDescriptionTypeB DescriptionComponent;

	// Token: 0x0400373F RID: 14143
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003740 RID: 14144
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x0200778C RID: 30604
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040276B6 RID: 161462
		public const int TitleItem = 0;

		// Token: 0x040276B7 RID: 161463
		public const int TextItem = 1;

		// Token: 0x040276B8 RID: 161464
		public const int RewardItem = 2;

		// Token: 0x040276B9 RID: 161465
		public const int PanelBottom = 3;

		// Token: 0x040276BA RID: 161466
		public const int DataCount = 4;

		// Token: 0x040276BB RID: 161467
		public const int DataTotal = 5;

		// Token: 0x040276BC RID: 161468
		public const int DataIcon = 6;
	}
}
