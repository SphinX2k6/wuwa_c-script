using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001203 RID: 4611
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopSubView : ActivitySubViewBase
{
	// Token: 0x06007B6B RID: 31595 RVA: 0x001A0568 File Offset: 0x0019E768
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
	}

	// Token: 0x06007B6C RID: 31596 RVA: 0x001A065D File Offset: 0x0019E85D
	protected override void OnSetData()
	{
		this.CumulativeShopData = (this.ActivityBaseData as CumulativeShopData);
	}

	// Token: 0x06007B6D RID: 31597 RVA: 0x001A0670 File Offset: 0x0019E870
	protected override UniTask OnBeforeStartAsync()
	{
		CumulativeShopSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CumulativeShopSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B6E RID: 31598 RVA: 0x001A06B4 File Offset: 0x0019E8B4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06007B6F RID: 31599 RVA: 0x001A0718 File Offset: 0x0019E918
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x001A077C File Offset: 0x0019E97C
	protected override void OnStart()
	{
		this.RemainTimeText = (TextConfig.Instance.GetMultiTextByKey("LeiXiao_GetScore_prompt") ?? "");
		this.TitleRemainTimeText = (TextConfig.Instance.GetMultiTextByKey("ActivityRemainingTime") ?? "");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "keyActivity_105100001_Desc", Array.Empty<object>());
		this.TitleComponent.SetActivityBaseData(this.CumulativeShopData);
		this.TitleComponent.SetTitleByText(this.CumulativeShopData.GetTitle());
		this.TitleComponent.SetTimeTextVisible(true);
		string timeTextByText = ActivityModel.Instance.GetRemainTimeText(this.CumulativeShopData.EndShowTime, this.TitleRemainTimeText) ?? "";
		this.TitleComponent.SetTimeTextByText(timeTextByText);
		this.RefreshLoopScroll();
		this.RefreshBottomShow();
	}

	// Token: 0x06007B71 RID: 31601 RVA: 0x001A0850 File Offset: 0x0019EA50
	protected override void OnRefreshView()
	{
		CumulativeShopData cumulativeShopData = this.CumulativeShopData;
		int num = (cumulativeShopData != null) ? cumulativeShopData.CurrencyId : 0;
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new List<int>
		{
			num
		});
		this.RefreshRedDot();
		UUITexture texture = base.GetTexture(6);
		if (num > 0)
		{
			base.SetItemIcon(texture, num, null, null);
		}
		CumulativeShopData cumulativeShopData2 = this.CumulativeShopData;
		int num2 = (cumulativeShopData2 != null) ? cumulativeShopData2.TotalScore : 0;
		UUIText text = base.GetText(7);
		LguiUtil.Instance.SetLocalTextNew(text, "LeiXiao_AllScore", new <>z__ReadOnlySingleElementList<object>(num2));
	}

	// Token: 0x06007B72 RID: 31602 RVA: 0x001A08E7 File Offset: 0x0019EAE7
	protected override void OnAfterShow()
	{
		this.AddTimer();
	}

	// Token: 0x06007B73 RID: 31603 RVA: 0x001A08EF File Offset: 0x0019EAEF
	private void OnClickTaskBtn()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.CumulativeShopTaskView, null, null);
		});
	}

	// Token: 0x06007B74 RID: 31604 RVA: 0x001A0920 File Offset: 0x0019EB20
	private PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x06007B75 RID: 31605 RVA: 0x001A0928 File Offset: 0x0019EB28
	protected void RefreshLoopScroll()
	{
		CumulativeShopData cumulativeShopData = this.CumulativeShopData;
		int payShopId = (cumulativeShopData != null) ? cumulativeShopData.ShopId : 0;
		this.PayShopGoodsList = new List<IPayShopUnionData>(PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)payShopId, 1, true));
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		this.LoopScrollView.GetUiAnimController().Play("", -1, false);
	}

	// Token: 0x06007B76 RID: 31606 RVA: 0x001A099B File Offset: 0x0019EB9B
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x06007B77 RID: 31607 RVA: 0x001A09A9 File Offset: 0x0019EBA9
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (shopId == PayShopDefine.EPayShopTabType.CumulativeShop)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x06007B78 RID: 31608 RVA: 0x001A09BE File Offset: 0x0019EBBE
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll();
	}

	// Token: 0x06007B79 RID: 31609 RVA: 0x001A09C6 File Offset: 0x0019EBC6
	private void OnShopVersionCodeChange()
	{
		ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
	}

	// Token: 0x06007B7A RID: 31610 RVA: 0x001A09D2 File Offset: 0x0019EBD2
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
		{
			this.OnRefreshTimer();
			this.RefreshBottomShow();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06007B7B RID: 31611 RVA: 0x001A09FD File Offset: 0x0019EBFD
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06007B7C RID: 31612 RVA: 0x001A0A1F File Offset: 0x0019EC1F
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x06007B7D RID: 31613 RVA: 0x001A0A28 File Offset: 0x0019EC28
	private void OnRefreshTimer()
	{
		this.TitleComponent.SetTimeTextVisible(true);
		string timeTextByText = ActivityModel.Instance.GetRemainTimeText(this.CumulativeShopData.EndShowTime, this.TitleRemainTimeText) ?? "";
		this.TitleComponent.SetTimeTextByText(timeTextByText);
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x06007B7E RID: 31614 RVA: 0x001A0A84 File Offset: 0x0019EC84
	private void RefreshBottomShow()
	{
		long endOpenTime = this.CumulativeShopData.EndOpenTime;
		if ((double)endOpenTime <= TimeUtil.Instance.GetServerTime())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "CumulativeShopOpenTimeEnd", Array.Empty<object>());
			this.BottomComponent.FunctionButton.SetEnableClick(false);
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(endOpenTime, this.RemainTimeText);
		base.GetText(9).SetText(remainTimeText, true);
	}

	// Token: 0x06007B7F RID: 31615 RVA: 0x001A0AFC File Offset: 0x0019ECFC
	private void RefreshRedDot()
	{
		bool anyTaskRedDot = this.CumulativeShopData.GetAnyTaskRedDot();
		this.BottomComponent.SetFunctionRedDotVisible(anyTaskRedDot);
	}

	// Token: 0x04003878 RID: 14456
	private const int TIMEGAP = 1000;

	// Token: 0x04003879 RID: 14457
	[Nullable(2)]
	private CumulativeShopData CumulativeShopData;

	// Token: 0x0400387A RID: 14458
	[Nullable(2)]
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400387B RID: 14459
	[Nullable(2)]
	private ActivityFunctionalTypeA BottomComponent;

	// Token: 0x0400387C RID: 14460
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PayShopItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x0400387D RID: 14461
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x0400387E RID: 14462
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400387F RID: 14463
	private string RemainTimeText = "";

	// Token: 0x04003880 RID: 14464
	private string TitleRemainTimeText = "";
}
