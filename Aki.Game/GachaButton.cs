using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C7D RID: 7293
[NullableContext(1)]
[Nullable(0)]
public class GachaButton : UiPanelBase
{
	// Token: 0x0600DBF0 RID: 56304 RVA: 0x00332F06 File Offset: 0x00331106
	public GachaButton(int times)
	{
		this.Times = times;
	}

	// Token: 0x0600DBF1 RID: 56305 RVA: 0x00332F18 File Offset: 0x00331118
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.GachaBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DBF2 RID: 56306 RVA: 0x003330C8 File Offset: 0x003312C8
	private void GachaBtn()
	{
		ProtoGachaInfo gachaInfo = this.GachaPoolData.GachaInfo;
		if (gachaInfo == null)
		{
			return;
		}
		if (gachaInfo.UsePoolId == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("GachaNoOption", Array.Empty<object>());
			return;
		}
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 1000.0)
		{
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		ValueTuple<bool, EConfirmBoxConfigId?> valueTuple = GachaModel.Instance.CheckCountIsEnough(gachaInfo, this.Times);
		if (!valueTuple.Item1)
		{
			EConfirmBoxConfigId? item = valueTuple.Item2;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(item.Value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		int commonItemCount = InventoryModel.Instance.GetCommonItemCount(gachaInfo.ItemId, 0);
		if (gachaInfo.Id == 5 && commonItemCount <= 0)
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.GachaJumpToMail);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		int num = this.ConsumeCount - commonItemCount;
		if (num <= 0)
		{
			GachaController.Instance.GachaRequest(gachaInfo.Id, this.Times, this.GachaPoolData.PoolInfo.Id);
			return;
		}
		ExchangeSimulation exchangeSimulation = ItemExchangeModel.Instance.CalculateConsume(gachaInfo.ItemId, num, 0, true);
		if (exchangeSimulation == null)
		{
			return;
		}
		CommonExchangeData exchangeData = new CommonExchangeData();
		exchangeData.InitByItemId(gachaInfo.ItemId);
		if (CommonConfig.Instance.GetBetaBlockRecharge().GetValueOrDefault())
		{
			ConfirmBoxDataNew confirmBoxDataNew3 = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableGacha);
			confirmBoxDataNew3.SetTextArgs(new string[]
			{
				exchangeData.GetDestName()
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew3);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew4 = new ConfirmBoxDataNew(EConfirmBoxConfigId.GachaCurrency);
		confirmBoxDataNew4.SetTextArgs(new string[]
		{
			num.ToString(),
			exchangeData.GetDestName(),
			exchangeSimulation.ConsumeCount.ToString(),
			exchangeData.GetSrcName()
		});
		confirmBoxDataNew4.FunctionMap.Add(2, delegate
		{
			this.ExChangeSecondCurrency(exchangeData, exchangeSimulation.ExChangeTime, exchangeSimulation.ConsumeCount);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew4);
	}

	// Token: 0x0600DBF3 RID: 56307 RVA: 0x003332FC File Offset: 0x003314FC
	private void ExChangeSecondCurrency(CommonExchangeData exchangeData, int exChangeTime, int needSecondCount)
	{
		int commonItemCount = InventoryModel.Instance.GetCommonItemCount(exchangeData.GetSrcItemId(), 0);
		if (commonItemCount >= needSecondCount)
		{
			ItemExchangeController.Instance.ItemExchangeRequest(exchangeData.GetDestItemId(), exChangeTime, false, delegate(int itemId, int itemCount)
			{
				if (InventoryModel.Instance.GetCommonItemCount(exchangeData.GetDestItemId(), 0) >= exChangeTime)
				{
					GachaController.Instance.GachaRequest(this.GachaPoolData.GachaInfo.Id, this.Times, this.GachaPoolData.PoolInfo.Id);
				}
			});
			return;
		}
		ExchangeSimulation exchangeSimulation = ItemExchangeModel.Instance.CalculateConsume(exchangeData.GetSrcItemId(), needSecondCount - commonItemCount, 0, true);
		if (exchangeSimulation == null)
		{
			return;
		}
		CommonExchangeData nextExchangeData = new CommonExchangeData();
		nextExchangeData.InitByItemId(exchangeData.GetSrcItemId());
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SecondCurrency);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			nextExchangeData.GetDestName(),
			nextExchangeData.GetSrcName(),
			nextExchangeData.GetDestName()
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			this.ExChangeFirstCurrency(nextExchangeData, exchangeSimulation.ExChangeTime, exchangeSimulation.ConsumeCount);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600DBF4 RID: 56308 RVA: 0x00333414 File Offset: 0x00331614
	private void ExChangeFirstCurrency(CommonExchangeData exchangeData, int exChangeTime, int needSecondCount)
	{
		if (InventoryModel.Instance.GetCommonItemCount(exchangeData.GetSrcItemId(), 0) >= needSecondCount)
		{
			ItemExchangeController.Instance.ItemExchangeRequest(exchangeData.GetDestItemId(), exChangeTime, true, null);
			return;
		}
		ConfirmBoxController.Instance.ShowFirstCurrencyConfirm();
	}

	// Token: 0x0600DBF5 RID: 56309 RVA: 0x00333448 File Offset: 0x00331648
	protected override UniTask OnBeforeStartAsync()
	{
		GachaButton.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaButton.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DBF6 RID: 56310 RVA: 0x0033348C File Offset: 0x0033168C
	public void Refresh(GachaPoolData data, EffectiveGachaButtonInfo buttonInfo)
	{
		this.GachaPoolData = data;
		this.ConsumeCount = buttonInfo.Consume;
		ProtoGachaInfo gachaInfo = data.GachaInfo;
		if (InventoryConfig.Instance.GetItemConfigData(gachaInfo.ItemId) == null)
		{
			return;
		}
		base.SetItemIcon(base.GetTexture(1), gachaInfo.ItemId, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Text_GachaExChangeCountDescribe_Text", new <>z__ReadOnlySingleElementList<object>(this.ConsumeCount));
		LguiUtil.Instance.SetLocalText(base.GetText(3), "GachaText", new <>z__ReadOnlySingleElementList<object>(this.Times.ToString()));
		if (buttonInfo.IsDiscount && buttonInfo.OriginConsume != null)
		{
			base.GetItem(7).SetUIActive(true);
			base.GetText(8).SetText(buttonInfo.OriginConsume.Value.ToString(), true);
		}
		else
		{
			base.GetItem(7).SetUIActive(false);
		}
		int id = data.PoolInfo.Id;
		GachaDefine.EGachaViewType? gachaViewType = GachaConfig.Instance.GetGachaViewType(id);
		if (gachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.NewPlayer)
		{
			GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig((int)gachaViewType.Value);
			base.GetItem(4).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), gachaViewTypeConfig.Value.TagText, Array.Empty<object>());
			FColor color = FColor.FromHex(gachaViewTypeConfig.Value.TagColor);
			base.GetSprite(6).SetColor(color);
		}
		else
		{
			base.GetItem(4).SetUIActive(false);
		}
		this.RefreshTag(buttonInfo);
		if (gachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.NewPlayer)
		{
			base.GetItem(9).SetUIActive(true);
		}
	}

	// Token: 0x0600DBF7 RID: 56311 RVA: 0x0033363C File Offset: 0x0033183C
	private void RefreshTag(EffectiveGachaButtonInfo buttonInfo)
	{
		UUIItem item = base.GetItem(9);
		GachaTagInfo customTag = buttonInfo.GetCustomTag();
		if (customTag != null)
		{
			item.SetUIActive(true);
			this.TagItemA.SetUiActive(false);
			this.TagItemB.SetUiActive(true);
			this.TagItemB.SetContent(customTag.Text);
			return;
		}
		this.TagItemB.SetUiActive(false);
		GachaTagInfo discountTag = buttonInfo.GetDiscountTag();
		if (discountTag == null)
		{
			this.TagItemA.SetUiActive(false);
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		this.TagItemA.SetUiActive(true);
		if (discountTag.Kind == EGachaTagKind.Free)
		{
			this.TagItemA.SetLocalText("SaleTag_1", Array.Empty<object>());
			return;
		}
		this.TagItemA.SetLocalText("SaleTag_2", new object[]
		{
			discountTag.DiscountPct.Value
		});
	}

	// Token: 0x040064EA RID: 25834
	private const long CLICKCD = 1000L;

	// Token: 0x040064EB RID: 25835
	[Nullable(2)]
	private GachaPoolData GachaPoolData;

	// Token: 0x040064EC RID: 25836
	public readonly int Times;

	// Token: 0x040064ED RID: 25837
	private int ConsumeCount;

	// Token: 0x040064EE RID: 25838
	private double LastOpenTime;

	// Token: 0x040064EF RID: 25839
	[Nullable(2)]
	private GachaDiscountTagItem TagItemA;

	// Token: 0x040064F0 RID: 25840
	[Nullable(2)]
	private GachaDiscountTagItem TagItemB;

	// Token: 0x0200823D RID: 33341
	[NullableContext(0)]
	private enum EGachaButton
	{
		// Token: 0x0402A7DE RID: 174046
		GachaBtn,
		// Token: 0x0402A7DF RID: 174047
		ConsumeTexture,
		// Token: 0x0402A7E0 RID: 174048
		ConsumeText,
		// Token: 0x0402A7E1 RID: 174049
		GachaText,
		// Token: 0x0402A7E2 RID: 174050
		DiscountItem,
		// Token: 0x0402A7E3 RID: 174051
		DiscountText,
		// Token: 0x0402A7E4 RID: 174052
		DiscountSprite,
		// Token: 0x0402A7E5 RID: 174053
		PanelNum02,
		// Token: 0x0402A7E6 RID: 174054
		TextNum02,
		// Token: 0x0402A7E7 RID: 174055
		PanelTag
	}
}
