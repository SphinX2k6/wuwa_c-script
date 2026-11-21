using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019BF RID: 6591
public class VisionNewRecommendPreviewTopItem : UiPanelBase
{
	// Token: 0x0601042D RID: 66605 RVA: 0x004BFBA8 File Offset: 0x004BDDA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0601042E RID: 66606 RVA: 0x004BFC02 File Offset: 0x004BDE02
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData>(base.GetHorizontalLayout(1), new Func<VisionAssembleSuitItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0601042F RID: 66607 RVA: 0x004BFC25 File Offset: 0x004BDE25
	[NullableContext(1)]
	private VisionAssembleSuitItem InitItem()
	{
		return new VisionAssembleSuitItem();
	}

	// Token: 0x06010430 RID: 66608 RVA: 0x004BFC2C File Offset: 0x004BDE2C
	[NullableContext(1)]
	public void Refresh(VisionNewRecommendPreviewTopData data)
	{
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Cost);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxCost);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data.SuitList, null, false);
	}

	// Token: 0x04009016 RID: 36886
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> Layout;

	// Token: 0x02007BF1 RID: 31729
	private enum ETopComponent
	{
		// Token: 0x04028236 RID: 164406
		CostText,
		// Token: 0x04028237 RID: 164407
		SuitHorizonScroller,
		// Token: 0x04028238 RID: 164408
		SuitItem
	}
}
