using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000742 RID: 1858
[NullableContext(2)]
[Nullable(0)]
public class InviteNewbieActivityItem : UiPanelBase
{
	// Token: 0x06005579 RID: 21881 RVA: 0x001C170C File Offset: 0x001BF90C
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

	// Token: 0x0600557A RID: 21882 RVA: 0x001C17B8 File Offset: 0x001BF9B8
	protected override UniTask OnBeforeStartAsync()
	{
		InviteNewbieActivityItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InviteNewbieActivityItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600557B RID: 21883 RVA: 0x001C17FC File Offset: 0x001BF9FC
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

	// Token: 0x0600557C RID: 21884 RVA: 0x001C1943 File Offset: 0x001BFB43
	private void OnClickEnter()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityDataCache, delegate()
		{
			InviteNewbieProtocolContext activityData = this.ActivityDataCache as InviteNewbieProtocolContext;
			ActivityInviteNewbieController.Instance.HandleOnEnterClick(activityData);
		});
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x001C1961 File Offset: 0x001BFB61
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.FunctionalComponent.FunctionButton.BindRedDot(ERedDotName.InviteNewbie, 0);
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x001C197F File Offset: 0x001BFB7F
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.FunctionalComponent.FunctionButton.UnBindGivenUid(0);
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x001C1998 File Offset: 0x001BFB98
	[NullableContext(1)]
	public void RefreshTimerTextByData(bool isShow, string timeText)
	{
		this.TitleComponent.SetTimeTextVisible(isShow);
		if (isShow)
		{
			this.TitleComponent.SetTimeTextByText(timeText);
		}
	}

	// Token: 0x04003B60 RID: 15200
	private ActivityBaseData ActivityDataCache;

	// Token: 0x04003B61 RID: 15201
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003B62 RID: 15202
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003B63 RID: 15203
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003B64 RID: 15204
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02006A2F RID: 27183
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022F22 RID: 143138
		public const int TitleItem = 0;

		// Token: 0x04022F23 RID: 143139
		public const int DescriptionItem = 1;

		// Token: 0x04022F24 RID: 143140
		public const int RewardListItem = 2;

		// Token: 0x04022F25 RID: 143141
		public const int FunctionalItem = 3;
	}
}
