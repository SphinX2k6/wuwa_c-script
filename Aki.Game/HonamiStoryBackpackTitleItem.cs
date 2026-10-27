using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E9B RID: 7835
public class HonamiStoryBackpackTitleItem : UiPanelBase
{
	// Token: 0x0600F094 RID: 61588 RVA: 0x0039BD56 File Offset: 0x00399F56
	public HonamiStoryBackpackTitleItem(EHonamiStoryBackpackType backpackType)
	{
		this.Backpack = HonamiStoryDefine.Instance.HonamiBackpackTypeMap[backpackType];
	}

	// Token: 0x0600F095 RID: 61589 RVA: 0x0039BD7C File Offset: 0x00399F7C
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

	// Token: 0x0600F096 RID: 61590 RVA: 0x0039BE08 File Offset: 0x0039A008
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

	// Token: 0x0600F097 RID: 61591 RVA: 0x0039BEE0 File Offset: 0x0039A0E0
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

	// Token: 0x04006F52 RID: 28498
	protected EHonamiStoryBackpack Backpack = EHonamiStoryBackpack.Inventory;

	// Token: 0x02008463 RID: 33891
	private enum EItem
	{
		// Token: 0x0402B178 RID: 176504
		Sprite,
		// Token: 0x0402B179 RID: 176505
		TxtName,
		// Token: 0x0402B17A RID: 176506
		TxtNum
	}
}
