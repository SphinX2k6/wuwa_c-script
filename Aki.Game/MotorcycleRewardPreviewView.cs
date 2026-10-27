using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200226D RID: 8813
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleRewardPreviewView : UiViewBase
{
	// Token: 0x06011343 RID: 70467 RVA: 0x00431AC1 File Offset: 0x0042FCC1
	public MotorcycleRewardPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011344 RID: 70468 RVA: 0x00431AD5 File Offset: 0x0042FCD5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06011345 RID: 70469 RVA: 0x00431B10 File Offset: 0x0042FD10
	protected override void OnStart()
	{
		List<TItem> list = this.OpenParam as List<TItem>;
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.LoopScrollView = new LoopScrollView<CommonItemSmallItemGrid, TItem>(base.GetLoopScrollViewComponent(0), gridActor, new Func<CommonItemSmallItemGrid>(this.OnGridProxyCreate), false);
		this.RewardDataList = (list ?? new List<TItem>());
	}

	// Token: 0x06011346 RID: 70470 RVA: 0x00431B6B File Offset: 0x0042FD6B
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06011347 RID: 70471 RVA: 0x00431B73 File Offset: 0x0042FD73
	private void RefreshView()
	{
		this.LoopScrollView.RefreshByData(this.RewardDataList, false, null, false);
	}

	// Token: 0x06011348 RID: 70472 RVA: 0x00431B89 File Offset: 0x0042FD89
	private CommonItemSmallItemGrid OnGridProxyCreate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x040082F4 RID: 33524
	private List<TItem> RewardDataList = new List<TItem>();

	// Token: 0x040082F5 RID: 33525
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CommonItemSmallItemGrid, TItem> LoopScrollView;

	// Token: 0x02008799 RID: 34713
	[NullableContext(0)]
	private class EMotorRewardPreviewComponent
	{
		// Token: 0x0402C12B RID: 180523
		public const int LoopScrollView = 0;

		// Token: 0x0402C12C RID: 180524
		public const int ScrollItem = 1;
	}
}
