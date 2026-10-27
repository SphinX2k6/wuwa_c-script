using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029AC RID: 10668
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerFightFinishItem : GridProxyAbstract<ShipTowerFightFinishItemData>
{
	// Token: 0x06016206 RID: 90630 RVA: 0x00598980 File Offset: 0x00596B80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06016207 RID: 90631 RVA: 0x00598A1C File Offset: 0x00596C1C
	public void Refresh(ShipTowerFightFinishItemData data)
	{
		this.ItemData = data;
		int num = data.ScoreA + data.ScoreB;
		base.GetText(0).SetText(num.ToString(), true);
		base.GetText(1).SetText(data.ScoreA.ToString(), true);
		base.GetText(2).SetText(data.ScoreB.ToString(), true);
		base.GetText(3).ShowTextNew(data.TotalTitle);
		base.GetText(4).ShowTextNew(data.TitleA);
		base.GetText(5).ShowTextNew(data.TitleB);
	}

	// Token: 0x06016208 RID: 90632 RVA: 0x00598AB8 File Offset: 0x00596CB8
	public override void Refresh(ShipTowerFightFinishItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0400A4DC RID: 42204
	private ShipTowerFightFinishItemData ItemData;

	// Token: 0x02008FBF RID: 36799
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E8F0 RID: 190704
		public const int TextTotalScore = 0;

		// Token: 0x0402E8F1 RID: 190705
		public const int TextScoreA = 1;

		// Token: 0x0402E8F2 RID: 190706
		public const int TextScoreB = 2;

		// Token: 0x0402E8F3 RID: 190707
		public const int TextTotalTitle = 3;

		// Token: 0x0402E8F4 RID: 190708
		public const int TextTitleA = 4;

		// Token: 0x0402E8F5 RID: 190709
		public const int TextTitleB = 5;
	}
}
