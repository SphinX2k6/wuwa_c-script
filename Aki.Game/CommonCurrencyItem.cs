using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017F1 RID: 6129
[NullableContext(1)]
[Nullable(0)]
public class CommonCurrencyItem : UiPanelBase
{
	// Token: 0x17000F1D RID: 3869
	// (set) Token: 0x0600B35D RID: 45917 RVA: 0x00288AAD File Offset: 0x00286CAD
	public Action<int> ButtonFunction
	{
		set
		{
			value != this.ButtonFunctionInternal;
			this.ButtonFunctionInternal = value;
		}
	}

	// Token: 0x0600B35E RID: 45918 RVA: 0x00288AC4 File Offset: 0x00286CC4
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

	// Token: 0x0600B35F RID: 45919 RVA: 0x00288C75 File Offset: 0x00286E75
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

	// Token: 0x0600B360 RID: 45920 RVA: 0x00288C9E File Offset: 0x00286E9E
	private void TextureClick()
	{
		if (this.TextureClickCheckFunction != null && !this.TextureClickCheckFunction(this.ItemId))
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
	}

	// Token: 0x0600B361 RID: 45921 RVA: 0x00288CCE File Offset: 0x00286ECE
	protected override void OnStart()
	{
		if (!this.SkipAutoAddEvent)
		{
			this.AddEventListener();
		}
	}

	// Token: 0x0600B362 RID: 45922 RVA: 0x00288CDE File Offset: 0x00286EDE
	protected override void OnBeforeDestroy()
	{
		if (!this.SkipAutoAddEvent)
		{
			this.RemoveEventListener();
		}
	}

	// Token: 0x0600B363 RID: 45923 RVA: 0x00288CF0 File Offset: 0x00286EF0
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

	// Token: 0x0600B364 RID: 45924 RVA: 0x00288D9C File Offset: 0x00286F9C
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

	// Token: 0x0600B365 RID: 45925 RVA: 0x00288E45 File Offset: 0x00287045
	private void RefreshCurrency(int itemId = 0)
	{
		this.RefreshCountText(null);
	}

	// Token: 0x0600B366 RID: 45926 RVA: 0x00288E4E File Offset: 0x0028704E
	private void OnPayShopGoodsBuy()
	{
		this.RefreshCurrency(0);
	}

	// Token: 0x0600B367 RID: 45927 RVA: 0x00288E58 File Offset: 0x00287058
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

	// Token: 0x0600B368 RID: 45928 RVA: 0x00288EB0 File Offset: 0x002870B0
	private void OnRemoveCommonItem(IReadOnlyList<int> configId)
	{
		if (!configId.Contains(this.ItemId))
		{
			return;
		}
		this.RefreshCountText(null);
	}

	// Token: 0x0600B369 RID: 45929 RVA: 0x00288EC8 File Offset: 0x002870C8
	private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
	{
		if (this.ItemId != normalItem.Id)
		{
			return;
		}
		this.RefreshCountText(null);
	}

	// Token: 0x0600B36A RID: 45930 RVA: 0x00288EE0 File Offset: 0x002870E0
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

	// Token: 0x0600B36B RID: 45931 RVA: 0x00288F3C File Offset: 0x0028713C
	private void SetTextureAllTransition()
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(4);
		if (uiTextureTransitionComponent != null)
		{
			uiTextureTransitionComponent.SetAllStateTexture(base.GetTexture(0).GetTexture());
		}
	}

	// Token: 0x0600B36C RID: 45932 RVA: 0x00288F68 File Offset: 0x00287168
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

	// Token: 0x0600B36D RID: 45933 RVA: 0x00288FCF File Offset: 0x002871CF
	public virtual void RefreshTemp(int itemId, string countText = null)
	{
		this.ShowWithoutText(itemId);
		this.RefreshCountText(countText);
	}

	// Token: 0x0600B36E RID: 45934 RVA: 0x00288FDF File Offset: 0x002871DF
	public virtual void ShowWithoutText(int itemId)
	{
		this.ItemId = itemId;
		this.SetTexture();
	}

	// Token: 0x0600B36F RID: 45935 RVA: 0x00288FF0 File Offset: 0x002871F0
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

	// Token: 0x0600B370 RID: 45936 RVA: 0x00289034 File Offset: 0x00287234
	public void SetCountText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600B371 RID: 45937 RVA: 0x00289049 File Offset: 0x00287249
	public void SetCountTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600B372 RID: 45938 RVA: 0x0028905E File Offset: 0x0028725E
	public void SetCount(int count)
	{
		base.GetText(1).SetText(count.ToString(), true);
	}

	// Token: 0x0600B373 RID: 45939 RVA: 0x00289074 File Offset: 0x00287274
	public void SetButtonFunction(Action<int> callback)
	{
		this.ButtonFunction = callback;
	}

	// Token: 0x0600B374 RID: 45940 RVA: 0x0028907D File Offset: 0x0028727D
	public void SetBeforeButtonFunction(Action callback)
	{
		this.BeforeButtonFunction = callback;
	}

	// Token: 0x0600B375 RID: 45941 RVA: 0x00289086 File Offset: 0x00287286
	public void SetTextureClickCheckFunction(Func<int, bool> callback)
	{
		this.TextureClickCheckFunction = callback;
	}

	// Token: 0x0600B376 RID: 45942 RVA: 0x00289090 File Offset: 0x00287290
	public void SetButtonActive(bool bActive)
	{
		UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(bActive);
	}

	// Token: 0x0600B377 RID: 45943 RVA: 0x002890BC File Offset: 0x002872BC
	public void RefreshMaxItem(bool bActive)
	{
		base.GetItem(8).SetUIActive(bActive);
	}

	// Token: 0x0600B378 RID: 45944 RVA: 0x002890CB File Offset: 0x002872CB
	public void SetToPayShopFunction()
	{
		this.ButtonFunction = new Action<int>(this.PayCurrencyClick);
	}

	// Token: 0x0600B379 RID: 45945 RVA: 0x002890E0 File Offset: 0x002872E0
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

	// Token: 0x0400513F RID: 20799
	public int ItemId;

	// Token: 0x04005140 RID: 20800
	public bool SkipAutoAddEvent;

	// Token: 0x04005141 RID: 20801
	private bool EventListenerAdded;

	// Token: 0x04005142 RID: 20802
	private Action<int> ButtonFunctionInternal;

	// Token: 0x04005143 RID: 20803
	private Action BeforeButtonFunction;

	// Token: 0x04005144 RID: 20804
	[Nullable(2)]
	private Func<int, bool> TextureClickCheckFunction;

	// Token: 0x02007DE5 RID: 32229
	[NullableContext(0)]
	private class ECommonCurrencyItem
	{
		// Token: 0x04029340 RID: 168768
		public const int Texture = 0;

		// Token: 0x04029341 RID: 168769
		public const int CountText = 1;

		// Token: 0x04029342 RID: 168770
		public const int Button = 2;

		// Token: 0x04029343 RID: 168771
		public const int TextureButton = 3;

		// Token: 0x04029344 RID: 168772
		public const int TextureTransition = 4;

		// Token: 0x04029345 RID: 168773
		public const int SliderItem = 5;

		// Token: 0x04029346 RID: 168774
		public const int SliderSprite = 6;

		// Token: 0x04029347 RID: 168775
		public const int SpriteIcon = 7;

		// Token: 0x04029348 RID: 168776
		public const int MaxItem = 8;
	}
}
