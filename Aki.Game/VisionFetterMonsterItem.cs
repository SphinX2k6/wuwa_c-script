using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002443 RID: 9283
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionFetterMonsterItem : GridProxyAbstract<VisionFetterMonsterData>
{
	// Token: 0x060129CF RID: 76239 RVA: 0x00497F48 File Offset: 0x00496148
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060129D0 RID: 76240 RVA: 0x00497FA2 File Offset: 0x004961A2
	protected override void OnStart()
	{
		this.MonsterLayout = new GenericLayout<VisionDetailMonsterItem, VisionDetailMonsterItemData>(base.GetGridLayout(1), new Func<VisionDetailMonsterItem>(this.InitMonsterItem), null, false, true);
	}

	// Token: 0x060129D1 RID: 76241 RVA: 0x00497FC5 File Offset: 0x004961C5
	private VisionDetailMonsterItem InitMonsterItem()
	{
		return new VisionDetailMonsterItem();
	}

	// Token: 0x060129D2 RID: 76242 RVA: 0x00497FCC File Offset: 0x004961CC
	public override void Refresh(VisionFetterMonsterData data, bool isSelected, int gridIndex)
	{
		this.RefreshCost(data);
		this.RefreshMonster(data);
	}

	// Token: 0x060129D3 RID: 76243 RVA: 0x00497FDC File Offset: 0x004961DC
	private void RefreshCost(VisionFetterMonsterData data)
	{
		int cost = data.Cost;
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(cost);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060129D4 RID: 76244 RVA: 0x00498015 File Offset: 0x00496215
	private void RefreshMonster(VisionFetterMonsterData data)
	{
		this.MonsterLayout.RefreshByData(data.MonsterList, null, false);
	}

	// Token: 0x04008C53 RID: 35923
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionDetailMonsterItem, VisionDetailMonsterItemData> MonsterLayout;

	// Token: 0x020089CD RID: 35277
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CC46 RID: 183366
		CostText,
		// Token: 0x0402CC47 RID: 183367
		MonsterLayout,
		// Token: 0x0402CC48 RID: 183368
		MonsterItem
	}
}
