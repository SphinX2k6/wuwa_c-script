using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024DC RID: 9436
public class RecommendSkillBranchItem : CommonRoleSkillBranchSwitchItem
{
	// Token: 0x06012FA0 RID: 77728 RVA: 0x004B30E0 File Offset: 0x004B12E0
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

	// Token: 0x06012FA1 RID: 77729 RVA: 0x004B3168 File Offset: 0x004B1368
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

	// Token: 0x06012FA2 RID: 77730 RVA: 0x004B31C9 File Offset: 0x004B13C9
	[NullableContext(1)]
	protected override UUIExtendToggle GetBranchToggle()
	{
		return null;
	}

	// Token: 0x06012FA3 RID: 77731 RVA: 0x004B31CC File Offset: 0x004B13CC
	private void SetMiddleIconToLeft(bool isLeft)
	{
		UUIItem item = base.GetItem(0);
		FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x02008A6D RID: 35437
	private enum EComp
	{
		// Token: 0x0402CF35 RID: 184117
		ItemSpriteMiddle,
		// Token: 0x0402CF36 RID: 184118
		SpriteTagIconL,
		// Token: 0x0402CF37 RID: 184119
		ItemTagL,
		// Token: 0x0402CF38 RID: 184120
		SpriteTagIconR,
		// Token: 0x0402CF39 RID: 184121
		ItemTagR
	}
}
