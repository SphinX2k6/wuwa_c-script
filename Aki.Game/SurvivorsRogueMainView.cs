using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B48 RID: 11080
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueMainView : UiTickViewBase
{
	// Token: 0x06016FAB RID: 94123 RVA: 0x005D4F84 File Offset: 0x005D3184
	public SurvivorsRogueMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016FAC RID: 94124 RVA: 0x005D5098 File Offset: 0x005D3298
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

	// Token: 0x06016FAD RID: 94125 RVA: 0x005D530C File Offset: 0x005D350C
	protected override UniTask OnCreateAsync()
	{
		SurvivorsRogueMainView.<OnCreateAsync>d__33 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<SurvivorsRogueMainView.<OnCreateAsync>d__33>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016FAE RID: 94126 RVA: 0x005D5350 File Offset: 0x005D3550
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueMainView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueMainView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016FAF RID: 94127 RVA: 0x005D5393 File Offset: 0x005D3593
	protected override void OnStart()
	{
		this.ScrollViewComp.OnLateUpdate.Bind(delegate(float _)
		{
			this.InitCurSelectPos();
			this.ScrollViewComp.OnLateUpdate.Unbind();
		});
	}

	// Token: 0x06016FB0 RID: 94128 RVA: 0x005D53B1 File Offset: 0x005D35B1
	protected override void OnBeforeShow()
	{
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
		this.RefreshFunctionButton();
		this.RefreshLevelInfo();
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06016FB1 RID: 94129 RVA: 0x005D53E4 File Offset: 0x005D35E4
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

	// Token: 0x06016FB2 RID: 94130 RVA: 0x005D5404 File Offset: 0x005D3604
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.SurvivorsInstSettle, new Action<bool>(this.OnSurvivorsInstSettle));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDay));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnSurvivorsRogueTalentNodeUpdate));
	}

	// Token: 0x06016FB3 RID: 94131 RVA: 0x005D549C File Offset: 0x005D369C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsInstSettle, new Action<bool>(this.OnSurvivorsInstSettle));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDay));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueTalentNodeUpdate, new Action<int>(this.OnSurvivorsRogueTalentNodeUpdate));
	}

	// Token: 0x06016FB4 RID: 94132 RVA: 0x005D5534 File Offset: 0x005D3734
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

	// Token: 0x06016FB5 RID: 94133 RVA: 0x005D55A8 File Offset: 0x005D37A8
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

	// Token: 0x06016FB6 RID: 94134 RVA: 0x005D55EC File Offset: 0x005D37EC
	protected override void OnTick(float delta)
	{
		foreach (SurvivorsLevelInfoItem survivorsLevelInfoItem in this.LevelInfoItemMap.Values)
		{
			survivorsLevelInfoItem.OnTick(delta);
		}
	}

	// Token: 0x06016FB7 RID: 94135 RVA: 0x005D5644 File Offset: 0x005D3844
	private void OnRefreshRedDot(int activityId)
	{
		if (this.ActivityDataBase.Id != activityId)
		{
			return;
		}
		this.RefreshFunctionButton();
	}

	// Token: 0x06016FB8 RID: 94136 RVA: 0x005D565C File Offset: 0x005D385C
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

	// Token: 0x06016FB9 RID: 94137 RVA: 0x005D56DE File Offset: 0x005D38DE
	private void OnViewClose(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.SurvivorsWeaponUnlockView)
		{
			return;
		}
		this.StartLevelUnlockFlow();
	}

	// Token: 0x06016FBA RID: 94138 RVA: 0x005D56F4 File Offset: 0x005D38F4
	private void OnSurvivorsRogueTalentNodeUpdate(int nodeId)
	{
		this.RefreshFunctionButton();
	}

	// Token: 0x06016FBB RID: 94139 RVA: 0x005D56FC File Offset: 0x005D38FC
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

	// Token: 0x06016FBC RID: 94140 RVA: 0x005D57D0 File Offset: 0x005D39D0
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

	// Token: 0x06016FBD RID: 94141 RVA: 0x005D5828 File Offset: 0x005D3A28
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

	// Token: 0x06016FBE RID: 94142 RVA: 0x005D58B0 File Offset: 0x005D3AB0
	private bool OnPointerBeginDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = true;
		return true;
	}

	// Token: 0x06016FBF RID: 94143 RVA: 0x005D58BA File Offset: 0x005D3ABA
	private bool OnPointerEndDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = false;
		this.StartElasticMovement = true;
		return true;
	}

	// Token: 0x06016FC0 RID: 94144 RVA: 0x005D58CC File Offset: 0x005D3ACC
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

	// Token: 0x06016FC1 RID: 94145 RVA: 0x005D597C File Offset: 0x005D3B7C
	private void UpdateParallaxItemPos(float posY)
	{
		for (int i = 0; i < this.ItemParallaxList.Count; i++)
		{
			SurvivorsRogueParallaxItem survivorsRogueParallaxItem = this.ItemParallaxList[i];
			float val = survivorsRogueParallaxItem.InitPosY + (posY - this.ScrollContentInitPosY) * survivorsRogueParallaxItem.ParallaxFactor;
			survivorsRogueParallaxItem.Item.SetAnchorOffsetY(Math.Max(0f, val));
		}
	}

	// Token: 0x06016FC2 RID: 94146 RVA: 0x005D59DC File Offset: 0x005D3BDC
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

	// Token: 0x06016FC3 RID: 94147 RVA: 0x005D5A8C File Offset: 0x005D3C8C
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

	// Token: 0x06016FC4 RID: 94148 RVA: 0x005D5B0E File Offset: 0x005D3D0E
	private void ScrollTweenerStart()
	{
		this.IsTweenerComplete = false;
		this.ScrollViewComp.SetRayCastTargetForScrollView(false);
		this.SetLevelItemInteractive(false);
	}

	// Token: 0x06016FC5 RID: 94149 RVA: 0x005D5B2A File Offset: 0x005D3D2A
	protected void ScrollTweenerEnd()
	{
		this.IsTweenerComplete = true;
		this.ScrollViewComp.SetRayCastTargetForScrollView(true);
		this.SetLevelItemInteractive(true);
	}

	// Token: 0x06016FC6 RID: 94150 RVA: 0x005D5B48 File Offset: 0x005D3D48
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

	// Token: 0x06016FC7 RID: 94151 RVA: 0x005D5B94 File Offset: 0x005D3D94
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

	// Token: 0x06016FC8 RID: 94152 RVA: 0x005D5BB7 File Offset: 0x005D3DB7
	private void TweenerComplete()
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		this.ScrollTweenerEnd();
	}

	// Token: 0x06016FC9 RID: 94153 RVA: 0x005D5BC8 File Offset: 0x005D3DC8
	private bool IsTopArea()
	{
		return this.CurrentDiff == 2;
	}

	// Token: 0x06016FCA RID: 94154 RVA: 0x005D5BD3 File Offset: 0x005D3DD3
	private bool IsBottomArea()
	{
		return this.CurrentDiff == 0;
	}

	// Token: 0x06016FCB RID: 94155 RVA: 0x005D5BE0 File Offset: 0x005D3DE0
	private UniTask InitAllLevel()
	{
		SurvivorsRogueMainView.<InitAllLevel>d__63 <InitAllLevel>d__;
		<InitAllLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllLevel>d__.<>4__this = this;
		<InitAllLevel>d__.<>1__state = -1;
		<InitAllLevel>d__.<>t__builder.Start<SurvivorsRogueMainView.<InitAllLevel>d__63>(ref <InitAllLevel>d__);
		return <InitAllLevel>d__.<>t__builder.Task;
	}

	// Token: 0x06016FCC RID: 94156 RVA: 0x005D5C24 File Offset: 0x005D3E24
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

	// Token: 0x06016FCD RID: 94157 RVA: 0x005D5D40 File Offset: 0x005D3F40
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

	// Token: 0x06016FCE RID: 94158 RVA: 0x005D5D88 File Offset: 0x005D3F88
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

	// Token: 0x06016FCF RID: 94159 RVA: 0x005D5E18 File Offset: 0x005D4018
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

	// Token: 0x06016FD0 RID: 94160 RVA: 0x005D5E90 File Offset: 0x005D4090
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

	// Token: 0x06016FD1 RID: 94161 RVA: 0x005D5F04 File Offset: 0x005D4104
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

	// Token: 0x06016FD2 RID: 94162 RVA: 0x005D5FD8 File Offset: 0x005D41D8
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

	// Token: 0x06016FD3 RID: 94163 RVA: 0x005D6014 File Offset: 0x005D4214
	private void SetLevelItemInteractive(bool enable)
	{
		foreach (SurvivorsLevelItem survivorsLevelItem in this.LevelItemMap.Values)
		{
			survivorsLevelItem.SetButtonInteractive(enable);
		}
	}

	// Token: 0x06016FD4 RID: 94164 RVA: 0x005D606C File Offset: 0x005D426C
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

	// Token: 0x06016FD5 RID: 94165 RVA: 0x005D61B0 File Offset: 0x005D43B0
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

	// Token: 0x06016FD6 RID: 94166 RVA: 0x005D625C File Offset: 0x005D445C
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

	// Token: 0x06016FD7 RID: 94167 RVA: 0x005D63C0 File Offset: 0x005D45C0
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

	// Token: 0x06016FD8 RID: 94168 RVA: 0x005D63DE File Offset: 0x005D45DE
	private void OnClickedBtnHandbook()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsHandbookView, null, null);
	}

	// Token: 0x06016FD9 RID: 94169 RVA: 0x005D63F1 File Offset: 0x005D45F1
	private void OnClickedBtnTalentTree()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTalentTreeView, null, null);
	}

	// Token: 0x06016FDA RID: 94170 RVA: 0x005D6404 File Offset: 0x005D4604
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

	// Token: 0x06016FDB RID: 94171 RVA: 0x005D6450 File Offset: 0x005D4650
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

	// Token: 0x06016FDC RID: 94172 RVA: 0x005D649C File Offset: 0x005D469C
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

	// Token: 0x06016FDD RID: 94173 RVA: 0x005D6508 File Offset: 0x005D4708
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

	// Token: 0x06016FDE RID: 94174 RVA: 0x005D6621 File Offset: 0x005D4821
	private void OnCloseBtnClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016FDF RID: 94175 RVA: 0x005D662C File Offset: 0x005D482C
	private void OnHelpBtnClicked()
	{
		SurvivorsActivityConfig? survivorsActivityConfig;
		int? num = (SurvivorsRogueModel.Instance.GetRogueActivityConfig() != null) ? new int?(survivorsActivityConfig.GetValueOrDefault().HelpId) : null;
		if (num != null)
		{
			HelpController.Instance.OpenHelpById(num.Value);
		}
	}

	// Token: 0x0400AB67 RID: 43879
	private readonly string[] diffIdToleSpineName = new string[]
	{
		"Idle1",
		"Idle2",
		"Idle3"
	};

	// Token: 0x0400AB68 RID: 43880
	private readonly string[] diffIdUnlockToSpineName = new string[]
	{
		"None",
		"Idle1to2",
		"Idle2to3"
	};

	// Token: 0x0400AB69 RID: 43881
	private const int CENTER_AREA_HALF_HEIGHT = 100;

	// Token: 0x0400AB6A RID: 43882
	protected SurvivorsActivityData ActivityDataBase;

	// Token: 0x0400AB6B RID: 43883
	protected UUIScrollViewWithScrollbarComponent ScrollViewComp;

	// Token: 0x0400AB6C RID: 43884
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x0400AB6D RID: 43885
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonTalentTree;

	// Token: 0x0400AB6E RID: 43886
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonHandbook;

	// Token: 0x0400AB6F RID: 43887
	[Nullable(2)]
	protected SurvivorsFunctionButtonItem ButtonReward;

	// Token: 0x0400AB70 RID: 43888
	protected readonly Dictionary<int, SurvivorsLevelInfoItem> LevelInfoItemMap = new Dictionary<int, SurvivorsLevelInfoItem>();

	// Token: 0x0400AB71 RID: 43889
	protected readonly Dictionary<int, SurvivorsLevelItem> LevelItemMap = new Dictionary<int, SurvivorsLevelItem>();

	// Token: 0x0400AB72 RID: 43890
	private SurvivorsActivityDefine.SurvivorsLevelInfo LevelInfo;

	// Token: 0x0400AB73 RID: 43891
	[Nullable(2)]
	private UCurveFloat UiCurveAreaMove;

	// Token: 0x0400AB74 RID: 43892
	private readonly List<SurvivorsRogueParallaxItem> ItemParallaxList = new List<SurvivorsRogueParallaxItem>();

	// Token: 0x0400AB75 RID: 43893
	private float CenterPosY;

	// Token: 0x0400AB76 RID: 43894
	private float CenterAreaHalfHeight;

	// Token: 0x0400AB77 RID: 43895
	private float LastScrollValue = 0.001f;

	// Token: 0x0400AB78 RID: 43896
	protected float ScrollContentInitPosY;

	// Token: 0x0400AB79 RID: 43897
	protected float ScrollContentLastPosY;

	// Token: 0x0400AB7A RID: 43898
	protected bool IsDragging;

	// Token: 0x0400AB7B RID: 43899
	protected bool StartElasticMovement;

	// Token: 0x0400AB7C RID: 43900
	protected readonly List<SurvivorsRogueDiffAreaInfo> DiffAreaUiInfoList = new List<SurvivorsRogueDiffAreaInfo>();

	// Token: 0x0400AB7D RID: 43901
	protected int CurrentDiff = -1;

	// Token: 0x0400AB7E RID: 43902
	protected int CurrentUnlockDiff = -1;

	// Token: 0x0400AB7F RID: 43903
	private readonly float ChangeAreaDuration = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueChangeAreaDuration").GetValueOrDefault();

	// Token: 0x0400AB80 RID: 43904
	private readonly float AreaBottomScale = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueAreaBottomScale").GetValueOrDefault();

	// Token: 0x0400AB81 RID: 43905
	private readonly float BackgroundParallaxFactor = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueBackgroundParallaxFactor").GetValueOrDefault();

	// Token: 0x0400AB82 RID: 43906
	private readonly float AutoAttachVelocityY = ConfigCommonParamById.GetFloatConfig("SurvivorsRogueAutoAttachVelocityY").GetValueOrDefault();

	// Token: 0x0400AB83 RID: 43907
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x0400AB84 RID: 43908
	private bool IsTweenerComplete = true;

	// Token: 0x0400AB85 RID: 43909
	private bool IsBindTweenerComplete;
}
