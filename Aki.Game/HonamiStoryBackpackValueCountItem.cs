using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E9C RID: 7836
public class HonamiStoryBackpackValueCountItem : UiPanelBase
{
	// Token: 0x0600F098 RID: 61592 RVA: 0x0039BF94 File Offset: 0x0039A194
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedCancel));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickedToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickedTogglePluginA));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickedTogglePluginB));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F099 RID: 61593 RVA: 0x0039C16C File Offset: 0x0039A36C
	protected override void OnStart()
	{
		this.InDungeon = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		int activityId = HonamiStoryModel.Instance.ActivityId;
		HonamiStoryActivity value = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId).Value;
		int itemId = this.InDungeon ? value.InnerItemId : value.OutCoinItemId;
		base.SetItemIcon(base.GetTexture(1), itemId, null, null);
		base.GetItem(7).SetUIActive(!this.InDungeon);
		base.GetButton(0).RootUIComp.Get().SetUIActive(!this.InDungeon);
		string textStringId = this.InDungeon ? "HonamiStory_SellValue_Inner" : "HonamiStory_SellValue_Outer";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
	}

	// Token: 0x0600F09A RID: 61594 RVA: 0x0039C23C File Offset: 0x0039A43C
	public void SetVisible(bool isVisible)
	{
		base.SetUiActive(isVisible);
		if (!this.InDungeon && isVisible)
		{
			base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600F09B RID: 61595 RVA: 0x0039C290 File Offset: 0x0039A490
	public void SetValue(int value)
	{
		if (value < 0)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "Controller value calculate Error", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(HonamiStoryUtil.GetPriceNumFormat(value), true);
	}

	// Token: 0x0600F09C RID: 61596 RVA: 0x0039C2D8 File Offset: 0x0039A4D8
	public void RefreshInGame()
	{
		string newText = HonamiStoryUtil.GetPriceNumFormat(HonamiStoryModel.Instance.GetBackPackData(2, false).GetTotalValue()) ?? "";
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0600F09D RID: 61597 RVA: 0x0039C318 File Offset: 0x0039A518
	private void OnClickedCancel()
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.SetLogicState(EHonamiStoryBackpackLogicState.Normal, null, null);
	}

	// Token: 0x0600F09E RID: 61598 RVA: 0x0039C344 File Offset: 0x0039A544
	private void OnClickedToggle(EToggleState toggleState)
	{
		bool isSelected = base.GetExtendToggle(3).GetToggleState() == EToggleState.ETT_Checked;
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.DoSellToAll(isSelected, EHonamiStoryItemType.Normal, 0);
	}

	// Token: 0x0600F09F RID: 61599 RVA: 0x0039C378 File Offset: 0x0039A578
	private void OnClickedTogglePluginA(EToggleState toggleState)
	{
		bool isSelected = base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked;
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.DoSellToAll(isSelected, EHonamiStoryItemType.Plugin, 1);
	}

	// Token: 0x0600F0A0 RID: 61600 RVA: 0x0039C3AC File Offset: 0x0039A5AC
	private void OnClickedTogglePluginB(EToggleState toggleState)
	{
		bool isSelected = base.GetExtendToggle(6).GetToggleState() == EToggleState.ETT_Checked;
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic == null)
		{
			return;
		}
		backpackLogic.DoSellToAll(isSelected, EHonamiStoryItemType.Plugin, 2);
	}

	// Token: 0x04006F53 RID: 28499
	private bool InDungeon;

	// Token: 0x02008464 RID: 33892
	private enum EItem
	{
		// Token: 0x0402B17C RID: 176508
		BtnCancel,
		// Token: 0x0402B17D RID: 176509
		Texture,
		// Token: 0x0402B17E RID: 176510
		TxtCost,
		// Token: 0x0402B17F RID: 176511
		Toggle,
		// Token: 0x0402B180 RID: 176512
		TxtTips,
		// Token: 0x0402B181 RID: 176513
		TogglePluginA,
		// Token: 0x0402B182 RID: 176514
		TogglePluginB,
		// Token: 0x0402B183 RID: 176515
		PanelToggle
	}
}
