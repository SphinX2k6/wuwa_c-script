using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020019C3 RID: 6595
public class RecommendSkillBranchItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x0601045F RID: 66655 RVA: 0x004C0CA0 File Offset: 0x004BEEA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06010460 RID: 66656 RVA: 0x004C0D28 File Offset: 0x004BEF28
	[NullableContext(1)]
	protected override SkillBranchSwitchItemGroup[] CollectBranchItems()
	{
		return new SkillBranchSwitchItemGroup[]
		{
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(1),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(2).SetUIActive(active);
					this.SetMiddleIconToLeft(active);
				}
			},
			new SkillBranchSwitchItemGroup
			{
				SpriteTagIcon = base.GetSprite(3),
				ActiveIndexHandler = delegate(bool active)
				{
					base.GetItem(4).SetUIActive(active);
				}
			}
		};
	}

	// Token: 0x06010461 RID: 66657 RVA: 0x004C0D89 File Offset: 0x004BEF89
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return null;
	}

	// Token: 0x06010462 RID: 66658 RVA: 0x004C0D8C File Offset: 0x004BEF8C
	private void SetMiddleIconToLeft(bool isLeft)
	{
		UUIItem item = base.GetItem(0);
		FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x02007BF5 RID: 31733
	private enum EComp
	{
		// Token: 0x0402824E RID: 164430
		ItemSpriteMiddle,
		// Token: 0x0402824F RID: 164431
		SpriteTagIconL,
		// Token: 0x04028250 RID: 164432
		ItemTagL,
		// Token: 0x04028251 RID: 164433
		SpriteTagIconR,
		// Token: 0x04028252 RID: 164434
		ItemTagR
	}
}
