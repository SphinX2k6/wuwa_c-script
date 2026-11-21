using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F27 RID: 7975
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerFightFinishItem : GridProxyAbstract<ShipTowerFightFinishItemData>
{
	// Token: 0x06013C0C RID: 80908 RVA: 0x005C38F8 File Offset: 0x005C1AF8
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

	// Token: 0x06013C0D RID: 80909 RVA: 0x005C3994 File Offset: 0x005C1B94
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

	// Token: 0x06013C0E RID: 80910 RVA: 0x005C3A30 File Offset: 0x005C1C30
	public override void Refresh(ShipTowerFightFinishItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0400A8C6 RID: 43206
	private ShipTowerFightFinishItemData ItemData;

	// Token: 0x02008208 RID: 33288
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029FEF RID: 172015
		public const int TextTotalScore = 0;

		// Token: 0x04029FF0 RID: 172016
		public const int TextScoreA = 1;

		// Token: 0x04029FF1 RID: 172017
		public const int TextScoreB = 2;

		// Token: 0x04029FF2 RID: 172018
		public const int TextTotalTitle = 3;

		// Token: 0x04029FF3 RID: 172019
		public const int TextTitleA = 4;

		// Token: 0x04029FF4 RID: 172020
		public const int TextTitleB = 5;
	}
}
