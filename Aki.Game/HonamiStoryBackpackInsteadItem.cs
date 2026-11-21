using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200135F RID: 4959
public class HonamiStoryBackpackInsteadItem : UiPanelBase
{
	// Token: 0x0600C4C1 RID: 50369 RVA: 0x003A7FA4 File Offset: 0x003A61A4
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

	// Token: 0x0600C4C2 RID: 50370 RVA: 0x003A808C File Offset: 0x003A628C
	protected override void OnStart()
	{
		UUIText text = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text, "HonamiStory_ChooseSlot", Array.Empty<object>());
	}

	// Token: 0x0600C4C3 RID: 50371 RVA: 0x003A80B8 File Offset: 0x003A62B8
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

	// Token: 0x0600C4C4 RID: 50372 RVA: 0x003A812C File Offset: 0x003A632C
	private void OnClickedCancel()
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.SetLogicState(EHonamiStoryBackpackLogicState.Normal, null, null);
	}

	// Token: 0x020075EA RID: 30186
	private enum EReplace
	{
		// Token: 0x040264A9 RID: 156841
		BtnCancel,
		// Token: 0x040264AA RID: 156842
		SpriteBg,
		// Token: 0x040264AB RID: 156843
		Icon,
		// Token: 0x040264AC RID: 156844
		TxtTips
	}
}
