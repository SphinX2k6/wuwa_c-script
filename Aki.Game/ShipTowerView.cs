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

// Token: 0x02001F5C RID: 8028
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerView : UiViewBase
{
	// Token: 0x06013D75 RID: 81269 RVA: 0x005C8F74 File Offset: 0x005C7174
	private static Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>> GetStageTypeMap()
	{
		Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>> dictionary = new Dictionary<EShipTowerStageType, Func<ShipTowerStageItemBase>>();
		dictionary.Add(EShipTowerStageType.OneTimeStage, () => new ShipTowerStageItemOneTime());
		dictionary.Add(EShipTowerStageType.RefreshStage, () => new ShipTowerStageItemRefresh());
		dictionary.Add(EShipTowerStageType.EndlessStage, () => new ShipTowerStageItemEndless());
		return dictionary;
	}

	// Token: 0x17001E07 RID: 7687
	// (get) Token: 0x06013D76 RID: 81270 RVA: 0x005C8FF8 File Offset: 0x005C71F8
	[Nullable(2)]
	public new ShipTowerViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as ShipTowerViewParams;
		}
	}

	// Token: 0x06013D77 RID: 81271 RVA: 0x005C9008 File Offset: 0x005C7208
	public ShipTowerView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013D78 RID: 81272 RVA: 0x005C90A0 File Offset: 0x005C72A0
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

	// Token: 0x06013D79 RID: 81273 RVA: 0x005C93D0 File Offset: 0x005C75D0
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

	// Token: 0x06013D7A RID: 81274 RVA: 0x005C9434 File Offset: 0x005C7634
	private UniTask CheckShowWelcomeView()
	{
		ShipTowerView.<CheckShowWelcomeView>d__41 <CheckShowWelcomeView>d__;
		<CheckShowWelcomeView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowWelcomeView>d__.<>4__this = this;
		<CheckShowWelcomeView>d__.<>1__state = -1;
		<CheckShowWelcomeView>d__.<>t__builder.Start<ShipTowerView.<CheckShowWelcomeView>d__41>(ref <CheckShowWelcomeView>d__);
		return <CheckShowWelcomeView>d__.<>t__builder.Task;
	}

	// Token: 0x06013D7B RID: 81275 RVA: 0x005C9478 File Offset: 0x005C7678
	protected override UniTask OnCreateAsync()
	{
		ShipTowerView.<OnCreateAsync>d__42 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<ShipTowerView.<OnCreateAsync>d__42>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D7C RID: 81276 RVA: 0x005C94BC File Offset: 0x005C76BC
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

	// Token: 0x06013D7D RID: 81277 RVA: 0x005C9500 File Offset: 0x005C7700
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerView.<OnBeforeStartAsync>d__44 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerView.<OnBeforeStartAsync>d__44>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D7E RID: 81278 RVA: 0x005C9544 File Offset: 0x005C7744
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

	// Token: 0x06013D7F RID: 81279 RVA: 0x005C969A File Offset: 0x005C789A
	protected override void OnBeforeHide()
	{
		ShipTowerModel.Instance.IsOpenedViewByWorld = false;
	}

	// Token: 0x06013D80 RID: 81280 RVA: 0x005C96A8 File Offset: 0x005C78A8
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

	// Token: 0x06013D81 RID: 81281 RVA: 0x005C96F8 File Offset: 0x005C78F8
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

	// Token: 0x06013D82 RID: 81282 RVA: 0x005C97C8 File Offset: 0x005C79C8
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

	// Token: 0x06013D83 RID: 81283 RVA: 0x005C9814 File Offset: 0x005C7A14
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

	// Token: 0x06013D84 RID: 81284 RVA: 0x005C9898 File Offset: 0x005C7A98
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

	// Token: 0x06013D85 RID: 81285 RVA: 0x005C98D4 File Offset: 0x005C7AD4
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

	// Token: 0x06013D86 RID: 81286 RVA: 0x005C9932 File Offset: 0x005C7B32
	private void UpdateChangeAreaValue()
	{
		this.ChangeAreaScrollDuration = this.GetValueByDisplayName(this.UiCompassRoot, 1, 1f);
	}

	// Token: 0x06013D87 RID: 81287 RVA: 0x005C994C File Offset: 0x005C7B4C
	private void UpdateGearValue()
	{
		this.GearLength = this.GetValueByDisplayName(this.UiGear, 1, 300f);
		this.BigGearLength = this.GetValueByDisplayName(this.UiBigGear, 1, 600f);
	}

	// Token: 0x06013D88 RID: 81288 RVA: 0x005C997E File Offset: 0x005C7B7E
	private void UpdateCompassValue()
	{
		this.CompassStartAngle = this.GetValueByDisplayName(this.UiCompass, 1, -45f);
		this.CompassEndAngle = this.GetValueByDisplayName(this.UiCompass, 2, 45f);
	}

	// Token: 0x06013D89 RID: 81289 RVA: 0x005C99B0 File Offset: 0x005C7BB0
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

	// Token: 0x06013D8A RID: 81290 RVA: 0x005C9A94 File Offset: 0x005C7C94
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

	// Token: 0x06013D8B RID: 81291 RVA: 0x005C9B78 File Offset: 0x005C7D78
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

	// Token: 0x06013D8C RID: 81292 RVA: 0x005C9C5C File Offset: 0x005C7E5C
	protected override void OnBeforeShow()
	{
		this.UpdateData();
		int num = 500;
		this.RefreshTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
		ShipTowerModel.Instance.CloseWelcomeView();
		this.UpdateRedPoint();
	}

	// Token: 0x06013D8D RID: 81293 RVA: 0x005C9CAB File Offset: 0x005C7EAB
	[NullableContext(2)]
	private bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
	{
		this.IsDragging = true;
		return true;
	}

	// Token: 0x06013D8E RID: 81294 RVA: 0x005C9CB5 File Offset: 0x005C7EB5
	[NullableContext(2)]
	private bool OnPointerEndDrag(ULGUIPointerEventData eventData)
	{
		this.IsDragging = false;
		return true;
	}

	// Token: 0x06013D8F RID: 81295 RVA: 0x005C9CC0 File Offset: 0x005C7EC0
	protected override void OnAfterPlayStartSequence()
	{
		ShipTowerViewParams openParam = this.OpenParam;
		if (openParam != null && openParam.IsOpenStageDesc.GetValueOrDefault())
		{
			return;
		}
		this.CheckNeedShowView();
	}

	// Token: 0x06013D90 RID: 81296 RVA: 0x005C9CF4 File Offset: 0x005C7EF4
	private UniTask CheckNeedShowView()
	{
		ShipTowerView.<CheckNeedShowView>d__63 <CheckNeedShowView>d__;
		<CheckNeedShowView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckNeedShowView>d__.<>4__this = this;
		<CheckNeedShowView>d__.<>1__state = -1;
		<CheckNeedShowView>d__.<>t__builder.Start<ShipTowerView.<CheckNeedShowView>d__63>(ref <CheckNeedShowView>d__);
		return <CheckNeedShowView>d__.<>t__builder.Task;
	}

	// Token: 0x06013D91 RID: 81297 RVA: 0x005C9D38 File Offset: 0x005C7F38
	private UniTask AwaitNeedShowView()
	{
		ShipTowerView.<AwaitNeedShowView>d__64 <AwaitNeedShowView>d__;
		<AwaitNeedShowView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitNeedShowView>d__.<>1__state = -1;
		<AwaitNeedShowView>d__.<>t__builder.Start<ShipTowerView.<AwaitNeedShowView>d__64>(ref <AwaitNeedShowView>d__);
		return <AwaitNeedShowView>d__.<>t__builder.Task;
	}

	// Token: 0x06013D92 RID: 81298 RVA: 0x005C9D73 File Offset: 0x005C7F73
	private void SetShipTowerMaskLayer(bool isShow)
	{
		UiLayer.Instance.SetShowMaskLayer("ShipTower.CheckNeedShowView", isShow);
	}

	// Token: 0x06013D93 RID: 81299 RVA: 0x005C9D85 File Offset: 0x005C7F85
	private void EventOpenView(EUiViewName viewName, int _)
	{
		this.SetShipTowerMaskLayer(false);
	}

	// Token: 0x06013D94 RID: 81300 RVA: 0x005C9D8E File Offset: 0x005C7F8E
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06013D95 RID: 81301 RVA: 0x005C9D96 File Offset: 0x005C7F96
	protected override void OnBeforeDestroy()
	{
		this.UiScrollViewStage.OnScrollValueChange.Unbind();
		this.UiScrollViewStage.OnPointerBeginDragCallBack.Unbind();
		this.UiScrollViewStage.OnPointerEndDragCallBack.Unbind();
		this.UnBindTweenerComplete();
	}

	// Token: 0x06013D96 RID: 81302 RVA: 0x005C9DCE File Offset: 0x005C7FCE
	protected override void OnAfterDestroy()
	{
	}

	// Token: 0x06013D97 RID: 81303 RVA: 0x005C9DD0 File Offset: 0x005C7FD0
	private UniTask InitStageItem()
	{
		ShipTowerView.<InitStageItem>d__70 <InitStageItem>d__;
		<InitStageItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitStageItem>d__.<>4__this = this;
		<InitStageItem>d__.<>1__state = -1;
		<InitStageItem>d__.<>t__builder.Start<ShipTowerView.<InitStageItem>d__70>(ref <InitStageItem>d__);
		return <InitStageItem>d__.<>t__builder.Task;
	}

	// Token: 0x06013D98 RID: 81304 RVA: 0x005C9E13 File Offset: 0x005C8013
	private void OnClickBtnBuff()
	{
		ShipTowerModel.Instance.OpenViewBuff(new ShipTowerBuffViewParams
		{
			OperationType = new EShipTowerBuffOperationType?(EShipTowerBuffOperationType.Preview)
		});
	}

	// Token: 0x06013D99 RID: 81305 RVA: 0x005C9E30 File Offset: 0x005C8030
	private void OnClickBtnReward()
	{
		ShipTowerModel.Instance.OpenViewReward(null);
	}

	// Token: 0x06013D9A RID: 81306 RVA: 0x005C9E3D File Offset: 0x005C803D
	private void OnClickBtnEndlessRecord()
	{
		ShipTowerModel.Instance.OpenViewRecord(null);
	}

	// Token: 0x06013D9B RID: 81307 RVA: 0x005C9E4C File Offset: 0x005C804C
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

	// Token: 0x06013D9C RID: 81308 RVA: 0x005C9EAC File Offset: 0x005C80AC
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

	// Token: 0x06013D9D RID: 81309 RVA: 0x005C9F28 File Offset: 0x005C8128
	private bool CurContentPosIsTop()
	{
		return this.LastScrollValue <= 0.05f;
	}

	// Token: 0x06013D9E RID: 81310 RVA: 0x005C9F3A File Offset: 0x005C813A
	private bool CurContentPosIsBottom()
	{
		return this.LastScrollValue >= 0.95f;
	}

	// Token: 0x06013D9F RID: 81311 RVA: 0x005C9F4C File Offset: 0x005C814C
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

	// Token: 0x06013DA0 RID: 81312 RVA: 0x005C9F99 File Offset: 0x005C8199
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

	// Token: 0x06013DA1 RID: 81313 RVA: 0x005C9FCC File Offset: 0x005C81CC
	private int GetShipTowerStageItemIndex(int index)
	{
		int num = 7;
		int max = 18;
		return MathCommon.Clamp(num + index, num, max);
	}

	// Token: 0x06013DA2 RID: 81314 RVA: 0x005C9FE8 File Offset: 0x005C81E8
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

	// Token: 0x06013DA3 RID: 81315 RVA: 0x005CA084 File Offset: 0x005C8284
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

	// Token: 0x06013DA4 RID: 81316 RVA: 0x005CA11D File Offset: 0x005C831D
	public void ScrollTweenerStart()
	{
		this.IsTweenerComplete = false;
		this.UiScrollViewStage.SetCanScroll(false);
		this.UiScrollViewStage.SetRayCastTargetForScrollView(false);
		this.SetStageItemClickEnable(false);
	}

	// Token: 0x06013DA5 RID: 81317 RVA: 0x005CA148 File Offset: 0x005C8348
	private void SetStageItemClickEnable(bool enable)
	{
		for (int i = 0; i < this.StageItemList.Count; i++)
		{
			this.StageItemList[i].SetClickEnable(enable);
		}
	}

	// Token: 0x06013DA6 RID: 81318 RVA: 0x005CA17D File Offset: 0x005C837D
	public void ScrollTweenerEnd()
	{
		this.IsTweenerComplete = true;
		this.UiScrollViewStage.SetCanScroll(true);
		this.UiScrollViewStage.SetRayCastTargetForScrollView(true);
		this.SetStageItemClickEnable(true);
	}

	// Token: 0x06013DA7 RID: 81319 RVA: 0x005CA1A8 File Offset: 0x005C83A8
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

	// Token: 0x06013DA8 RID: 81320 RVA: 0x005CA1F4 File Offset: 0x005C83F4
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

	// Token: 0x06013DA9 RID: 81321 RVA: 0x005CA217 File Offset: 0x005C8417
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

	// Token: 0x06013DAA RID: 81322 RVA: 0x005CA234 File Offset: 0x005C8434
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

	// Token: 0x06013DAB RID: 81323 RVA: 0x005CA2AC File Offset: 0x005C84AC
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

	// Token: 0x06013DAC RID: 81324 RVA: 0x005CA328 File Offset: 0x005C8528
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

	// Token: 0x06013DAD RID: 81325 RVA: 0x005CA3B8 File Offset: 0x005C85B8
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

	// Token: 0x06013DAE RID: 81326 RVA: 0x005CA410 File Offset: 0x005C8610
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

	// Token: 0x06013DAF RID: 81327 RVA: 0x005CA4B0 File Offset: 0x005C86B0
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

	// Token: 0x06013DB0 RID: 81328 RVA: 0x005CA610 File Offset: 0x005C8810
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

	// Token: 0x06013DB1 RID: 81329 RVA: 0x005CA6DC File Offset: 0x005C88DC
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

	// Token: 0x06013DB2 RID: 81330 RVA: 0x005CA728 File Offset: 0x005C8928
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

	// Token: 0x06013DB3 RID: 81331 RVA: 0x005CA77C File Offset: 0x005C897C
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

	// Token: 0x06013DB4 RID: 81332 RVA: 0x005CA7AD File Offset: 0x005C89AD
	private void UpdateData()
	{
		this.UpdateEndlessRecord();
		this.UpdateRewardProgress();
		this.UpdateBuffNew();
	}

	// Token: 0x06013DB5 RID: 81333 RVA: 0x005CA7C4 File Offset: 0x005C89C4
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

	// Token: 0x06013DB6 RID: 81334 RVA: 0x005CA7F0 File Offset: 0x005C89F0
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

	// Token: 0x06013DB7 RID: 81335 RVA: 0x005CA82C File Offset: 0x005C8A2C
	private void UpdateRewardProgress()
	{
		string rewardProgressText = ShipTowerModel.Instance.GetRewardProgressText(true);
		string newText = ShipTowerModel.Instance.GetCurrentStageSeasonName() + "(" + rewardProgressText + ")";
		base.GetText(3).SetText(newText, true);
		this.UpdateRemainTime();
	}

	// Token: 0x06013DB8 RID: 81336 RVA: 0x005CA874 File Offset: 0x005C8A74
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

	// Token: 0x06013DB9 RID: 81337 RVA: 0x005CA89F File Offset: 0x005C8A9F
	private void OnTimerRefresh(float delta)
	{
		this.UpdateRemainTime();
		if (ShipTowerModel.Instance.TimeIsOver())
		{
			this.ClearTimer();
			ShipTowerModel.Instance.CheckIsNeedShowConfirmSeasonUpdate(null);
		}
	}

	// Token: 0x06013DBA RID: 81338 RVA: 0x005CA8C5 File Offset: 0x005C8AC5
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x06013DBB RID: 81339 RVA: 0x005CA8E8 File Offset: 0x005C8AE8
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

	// Token: 0x06013DBC RID: 81340 RVA: 0x005CA923 File Offset: 0x005C8B23
	private void EventRewardReceive(int _)
	{
		this.UpdateRewardProgress();
	}

	// Token: 0x06013DBD RID: 81341 RVA: 0x005CA92C File Offset: 0x005C8B2C
	private void EventShipTowerStageUpdate(int id)
	{
		ShipTowerStageItemBase shipTowerStageItemBase;
		if (this.StageItemMap.TryGetValue(id, out shipTowerStageItemBase))
		{
			shipTowerStageItemBase.UpdateData();
		}
	}

	// Token: 0x06013DBE RID: 81342 RVA: 0x005CA94F File Offset: 0x005C8B4F
	private void OnHelpClick()
	{
		HelpController.Instance.OpenHelpById(201);
	}

	// Token: 0x06013DBF RID: 81343 RVA: 0x005CA960 File Offset: 0x005C8B60
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

	// Token: 0x0400A93E RID: 43326
	private const string MASK_LAYER_TAG = "ShipTower.CheckNeedShowView";

	// Token: 0x0400A93F RID: 43327
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A940 RID: 43328
	public UUIScrollViewWithScrollbarComponent UiScrollViewStage;

	// Token: 0x0400A941 RID: 43329
	private UUIItem UiItemParallaxRoot;

	// Token: 0x0400A942 RID: 43330
	private readonly List<IParallaxItem> ItemParallaxList = new List<IParallaxItem>();

	// Token: 0x0400A943 RID: 43331
	private float LastScrollValue = 0.001f;

	// Token: 0x0400A944 RID: 43332
	private float ScrollContentInitPosY;

	// Token: 0x0400A945 RID: 43333
	private float ScrollContentLastPosY;

	// Token: 0x0400A946 RID: 43334
	private IReadOnlyList<SlashTowerShowStage> ShowStageCfgList;

	// Token: 0x0400A947 RID: 43335
	private int TopStageIndex;

	// Token: 0x0400A948 RID: 43336
	private readonly Dictionary<int, ShipTowerStageItemBase> StageItemMap = new Dictionary<int, ShipTowerStageItemBase>();

	// Token: 0x0400A949 RID: 43337
	private readonly List<ShipTowerStageItemBase> StageItemList = new List<ShipTowerStageItemBase>();

	// Token: 0x0400A94A RID: 43338
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x0400A94B RID: 43339
	[Nullable(2)]
	public UCurveFloat UiCureChangeArea;

	// Token: 0x0400A94C RID: 43340
	public float ChangeAreaScrollDuration;

	// Token: 0x0400A94D RID: 43341
	[Nullable(2)]
	public UCurveFloat UiCureFlipPage;

	// Token: 0x0400A94E RID: 43342
	[Nullable(2)]
	public UCurveFloat UiCureScrollTo;

	// Token: 0x0400A94F RID: 43343
	public float FlipPageDistanceThreshold;

	// Token: 0x0400A950 RID: 43344
	public float FlipPageScrollDuration;

	// Token: 0x0400A951 RID: 43345
	public float FlipPageIntervalDistance;

	// Token: 0x0400A952 RID: 43346
	private UUIItem UiCompassRoot;

	// Token: 0x0400A953 RID: 43347
	private UUISprite UiGear;

	// Token: 0x0400A954 RID: 43348
	private UUISprite UiBigGear;

	// Token: 0x0400A955 RID: 43349
	private UUISprite UiCompass;

	// Token: 0x0400A956 RID: 43350
	private float GearLength;

	// Token: 0x0400A957 RID: 43351
	private float BigGearLength;

	// Token: 0x0400A958 RID: 43352
	private float CompassStartAngle;

	// Token: 0x0400A959 RID: 43353
	private float CompassEndAngle;

	// Token: 0x0400A95A RID: 43354
	private FRotator RotationCompass = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A95B RID: 43355
	private FRotator RotationGear = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A95C RID: 43356
	private FRotator RotationBigGear = new FRotator(0f, 0f, 0f);

	// Token: 0x0400A95D RID: 43357
	private bool IsBindTweenerComplete;

	// Token: 0x0400A95E RID: 43358
	private bool IsTweenerComplete = true;

	// Token: 0x0400A95F RID: 43359
	private bool IsDragging;

	// Token: 0x02008254 RID: 33364
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A13A RID: 172346
		public const int ItemCaption = 0;

		// Token: 0x0402A13B RID: 172347
		public const int BtnBuff = 1;

		// Token: 0x0402A13C RID: 172348
		public const int BtnEndlessRecord = 2;

		// Token: 0x0402A13D RID: 172349
		public const int TxtRewardProgress = 3;

		// Token: 0x0402A13E RID: 172350
		public const int TxtCountDownTime = 4;

		// Token: 0x0402A13F RID: 172351
		public const int BtnLastStage = 5;

		// Token: 0x0402A140 RID: 172352
		public const int BtnNextStage = 6;

		// Token: 0x0402A141 RID: 172353
		public const int ItemOneTimeStage1 = 7;

		// Token: 0x0402A142 RID: 172354
		public const int ItemOneTimeStage2 = 8;

		// Token: 0x0402A143 RID: 172355
		public const int ItemOneTimeStage3 = 9;

		// Token: 0x0402A144 RID: 172356
		public const int ItemOneTimeStage4 = 10;

		// Token: 0x0402A145 RID: 172357
		public const int ItemOneTimeStage5 = 11;

		// Token: 0x0402A146 RID: 172358
		public const int ItemOneTimeStage6 = 12;

		// Token: 0x0402A147 RID: 172359
		public const int ItemRefreshStage1 = 13;

		// Token: 0x0402A148 RID: 172360
		public const int ItemRefreshStage2 = 14;

		// Token: 0x0402A149 RID: 172361
		public const int ItemRefreshStage3 = 15;

		// Token: 0x0402A14A RID: 172362
		public const int ItemRefreshStage4 = 16;

		// Token: 0x0402A14B RID: 172363
		public const int ItemRefreshStage5 = 17;

		// Token: 0x0402A14C RID: 172364
		public const int ItemEndlessStage = 18;

		// Token: 0x0402A14D RID: 172365
		public const int TxtCurrentArea = 19;

		// Token: 0x0402A14E RID: 172366
		public const int ItemParallaxRoot = 20;

		// Token: 0x0402A14F RID: 172367
		public const int ScrollViewStage = 21;

		// Token: 0x0402A150 RID: 172368
		public const int BtnReward = 22;

		// Token: 0x0402A151 RID: 172369
		public const int ItemRewardRedDot = 23;

		// Token: 0x0402A152 RID: 172370
		public const int ItemCompassRoot = 24;

		// Token: 0x0402A153 RID: 172371
		public const int SpriteBigGear = 25;

		// Token: 0x0402A154 RID: 172372
		public const int SpriteGear = 26;

		// Token: 0x0402A155 RID: 172373
		public const int SpriteCompass = 27;

		// Token: 0x0402A156 RID: 172374
		public const int ItemBuffNew = 28;
	}
}
