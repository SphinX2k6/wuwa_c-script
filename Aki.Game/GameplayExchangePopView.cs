using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002341 RID: 9025
[NullableContext(2)]
[Nullable(0)]
public class GameplayExchangePopView : UiViewBase
{
	// Token: 0x06011E51 RID: 73297 RVA: 0x00467153 File Offset: 0x00465353
	[NullableContext(1)]
	public GameplayExchangePopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E52 RID: 73298 RVA: 0x0046715C File Offset: 0x0046535C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnCancelClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011E53 RID: 73299 RVA: 0x00467420 File Offset: 0x00465620
	protected override UniTask OnBeforeStartAsync()
	{
		GameplayExchangePopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GameplayExchangePopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E54 RID: 73300 RVA: 0x00467464 File Offset: 0x00465664
	protected override void OnStart()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.NumberSelect = this.CreateNumberSelectComponent(base.GetItem(9));
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = this.ViewProxy.MaxBuyCount,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
		this.RefreshNumberSelectComponentButtonState();
		base.GetItem(13).SetUIActive(true);
	}

	// Token: 0x06011E55 RID: 73301 RVA: 0x004674E9 File Offset: 0x004656E9
	[NullableContext(1)]
	protected virtual NumberSelectComponent CreateNumberSelectComponent(UUIItem item)
	{
		return new NumberSelectComponent(item);
	}

	// Token: 0x06011E56 RID: 73302 RVA: 0x004674F1 File Offset: 0x004656F1
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06011E57 RID: 73303 RVA: 0x004674F9 File Offset: 0x004656F9
	protected override void OnBeforeDestroy()
	{
		this.NumberSelect.Destroy(null);
		this.ShopItem.Destroy(null);
		this.RemoveResellTimer();
	}

	// Token: 0x06011E58 RID: 73304 RVA: 0x00467519 File Offset: 0x00465719
	public void RefreshView()
	{
		this.RefreshShopItem();
		this.RefreshDescribeText();
		this.RefreshConfirmButtonState();
		this.RefreshPriceInfo();
		this.RefreshCurrency();
		this.RefreshLockText();
		this.RefreshNumberSelectComponentButtonState();
		this.RefreshTipTitleItem();
	}

