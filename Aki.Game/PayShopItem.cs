using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002386 RID: 9094
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x060122BC RID: 74428 RVA: 0x00478420 File Offset: 0x00476620
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060122BD RID: 74429 RVA: 0x00478724 File Offset: 0x00476924
	public void HideExchangePopViewElement()
	{
		this.SetRaycastState(false);
		this.SetDownPriceShowState(false);
		this.SetForceHideReUpTextState(true);
		this.SetResellShowState(true);
		this.SetDisableSelfInteractiveState(true);
		this.SetLeftTimeTextShowState(false);
		this.SetRedDotState(false);
	}

	// Token: 0x060122BE RID: 74430 RVA: 0x00478757 File Offset: 0x00476957
	public void HidePackageViewElement()
	{
		this.SetRaycastState(false);
		this.SetForceHideReUpTextState(true);
		this.SetResellShowState(true);
		this.SetDisableSelfInteractiveState(true);
		this.SetLeftTimeTextShowState(false);
		this.PayShopItemBase.SetDownPriceOnlyShow(true);
		this.SetRedDotState(false);
	}

	// Token: 0x060122BF RID: 74431 RVA: 0x0047878F File Offset: 0x0047698F
	public void SetRaycastState(bool state)
	{
		this.RootItem.SetRaycastTarget(state);
		this.PayShopItemBase.GetRootItem().SetRaycastTarget(state);
		base.GetButton(8).SetCanClickWhenDisable(state);
	}

	// Token: 0x060122C0 RID: 74432 RVA: 0x004787BB File Offset: 0x004769BB
	public void SetResellShowState(bool state)
	{
		this.ForceHideResellText = state;
	}

	// Token: 0x060122C1 RID: 74433 RVA: 0x004787C4 File Offset: 0x004769C4
	public void SetDisableSelfInteractiveState(bool state)
	{
		this.ForceDisableSelfInteractive = state;
	}

	// Token: 0x060122C2 RID: 74434 RVA: 0x004787CD File Offset: 0x004769CD
	public void SetForceHideReUpTextState(bool state)
	{
		this.ForceHideReUpState = state;
	}

	// Token: 0x060122C3 RID: 74435 RVA: 0x004787D6 File Offset: 0x004769D6
	public void SetDownPriceShowState(bool state)
	{
		this.PayShopItemBase.SetDownPriceShowState(state);
	}

	// Token: 0x060122C4 RID: 74436 RVA: 0x004787E4 File Offset: 0x004769E4
	private void OnClickItem()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:ShopItem 点击商品";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.Data.GetGoodsData().Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		PayShopController.Instance.OpenBuyViewByGoodsId(this.Data, this.ExchangeExtraData);
		Action<PayShopItem, PayShopGoods> buttonExtraFunction = this.ButtonExtraFunction;
		if (buttonExtraFunction == null)
		{
			return;
		}
		buttonExtraFunction(this, this.Data);
	}

	// Token: 0x060122C5 RID: 74437 RVA: 0x0047885C File Offset: 0x00476A5C
	protected override void OnStart()
	{
		base.GetItem(12).SetUIActive(false);
		this.PayShopItemBase = new PayShopItemBase(base.GetItem(0));
		this.PayShopItemBase.Init();
		this.CurrentBuyLimitItemState = base.GetItem(5).bIsUIActive;
		this.CurrentDiscountItemState = base.GetItem(1).bIsUIActive;
		this.DiscountLabelShowState = base.GetItem(4).bIsUIActive;
		this.CurrentResellTextState = base.GetText(7).bIsUIActive;
		this.CurrentBuyButtonSelfInteractiveState = false;
		this.CurrentWarnState = false;
		this.LeftTopState = base.GetItem(12).bIsActive;
		base.GetButton(8).SetCanClickWhenDisable(true);
		this.SetNewFlagState(false);
		this.AddEventListener();
	}

	// Token: 0x060122C6 RID: 74438 RVA: 0x00478917 File Offset: 0x00476B17
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x060122C7 RID: 74439 RVA: 0x00478935 File Offset: 0x00476B35
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x060122C8 RID: 74440 RVA: 0x00478954 File Offset: 0x00476B54
	private void OnDiscountShopTimerRefresh()
	{
		if (this.Data == null || !base.IsUiActiveInHierarchy())
		{
			return;
		}
		bool flag = false;
		if (this.RefreshDiscount())
		{
			flag = true;
		}
		if (this.RefreshCountDown())
		{
			flag = true;
		}
		this.RefreshDiscountLabel();
		this.RefreshReSellText();
		this.RefreshDiscountLabelShowState();
		this.RefreshButtonState();
		this.RefreshLeftTopItem();
		this.RefreshRecommendTagItem();
		this.RefreshCumulativeShopContent();
		this.RefreshRoleRoundIconItem();
		this.RefreshWarnState();
		this.PayShopItemBase.OnTimerRefresh(this.Data.ConvertToPayShopBaseSt(), false, 0);
		if (flag)
		{
			this.TryEmitRefreshTips();
		}
	}

	// Token: 0x060122C9 RID: 74441 RVA: 0x004789E0 File Offset: 0x00476BE0
	[NullableContext(1)]
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		PayShopGoods payShopGoods = data as PayShopGoods;
		if (payShopGoods == null)
		{
			return;
		}
		this.Data = payShopGoods;
		this.PayShopItemBase.Refresh(this.Data.ConvertToPayShopBaseSt(), isSelected, gridIndex);
		this.ResetView();
		this.RefreshDiscount();
		this.RefreshCountDown();
		this.RefreshDiscountLabel();
		this.RefreshReSellText();
		this.RefreshDiscountLabelShowState();
		this.RefreshButtonState();
		this.RefreshReUpTimeText();
		this.RefreshLeftTopItem();
		this.RefreshRecommendTagItem();
		this.RefreshCumulativeShopContent();
		this.RefreshWarnState();
	}

	// Token: 0x060122CA RID: 74442 RVA: 0x00478A61 File Offset: 0x00476C61
	public void SetNeedShowOnceBuyLimit(bool state)
	{
		this.PayShopItemBase.SetLeftTimeTextShowOnceBuy(state);
	}

	// Token: 0x060122CB RID: 74443 RVA: 0x00478A6F File Offset: 0x00476C6F
	private void ResetView()
	{
		base.GetItem(15).SetUIActive(false);
		this.CurrentWarnState = false;
	}

	// Token: 0x060122CC RID: 74444 RVA: 0x00478A88 File Offset: 0x00476C88
	private void RefreshWarnState()
	{
		bool flag = !this.Data.IfCanBuy();
		if (flag && this.ForceDisableSelfInteractive)
		{
			flag = false;
		}
		if (this.CurrentWarnState != flag)
		{
			UUIItem item = base.GetItem(15);
			UUIText text = base.GetText(16);
			this.CurrentWarnState = flag;
			item.SetUIActive(flag);
			if (flag)
			{
				text.SetText(this.Data.GetConditionLimitText(), true);
			}
		}
	}

	// Token: 0x060122CD RID: 74445 RVA: 0x00478AF0 File Offset: 0x00476CF0
	private void RefreshButtonState()
	{
		bool flag = this.Data.IsSoldOut();
		bool flag2 = this.Data.IsLimitGoods() && flag;
		if (flag2 && this.ForceDisableSelfInteractive)
		{
			flag2 = false;
		}
		if (this.CurrentBuyButtonSelfInteractiveState != flag2)
		{
			this.CurrentBuyButtonSelfInteractiveState = flag2;
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			if (flag)
			{
				UUIText text = base.GetText(14);
				if (text == null)
				{
					return;
				}
				text.SetText(this.Data.GetDownTipsText(), true);
			}
		}
	}

	// Token: 0x060122CE RID: 74446 RVA: 0x00478B6C File Offset: 0x00476D6C
	private void RefreshDiscountLabelShowState()
	{
		bool flag = this.Data.GetDiscountLabel() > 0 && (this.Data.InLabelShowTime() || (!this.Data.InLabelShowTime() && false));
		if (this.DiscountLabelShowState != flag)
		{
			base.GetItem(4).SetUIActive(flag);
			this.DiscountLabelShowState = flag;
		}
	}

	// Token: 0x060122CF RID: 74447 RVA: 0x00478BD0 File Offset: 0x00476DD0
	private void RefreshLeftTopItem()
	{
		bool ifShowRecommendTag = this.Data.GetIfShowRecommendTag();
		bool flag = this.DiscountLabelShowState || this.CurrentDiscountItemState || ifShowRecommendTag;
		if (this.LeftTopState != flag)
		{
			this.LeftTopState = flag;
			base.GetItem(12).SetUIActive(flag);
		}
	}

	// Token: 0x060122D0 RID: 74448 RVA: 0x00478C1C File Offset: 0x00476E1C
	private void RefreshRecommendTagItem()
	{
		this.CurrentRecommendTagItemState = this.Data.GetIfShowRecommendTag();
		if (this.CurrentRecommendTagItemState && this.RecommendTagItem == null)
		{
			this.RecommendTagItem = new UiPanelBase();
			this.RecommendTagItem.CreateThenShowByResourceIdAsync("UiItem_ItemBaseC1Recommend", base.GetItem(18), false).ContinueWith(delegate()
			{
				UiPanelBase recommendTagItem2 = this.RecommendTagItem;
				if (recommendTagItem2 == null)
				{
					return;
				}
				UUIItem rootItem2 = recommendTagItem2.GetRootItem();
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetUIActive(this.CurrentRecommendTagItemState);
			});
		}
		UiPanelBase recommendTagItem = this.RecommendTagItem;
		if (recommendTagItem == null)
		{
			return;
		}
		UUIItem rootItem = recommendTagItem.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(this.CurrentRecommendTagItemState);
	}

	// Token: 0x060122D1 RID: 74449 RVA: 0x00478CA0 File Offset: 0x00476EA0
	private void RefreshCumulativeShopContent()
	{
		if (!PayShopDefine.PayShopCumulativeTabTypeSet.Contains(this.Data.PayShopId))
		{
			return;
		}
		int itemConfigId = this.Data.GetItemData().ItemId;
		AActor owner = base.GetItem(19).GetOwner();
		if (owner == null)
		{
			return;
		}
		if (this.CumulativePayShopContentPanel == null)
		{
			CumulativePayShopContentPanel panel = new CumulativePayShopContentPanel();
			this.CumulativePayShopContentPanel = panel;
			panel.CreateByActorAsync(owner, null, false).ContinueWith(delegate()
			{
				panel.SetUiActive(true);
				panel.RefreshCheckButtonVisibility(itemConfigId);
			});
			return;
		}
		this.CumulativePayShopContentPanel.RefreshCheckButtonVisibility(itemConfigId);
	}

	// Token: 0x060122D2 RID: 74450 RVA: 0x00478D44 File Offset: 0x00476F44
	private void RefreshRoleRoundIconItem()
	{
		int itemId = this.Data.GetItemData().ItemId;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
		bool flag = PayShopDefine.PayShopNeedOrnamentRoleIconShopSet.Contains(this.Data.PayShopId);
		this.CurrentRoleRoundIconState = (flag && itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem);
		if (!this.CurrentRoleRoundIconState)
		{
			this.CurrentRoleRoundIconPath = "";
			PayShopRoleRoundIconItem roleRoundIconItem = this.RoleRoundIconItem;
			if (roleRoundIconItem == null)
			{
				return;
			}
			roleRoundIconItem.SetUiActive(false);
			return;
		}
		else
		{
			RoleOrnamentData roleOrnamentData = RoleOrnamentModel.Instance.GetRoleOrnamentData(itemId);
			int[] array = (roleOrnamentData != null) ? roleOrnamentData.GetRoleSkinIds() : null;
			int num = (array != null && array.Length != 0) ? array[0] : 0;
			if (num == 0)
			{
				this.CurrentRoleRoundIconPath = "";
				PayShopRoleRoundIconItem roleRoundIconItem2 = this.RoleRoundIconItem;
				if (roleRoundIconItem2 == null)
				{
					return;
				}
				roleRoundIconItem2.SetUiActive(false);
				return;
			}
			else
			{
				RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(num);
				int num2 = (roleSkinConfig != null) ? roleSkinConfig.GetValueOrDefault().RoleId : 0;
				RoleInfo? roleInfo = (num2 > 0) ? RoleConfig.Instance.GetRoleConfig(num2) : null;
				string text = ((roleInfo != null) ? roleInfo.GetValueOrDefault().RoleHeadIconCircle : null) ?? "";
				if (string.IsNullOrEmpty(text))
				{
					this.CurrentRoleRoundIconPath = "";
					PayShopRoleRoundIconItem roleRoundIconItem3 = this.RoleRoundIconItem;
					if (roleRoundIconItem3 == null)
					{
						return;
					}
					roleRoundIconItem3.SetUiActive(false);
					return;
				}
				else
				{
					if (this.CurrentRoleRoundIconState && this.RoleRoundIconItem == null)
					{
						this.RoleRoundIconItem = new PayShopRoleRoundIconItem();
						this.RoleRoundIconItem.CreateThenShowByResourceIdAsync("UiItem_ItemBaseC1Head", base.GetItem(19), false).ContinueWith(new Action(this.RefreshRoleRoundIconItem));
						return;
					}
					PayShopRoleRoundIconItem roleRoundIconItem4 = this.RoleRoundIconItem;
					if (roleRoundIconItem4 != null)
					{
						roleRoundIconItem4.SetUiActive(this.CurrentRoleRoundIconState);
					}
					if (this.CurrentRoleRoundIconPath != text)
					{
						this.CurrentRoleRoundIconPath = text;
						PayShopRoleRoundIconItem roleRoundIconItem5 = this.RoleRoundIconItem;
						if (roleRoundIconItem5 == null)
						{
							return;
						}
						roleRoundIconItem5.SetIconByPath(text);
					}
					return;
				}
			}
		}
	}

	// Token: 0x060122D3 RID: 74451 RVA: 0x00478F28 File Offset: 0x00477128
	private void RefreshDiscountLabel()
	{
		int discountLabel = this.Data.GetDiscountLabel();
		if (discountLabel > 0 && this.Data.InLabelShowTime() && this.CurrentLabelId != discountLabel)
		{
			this.CurrentLabelId = discountLabel;
			string tempText = PayShopConfig.Instance.GetShopDiscountLabel(discountLabel);
			if (PayShopDefine.payGiftRoutedShopSet.Contains(this.Data.PayShopId))
			{
				base.GetItem(4).SetUIActive(false);
				PayShopTagItem tagItem = new PayShopTagItem();
				string valueOrDefault = PayShopDefine.payShopTagTypeToResourceId.GetValueOrDefault((PayShopDefine.EPayShopTagType)discountLabel);
				tagItem.CreateThenShowByResourceIdAsync(valueOrDefault, base.GetItem(18), false).ContinueWith(delegate()
				{
					tagItem.SetTextByTextId(tempText, 0);
				});
				return;
			}
			base.GetText(11).ShowTextNew(tempText);
		}
	}

	// Token: 0x060122D4 RID: 74452 RVA: 0x00478FF8 File Offset: 0x004771F8
	private bool RefreshCountDown()
	{
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Data.GetCountDownData();
		bool result = false;
		if (countDownData.Item3 == 0.0)
		{
			if (this.CurrentBuyLimitItemState)
			{
				base.GetItem(5).SetUIActive(false);
				this.CurrentBuyLimitItemState = false;
				result = true;
			}
			return result;
		}
		CommonDefine.IPayShowCountDownRemainTime payShowCountDownRemainTime = countDownData.Item2;
		EPayCountTimeType item = countDownData.Item1;
		if (this.ForceHideResellText)
		{
			payShowCountDownRemainTime = null;
		}
		if (payShowCountDownRemainTime != null && item != EPayCountTimeType.Resell)
		{
			if (!this.CurrentBuyLimitItemState)
			{
				base.GetItem(5).SetUIActive(true);
				this.CurrentBuyLimitItemState = true;
				result = true;
			}
			UUIText text = base.GetText(6);
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime2 = payShowCountDownRemainTime as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime2 != null)
			{
				text.SetText(payShowCountDownRemainTime2.Value, true);
				return result;
			}
			LguiUtil.Instance.SetLocalText(text, ((CommonDefine.IRemainTime)payShowCountDownRemainTime).TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.IRemainTime)payShowCountDownRemainTime).TimeValue));
		}
		else if (this.CurrentBuyLimitItemState)
		{
			base.GetItem(5).SetUIActive(false);
			this.CurrentBuyLimitItemState = false;
			result = true;
		}
		return result;
	}

	// Token: 0x060122D5 RID: 74453 RVA: 0x004790F4 File Offset: 0x004772F4
	private void RefreshReSellText()
	{
		string resellText = this.Data.GetResellText();
		bool flag = !StringUtils.IsEmpty(resellText);
		if (this.ForceHideResellText)
		{
			flag = false;
		}
		if (this.CurrentReSellText != resellText)
		{
			this.CurrentReSellText = resellText;
			if (flag)
			{
				string textById = TextConfig.Instance.GetTextById(resellText);
				base.GetText(7).SetText(textById, true);
			}
		}
		if (this.CurrentResellTextState != flag)
		{
			this.CurrentResellTextState = flag;
			base.GetText(7).SetUIActive(flag);
		}
	}

	// Token: 0x060122D6 RID: 74454 RVA: 0x00479170 File Offset: 0x00477370
	private bool RefreshDiscount()
	{
		UUIItem item = base.GetItem(1);
		bool flag = this.Data.HasDiscount();
		if (flag && PayShopDefine.payGiftRoutedShopSet.Contains(this.Data.PayShopId))
		{
			if (item != null)
			{
				item.SetUIActive(false);
			}
			bool flag2 = this.Data.GetDiscountLabel() != 0;
			if (!this.PackageDiscountState && !flag2)
			{
				PayShopTagItem discountNewItem = new PayShopTagItem();
				discountNewItem.CreateThenShowByResourceIdAsync("ShopItemDiscountLabel", base.GetItem(12), false).ContinueWith(delegate()
				{
					int discountNew = this.Data.GetDiscountNew();
					discountNewItem.SetText(StringUtils.Format("+{0}%", new string[]
					{
						discountNew.ToString()
					}));
				});
				this.PackageDiscountState = true;
			}
			return false;
		}
		bool result = false;
		if (this.CurrentDiscountItemState != flag)
		{
			item.SetUIActive(flag);
			this.CurrentDiscountItemState = flag;
			result = true;
		}
		if (this.CurrentDiscountItemState)
		{
			int discount = this.Data.GetDiscount();
			if (discount != this.CurrentDiscountValue)
			{
				this.CurrentDiscountValue = discount;
				base.GetText(2).SetText(StringUtils.Format("-{0}%", new string[]
				{
					discount.ToString()
				}), true);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x060122D7 RID: 74455 RVA: 0x0047928C File Offset: 0x0047748C
	private void RefreshReUpTimeText()
	{
		if (this.ForceHideReUpState)
		{
			base.GetItem(5).SetUIActive(false);
			return;
		}
		if (this.CurrentBuyLimitItemState)
		{
			return;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Data.GetCountDownData();
		if (countDownData.Item1 != EPayCountTimeType.Resell)
		{
			base.GetItem(5).SetUIActive(false);
			this.PayShopItemBase.SetLeftTimeTextShowState(true);
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime item = countDownData.Item2;
		base.GetItem(5).SetUIActive(true);
		this.PayShopItemBase.SetLeftTimeTextShowState(false);
		UUIText text = base.GetText(6);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		LguiUtil.Instance.SetLocalText(text, ((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)item).Value.TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)item).Value.TimeValue));
	}

	// Token: 0x060122D8 RID: 74456 RVA: 0x0047935C File Offset: 0x0047755C
	public void SetLeftTimeTextShowState(bool state)
	{
		this.PayShopItemBase.SetLeftTimeTextShowState(state);
	}

	// Token: 0x060122D9 RID: 74457 RVA: 0x0047936A File Offset: 0x0047756A
	public void SetNameTextShowState(bool state)
	{
		this.PayShopItemBase.SetNameTextShowState(state);
	}

	// Token: 0x060122DA RID: 74458 RVA: 0x00479378 File Offset: 0x00477578
	public void SetRedDotState(bool state)
	{
		this.PayShopItemBase.RefreshRedDotState = state;
		this.PayShopItemBase.SetRedDotVisible(state);
	}

	// Token: 0x060122DB RID: 74459 RVA: 0x00479392 File Offset: 0x00477592
	public void SetNewFlagState(bool state)
	{
		base.GetItem(17).SetUIActive(state);
	}

	// Token: 0x060122DC RID: 74460 RVA: 0x004793A2 File Offset: 0x004775A2
	[NullableContext(1)]
	public void SetExchangeExtraData(PayShopExchangeExtraData extraData)
	{
		this.ExchangeExtraData = extraData;
	}

	// Token: 0x060122DD RID: 74461 RVA: 0x004793AB File Offset: 0x004775AB
	[NullableContext(1)]
	public void SetExtraFunction(Action<PayShopItem, PayShopGoods> buttonExtraFunction)
	{
		this.ButtonExtraFunction = buttonExtraFunction;
	}

	// Token: 0x060122DE RID: 74462 RVA: 0x004793B4 File Offset: 0x004775B4
	protected void TryEmitRefreshTips()
	{
		PayShopController.Instance.ClosePayShopGoodDetailPopView();
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, (int)this.Data.PayShopId, true);
	}

	// Token: 0x060122DF RID: 74463 RVA: 0x004793E9 File Offset: 0x004775E9
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0400894D RID: 35149
	private bool CurrentBuyLimitItemState;

	// Token: 0x0400894E RID: 35150
	private bool CurrentDiscountItemState;

	// Token: 0x0400894F RID: 35151
	private PayShopGoods Data;

	// Token: 0x04008950 RID: 35152
	private PayShopItemBase PayShopItemBase;

	// Token: 0x04008951 RID: 35153
	private bool DiscountLabelShowState;

	// Token: 0x04008952 RID: 35154
	private int CurrentLabelId;

	// Token: 0x04008953 RID: 35155
	private bool CurrentResellTextState;

	// Token: 0x04008954 RID: 35156
	[Nullable(1)]
	private string CurrentReSellText = "";

	// Token: 0x04008955 RID: 35157
	private int CurrentDiscountValue;

	// Token: 0x04008956 RID: 35158
	private bool CurrentBuyButtonSelfInteractiveState;

	// Token: 0x04008957 RID: 35159
	private bool CurrentWarnState;

	// Token: 0x04008958 RID: 35160
	private bool CurrentRecommendTagItemState;

	// Token: 0x04008959 RID: 35161
	private PayShopRoleRoundIconItem RoleRoundIconItem;

	// Token: 0x0400895A RID: 35162
	private bool CurrentRoleRoundIconState;

	// Token: 0x0400895B RID: 35163
	[Nullable(1)]
	private string CurrentRoleRoundIconPath = "";

	// Token: 0x0400895C RID: 35164
	private bool ForceHideResellText;

	// Token: 0x0400895D RID: 35165
	private bool ForceDisableSelfInteractive;

	// Token: 0x0400895E RID: 35166
	private bool ForceHideReUpState;

	// Token: 0x0400895F RID: 35167
	private bool LeftTopState = true;

	// Token: 0x04008960 RID: 35168
	private bool PackageDiscountState;

	// Token: 0x04008961 RID: 35169
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<PayShopItem, PayShopGoods> ButtonExtraFunction;

	// Token: 0x04008962 RID: 35170
	private PayShopExchangeExtraData ExchangeExtraData;

	// Token: 0x04008963 RID: 35171
	private UiPanelBase RecommendTagItem;

	// Token: 0x04008964 RID: 35172
	private CumulativePayShopContentPanel CumulativePayShopContentPanel;

	// Token: 0x02008925 RID: 35109
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C948 RID: 182600
		BaseItem,
		// Token: 0x0402C949 RID: 182601
		DiscountItem,
		// Token: 0x0402C94A RID: 182602
		DiscountText,
		// Token: 0x0402C94B RID: 182603
		DiscountLabelSprite,
		// Token: 0x0402C94C RID: 182604
		DiscountLabelItem,
		// Token: 0x0402C94D RID: 182605
		BuyLimitTimeItem,
		// Token: 0x0402C94E RID: 182606
		BuyLimitTimeText,
		// Token: 0x0402C94F RID: 182607
		ReSellText,
		// Token: 0x0402C950 RID: 182608
		BuyButton,
		// Token: 0x0402C951 RID: 182609
		ReUpTimeItem,
		// Token: 0x0402C952 RID: 182610
		ReUpTimeText,
		// Token: 0x0402C953 RID: 182611
		LabelText,
		// Token: 0x0402C954 RID: 182612
		LeftTopItem,
		// Token: 0x0402C955 RID: 182613
		SoldOutItem,
		// Token: 0x0402C956 RID: 182614
		SoldOutText,
		// Token: 0x0402C957 RID: 182615
		WarnItem,
		// Token: 0x0402C958 RID: 182616
		WarnText,
		// Token: 0x0402C959 RID: 182617
		NewFlagItem,
		// Token: 0x0402C95A RID: 182618
		ItemTagPanel,
		// Token: 0x0402C95B RID: 182619
		ItemTagPanelTopRight
	}
}
