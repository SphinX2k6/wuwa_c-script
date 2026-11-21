using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CAA RID: 3242
[NullableContext(1)]
[Nullable(0)]
public class CommonCurrencyItem : UiPanelBase
{
	// Token: 0x17000F40 RID: 3904
	// (set) Token: 0x06008747 RID: 34631 RVA: 0x00293181 File Offset: 0x00291381
	public Action<int> ButtonFunction
	{
		set
		{
			value != this.ButtonFunctionInternal;
			this.ButtonFunctionInternal = value;
		}
	}

	// Token: 0x06008748 RID: 34632 RVA: 0x00293198 File Offset: 0x00291398
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITextureTransitionComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.TextureClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008749 RID: 34633 RVA: 0x00293349 File Offset: 0x00291549
	private void ButtonClick()
	{
		Action beforeButtonFunction = this.BeforeButtonFunction;
		if (beforeButtonFunction != null)
		{
			beforeButtonFunction();
		}
		Action<int> buttonFunctionInternal = this.ButtonFunctionInternal;
		if (buttonFunctionInternal == null)
		{
			return;
		}
		buttonFunctionInternal(this.ItemId);
	}

	// Token: 0x0600874A RID: 34634 RVA: 0x00293372 File Offset: 0x00291572
	private void TextureClick()
	{
		if (this.TextureClickCheckFunction != null && !this.TextureClickCheckFunction(this.ItemId))
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
	}

	// Token: 0x0600874B RID: 34635 RVA: 0x002933A3 File Offset: 0x002915A3
	protected override void OnStart()
	{
		if (!this.SkipAutoAddEvent)
		{
			this.AddEventListener();
		}
	}

	// Token: 0x0600874C RID: 34636 RVA: 0x002933B3 File Offset: 0x002915B3
	protected override void OnBeforeDestroy()
	{
		if (!this.SkipAutoAddEvent)
		{
			this.RemoveEventListener();
		}
	}

