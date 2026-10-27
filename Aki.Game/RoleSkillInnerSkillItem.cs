using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028B4 RID: 10420
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillInnerSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x060157D7 RID: 88023 RVA: 0x0056B710 File Offset: 0x00569910
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

	// Token: 0x060157D8 RID: 88024 RVA: 0x0056B883 File Offset: 0x00569A83
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x060157D9 RID: 88025 RVA: 0x0056B88C File Offset: 0x00569A8C
	protected override UUIText GetLevelText()
	{
		return base.GetText(1);
	}

	// Token: 0x060157DA RID: 88026 RVA: 0x0056B895 File Offset: 0x00569A95
	protected override UUIText GetNameText()
	{
		return base.GetText(2);
	}

	// Token: 0x060157DB RID: 88027 RVA: 0x0056B89E File Offset: 0x00569A9E
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x060157DC RID: 88028 RVA: 0x0056B8A7 File Offset: 0x00569AA7
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.InnerSkill);
	}

	// Token: 0x060157DD RID: 88029 RVA: 0x0056B8AF File Offset: 0x00569AAF
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060157DE RID: 88030 RVA: 0x0056B8B8 File Offset: 0x00569AB8
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x060157DF RID: 88031 RVA: 0x0056B8C1 File Offset: 0x00569AC1
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060157E0 RID: 88032 RVA: 0x0056B8CA File Offset: 0x00569ACA
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x060157E1 RID: 88033 RVA: 0x0056B8D3 File Offset: 0x00569AD3
	protected override UUIItem GetShowTagItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x060157E2 RID: 88034 RVA: 0x0056B8DC File Offset: 0x00569ADC
	protected override UUITexture GetShowTagTex()
	{
		return base.GetTexture(9);
	}

	// Token: 0x02008EB5 RID: 36533
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E463 RID: 189539
		SkillIconItem,
		// Token: 0x0402E464 RID: 189540
		LevelText,
		// Token: 0x0402E465 RID: 189541
		NameText,
		// Token: 0x0402E466 RID: 189542
		StrongArrowUpItem,
		// Token: 0x0402E467 RID: 189543
		LeftBranchItem,
		// Token: 0x0402E468 RID: 189544
		LeftBranchIconSprite,
		// Token: 0x0402E469 RID: 189545
		RightBranchItem,
		// Token: 0x0402E46A RID: 189546
		RightBranchIconSprite,
		// Token: 0x0402E46B RID: 189547
		ShowTagItem,
		// Token: 0x0402E46C RID: 189548
		ShowTagTex
	}
}
