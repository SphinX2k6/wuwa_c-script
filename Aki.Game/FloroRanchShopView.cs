using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001B76 RID: 7030
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopView : UiViewBase
{
	// Token: 0x0600D11B RID: 53531 RVA: 0x002FD50C File Offset: 0x002FB70C
	public FloroRanchShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D11C RID: 53532 RVA: 0x002FD568 File Offset: 0x002FB768
	protected unsafe override void OnRegisterComponent()
	{
		int num = 35;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickBuyButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickRefreshButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickHideButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D11D RID: 53533 RVA: 0x002FDAD4 File Offset: 0x002FBCD4
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchShopView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchShopView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D11E RID: 53534 RVA: 0x002FDB18 File Offset: 0x002FBD18
	protected override void OnStart()
	{
		this.ActivityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		FloroRanchShopViewParam floroRanchShopViewParam = (FloroRanchShopViewParam)this.OpenParam;
		this.CloseCallback = floroRanchShopViewParam.CloseCallback;
		FloroRanchShop shopData = floroRanchShopViewParam.ShopData;
		this.InitShopItemDataList(shopData);
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(18),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.FloroRanch,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600D11F RID: 53535 RVA: 0x002FDB98 File Offset: 0x002FBD98
	protected override void OnBeforeShow()
	{
		this.RefreshGoodsView(true);
		this.ShowAllToy();
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName != null)
		{
			(viewByName as FloroRanchGamePlayView).SetToyPanelActive(false);
		}
		UUIInturnAnimController animController = this.AnimController;
		if (animController != null)
		{
			animController.Play("", -1, false);
		}
		this.UiBlur.SetEnableUiBlur(true);
	}

	// Token: 0x0600D120 RID: 53536 RVA: 0x002FDBF8 File Offset: 0x002FBDF8
	protected override void OnBeforeHide()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName != null)
		{
			(viewByName as FloroRanchGamePlayView).SetToyPanelActive(true);
		}
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600D121 RID: 53537 RVA: 0x002FDC30 File Offset: 0x002FBE30
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(18));
	}

	// Token: 0x0600D122 RID: 53538 RVA: 0x002FDC44 File Offset: 0x002FBE44
	private FloroRanchGoodsItem CreateGoodsItem()
	{
		FloroRanchGoodsItem floroRanchGoodsItem = new FloroRanchGoodsItem();
		floroRanchGoodsItem.BindClickCallback(new Action<FloroRanchShopItemDataBase>(this.OnClickGoodItem));
		this.GoodsItemList.Add(floroRanchGoodsItem);
		return floroRanchGoodsItem;
	}

	// Token: 0x0600D123 RID: 53539 RVA: 0x002FDC78 File Offset: 0x002FBE78
	private UniTask CreateToyItem(int point)
	{
		FloroRanchShopView.<CreateToyItem>d__20 <CreateToyItem>d__;
		<CreateToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateToyItem>d__.<>4__this = this;
		<CreateToyItem>d__.point = point;
		<CreateToyItem>d__.<>1__state = -1;
		<CreateToyItem>d__.<>t__builder.Start<FloroRanchShopView.<CreateToyItem>d__20>(ref <CreateToyItem>d__);
		return <CreateToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D124 RID: 53540 RVA: 0x002FDCC3 File Offset: 0x002FBEC3
	private void InitUiBlur()
	{
		this.UiBlur = UE.NewObject<TsUiBlur>(this.RootActor, null, EObjectFlags.RF_NoFlags);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600D125 RID: 53541 RVA: 0x002FDCE4 File Offset: 0x002FBEE4
	private void RefreshGoodsView(bool resetToFirst)
	{
		FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
		this.ItemCost.SetCurrencyData(diamondData);
		bool allowedRefresh = this.ShopData.AllowedRefresh;
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(allowedRefresh);
		}
		if (allowedRefresh)
		{
			int count = this.ShopData.Cost[0].Count;
			bool flag = FloroRanchGamePlayModel.Instance.DiamondData.GetAmount() >= (long)count;
			UUIText text = base.GetText(3);
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			FloroRanchCurrencyConfigData floroRanchCurrencyConfig = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(ECurrencyType.Diamond);
			base.SetTextureByPath(floroRanchCurrencyConfig.GetSmallIcon(), base.GetTexture(2), null, null);
			int freeTimes = this.ShopData.FreeTimes;
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.ShowTextNew((freeTimes > 0) ? "Farm_Edit5" : "Farm_Edit4");
			}
			UUIItem item = base.GetItem(29);
			if (item != null)
			{
				item.SetUIActive(freeTimes > 0);
			}
			UUIText text3 = base.GetText(30);
			if (text3 != null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(freeTimes);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		foreach (FloroRanchGoodsItem floroRanchGoodsItem in this.GoodsItemList)
		{
			floroRanchGoodsItem.SetSelectState(false);
		}
		this.GoodsScrollView.RefreshByDataAsync(this.ShopItemDataList, false).ContinueWith(delegate()
		{
			this.UpdateSelectionAfterDataChange(resetToFirst);
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		});
	}

	// Token: 0x0600D126 RID: 53542 RVA: 0x002FDEDC File Offset: 0x002FC0DC
	private void RefreshGoodsTip()
	{
		if (this.CurSelectGoods == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "商店没有选中商品！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		FloroRanchShopItemType type = this.CurSelectGoods.Type;
		UUIText text = base.GetText(10);
		if (text != null)
		{
			text.ShowTextNew(this.CurSelectGoods.GetName());
		}
		UUIText text2 = base.GetText(18);
		if (text2 != null)
		{
			text2.SetText(this.CurSelectGoods.Desc, true);
		}
		base.SetTextureByPath(this.CurSelectGoods.GetIcon(), base.GetTexture(11), null, null);
		bool flag = type == FloroRanchShopItemType.ShopToy;
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(31);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		if (!flag)
		{
			int race = this.CurSelectGoods.GetRace();
			FloroRanchRaceData floroRanchRaceData = FloroRanchModel.Instance.GetFloroRanchRaceData(race);
			if (floroRanchRaceData != null)
			{
				base.SetTextureByPath(floroRanchRaceData.SmallIcon, base.GetTexture(14), null, null);
				UUIText text3 = base.GetText(15);
				if (text3 != null)
				{
					text3.ShowTextNew(floroRanchRaceData.GetRaceName());
				}
			}
		}
		else
		{
			FloroRanchRaceData toyRaceData = this.CurSelectGoods.GetToyRaceData();
			if (toyRaceData != null)
			{
				base.SetTextureByPath(toyRaceData.SmallIcon, base.GetTexture(32), null, null);
				UUIItem item3 = base.GetItem(31);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
			}
		}
		bool flag2 = this.CurSelectGoods.Type == FloroRanchShopItemType.Card;
		if (flag2)
		{
			FloroRanchCurrencyData floroRanchCurrencyData = new FloroRanchCurrencyData(ECurrencyType.Salary);
			base.SetTextureByPath(floroRanchCurrencyData.ConfigData.GetSmallIcon(), base.GetTexture(16), null, null);
			UUIText text4 = base.GetText(17);
			if (text4 != null)
			{
				text4.SetText(this.CurSelectGoods.GetEarnCount().ToString(), true);
			}
		}
		UUITexture texture = base.GetTexture(16);
		if (texture != null)
		{
			texture.SetUIActive(flag2);
		}
		UUIText text5 = base.GetText(17);
		if (text5 != null)
		{
			text5.SetUIActive(flag2);
		}
		UUIItem item4 = base.GetItem(33);
		if (item4 != null)
		{
			item4.SetUIActive(this.CurSelectGoods.GetIsSpecialPhantom());
		}
		FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
		bool isSold = this.CurSelectGoods.IsSold;
		if (!isSold)
		{
			int price = this.CurSelectGoods.Price;
			UUIText text6 = base.GetText(25);
			UUIText uuitext = text6;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(price);
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			long amount = diamondData.GetAmount();
			UUIItem uuiitem = text6;
			bool bUseChangeColor = amount < (long)price;
			FColor? fcolor = new FColor?(text6.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetTextureByPath(diamondData.ConfigData.GetSmallIcon(), base.GetTexture(24), null, null);
		}
		UUIButtonComponent button = base.GetButton(22);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!isSold);
		}
		UUIItem item5 = base.GetItem(21);
		if (item5 != null)
		{
			item5.SetUIActive(isSold);
		}
		UUIText text7 = base.GetText(23);
		if (text7 != null)
		{
			text7.ShowTextNew("Farm_Edit1");
		}
		UUIText text8 = base.GetText(12);
		if (text8 != null)
		{
			text8.ShowTextNew(this.TypeTextId[(int)type]);
		}
		FloroRanchRarityData qualityData = this.CurSelectGoods.GetQualityData();
		base.SetTextureByPath(qualityData.GetRarityDetailCardBigBg(), base.GetTexture(19), null, null);
		base.SetTextureByPath(qualityData.GetRarityDetailCardSmallBg(), base.GetTexture(20), null, null);
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		EFloroRanchCardType? efloroRanchCardType = null;
		if (type == FloroRanchShopItemType.ShopToy)
		{
			efloroRanchCardType = new EFloroRanchCardType?(EFloroRanchCardType.Toy);
		}
		else if (type == FloroRanchShopItemType.Card)
		{
			efloroRanchCardType = new EFloroRanchCardType?(EFloroRanchCardType.Phantom);
		}
		bool flag3 = efloroRanchCardType != null && currentActivityData.IsSubDungeonRecommendItem(subInstanceId, this.CurSelectGoods.Id, efloroRanchCardType.Value);
		UUISprite sprite = base.GetSprite(34);
		if (!flag3)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
				return;
			}
		}
		else if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
	}

	// Token: 0x0600D127 RID: 53543 RVA: 0x002FE2F4 File Offset: 0x002FC4F4
	private void ShowAllToy()
	{
		int enableToyCount = FloroRanchGamePlayModel.Instance.EnableToyCount;
		for (int i = 0; i < enableToyCount; i++)
		{
			if (FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(i) != null)
			{
				this.ShowToy(i);
			}
			else
			{
				this.HideToy(i);
			}
		}
	}

	// Token: 0x0600D128 RID: 53544 RVA: 0x002FE338 File Offset: 0x002FC538
	private void ShowToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
			floroRanchToyGridItem.PlayShowAnim(toyEntityByPoint);
		}
	}

	// Token: 0x0600D129 RID: 53545 RVA: 0x002FE368 File Offset: 0x002FC568
	private void HideToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			floroRanchToyGridItem.SetInfoPanelActive(false);
		}
	}

	// Token: 0x0600D12A RID: 53546 RVA: 0x002FE38C File Offset: 0x002FC58C
	private void SetToyListActive(bool isActive)
	{
		base.GetItem(27).SetAlpha(isActive > false);
	}

	// Token: 0x0600D12B RID: 53547 RVA: 0x002FE3A0 File Offset: 0x002FC5A0
	private void ToySellCallback(int point)
	{
		this.HideToy(point);
		this.RefreshGoodsView(false);
	}

	// Token: 0x0600D12C RID: 53548 RVA: 0x002FE3B0 File Offset: 0x002FC5B0
	private void OnClickGoodItem(FloroRanchShopItemDataBase data)
	{
		this.SelectGoodsData(data);
	}

	// Token: 0x0600D12D RID: 53549 RVA: 0x002FE3B9 File Offset: 0x002FC5B9
	private void SelectGoodsData(FloroRanchShopItemDataBase data)
	{
		if (this.CurSelectGoods != null)
		{
			this.RefreshGoodsItemToggleState(false, this.CurSelectGoods.IncId);
		}
		this.CurSelectGoods = data;
		if (data != null)
		{
			this.RefreshGoodsItemToggleState(true, data.IncId);
		}
		this.RefreshGoodsTip();
	}

	// Token: 0x0600D12E RID: 53550 RVA: 0x002FE3F4 File Offset: 0x002FC5F4
	private void RefreshGoodsItemToggleState(bool isSelected, int incId)
	{
		FloroRanchGoodsItem floroRanchGoodsItem = this.GoodsItemList.Find(delegate(FloroRanchGoodsItem item)
		{
			FloroRanchShopItemDataBase data = item.Data;
			return data != null && data.IncId == incId;
		});
		if (floroRanchGoodsItem != null)
		{
			floroRanchGoodsItem.SetSelectState(isSelected);
		}
	}

	// Token: 0x0600D12F RID: 53551 RVA: 0x002FE430 File Offset: 0x002FC630
	private void OnClickToyItem(int point)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchShopTipView, new FloroRanchShopTipViewParam
		{
			ToyPoint = point,
			SellCallback = new Action<int>(this.ToySellCallback),
			ShowToyListCallback = new Action<bool>(this.SetToyListActive)
		}, null);
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			floroRanchToyGridItem.SetSelectState(false);
		}
	}

	// Token: 0x0600D130 RID: 53552 RVA: 0x002FE4A0 File Offset: 0x002FC6A0
	private void OnClickBuyButton()
	{
		if (this.CurSelectGoods == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "商店没有选中商品！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int cardLimitCount = FloroRanchGamePlayModel.Instance.GetCurrentActivityData().CardLimitCount;
		if (FloroRanchGamePlayModel.Instance.OwnCardEntityCount >= cardLimitCount)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhrolovaFarm_AnimalMax", Array.Empty<object>());
			return;
		}
		long amount = FloroRanchGamePlayModel.Instance.DiamondData.GetAmount();
		int price = this.CurSelectGoods.Price;
		if (amount < (long)price)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_BuyFail", Array.Empty<object>());
			return;
		}
		int id = this.CurSelectGoods.Id;
		FloroRanchShopItemType type = this.CurSelectGoods.Type;
		if (type == FloroRanchShopItemType.ShopToy)
		{
			int curToyCount = FloroRanchGamePlayModel.Instance.GetCurToyCount();
			int enableToyCount = FloroRanchGamePlayModel.Instance.EnableToyCount;
			if (curToyCount >= enableToyCount)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ToyFull", Array.Empty<object>());
				return;
			}
		}
		int activityId = FloroRanchGamePlayModel.Instance.ActivityId;
		FloroRanchController.Instance.SendFloroRanchPlayShopBuyRequest(activityId, FloroRanchGamePlayModel.Instance.SubInstanceId, this.ShopData.IncId, id, (int)type, this.CurSelectGoods.IncId, delegate(FloroRanchPlayShopBuyResponse response)
		{
			if (response == null)
			{
				return;
			}
			this.InitShopItemDataList(response.Shop);
			this.RefreshGoodsView(false);
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_BuySuccess", Array.Empty<object>());
			if (response.Toy != null)
			{
				int point = response.Toy.NewToy.Point;
				this.ShowToy(point);
			}
		});
	}

	// Token: 0x0600D131 RID: 53553 RVA: 0x002FE5D0 File Offset: 0x002FC7D0
	private void OnClickRefreshButton()
	{
		if (!this.ShopData.AllowedRefresh)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "商店刷新 allowedRefresh 为 false", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (FloroRanchGamePlayModel.Instance.DiamondData.GetAmount() < (long)this.ShopData.Cost[0].Count)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_MoneyNotEnough", Array.Empty<object>());
			return;
		}
		FloroRanchGamePlayModel instance = FloroRanchGamePlayModel.Instance;
		int activityId = instance.ActivityId;
		FloroRanchController.Instance.SendFloroRanchPlayRefreshShopRequest(activityId, instance.SubInstanceId, this.ShopData.IncId, delegate(FloroRanchPlayRefreshShopResponse response)
		{
			this.InitShopItemDataList(response.Shop);
			this.RefreshGoodsView(true);
			UUIInturnAnimController animController = this.AnimController;
			if (animController == null)
			{
				return;
			}
			animController.Play("", -1, false);
		});
	}

	// Token: 0x0600D132 RID: 53554 RVA: 0x002FE67C File Offset: 0x002FC87C
	private void SendCloseTaskRequest()
	{
		if (this.ShopData != null)
		{
			int activityId = FloroRanchGamePlayModel.Instance.ActivityId;
			int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
			FloroRanchController.Instance.SendFloroRanchCloseTaskRequest(activityId, subInstanceId, this.ShopData.IncId, null);
			return;
		}
		Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "商店数据为空！ 无法发送关闭任务请求", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600D133 RID: 53555 RVA: 0x002FE6DF File Offset: 0x002FC8DF
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x0600D134 RID: 53556 RVA: 0x002FE6EB File Offset: 0x002FC8EB
	private void OnClickCloseButton()
	{
		this.SendCloseTaskRequest();
		base.CloseMe(null);
		Action closeCallback = this.CloseCallback;
		if (closeCallback == null)
		{
			return;
		}
		closeCallback();
	}

	// Token: 0x0600D135 RID: 53557 RVA: 0x002FE70C File Offset: 0x002FC90C
	public void InitShopItemDataList(FloroRanchShop shopData)
	{
		this.ShopData = shopData;
		RepeatedField<FloroRanchShopItem> items = shopData.Items;
		this.ShopItemDataList.Clear();
		foreach (FloroRanchShopItem item in items)
		{
			FloroRanchShopItemDataBase floroRanchShopItemDataBase = this.CreateShopItem(item);
			if (floroRanchShopItemDataBase != null)
			{
				this.ShopItemDataList.Add(floroRanchShopItemDataBase);
			}
		}
		this.ActivityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
	}

	// Token: 0x0600D136 RID: 53558 RVA: 0x002FE790 File Offset: 0x002FC990
	private void UpdateSelectionAfterDataChange(bool resetToFirst)
	{
		FloroRanchShopView.<>c__DisplayClass40_0 CS$<>8__locals1 = new FloroRanchShopView.<>c__DisplayClass40_0();
		if (this.ShopItemDataList.Count == 0)
		{
			this.CurSelectGoods = null;
			return;
		}
		if (resetToFirst)
		{
			this.CurSelectGoods = null;
			this.SelectGoodsData(this.ShopItemDataList[0]);
			return;
		}
		FloroRanchShopView.<>c__DisplayClass40_0 CS$<>8__locals2 = CS$<>8__locals1;
		FloroRanchShopItemDataBase curSelectGoods = this.CurSelectGoods;
		CS$<>8__locals2.curSelectGoodIncId = ((curSelectGoods != null) ? new int?(curSelectGoods.IncId) : null);
		if (CS$<>8__locals1.curSelectGoodIncId != null && CS$<>8__locals1.curSelectGoodIncId.GetValueOrDefault() != 0)
		{
			FloroRanchShopItemDataBase floroRanchShopItemDataBase = this.ShopItemDataList.Find((FloroRanchShopItemDataBase item) => item.IncId == CS$<>8__locals1.curSelectGoodIncId.Value);
			if (floroRanchShopItemDataBase != null)
			{
				this.SelectGoodsData(floroRanchShopItemDataBase);
				return;
			}
			this.SelectGoodsData(this.ShopItemDataList[0]);
		}
	}

	// Token: 0x0600D137 RID: 53559 RVA: 0x002FE84C File Offset: 0x002FCA4C
	private FloroRanchShopItemDataBase CreateShopItem(FloroRanchShopItem item)
	{
		switch (item.Type)
		{
		case FloroRanchShopItemType.Card:
			return new FloroRanchShopItemCardData(item);
		case FloroRanchShopItemType.CardGroup:
			return new FloroRanchShopItemCardGroupData(item);
		case FloroRanchShopItemType.ShopToy:
			return new FloroRanchShopItemToyData(item);
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanch商店物品类型错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", item.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		}
	}

	// Token: 0x04005FF9 RID: 24569
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x04005FFA RID: 24570
	private GenericScrollViewNew<FloroRanchGoodsItem, FloroRanchShopItemDataBase> GoodsScrollView;

	// Token: 0x04005FFB RID: 24571
	private FloroRanchShop ShopData;

	// Token: 0x04005FFC RID: 24572
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04005FFD RID: 24573
	private readonly List<FloroRanchGoodsItem> GoodsItemList = new List<FloroRanchGoodsItem>();

	// Token: 0x04005FFE RID: 24574
	private FloroRanchShopItemDataBase CurSelectGoods;

	// Token: 0x04005FFF RID: 24575
	private readonly Dictionary<int, FloroRanchToyGridItem> ToyItemMap = new Dictionary<int, FloroRanchToyGridItem>();

	// Token: 0x04006000 RID: 24576
	private Action CloseCallback;

	// Token: 0x04006001 RID: 24577
	private UUIInturnAnimController AnimController;

	// Token: 0x04006002 RID: 24578
	private TsUiBlur UiBlur;

	// Token: 0x04006003 RID: 24579
	private readonly string[] TypeTextId = new string[]
	{
		"Farm_CardType1",
		"Farm_CardType3",
		"Farm_CardType2"
	};

	// Token: 0x04006004 RID: 24580
	public readonly List<FloroRanchShopItemDataBase> ShopItemDataList = new List<FloroRanchShopItemDataBase>();

	// Token: 0x020080F2 RID: 33010
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A124 RID: 172324
		public const int CloseButton = 0;

		// Token: 0x0402A125 RID: 172325
		public const int RefreshButton = 1;

		// Token: 0x0402A126 RID: 172326
		public const int RefreshTexture = 2;

		// Token: 0x0402A127 RID: 172327
		public const int RefreshPrice = 3;

		// Token: 0x0402A128 RID: 172328
		public const int RefreshButtonText = 4;

		// Token: 0x0402A129 RID: 172329
		public const int GoodsScrollView = 5;

		// Token: 0x0402A12A RID: 172330
		public const int GoodsItem = 6;

		// Token: 0x0402A12B RID: 172331
		public const int HideButton = 7;

		// Token: 0x0402A12C RID: 172332
		public const int ItemCost = 8;

		// Token: 0x0402A12D RID: 172333
		public const int GoodsTipItem = 9;

		// Token: 0x0402A12E RID: 172334
		public const int GoodsName = 10;

		// Token: 0x0402A12F RID: 172335
		public const int GoodsTexture = 11;

		// Token: 0x0402A130 RID: 172336
		public const int GoodsType = 12;

		// Token: 0x0402A131 RID: 172337
		public const int GoodsRaceItem = 13;

		// Token: 0x0402A132 RID: 172338
		public const int GoodsRaceTexture = 14;

		// Token: 0x0402A133 RID: 172339
		public const int GoodsRaceName = 15;

		// Token: 0x0402A134 RID: 172340
		public const int EarnTexture = 16;

		// Token: 0x0402A135 RID: 172341
		public const int EarnCount = 17;

		// Token: 0x0402A136 RID: 172342
		public const int GoodsDesc = 18;

		// Token: 0x0402A137 RID: 172343
		public const int QualityTexture = 19;

		// Token: 0x0402A138 RID: 172344
		public const int QualityBTexture = 20;

		// Token: 0x0402A139 RID: 172345
		public const int SoldItem = 21;

		// Token: 0x0402A13A RID: 172346
		public const int BuyButton = 22;

		// Token: 0x0402A13B RID: 172347
		public const int BuyButtonText = 23;

		// Token: 0x0402A13C RID: 172348
		public const int BuyTexture = 24;

		// Token: 0x0402A13D RID: 172349
		public const int BuyCount = 25;

		// Token: 0x0402A13E RID: 172350
		public const int ItemHidePanel = 26;

		// Token: 0x0402A13F RID: 172351
		public const int ToyLayout = 27;

		// Token: 0x0402A140 RID: 172352
		public const int ToyItemTemplate = 28;

		// Token: 0x0402A141 RID: 172353
		public const int RefreshTimePanel = 29;

		// Token: 0x0402A142 RID: 172354
		public const int RefreshTimeText = 30;

		// Token: 0x0402A143 RID: 172355
		public const int ToyRaceItem = 31;

		// Token: 0x0402A144 RID: 172356
		public const int ToyRaceIcon = 32;

		// Token: 0x0402A145 RID: 172357
		public const int ItemPhantomIcon = 33;

		// Token: 0x0402A146 RID: 172358
		public const int RecommendSprite = 34;
	}
}
