using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200109A RID: 4250
[NullableContext(2)]
[Nullable(0)]
public class ActivityRecommendView : UiViewBase
{
	// Token: 0x06006EB0 RID: 28336 RVA: 0x00169DA0 File Offset: 0x00167FA0
	[NullableContext(1)]
	public ActivityRecommendView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006EB1 RID: 28337 RVA: 0x00169DAC File Offset: 0x00167FAC
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

	// Token: 0x06006EB2 RID: 28338 RVA: 0x00169E1C File Offset: 0x0016801C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRecommendView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRecommendView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006EB3 RID: 28339 RVA: 0x00169E60 File Offset: 0x00168060
	protected override void OnStart()
	{
		base.OnStart();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
		this.RecommendItemScrollView = new GenericLayout<ActivityRecommendItem, int>(base.GetVerticalLayout(2), new Func<ActivityRecommendItem>(this.InitItem), null, false, true);
	}

	// Token: 0x06006EB4 RID: 28340 RVA: 0x00169EC0 File Offset: 0x001680C0
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

	// Token: 0x06006EB5 RID: 28341 RVA: 0x00169F33 File Offset: 0x00168133
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.Destroy(null);
		}
		this.CaptionItem = null;
	}

	// Token: 0x06006EB6 RID: 28342 RVA: 0x00169F4E File Offset: 0x0016814E
	[NullableContext(1)]
	private ActivityRecommendItem InitItem()
	{
		ActivityRecommendItem activityRecommendItem = new ActivityRecommendItem();
		activityRecommendItem.SetViewModel(this.Vm);
		return activityRecommendItem;
	}

	// Token: 0x06006EB7 RID: 28343 RVA: 0x00169F61 File Offset: 0x00168161
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400335A RID: 13146
	private ActivityRecommendViewModel Vm;

	// Token: 0x0400335B RID: 13147
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400335C RID: 13148
	private ActivityRecommendItem MainQuestItem;

	// Token: 0x0400335D RID: 13149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRecommendItem, int> RecommendItemScrollView;
}
