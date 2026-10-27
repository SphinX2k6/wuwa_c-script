using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x02001D31 RID: 7473
public class TrapDefensePhantomPointMarkView : TrapDefenseMarkView
{
	// Token: 0x0600E24E RID: 57934 RVA: 0x00352A68 File Offset: 0x00350C68
	public TrapDefensePhantomPointMarkView(int markId) : base(markId)
	{
	}

	// Token: 0x0600E24F RID: 57935 RVA: 0x00352A71 File Offset: 0x00350C71
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600E250 RID: 57936 RVA: 0x00352A94 File Offset: 0x00350C94
	protected override void OnBeforeShow()
	{
		this.RefreshIcon();
	}

	// Token: 0x0600E251 RID: 57937 RVA: 0x00352A9C File Offset: 0x00350C9C
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

	// Token: 0x0600E252 RID: 57938 RVA: 0x00352B22 File Offset: 0x00350D22
	public override void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
	{
		if (status == ETowerDefenseEventProcessStatus.Ready)
		{
			this.RefreshIcon();
		}
	}

	// Token: 0x02008336 RID: 33590
	private static class EChildComponent
	{
		// Token: 0x0402AC95 RID: 175253
		public const int Icon = 0;
	}
}
