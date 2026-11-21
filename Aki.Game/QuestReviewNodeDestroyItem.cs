using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001B6E RID: 7022
public class QuestReviewNodeDestroyItem : QuestReviewNodeItemBase
{
	// Token: 0x0601182B RID: 71723 RVA: 0x005296B0 File Offset: 0x005278B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601182C RID: 71724 RVA: 0x0052971C File Offset: 0x0052791C
	[NullableContext(1)]
	public override void Refresh(IQuestReviewNodeParam param)
	{
		base.GetRootItem().SetAlpha(1f);
		base.GetSprite(0).SetAlpha(0.5f);
		base.GetSprite(1).SetAlpha(0.5f);
		base.GetSprite(1).SetUIActive(!param.IsLastSlotEmpty);
		this.SetSpriteByPath(param.RoundIcon, base.GetSprite(1), false, null, null);
		FColor color = FColor.FromHex(param.LineColorHex);
		base.GetSprite(0).SetColor(color);
	}

	// Token: 0x02007E5D RID: 32349
	private class ENodeDestroyComponentDefine
	{
		// Token: 0x04028E4B RID: 167499
		public const int SpriteLineHorizontal = 0;

		// Token: 0x04028E4C RID: 167500
		public const int SpriteStartPoint = 1;
	}
}
