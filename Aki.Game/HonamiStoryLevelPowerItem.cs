using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E99 RID: 7833
public class HonamiStoryLevelPowerItem : UiPanelBase
{
	// Token: 0x0600F082 RID: 61570 RVA: 0x0039B0CC File Offset: 0x003992CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600F083 RID: 61571 RVA: 0x0039B152 File Offset: 0x00399352
	public void RefreshPowerVisible(bool isVisible)
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isVisible);
	}

	// Token: 0x02008460 RID: 33888
	private enum EPower
	{
		// Token: 0x0402B161 RID: 176481
		Txt,
		// Token: 0x0402B162 RID: 176482
		SpriteNumBg,
		// Token: 0x0402B163 RID: 176483
		SpriteLevelIcon,
		// Token: 0x0402B164 RID: 176484
		SpriteCircle,
		// Token: 0x0402B165 RID: 176485
		PanelNum
	}
}
