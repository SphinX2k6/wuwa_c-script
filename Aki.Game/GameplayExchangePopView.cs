using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001826 RID: 6182
[NullableContext(2)]
[Nullable(0)]
public class GameplayExchangePopView : UiViewBase
{
	// Token: 0x0600F301 RID: 62209 RVA: 0x0047421B File Offset: 0x0047241B
	[NullableContext(1)]
	public GameplayExchangePopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F302 RID: 62210 RVA: 0x00474224 File Offset: 0x00472424
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

	// Token: 0x0600F303 RID: 62211 RVA: 0x004744E8 File Offset: 0x004726E8
	protected override UniTask OnBeforeStartAsync()
	{
		GameplayExchangePopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GameplayExchangePopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F304 RID: 62212 RVA: 0x0047452C File Offset: 0x0047272C
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

	// Token: 0x0600F305 RID: 62213 RVA: 0x004745B1 File Offset: 0x004727B1
	[NullableContext(1)]
	protected virtual NumberSelectComponent CreateNumberSelectComponent(UUIItem item)
	{
		return new NumberSelectComponent(item);
	}

	// Token: 0x0600F306 RID: 62214 RVA: 0x004745B9 File Offset: 0x004727B9
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600F307 RID: 62215 RVA: 0x004745C1 File Offset: 0x004727C1
	protected override void OnBeforeDestroy()
	{
		this.NumberSelect.Destroy(null);
		this.ShopItem.Destroy(null);
		this.RemoveResellTimer();
	}

	// Token: 0x0600F308 RID: 62216 RVA: 0x004745E1 File Offset: 0x004727E1
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

	// Token: 0x0600F309 RID: 62217 RVA: 0x00474613 File Offset: 0x00472813
	public void RefreshShopItem()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.ShopItemRefresh();
	}

	// Token: 0x0600F30A RID: 62218 RVA: 0x00474629 File Offset: 0x00472829
	public void RefreshDescribeText()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		GameplayShopUtil.SetText(base.GetText(5), this.ViewProxy.DescribeTextData);
	}

	// Token: 0x0600F30B RID: 62219 RVA: 0x0047464C File Offset: 0x0047284C
	public void RefreshConfirmButtonState()
	{
		bool selfInteractive = this.ViewProxy.CheckConfirmButtonCanInteract();
		base.GetButton(7).SetSelfInteractive(selfInteractive);
	}

	// Token: 0x0600F30C RID: 62220 RVA: 0x00474674 File Offset: 0x00472874
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

	// Token: 0x0600F30D RID: 62221 RVA: 0x00474700 File Offset: 0x00472900
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

	// Token: 0x0600F30E RID: 62222 RVA: 0x00474758 File Offset: 0x00472958
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

	// Token: 0x0600F30F RID: 62223 RVA: 0x00474790 File Offset: 0x00472990
	private UniTask RefreshCurrencyAsync()
	{
		GameplayExchangePopView.<RefreshCurrencyAsync>d__21 <RefreshCurrencyAsync>d__;
		<RefreshCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrencyAsync>d__.<>4__this = this;
		<RefreshCurrencyAsync>d__.<>1__state = -1;
		<RefreshCurrencyAsync>d__.<>t__builder.Start<GameplayExchangePopView.<RefreshCurrencyAsync>d__21>(ref <RefreshCurrencyAsync>d__);
		return <RefreshCurrencyAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F310 RID: 62224 RVA: 0x004747D4 File Offset: 0x004729D4
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

	// Token: 0x0600F311 RID: 62225 RVA: 0x00474869 File Offset: 0x00472A69
	public void RefreshReSellText(float _)
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.OnResellTimeRefresh();
		this.RefreshLockText();
	}

	// Token: 0x0600F312 RID: 62226 RVA: 0x00474885 File Offset: 0x00472A85
	public void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x0600F313 RID: 62227 RVA: 0x004748A8 File Offset: 0x00472AA8
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

	// Token: 0x0600F314 RID: 62228 RVA: 0x0047492B File Offset: 0x00472B2B
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

	// Token: 0x0600F315 RID: 62229 RVA: 0x00474966 File Offset: 0x00472B66
	public void RefreshNumberSelectComponentButtonState()
	{
		if (this.NumberSelect.GetIfLimit())
		{
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetAddReduceButtonInteractive(false);
		}
	}

	// Token: 0x0600F316 RID: 62230 RVA: 0x0047498D File Offset: 0x00472B8D
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F317 RID: 62231 RVA: 0x00474998 File Offset: 0x00472B98
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		IGameplayShopExchangePopViewProxy viewProxy = this.ViewProxy;
		string text = (viewProxy != null) ? viewProxy.ExchangeTableTextId : null;
		return new TableTextArgNew((!string.IsNullOrEmpty(text) && !StringUtils.IsEmpty(text)) ? text : "Text_BugCount_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600F318 RID: 62232 RVA: 0x004749E6 File Offset: 0x00472BE6
	private void ValueChangeFunction(int selectValue)
	{
		this.ViewProxy.BuyCount = selectValue;
		this.RefreshPriceInfo();
	}

	// Token: 0x0600F319 RID: 62233 RVA: 0x004749FA File Offset: 0x00472BFA
	private void OnCancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F31A RID: 62234 RVA: 0x00474A03 File Offset: 0x00472C03
	private void OnConfirmClick()
	{
		if (this.ViewProxy == null)
		{
			return;
		}
		this.ViewProxy.OnConfirmButtonClick(base.GetViewId());
	}

	// Token: 0x040088CC RID: 35020
	[Nullable(1)]
	private const string COLOR = "FED12E";

	// Token: 0x040088CD RID: 35021
	protected IGameplayShopExchangePopViewProxy ViewProxy;

	// Token: 0x040088CE RID: 35022
	protected TimerHandle ResellTimerId;

	// Token: 0x040088CF RID: 35023
	protected UiPanelBase ShopItem;

	// Token: 0x040088D0 RID: 35024
	protected NumberSelectComponent NumberSelect;

	// Token: 0x040088D1 RID: 35025
	private CommonCurrencyItemListComponent CustomCurrencyItemList;

	// Token: 0x02007A4A RID: 31306
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027A2C RID: 162348
		EndTimeIcon,
		// Token: 0x04027A2D RID: 162349
		EndTimeText,
		// Token: 0x04027A2E RID: 162350
		ItemAttach,
		// Token: 0x04027A2F RID: 162351
		CurrencyIcon,
		// Token: 0x04027A30 RID: 162352
		CurrencyCount,
		// Token: 0x04027A31 RID: 162353
		DescribeText,
		// Token: 0x04027A32 RID: 162354
		CancelButton,
		// Token: 0x04027A33 RID: 162355
		ConfirmButton,
		// Token: 0x04027A34 RID: 162356
		TipTitleItem,
		// Token: 0x04027A35 RID: 162357
		NumberSelect,
		// Token: 0x04027A36 RID: 162358
		LimitText,
		// Token: 0x04027A37 RID: 162359
		LockItem,
		// Token: 0x04027A38 RID: 162360
		LockText,
		// Token: 0x04027A39 RID: 162361
		ItemPanel,
		// Token: 0x04027A3A RID: 162362
		LeftTimeDescText,
		// Token: 0x04027A3B RID: 162363
		LeftTimeItem,
		// Token: 0x04027A3C RID: 162364
		LeftTimeText
	}
}
