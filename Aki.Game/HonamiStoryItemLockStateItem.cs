using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA1 RID: 7841
public class HonamiStoryItemLockStateItem : UiPanelBase
{
	// Token: 0x0600F0C8 RID: 61640 RVA: 0x0039D362 File Offset: 0x0039B562
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600F0C9 RID: 61641 RVA: 0x0039D388 File Offset: 0x0039B588
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

	// Token: 0x0200846A RID: 33898
	private enum EItemLock
	{
		// Token: 0x0402B196 RID: 176534
		Mask
	}
}
