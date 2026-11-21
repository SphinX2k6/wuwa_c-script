using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001751 RID: 5969
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleRewardPreviewView : UiViewBase
{
	// Token: 0x0600E7D9 RID: 59353 RVA: 0x0043E6CD File Offset: 0x0043C8CD
	public MotorcycleRewardPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E7DA RID: 59354 RVA: 0x0043E6E1 File Offset: 0x0043C8E1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600E7DB RID: 59355 RVA: 0x0043E71C File Offset: 0x0043C91C
	protected override void OnStart()
	{
		List<TItem> list = this.OpenParam as List<TItem>;
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.LoopScrollView = new LoopScrollView<CommonItemSmallItemGrid, TItem>(base.GetLoopScrollViewComponent(0), gridActor, new Func<CommonItemSmallItemGrid>(this.OnGridProxyCreate), false);
		this.RewardDataList = (list ?? new List<TItem>());
	}

	// Token: 0x0600E7DC RID: 59356 RVA: 0x0043E777 File Offset: 0x0043C977
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600E7DD RID: 59357 RVA: 0x0043E77F File Offset: 0x0043C97F
	private void RefreshView()
	{
		this.LoopScrollView.RefreshByData(this.RewardDataList, false, null, false);
	}

	// Token: 0x0600E7DE RID: 59358 RVA: 0x0043E795 File Offset: 0x0043C995
	private CommonItemSmallItemGrid OnGridProxyCreate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x04008432 RID: 33842
	private List<TItem> RewardDataList = new List<TItem>();

	// Token: 0x04008433 RID: 33843
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CommonItemSmallItemGrid, TItem> LoopScrollView;

	// Token: 0x02007922 RID: 31010
	[NullableContext(0)]
	private class EMotorRewardPreviewComponent
	{
		// Token: 0x04027443 RID: 160835
		public const int LoopScrollView = 0;

		// Token: 0x04027444 RID: 160836
		public const int ScrollItem = 1;
	}
}