	// Token: 0x0600874D RID: 34637 RVA: 0x002933C4 File Offset: 0x002915C4
	public virtual void AddEventListener()
	{
		if (this.EventListenerAdded)
		{
			return;
		}
		this.EventListenerAdded = true;
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshCurrency));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
		EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
	}

	// Token: 0x0600874E RID: 34638 RVA: 0x00293470 File Offset: 0x00291670
	public virtual void RemoveEventListener()
	{
		if (!this.EventListenerAdded)
		{
			return;
		}
		this.EventListenerAdded = false;
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshCurrency));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
		EventSystem.Instance.Remove<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
	}

	// Token: 0x0600874F RID: 34639 RVA: 0x00293519 File Offset: 0x00291719
	private void RefreshCurrency(int itemId = 0)
	{
		this.RefreshCountText(null);
	}

	// Token: 0x06008750 RID: 34640 RVA: 0x00293522 File Offset: 0x00291722
	private void OnPayShopGoodsBuy()
	{
		this.RefreshCurrency(0);
	}

	// Token: 0x06008751 RID: 34641 RVA: 0x0029352C File Offset: 0x0029172C
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		foreach (IProto_NormalItem proto_NormalItem in normalItemList)
		{
			if (this.ItemId == proto_NormalItem.Id)
			{
				this.RefreshCountText(null);
				break;
			}
		}
	}

	// Token: 0x06008752 RID: 34642 RVA: 0x00293584 File Offset: 0x00291784
	private void OnRemoveCommonItem(IReadOnlyList<int> configId)
	{
		bool flag = false;
		for (int i = 0; i < configId.Count; i++)
		{
			if (configId[i] == this.ItemId)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		this.RefreshCountText(null);
	}

	// Token: 0x06008753 RID: 34643 RVA: 0x002935C2 File Offset: 0x002917C2
	private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
	{
		if (this.ItemId != normalItem.Id)
		{
			return;
		}
		this.RefreshCountText(null);
	}

	// Token: 0x06008754 RID: 34644 RVA: 0x002935DC File Offset: 0x002917DC
	private void SetTexture()
	{
		UUITexture texture = base.GetTexture(0);
		texture.SetUIActive(false);
		base.SetItemIcon(base.GetTexture(0), this.ItemId, null, delegate(bool _)
		{
			this.SetTextureAllTransition();
			texture.SetUIActive(true);
		});
	}

	// Token: 0x06008755 RID: 34645 RVA: 0x00293638 File Offset: 0x00291838
	private void SetTextureAllTransition()
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(4);
		if (uiTextureTransitionComponent != null)
		{
			uiTextureTransitionComponent.SetAllStateTexture(base.GetTexture(0).GetTexture());
		}
	}

	// Token: 0x06008756 RID: 34646 RVA: 0x00293664 File Offset: 0x00291864
	private void PayCurrencyClick(int itemId)
	{
		int? num = GachaConfig.Instance.PrimaryCurrency();
		int? num2 = num;
		if (itemId == num2.GetValueOrDefault() & num2 != null)
		{
			PayShopController.Instance.OpenPayShopViewToRecharge();
			return;
		}
		int? num3 = GachaConfig.Instance.SecondCurrency();
		num2 = num3;
		if (itemId == num2.GetValueOrDefault() & num2 != null)
		{
			ItemExchangeController.Instance.OpenExchangeViewByItemId(itemId, null, false);
		}
	}

	// Token: 0x06008757 RID: 34647 RVA: 0x002936CB File Offset: 0x002918CB
	public virtual void RefreshTemp(int itemId, string countText = null)
	{
		this.ShowWithoutText(itemId);
		this.RefreshCountText(countText);
	}

	// Token: 0x06008758 RID: 34648 RVA: 0x002936DB File Offset: 0x002918DB
	public virtual void ShowWithoutText(int itemId)
	{
		this.ItemId = itemId;
		this.SetTexture();
	}

	// Token: 0x06008759 RID: 34649 RVA: 0x002936EC File Offset: 0x002918EC
	[NullableContext(2)]
	public void RefreshCountText(string text = null)
	{
		UUIText text2 = base.GetText(1);
		string text3 = text ?? InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0).ToString();
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text3.ToString(), true);
	}

	// Token: 0x0600875A RID: 34650 RVA: 0x00293730 File Offset: 0x00291930
	public void SetCountText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600875B RID: 34651 RVA: 0x00293745 File Offset: 0x00291945
	public void SetCountTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600875C RID: 34652 RVA: 0x0029375A File Offset: 0x0029195A
	public void SetCount(int count)
	{
		base.GetText(1).SetText(count.ToString(), true);
	}

	// Token: 0x0600875D RID: 34653 RVA: 0x00293770 File Offset: 0x00291970
	public void SetButtonFunction(Action<int> callback)
	{
		this.ButtonFunction = callback;
	}

	// Token: 0x0600875E RID: 34654 RVA: 0x00293779 File Offset: 0x00291979
	public void SetBeforeButtonFunction(Action callback)
	{
		this.BeforeButtonFunction = callback;
	}

	// Token: 0x0600875F RID: 34655 RVA: 0x00293782 File Offset: 0x00291982
	public void SetTextureClickCheckFunction(Func<int, bool> callback)
	{
		this.TextureClickCheckFunction = callback;
	}

	// Token: 0x06008760 RID: 34656 RVA: 0x0029378C File Offset: 0x0029198C
	public void SetButtonActive(bool bActive)
	{
		UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(bActive);
	}

	// Token: 0x06008761 RID: 34657 RVA: 0x002937B8 File Offset: 0x002919B8
	public void RefreshMaxItem(bool bActive)
	{
		base.GetItem(8).SetUIActive(bActive);
	}

	// Token: 0x06008762 RID: 34658 RVA: 0x002937C7 File Offset: 0x002919C7
	public void SetToPayShopFunction()
	{
		this.ButtonFunction = new Action<int>(this.PayCurrencyClick);
	}

	// Token: 0x06008763 RID: 34659 RVA: 0x002937DC File Offset: 0x002919DC
	public virtual void RefreshAddButtonActive()
	{
		int? num = GachaConfig.Instance.PrimaryCurrency();
		int? num2 = GachaConfig.Instance.SecondCurrency();
		UUIButtonComponent button = base.GetButton(2);
		int itemId = this.ItemId;
		int? num3 = num;
		if (!(itemId == num3.GetValueOrDefault() & num3 != null))
		{
			int itemId2 = this.ItemId;
			num3 = num2;
			if (!(itemId2 == num3.GetValueOrDefault() & num3 != null))
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem == null)
				{
					return;
				}
				uuiitem.SetUIActive(false);
				return;
			}
		}
		UUIItem uuiitem2 = button.RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetUIActive(true);
	}

	// Token: 0x040051EA RID: 20970
	public int ItemId;

	// Token: 0x040051EB RID: 20971
	public bool SkipAutoAddEvent;

	// Token: 0x040051EC RID: 20972
	private bool EventListenerAdded;

	// Token: 0x040051ED RID: 20973
	private Action<int> ButtonFunctionInternal;

	// Token: 0x040051EE RID: 20974
	private Action BeforeButtonFunction;

	// Token: 0x040051EF RID: 20975
	[Nullable(2)]
	private Func<int, bool> TextureClickCheckFunction;

	// Token: 0x02006F6B RID: 28523
	[NullableContext(0)]
	private class ECommonCurrencyItem
	{
		// Token: 0x0402466B RID: 149099
		public const int Texture = 0;

		// Token: 0x0402466C RID: 149100
		public const int CountText = 1;

		// Token: 0x0402466D RID: 149101
		public const int Button = 2;

		// Token: 0x0402466E RID: 149102
		public const int TextureButton = 3;

		// Token: 0x0402466F RID: 149103
		public const int TextureTransition = 4;

		// Token: 0x04024670 RID: 149104
		public const int SliderItem = 5;

		// Token: 0x04024671 RID: 149105
		public const int SliderSprite = 6;

		// Token: 0x04024672 RID: 149106
		public const int SpriteIcon = 7;

		// Token: 0x04024673 RID: 149107
		public const int MaxItem = 8;
	}
}
