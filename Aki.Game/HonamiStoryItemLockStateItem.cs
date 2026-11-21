using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001363 RID: 4963
public class HonamiStoryItemLockStateItem : UiPanelBase
{
	// Token: 0x0600C4E7 RID: 50407 RVA: 0x003A8F1E File Offset: 0x003A711E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600C4E8 RID: 50408 RVA: 0x003A8F44 File Offset: 0x003A7144
	[NullableContext(1)]
	public void RefreshMask(bool enable, HonamiStoryItemDataBase itemData, EHonamiStoryBackpackType backpackType)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(enable);
		}
		if (!enable)
		{
			return;
		}
		UUIItem rootItem = this.RootItem;
		HonamiStoryModel instance = HonamiStoryModel.Instance;
		EHonamiStoryBackpack backpackId = HonamiStoryDefine.Instance.HonamiBackpackTypeMap[backpackType];
		HonamiStoryBackpackData backPackData = instance.GetBackPackData((int)backpackId, false);
		int gridWidth = itemData.GetGridWidth();
		int gridHeight = itemData.GetGridHeight();
		int num = backPackData.GetCellWidth() * gridWidth + (gridWidth - 1) * backPackData.GetCellHorizontalInterval();
		int num2 = backPackData.GetCellHeight() * gridHeight + (gridHeight - 1) * backPackData.GetCellVerticalInterval();
		rootItem.SetWidth((float)num);
		rootItem.SetHeight((float)num2);
	}

	// Token: 0x020075EF RID: 30191
	private enum EItemLock
	{
		// Token: 0x040264BA RID: 156858
		Mask
	}
}
