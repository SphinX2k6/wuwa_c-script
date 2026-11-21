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

// Token: 0x02001035 RID: 4149
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopView : UiViewBase
{
	// Token: 0x0600A52C RID: 42284 RVA: 0x003085E4 File Offset: 0x003067E4
	public FloroRanchShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A52D RID: 42285 RVA: 0x00308640 File Offset: 0x00306840
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

	// Token: 0x0600A52E RID: 42286 RVA: 0x00308BAC File Offset: 0x00306DAC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchShopView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchShopView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A52F RID: 42287 RVA: 0x00308BF0 File Offset: 0x00306DF0
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

	// Token: 0x0600A530 RID: 42288 RVA: 0x00308C70 File Offset: 0x00306E70
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

	// Token: 0x0600A531 RID: 42289 RVA: 0x00308CD0 File Offset: 0x00306ED0
	protected override void OnBeforeHide()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName != null)
		{
			(viewByName as FloroRanchGamePlayView).SetToyPanelActive(true);
		}
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A532 RID: 42290 RVA: 0x00308D08 File Offset: 0x00306F08
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(18));
	}

	// Token: 0x0600A533 RID: 42291 RVA: 0x00308D1C File Offset: 0x00306F1C
	private FloroRanchGoodsItem CreateGoodsItem()
	{
		FloroRanchGoodsItem floroRanchGoodsItem = new FloroRanchGoodsItem();
		floroRanchGoodsItem.BindClickCallback(new Action<FloroRanchShopItemDataBase>(this.OnClickGoodItem));
		this.GoodsItemList.Add(floroRanchGoodsItem);
		return floroRanchGoodsItem;
	}

	// Token: 0x0600A534 RID: 42292 RVA: 0x00308D50 File Offset: 0x00306F50
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

	// Token: 0x0600A535 RID: 42293 RVA: 0x00308D9B File Offset: 0x00306F9B
	private void InitUiBlur()
	{
		this.UiBlur = UE.NewObject<TsUiBlur>(this.RootActor, null, EObjectFlags.RF_NoFlags);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A536 RID: 42294 RVA: 0x00308DBC File Offset: 0x00306FBC
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

	// Token: 0x0600A537 RID: 42295 RVA: 0x00308FB4 File Offset: 0x003071B4
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

	// Token: 0x0600A538 RID: 42296 RVA: 0x003093CC File Offset: 0x003075CC
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

	// Token: 0x0600A539 RID: 42297 RVA: 0x00309410 File Offset: 0x00307610
	private void ShowToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
			floroRanchToyGridItem.PlayShowAnim(toyEntityByPoint);
		}
	}

	// Token: 0x0600A53A RID: 42298 RVA: 0x00309440 File Offset: 0x00307640
	private void HideToy(int point)
	{
		FloroRanchToyGridItem floroRanchToyGridItem;
		if (this.ToyItemMap.TryGetValue(point, out floroRanchToyGridItem))
		{
			floroRanchToyGridItem.SetInfoPanelActive(false);
		}
	}

	// Token: 0x0600A53B RID: 42299 RVA: 0x00309464 File Offset: 0x00307664
	private void SetToyListActive(bool isActive)
	{
		base.GetItem(27).SetAlpha(isActive > false);
	}

	// Token: 0x0600A53C RID: 42300 RVA: 0x00309478 File Offset: 0x00307678
	private void ToySellCallback(int point)
	{
		this.HideToy(point);
		this.RefreshGoodsView(false);
	}

	// Token: 0x0600A53D RID: 42301 RVA: 0x00309488 File Offset: 0x00307688
	private void OnClickGoodItem(FloroRanchShopItemDataBase data)
	{
		this.SelectGoodsData(data);
	}

	// Token: 0x0600A53E RID: 42302 RVA: 0x00309491 File Offset: 0x00307691
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

	// Token: 0x0600A53F RID: 42303 RVA: 0x003094CC File Offset: 0x003076CC
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

	// Token: 0x0600A540 RID: 42304 RVA: 0x00309508 File Offset: 0x00307708
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

	// Token: 0x0600A541 RID: 42305 RVA: 0x00309578 File Offset: 0x00307778
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

	// Token: 0x0600A542 RID: 42306 RVA: 0x003096A8 File Offset: 0x003078A8
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

	// Token: 0x0600A543 RID: 42307 RVA: 0x00309754 File Offset: 0x00307954
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

	// Token: 0x0600A544 RID: 42308 RVA: 0x003097B7 File Offset: 0x003079B7
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x0600A545 RID: 42309 RVA: 0x003097C3 File Offset: 0x003079C3
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

	// Token: 0x0600A546 RID: 42310 RVA: 0x003097E4 File Offset: 0x003079E4
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

	// Token: 0x0600A547 RID: 42311 RVA: 0x00309868 File Offset: 0x00307A68
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

	// Token: 0x0600A548 RID: 42312 RVA: 0x00309924 File Offset: 0x00307B24
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

	// Token: 0x040060C8 RID: 24776
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x040060C9 RID: 24777
	private GenericScrollViewNew<FloroRanchGoodsItem, FloroRanchShopItemDataBase> GoodsScrollView;

	// Token: 0x040060CA RID: 24778
	private FloroRanchShop ShopData;

	// Token: 0x040060CB RID: 24779
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x040060CC RID: 24780
	private readonly List<FloroRanchGoodsItem> GoodsItemList = new List<FloroRanchGoodsItem>();

	// Token: 0x040060CD RID: 24781
	private FloroRanchShopItemDataBase CurSelectGoods;

	// Token: 0x040060CE RID: 24782
	private readonly Dictionary<int, FloroRanchToyGridItem> ToyItemMap = new Dictionary<int, FloroRanchToyGridItem>();

	// Token: 0x040060CF RID: 24783
	private Action CloseCallback;

	// Token: 0x040060D0 RID: 24784
	private UUIInturnAnimController AnimController;

	// Token: 0x040060D1 RID: 24785
	private TsUiBlur UiBlur;

	// Token: 0x040060D2 RID: 24786
	private readonly string[] TypeTextId = new string[]
	{
		"Farm_CardType1",
		"Farm_CardType3",
		"Farm_CardType2"
	};

	// Token: 0x040060D3 RID: 24787
	public readonly List<FloroRanchShopItemDataBase> ShopItemDataList = new List<FloroRanchShopItemDataBase>();

	// Token: 0x02007280 RID: 29312
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025458 RID: 152664
		public const int CloseButton = 0;

		// Token: 0x04025459 RID: 152665
		public const int RefreshButton = 1;

		// Token: 0x0402545A RID: 152666
		public const int RefreshTexture = 2;

		// Token: 0x0402545B RID: 152667
		public const int RefreshPrice = 3;

		// Token: 0x0402545C RID: 152668
		public const int RefreshButtonText = 4;

		// Token: 0x0402545D RID: 152669
		public const int GoodsScrollView = 5;

		// Token: 0x0402545E RID: 152670
		public const int GoodsItem = 6;

		// Token: 0x0402545F RID: 152671
		public const int HideButton = 7;

		// Token: 0x04025460 RID: 152672
		public const int ItemCost = 8;

		// Token: 0x04025461 RID: 152673
		public const int GoodsTipItem = 9;

		// Token: 0x04025462 RID: 152674
		public const int GoodsName = 10;

		// Token: 0x04025463 RID: 152675
		public const int GoodsTexture = 11;

		// Token: 0x04025464 RID: 152676
		public const int GoodsType = 12;

		// Token: 0x04025465 RID: 152677
		public const int GoodsRaceItem = 13;

		// Token: 0x04025466 RID: 152678
		public const int GoodsRaceTexture = 14;

		// Token: 0x04025467 RID: 152679
		public const int GoodsRaceName = 15;

		// Token: 0x04025468 RID: 152680
		public const int EarnTexture = 16;

		// Token: 0x04025469 RID: 152681
		public const int EarnCount = 17;

		// Token: 0x0402546A RID: 152682
		public const int GoodsDesc = 18;

		// Token: 0x0402546B RID: 152683
		public const int QualityTexture = 19;

		// Token: 0x0402546C RID: 152684
		public const int QualityBTexture = 20;

		// Token: 0x0402546D RID: 152685
		public const int SoldItem = 21;

		// Token: 0x0402546E RID: 152686
		public const int BuyButton = 22;

		// Token: 0x0402546F RID: 152687
		public const int BuyButtonText = 23;

		// Token: 0x04025470 RID: 152688
		public const int BuyTexture = 24;

		// Token: 0x04025471 RID: 152689
		public const int BuyCount = 25;

		// Token: 0x04025472 RID: 152690
		public const int ItemHidePanel = 26;

		// Token: 0x04025473 RID: 152691
		public const int ToyLayout = 27;

		// Token: 0x04025474 RID: 152692
		public const int ToyItemTemplate = 28;

		// Token: 0x04025475 RID: 152693
		public const int RefreshTimePanel = 29;

		// Token: 0x04025476 RID: 152694
		public const int RefreshTimeText = 30;

		// Token: 0x04025477 RID: 152695
		public const int ToyRaceItem = 31;

		// Token: 0x04025478 RID: 152696
		public const int ToyRaceIcon = 32;

		// Token: 0x04025479 RID: 152697
		public const int ItemPhantomIcon = 33;

		// Token: 0x0402547A RID: 152698
		public const int RecommendSprite = 34;
	}
}
