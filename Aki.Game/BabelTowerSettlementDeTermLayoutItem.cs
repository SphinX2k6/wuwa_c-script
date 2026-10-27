using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001187 RID: 4487
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerSettlementDeTermLayoutItem : GridProxyAbstract<int[]>
{
	// Token: 0x060076A8 RID: 30376 RVA: 0x0018B1A4 File Offset: 0x001893A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060076A9 RID: 30377 RVA: 0x0018B1EC File Offset: 0x001893EC
	protected override void OnStart()
	{
		this.DeTermLayout = new GenericLayout<BabelTowerSettlementDeTermItem, int>(base.GetHorizontalLayout(0), new Func<BabelTowerSettlementDeTermItem>(this.CreateDeTermItem), this.TemplateActor, false, true);
	}

	// Token: 0x060076AA RID: 30378 RVA: 0x0018B214 File Offset: 0x00189414
	private BabelTowerSettlementDeTermItem CreateDeTermItem()
	{
		return new BabelTowerSettlementDeTermItem();
	}

	// Token: 0x060076AB RID: 30379 RVA: 0x0018B21B File Offset: 0x0018941B
	public override void Refresh(int[] data, bool isSelected, int gridIndex)
	{
		GenericLayout<BabelTowerSettlementDeTermItem, int> deTermLayout = this.DeTermLayout;
		if (deTermLayout == null)
		{
			return;
		}
		deTermLayout.RefreshByData(new List<int>(data), null, false);
	}

	// Token: 0x060076AC RID: 30380 RVA: 0x0018B235 File Offset: 0x00189435
	public void SetLayoutPadding(FMargin padding)
	{
		base.GetHorizontalLayout(0).SetPadding(padding);
	}

	// Token: 0x04003670 RID: 13936
	[Nullable(2)]
	public AUIBaseActor TemplateActor;

	// Token: 0x04003671 RID: 13937
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerSettlementDeTermItem, int> DeTermLayout;

	// Token: 0x02007763 RID: 30563
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402761A RID: 161306
		public const int DeTermHorizontalLayout = 0;
	}
}
