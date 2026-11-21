using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F1B RID: 3867
public class DangoAbyssShopView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06009AAF RID: 39599 RVA: 0x002DE283 File Offset: 0x002DC483
	[NullableContext(1)]
	public DangoAbyssShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009AB0 RID: 39600 RVA: 0x002DE28C File Offset: 0x002DC48C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBack)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickDango))
		};
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x002DE34D File Offset: 0x002DC54D
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x06009AB2 RID: 39602 RVA: 0x002DE35C File Offset: 0x002DC55C
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009AB3 RID: 39603 RVA: 0x002DE365 File Offset: 0x002DC565
	protected override void OnHandleLoadScene()
	{
		DangoAbyssController.Instance.InitAbyssDangoObserver(99);
	}

	// Token: 0x06009AB4 RID: 39604 RVA: 0x002DE373 File Offset: 0x002DC573
	protected override void OnHandleReleaseScene()
	{
		DangoAbyssController.Instance.DestroyAbyssDangoObserver(99);
	}

	// Token: 0x06009AB5 RID: 39605 RVA: 0x002DE381 File Offset: 0x002DC581
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
	}

	// Token: 0x06009AB6 RID: 39606 RVA: 0x002DE3B8 File Offset: 0x002DC5B8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x002DE3F0 File Offset: 0x002DC5F0
	private void OnCloseViewFinish(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.CommonRewardView)
		{
			this.CancelTimerHandle();
			this.ChangeDangoAni(DangoAbyssConfig.Instance.GetBadDangoBuyAni(), false);
			this.CurrentDelayBackHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ChangeDangoAni(DangoAbyssConfig.Instance.GetBadDangoStandAni(), true);
			}, (float)DangoAbyssConfig.Instance.GetDangoShopBuyTime(), null, null, true, 1f);
		}
	}

	// Token: 0x06009AB8 RID: 39608 RVA: 0x002DE450 File Offset: 0x002DC650
	private void RefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		this.ClickCount = 0;
	}

	// Token: 0x06009AB9 RID: 39609 RVA: 0x002DE45C File Offset: 0x002DC65C
	private void OnClickDango()
	{
		long num = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		if (num - this.LastTimeClickTime < 1800L)
		{
			return;
		}
		this.LastTimeClickTime = num;
		this.ClickCount++;
		if (this.ClickCount > 3)
		{
			if (!this.IfPlayAni)
			{
				this.IfPlayAni = true;
				this.ChangeDangoAni(DangoAbyssConfig.Instance.GetBadDangoBadDangoPinkOverAni(), true);
				this.CancelTimerHandle();
				return;
			}
		}
		else
		{
			this.ChangeDangoAni(DangoAbyssConfig.Instance.GetBadDangoBadDangoPinkAni(), false);
			this.CancelTimerHandle();
			this.CurrentDelayBackHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ChangeDangoAni(DangoAbyssConfig.Instance.GetBadDangoStandAni(), true);
			}, (float)DangoAbyssConfig.Instance.GetDangoShopClickTime(), null, null, true, 1f);
		}
	}

	// Token: 0x06009ABA RID: 39610 RVA: 0x002DE513 File Offset: 0x002DC713
	[NullableContext(1)]
	private void ChangeDangoAni(string path, bool ifLoop)
	{
		DangoAbyssController.Instance.RefreshAbyssDangoAnimation(99, path, ifLoop);
	}

	// Token: 0x06009ABB RID: 39611 RVA: 0x002DE523 File Offset: 0x002DC723
	private void CancelTimerHandle()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.CurrentDelayBackHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CurrentDelayBackHandle);
			this.CurrentDelayBackHandle = null;
		}
	}

	// Token: 0x06009ABC RID: 39612 RVA: 0x002DE550 File Offset: 0x002DC750
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssShopView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssShopView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009ABD RID: 39613 RVA: 0x002DE593 File Offset: 0x002DC793
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)"DangoAbyssShop", viewId, operationType);
	}

	// Token: 0x06009ABE RID: 39614 RVA: 0x002DE5AB File Offset: 0x002DC7AB
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)"DangoAbyssShop", nextViewName, closeViewId, operationType);
	}

	// Token: 0x06009ABF RID: 39615 RVA: 0x002DE5C8 File Offset: 0x002DC7C8
	protected override void OnBeforeShow()
	{
		DangoAbyssController.Instance.RefreshAbyssDangoModel(99, 999, "MonsterCase2", null);
		this.PushCameraHandleByOpenView((EUiViewName)"DangoAbyssShop", base.GetViewId(), EUiCameraHandleOperationType.Blend);
		int openShopId = DangoAbyssModel.Instance.GetOpenShopId();
		this.ActivityShopScrollItem.Refresh(openShopId).Forget();
	}

	// Token: 0x06009AC0 RID: 39616 RVA: 0x002DE61F File Offset: 0x002DC81F
	protected override void OnBeforeHide()
	{
		this.CancelTimerHandle();
	}

	// Token: 0x04005C54 RID: 23636
	[Nullable(1)]
	private const string DANGOSHOP = "DangoAbyssShop";

	// Token: 0x04005C55 RID: 23637
	private const int MODELINDEX = 99;

	// Token: 0x04005C56 RID: 23638
	private const int CHANGECD = 1800;

	// Token: 0x04005C57 RID: 23639
	[Nullable(2)]
	private CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x04005C58 RID: 23640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityShopScrollItem<ActivityShopGridItem> ActivityShopScrollItem;

	// Token: 0x04005C59 RID: 23641
	private int ClickCount;

	// Token: 0x04005C5A RID: 23642
	private bool IfPlayAni;

	// Token: 0x04005C5B RID: 23643
	private long LastTimeClickTime;

	// Token: 0x04005C5C RID: 23644
	[Nullable(2)]
	private TimerHandle CurrentDelayBackHandle;

	// Token: 0x02007136 RID: 28982
	private enum EComponent
	{
		// Token: 0x04024E20 RID: 151072
		BackBtn,
		// Token: 0x04024E21 RID: 151073
		CostLayer,
		// Token: 0x04024E22 RID: 151074
		ItemScroller,
		// Token: 0x04024E23 RID: 151075
		Item,
		// Token: 0x04024E24 RID: 151076
		HalfButton
	}
}
