using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001E2C RID: 7724
public class RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem : RoleSkillChainItem
{
	// Token: 0x060131C4 RID: 78276 RVA: 0x00596028 File Offset: 0x00594228
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

	// Token: 0x060131C5 RID: 78277 RVA: 0x005960F4 File Offset: 0x005942F4
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

	// Token: 0x020080F9 RID: 33017
	private enum EComponent
	{
		// Token: 0x04029B49 RID: 170825
		InnerPassiveSkillItem,
		// Token: 0x04029B4A RID: 170826
		OuterPassiveSkillItem1,
		// Token: 0x04029B4B RID: 170827
		OuterPassiveSkillItem2,
		// Token: 0x04029B4C RID: 170828
		LineItem1,
		// Token: 0x04029B4D RID: 170829
		LineItem2
	}
}
