using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200135D RID: 4957
public class HonamiStoryBackpackTitleItem : UiPanelBase
{
	// Token: 0x0600C4B3 RID: 50355 RVA: 0x003A7912 File Offset: 0x003A5B12
	public HonamiStoryBackpackTitleItem(EHonamiStoryBackpackType backpackType)
	{
		this.Backpack = HonamiStoryDefine.Instance.HonamiBackpackTypeMap[backpackType];
	}

	// Token: 0x0600C4B4 RID: 50356 RVA: 0x003A7938 File Offset: 0x003A5B38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C4B5 RID: 50357 RVA: 0x003A79C4 File Offset: 0x003A5BC4
	protected override void OnStart()
	{
		string text;
		switch (this.Backpack)
		{
		case EHonamiStoryBackpack.Inventory:
			text = "HonamiStory_WareHouse";
			break;
		case EHonamiStoryBackpack.Backpack:
			text = "HonamiStory_BackPack";
			break;
		case EHonamiStoryBackpack.PickUpBox:
			text = "HonamiStory_FallingPile";
			break;
		default:
			text = "HonamiStory_BackPack";
			break;
		}
		string textStringId = text;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		switch (this.Backpack)
		{
		case EHonamiStoryBackpack.Inventory:
			text = "SP_TipsTitleIcon2";
			break;
		case EHonamiStoryBackpack.Backpack:
			text = "SP_TipsTitleIcon1";
			break;
		case EHonamiStoryBackpack.PickUpBox:
			text = "SP_TipsTitleIcon3";
			break;
		default:
			text = "SP_TipsTitleIcon1";
			break;
		}
		string resourceId = text;
		string path = UiResourceConfig.Instance.GetResourcePath(resourceId) ?? string.Empty;
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		this.Refresh();
	}

	// Token: 0x0600C4B6 RID: 50358 RVA: 0x003A7A9C File Offset: 0x003A5C9C
	public void Refresh()
	{
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData((int)this.Backpack, false);
		int capacity = backPackData.GetCapacity();
		int occupy = backPackData.GetOccupy();
		if (this.Backpack == EHonamiStoryBackpack.Inventory && backPackData.GetOverflowCapacity() > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "HonamiStory_OverflowCapacity", new <>z__ReadOnlyArray<object>(new object[]
			{
				occupy,
				capacity
			}));
			return;
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(occupy);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(capacity);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x04007033 RID: 28723
	protected EHonamiStoryBackpack Backpack = EHonamiStoryBackpack.Inventory;

	// Token: 0x020075E8 RID: 30184
	private enum EItem
	{
		// Token: 0x0402649C RID: 156828
		Sprite,
		// Token: 0x0402649D RID: 156829
		TxtName,
		// Token: 0x0402649E RID: 156830
		TxtNum
	}
}
