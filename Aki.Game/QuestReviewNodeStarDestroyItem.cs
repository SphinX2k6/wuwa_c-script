using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001B70 RID: 7024
public class QuestReviewNodeStarDestroyItem : QuestReviewNodeItemBase
{
	// Token: 0x06011832 RID: 71730 RVA: 0x00529960 File Offset: 0x00527B60
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

	// Token: 0x06011833 RID: 71731 RVA: 0x005299EC File Offset: 0x00527BEC
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

	// Token: 0x02007E5F RID: 32351
	private class ENodeStarDestroyComponentDefine
	{
		// Token: 0x04028E51 RID: 167505
		public const int SpriteLineHorizontal = 0;

		// Token: 0x04028E52 RID: 167506
		public const int SpriteStartPoint = 1;

		// Token: 0x04028E53 RID: 167507
		public const int ItemAnimRound = 2;
	}
}
