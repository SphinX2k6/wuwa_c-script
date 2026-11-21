using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x020011EF RID: 4591
public class TrapDefenseCampMarkView : TrapDefenseMarkView
{
	// Token: 0x0600B659 RID: 46681 RVA: 0x0035DF47 File Offset: 0x0035C147
	public TrapDefenseCampMarkView(int markId) : base(markId)
	{
	}

	// Token: 0x0600B65A RID: 46682 RVA: 0x0035DF50 File Offset: 0x0035C150
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600B65B RID: 46683 RVA: 0x0035DF74 File Offset: 0x0035C174
	protected override void OnBeforeShow()
	{
		UUISprite sprite = base.GetSprite(0);
		this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon3.SP_IconTowerDefenseMapIcon3", sprite, true, null, delegate(bool _)
		{
			sprite.SetUIActive(true);
		});
	}

	// Token: 0x020074BA RID: 29882
	private static class EChildComponent
	{
		// Token: 0x04025FB8 RID: 155576
		public const int Icon = 0;
	}
}
