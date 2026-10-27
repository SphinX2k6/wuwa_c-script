using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029E1 RID: 10721
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerView : UiViewBase
{
	// Token: 0x0601636F RID: 90991 RVA: 0x0059DFBC File Offset: 0x0059C1BC
	private static Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>> GetStageTypeMap()
	{
		Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>> dictionary = new Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>>();
		dictionary.Add(EShipTowerStageType.OneTimeStage, () => new ShipTowerStageItemOneTime());
		dictionary.Add(EShipTowerStageType.RefreshStage, () => new ShipTowerStageItemRefresh());
		dictionary.Add(EShipTowerStageType.EndlessStage, () => new ShipTowerStageItemEndless());
		return dictionary;
	}

	// Token: 0x17001DAE RID: 7598
	// (get) Token: 0x06016370 RID: 90992 RVA: 0x0059E040 File Offset: 0x0059C240
	[Nullable(2)]
	public new ShipTowerViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as ShipTowerViewParams;
		}
	}

	// Token: 0x06016371 RID: 90993 RVA: 0x0059E050 File Offset: 0x0059C250
	public ShipTowerView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016372 RID: 90994 RVA: 0x0059E0E8 File Offset: 0x0059C2E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUISprite)),
			new ValueTuple<int, Type>(25, typeof(UUISprite)),
			new ValueTuple<int, Type>(27, typeof(UUISprite)),
			new ValueTuple<int, Type>(28, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnBuff)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnEndlessRecord)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnLastStage)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnNextStage)),
			new ValueTuple<int, Delegate>(22, new Action(this.OnClickBtnReward))
		};
	}

	// Token: 0x06016373 RID: 90995 RVA: 0x0059E418 File Offset: 0x0059C618
	private void InitDataParam()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		if (openParam == null || !openParam.IsOpenCover.GetValueOrDefault())
		{
			ShipTowerModel.Instance.ClearChallengeStageData();
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ShipTower;
		ELogAuthor author = ELogAuthor.CX;
		string message = "";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DataParam", this.OpenParam);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06016374 RID: 90996 RVA: 0x0059E47C File Offset: 0x0059C67C
	private UniTask CheckShowWelcomeView()
	{
		ShipTowerView.<CheckShowWelcomeView>d__41 <CheckShowWelcomeView>d__;
		<CheckShowWelcomeView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowWelcomeView>d__.<>4__this = this;
		<CheckShowWelcomeView>d__.<>1__state = -1;
		<CheckShowWelcomeView>d__.<>t__builder.Start<ShipTowerView.<CheckShowWelcomeView>d__41>(ref <CheckShowWelcomeView>d__);
		return <CheckShowWelcomeView>d__.<>t__builder.Task;
	}

	// Token: 0x06016375 RID: 90997 RVA: 0x0059E4C0 File Offset: 0x0059C6C0
	protected override UniTask OnCreateAsync()
	{
		ShipTowerView.<OnCreateAsync>d__42 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<ShipTowerView.<OnCreateAsync>d__42>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016376 RID: 90998 RVA: 0x0059E504 File Offset: 0x0059C704
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<UCurveFloat> LoadCurveFloat(string resId)
	{
		ShipTowerView.<LoadCurveFloat>d__43 <LoadCurveFloat>d__;
		<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveFloat>d__.resId = resId;
		<LoadCurveFloat>d__.<>1__state = -1;
		<LoadCurveFloat>d__.<>t__builder.Start<ShipTowerView.<LoadCurveFloat>d__43>(ref <LoadCurveFloat>d__);
		return <LoadCurveFloat>d__.<>t__builder.Task;
	}

	// Token: 0x06016377 RID: 90999 RVA: 0x0059E548 File Offset: 0x0059C748
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerView.<OnBeforeStartAsync>d__44 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerView.<OnBeforeStartAsync>d__44>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016378 RID: 91000 RVA: 0x0059E58C File Offset: 0x0059C78C
	protected override void OnStart()
	{
		this.UpdateRedPoint();
		this.UiCompassRoot = base.GetItem(24);
		this.UiGear = base.GetSprite(26);
		this.UiBigGear = base.GetSprite(25);
		this.UiCompass = base.GetSprite(27);
		this.UiScrollViewStage = base.GetScrollViewWithScrollbar(21);
		this.UpdateFlipPageValue();
		this.UpdateChangeAreaValue();
		this.UpdateGearValue();
		this.UpdateCompassValue();
		this.UiScrollViewStage.ScrollToEaseType = LTweenEase.CurveFloat;
		this.UiScrollViewStage.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		this.UiScrollViewStage.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
		this.UiScrollViewStage.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerEndDrag));
		this.UiScrollViewStage.bCallTweenerCompleteCallbackWhenKill = true;
		UUIItem uuiitem = this.UiScrollViewStage.ContentUIItem.Get();
		this.ScrollContentInitPosY = ((uuiitem != null) ? uuiitem.GetAnchorOffsetY() : 0f);
		this.ScrollContentLastPosY = this.ScrollContentInitPosY;
		this.UiItemParallaxRoot = base.GetItem(20);
		this.ShowStageCfgList = ShipTowerConfig.Instance.GetAllShowStageCfg();
		this.InitParallaxItem();
		this.UpdateTopStageIndex(this.ScrollContentInitPosY);
		this.CheckInitDataParam();
		this.InitCurStageItemPos();
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x06016379 RID: 91001 RVA: 0x0059E6E2 File Offset: 0x0059C8E2
	protected override void OnBeforeHide()
	{
		ShipTowerModel.Instance.IsOpenedViewByWorld = false;
	}

	// Token: 0x0601637A RID: 91002 RVA: 0x0059E6F0 File Offset: 0x0059C8F0
	private void AddHomeBtnExtraCallback()
	{
		ShipTowerView.<>c__DisplayClass47_0 CS$<>8__locals1 = new ShipTowerView.<>c__DisplayClass47_0();
		ShipTowerView.<>c__DisplayClass47_0 CS$<>8__locals2 = CS$<>8__locals1;
		ShipTowerViewParams openParam = this.OpenParam;
		CS$<>8__locals2.isFromInstanceDungeon = ((openParam != null) ? openParam.IsFromInstanceDungeon : null);
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			ShipTowerView.<>c__DisplayClass47_0.<<AddHomeBtnExtraCallback>b__0>d <<AddHomeBtnExtraCallback>b__0>d;
			<<AddHomeBtnExtraCallback>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__0>d.<>4__this = CS$<>8__locals1;
			<<AddHomeBtnExtraCallback>b__0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__0>d.<>t__builder.Start<ShipTowerView.<>c__DisplayClass47_0.<<AddHomeBtnExtraCallback>b__0>d>(ref <<AddHomeBtnExtraCallback>b__0>d);
			return <<AddHomeBtnExtraCallback>b__0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0601637B RID: 91003 RVA: 0x0059E740 File Offset: 0x0059C940
	public void InitCurStageItemPos()
	{
		ShipTowerStageData focusingStageData = this.GetFocusingStageData();
		if (focusingStageData == null)
		{
			return;
		}
		this.ScrollToTopByIndex(0, false);
		UUIItem item = base.GetItem(7 + focusingStageData.OrderIndex - 1);
		float num = item.GetStretchTop() + item.GetHeight() / 2f;
		UUIItem uuiitem = this.UiScrollViewStage.RootUIComp.Get();
		float num2 = (uuiitem != null) ? uuiitem.GetHeight() : 0f;
		UUIItem uuiitem2 = this.UiScrollViewStage.ContentUIItem.Get();
		float val = ((uuiitem2 != null) ? uuiitem2.GetHeight() : 0f) - num2;
		float inY = Math.Max(0f, Math.Min(val, num - num2 / 2f));
		this.UiScrollViewStage.SetScrollValue(new FVector2D(0f, inY));
	}

	// Token: 0x0601637C RID: 91004 RVA: 0x0059E810 File Offset: 0x0059CA10
	[NullableContext(2)]
	private ShipTowerStageData GetFocusingStageData()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		if (openParam != null && openParam.StageId != null)
		{
			return ShipTowerModel.Instance.GetStageDataById(openParam.StageId.Value);
		}
		return ShipTowerModel.Instance.GetNextChallengeStageData(null);
	}

	// Token: 0x0601637D RID: 91005 RVA: 0x0059E85C File Offset: 0x0059CA5C
	private void InitParallaxItem()
	{
		UUIItem uiItemParallaxRoot = this.UiItemParallaxRoot;
		int num = uiItemParallaxRoot.UIChildren.Num();
		for (int i = 0; i < num; i++)
		{
			UUIItem uuiitem = uiItemParallaxRoot.UIChildren.Get(i);
			float valueByDisplayName = this.GetValueByDisplayName(uuiitem, 1, 1f);
			float initPosY = (uuiitem != null) ? uuiitem.GetAnchorOffsetY() : 0f;
			this.ItemParallaxList.Add(new ParallaxItem
			{
				Item = uuiitem,
				InitPosY = initPosY,
				ParallaxSub = valueByDisplayName
			});
		}
	}

	// Token: 0x0601637E RID: 91006 RVA: 0x0059E8E0 File Offset: 0x0059CAE0
	private float GetValueByDisplayName(UUIItem uiItem, int index = 1, float defaultValue = 1f)
	{
		string[] array = uiItem.GetDisplayName().Split('#', StringSplitOptions.None);
		if (index >= array.Length)
		{
			return defaultValue;
		}
		float num;
		if (!float.TryParse(array[index], out num))
		{
			return defaultValue;
		}
		return num / 100f;
	}

	// Token: 0x0601637F RID: 91007 RVA: 0x0059E91C File Offset: 0x0059CB1C
	private void UpdateFlipPageValue()
	{
		UUIItem uuiitem = this.UiScrollViewStage.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		this.FlipPageScrollDuration = this.GetValueByDisplayName(uuiitem, 1, 0.2f);
		this.FlipPageDistanceThreshold = this.GetValueByDisplayName(uuiitem, 2, 300f);
		this.FlipPageIntervalDistance = this.GetValueByDisplayName(uuiitem, 3, 2f);
	}

	// Token: 0x06016380 RID: 91008 RVA: 0x0059E97A File Offset: 0x0059CB7A
	private void UpdateChangeAreaValue()
	{
		this.ChangeAreaScrollDuration = this.GetValueByDisplayName(this.UiCompassRoot, 1, 1f);
	}

	// Token: 0x06016381 RID: 91009 RVA: 0x0059E994 File Offset: 0x0059CB94
	private void UpdateGearValue()
	{
		this.GearLength = this.GetValueByDisplayName(this.UiGear, 1, 300f);
		this.BigGearLength = this.GetValueByDisplayName(this.UiBigGear, 1, 600f);
	}

	// Token: 0x06016382 RID: 91010 RVA: 0x0059E9C6 File Offset: 0x0059CBC6
	private void UpdateCompassValue()
	{
		this.CompassStartAngle = this.GetValueByDisplayName(this.UiCompass, 1, -45f);
		this.CompassEndAngle = this.GetValueByDisplayName(this.UiCompass, 2, 45f);
	}

	// Token: 0x06016383 RID: 91011 RVA: 0x0059E9F8 File Offset: 0x0059CBF8
	private void CheckInitDataParam()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		int stageId = ((openParam != null) ? openParam.StageId : null) ?? ShipTowerModel.Instance.TowerStageDataList[0].Id;
		ShipTowerViewParams openParam2 = this.OpenParam;
		int? applyTeamEditStageId = (openParam2 != null) ? new int?(openParam2.ApplyTeamEditStageId) : null;
		ShipTowerViewParams openParam3 = this.OpenParam;
		bool? flag = (openParam3 != null) ? openParam3.IsOpenStageDesc : null;
		ShipTowerViewParams openParam4 = this.OpenParam;
		bool? isOpenCover = (openParam4 != null) ? openParam4.IsOpenCover : null;
		if (flag.GetValueOrDefault())
		{
			ShipTowerModel.Instance.OpenViewDesc(new ShipTowerDescViewParams
			{
				StageId = stageId,
				ApplyTeamEditStageId = applyTeamEditStageId,
				IsOpenCover = isOpenCover
			}, delegate(bool _, int _)
			{
				this.CheckNeedShowView();
			});
		}
	}

	// Token: 0x06016384 RID: 91012 RVA: 0x0059EADC File Offset: 0x0059CCDC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureResetStage, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerStageUpdate, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Add(EEventName.ShipTowerBuffNewUpdate, new Action(this.UpdateBuffNew));
		EventSystem.Instance.Add(EEventName.ShipTowerEndlessRecordUpdate, new Action(this.UpdateEndlessRecord));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.EventOpenView));
		RedDotController.Instance.BindRedDot(ERedDotName.ShipTowerReward, base.GetItem(23), null, 0);
	}

	// Token: 0x06016385 RID: 91013 RVA: 0x0059EBC0 File Offset: 0x0059CDC0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Remove<int>(EEventName.ShipTowerSureResetStage, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Remove<int>(EEventName.ShipTowerStageUpdate, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Remove<int>(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.EventShipTowerStageUpdate));
		EventSystem.Instance.Remove(EEventName.ShipTowerBuffNewUpdate, new Action(this.UpdateBuffNew));
		EventSystem.Instance.Remove(EEventName.ShipTowerEndlessRecordUpdate, new Action(this.UpdateEndlessRecord));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.EventOpenView));
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ShipTowerReward, base.GetItem(23), 0);
	}

	// Token: 0x06016386 RID: 91014 RVA: 0x0059ECA4 File Offset: 0x0059CEA4
	protected override void OnBeforeShow()
	{
		this.UpdateData();
		int num = 500;
		this.RefreshTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
		ShipTowerModel.Instance.CloseWelcomeView();
		this.UpdateRedPoint();
	}

	// Token: 0x06016387 RID: 91015 RVA: 0x0059ECF3 File Offset: 0x0059CEF3
	[NullableContext(2)]
	private bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
	{
		this.IsDragging = true;
		return true;
	}

	// Token: 0x06016388 RID: 91016 RVA: 0x0059ECFD File Offset: 0x0059CEFD
	[NullableContext(2)]
	private bool OnPointerEndDrag(ULGUIPointerEventData eventData)
	{
		this.IsDragging = false;
		return true;
	}

	// Token: 0x06016389 RID: 91017 RVA: 0x0059ED08 File Offset: 0x0059CF08
	protected override void OnAfterPlayStartSequence()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		if (openParam != null && openParam.IsOpenStageDesc.GetValueOrDefault())
		{
			return;
		}
		this.CheckNeedShowView();
	}

	// Token: 0x0601638A RID: 91018 RVA: 0x0059ED3C File Offset: 0x0059CF3C
	private UniTask CheckNeedShowView()
	{
		ShipTowerView.<CheckNeedShowView>d__63 <CheckNeedShowView>d__;
		<CheckNeedShowView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckNeedShowView>d__.<>4__this = this;
		<CheckNeedShowView>d__.<>1__state = -1;
		<CheckNeedShowView>d__.<>t__builder.Start<ShipTowerView.<CheckNeedShowView>d__63>(ref <CheckNeedShowView>d__);
		return <CheckNeedShowView>d__.<>t__builder.Task;
	}

	// Token: 0x0601638B RID: 91019 RVA: 0x0059ED80 File Offset: 0x0059CF80
	private UniTask AwaitNeedShowView()
	{
		ShipTowerView.<AwaitNeedShowView>d__64 <AwaitNeedShowView>d__;
		<AwaitNeedShowView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitNeedShowView>d__.<>1__state = -1;
		<AwaitNeedShowView>d__.<>t__builder.Start<ShipTowerView.<AwaitNeedShowView>d__64>(ref <AwaitNeedShowView>d__);
		return <AwaitNeedShowView>d__.<>t__builder.Task;
	}

	// Token: 0x0601638C RID: 91020 RVA: 0x0059EDBB File Offset: 0x0059CFBB
	private void SetShipTowerMaskLayer(bool isShow)
	{
		UiLayer.Instance.SetShowMaskLayer("ShipTower.CheckNeedShowView", isShow);
	}

	// Token: 0x0601638D RID: 91021 RVA: 0x0059EDCD File Offset: 0x0059CFCD
	private void EventOpenView(EUiViewName viewName, int _)
	{
		this.SetShipTowerMaskLayer(false);
	}

	// Token: 0x0601638E RID: 91022 RVA: 0x0059EDD6 File Offset: 0x0059CFD6
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x0601638F RID: 91023 RVA: 0x0059EDDE File Offset: 0x0059CFDE
	protected override void OnBeforeDestroy()
	{
		this.UiScrollViewStage.OnScrollValueChange.Unbind();
		this.UiScrollViewStage.OnPointerBeginDragCallBack.Unbind();
		this.UiScrollViewStage.OnPointerEndDragCallBack.Unbind();
		this.UnBindTweenerComplete();
	}

	// Token: 0x06016390 RID: 91024 RVA: 0x0059EE16 File Offset: 0x0059D016
	protected override void OnAfterDestroy()
	{
	}

	// Token: 0x06016391 RID: 91025 RVA: 0x0059EE18 File Offset: 0x0059D018
	private UniTask InitStageItem()
	{
		ShipTowerView.<InitStageItem>d__70 <InitStageItem>d__;
		<InitStageItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitStageItem>d__.<>4__this = this;
		<InitStageItem>d__.<>1__state = -1;
		<InitStageItem>d__.<>t__builder.Start<ShipTowerView.<InitStageItem>d__70>(ref <InitStageItem>d__);
		return <InitStageItem>d__.<>t__builder.Task;
	}

	// Token: 0x06016392 RID: 91026 RVA: 0x0059EE5B File Offset: 0x0059D05B
	private void OnClickBtnBuff()
	{
		ShipTowerModel.Instance.OpenViewBuff(new ShipTowerBuffViewParams
		{
			OperationType = new EShipTowerBuffOperationType?(EShipTowerBuffOperationType.Preview)
		});
	}

	// Token: 0x06016393 RID: 91027 RVA: 0x0059EE78 File Offset: 0x0059D078
	private void OnClickBtnReward()
	{
		ShipTowerModel.Instance.OpenViewReward(null);
	}

	// Token: 0x06016394 RID: 91028 RVA: 0x0059EE85 File Offset: 0x0059D085
	private void OnClickBtnEndlessRecord()
	{
		ShipTowerModel.Instance.OpenViewRecord(null);
	}

	// Token: 0x06016395 RID: 91029 RVA: 0x0059EE94 File Offset: 0x0059D094
	private void OnClickBtnLastStage()
	{
		if (this.CurContentPosIsTop())
		{
			return;
		}
		for (int i = 0; i < this.ShowStageCfgList.Count; i++)
		{
			SlashTowerShowStage slashTowerShowStage = this.ShowStageCfgList[i];
			if (slashTowerShowStage.OutIndex + 1 < this.TopStageIndex)
			{
				this.ScrollToIndexOutUp(slashTowerShowStage.OutIndex);
				return;
			}
		}
		this.ScrollToIndexOutUp(0);
	}

	// Token: 0x06016396 RID: 91030 RVA: 0x0059EEF4 File Offset: 0x0059D0F4
	private void OnClickBtnNextStage()
	{
		if (this.CurContentPosIsBottom())
		{
			return;
		}
		for (int i = 0; i < this.ShowStageCfgList.Count; i++)
		{
			SlashTowerShowStage slashTowerShowStage = this.ShowStageCfgList[i];
			if (slashTowerShowStage.OutIndex > this.TopStageIndex)
			{
				this.ScrollToIndexOutUp(slashTowerShowStage.OutIndex);
				return;
			}
		}
		this.ScrollToIndexOutUp(this.ShowStageCfgList[this.ShowStageCfgList.Count - 1].OutIndex);
	}

	// Token: 0x06016397 RID: 91031 RVA: 0x0059EF70 File Offset: 0x0059D170
	private bool CurContentPosIsTop()
	{
		return this.LastScrollValue <= 0.05f;
	}

	// Token: 0x06016398 RID: 91032 RVA: 0x0059EF82 File Offset: 0x0059D182
	private bool CurContentPosIsBottom()
	{
		return this.LastScrollValue >= 0.95f;
	}

	// Token: 0x06016399 RID: 91033 RVA: 0x0059EF94 File Offset: 0x0059D194
	private void ScrollToIndexOutUp(int index)
	{
		if (!this.IsTweenerComplete)
		{
			return;
		}
		if (ShipTowerModel.Instance.DebugParallaxSub)
		{
			this.UpdateChangeAreaValue();
		}
		this.UiScrollViewStage.ScrollToDuration = this.ChangeAreaScrollDuration;
		this.UiCureScrollTo = this.UiCureChangeArea;
		this.ScrollToTopByIndex(index, true);
	}

	// Token: 0x0601639A RID: 91034 RVA: 0x0059EFE1 File Offset: 0x0059D1E1
	public void ScrollToIndexFlipPage(int index, bool isUp = true)
	{
		this.UiScrollViewStage.ScrollToDuration = this.FlipPageScrollDuration;
		this.UiCureScrollTo = this.UiCureFlipPage;
		if (isUp)
		{
			this.ScrollToTopByIndex(index, true);
			return;
		}
		this.ScrollToBottomByIndex(index, true);
	}

	// Token: 0x0601639B RID: 91035 RVA: 0x0059F014 File Offset: 0x0059D214
	private int GetShipTowerStageItemIndex(int index)
	{
		int num = 7;
		int max = 18;
		return MathCommon.Clamp(num + index, num, max);
	}

	// Token: 0x0601639C RID: 91036 RVA: 0x0059F030 File Offset: 0x0059D230
	private void ScrollToTopByIndex(int index, bool tween = true)
	{
		int shipTowerStageItemIndex = this.GetShipTowerStageItemIndex(index);
		UUIItem item = base.GetItem(shipTowerStageItemIndex);
		UUIItem uuiitem = this.UiScrollViewStage.ContentUIItem.Get();
		FVector2D fvector2D;
		if (uuiitem == null)
		{
			fvector2D = new FVector2D();
		}
		else
		{
			FVector relativeLocation = uuiitem.RelativeLocation;
			fvector2D = new FVector2D(ref relativeLocation);
		}
		FVector2D fvector2D2 = fvector2D;
		this.UiScrollViewStage.StopMovement();
		this.UiScrollViewStage.ScrollToTop(ref fvector2D2, item, tween);
		if (this.UiScrollViewStage.Tweener != null)
		{
			this.UiScrollViewStage.Tweener.SetCurveFloat(this.UiCureScrollTo);
		}
		if (tween)
		{
			this.ScrollTweenerStart();
			this.BindTweenerComplete();
		}
	}

	// Token: 0x0601639D RID: 91037 RVA: 0x0059F0CC File Offset: 0x0059D2CC
	private void ScrollToBottomByIndex(int index, bool tween = true)
	{
		int shipTowerStageItemIndex = this.GetShipTowerStageItemIndex(index);
		UUIItem item = base.GetItem(shipTowerStageItemIndex);
		UUIItem uuiitem = this.UiScrollViewStage.ContentUIItem.Get();
		FVector2D fvector2D;
		if (uuiitem == null)
		{
			fvector2D = new FVector2D();
		}
		else
		{
			FVector relativeLocation = uuiitem.RelativeLocation;
			fvector2D = new FVector2D(ref relativeLocation);
		}
		FVector2D fvector2D2 = fvector2D;
		this.UiScrollViewStage.StopMovement();
		this.UiScrollViewStage.ScrollToBottom(ref fvector2D2, item, tween);
		if (this.UiScrollViewStage.Tweener != null)
		{
			this.UiScrollViewStage.Tweener.SetCurveFloat(this.UiCureScrollTo);
		}
		if (tween)
		{
			this.ScrollTweenerStart();
			this.BindTweenerComplete();
		}
	}

	// Token: 0x0601639E RID: 91038 RVA: 0x0059F165 File Offset: 0x0059D365
	public void ScrollTweenerStart()
	{
		this.IsTweenerComplete = false;
		this.UiScrollViewStage.SetCanScroll(false);
		this.UiScrollViewStage.SetRayCastTargetForScrollView(false);
		this.SetStageItemClickEnable(false);
	}

	// Token: 0x0601639F RID: 91039 RVA: 0x0059F190 File Offset: 0x0059D390
	private void SetStageItemClickEnable(bool enable)
	{
		for (int i = 0; i < this.StageItemList.Count; i++)
		{
			this.StageItemList[i].SetClickEnable(enable);
		}
	}

	// Token: 0x060163A0 RID: 91040 RVA: 0x0059F1C5 File Offset: 0x0059D3C5
	public void ScrollTweenerEnd()
	{
		this.IsTweenerComplete = true;
		this.UiScrollViewStage.SetCanScroll(true);
		this.UiScrollViewStage.SetRayCastTargetForScrollView(true);
		this.SetStageItemClickEnable(true);
	}

	// Token: 0x060163A1 RID: 91041 RVA: 0x0059F1F0 File Offset: 0x0059D3F0
	private void BindTweenerComplete()
	{
		if (this.IsBindTweenerComplete)
		{
			return;
		}
		if (this.UiScrollViewStage.Tweener == null)
		{
			return;
		}
		this.IsBindTweenerComplete = true;
		this.UiScrollViewStage.Tweener.OnCompleteCallBack.Bind(new Action(this.TweenerComplete));
	}

	// Token: 0x060163A2 RID: 91042 RVA: 0x0059F23C File Offset: 0x0059D43C
	private void UnBindTweenerComplete()
	{
		this.IsBindTweenerComplete = false;
		ULTweener tweener = this.UiScrollViewStage.Tweener;
		if (tweener == null)
		{
			return;
		}
		tweener.OnCompleteCallBack.Unbind();
	}

	// Token: 0x060163A3 RID: 91043 RVA: 0x0059F25F File Offset: 0x0059D45F
	private void TweenerComplete()
	{
		TimerSystem.Instance.Next(delegate(float delta)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.ScrollTweenerEnd();
		}, null, null);
	}

	// Token: 0x060163A4 RID: 91044 RVA: 0x0059F27C File Offset: 0x0059D47C
	private void OnScrollValueChange(FVector2D inVector)
	{
		float y = inVector.Y;
		if (y == this.LastScrollValue)
		{
			return;
		}
		this.LastScrollValue = y;
		UUIItem uuiitem = this.UiScrollViewStage.ContentUIItem.Get();
		float num = (uuiitem != null) ? uuiitem.GetAnchorOffsetY() : 0f;
		float addPosY = num - this.ScrollContentLastPosY;
		this.ScrollContentLastPosY = num;
		this.UpdateTopStageIndex(num);
		this.UpdateParallaxItemPos(num);
		this.UpdateGearScroll(addPosY);
		this.UpdateCompassPercent(y);
	}

	// Token: 0x060163A5 RID: 91045 RVA: 0x0059F2F4 File Offset: 0x0059D4F4
	private void UpdateParallaxItemPos(float posY)
	{
		bool debugParallaxSub = ShipTowerModel.Instance.DebugParallaxSub;
		for (int i = 0; i < this.ItemParallaxList.Count; i++)
		{
			IParallaxItem parallaxItem = this.ItemParallaxList[i];
			float num = debugParallaxSub ? this.GetValueByDisplayName(parallaxItem.Item, 1, 1f) : parallaxItem.ParallaxSub;
			float anchorOffsetY = parallaxItem.InitPosY + (posY - this.ScrollContentInitPosY) * num;
			parallaxItem.Item.SetAnchorOffsetY(anchorOffsetY);
		}
	}

	// Token: 0x060163A6 RID: 91046 RVA: 0x0059F370 File Offset: 0x0059D570
	public void UpdateGearScroll(float addPosY)
	{
		if (ShipTowerModel.Instance.DebugParallaxSub)
		{
			this.UpdateGearValue();
		}
		float num = 360f;
		float num2 = addPosY / this.GearLength * num;
		float num3 = addPosY / this.BigGearLength * num;
		this.RotationGear.Yaw = this.RotationGear.Yaw + num2;
		this.RotationBigGear.Yaw = this.RotationBigGear.Yaw - num3;
		this.UiGear.SetUIRelativeRotation(this.RotationGear);
		this.UiBigGear.SetUIRelativeRotation(this.RotationBigGear);
	}

	// Token: 0x060163A7 RID: 91047 RVA: 0x0059F400 File Offset: 0x0059D600
	public void UpdateCompassPercent(float percent)
	{
		if (ShipTowerModel.Instance.DebugParallaxSub)
		{
			this.UpdateCompassValue();
		}
		float num = this.CompassEndAngle - this.CompassStartAngle;
		float yaw = percent * num + this.CompassStartAngle;
		this.RotationCompass.Yaw = yaw;
		this.UiCompass.SetUIRelativeRotation(this.RotationCompass);
	}

	// Token: 0x060163A8 RID: 91048 RVA: 0x0059F458 File Offset: 0x0059D658
	private void UpdateTopStageIndex(float posY)
	{
		int num = this.TopStageIndex;
		for (int i = 7; i <= 18; i++)
		{
			UUIItem item = base.GetItem(i);
			float height = item.GetHeight();
			float num2 = item.GetStretchTop() + height;
			num = i - 7 + 1;
			if (posY <= num2)
			{
				break;
			}
		}
		if (this.TopStageIndex == num)
		{
			return;
		}
		this.TopStageIndex = num;
		for (int j = 0; j < this.ShowStageCfgList.Count; j++)
		{
			SlashTowerShowStage slashTowerShowStage = this.ShowStageCfgList[j];
			if (slashTowerShowStage.OutIndex >= this.TopStageIndex)
			{
				base.GetText(19).ShowTextNew(slashTowerShowStage.Name);
				return;
			}
		}
	}

	// Token: 0x060163A9 RID: 91049 RVA: 0x0059F4F8 File Offset: 0x0059D6F8
	public void CheckFlipPage(float addPosY)
	{
		float scrollContentLastPosY = this.ScrollContentLastPosY;
		if (!this.IsTweenerComplete)
		{
			return;
		}
		if (this.LastScrollValue <= 0f || this.LastScrollValue >= 1f)
		{
			return;
		}
		if (this.IsDragging)
		{
			return;
		}
		if (ShipTowerModel.Instance.DebugParallaxSub)
		{
			this.UpdateFlipPageValue();
		}
		if (Math.Abs(addPosY) > this.FlipPageIntervalDistance)
		{
			return;
		}
		UUIItem uuiitem = this.UiScrollViewStage.RootUIComp.Get();
		float num = (uuiitem != null) ? uuiitem.GetHeight() : 0f;
		for (int i = 0; i < this.ShowStageCfgList.Count; i++)
		{
			SlashTowerShowStage? slashTowerShowStage = (i > 0) ? new SlashTowerShowStage?(this.ShowStageCfgList[i - 1]) : null;
			SlashTowerShowStage slashTowerShowStage2 = this.ShowStageCfgList[i];
			if (slashTowerShowStage != null && slashTowerShowStage.Value.OutIndex + 1 == slashTowerShowStage2.OutIndex)
			{
				this.FlipPageNearStage(slashTowerShowStage.Value.OutIndex - 1, slashTowerShowStage.Value.OutIndex, num, addPosY > 0f);
				return;
			}
			if (this.IsFlipPageUp(slashTowerShowStage2.OutIndex, scrollContentLastPosY))
			{
				return;
			}
			float downContentPosY = scrollContentLastPosY + num;
			if (this.IsFlipPageDown(slashTowerShowStage2.OutIndex - 1, downContentPosY))
			{
				return;
			}
		}
	}

	// Token: 0x060163AA RID: 91050 RVA: 0x0059F658 File Offset: 0x0059D858
	private void FlipPageNearStage(int lastIndex, int nextIndex, float scrollHeight, bool isToDown)
	{
		float scrollContentLastPosY = this.ScrollContentLastPosY;
		float num = scrollContentLastPosY + scrollHeight;
		float stageItemPosY = this.GetStageItemPosY(lastIndex, false);
		float stageItemPosY2 = this.GetStageItemPosY(nextIndex, true);
		if (num < stageItemPosY + this.FlipPageDistanceThreshold * 0.5f)
		{
			return;
		}
		if (num < stageItemPosY2)
		{
			this.ScrollToIndexFlipPage(isToDown ? nextIndex : lastIndex, isToDown);
			return;
		}
		UUIItem uuiitem = this.UiScrollViewStage.ContentUIItem.Get();
		float num2 = (uuiitem != null) ? uuiitem.GetHeight() : 0f;
		if (stageItemPosY2 + scrollHeight >= num2)
		{
			if (num2 - scrollHeight - scrollContentLastPosY < this.FlipPageDistanceThreshold * 0.5f)
			{
				this.ScrollToIndexFlipPage(nextIndex, true);
				return;
			}
			this.ScrollToIndexFlipPage(isToDown ? nextIndex : lastIndex, isToDown);
			return;
		}
		else
		{
			if (scrollContentLastPosY > stageItemPosY2 + this.FlipPageDistanceThreshold * 0.5f)
			{
				return;
			}
			this.ScrollToIndexFlipPage(nextIndex, true);
			return;
		}
	}

	// Token: 0x060163AB RID: 91051 RVA: 0x0059F724 File Offset: 0x0059D924
	private bool IsFlipPageUp(int index, float contentPosY)
	{
		float stageItemPosY = this.GetStageItemPosY(index, true);
		float flipPageDistanceThreshold = this.FlipPageDistanceThreshold;
		float num = contentPosY - stageItemPosY;
		if (num <= -flipPageDistanceThreshold || num >= flipPageDistanceThreshold)
		{
			return false;
		}
		if (num > -flipPageDistanceThreshold * 0.5f)
		{
			this.ScrollToIndexFlipPage(index, true);
			return true;
		}
		this.ScrollToIndexFlipPage(index - 1, false);
		return true;
	}

	// Token: 0x060163AC RID: 91052 RVA: 0x0059F770 File Offset: 0x0059D970
	private bool IsFlipPageDown(int index, float downContentPosY)
	{
		float stageItemPosY = this.GetStageItemPosY(index, false);
		float num = downContentPosY - stageItemPosY;
		if (num <= -this.FlipPageDistanceThreshold || num >= this.FlipPageDistanceThreshold)
		{
			return false;
		}
		if (num < this.FlipPageDistanceThreshold * 0.5f)
		{
			this.ScrollToIndexFlipPage(index, false);
			return true;
		}
		this.ScrollToIndexFlipPage(index + 1, true);
		return true;
	}

	// Token: 0x060163AD RID: 91053 RVA: 0x0059F7C4 File Offset: 0x0059D9C4
	public float GetStageItemPosY(int index, bool isTop = true)
	{
		int shipTowerStageItemIndex = this.GetShipTowerStageItemIndex(index);
		UUIItem item = base.GetItem(shipTowerStageItemIndex);
		float stretchTop = item.GetStretchTop();
		if (!isTop)
		{
			return stretchTop + item.GetHeight();
		}
		return stretchTop;
	}

	// Token: 0x060163AE RID: 91054 RVA: 0x0059F7F5 File Offset: 0x0059D9F5
	private void UpdateData()
	{
		this.UpdateEndlessRecord();
		this.UpdateRewardProgress();
		this.UpdateBuffNew();
	}

	// Token: 0x060163AF RID: 91055 RVA: 0x0059F80C File Offset: 0x0059DA0C
	private void UpdateBuffNew()
	{
		bool uiactive = ShipTowerModel.Instance.IsExistFirstGetBuff();
		UUIItem item = base.GetItem(28);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x060163B0 RID: 91056 RVA: 0x0059F838 File Offset: 0x0059DA38
	private void UpdateEndlessRecord()
	{
		bool uiactive = ShipTowerModel.Instance.IsEndlessRecordOpen();
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(uiactive);
	}

	// Token: 0x060163B1 RID: 91057 RVA: 0x0059F874 File Offset: 0x0059DA74
	private void UpdateRewardProgress()
	{
		string rewardProgressText = ShipTowerModel.Instance.GetRewardProgressText(true);
		string newText = ShipTowerModel.Instance.GetCurrentStageSeasonName() + "(" + rewardProgressText + ")";
		base.GetText(3).SetText(newText, true);
		this.UpdateRemainTime();
	}

	// Token: 0x060163B2 RID: 91058 RVA: 0x0059F8BC File Offset: 0x0059DABC
	private void UpdateRemainTime()
	{
		string rewardCountDownDesc = ShipTowerModel.Instance.GetRewardCountDownDesc();
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(rewardCountDownDesc, true);
	}

	// Token: 0x060163B3 RID: 91059 RVA: 0x0059F8E7 File Offset: 0x0059DAE7
	private void OnTimerRefresh(float delta)
	{
		this.UpdateRemainTime();
		if (ShipTowerModel.Instance.TimeIsOver())
		{
			this.ClearTimer();
			ShipTowerModel.Instance.CheckIsNeedShowConfirmSeasonUpdate(null);
		}
	}

	// Token: 0x060163B4 RID: 91060 RVA: 0x0059F90D File Offset: 0x0059DB0D
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x060163B5 RID: 91061 RVA: 0x0059F930 File Offset: 0x0059DB30
	private void CloseCallBack()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		if (openParam != null && openParam.IsFromInstanceDungeon.GetValueOrDefault())
		{
			ShipTowerModel.Instance.OpenConfirmBackWorld();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060163B6 RID: 91062 RVA: 0x0059F96B File Offset: 0x0059DB6B
	private void EventRewardReceive(int _)
	{
		this.UpdateRewardProgress();
	}

	// Token: 0x060163B7 RID: 91063 RVA: 0x0059F974 File Offset: 0x0059DB74
	private void EventShipTowerStageUpdate(int id)
	{
		ShipTowerStageItemBase shipTowerStageItemBase;
		if (this.StageItemMap.TryGetValue(id, out shipTowerStageItemBase))
		{
			shipTowerStageItemBase.UpdateData();
		}
	}

	// Token: 0x060163B8 RID: 91064 RVA: 0x0059F997 File Offset: 0x0059DB97
	private void OnHelpClick()
	{
		HelpController.Instance.OpenHelpById(201);
	}

	// Token: 0x060163B9 RID: 91065 RVA: 0x0059F9A8 File Offset: 0x0059DBA8
	private void UpdateRedPoint()
	{
		ServerStorageNumber serverStorageNumber = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ShipTowerSeason) as ServerStorageNumber;
		if (serverStorageNumber != null)
		{
			serverStorageNumber.Set(new int?(ShipTowerModel.Instance.CurSeason));
		}
		ActivityShipTowerController instance = ActivityShipTowerController.Instance;
		int? num;
		if (instance == null)
		{
			num = null;
		}
		else
		{
			ActivityShipTowerData data = instance.Data;
			num = ((data != null) ? new int?(data.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		if (valueOrDefault > 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, valueOrDefault);
		}
		EventSystem.Instance.Emit(EEventName.RedDotAdventurePeriodicityTabUpdate);
		ActivityShipTowerController instance2 = ActivityShipTowerController.Instance;
		bool? flag;
		if (instance2 == null)
		{
			flag = null;
		}
		else
		{
			ActivityShipTowerData data2 = instance2.Data;
			flag = ((data2 != null) ? new bool?(data2.RedPointShowState) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault2 = flag2.GetValueOrDefault();
		AdventureGuideModel.Instance.ReportPeriodicActivityRedClear(EDungeonSubType.ShipTower, valueOrDefault2);
	}

	// Token: 0x0400A554 RID: 42324
	private const string MASK_LAYER_TAG = "ShipTower.CheckNeedShowView";

	// Token: 0x0400A555 RID: 42325
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A556 RID: 42326
	public UUIScrollViewWithScrollbarComponent UiScrollViewStage;

	// Token: 0x0400A557 RID: 42327
	private UUIItem UiItemParallaxRoot;

	// Token: 0x0400A558 RID: 42328
	private readonly List<IParallaxItem> ItemParallaxList = new List<IParallaxItem>();

	// Token: 0x0400A559 RID: 42329
	private float LastScrollValue = 0.001f;

	// Token: 0x0400A55A RID: 42330
	private float ScrollContentInitPosY;

	// Token: 0x0400A55B RID: 42331
	private float ScrollContentLastPosY;

	// Token: 0x0400A55C RID: 42332
	private IReadOnlyList<SlashTowerShowStage> ShowStageCfgList;

	// Token: 0x0400A55D RID: 42333
	private int TopStageIndex;

	// Token: 0x0400A55E RID: 42334
	private readonly Dictionary<int, ShipTowerStageItemBase> StageItemMap = new Dictionary<int, ShipTowerStageItemBase>();

	// Token: 0x0400A55F RID: 42335
	private readonly List<ShipTowerStageItemBase> StageItemList = new List<ShipTowerStageItemBase>();

	// Token: 0x0400A560 RID: 42336
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x0400A561 RID: 42337
	[Nullable(2)]
	public UCurveFloat UiCureChangeArea;

	// Token: 0x0400A562 RID: 42338
	public float ChangeAreaScrollDuration;

	// Token: 0x0400A563 RID: 42339
	[Nullable(2)]
	public UCurveFloat UiCureFlipPage;

	// Token: 0x0400A564 RID: 42340
	[Nullable(2)]
	public UCurveFloat UiCureScrollTo;

	// Token: 0x0400A565 RID: 42341
	public float FlipPageDistanceThreshold;

	// Token: 0x0400A566 RID: 42342
	public float FlipPageScrollDuration;

	// Token: 0x0400A567 RID: 42343
	public float FlipPageIntervalDistance;

	// Token: 0x0400A568 RID: 42344
	private UUIItem UiCompassRoot;

	// Token: 0x0400A569 RID: 42345
	private UUISprite UiGear;

	// Token: 0x0400A56A RID: 42346
	private UUISprite UiBigGear;

	// Token: 0x0400A56B RID: 42347
	private UUISprite UiCompass;

	// Token: 0x0400A56C RID: 42348
	private float GearLength;

	// Token: 0x0400A56D RID: 42349
	private float BigGearLength;

	// Token: 0x0400A56E RID: 42350
	private float CompassStartAngle;

	// Token: 0x0400A56F RID: 42351
	private float CompassEndAngle;

	// Token: 0x0400A570 RID: 42352
	private FRotator RotationCompass = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A571 RID: 42353
	private FRotator RotationGear = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A572 RID: 42354
	private FRotator RotationBigGear = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A573 RID: 42355
	private bool IsBindTweenerComplete;

	// Token: 0x0400A574 RID: 42356
	private bool IsTweenerComplete = true;

	// Token: 0x0400A575 RID: 42357
	private bool IsDragging;

	// Token: 0x0200900D RID: 36877
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA42 RID: 191042
		public const int ItemCaption = 0;

		// Token: 0x0402EA43 RID: 191043
		public const int BtnBuff = 1;

		// Token: 0x0402EA44 RID: 191044
		public const int BtnEndlessRecord = 2;

		// Token: 0x0402EA45 RID: 191045
		public const int TxtRewardProgress = 3;

		// Token: 0x0402EA46 RID: 191046
		public const int TxtCountDownTime = 4;

		// Token: 0x0402EA47 RID: 191047
		public const int BtnLastStage = 5;

		// Token: 0x0402EA48 RID: 191048
		public const int BtnNextStage = 6;

		// Token: 0x0402EA49 RID: 191049
		public const int ItemOneTimeStage1 = 7;

		// Token: 0x0402EA4A RID: 191050
		public const int ItemOneTimeStage2 = 8;

		// Token: 0x0402EA4B RID: 191051
		public const int ItemOneTimeStage3 = 9;

		// Token: 0x0402EA4C RID: 191052
		public const int ItemOneTimeStage4 = 10;

		// Token: 0x0402EA4D RID: 191053
		public const int ItemOneTimeStage5 = 11;

		// Token: 0x0402EA4E RID: 191054
		public const int ItemOneTimeStage6 = 12;

		// Token: 0x0402EA4F RID: 191055
		public const int ItemRefreshStage1 = 13;

		// Token: 0x0402EA50 RID: 191056
		public const int ItemRefreshStage2 = 14;

		// Token: 0x0402EA51 RID: 191057
		public const int ItemRefreshStage3 = 15;

		// Token: 0x0402EA52 RID: 191058
		public const int ItemRefreshStage4 = 16;

		// Token: 0x0402EA53 RID: 191059
		public const int ItemRefreshStage5 = 17;

		// Token: 0x0402EA54 RID: 191060
		public const int ItemEndlessStage = 18;

		// Token: 0x0402EA55 RID: 191061
		public const int TxtCurrentArea = 19;

		// Token: 0x0402EA56 RID: 191062
		public const int ItemParallaxRoot = 20;

		// Token: 0x0402EA57 RID: 191063
		public const int ScrollViewStage = 21;

		// Token: 0x0402EA58 RID: 191064
		public const int BtnReward = 22;

		// Token: 0x0402EA59 RID: 191065
		public const int ItemRewardRedDot = 23;

		// Token: 0x0402EA5A RID: 191066
		public const int ItemCompassRoot = 24;

		// Token: 0x0402EA5B RID: 191067
		public const int SpriteBigGear = 25;

		// Token: 0x0402EA5C RID: 191068
		public const int SpriteGear = 26;

		// Token: 0x0402EA5D RID: 191069
		public const int SpriteCompass = 27;

		// Token: 0x0402EA5E RID: 191070
		public const int ItemBuffNew = 28;
	}
}
