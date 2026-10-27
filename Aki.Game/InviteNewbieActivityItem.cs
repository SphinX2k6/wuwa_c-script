using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200128E RID: 4750
[NullableContext(2)]
[Nullable(0)]
public class InviteNewbieActivityItem : UiPanelBase
{
	// Token: 0x060081E2 RID: 33250 RVA: 0x001B8A3C File Offset: 0x001B6C3C
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

	// Token: 0x060081E3 RID: 33251 RVA: 0x001B8AE8 File Offset: 0x001B6CE8
	protected override UniTask OnBeforeStartAsync()
	{
		InviteNewbieActivityItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InviteNewbieActivityItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060081E4 RID: 33252 RVA: 0x001B8B2C File Offset: 0x001B6D2C
	protected override void OnStart()
	{
		Activity value = this.ActivityDataCache.LocalConfig.Value;
		this.TitleComponent.SetActivityBaseData(this.ActivityDataCache);
		this.TitleComponent.SetTitleByText(this.ActivityDataCache.GetTitle());
		this.TitleComponent.SetSubTitleVisible(!StringUtils.IsEmpty(value.DescTheme));
		if (!StringUtils.IsEmpty(value.DescTheme))
		{
			this.TitleComponent.SetSubTitleByTextId(value.DescTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentVisible(!StringUtils.IsEmpty(value.Desc));
		if (!StringUtils.IsEmpty(value.Desc))
		{
			this.DescriptionComponent.SetContentByTextId(value.Desc, Array.Empty<string>());
		}
		List<TItem> previewReward = this.ActivityDataCache.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.RewardListComponent.SetTitleByTextId("Activity_104600001_Reward");
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnClickEnter));
		this.FunctionalComponent.FunctionButton.SetLocalTextNew("Activity_104600001_GObutton", Array.Empty<object>());
	}

	// Token: 0x060081E5 RID: 33253 RVA: 0x001B8C73 File Offset: 0x001B6E73
	private void OnClickEnter()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityDataCache, delegate()
		{
			InviteNewbieProtocolContext activityData = this.ActivityDataCache as InviteNewbieProtocolContext;
			ActivityInviteNewbieController.Instance.HandleOnEnterClick(activityData);
		});
	}

	// Token: 0x060081E6 RID: 33254 RVA: 0x001B8C91 File Offset: 0x001B6E91
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.FunctionalComponent.FunctionButton.BindRedDot(ERedDotName.InviteNewbie, 0);
	}

	// Token: 0x060081E7 RID: 33255 RVA: 0x001B8CAF File Offset: 0x001B6EAF
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.FunctionalComponent.FunctionButton.UnBindGivenUid(0);
	}

	// Token: 0x060081E8 RID: 33256 RVA: 0x001B8CC8 File Offset: 0x001B6EC8
	[NullableContext(1)]
	public void RefreshTimerTextByData(bool isShow, string timeText)
	{
		this.TitleComponent.SetTimeTextVisible(isShow);
		if (isShow)
		{
			this.TitleComponent.SetTimeTextByText(timeText);
		}
	}

	// Token: 0x04003AC8 RID: 15048
	private ActivityBaseData ActivityDataCache;

	// Token: 0x04003AC9 RID: 15049
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003ACA RID: 15050
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003ACB RID: 15051
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003ACC RID: 15052
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x020078A4 RID: 30884
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027BF1 RID: 162801
		public const int TitleItem = 0;

		// Token: 0x04027BF2 RID: 162802
		public const int DescriptionItem = 1;

		// Token: 0x04027BF3 RID: 162803
		public const int RewardListItem = 2;

		// Token: 0x04027BF4 RID: 162804
		public const int FunctionalItem = 3;
	}
}
