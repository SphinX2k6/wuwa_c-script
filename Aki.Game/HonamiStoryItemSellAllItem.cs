using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001364 RID: 4964
public class HonamiStoryItemSellAllItem : UiPanelBase
{
	// Token: 0x0600C4EA RID: 50410 RVA: 0x003A8FDD File Offset: 0x003A71DD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600C4EB RID: 50411 RVA: 0x003A9000 File Offset: 0x003A7200
	public void SetSelected(bool value)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(value);
	}

	// Token: 0x020075F0 RID: 30192
	private enum ESell
	{
		// Token: 0x040264BC RID: 156860
		Sprite
	}
}
