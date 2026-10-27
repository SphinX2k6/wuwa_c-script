using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA4 RID: 7844
public class HonamiStoryItemGridPlacementItem : UiPanelBase
{
	// Token: 0x0600F0D2 RID: 61650 RVA: 0x0039D520 File Offset: 0x0039B720
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600F0D3 RID: 61651 RVA: 0x0039D55C File Offset: 0x0039B75C
	public void Refresh()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState != EHonamiStoryBackpackLogicState.TipsWithPlugins && backpackLogicState != EHonamiStoryBackpackLogicState.DraggingPlugins)
		{
			return;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins);
	}

	// Token: 0x0200846D RID: 33901
	private enum EPlacement
	{
		// Token: 0x0402B19D RID: 176541
		TipsPlacement,
		// Token: 0x0402B19E RID: 176542
		DragPlacementSprite
	}
}
