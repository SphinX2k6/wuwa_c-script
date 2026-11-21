using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001366 RID: 4966
public class HonamiStoryItemGridPlacementItem : UiPanelBase
{
	// Token: 0x0600C4F1 RID: 50417 RVA: 0x003A90DC File Offset: 0x003A72DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600C4F2 RID: 50418 RVA: 0x003A9118 File Offset: 0x003A7318
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

	// Token: 0x020075F2 RID: 30194
	private enum EPlacement
	{
		// Token: 0x040264C1 RID: 156865
		TipsPlacement,
		// Token: 0x040264C2 RID: 156866
		DragPlacementSprite
	}
}
