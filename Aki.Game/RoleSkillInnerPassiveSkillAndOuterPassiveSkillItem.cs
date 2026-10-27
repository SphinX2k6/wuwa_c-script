using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028B1 RID: 10417
public class RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem : RoleSkillChainItem
{
	// Token: 0x060157C4 RID: 88004 RVA: 0x0056B1E0 File Offset: 0x005693E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060157C5 RID: 88005 RVA: 0x0056B2AC File Offset: 0x005694AC
	protected override void OnStart()
	{
		RoleSkillInnerPassiveSkillItem roleSkillInnerPassiveSkillItem = new RoleSkillInnerPassiveSkillItem();
		roleSkillInnerPassiveSkillItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		roleSkillInnerPassiveSkillItem.SetSkillBranchEnable(this.IsSkillBranchEnable);
		this.SkillNodeItemList.Add(roleSkillInnerPassiveSkillItem);
		foreach (RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent name in new RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent[]
		{
			RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent.OuterPassiveSkillItem1,
			RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent.OuterPassiveSkillItem2
		})
		{
			UUIItem item = base.GetItem((int)name);
			RoleSkillOuterPassiveSkillItem roleSkillOuterPassiveSkillItem = new RoleSkillOuterPassiveSkillItem();
			roleSkillOuterPassiveSkillItem.SetSkillBranchEnable(this.IsSkillBranchEnable);
			roleSkillOuterPassiveSkillItem.CreateThenShowByActor(item.GetOwner(), null);
			this.SkillNodeItemList.Add(roleSkillOuterPassiveSkillItem);
		}
		foreach (RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent name2 in new RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent[]
		{
			RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent.LineItem1,
			RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem.EComponent.LineItem2
		})
		{
			UUIItem item2 = base.GetItem((int)name2);
			this.LineItemList.Add(item2);
		}
	}

	// Token: 0x02008EB2 RID: 36530
	private enum EComponent
	{
		// Token: 0x0402E44C RID: 189516
		InnerPassiveSkillItem,
		// Token: 0x0402E44D RID: 189517
		OuterPassiveSkillItem1,
		// Token: 0x0402E44E RID: 189518
		OuterPassiveSkillItem2,
		// Token: 0x0402E44F RID: 189519
		LineItem1,
		// Token: 0x0402E450 RID: 189520
		LineItem2
	}
}
