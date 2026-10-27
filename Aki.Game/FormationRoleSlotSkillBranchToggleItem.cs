using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001BCF RID: 7119
internal class FormationRoleSlotSkillBranchToggleItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x0600D44E RID: 54350 RVA: 0x0030DAA8 File Offset: 0x0030BCA8
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

	// Token: 0x0600D44F RID: 54351 RVA: 0x0030DBF3 File Offset: 0x0030BDF3
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600D450 RID: 54352 RVA: 0x0030DBFC File Offset: 0x0030BDFC
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

	// Token: 0x02008189 RID: 33161
	private enum ESlotSkillBranchChild
	{
		// Token: 0x0402A445 RID: 173125
		Toggle,
		// Token: 0x0402A446 RID: 173126
		SpriteTagBgL,
		// Token: 0x0402A447 RID: 173127
		SpriteTagBgR,
		// Token: 0x0402A448 RID: 173128
		SpriteTagIconL,
		// Token: 0x0402A449 RID: 173129
		ItemTagL,
		// Token: 0x0402A44A RID: 173130
		SpriteTagIconR,
		// Token: 0x0402A44B RID: 173131
		ItemTagR
	}
}
