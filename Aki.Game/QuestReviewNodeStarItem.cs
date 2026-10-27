using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02002684 RID: 9860
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeStarItem : QuestReviewNodeItemBase
{
	// Token: 0x0601434C RID: 82764 RVA: 0x0051AA78 File Offset: 0x00518C78
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601434D RID: 82765 RVA: 0x0051AB24 File Offset: 0x00518D24
	public override void Refresh(IQuestReviewNodeParam param)
	{
		base.GetRootItem().SetAlpha(1f);
		base.GetSprite(0).SetAlpha(0.5f);
		base.GetSprite(2).SetAlpha(0.5f);
		base.GetSprite(1).SetAlpha(0.5f);
		base.GetSprite(1).SetUIActive(!param.IsLastSlotEmpty);
		this.SetSpriteByPath(param.RoundIcon, base.GetSprite(1), false, null, null);
		this.SetSpriteByPath(param.StarIcon, base.GetSprite(3), false, null, null);
		base.GetSprite(0).SetUIActive(true);
		base.GetSprite(2).SetUIActive(false);
		int num = param.IsLastSlot ? 0 : -190;
		this.SpriteLineHorizontal.SetStretchRight((float)num);
		FColor color = FColor.FromHex(param.LineColorHex);
		this.SpriteLineHorizontal.SetColor(color);
	}

	// Token: 0x170019F9 RID: 6649
	// (get) Token: 0x0601434E RID: 82766 RVA: 0x0051AC15 File Offset: 0x00518E15
	private UUISprite SpriteLineHorizontal
	{
		get
		{
			return base.GetSprite(0);
		}
	}

	// Token: 0x02008CD5 RID: 36053
	[NullableContext(0)]
	private class ENodeStarComponentDefine
	{
		// Token: 0x0402DB36 RID: 187190
		public const int SpriteLineHorizontalSolid = 0;

		// Token: 0x0402DB37 RID: 187191
		public const int SpriteStartPoint = 1;

		// Token: 0x0402DB38 RID: 187192
		public const int SpriteLineHorizontalDotted = 2;

		// Token: 0x0402DB39 RID: 187193
		public const int SpriteIcon = 3;
	}
}
