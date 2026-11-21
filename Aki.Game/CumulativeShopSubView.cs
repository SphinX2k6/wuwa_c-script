using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006B7 RID: 1719
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopSubView : ActivitySubViewBase
{
	// Token: 0x06004F01 RID: 20225 RVA: 0x001A9220 File Offset: 0x001A7420
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

	// Token: 0x06004F02 RID: 20226 RVA: 0x001A9315 File Offset: 0x001A7515
	protected override void OnSetData()
	{
		this.CumulativeShopData = (this.ActivityBaseData as CumulativeShopData);
	}

	// Token: 0x06004F03 RID: 20227 RVA: 0x001A9328 File Offset: 0x001A7528
	protected override UniTask OnBeforeStartAsync()
	{
		CumulativeShopSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CumulativeShopSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004F04 RID: 20228 RVA: 0x001A936C File Offset: 0x001A756C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06004F05 RID: 20229 RVA: 0x001A93D0 File Offset: 0x001A75D0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06004F06 RID: 20230 RVA: 0x001A9434 File Offset: 0x001A7634
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

	// Token: 0x06004F07 RID: 20231 RVA: 0x001A9508 File Offset: 0x001A7708
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

	// Token: 0x06004F08 RID: 20232 RVA: 0x001A959F File Offset: 0x001A779F
	protected override void OnAfterShow()
	{
		this.AddTimer();
	}

	// Token: 0x06004F09 RID: 20233 RVA: 0x001A95A7 File Offset: 0x001A77A7
	private void OnClickTaskBtn()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.CumulativeShopTaskView, null, null);
		});
	}

	// Token: 0x06004F0A RID: 20234 RVA: 0x001A95D8 File Offset: 0x001A77D8
	private PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x06004F0B RID: 20235 RVA: 0x001A95E0 File Offset: 0x001A77E0
	protected void RefreshLoopScroll()
	{
		CumulativeShopData cumulativeShopData = this.CumulativeShopData;
		int payShopId = (cumulativeShopData != null) ? cumulativeShopData.ShopId : 0;
		this.PayShopGoodsList = new List<IPayShopUnionData>(PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)payShopId, 1, true));
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		this.LoopScrollView.GetUiAnimController().Play("", -1, false);
	}

	// Token: 0x06004F0C RID: 20236 RVA: 0x001A9653 File Offset: 0x001A7853
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x06004F0D RID: 20237 RVA: 0x001A9661 File Offset: 0x001A7861
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (shopId == PayShopDefine.EPayShopTabType.CumulativeShop)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x06004F0E RID: 20238 RVA: 0x001A9676 File Offset: 0x001A7876
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll();
	}

	// Token: 0x06004F0F RID: 20239 RVA: 0x001A967E File Offset: 0x001A787E
	private void OnShopVersionCodeChange()
	{
		ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
	}

	// Token: 0x06004F10 RID: 20240 RVA: 0x001A968A File Offset: 0x001A788A
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
		{
			this.OnRefreshTimer();
			this.RefreshBottomShow();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06004F11 RID: 20241 RVA: 0x001A96B5 File Offset: 0x001A78B5
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06004F12 RID: 20242 RVA: 0x001A96D7 File Offset: 0x001A78D7
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x06004F13 RID: 20243 RVA: 0x001A96E0 File Offset: 0x001A78E0
	private void OnRefreshTimer()
	{
		this.TitleComponent.SetTimeTextVisible(true);
		string timeTextByText = ActivityModel.Instance.GetRemainTimeText(this.CumulativeShopData.EndShowTime, this.TitleRemainTimeText) ?? "";
		this.TitleComponent.SetTimeTextByText(timeTextByText);
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x06004F14 RID: 20244 RVA: 0x001A973C File Offset: 0x001A793C
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

	// Token: 0x06004F15 RID: 20245 RVA: 0x001A97B4 File Offset: 0x001A79B4
	private void RefreshRedDot()
	{
		bool anyTaskRedDot = this.CumulativeShopData.GetAnyTaskRedDot();
		this.BottomComponent.SetFunctionRedDotVisible(anyTaskRedDot);
	}

	// Token: 0x04003911 RID: 14609
	private const int TIMEGAP = 1000;

	// Token: 0x04003912 RID: 14610
	[Nullable(2)]
	private CumulativeShopData CumulativeShopData;

	// Token: 0x04003913 RID: 14611
	[Nullable(2)]
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003914 RID: 14612
	[Nullable(2)]
	private ActivityFunctionalTypeA BottomComponent;

	// Token: 0x04003915 RID: 14613
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PayShopItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x04003916 RID: 14614
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x04003917 RID: 14615
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04003918 RID: 14616
	private string RemainTimeText = "";

	// Token: 0x04003919 RID: 14617
	private string TitleRemainTimeText = "";
}
