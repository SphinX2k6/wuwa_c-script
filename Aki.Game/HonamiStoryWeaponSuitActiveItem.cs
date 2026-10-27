using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F07 RID: 7943
public class HonamiStoryWeaponSuitActiveItem : UiPanelBase
{
	// Token: 0x0600F4A0 RID: 62624 RVA: 0x003B0400 File Offset: 0x003AE600
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

	// Token: 0x0600F4A1 RID: 62625 RVA: 0x003B0448 File Offset: 0x003AE648
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600F4A2 RID: 62626 RVA: 0x003B0464 File Offset: 0x003AE664
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

	// Token: 0x04007131 RID: 28977
	private const int START_SHOW_MIN_COUNT = 2;

	// Token: 0x04007132 RID: 28978
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x04007133 RID: 28979
	private bool LastActiveStatus;

	// Token: 0x02008512 RID: 34066
	private enum EHonamiStoryWeaponSuitActiveItemComponent
	{
		// Token: 0x0402B4E8 RID: 177384
		Sprite
	}

	// Token: 0x02008513 RID: 34067
	private enum EHonamiStoryWeaponSuitActiveItemIndex
	{
		// Token: 0x0402B4EA RID: 177386
		InActive,
		// Token: 0x0402B4EB RID: 177387
		ActiveOne,
		// Token: 0x0402B4EC RID: 177388
		ActiveAll
	}
}
