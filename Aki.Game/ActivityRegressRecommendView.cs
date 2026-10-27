using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200143E RID: 5182
public class ActivityRegressRecommendView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009252 RID: 37458 RVA: 0x001F4CF8 File Offset: 0x001F2EF8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x06009253 RID: 37459 RVA: 0x001F4D34 File Offset: 0x001F2F34
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRecommendView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRecommendView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009254 RID: 37460 RVA: 0x001F4D77 File Offset: 0x001F2F77
	protected override void OnStart()
	{
		base.OnStart();
		this.RecommendItemScrollView = new GenericLayout<ActivityRegressRecommendItem, int>(base.GetVerticalLayout(1), new Func<ActivityRegressRecommendItem>(this.InitItem), null, false, true);
	}

	// Token: 0x06009255 RID: 37461 RVA: 0x001F4DA0 File Offset: 0x001F2FA0
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		List<int> recommendDataList = ActivityRegressModel.Instance.GetRecommendDataList();
		this.RecommendItemScrollView.RefreshByData(recommendDataList, null, true);
	}

	// Token: 0x06009256 RID: 37462 RVA: 0x001F4DCC File Offset: 0x001F2FCC
	[NullableContext(1)]
	private ActivityRegressRecommendItem InitItem()
	{
		return new ActivityRegressRecommendItem();
	}

	// Token: 0x040040C7 RID: 16583
	private const int MAIN_QUEST_ITEM_ID = 1;

	// Token: 0x040040C8 RID: 16584
	[Nullable(2)]
	private ActivityRegressRecommendItem MainQuestItem;

	// Token: 0x040040C9 RID: 16585
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRegressRecommendItem, int> RecommendItemScrollView;

	// Token: 0x02007A6C RID: 31340
	private class EComponents
	{
		// Token: 0x04028487 RID: 164999
		public const int MainQuestItem = 0;

		// Token: 0x04028488 RID: 165000
		public const int RecommendItemLayout = 1;
	}
}
