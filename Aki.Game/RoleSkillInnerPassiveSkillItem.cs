using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E2D RID: 7725
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillInnerPassiveSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x060131C7 RID: 78279 RVA: 0x005961D0 File Offset: 0x005943D0
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

	// Token: 0x060131C8 RID: 78280 RVA: 0x00596343 File Offset: 0x00594543
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x060131C9 RID: 78281 RVA: 0x0059634C File Offset: 0x0059454C
	protected override UUIText GetLevelText()
	{
		return base.GetText(1);
	}

	// Token: 0x060131CA RID: 78282 RVA: 0x00596355 File Offset: 0x00594555
	protected override UUIText GetNameText()
	{
		return base.GetText(2);
	}

	// Token: 0x060131CB RID: 78283 RVA: 0x0059635E File Offset: 0x0059455E
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x060131CC RID: 78284 RVA: 0x00596367 File Offset: 0x00594567
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.InnerPassiveSkill);
	}

	// Token: 0x060131CD RID: 78285 RVA: 0x0059636F File Offset: 0x0059456F
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060131CE RID: 78286 RVA: 0x00596378 File Offset: 0x00594578
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x060131CF RID: 78287 RVA: 0x00596381 File Offset: 0x00594581
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060131D0 RID: 78288 RVA: 0x0059638A File Offset: 0x0059458A
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x060131D1 RID: 78289 RVA: 0x00596393 File Offset: 0x00594593
	protected override UUIItem GetShowTagItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x060131D2 RID: 78290 RVA: 0x0059639C File Offset: 0x0059459C
	protected override UUITexture GetShowTagTex()
	{
		return base.GetTexture(9);
	}

	// Token: 0x020080FA RID: 33018
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029B4F RID: 170831
		SkillIconItem,
		// Token: 0x04029B50 RID: 170832
		LevelText,
		// Token: 0x04029B51 RID: 170833
		NameText,
		// Token: 0x04029B52 RID: 170834
		StrongArrowUpItem,
		// Token: 0x04029B53 RID: 170835
		LeftBranchItem,
		// Token: 0x04029B54 RID: 170836
		LeftBranchIconSprite,
		// Token: 0x04029B55 RID: 170837
		RightBranchItem,
		// Token: 0x04029B56 RID: 170838
		RightBranchIconSprite,
		// Token: 0x04029B57 RID: 170839
		ShowTagItem,
		// Token: 0x04029B58 RID: 170840
		ShowTagTex
	}
}
