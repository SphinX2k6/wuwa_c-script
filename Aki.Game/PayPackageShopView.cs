using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200236B RID: 9067
[NullableContext(1)]
[Nullable(0)]
public class PayPackageShopView : DiscountShopView
{
	// Token: 0x06012187 RID: 74119 RVA: 0x00471BC9 File Offset: 0x0046FDC9
	protected override void AddEventListener()
	{
		base.AddEventListener();
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06012188 RID: 74120 RVA: 0x00471BED File Offset: 0x0046FDED
	protected override void RemoveEventListener()
	{
		base.RemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06012189 RID: 74121 RVA: 0x00471C11 File Offset: 0x0046FE11
	protected override UUIItem GetScrollItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x0601218A RID: 74122 RVA: 0x00471C1A File Offset: 0x0046FE1A
	protected override GridProxyAbstract<IPayShopUnionData> InitItem()
	{
		return new PayShopBigItem();
	}

	// Token: 0x0601218B RID: 74123 RVA: 0x00471C21 File Offset: 0x0046FE21
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		base.TryRefreshTabs();
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0601218C RID: 74124 RVA: 0x00471C38 File Offset: 0x0046FE38
	private void OnRefreshPayGiftList()
	{
		if (!this.OnShowRequestInfo)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RefreshChargeView);
			Action value = delegate()
			{
				this.RefreshLoopScroll(this.CurrentSelectTabId);
			};
			confirmBoxDataNew.FunctionMap.Add(1, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
		else
		{
			this.RefreshLoopScroll(this.CurrentSelectTabId);
		}
		this.OnShowRequestInfo = false;
	}

	// Token: 0x0601218D RID: 74125 RVA: 0x00471C94 File Offset: 0x0046FE94
	protected override void RefreshLoopScroll(int tabId)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		this.PayShopGoodsList = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.GiftBag, tabId, true).Cast<IPayShopUnionData>().ToList<IPayShopUnionData>();
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(base.GetProxyData), this.PayShopGoodsList.Count, false, false);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(this.PayShopGoodsList.Count > 0);
		base.GetItem(8).SetUIActive(this.PayShopGoodsList.Count <= 0);
		base.CheckIfNeedShowPlayStationStoreIcon();
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayPackageShopView Reload", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601218E RID: 74126 RVA: 0x00471D54 File Offset: 0x0046FF54
	protected unsafe override void UpdateTabs(int selectIndex, bool bScrollTo = false)
	{
		List<int> tabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 页签数据";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", base.GetViewName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", tabIdList);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		int count = tabIdList.Count;
		this.CurTabNum = count;
		this.TabGroup.ResetLastSelectTab();
		Action callBack = delegate()
		{
			foreach (KeyValuePair<int, PayShopSwitchItem> keyValuePair in this.TabGroup.GetTabItemMap())
			{
				int key = keyValuePair.Key;
				PayShopSwitchItem value = keyValuePair.Value;
				value.UpdateView((PayShopDefine.EPayShopTabType)this.CurrentShopId, tabIdList[key]);
				value.BindRedDot(ERedDotName.PayShopTab, tabIdList[key]);
			}
			this.TabGroup.SelectToggleByIndex(selectIndex, true, true);
			if (bScrollTo)
			{
				this.LateScrollToTab(selectIndex);
			}
		};
		this.TabGroup.RefreshTabItemByLength(count, callBack);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Shop;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "PayShop:TabView 选择页签";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601218F RID: 74127 RVA: 0x00471E54 File Offset: 0x00470054
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PayPackageShopView.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PayPackageShopView.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06012190 RID: 74128 RVA: 0x00471E97 File Offset: 0x00470097
	protected override void OnBeforeShow()
	{
		base.GetItem(4).SetUIActive(true);
		this.TabGroup.SetActive(true);
	}

	// Token: 0x040088EB RID: 35051
	private bool OnShowRequestInfo;
}
