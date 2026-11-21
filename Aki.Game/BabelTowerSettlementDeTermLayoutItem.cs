using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200063B RID: 1595
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerSettlementDeTermLayoutItem : GridProxyAbstract<int[]>
{
	// Token: 0x06004A3F RID: 19007 RVA: 0x00193D54 File Offset: 0x00191F54
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

	// Token: 0x06004A40 RID: 19008 RVA: 0x00193D9C File Offset: 0x00191F9C
	protected override void OnStart()
	{
		this.DeTermLayout = new GenericLayout<BabelTowerSettlementDeTermItem, int>(base.GetHorizontalLayout(0), new Func<BabelTowerSettlementDeTermItem>(this.CreateDeTermItem), this.TemplateActor, false, true);
	}

	// Token: 0x06004A41 RID: 19009 RVA: 0x00193DC4 File Offset: 0x00191FC4
	private BabelTowerSettlementDeTermItem CreateDeTermItem()
	{
		return new BabelTowerSettlementDeTermItem();
	}

	// Token: 0x06004A42 RID: 19010 RVA: 0x00193DCB File Offset: 0x00191FCB
	public override void Refresh(int[] data, bool isSelected, int gridIndex)
	{
		GenericLayout<BabelTowerSettlementDeTermItem, int> deTermLayout = this.DeTermLayout;
		if (deTermLayout == null)
		{
			return;
		}
		deTermLayout.RefreshByData(new List<int>(data), null, false);
	}

	// Token: 0x06004A43 RID: 19011 RVA: 0x00193DE5 File Offset: 0x00191FE5
	public void SetLayoutPadding(FMargin padding)
	{
		base.GetHorizontalLayout(0).SetPadding(padding);
	}

	// Token: 0x04003709 RID: 14089
	[Nullable(2)]
	public AUIBaseActor TemplateActor;

	// Token: 0x0400370A RID: 14090
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerSettlementDeTermItem, int> DeTermLayout;

	// Token: 0x020068F0 RID: 26864
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022953 RID: 141651
		public const int DeTermHorizontalLayout = 0;
	}
}
