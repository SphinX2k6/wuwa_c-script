using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028BE RID: 10430
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillOuterPassiveSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x06015827 RID: 88103 RVA: 0x0056CC50 File Offset: 0x0056AE50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015828 RID: 88104 RVA: 0x0056CD7F File Offset: 0x0056AF7F
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x06015829 RID: 88105 RVA: 0x0056CD88 File Offset: 0x0056AF88
	protected override UUIItem GetLockItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x0601582A RID: 88106 RVA: 0x0056CD91 File Offset: 0x0056AF91
	protected override UUIText GetNameText()
	{
		return base.GetText(3);
	}

	// Token: 0x0601582B RID: 88107 RVA: 0x0056CD9A File Offset: 0x0056AF9A
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x0601582C RID: 88108 RVA: 0x0056CDA3 File Offset: 0x0056AFA3
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.OuterPassiveSkill);
	}

	// Token: 0x0601582D RID: 88109 RVA: 0x0056CDAB File Offset: 0x0056AFAB
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x0601582E RID: 88110 RVA: 0x0056CDB4 File Offset: 0x0056AFB4
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x0601582F RID: 88111 RVA: 0x0056CDBD File Offset: 0x0056AFBD
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x06015830 RID: 88112 RVA: 0x0056CDC6 File Offset: 0x0056AFC6
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x02008EC5 RID: 36549
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E4B6 RID: 189622
		SkillIconItem,
		// Token: 0x0402E4B7 RID: 189623
		LockItem,
		// Token: 0x0402E4B8 RID: 189624
		StrongArrowUpItem,
		// Token: 0x0402E4B9 RID: 189625
		NameText,
		// Token: 0x0402E4BA RID: 189626
		LeftBranchItem,
		// Token: 0x0402E4BB RID: 189627
		LeftBranchIconSprite,
		// Token: 0x0402E4BC RID: 189628
		RightBranchItem,
		// Token: 0x0402E4BD RID: 189629
		RightBranchIconSprite
	}
}
