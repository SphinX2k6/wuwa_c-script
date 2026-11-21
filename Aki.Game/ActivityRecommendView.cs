using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200054E RID: 1358
[NullableContext(2)]
[Nullable(0)]
public class ActivityRecommendView : UiViewBase
{
	// Token: 0x06004246 RID: 16966 RVA: 0x00172700 File Offset: 0x00170900
	[NullableContext(1)]
	public ActivityRecommendView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004247 RID: 16967 RVA: 0x0017270C File Offset: 0x0017090C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x0017277C File Offset: 0x0017097C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRecommendView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRecommendView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004249 RID: 16969 RVA: 0x001727C0 File Offset: 0x001709C0
	protected override void OnStart()
	{
		base.OnStart();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
		this.RecommendItemScrollView = new GenericLayout<ActivityRecommendItem, int>(base.GetVerticalLayout(2), new Func<ActivityRecommendItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x00172820 File Offset: 0x00170A20
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (this.Vm == null)
		{
			return;
		}
		ActivityRecommendItem mainQuestItem = this.MainQuestItem;
		if (mainQuestItem != null)
		{
			mainQuestItem.Refresh(this.Vm.GetMainQuestItemId(), false, 0);
		}
		List<int> recommendIdList = this.Vm.GetRecommendIdList();
		GenericLayout<ActivityRecommendItem, int> recommendItemScrollView = this.RecommendItemScrollView;
		if (recommendItemScrollView != null)
		{
			recommendItemScrollView.RefreshByData(recommendIdList, null, true);
		}
		bool uiactive = this.Vm.IsMainQuestAvailable();
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x00172893 File Offset: 0x00170A93
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.Destroy(null);
		}
		this.CaptionItem = null;
	}

	// Token: 0x0600424C RID: 16972 RVA: 0x001728AE File Offset: 0x00170AAE
	[NullableContext(1)]
	private ActivityRecommendItem InitItem()
	{
		ActivityRecommendItem activityRecommendItem = new ActivityRecommendItem();
		activityRecommendItem.SetViewModel(this.Vm);
		return activityRecommendItem;
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x001728C1 File Offset: 0x00170AC1
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040033F3 RID: 13299
	private ActivityRecommendViewModel Vm;

	// Token: 0x040033F4 RID: 13300
	private PopupCaptionItem CaptionItem;

	// Token: 0x040033F5 RID: 13301
	private ActivityRecommendItem MainQuestItem;

	// Token: 0x040033F6 RID: 13302
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRecommendItem, int> RecommendItemScrollView;
}
