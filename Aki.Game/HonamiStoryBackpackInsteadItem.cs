using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E9D RID: 7837
public class HonamiStoryBackpackInsteadItem : UiPanelBase
{
	// Token: 0x0600F0A2 RID: 61602 RVA: 0x0039C3E8 File Offset: 0x0039A5E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedCancel));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F0A3 RID: 61603 RVA: 0x0039C4D0 File Offset: 0x0039A6D0
	protected override void OnStart()
	{
		UUIText text = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text, "HonamiStory_ChooseSlot", Array.Empty<object>());
	}

	// Token: 0x0600F0A4 RID: 61604 RVA: 0x0039C4FC File Offset: 0x0039A6FC
	public void SetVisible(bool isVisible)
	{
		base.SetUiActive(isVisible);
		if (isVisible)
		{
			HonamiStoryItemDataBase insteadItem = HonamiStoryModel.Instance.GetBackpackLogic().GetInsteadItem();
			this.SetSpriteByPath(insteadItem.GetQualityConfig().Value.GridBg, base.GetSprite(1), false, null, null);
			base.SetTextureByPath(insteadItem.GetIconTexture(), base.GetTexture(2), null, null);
		}
	}

	// Token: 0x0600F0A5 RID: 61605 RVA: 0x0039C570 File Offset: 0x0039A770
	private void OnClickedCancel()
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.SetLogicState(EHonamiStoryBackpackLogicState.Normal, null, null);
	}

	// Token: 0x02008465 RID: 33893
	private enum EReplace
	{
		// Token: 0x0402B185 RID: 176517
		BtnCancel,
		// Token: 0x0402B186 RID: 176518
		SpriteBg,
		// Token: 0x0402B187 RID: 176519
		Icon,
		// Token: 0x0402B188 RID: 176520
		TxtTips
	}
}
