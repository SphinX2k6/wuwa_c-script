using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02002792 RID: 10130
public class TeamRoleSelectSkillBranchItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x06014C94 RID: 85140 RVA: 0x00543E4C File Offset: 0x0054204C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(base.OnToggleStateChange));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014C95 RID: 85141 RVA: 0x00543F76 File Offset: 0x00542176
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06014C96 RID: 85142 RVA: 0x00543F80 File Offset: 0x00542180
	[NullableContext(1)]
	protected override SkillBranchSwitchItemGroup[] CollectBranchItems()
	{
		return new SkillBranchSwitchItemGroup[]
		{
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(2),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(3).SetUIActive(active);
				}
			},
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(4),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(5).SetUIActive(active);
					this.SetMiddleTagItemToRight(active);
				}
			}
		};
	}

	// Token: 0x06014C97 RID: 85143 RVA: 0x00543FE4 File Offset: 0x005421E4
	private void SetMiddleTagItemToRight(bool isRight)
	{
		UUIItem item = base.GetItem(1);
		FVector fvector = new FVector(0f, (float)(isRight ? 180 : 0), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x02008DF7 RID: 36343
	private enum EChild
	{
		// Token: 0x0402E101 RID: 188673
		Toggle,
		// Token: 0x0402E102 RID: 188674
		ItemMiddle,
		// Token: 0x0402E103 RID: 188675
		SpriteTagIconL,
		// Token: 0x0402E104 RID: 188676
		ItemTagL,
		// Token: 0x0402E105 RID: 188677
		SpriteTagIconR,
		// Token: 0x0402E106 RID: 188678
		ItemTagR
	}
}
