using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200135B RID: 4955
public class HonamiStoryLevelPowerItem : UiPanelBase
{
	// Token: 0x0600C4A1 RID: 50337 RVA: 0x003A6C88 File Offset: 0x003A4E88
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

	// Token: 0x0600C4A2 RID: 50338 RVA: 0x003A6D0E File Offset: 0x003A4F0E
	public void RefreshPowerVisible(bool isVisible)
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isVisible);
	}

	// Token: 0x020075E5 RID: 30181
	private enum EPower
	{
		// Token: 0x04026485 RID: 156805
		Txt,
		// Token: 0x04026486 RID: 156806
		SpriteNumBg,
		// Token: 0x04026487 RID: 156807
		SpriteLevelIcon,
		// Token: 0x04026488 RID: 156808
		SpriteCircle,
		// Token: 0x04026489 RID: 156809
		PanelNum
	}
}
