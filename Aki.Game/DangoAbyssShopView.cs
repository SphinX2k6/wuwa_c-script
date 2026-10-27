using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A5C RID: 6748
public class DangoAbyssShopView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x0600C69F RID: 50847 RVA: 0x002D317F File Offset: 0x002D137F
	[NullableContext(1)]
	public DangoAbyssShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C6A0 RID: 50848 RVA: 0x002D3188 File Offset: 0x002D1388
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

	// Token: 0x0600C6A1 RID: 50849 RVA: 0x002D3249 File Offset: 0x002D1449
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C6A2 RID: 50850 RVA: 0x002D3258 File Offset: 0x002D1458
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C6A3 RID: 50851 RVA: 0x002D3261 File Offset: 0x002D1461
	protected override void OnHandleLoadScene()
	{
		DangoAbyssController.Instance.InitAbyssDangoObserver(99);
	}

	// Token: 0x0600C6A4 RID: 50852 RVA: 0x002D326F File Offset: 0x002D146F
	protected override void OnHandleReleaseScene()
	{
		DangoAbyssController.Instance.DestroyAbyssDangoObserver(99);
	}

	// Token: 0x0600C6A5 RID: 50853 RVA: 0x002D327D File Offset: 0x002D147D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
	}

	// Token: 0x0600C6A6 RID: 50854 RVA: 0x002D32B4 File Offset: 0x002D14B4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
	}

	// Token: 0x0600C6A7 RID: 50855 RVA: 0x002D32EC File Offset: 0x002D14EC
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

	// Token: 0x0600C6A8 RID: 50856 RVA: 0x002D334C File Offset: 0x002D154C
	private void RefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		this.ClickCount = 0;
	}

	// Token: 0x0600C6A9 RID: 50857 RVA: 0x002D3358 File Offset: 0x002D1558
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

	// Token: 0x0600C6AA RID: 50858 RVA: 0x002D340F File Offset: 0x002D160F
	[NullableContext(1)]
	private void ChangeDangoAni(string path, bool ifLoop)
	{
		DangoAbyssController.Instance.RefreshAbyssDangoAnimation(99, path, ifLoop);
	}

	// Token: 0x0600C6AB RID: 50859 RVA: 0x002D341F File Offset: 0x002D161F
	private void CancelTimerHandle()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.CurrentDelayBackHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CurrentDelayBackHandle);
			this.CurrentDelayBackHandle = null;
		}
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x002D344C File Offset: 0x002D164C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssShopView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssShopView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x002D348F File Offset: 0x002D168F
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)"DangoAbyssShop", new int?(base.GetViewId()), true);
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x002D34B1 File Offset: 0x002D16B1
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)"DangoAbyssShop", stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x0600C6AF RID: 50863 RVA: 0x002D34CC File Offset: 0x002D16CC
	protected override void OnBeforeShow()
	{
		DangoAbyssController.Instance.RefreshAbyssDangoModel(99, 999, "MonsterCase2", null);
		this.PushCameraHandle((EUiViewName)"DangoAbyssShop", base.GetViewId(), true);
		int openShopId = DangoAbyssModel.Instance.GetOpenShopId();
		this.ActivityShopScrollItem.Refresh(openShopId).Forget();
	}

	// Token: 0x0600C6B0 RID: 50864 RVA: 0x002D3523 File Offset: 0x002D1723
	protected override void OnBeforeHide()
	{
		this.CancelTimerHandle();
	}

	// Token: 0x04005B85 RID: 23429
	[Nullable(1)]
	private const string DANGOSHOP = "DangoAbyssShop";

	// Token: 0x04005B86 RID: 23430
	private const int MODELINDEX = 99;

	// Token: 0x04005B87 RID: 23431
	private const int CHANGECD = 1800;

	// Token: 0x04005B88 RID: 23432
	[Nullable(2)]
	private CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x04005B89 RID: 23433
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityShopScrollItem<ActivityShopGridItem> ActivityShopScrollItem;

	// Token: 0x04005B8A RID: 23434
	private int ClickCount;

	// Token: 0x04005B8B RID: 23435
	private bool IfPlayAni;

	// Token: 0x04005B8C RID: 23436
	private long LastTimeClickTime;

	// Token: 0x04005B8D RID: 23437
	[Nullable(2)]
	private TimerHandle CurrentDelayBackHandle;

	// Token: 0x02007FA7 RID: 32679
	private enum EComponent
	{
		// Token: 0x04029AE3 RID: 170723
		BackBtn,
		// Token: 0x04029AE4 RID: 170724
		CostLayer,
		// Token: 0x04029AE5 RID: 170725
		ItemScroller,
		// Token: 0x04029AE6 RID: 170726
		Item,
		// Token: 0x04029AE7 RID: 170727
		HalfButton
	}
}
