using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001853 RID: 6227
[NullableContext(1)]
[Nullable(0)]
public class PayShopNewPlayerView : DiscountShopView
{
	// Token: 0x0600F653 RID: 63059 RVA: 0x0047F373 File Offset: 0x0047D573
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
	}

	// Token: 0x0600F654 RID: 63060 RVA: 0x0047F396 File Offset: 0x0047D596
	protected override void AddEventListener()
	{
		base.AddEventListener();
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F655 RID: 63061 RVA: 0x0047F3BA File Offset: 0x0047D5BA
	protected override void RemoveEventListener()
	{
		base.RemoveEventListener();
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F656 RID: 63062 RVA: 0x0047F3DE File Offset: 0x0047D5DE
	protected override UUIItem GetScrollItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x0600F657 RID: 63063 RVA: 0x0047F3E7 File Offset: 0x0047D5E7
	protected override GridProxyAbstract<IPayShopUnionData> InitItem()
	{
		return new PayShopBigItem();
	}

	// Token: 0x0600F658 RID: 63064 RVA: 0x0047F3EE File Offset: 0x0047D5EE
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		base.TryRefreshTabs();
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F659 RID: 63065 RVA: 0x0047F404 File Offset: 0x0047D604
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

	// Token: 0x0600F65A RID: 63066 RVA: 0x0047F460 File Offset: 0x0047D660
	protected override void OnStart()
	{
		base.OnStart();
		this.SubViewComponent = new TabViewComponent<int>(base.GetItem(7), EKeyMode.Default);
		base.GetItem(7).SetUIActive(false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:NewPlayer 界面Start";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F65B RID: 63067 RVA: 0x0047F4C0 File Offset: 0x0047D6C0
	protected override void RefreshLoopScroll(int tabId)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		if (tabId == 1)
		{
			base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(7).SetUIActive(true);
			int selectedIndex = this.TabGroup.GetSelectedIndex();
			TabViewComponent<int> subViewComponent = this.SubViewComponent;
			if (subViewComponent != null)
			{
				subViewComponent.ToggleCallBack(selectedIndex, EUiTabViewName.NewPlayerWeekCardView, this.TabGroup.GetTabItemByIndex(selectedIndex), null, null);
			}
			Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShopNewPlayerView Reload(WeekCardView)", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		base.GetItem(7).SetUIActive(false);
		TabViewComponent<int> subViewComponent2 = this.SubViewComponent;
		if (subViewComponent2 != null)
		{
			subViewComponent2.SetCurrentTabViewState(false);
		}
		base.RefreshLoopScroll(tabId);
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShopNewPlayerView Reload", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600F65C RID: 63068 RVA: 0x0047F5AC File Offset: 0x0047D7AC
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PayShopNewPlayerView.<OnBeforeShowAsyncImplement>d__11 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PayShopNewPlayerView.<OnBeforeShowAsyncImplement>d__11>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600F65D RID: 63069 RVA: 0x0047F5EF File Offset: 0x0047D7EF
	protected override void OnBeforeShow()
	{
		base.GetItem(4).SetUIActive(true);
		this.TabGroup.SetActive(true);
	}

	// Token: 0x0600F65E RID: 63070 RVA: 0x0047F60A File Offset: 0x0047D80A
	protected override void OnBeforeDestroy()
	{
		if (this.SubViewComponent != null)
		{
			this.SubViewComponent.DestroyTabViewComponent();
			this.SubViewComponent = null;
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x04008A38 RID: 35384
	private bool OnShowRequestInfo;

	// Token: 0x04008A39 RID: 35385
	[Nullable(2)]
	private TabViewComponent<int> SubViewComponent;
}
