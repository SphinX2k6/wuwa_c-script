using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001928 RID: 6440
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionFetterMonsterItem : GridProxyAbstract<VisionFetterMonsterData>
{
	// Token: 0x0600FE85 RID: 65157 RVA: 0x004A551C File Offset: 0x004A371C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600FE86 RID: 65158 RVA: 0x004A5576 File Offset: 0x004A3776
	protected override void OnStart()
	{
		this.MonsterLayout = new GenericLayout<VisionDetailMonsterItem, VisionDetailMonsterItemData>(base.GetGridLayout(1), new Func<VisionDetailMonsterItem>(this.InitMonsterItem), null, false, true);
	}

	// Token: 0x0600FE87 RID: 65159 RVA: 0x004A5599 File Offset: 0x004A3799
	private VisionDetailMonsterItem InitMonsterItem()
	{
		return new VisionDetailMonsterItem();
	}

	// Token: 0x0600FE88 RID: 65160 RVA: 0x004A55A0 File Offset: 0x004A37A0
	public override void Refresh(VisionFetterMonsterData data, bool isSelected, int gridIndex)
	{
		this.RefreshCost(data);
		this.RefreshMonster(data);
	}

	// Token: 0x0600FE89 RID: 65161 RVA: 0x004A55B0 File Offset: 0x004A37B0
	private void RefreshCost(VisionFetterMonsterData data)
	{
		int cost = data.Cost;
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(cost);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600FE8A RID: 65162 RVA: 0x004A55E9 File Offset: 0x004A37E9
	private void RefreshMonster(VisionFetterMonsterData data)
	{
		this.MonsterLayout.RefreshByData(data.MonsterList, null, false);
	}

	// Token: 0x04008D9A RID: 36250
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionDetailMonsterItem, VisionDetailMonsterItemData> MonsterLayout;

	// Token: 0x02007B54 RID: 31572
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027F5C RID: 163676
		CostText,
		// Token: 0x04027F5D RID: 163677
		MonsterLayout,
		// Token: 0x04027F5E RID: 163678
		MonsterItem
	}
}
