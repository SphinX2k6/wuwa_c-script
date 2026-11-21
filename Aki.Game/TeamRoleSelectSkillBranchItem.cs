using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001C7D RID: 7293
public class TeamRoleSelectSkillBranchItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x0601217F RID: 74111 RVA: 0x00552F48 File Offset: 0x00551148
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

	// Token: 0x06012180 RID: 74112 RVA: 0x00553072 File Offset: 0x00551272
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06012181 RID: 74113 RVA: 0x0055307C File Offset: 0x0055127C
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

	// Token: 0x06012182 RID: 74114 RVA: 0x005530E0 File Offset: 0x005512E0
	private void SetMiddleTagItemToRight(bool isRight)
	{
		UUIItem item = base.GetItem(1);
		FVector fvector = new FVector(0f, (float)(isRight ? 180 : 0), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x02007F7E RID: 32638
	private enum EChild
	{
		// Token: 0x04029414 RID: 168980
		Toggle,
		// Token: 0x04029415 RID: 168981
		ItemMiddle,
		// Token: 0x04029416 RID: 168982
		SpriteTagIconL,
		// Token: 0x04029417 RID: 168983
		ItemTagL,
		// Token: 0x04029418 RID: 168984
		SpriteTagIconR,
		// Token: 0x04029419 RID: 168985
		ItemTagR
	}
}
