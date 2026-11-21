using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x020011F3 RID: 4595
public class TrapDefensePhantomPointMarkView : TrapDefenseMarkView
{
	// Token: 0x0600B66B RID: 46699 RVA: 0x0035E498 File Offset: 0x0035C698
	public TrapDefensePhantomPointMarkView(int markId) : base(markId)
	{
	}

	// Token: 0x0600B66C RID: 46700 RVA: 0x0035E4A1 File Offset: 0x0035C6A1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600B66D RID: 46701 RVA: 0x0035E4C4 File Offset: 0x0035C6C4
	protected override void OnBeforeShow()
	{
		this.RefreshIcon();
	}

	// Token: 0x0600B66E RID: 46702 RVA: 0x0035E4CC File Offset: 0x0035C6CC
	private void RefreshIcon()
	{
		UUISprite sprite = base.GetSprite(0);
		TrapDefensePhantomPointMarkItem trapDefensePhantomPointMarkItem = base.GetMarkData() as TrapDefensePhantomPointMarkItem;
		if (trapDefensePhantomPointMarkItem != null && trapDefensePhantomPointMarkItem.IsActivated())
		{
			this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon2.SP_IconTowerDefenseMapIcon2", sprite, true, null, delegate(bool _)
			{
				sprite.SetUIActive(true);
			});
			return;
		}
		this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon1.SP_IconTowerDefenseMapIcon1", sprite, true, null, delegate(bool _)
		{
			sprite.SetUIActive(true);
		});
	}

	// Token: 0x0600B66F RID: 46703 RVA: 0x0035E552 File Offset: 0x0035C752
	public override void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
	{
		if (status == ETowerDefenseEventProcessStatus.Ready)
		{
			this.RefreshIcon();
		}
	}

	// Token: 0x020074BF RID: 29887
	private static class EChildComponent
	{
		// Token: 0x04025FBD RID: 155581
		public const int Icon = 0;
	}
}
