using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02001D2D RID: 7469
public class TrapDefenseCampMarkView : TrapDefenseMarkView
{
	// Token: 0x0600E23C RID: 57916 RVA: 0x00352517 File Offset: 0x00350717
	public TrapDefenseCampMarkView(int markId) : base(markId)
	{
	}

	// Token: 0x0600E23D RID: 57917 RVA: 0x00352520 File Offset: 0x00350720
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600E23E RID: 57918 RVA: 0x00352544 File Offset: 0x00350744
	protected override void OnBeforeShow()
	{
		UUISprite sprite = base.GetSprite(0);
		this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon3.SP_IconTowerDefenseMapIcon3", sprite, true, null, delegate(bool _)
		{
			sprite.SetUIActive(true);
		});
	}

	// Token: 0x02008331 RID: 33585
	private static class EChildComponent
	{
		// Token: 0x0402AC90 RID: 175248
		public const int Icon = 0;
	}
}
