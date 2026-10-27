using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA2 RID: 7842
public class HonamiStoryItemSellAllItem : UiPanelBase
{
	// Token: 0x0600F0CB RID: 61643 RVA: 0x0039D421 File Offset: 0x0039B621
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600F0CC RID: 61644 RVA: 0x0039D444 File Offset: 0x0039B644
	public void SetSelected(bool value)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(value);
	}

	// Token: 0x0200846B RID: 33899
	private enum ESell
	{
		// Token: 0x0402B198 RID: 176536
		Sprite
	}
}
