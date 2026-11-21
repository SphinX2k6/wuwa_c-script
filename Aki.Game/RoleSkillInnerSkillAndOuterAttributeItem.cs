using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E2E RID: 7726
public class RoleSkillInnerSkillAndOuterAttributeItem : RoleSkillChainItem
{
	// Token: 0x060131D4 RID: 78292 RVA: 0x005963B0 File Offset: 0x005945B0
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

	// Token: 0x060131D5 RID: 78293 RVA: 0x0059647C File Offset: 0x0059467C
	protected override void OnStart()
	{
		RoleSkillInnerSkillItem roleSkillInnerSkillItem = new RoleSkillInnerSkillItem();
		roleSkillInnerSkillItem.SetSkillBranchEnable(this.IsSkillBranchEnable);
		roleSkillInnerSkillItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		this.SkillNodeItemList.Add(roleSkillInnerSkillItem);
		foreach (RoleSkillInnerSkillAndOuterAttributeItem.EComponent name in new RoleSkillInnerSkillAndOuterAttributeItem.EComponent[]
		{
			RoleSkillInnerSkillAndOuterAttributeItem.EComponent.OuterAttributeItem1,
			RoleSkillInnerSkillAndOuterAttributeItem.EComponent.OuterAttributeItem2
		})
		{
			UUIItem item = base.GetItem((int)name);
			RoleSkillOuterAttributeSkillItem roleSkillOuterAttributeSkillItem = new RoleSkillOuterAttributeSkillItem();
			roleSkillOuterAttributeSkillItem.SetSkillBranchEnable(this.IsSkillBranchEnable);
			roleSkillOuterAttributeSkillItem.CreateThenShowByActor(item.GetOwner(), null);
			this.SkillNodeItemList.Add(roleSkillOuterAttributeSkillItem);
		}
		foreach (RoleSkillInnerSkillAndOuterAttributeItem.EComponent name2 in new RoleSkillInnerSkillAndOuterAttributeItem.EComponent[]
		{
			RoleSkillInnerSkillAndOuterAttributeItem.EComponent.LineItem1,
			RoleSkillInnerSkillAndOuterAttributeItem.EComponent.LineItem2
		})
		{
			UUIItem item2 = base.GetItem((int)name2);
			this.LineItemList.Add(item2);
		}
	}

	// Token: 0x020080FB RID: 33019
	private enum EComponent
	{
		// Token: 0x04029B5A RID: 170842
		InnerSkillItem,
		// Token: 0x04029B5B RID: 170843
		OuterAttributeItem1,
		// Token: 0x04029B5C RID: 170844
		OuterAttributeItem2,
		// Token: 0x04029B5D RID: 170845
		LineItem1,
		// Token: 0x04029B5E RID: 170846
		LineItem2
	}
}
