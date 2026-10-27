using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02002683 RID: 9859
public class QuestReviewNodeDestroyItem : QuestReviewNodeItemBase
{
	// Token: 0x06014349 RID: 82761 RVA: 0x0051A978 File Offset: 0x00518B78
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

	// Token: 0x0601434A RID: 82762 RVA: 0x0051A9E4 File Offset: 0x00518BE4
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

	// Token: 0x02008CD4 RID: 36052
	private class ENodeDestroyComponentDefine
	{
		// Token: 0x0402DB34 RID: 187188
		public const int SpriteLineHorizontal = 0;

		// Token: 0x0402DB35 RID: 187189
		public const int SpriteStartPoint = 1;
	}
}
