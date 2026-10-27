using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028BD RID: 10429
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillOuterAttributeSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x06015820 RID: 88096 RVA: 0x0056CB98 File Offset: 0x0056AD98
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

	// Token: 0x06015821 RID: 88097 RVA: 0x0056CC22 File Offset: 0x0056AE22
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x06015822 RID: 88098 RVA: 0x0056CC2B File Offset: 0x0056AE2B
	protected override UUIItem GetLockItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x06015823 RID: 88099 RVA: 0x0056CC34 File Offset: 0x0056AE34
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x06015824 RID: 88100 RVA: 0x0056CC3D File Offset: 0x0056AE3D
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.OuterAttribute);
	}

	// Token: 0x06015825 RID: 88101 RVA: 0x0056CC45 File Offset: 0x0056AE45
	public override bool IsIconTexture()
	{
		return true;
	}

	// Token: 0x02008EC4 RID: 36548
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E4B2 RID: 189618
		SkillIconItem,
		// Token: 0x0402E4B3 RID: 189619
		LockItem,
		// Token: 0x0402E4B4 RID: 189620
		StrongArrowUpItem
	}
}