	// Token: 0x06011E59 RID: 73305 RVA: 0x0046754B File Offset: 0x0046574B
	public void RefreshShopItem()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.ShopItemRefresh();
	}

	// Token: 0x06011E5A RID: 73306 RVA: 0x00467561 File Offset: 0x00465761
	public void RefreshDescribeText()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		GameplayShopUtil.SetText(base.GetText(5), this.ViewProxy.DescribeTextData);
	}

	// Token: 0x06011E5B RID: 73307 RVA: 0x00467584 File Offset: 0x00465784
	public void RefreshConfirmButtonState()
	{
		bool selfInteractive = this.ViewProxy.CheckConfirmButtonCanInteract();
		base.GetButton(7).SetSelfInteractive(selfInteractive);
	}

	// Token: 0x06011E5C RID: 73308 RVA: 0x004675AC File Offset: 0x004657AC
	public void RefreshPriceInfo()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		base.SetItemIcon(base.GetTexture(3), this.ViewProxy.CurrencyId, null, null);
		UUIText text = base.GetText(4);
		int num = this.ViewProxy.BuyCount * this.ViewProxy.Price;
		bool flag = this.ViewProxy.CheckMoneyEnough();
		text.SetText(num.ToString(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x06011E5D RID: 73309 RVA: 0x00467638 File Offset: 0x00465838
	public void RefreshLimitText()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		UUIText text = base.GetText(16);
		bool limitTextItemVisible = this.ViewProxy.LimitTextItemVisible;
		text.SetUIActive(limitTextItemVisible);
		if (limitTextItemVisible)
		{
			GameplayShopUtil.SetText(text, this.ViewProxy.LimitTextData);
			text.SetColor(FColor.FromHex("FED12E"));
		}
	}

	// Token: 0x06011E5E RID: 73310 RVA: 0x00467690 File Offset: 0x00465890
	public void RefreshCurrency()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		UiAsyncTask task = new UiAsyncTask("RefreshCurrency", delegate()
		{
			GameplayExchangePopView.<<RefreshCurrency>b__20_0>d <<RefreshCurrency>b__20_0>d;
			<<RefreshCurrency>b__20_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshCurrency>b__20_0>d.<>4__this = this;
			<<RefreshCurrency>b__20_0>d.<>1__state = -1;
			<<RefreshCurrency>b__20_0>d.<>t__builder.Start<GameplayExchangePopView.<<RefreshCurrency>b__20_0>d>(ref <<RefreshCurrency>b__20_0>d);
			return <<RefreshCurrency>b__20_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06011E5F RID: 73311 RVA: 0x004676C8 File Offset: 0x004658C8
	private UniTask RefreshCurrencyAsync()
	{
		GameplayExchangePopView.<RefreshCurrencyAsync>d__21 <RefreshCurrencyAsync>d__;
		<RefreshCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrencyAsync>d__.<>4__this = this;
		<RefreshCurrencyAsync>d__.<>1__state = -1;
		<RefreshCurrencyAsync>d__.<>t__builder.Start<GameplayExchangePopView.<RefreshCurrencyAsync>d__21>(ref <RefreshCurrencyAsync>d__);
		return <RefreshCurrencyAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E60 RID: 73312 RVA: 0x0046770C File Offset: 0x0046590C
	public void RefreshLockText()
	{
		this.RemoveResellTimer();
		if (this.ViewProxy == null)
		{
			return;
		}
		bool lockItemVisible = this.ViewProxy.LockItemVisible;
		base.GetItem(11).SetUIActive(lockItemVisible);
		if (lockItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(12), this.ViewProxy.LockTextData);
		}
		if (this.ViewProxy.ReSellTime > 0)
		{
			this.ResellTimerId = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.RefreshReSellText), (float)(this.ViewProxy.ReSellTime * 1000), null, null, true, 1f);
		}
	}

	// Token: 0x06011E61 RID: 73313 RVA: 0x004677A1 File Offset: 0x004659A1
	public void RefreshReSellText(float _)
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.OnResellTimeRefresh();
		this.RefreshLockText();
	}

	// Token: 0x06011E62 RID: 73314 RVA: 0x004677BD File Offset: 0x004659BD
	public void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x06011E63 RID: 73315 RVA: 0x004677E0 File Offset: 0x004659E0
	public void RefreshLeftTimeText()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		base.GetItem(15).SetUIActive(this.ViewProxy.LeftTimeItemVisible);
		if (this.ViewProxy.LeftTimeItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(14), this.ViewProxy.LeftTimeDescTextData);
			bool leftTimeTextVisible = this.ViewProxy.LeftTimeTextVisible;
			UUIText text = base.GetText(16);
			text.SetUIActive(leftTimeTextVisible);
			if (leftTimeTextVisible)
			{
				GameplayShopUtil.SetText(text, this.ViewProxy.LeftTimeTextData);
			}
		}
	}

	// Token: 0x06011E64 RID: 73316 RVA: 0x00467863 File Offset: 0x00465A63
	public void RefreshTipTitleItem()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		base.GetItem(8).SetUIActive(this.ViewProxy.TipTitleItemVisible);
		if (this.ViewProxy.TipTitleItemVisible)
		{
			this.RefreshLimitText();
			this.RefreshLeftTimeText();
		}
	}

	// Token: 0x06011E65 RID: 73317 RVA: 0x0046789E File Offset: 0x00465A9E
	public void RefreshNumberSelectComponentButtonState()
	{
		if (this.NumberSelect.GetIfLimit())
		{
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetAddReduceButtonInteractive(false);
		}
	}

	// Token: 0x06011E66 RID: 73318 RVA: 0x004678C5 File Offset: 0x00465AC5
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011E67 RID: 73319 RVA: 0x004678D0 File Offset: 0x00465AD0
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		IGameplayShopExchangePopViewProxy viewProxy = this.ViewProxy;
		string text = (viewProxy != null) ? viewProxy.ExchangeTableTextId : null;
		return new TableTextArgNew((!string.IsNullOrEmpty(text) && !StringUtils.IsEmpty(text)) ? text : "Text_BugCount_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06011E68 RID: 73320 RVA: 0x0046791E File Offset: 0x00465B1E
	private void ValueChangeFunction(int selectValue)
	{
		this.ViewProxy.BuyCount = selectValue;
		this.RefreshPriceInfo();
	}

	// Token: 0x06011E69 RID: 73321 RVA: 0x00467932 File Offset: 0x00465B32
	private void OnCancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011E6A RID: 73322 RVA: 0x0046793B File Offset: 0x00465B3B
	private void OnConfirmClick()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.OnConfirmButtonClick(base.GetViewId());
	}

	// Token: 0x04008789 RID: 34697
	[Nullable(1)]
	private const string COLOR = "FED12E";

	// Token: 0x0400878A RID: 34698
	protected IGameplayShopExchangePopViewProxy ViewProxy;

	// Token: 0x0400878B RID: 34699
	protected TimerHandle ResellTimerId;

	// Token: 0x0400878C RID: 34700
	protected UiPanelBase ShopItem;

	// Token: 0x0400878D RID: 34701
	protected NumberSelectComponent NumberSelect;

	// Token: 0x0400878E RID: 34702
	private CommonCurrencyItemListComponent CustomCurrencyItemList;

	// Token: 0x020088C1 RID: 35009
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402C718 RID: 182040
		EndTimeIcon,
		// Token: 0x0402C719 RID: 182041
		EndTimeText,
		// Token: 0x0402C71A RID: 182042
		ItemAttach,
		// Token: 0x0402C71B RID: 182043
		CurrencyIcon,
		// Token: 0x0402C71C RID: 182044
		CurrencyCount,
		// Token: 0x0402C71D RID: 182045
		DescribeText,
		// Token: 0x0402C71E RID: 182046
		CancelButton,
		// Token: 0x0402C71F RID: 182047
		ConfirmButton,
		// Token: 0x0402C720 RID: 182048
		TipTitleItem,
		// Token: 0x0402C721 RID: 182049
		NumberSelect,
		// Token: 0x0402C722 RID: 182050
		LimitText,
		// Token: 0x0402C723 RID: 182051
		LockItem,
		// Token: 0x0402C724 RID: 182052
		LockText,
		// Token: 0x0402C725 RID: 182053
		ItemPanel,
		// Token: 0x0402C726 RID: 182054
		LeftTimeDescText,
		// Token: 0x0402C727 RID: 182055
		LeftTimeItem,
		// Token: 0x0402C728 RID: 182056
		LeftTimeText
	}
}
