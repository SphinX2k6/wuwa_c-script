using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200236E RID: 9070
[NullableContext(1)]
[Nullable(0)]
public class PayShopNewPlayerView : DiscountShopView
{
	// Token: 0x060121A3 RID: 74147 RVA: 0x004721F3 File Offset: 0x004703F3
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
	}

	// Token: 0x060121A4 RID: 74148 RVA: 0x00472216 File Offset: 0x00470416
	protected override void AddEventListener()
	{
		base.AddEventListener();
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060121A5 RID: 74149 RVA: 0x0047223A File Offset: 0x0047043A
	protected override void RemoveEventListener()
	{
		base.RemoveEventListener();
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060121A6 RID: 74150 RVA: 0x0047225E File Offset: 0x0047045E
	protected override UUIItem GetScrollItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060121A7 RID: 74151 RVA: 0x00472267 File Offset: 0x00470467
	protected override GridProxyAbstract<IPayShopUnionData> InitItem()
	{
		return new PayShopBigItem();
	}

	// Token: 0x060121A8 RID: 74152 RVA: 0x0047226E File Offset: 0x0047046E
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		base.TryRefreshTabs();
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x060121A9 RID: 74153 RVA: 0x00472284 File Offset: 0x00470484
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

	// Token: 0x060121AA RID: 74154 RVA: 0x004722E0 File Offset: 0x004704E0
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

	// Token: 0x060121AB RID: 74155 RVA: 0x00472340 File Offset: 0x00470540
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

	// Token: 0x060121AC RID: 74156 RVA: 0x0047242C File Offset: 0x0047062C
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PayShopNewPlayerView.<OnBeforeShowAsyncImplement>d__11 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PayShopNewPlayerView.<OnBeforeShowAsyncImplement>d__11>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060121AD RID: 74157 RVA: 0x0047246F File Offset: 0x0047066F
	protected override void OnBeforeShow()
	{
		base.GetItem(4).SetUIActive(true);
		this.TabGroup.SetActive(true);
	}

	// Token: 0x060121AE RID: 74158 RVA: 0x0047248A File Offset: 0x0047068A
	protected override void OnBeforeDestroy()
	{
		if (this.SubViewComponent != null)
		{
			this.SubViewComponent.DestroyTabViewComponent();
			this.SubViewComponent = null;
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x040088F3 RID: 35059
	private bool OnShowRequestInfo;

	// Token: 0x040088F4 RID: 35060
	[Nullable(2)]
	private TabViewComponent<int> SubViewComponent;
}
