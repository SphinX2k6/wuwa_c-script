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

// Token: 0x0200186B RID: 6251
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x0600F76C RID: 63340 RVA: 0x004855A0 File Offset: 0x004837A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 22;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F76D RID: 63341 RVA: 0x004858E8 File Offset: 0x00483AE8
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

	// Token: 0x0600F76E RID: 63342 RVA: 0x0048591B File Offset: 0x00483B1B
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

	// Token: 0x0600F76F RID: 63343 RVA: 0x00485953 File Offset: 0x00483B53
	public void SetRaycastState(bool state)
	{
		this.RootItem.SetRaycastTarget(state);
		this.PayShopItemBase.GetRootItem().SetRaycastTarget(state);
		base.GetButton(8).SetCanClickWhenDisable(state);
	}

	// Token: 0x0600F770 RID: 63344 RVA: 0x0048597F File Offset: 0x00483B7F
	public void SetResellShowState(bool state)
	{
		this.ForceHideResellText = state;
	}

	// Token: 0x0600F771 RID: 63345 RVA: 0x00485988 File Offset: 0x00483B88
	public void SetDisableSelfInteractiveState(bool state)
	{
		this.ForceDisableSelfInteractive = state;
	}

	// Token: 0x0600F772 RID: 63346 RVA: 0x00485991 File Offset: 0x00483B91
	public void SetForceHideReUpTextState(bool state)
	{
		this.ForceHideReUpState = state;
	}

	// Token: 0x0600F773 RID: 63347 RVA: 0x0048599A File Offset: 0x00483B9A
	public void SetDownPriceShowState(bool state)
	{
		this.PayShopItemBase.SetDownPriceShowState(state);
	}

	// Token: 0x0600F774 RID: 63348 RVA: 0x004859A8 File Offset: 0x00483BA8
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

	// Token: 0x0600F775 RID: 63349 RVA: 0x00485A20 File Offset: 0x00483C20
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

	// Token: 0x0600F776 RID: 63350 RVA: 0x00485ADB File Offset: 0x00483CDB
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0600F777 RID: 63351 RVA: 0x00485AF9 File Offset: 0x00483CF9
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0600F778 RID: 63352 RVA: 0x00485B18 File Offset: 0x00483D18
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

	// Token: 0x0600F779 RID: 63353 RVA: 0x00485BA4 File Offset: 0x00483DA4
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

	// Token: 0x0600F77A RID: 63354 RVA: 0x00485C25 File Offset: 0x00483E25
	public void SetNeedShowOnceBuyLimit(bool state)
	{
		this.PayShopItemBase.SetLeftTimeTextShowOnceBuy(state);
	}

	// Token: 0x0600F77B RID: 63355 RVA: 0x00485C33 File Offset: 0x00483E33
	private void ResetView()
	{
		base.GetItem(15).SetUIActive(false);
		this.CurrentWarnState = false;
		this.CurrentLimitTimePanelStyle = PayShopItem.ELimitTimePanelStyle.None;
	}

	// Token: 0x0600F77C RID: 63356 RVA: 0x00485C54 File Offset: 0x00483E54
	private void RefreshWarnState()
	{
		bool flag = !this.Data.IfCanBuy();
		if (flag)
		{
			if (this.Data.GetCantBuyReason() == PayShopDefine.EPayShopCantBuyReason.NotInSellTime)
			{
				flag = false;
			}
			if (this.ForceDisableSelfInteractive)
			{
				flag = false;
			}
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

	// Token: 0x0600F77D RID: 63357 RVA: 0x00485CCC File Offset: 0x00483ECC
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

	// Token: 0x0600F77E RID: 63358 RVA: 0x00485D48 File Offset: 0x00483F48
	private void RefreshDiscountLabelShowState()
	{
		bool flag = this.Data.GetDiscountLabel() > 0 && (this.Data.InLabelShowTime() || (!this.Data.InLabelShowTime() && false));
		if (this.DiscountLabelShowState != flag)
		{
			base.GetItem(4).SetUIActive(flag);
			this.DiscountLabelShowState = flag;
		}
	}

	// Token: 0x0600F77F RID: 63359 RVA: 0x00485DAC File Offset: 0x00483FAC
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

	// Token: 0x0600F780 RID: 63360 RVA: 0x00485DF8 File Offset: 0x00483FF8
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

	// Token: 0x0600F781 RID: 63361 RVA: 0x00485E7C File Offset: 0x0048407C
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

	// Token: 0x0600F782 RID: 63362 RVA: 0x00485F20 File Offset: 0x00484120
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

	// Token: 0x0600F783 RID: 63363 RVA: 0x00486104 File Offset: 0x00484304
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

	// Token: 0x0600F784 RID: 63364 RVA: 0x004861D4 File Offset: 0x004843D4
	private bool RefreshCountDown()
	{
		if (this.Data.IsShowTimePreview())
		{
			bool result = !this.CurrentBuyLimitItemState;
			if (!this.CurrentBuyLimitItemState)
			{
				base.GetItem(5).SetUIActive(true);
				this.CurrentBuyLimitItemState = true;
			}
			this.SetLimitTimePanelStyle(true);
			PayShopGoodsData goodsData = this.Data.GetGoodsData();
			string text = TimeUtil.Instance.GetDataFromTimeStamp((double)goodsData.BeginTime).ToString("MM.dd");
			string text2 = TimeUtil.Instance.GetDataFromTimeStamp((double)goodsData.EndTime).ToString("MM.dd");
			base.GetText(6).SetText(StringUtils.Format("{0} ~ {1}", new string[]
			{
				text,
				text2
			}), true);
			return result;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Data.GetCountDownData();
		bool result2 = false;
		if (countDownData.Item3 == 0.0)
		{
			if (this.CurrentBuyLimitItemState)
			{
				base.GetItem(5).SetUIActive(false);
				this.CurrentBuyLimitItemState = false;
				result2 = true;
			}
			return result2;
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
				result2 = true;
			}
			this.SetLimitTimePanelStyle(false);
			UUIText text3 = base.GetText(6);
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime2 = payShowCountDownRemainTime as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime2 != null)
			{
				text3.SetText(payShowCountDownRemainTime2.Value, true);
				return result2;
			}
			LguiUtil.Instance.SetLocalText(text3, ((CommonDefine.IRemainTime)payShowCountDownRemainTime).TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.IRemainTime)payShowCountDownRemainTime).TimeValue));
		}
		else if (this.CurrentBuyLimitItemState)
		{
			base.GetItem(5).SetUIActive(false);
			this.CurrentBuyLimitItemState = false;
			result2 = true;
		}
		return result2;
	}

	// Token: 0x0600F785 RID: 63365 RVA: 0x00486390 File Offset: 0x00484590
	private void SetLimitTimePanelStyle(bool isShowTimePreview)
	{
		PayShopItem.ELimitTimePanelStyle elimitTimePanelStyle = isShowTimePreview ? PayShopItem.ELimitTimePanelStyle.ShowTimePreview : PayShopItem.ELimitTimePanelStyle.Normal;
		if (this.CurrentLimitTimePanelStyle == elimitTimePanelStyle)
		{
			return;
		}
		this.CurrentLimitTimePanelStyle = elimitTimePanelStyle;
		string hexStr;
		if (PayShopItem.LimitTimePanelBgColorMap.TryGetValue(elimitTimePanelStyle, out hexStr))
		{
			base.GetSprite(20).SetColor(FColor.FromHex(hexStr));
		}
		string resourceId = isShowTimePreview ? "SP_ShopTimeIcon1" : "SP_ShopTimeIcon";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(21), false, null, null);
	}

	// Token: 0x0600F786 RID: 63366 RVA: 0x00486410 File Offset: 0x00484610
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

	// Token: 0x0600F787 RID: 63367 RVA: 0x0048648C File Offset: 0x0048468C
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

	// Token: 0x0600F788 RID: 63368 RVA: 0x004865A8 File Offset: 0x004847A8
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
		this.SetLimitTimePanelStyle(false);
		UUIText text = base.GetText(6);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		LguiUtil.Instance.SetLocalText(text, ((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)item).Value.TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)item).Value.TimeValue));
	}

	// Token: 0x0600F789 RID: 63369 RVA: 0x0048667F File Offset: 0x0048487F
	public void SetLeftTimeTextShowState(bool state)
	{
		this.PayShopItemBase.SetLeftTimeTextShowState(state);
	}

	// Token: 0x0600F78A RID: 63370 RVA: 0x0048668D File Offset: 0x0048488D
	public void SetNameTextShowState(bool state)
	{
		this.PayShopItemBase.SetNameTextShowState(state);
	}

	// Token: 0x0600F78B RID: 63371 RVA: 0x0048669B File Offset: 0x0048489B
	public void SetRedDotState(bool state)
	{
		this.PayShopItemBase.RefreshRedDotState = state;
		this.PayShopItemBase.SetRedDotVisible(state);
	}

	// Token: 0x0600F78C RID: 63372 RVA: 0x004866B5 File Offset: 0x004848B5
	public void SetNewFlagState(bool state)
	{
		base.GetItem(17).SetUIActive(state);
	}

	// Token: 0x0600F78D RID: 63373 RVA: 0x004866C5 File Offset: 0x004848C5
	public void SetExchangeExtraData(PayShopExchangeExtraData extraData)
	{
		this.ExchangeExtraData = extraData;
	}

	// Token: 0x0600F78E RID: 63374 RVA: 0x004866CE File Offset: 0x004848CE
	public void SetExtraFunction(Action<PayShopItem, PayShopGoods> buttonExtraFunction)
	{
		this.ButtonExtraFunction = buttonExtraFunction;
	}

	// Token: 0x0600F78F RID: 63375 RVA: 0x004866D7 File Offset: 0x004848D7
	protected void TryEmitRefreshTips()
	{
		PayShopController.Instance.ClosePayShopGoodDetailPopView();
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, (int)this.Data.PayShopId, true);
	}

	// Token: 0x0600F790 RID: 63376 RVA: 0x0048670C File Offset: 0x0048490C
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04008A92 RID: 35474
	private static readonly IReadOnlyDictionary<PayShopItem.ELimitTimePanelStyle, string> LimitTimePanelBgColorMap = new Dictionary<PayShopItem.ELimitTimePanelStyle, string>
	{
		{
			PayShopItem.ELimitTimePanelStyle.Normal,
			"111616FF"
		},
		{
			PayShopItem.ELimitTimePanelStyle.ShowTimePreview,
			"BF5F64FF"
		}
	};

	// Token: 0x04008A93 RID: 35475
	private bool CurrentBuyLimitItemState;

	// Token: 0x04008A94 RID: 35476
	private PayShopItem.ELimitTimePanelStyle CurrentLimitTimePanelStyle = PayShopItem.ELimitTimePanelStyle.None;

	// Token: 0x04008A95 RID: 35477
	private bool CurrentDiscountItemState;

	// Token: 0x04008A96 RID: 35478
	[Nullable(2)]
	private PayShopGoods Data;

	// Token: 0x04008A97 RID: 35479
	[Nullable(2)]
	private PayShopItemBase PayShopItemBase;

	// Token: 0x04008A98 RID: 35480
	private bool DiscountLabelShowState;

	// Token: 0x04008A99 RID: 35481
	private int CurrentLabelId;

	// Token: 0x04008A9A RID: 35482
	private bool CurrentResellTextState;

	// Token: 0x04008A9B RID: 35483
	private string CurrentReSellText = "";

	// Token: 0x04008A9C RID: 35484
	private int CurrentDiscountValue;

	// Token: 0x04008A9D RID: 35485
	private bool CurrentBuyButtonSelfInteractiveState;

	// Token: 0x04008A9E RID: 35486
	private bool CurrentWarnState;

	// Token: 0x04008A9F RID: 35487
	private bool CurrentRecommendTagItemState;

	// Token: 0x04008AA0 RID: 35488
	[Nullable(2)]
	private PayShopRoleRoundIconItem RoleRoundIconItem;

	// Token: 0x04008AA1 RID: 35489
	private bool CurrentRoleRoundIconState;

	// Token: 0x04008AA2 RID: 35490
	private string CurrentRoleRoundIconPath = "";

	// Token: 0x04008AA3 RID: 35491
	private bool ForceHideResellText;

	// Token: 0x04008AA4 RID: 35492
	private bool ForceDisableSelfInteractive;

	// Token: 0x04008AA5 RID: 35493
	private bool ForceHideReUpState;

	// Token: 0x04008AA6 RID: 35494
	private bool LeftTopState = true;

	// Token: 0x04008AA7 RID: 35495
	private bool PackageDiscountState;

	// Token: 0x04008AA8 RID: 35496
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<PayShopItem, PayShopGoods> ButtonExtraFunction;

	// Token: 0x04008AA9 RID: 35497
	[Nullable(2)]
	private PayShopExchangeExtraData ExchangeExtraData;

	// Token: 0x04008AAA RID: 35498
	[Nullable(2)]
	private UiPanelBase RecommendTagItem;

	// Token: 0x04008AAB RID: 35499
	[Nullable(2)]
	private CumulativePayShopContentPanel CumulativePayShopContentPanel;

	// Token: 0x02007AAF RID: 31407
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027C60 RID: 162912
		BaseItem,
		// Token: 0x04027C61 RID: 162913
		DiscountItem,
		// Token: 0x04027C62 RID: 162914
		DiscountText,
		// Token: 0x04027C63 RID: 162915
		DiscountLabelSprite,
		// Token: 0x04027C64 RID: 162916
		DiscountLabelItem,
		// Token: 0x04027C65 RID: 162917
		BuyLimitTimeItem,
		// Token: 0x04027C66 RID: 162918
		BuyLimitTimeText,
		// Token: 0x04027C67 RID: 162919
		ReSellText,
		// Token: 0x04027C68 RID: 162920
		BuyButton,
		// Token: 0x04027C69 RID: 162921
		ReUpTimeItem,
		// Token: 0x04027C6A RID: 162922
		ReUpTimeText,
		// Token: 0x04027C6B RID: 162923
		LabelText,
		// Token: 0x04027C6C RID: 162924
		LeftTopItem,
		// Token: 0x04027C6D RID: 162925
		SoldOutItem,
		// Token: 0x04027C6E RID: 162926
		SoldOutText,
		// Token: 0x04027C6F RID: 162927
		WarnItem,
		// Token: 0x04027C70 RID: 162928
		WarnText,
		// Token: 0x04027C71 RID: 162929
		NewFlagItem,
		// Token: 0x04027C72 RID: 162930
		ItemTagPanel,
		// Token: 0x04027C73 RID: 162931
		ItemTagPanelTopRight,
		// Token: 0x04027C74 RID: 162932
		SpriteTimeBg,
		// Token: 0x04027C75 RID: 162933
		SpriteTimeIcon
	}

	// Token: 0x02007AB0 RID: 31408
	[NullableContext(0)]
	private enum ELimitTimePanelStyle
	{
		// Token: 0x04027C77 RID: 162935
		None = -1,
		// Token: 0x04027C78 RID: 162936
		Normal,
		// Token: 0x04027C79 RID: 162937
		ShowTimePreview
	}
}
