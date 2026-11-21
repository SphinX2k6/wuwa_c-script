using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E2F RID: 7727
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillInnerSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x060131D7 RID: 78295 RVA: 0x00596558 File Offset: 0x00594758
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

	// Token: 0x060131D8 RID: 78296 RVA: 0x005966CB File Offset: 0x005948CB
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x060131D9 RID: 78297 RVA: 0x005966D4 File Offset: 0x005948D4
	protected override UUIText GetLevelText()
	{
		return base.GetText(1);
	}

	// Token: 0x060131DA RID: 78298 RVA: 0x005966DD File Offset: 0x005948DD
	protected override UUIText GetNameText()
	{
		return base.GetText(2);
	}

	// Token: 0x060131DB RID: 78299 RVA: 0x005966E6 File Offset: 0x005948E6
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x060131DC RID: 78300 RVA: 0x005966EF File Offset: 0x005948EF
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.InnerSkill);
	}

	// Token: 0x060131DD RID: 78301 RVA: 0x005966F7 File Offset: 0x005948F7
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060131DE RID: 78302 RVA: 0x00596700 File Offset: 0x00594900
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x060131DF RID: 78303 RVA: 0x00596709 File Offset: 0x00594909
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060131E0 RID: 78304 RVA: 0x00596712 File Offset: 0x00594912
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x060131E1 RID: 78305 RVA: 0x0059671B File Offset: 0x0059491B
	protected override UUIItem GetShowTagItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x060131E2 RID: 78306 RVA: 0x00596724 File Offset: 0x00594924
	protected override UUITexture GetShowTagTex()
	{
		return base.GetTexture(9);
	}

	// Token: 0x020080FC RID: 33020
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029B60 RID: 170848
		SkillIconItem,
		// Token: 0x04029B61 RID: 170849
		LevelText,
		// Token: 0x04029B62 RID: 170850
		NameText,
		// Token: 0x04029B63 RID: 170851
		StrongArrowUpItem,
		// Token: 0x04029B64 RID: 170852
		LeftBranchItem,
		// Token: 0x04029B65 RID: 170853
		LeftBranchIconSprite,
		// Token: 0x04029B66 RID: 170854
		RightBranchItem,
		// Token: 0x04029B67 RID: 170855
		RightBranchIconSprite,
		// Token: 0x04029B68 RID: 170856
		ShowTagItem,
		// Token: 0x04029B69 RID: 170857
		ShowTagTex
	}
}
