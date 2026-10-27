using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024D8 RID: 9432
public class VisionNewRecommendPreviewTopItem : UiPanelBase
{
	// Token: 0x06012F6E RID: 77678 RVA: 0x004B1FA8 File Offset: 0x004B01A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012F6F RID: 77679 RVA: 0x004B2002 File Offset: 0x004B0202
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData>(base.GetHorizontalLayout(1), new Func<VisionAssembleSuitItem>(this.InitItem), null, false, true);
	}

	// Token: 0x06012F70 RID: 77680 RVA: 0x004B2025 File Offset: 0x004B0225
	[NullableContext(1)]
	private VisionAssembleSuitItem InitItem()
	{
		return new VisionAssembleSuitItem();
	}

	// Token: 0x06012F71 RID: 77681 RVA: 0x004B202C File Offset: 0x004B022C
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

	// Token: 0x04008ECC RID: 36556
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> Layout;

	// Token: 0x02008A68 RID: 35432
	private enum ETopComponent
	{
		// Token: 0x0402CF18 RID: 184088
		CostText,
		// Token: 0x0402CF19 RID: 184089
		SuitHorizonScroller,
		// Token: 0x0402CF1A RID: 184090
		SuitItem
	}
}
