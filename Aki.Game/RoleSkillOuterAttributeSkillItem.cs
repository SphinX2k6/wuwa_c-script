using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E38 RID: 7736
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillOuterAttributeSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x06013220 RID: 78368 RVA: 0x005979E0 File Offset: 0x00595BE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013221 RID: 78369 RVA: 0x00597A6A File Offset: 0x00595C6A
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x06013222 RID: 78370 RVA: 0x00597A73 File Offset: 0x00595C73
	protected override UUIItem GetLockItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x06013223 RID: 78371 RVA: 0x00597A7C File Offset: 0x00595C7C
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x06013224 RID: 78372 RVA: 0x00597A85 File Offset: 0x00595C85
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.OuterAttribute);
	}

	// Token: 0x06013225 RID: 78373 RVA: 0x00597A8D File Offset: 0x00595C8D
	public override bool IsIconTexture()
	{
		return true;
	}

	// Token: 0x0200810B RID: 33035
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029BAF RID: 170927
		SkillIconItem,
		// Token: 0x04029BB0 RID: 170928
		LockItem,
		// Token: 0x04029BB1 RID: 170929
		StrongArrowUpItem
	}
}
