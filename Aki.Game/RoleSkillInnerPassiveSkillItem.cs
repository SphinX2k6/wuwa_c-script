using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028B2 RID: 10418
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillInnerPassiveSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x060157C7 RID: 88007 RVA: 0x0056B388 File Offset: 0x00569588
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060157C8 RID: 88008 RVA: 0x0056B4FB File Offset: 0x005696FB
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x060157C9 RID: 88009 RVA: 0x0056B504 File Offset: 0x00569704
	protected override UUIText GetLevelText()
	{
		return base.GetText(1);
	}

	// Token: 0x060157CA RID: 88010 RVA: 0x0056B50D File Offset: 0x0056970D
	protected override UUIText GetNameText()
	{
		return base.GetText(2);
	}

	// Token: 0x060157CB RID: 88011 RVA: 0x0056B516 File Offset: 0x00569716
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x060157CC RID: 88012 RVA: 0x0056B51F File Offset: 0x0056971F
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.InnerPassiveSkill);
	}

	// Token: 0x060157CD RID: 88013 RVA: 0x0056B527 File Offset: 0x00569727
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060157CE RID: 88014 RVA: 0x0056B530 File Offset: 0x00569730
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x060157CF RID: 88015 RVA: 0x0056B539 File Offset: 0x00569739
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060157D0 RID: 88016 RVA: 0x0056B542 File Offset: 0x00569742
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x060157D1 RID: 88017 RVA: 0x0056B54B File Offset: 0x0056974B
	protected override UUIItem GetShowTagItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x060157D2 RID: 88018 RVA: 0x0056B554 File Offset: 0x00569754
	protected override UUITexture GetShowTagTex()
	{
		return base.GetTexture(9);
	}

	// Token: 0x02008EB3 RID: 36531
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E452 RID: 189522
		SkillIconItem,
		// Token: 0x0402E453 RID: 189523
		LevelText,
		// Token: 0x0402E454 RID: 189524
		NameText,
		// Token: 0x0402E455 RID: 189525
		StrongArrowUpItem,
		// Token: 0x0402E456 RID: 189526
		LeftBranchItem,
		// Token: 0x0402E457 RID: 189527
		LeftBranchIconSprite,
		// Token: 0x0402E458 RID: 189528
		RightBranchItem,
		// Token: 0x0402E459 RID: 189529
		RightBranchIconSprite,
		// Token: 0x0402E45A RID: 189530
		ShowTagItem,
		// Token: 0x0402E45B RID: 189531
		ShowTagTex
	}
}
