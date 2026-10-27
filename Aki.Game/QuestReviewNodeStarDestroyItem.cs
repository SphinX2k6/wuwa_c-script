using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02002685 RID: 9861
public class QuestReviewNodeStarDestroyItem : QuestReviewNodeItemBase
{
	// Token: 0x06014350 RID: 82768 RVA: 0x0051AC28 File Offset: 0x00518E28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014351 RID: 82769 RVA: 0x0051ACB4 File Offset: 0x00518EB4
	[NullableContext(1)]
	public override void Refresh(IQuestReviewNodeParam param)
	{
		base.GetRootItem().SetAlpha(1f);
		base.GetSprite(0).SetAlpha(0.5f);
		base.GetSprite(1).SetAlpha(0.5f);
		base.GetSprite(1).SetUIActive(!param.IsLastSlotEmpty);
		base.GetItem(2).SetUIActive(!param.IsLastSlotEmpty);
		this.SetSpriteByPath(param.RoundIcon, base.GetSprite(1), false, null, null);
		FColor color = FColor.FromHex(param.LineColorHex);
		base.GetSprite(0).SetColor(color);
		int num = param.IsLastSlot ? 0 : -190;
		base.GetSprite(0).SetStretchRight((float)num);
	}

	// Token: 0x02008CD6 RID: 36054
	private class ENodeStarDestroyComponentDefine
	{
		// Token: 0x0402DB3A RID: 187194
		public const int SpriteLineHorizontal = 0;

		// Token: 0x0402DB3B RID: 187195
		public const int SpriteStartPoint = 1;

		// Token: 0x0402DB3C RID: 187196
		public const int ItemAnimRound = 2;
	}
}
