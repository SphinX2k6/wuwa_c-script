using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013C9 RID: 5065
public class HonamiStoryWeaponSuitActiveItem : UiPanelBase
{
	// Token: 0x0600C8BF RID: 51391 RVA: 0x003BBEF4 File Offset: 0x003BA0F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C8C0 RID: 51392 RVA: 0x003BBF3C File Offset: 0x003BA13C
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600C8C1 RID: 51393 RVA: 0x003BBF58 File Offset: 0x003BA158
	[NullableContext(1)]
	public void Refresh(IHonamiStoryWeaponSuitData data)
	{
		int suitId = data.SuitId;
		HonamiStoryRoleEquipData equipData = data.EquipData;
		HonamiStoryWeaponSuitActiveData honamiStoryWeaponSuitActiveData = (equipData != null) ? equipData.IsSuitActivate(suitId, null) : null;
		CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData weaponSuitData = HonamiStoryModel.Instance.GetWeaponSuitData(suitId);
		HonamiStoryPluginSubType value = HonamiStoryConfig.Instance.GetPluginSubType(weaponSuitData.WeaponPluginType).Value;
		HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex ehonamiStoryWeaponSuitActiveItemIndex = HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.InActive;
		if (honamiStoryWeaponSuitActiveData != null)
		{
			int num = honamiStoryWeaponSuitActiveData.NeedCount - 2;
			int num2 = honamiStoryWeaponSuitActiveData.CurCount - num;
			bool flag = honamiStoryWeaponSuitActiveData.CurCount >= honamiStoryWeaponSuitActiveData.NeedCount;
			if (flag && flag != this.LastActiveStatus)
			{
				UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
				if (levelPlaySequence != null)
				{
					levelPlaySequence.PlaySequence("Burst", false, null);
				}
			}
			this.LastActiveStatus = flag;
			if (num2 >= 2)
			{
				ehonamiStoryWeaponSuitActiveItemIndex = HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.ActiveAll;
			}
			else if (num2 >= 1)
			{
				ehonamiStoryWeaponSuitActiveItemIndex = HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.ActiveOne;
			}
			else
			{
				ehonamiStoryWeaponSuitActiveItemIndex = HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.InActive;
			}
		}
		string text;
		switch (ehonamiStoryWeaponSuitActiveItemIndex)
		{
		case HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.InActive:
			text = value.ActiveSpritePath;
			break;
		case HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.ActiveOne:
			text = value.ActiveOneSpritePath;
			break;
		case HonamiStoryWeaponSuitActiveItem.EHonamiStoryWeaponSuitActiveItemIndex.ActiveAll:
			text = value.ActiveAllSpritePath;
			break;
		default:
			text = value.ActiveSpritePath;
			break;
		}
		if (!string.IsNullOrEmpty(text))
		{
			this.SetSpriteByPath(text, base.GetSprite(0), true, null, null);
		}
	}

	// Token: 0x04007212 RID: 29202
	private const int START_SHOW_MIN_COUNT = 2;

	// Token: 0x04007213 RID: 29203
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x04007214 RID: 29204
	private bool LastActiveStatus;

	// Token: 0x02007697 RID: 30359
	private enum EHonamiStoryWeaponSuitActiveItemComponent
	{
		// Token: 0x0402680C RID: 157708
		Sprite
	}

	// Token: 0x02007698 RID: 30360
	private enum EHonamiStoryWeaponSuitActiveItemIndex
	{
		// Token: 0x0402680E RID: 157710
		InActive,
		// Token: 0x0402680F RID: 157711
		ActiveOne,
		// Token: 0x04026810 RID: 157712
		ActiveAll
	}
}
