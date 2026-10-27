using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020028B3 RID: 10419
public class RoleSkillInnerSkillAndOuterAttributeItem : RoleSkillChainItem
{
	// Token: 0x060157D4 RID: 88020 RVA: 0x0056B568 File Offset: 0x00569768
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

	// Token: 0x060157D5 RID: 88021 RVA: 0x0056B634 File Offset: 0x00569834
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

	// Token: 0x02008EB4 RID: 36532
	private enum EComponent
	{
		// Token: 0x0402E45D RID: 189533
		InnerSkillItem,
		// Token: 0x0402E45E RID: 189534
		OuterAttributeItem1,
		// Token: 0x0402E45F RID: 189535
		OuterAttributeItem2,
		// Token: 0x0402E460 RID: 189536
		LineItem1,
		// Token: 0x0402E461 RID: 189537
		LineItem2
	}
}
