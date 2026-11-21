using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008F2 RID: 2290
public class ActivityRegressRecommendView : ActivityRegressMainSubViewBase
{
	// Token: 0x060065E7 RID: 26087 RVA: 0x001FD834 File Offset: 0x001FBA34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x060065E8 RID: 26088 RVA: 0x001FD870 File Offset: 0x001FBA70
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRecommendView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRecommendView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060065E9 RID: 26089 RVA: 0x001FD8B3 File Offset: 0x001FBAB3
	protected override void OnStart()
	{
		base.OnStart();
		this.RecommendItemScrollView = new GenericLayout<ActivityRegressRecommendItem, int>(base.GetVerticalLayout(1), new Func<ActivityRegressRecommendItem>(this.InitItem), null, false, true);
	}

	// Token: 0x060065EA RID: 26090 RVA: 0x001FD8DC File Offset: 0x001FBADC
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		List<int> recommendDataList = ActivityRegressModel.Instance.GetRecommendDataList();
		this.RecommendItemScrollView.RefreshByData(recommendDataList, null, true);
	}

	// Token: 0x060065EB RID: 26091 RVA: 0x001FD908 File Offset: 0x001FBB08
	[NullableContext(1)]
	private ActivityRegressRecommendItem InitItem()
	{
		return new ActivityRegressRecommendItem();
	}

	// Token: 0x0400415F RID: 16735
	private const int MAIN_QUEST_ITEM_ID = 1;

	// Token: 0x04004160 RID: 16736
	[Nullable(2)]
	private ActivityRegressRecommendItem MainQuestItem;

	// Token: 0x04004161 RID: 16737
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRegressRecommendItem, int> RecommendItemScrollView;

	// Token: 0x02006BF0 RID: 27632
	private class EComponents
	{
		// Token: 0x040237A1 RID: 145313
		public const int MainQuestItem = 0;

		// Token: 0x040237A2 RID: 145314
		public const int RecommendItemLayout = 1;
	}
}
