using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001B6F RID: 7023
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeStarItem : QuestReviewNodeItemBase
{
	// Token: 0x0601182E RID: 71726 RVA: 0x005297B0 File Offset: 0x005279B0
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

	// Token: 0x0601182F RID: 71727 RVA: 0x0052985C File Offset: 0x00527A5C
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

	// Token: 0x17001A31 RID: 6705
	// (get) Token: 0x06011830 RID: 71728 RVA: 0x0052994D File Offset: 0x00527B4D
	private UUISprite SpriteLineHorizontal
	{
		get
		{
			return base.GetSprite(0);
		}
	}

	// Token: 0x02007E5E RID: 32350
	[NullableContext(0)]
	private class ENodeStarComponentDefine
	{
		// Token: 0x04028E4D RID: 167501
		public const int SpriteLineHorizontalSolid = 0;

		// Token: 0x04028E4E RID: 167502
		public const int SpriteStartPoint = 1;

		// Token: 0x04028E4F RID: 167503
		public const int SpriteLineHorizontalDotted = 2;

		// Token: 0x04028E50 RID: 167504
		public const int SpriteIcon = 3;
	}
}
