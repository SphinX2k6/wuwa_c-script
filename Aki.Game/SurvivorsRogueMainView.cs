using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020C4 RID: 8388
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueMainView : UiTickViewBase
{
	// Token: 0x060149DC RID: 84444 RVA: 0x00601AF0 File Offset: 0x005FFCF0
	public SurvivorsRogueMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060149DD RID: 84445 RVA: 0x00601C04 File Offset: 0x005FFE04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(10, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(11, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickedBtnUp)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickedBtnDown))
		};
	}

	// Token: 0x060149DE RID: 84446 RVA: 0x00601E78 File Offset: 0x00600078
	protected override UniTask OnCreateAsync()
	{
		SurvivorsRogueMainView.<OnCreateAsync>d__33 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<SurvivorsRogueMainView.<OnCreateAsync>d__33>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060149DF RID: 84447 RVA: 0x00601EBC File Offset: 0x006000BC
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueMainView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueMainView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060149E0 RID: 84448 RVA: 0x00601EFF File Offset: 0x006000FF
	protected override void OnStart()
	{
		this.ScrollViewComp.OnLateUpdate.Bind(delegate(float _)
		{
			this.InitCurSelectPos();
			this.ScrollViewComp.OnLateUpdate.Unbind();
		});
	}

	// Token: 0x060149E1 RID: 84449 RVA: 0x00601F1D File Offset: 0x0060011D
	protected override void OnBeforeShow()
	{
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
		this.RefreshFunctionButton();
		this.RefreshLevelInfo();
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x060149E2 RID: 84450 RVA: 0x00601F50 File Offset: 0x00600150
	protected override void OnAfterShow()
	{
		SurvivorsRogueController.Instance.TryOpenWeaponUnlockView().ContinueWith(delegate(bool isOpen)
		{
			if (!isOpen)
			{
				this.StartLevelUnlockFlow();
			}
		});
	}

	// Token: 0x060149E3 RID: 84451 RVA: 0x00601F70 File Offset: 0x00600170
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.SurvivorsInstSettle, new Action<bool>(this.OnSurvivorsInstSettle));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDay));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnSurvivorsRogueTalentNodeUpdate));
	}

	// Token: 0x060149E4 RID: 84452 RVA: 0x00602008 File Offset: 0x00600208
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsInstSettle, new Action<bool>(this.OnSurvivorsInstSettle));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDay));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnSurvivorsRogueTalentNodeUpdate));
	}

	// Token: 0x060149E5 RID: 84453 RVA: 0x006020A0 File Offset: 0x006002A0
	protected override void OnBeforeDestroy()
	{
		this.ItemParallaxList.Clear();
		this.ScrollViewComp.OnScrollValueChange.Unbind();
		this.ScrollViewComp.OnPointerBeginDragCallBack.Unbind();
		this.ScrollViewComp.OnPointerEndDragCallBack.Unbind();
		USpineSkeletonAnimationComponent spine = base.GetSpine(22);
		if (spine != null)
		{
			spine.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnAnimationComplete));
		}
		this.UnBindTweenerComplete();
	}

	// Token: 0x060149E6 RID: 84454 RVA: 0x00602114 File Offset: 0x00600314
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<UCurveFloat> LoadCurveFloat(string resId)
	{
		SurvivorsRogueMainView.<LoadCurveFloat>d__41 <LoadCurveFloat>d__;
		<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveFloat>d__.resId = resId;
		<LoadCurveFloat>d__.<>1__state = -1;
		<LoadCurveFloat>d__.<>t__builder.Start<SurvivorsRogueMainView.<LoadCurveFloat>d__41>(ref <LoadCurveFloat>d__);
		return <LoadCurveFloat>d__.<>t__builder.Task;
	}

	// Token: 0x060149E7 RID: 84455 RVA: 0x00602158 File Offset: 0x00600358
	protected override void OnTick(float delta)
	{
		foreach (SurvivorsLevelInfoItem survivorsLevelInfoItem in this.LevelInfoItemMap.Values)
		{
			survivorsLevelInfoItem.OnTick(delta);
		}
	}

	// Token: 0x060149E8 RID: 84456 RVA: 0x006021B0 File Offset: 0x006003B0
	private void OnRefreshRedDot(int activityId)
	{
		if (this.ActivityDataBase.Id != activityId)
		{
			return;
		}
		this.RefreshFunctionButton();
	}

	// Token: 0x060149E9 RID: 84457 RVA: 0x006021C8 File Offset: 0x006003C8
	private void OnActivityCrossDay()
	{
		this.RefreshFunctionButton();
		List<int> allLevelId = this.ActivityDataBase.GetAllLevelId();
		for (int i = allLevelId.Count - 1; i >= 0; i--)
		{
			int num = allLevelId[i];
			ISurvivorsLevelInfo currentLevelInfoByLevelId = this.ActivityDataBase.GetCurrentLevelInfoByLevelId(num);
			SurvivorsLevelItem survivorsLevelItem;
			SurvivorsLevelInfoItem survivorsLevelInfoItem;
			if (this.LevelItemMap.TryGetValue(num, out survivorsLevelItem) && this.LevelInfoItemMap.TryGetValue(num, out survivorsLevelInfoItem) && currentLevelInfoByLevelId != null)
			{
				survivorsLevelItem.Refresh(num, currentLevelInfoByLevelId.IsEndlessMode);
				survivorsLevelInfoItem.Refresh(currentLevelInfoByLevelId, false, i);
			}
		}
	}

	// Token: 0x060149EA RID: 84458 RVA: 0x0060224A File Offset: 0x0060044A
	private void OnViewClose(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.SurvivorsWeaponUnlockView)
		{
			return;
		}
		this.StartLevelUnlockFlow();
	}

	// Token: 0x060149EB RID: 84459 RVA: 0x00602260 File Offset: 0x00600460
	private void OnSurvivorsRogueTalentNodeUpdate(int nodeId)
	{
		this.RefreshFunctionButton();
	}

	// Token: 0x060149EC RID: 84460 RVA: 0x00602268 File Offset: 0x00600468
	private void InitScrollView()
	{
		this.ScrollViewComp = base.GetScrollViewWithScrollbar(2);
		this.ScrollViewComp.ScrollToEaseType = LTweenEase.CurveFloat;
		this.ScrollViewComp.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		this.ScrollViewComp.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
		this.ScrollViewComp.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerEndDrag));
		this.ScrollContentInitPosY = this.ScrollViewComp.ContentUIItem.Get().GetAnchorOffsetY();
		this.ScrollContentLastPosY = this.ScrollContentInitPosY;
		this.CenterAreaHalfHeight = 100f;
		this.CenterPosY = this.ScrollViewComp.RootUIComp.Get().GetHeight() / 2f;
	}

	// Token: 0x060149ED RID: 84461 RVA: 0x0060233C File Offset: 0x0060053C
	private void InitParallaxItem()
	{
		TWeakObjectPtr<UUIItem> contentUIItem = base.GetScrollViewWithScrollbar(1).ContentUIItem;
		SurvivorsRogueParallaxItem item = new SurvivorsRogueParallaxItem
		{
			Item = contentUIItem,
			InitPosY = contentUIItem.Get().GetAnchorOffsetY(),
			ParallaxFactor = this.BackgroundParallaxFactor
		};
		this.ItemParallaxList.Add(item);
	}

	// Token: 0x060149EE RID: 84462 RVA: 0x00602394 File Offset: 0x00600594
	private void InitCurSelectPos()
	{
		int levelId = this.LevelInfo.LevelId;
		if (levelId != 0)
		{
			this.ScrollLevelIdToCenter(levelId);
		}
		else
		{
			int focusLevelId = this.ActivityDataBase.GetFocusLevelId();
			this.ScrollLevelIdToCenter(focusLevelId);
		}
		foreach (SurvivorsLevelInfoItem survivorsLevelInfoItem in this.LevelInfoItemMap.Values)
		{
			survivorsLevelInfoItem.SetSaveFile(this.LevelInfo);
		}
	}

	// Token: 0x060149EF RID: 84463 RVA: 0x0060241C File Offset: 0x0060061C
	private bool OnPointerBeginDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = true;
		return true;
	}

	// Token: 0x060149F0 RID: 84464 RVA: 0x00602426 File Offset: 0x00600626
	private bool OnPointerEndDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = false;
		this.StartElasticMovement = true;
		return true;
	}

	// Token: 0x060149F1 RID: 84465 RVA: 0x00602438 File Offset: 0x00600638
	private void OnScrollValueChange(FVector2D inVector)
	{
		float y = inVector.Y;
		if (Math.Abs(y - this.LastScrollValue) < 1.1754944E-38f)
		{
			return;
		}
		this.LastScrollValue = y;
		float anchorOffsetY = this.ScrollViewComp.ContentUIItem.Get().GetAnchorOffsetY();
		this.ScrollContentLastPosY = anchorOffsetY;
		this.UpdateCurrentDiffArea(anchorOffsetY);
		this.UpdateParallaxItemPos(anchorOffsetY);
		this.UpdateLevelInfoPos();
		if (this.StartElasticMovement && Math.Abs(this.ScrollViewComp.GetVelocity().Y) < this.AutoAttachVelocityY)
		{
			SurvivorsRogueDiffAreaInfo survivorsRogueDiffAreaInfo = this.DiffAreaUiInfoList[this.CurrentDiff];
			this.ScrollLevelIdToBottom(survivorsRogueDiffAreaInfo.LowerBoundLevelId, true);
			this.StartElasticMovement = false;
		}
	}

	// Token: 0x060149F2 RID: 84466 RVA: 0x006024E8 File Offset: 0x006006E8
	private void UpdateParallaxItemPos(float posY)
	{
		for (int i = 0; i < this.ItemParallaxList.Count; i++)
		{
			SurvivorsRogueParallaxItem survivorsRogueParallaxItem = this.ItemParallaxList[i];
			float val = survivorsRogueParallaxItem.InitPosY + (posY - this.ScrollContentInitPosY) * survivorsRogueParallaxItem.ParallaxFactor;
			survivorsRogueParallaxItem.Item.SetAnchorOffsetY(Math.Max(0f, val));
		}
	}

	// Token: 0x060149F3 RID: 84467 RVA: 0x00602548 File Offset: 0x00600748
	protected void ScrollLevelIdToBottom(int levelId, bool tween = true)
	{
		SurvivorsLevelItem survivorsLevelItem;
		if (!this.LevelItemMap.TryGetValue(levelId, out survivorsLevelItem))
		{
			return;
		}
		FVector relativeLocation = this.ScrollViewComp.ContentUIItem.Get().RelativeLocation;
		FVector2D fvector2D = new FVector2D(ref relativeLocation);
		UUIItem bottomPosItem = survivorsLevelItem.GetBottomPosItem();
		this.ScrollViewComp.StopMovement();
		if (tween)
		{
			this.ScrollTweenerStart();
		}
		this.ScrollViewComp.ScrollToBottom(ref fvector2D, bottomPosItem, tween);
		if (tween && this.ScrollViewComp.Tweener != null)
		{
			this.ScrollViewComp.Tweener.SetDuration(this.ChangeAreaDuration);
			this.ScrollViewComp.Tweener.SetCurveFloat(this.UiCurveAreaMove);
			this.BindTweenerComplete();
		}
	}

	// Token: 0x060149F4 RID: 84468 RVA: 0x006025F8 File Offset: 0x006007F8
	protected void ScrollLevelIdToCenter(int levelId)
	{
		SurvivorsLevelItem survivorsLevelItem;
		if (!this.LevelItemMap.TryGetValue(levelId, out survivorsLevelItem))
		{
			return;
		}
		float num = -survivorsLevelItem.GetOriginalItem().GetAnchorOffsetY() - this.CenterPosY;
		if (num <= 0f)
		{
			return;
		}
		this.TempVector2D.Reset();
		this.TempVector2D.Y = (double)num;
		this.ScrollViewComp.StopMovement();
		this.ScrollViewComp.ContentUIItem.Get().SetAnchorOffset(this.TempVector2D.ToUeVector2D(false));
	}

	// Token: 0x060149F5 RID: 84469 RVA: 0x0060267A File Offset: 0x0060087A
	private void ScrollTweenerStart()
	{
		this.IsTweenerComplete = false;
		this.ScrollViewComp.SetRayCastTargetForScrollView(false);
		this.SetLevelItemInteractive(false);
	}

	// Token: 0x060149F6 RID: 84470 RVA: 0x00602696 File Offset: 0x00600896
	protected void ScrollTweenerEnd()
	{
		this.IsTweenerComplete = true;
		this.ScrollViewComp.SetRayCastTargetForScrollView(true);
		this.SetLevelItemInteractive(true);
	}

	// Token: 0x060149F7 RID: 84471 RVA: 0x006026B4 File Offset: 0x006008B4
	private void BindTweenerComplete()
	{
		if (this.IsBindTweenerComplete)
		{
			return;
		}
		if (this.ScrollViewComp.Tweener == null)
		{
			return;
		}
		this.IsBindTweenerComplete = true;
		this.ScrollViewComp.Tweener.OnCompleteCallBack.Bind(new Action(this.TweenerComplete));
	}

	// Token: 0x060149F8 RID: 84472 RVA: 0x00602700 File Offset: 0x00600900
	private void UnBindTweenerComplete()
	{
		this.IsBindTweenerComplete = false;
		ULTweener tweener = this.ScrollViewComp.Tweener;
		if (tweener == null)
		{
			return;
		}
		tweener.OnCompleteCallBack.Unbind();
	}

	// Token: 0x060149F9 RID: 84473 RVA: 0x00602723 File Offset: 0x00600923
	private void TweenerComplete()
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		this.ScrollTweenerEnd();
	}

	// Token: 0x060149FA RID: 84474 RVA: 0x00602734 File Offset: 0x00600934
	private bool IsTopArea()
	{
		return this.CurrentDiff == 2;
	}

	// Token: 0x060149FB RID: 84475 RVA: 0x0060273F File Offset: 0x0060093F
	private bool IsBottomArea()
	{
		return this.CurrentDiff == 0;
	}

	// Token: 0x060149FC RID: 84476 RVA: 0x0060274C File Offset: 0x0060094C
	private UniTask InitAllLevel()
	{
		SurvivorsRogueMainView.<InitAllLevel>d__63 <InitAllLevel>d__;
		<InitAllLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllLevel>d__.<>4__this = this;
		<InitAllLevel>d__.<>1__state = -1;
		<InitAllLevel>d__.<>t__builder.Start<SurvivorsRogueMainView.<InitAllLevel>d__63>(ref <InitAllLevel>d__);
		return <InitAllLevel>d__.<>t__builder.Task;
	}

	// Token: 0x060149FD RID: 84477 RVA: 0x00602790 File Offset: 0x00600990
	private unsafe void InitDiffArea()
	{
		Span<int> areaBoundLevelIdBytes = SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(this.ActivityDataBase.Id).Value.GetAreaBoundLevelIdBytes();
		float num = this.ScrollViewComp.RootUIComp.Get().GetHeight() * this.AreaBottomScale;
		for (int i = 0; i < areaBoundLevelIdBytes.Length; i++)
		{
			int num2 = *areaBoundLevelIdBytes[i];
			UUIItem originalItem = this.LevelItemMap[num2].GetOriginalItem();
			float height = originalItem.GetHeight();
			float anchorOffsetY = originalItem.GetAnchorOffsetY();
			SurvivorsRogueDiffAreaInfo item = new SurvivorsRogueDiffAreaInfo
			{
				Diff = ESurvivorsLevelDiff.Easy + i,
				LowerBoundLevelId = num2,
				LowerBoundPosY = anchorOffsetY - height + num
			};
			this.DiffAreaUiInfoList.Add(item);
		}
		this.CurrentUnlockDiff = (int)this.ActivityDataBase.GetCurrentUnlockDiffId();
		string animationName = this.diffIdToleSpineName[this.CurrentUnlockDiff];
		base.GetSpine(22).AnimationComplete.Add(new Action<UTrackEntry>(this.OnAnimationComplete));
		base.GetSpine(22).SetAnimation(0, animationName, true);
	}

	// Token: 0x060149FE RID: 84478 RVA: 0x006028AC File Offset: 0x00600AAC
	[NullableContext(2)]
	private void OnAnimationComplete(UTrackEntry entry)
	{
		if (entry == null)
		{
			return;
		}
		string animationName = entry.getAnimationName();
		int num = Array.IndexOf<string>(this.diffIdUnlockToSpineName, animationName);
		if (num != -1)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(22);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, this.diffIdToleSpineName[num], true);
		}
	}

	// Token: 0x060149FF RID: 84479 RVA: 0x006028F4 File Offset: 0x00600AF4
	private void UpdateLevelInfoPos()
	{
		foreach (KeyValuePair<int, SurvivorsLevelItem> keyValuePair in this.LevelItemMap)
		{
			int key = keyValuePair.Key;
			FVectorDouble newLocation = keyValuePair.Value.GetRootActor().D_K2_GetActorLocation();
			SurvivorsLevelInfoItem survivorsLevelInfoItem;
			if (this.LevelInfoItemMap.TryGetValue(key, out survivorsLevelInfoItem))
			{
				FHitResult fhitResult = new FHitResult();
				survivorsLevelInfoItem.GetRootActor().D_K2_SetActorLocation(newLocation, false, ref fhitResult, false);
			}
		}
	}

	// Token: 0x06014A00 RID: 84480 RVA: 0x00602984 File Offset: 0x00600B84
	private void UpdateCurrentDiffArea(float posY)
	{
		ESurvivorsLevelDiff esurvivorsLevelDiff = ESurvivorsLevelDiff.Easy;
		for (int i = 1; i < this.DiffAreaUiInfoList.Count; i++)
		{
			SurvivorsRogueDiffAreaInfo survivorsRogueDiffAreaInfo = this.DiffAreaUiInfoList[i];
			float lowerBoundPosY = survivorsRogueDiffAreaInfo.LowerBoundPosY;
			if (posY + lowerBoundPosY > 0f)
			{
				break;
			}
			esurvivorsLevelDiff = survivorsRogueDiffAreaInfo.Diff;
		}
		if (this.CurrentDiff == (int)esurvivorsLevelDiff)
		{
			return;
		}
		this.GetDiffToggle((ESurvivorsLevelDiff)this.CurrentDiff).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CurrentDiff = (int)esurvivorsLevelDiff;
		this.RefreshCurrentDiffInfo();
	}

	// Token: 0x06014A01 RID: 84481 RVA: 0x006029FC File Offset: 0x00600BFC
	private void RefreshCurrentDiffInfo()
	{
		UUIText text = base.GetText(21);
		string textStringId = string.Empty;
		switch (this.CurrentDiff)
		{
		case 0:
			textStringId = "SurvivorsLevelSimple_TagName";
			break;
		case 1:
			textStringId = "SurvivorsLevelOrdinary_TagName";
			break;
		case 2:
			textStringId = "SurvivorsLevelDifficult_TagName";
			break;
		}
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		this.GetDiffToggle((ESurvivorsLevelDiff)this.CurrentDiff).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014A02 RID: 84482 RVA: 0x00602A70 File Offset: 0x00600C70
	protected int GetNearestCenterLevelId()
	{
		int result = 0;
		int maxValue = int.MaxValue;
		float anchorOffsetY = this.ScrollViewComp.ContentUIItem.Get().GetAnchorOffsetY();
		float num = anchorOffsetY - this.CenterAreaHalfHeight;
		float num2 = anchorOffsetY + this.CenterAreaHalfHeight;
		foreach (KeyValuePair<int, SurvivorsLevelItem> keyValuePair in this.LevelItemMap)
		{
			int key = keyValuePair.Key;
			UUIItem originalItem = keyValuePair.Value.GetOriginalItem();
			float height = originalItem.GetHeight();
			float anchorOffsetY2 = originalItem.GetAnchorOffsetY();
			float num3 = height - anchorOffsetY2 - this.CenterPosY;
			if (num <= num3 && num3 <= num2 && Math.Abs(num3 - this.CenterPosY) < (float)maxValue)
			{
				result = key;
			}
		}
		return result;
	}

	// Token: 0x06014A03 RID: 84483 RVA: 0x00602B44 File Offset: 0x00600D44
	private UUIExtendToggle GetDiffToggle(ESurvivorsLevelDiff diff)
	{
		switch (diff)
		{
		case ESurvivorsLevelDiff.Easy:
			return base.GetExtendToggle(11);
		case ESurvivorsLevelDiff.Normal:
			return base.GetExtendToggle(10);
		case ESurvivorsLevelDiff.Challenge:
			return base.GetExtendToggle(9);
		default:
			return base.GetExtendToggle(10);
		}
	}

	// Token: 0x06014A04 RID: 84484 RVA: 0x00602B80 File Offset: 0x00600D80
	private void SetLevelItemInteractive(bool enable)
	{
		foreach (SurvivorsLevelItem survivorsLevelItem in this.LevelItemMap.Values)
		{
			survivorsLevelItem.SetButtonInteractive(enable);
		}
	}

	// Token: 0x06014A05 RID: 84485 RVA: 0x00602BD8 File Offset: 0x00600DD8
	private void StartLevelUnlockFlow()
	{
		bool flag = false;
		foreach (KeyValuePair<int, SurvivorsLevelInfoItem> keyValuePair in this.LevelInfoItemMap)
		{
			int key = keyValuePair.Key;
			SurvivorsLevelInfoItem value = keyValuePair.Value;
			bool flag2 = this.ActivityDataBase.TryRemoveLevelNewUnlock(key, false);
			bool flag3 = this.ActivityDataBase.TryRemoveLevelNewUnlock(key, true);
			bool flag4 = this.ActivityDataBase.TryRemoveLevelNewFinished(key);
			if (flag3)
			{
				value.PlaySequenceByName(ESurvivorsLevelInfoSeqName.EndlessOpen);
				flag = true;
			}
			else if (flag2)
			{
				value.PlaySequenceByName(ESurvivorsLevelInfoSeqName.Unlock);
				flag = true;
			}
			else if (flag4)
			{
				value.PlaySequenceByName(ESurvivorsLevelInfoSeqName.Complete);
			}
		}
		if (flag)
		{
			this.ActivityDataBase.RefreshActivityRedDot();
		}
		if (this.ActivityDataBase.IsEndlessFirstOpenCheck())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsLevelSelection_EndlessTips", Array.Empty<object>());
		}
		int currentUnlockDiffId = (int)this.ActivityDataBase.GetCurrentUnlockDiffId();
		if (currentUnlockDiffId > this.CurrentUnlockDiff)
		{
			this.CurrentUnlockDiff = currentUnlockDiffId;
			string animationName = this.diffIdUnlockToSpineName[this.CurrentUnlockDiff];
			base.GetSpine(22).SetAnimation(0, animationName, false);
		}
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
	}

	// Token: 0x06014A06 RID: 84486 RVA: 0x00602D1C File Offset: 0x00600F1C
	private void RefreshLevelInfo()
	{
		int num = this.LevelItemMap.Count;
		foreach (KeyValuePair<int, SurvivorsLevelItem> keyValuePair in this.LevelItemMap)
		{
			int key = keyValuePair.Key;
			SurvivorsLevelItem value = keyValuePair.Value;
			ISurvivorsLevelInfo currentLevelInfoByLevelId = this.ActivityDataBase.GetCurrentLevelInfoByLevelId(key);
			SurvivorsLevelInfoItem survivorsLevelInfoItem;
			if (this.LevelInfoItemMap.TryGetValue(key, out survivorsLevelInfoItem) && currentLevelInfoByLevelId != null)
			{
				value.Refresh(key, currentLevelInfoByLevelId.IsEndlessMode);
				survivorsLevelInfoItem.Refresh(currentLevelInfoByLevelId, false, num);
				num--;
			}
		}
	}

	// Token: 0x06014A07 RID: 84487 RVA: 0x00602DC8 File Offset: 0x00600FC8
	private void RefreshFunctionButton()
	{
		string text = this.ActivityDataBase.GetFinishedRewardTaskCount().ToString();
		string text2 = this.ActivityDataBase.RewardTaskMap.Count.ToString();
		this.ButtonReward.SetDescText("SurvivorsReward", new string[]
		{
			text,
			text2
		});
		this.ButtonReward.SetRedDotVisible(this.ActivityDataBase.GetRewardRedDotState());
		string text3 = this.ActivityDataBase.GetAllItemUnlockCount().ToString();
		string text4 = this.ActivityDataBase.GetAllItemCount().ToString();
		this.ButtonHandbook.SetDescText("SurvivorsCollection", new string[]
		{
			text3,
			text4
		});
		Dictionary<int, SurvivorsTalentNode> talentNodeMap = this.ActivityDataBase.TalentNodeMap;
		int num = 0;
		using (Dictionary<int, SurvivorsTalentNode>.ValueCollection.Enumerator enumerator = talentNodeMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ESurvivorsTalentNodeStatus.Upgraded)
				{
					num++;
				}
			}
		}
		string text5 = talentNodeMap.Count.ToString();
		this.ButtonTalentTree.SetRedDotVisible(this.ActivityDataBase.GetTalentTreeRed());
		this.ButtonTalentTree.SetDescText("SurvivorsSkillTree", new string[]
		{
			num.ToString(),
			text5
		});
	}

	// Token: 0x06014A08 RID: 84488 RVA: 0x00602F2C File Offset: 0x0060112C
	private void OnClickedBtnReward()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06014A09 RID: 84489 RVA: 0x00602F4A File Offset: 0x0060114A
	private void OnClickedBtnHandbook()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsHandbookView, null, null);
	}

	// Token: 0x06014A0A RID: 84490 RVA: 0x00602F5D File Offset: 0x0060115D
	private void OnClickedBtnTalentTree()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTalentTreeView, null, null);
	}

	// Token: 0x06014A0B RID: 84491 RVA: 0x00602F70 File Offset: 0x00601170
	private void OnClickedBtnUp()
	{
		if (this.IsDragging)
		{
			return;
		}
		if (!this.IsTweenerComplete)
		{
			return;
		}
		if (this.IsTopArea())
		{
			return;
		}
		SurvivorsRogueDiffAreaInfo survivorsRogueDiffAreaInfo = this.DiffAreaUiInfoList[this.CurrentDiff + 1];
		this.ScrollLevelIdToBottom(survivorsRogueDiffAreaInfo.LowerBoundLevelId, true);
	}

	// Token: 0x06014A0C RID: 84492 RVA: 0x00602FBC File Offset: 0x006011BC
	private void OnClickedBtnDown()
	{
		if (this.IsDragging)
		{
			return;
		}
		if (!this.IsTweenerComplete)
		{
			return;
		}
		if (this.IsBottomArea())
		{
			return;
		}
		SurvivorsRogueDiffAreaInfo survivorsRogueDiffAreaInfo = this.DiffAreaUiInfoList[this.CurrentDiff - 1];
		this.ScrollLevelIdToBottom(survivorsRogueDiffAreaInfo.LowerBoundLevelId, true);
	}

	// Token: 0x06014A0D RID: 84493 RVA: 0x00603008 File Offset: 0x00601208
	private void OnSurvivorsInstSettle(bool success)
	{
		if (!success)
		{
			return;
		}
		this.LevelInfo = new SurvivorsActivityDefine.SurvivorsLevelInfo();
		foreach (SurvivorsLevelInfoItem survivorsLevelInfoItem in this.LevelInfoItemMap.Values)
		{
			survivorsLevelInfoItem.SetSaveFile(this.LevelInfo);
		}
	}

	// Token: 0x06014A0E RID: 84494 RVA: 0x00603074 File Offset: 0x00601274
	private void OnButtonClickedCallback(int levelId)
	{
		bool isInfinite = this.ActivityDataBase.IsEndlessMode(levelId);
		if (!this.ActivityDataBase.GetLevelUnlockState(levelId, isInfinite))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsEnterLockTips", Array.Empty<object>());
			return;
		}
		SurvivorsLevel value = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(levelId).Value;
		SurvivorsRogueModel.Instance.SelectLevelInfo = this.LevelInfo;
		if (!this.LevelInfo.IsSaveFile)
		{
			this.LevelInfo.LevelId = levelId;
			this.LevelInfo.InstId = value.InstId;
			this.LevelInfo.IsEndless = this.ActivityDataBase.IsEndlessMode(levelId);
			UiManager.Instance.OpenView(EUiViewName.SurvivorsLevelDetailView, null, null);
			return;
		}
		if (this.LevelInfo.LevelId != levelId)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsEnterHasSaveTips", Array.Empty<object>());
			return;
		}
		SurvivorsExitViewParams param = new SurvivorsExitViewParams
		{
			IsExternal = true,
			Batch = this.LevelInfo.Batch,
			MaxBatch = this.LevelInfo.MaxBatch
		};
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueExitView, param, null);
	}

	// Token: 0x06014A0F RID: 84495 RVA: 0x0060318D File Offset: 0x0060138D
	private void OnCloseBtnClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014A10 RID: 84496 RVA: 0x00603198 File Offset: 0x00601398
	private void OnHelpBtnClicked()
	{
		SurvivorsActivityConfig? survivorsActivityConfig;
		int? num = (SurvivorsRogueModel.Instance.GetRogueActivityConfig() != null) ? new int?(survivorsActivityConfig.GetValueOrDefault().HelpId) : null;
		if (num != null)
		{
			HelpController.Instance.OpenHelpById(num.Value);
		}
	}

	// Token: 0x0400AF6D RID: 44909
	private readonly string[] diffIdToleSpineName = new string[]
	{
		"Idle1",
		"Idle2",
		"Idle3"
	};

	// Token: 0x0400AF6E RID: 44910
	private readonly string[] diffIdUnlockToSpineName = new string[]
	{
		"None",
		"Idle1to2",
		"Idle2to3"
	};

	// Token: 0x0400AF6F RID: 44911
	private const int CENTER_AREA_HALF_HEIGHT = 100;

	// Token: 0x0400AF70 RID: 44912
	protected SurvivorsActivityData ActivityDataBase;

	// Token: 0x0400AF71 RID: 44913
	protected UUIScrollViewWithScrollbarComponent ScrollViewComp;

	// Token: 0x0400AF72 RID: 44914
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x0400AF73 RID: 44915
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonTalentTree;

	// Token: 0x0400AF74 RID: 44916
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonHandbook;

	// Token: 0x0400AF75 RID: 44917
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonReward;

	// Token: 0x0400AF76 RID: 44918
	protected readonly Dictionary<int, SurvivorsLevelInfoItem> LevelInfoItemMap = new Dictionary<int, SurvivorsLevelInfoItem>();

	// Token: 0x0400AF77 RID: 44919
	protected readonly Dictionary<int, SurvivorsLevelItem> LevelItemMap = new Dictionary<int, SurvivorsLevelItem>();

	// Token: 0x0400AF78 RID: 44920
	private SurvivorsActivityDefine.SurvivorsLevelInfo LevelInfo;

	// Token: 0x0400AF79 RID: 44921
	[Nullable(2)]
	private UCurveFloat UiCurveAreaMove;

	// Token: 0x0400AF7A RID: 44922
	private readonly List<SurvivorsRogueParallaxItem> ItemParallaxList = new List<SurvivorsRogueParallaxItem>();

	// Token: 0x0400AF7B RID: 44923
	private float CenterPosY;

	// Token: 0x0400AF7C RID: 44924
	private float CenterAreaHalfHeight;

	// Token: 0x0400AF7D RID: 44925
	private float LastScrollValue = 0.001f;

	// Token: 0x0400AF7E RID: 44926
	protected float ScrollContentInitPosY;

	// Token: 0x0400AF7F RID: 44927
	protected float ScrollContentLastPosY;

	// Token: 0x0400AF80 RID: 44928
	protected bool IsDragging;

	// Token: 0x0400AF81 RID: 44929
	protected bool StartElasticMovement;

	// Token: 0x0400AF82 RID: 44930
	protected readonly List<SurvivorsRogueDiffAreaInfo> DiffAreaUiInfoList = new List<SurvivorsRogueDiffAreaInfo>();

	// Token: 0x0400AF83 RID: 44931
	protected int CurrentDiff = -1;

	// Token: 0x0400AF84 RID: 44932
	protected int CurrentUnlockDiff = -1;

	// Token: 0x0400AF85 RID: 44933
	private readonly float ChangeAreaDuration = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueChangeAreaDuration").GetValueOrDefault();

	// Token: 0x0400AF86 RID: 44934
	private readonly float AreaBottomScale = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueAreaBottomScale").GetValueOrDefault();

	// Token: 0x0400AF87 RID: 44935
	private readonly float BackgroundParallaxFactor = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueBackgroundParallaxFactor").GetValueOrDefault();

	// Token: 0x0400AF88 RID: 44936
	private readonly float AutoAttachVelocityY = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueAutoAttachVelocityY").GetValueOrDefault();

	// Token: 0x0400AF89 RID: 44937
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x0400AF8A RID: 44938
	private bool IsTweenerComplete = true;

	// Token: 0x0400AF8B RID: 44939
	private bool IsBindTweenerComplete;
}
