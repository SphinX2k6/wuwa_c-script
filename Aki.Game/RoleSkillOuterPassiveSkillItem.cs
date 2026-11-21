using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E39 RID: 7737
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillOuterPassiveSkillItem : RoleSkillTreeSkillItemBase
{
	// Token: 0x06013227 RID: 78375 RVA: 0x00597A98 File Offset: 0x00595C98
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

	// Token: 0x06013228 RID: 78376 RVA: 0x00597BC7 File Offset: 0x00595DC7
	protected override UUIItem GetSkillIconItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x06013229 RID: 78377 RVA: 0x00597BD0 File Offset: 0x00595DD0
	protected override UUIItem GetLockItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x0601322A RID: 78378 RVA: 0x00597BD9 File Offset: 0x00595DD9
	protected override UUIText GetNameText()
	{
		return base.GetText(3);
	}

	// Token: 0x0601322B RID: 78379 RVA: 0x00597BE2 File Offset: 0x00595DE2
	protected override UUIItem GetStrongArrowUpItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x0601322C RID: 78380 RVA: 0x00597BEB File Offset: 0x00595DEB
	public override ESkillTreeNodeType? GetType()
	{
		return new ESkillTreeNodeType?(ESkillTreeNodeType.OuterPassiveSkill);
	}

	// Token: 0x0601322D RID: 78381 RVA: 0x00597BF3 File Offset: 0x00595DF3
	protected override UUIItem GetLeftBranchItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x0601322E RID: 78382 RVA: 0x00597BFC File Offset: 0x00595DFC
	protected override UUISprite GetLeftBranchIcon()
	{
		return base.GetSprite(5);
	}

	// Token: 0x0601322F RID: 78383 RVA: 0x00597C05 File Offset: 0x00595E05
	protected override UUIItem GetRightBranchItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x06013230 RID: 78384 RVA: 0x00597C0E File Offset: 0x00595E0E
	protected override UUISprite GetRightBranchIcon()
	{
		return base.GetSprite(7);
	}

	// Token: 0x0200810C RID: 33036
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029BB3 RID: 170931
		SkillIconItem,
		// Token: 0x04029BB4 RID: 170932
		LockItem,
		// Token: 0x04029BB5 RID: 170933
		StrongArrowUpItem,
		// Token: 0x04029BB6 RID: 170934
		NameText,
		// Token: 0x04029BB7 RID: 170935
		LeftBranchItem,
		// Token: 0x04029BB8 RID: 170936
		LeftBranchIconSprite,
		// Token: 0x04029BB9 RID: 170937
		RightBranchItem,
		// Token: 0x04029BBA RID: 170938
		RightBranchIconSprite
	}
}
