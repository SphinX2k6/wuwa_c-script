using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200108E RID: 4238
internal class FormationRoleSlotSkillBranchToggleItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x0600A860 RID: 43104 RVA: 0x00318C1C File Offset: 0x00316E1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(base.OnToggleStateChange));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A861 RID: 43105 RVA: 0x00318D67 File Offset: 0x00316F67
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600A862 RID: 43106 RVA: 0x00318D70 File Offset: 0x00316F70
	[NullableContext(1)]
	protected override SkillBranchSwitchItemGroup[] CollectBranchItems()
	{
		return new SkillBranchSwitchItemGroup[]
		{
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(3),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(4).SetUIActive(active);
					base.GetSprite(1).SetUIActive(active);
				}
			},
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(5),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(6).SetUIActive(active);
					base.GetSprite(2).SetUIActive(active);
				}
			}
		};
	}

	// Token: 0x02007317 RID: 29463
	private enum ESlotSkillBranchChild
	{
		// Token: 0x04025779 RID: 153465
		Toggle,
		// Token: 0x0402577A RID: 153466
		SpriteTagBgL,
		// Token: 0x0402577B RID: 153467
		SpriteTagBgR,
		// Token: 0x0402577C RID: 153468
		SpriteTagIconL,
		// Token: 0x0402577D RID: 153469
		ItemTagL,
		// Token: 0x0402577E RID: 153470
		SpriteTagIconR,
		// Token: 0x0402577F RID: 153471
		ItemTagR
	}
}
