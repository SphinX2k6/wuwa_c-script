using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CEA RID: 7402
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerPrepareView : UiViewBase
{
	// Token: 0x06012518 RID: 75032 RVA: 0x005674CB File Offset: 0x005656CB
	public RoleTowerPrepareView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B71 RID: 7025
	// (get) Token: 0x06012519 RID: 75033 RVA: 0x005674F1 File Offset: 0x005656F1
	[Nullable(2)]
	private new RoleTowerPrepareViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as RoleTowerPrepareViewParams;
		}
	}

	// Token: 0x0601251A RID: 75034 RVA: 0x00567500 File Offset: 0x00565700
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickTeamBuff)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickCurrentStage))
		};
	}

	// Token: 0x0601251B RID: 75035 RVA: 0x0056761C File Offset: 0x0056581C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerPrepareView.<OnBeforeStartAsync>d__37 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerPrepareView.<OnBeforeStartAsync>d__37>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601251C RID: 75036 RVA: 0x00567660 File Offset: 0x00565860
	private static bool IsActivityMainViewExist()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.RoleTowerActivityView);
		return viewByName != null && !viewByName.IsPreOpening && !viewByName.WaitToDestroy && !viewByName.IsDestroyOrDestroying;
	}

	// Token: 0x0601251D RID: 75037 RVA: 0x0056769C File Offset: 0x0056589C
	protected override void OnStart()
	{
		if (RoleTowerModel.Instance.IsInRoleTowerDungeon())
		{
			foreach (int id in new List<int>(BulletModel.Instance.GetBulletEntityMap().Keys))
			{
				BulletController.Instance.DestroyBullet(id, false, EBulletDestroyReason.Normal, false);
			}
		}
		UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		}
		UUIScrollViewWithScrollbarComponent scrollView2 = this.ScrollView;
		if (scrollView2 != null)
		{
			scrollView2.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnScrollBeginDrag));
		}
		UUIScrollViewWithScrollbarComponent scrollView3 = this.ScrollView;
		if (scrollView3 != null)
		{
			scrollView3.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnScrollEndDrag));
		}
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnSnapTick), "RoleTowerPrepareView", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.SnapTickId = ((ticker != null) ? ticker.Id : -1);
		this.InitSelectStage();
		this.InitScrollPending = true;
		this.InitScrollElapsedMs = 0f;
		this.InitScrollFrames = 0;
	}

	// Token: 0x0601251E RID: 75038 RVA: 0x005677C8 File Offset: 0x005659C8
	protected override void OnBeforeDestroy()
	{
		RoleTowerPrepareViewParams openParam = this.OpenParam;
		if (openParam != null && openParam.IsCheckPoint)
		{
			RoleTowerModel.Instance.CloseCheckPointView();
		}
		UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.OnScrollValueChange.Unbind();
		}
		UUIScrollViewWithScrollbarComponent scrollView2 = this.ScrollView;
		if (scrollView2 != null)
		{
			scrollView2.OnPointerBeginDragCallBack.Unbind();
		}
		UUIScrollViewWithScrollbarComponent scrollView3 = this.ScrollView;
		if (scrollView3 != null)
		{
			scrollView3.OnPointerEndDragCallBack.Unbind();
		}
		if (this.SnapTickId != -1)
		{
			TickSystem.Instance.Remove(this.SnapTickId);
			this.SnapTickId = -1;
		}
	}

	// Token: 0x0601251F RID: 75039 RVA: 0x00567856 File Offset: 0x00565A56
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerLevelUpdate, new Action<int>(this.OnStageSelectChanged));
	}

	// Token: 0x06012520 RID: 75040 RVA: 0x00567874 File Offset: 0x00565A74
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerLevelUpdate, new Action<int>(this.OnStageSelectChanged));
	}

	// Token: 0x06012521 RID: 75041 RVA: 0x00567892 File Offset: 0x00565A92
	protected override void OnBeforeShow()
	{
		this.RefreshStageList();
		this.RefreshRemainTime();
		this.RefreshAllPanels();
	}

	// Token: 0x06012522 RID: 75042 RVA: 0x005678A8 File Offset: 0x00565AA8
	private UniTask LoadCurves()
	{
		RoleTowerPrepareView.<LoadCurves>d__44 <LoadCurves>d__;
		<LoadCurves>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCurves>d__.<>4__this = this;
		<LoadCurves>d__.<>1__state = -1;
		<LoadCurves>d__.<>t__builder.Start<RoleTowerPrepareView.<LoadCurves>d__44>(ref <LoadCurves>d__);
		return <LoadCurves>d__.<>t__builder.Task;
	}

	// Token: 0x06012523 RID: 75043 RVA: 0x005678EC File Offset: 0x00565AEC
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<UCurveFloat> LoadCurveByResId(string resId)
	{
		RoleTowerPrepareView.<LoadCurveByResId>d__45 <LoadCurveByResId>d__;
		<LoadCurveByResId>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveByResId>d__.resId = resId;
		<LoadCurveByResId>d__.<>1__state = -1;
		<LoadCurveByResId>d__.<>t__builder.Start<RoleTowerPrepareView.<LoadCurveByResId>d__45>(ref <LoadCurveByResId>d__);
		return <LoadCurveByResId>d__.<>t__builder.Task;
	}

	// Token: 0x06012524 RID: 75044 RVA: 0x00567930 File Offset: 0x00565B30
	private void InitScrollGeometry()
	{
		this.ScrollView = base.GetScrollViewWithScrollbar(4);
		if (this.ScrollView == null)
		{
			return;
		}
		AUIBaseActor auibaseActor = this.ScrollView.Content.Get();
		this.ContentItem = ((auibaseActor != null) ? auibaseActor.GetUIItem() : null);
		if (this.ContentItem == null)
		{
			return;
		}
		this.ViewportWidth = this.ScrollView.GetViewport().GetUIItem().GetWidth();
		this.ScrollView.SetRayCastTargetForScrollView(true);
	}

	// Token: 0x06012525 RID: 75045 RVA: 0x005679A8 File Offset: 0x00565BA8
	private UniTask CreateAllStageNodes()
	{
		RoleTowerPrepareView.<CreateAllStageNodes>d__47 <CreateAllStageNodes>d__;
		<CreateAllStageNodes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllStageNodes>d__.<>4__this = this;
		<CreateAllStageNodes>d__.<>1__state = -1;
		<CreateAllStageNodes>d__.<>t__builder.Start<RoleTowerPrepareView.<CreateAllStageNodes>d__47>(ref <CreateAllStageNodes>d__);
		return <CreateAllStageNodes>d__.<>t__builder.Task;
	}

	// Token: 0x06012526 RID: 75046 RVA: 0x005679EC File Offset: 0x00565BEC
	private void RefreshContentWidth()
	{
		if (this.ContentItem == null)
		{
			return;
		}
		int count = this.StageUiItems.Count;
		float num = (float)count * 667f;
		if (count > 1 && num <= this.ViewportWidth)
		{
			num = this.ViewportWidth + 667f;
		}
		this.ContentItem.SetWidth(num);
	}

	// Token: 0x06012527 RID: 75047 RVA: 0x00567A3C File Offset: 0x00565C3C
	private void InitSelectStage()
	{
		RoleTowerPrepareViewParams openParam = this.OpenParam;
		int num = (openParam != null) ? openParam.LevelId : RoleTowerModel.Instance.CurSelectLevel;
		RoleTowerModel.Instance.CurSelectLevel = num;
		RoleTowerModel.Instance.CurSelectStage = this.GetChallengeableStageId(num);
	}

	// Token: 0x06012528 RID: 75048 RVA: 0x00567A81 File Offset: 0x00565C81
	private int GetChallengeableStageId(int levelId)
	{
		return RoleTowerModel.Instance.GetChallengeableStageId(levelId);
	}

	// Token: 0x06012529 RID: 75049 RVA: 0x00567A90 File Offset: 0x00565C90
	private void RefreshStageList()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int curSelectStage = RoleTowerModel.Instance.CurSelectStage;
		int challengeableStageId = RoleTowerModel.Instance.GetChallengeableStageId(curSelectLevel);
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = RoleTowerModel.Instance.GetStageCfgListByLevel(curSelectLevel);
		int num = Math.Min(stageCfgListByLevel.Count, this.StageNodes.Count);
		for (int i = 0; i < num; i++)
		{
			RoleTowerStageNodeData data = new RoleTowerStageNodeData
			{
				StageId = stageCfgListByLevel[i].Id,
				StageSeq = i + 1,
				IsChallengeable = (stageCfgListByLevel[i].Id == challengeableStageId)
			};
			this.StageNodes[i].Refresh(data, stageCfgListByLevel[i].Id == curSelectStage);
		}
		this.UpdateStageNodesByCurve(this.DisplayScrollProgress);
		this.RefreshCurrentStageBtn();
	}

	// Token: 0x0601252A RID: 75050 RVA: 0x00567B70 File Offset: 0x00565D70
	private void RefreshCurrentStageBtn()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int curSelectStage = RoleTowerModel.Instance.CurSelectStage;
		int challengeableStageId = RoleTowerModel.Instance.GetChallengeableStageId(curSelectLevel);
		bool uiactive = challengeableStageId > 0 && curSelectStage != challengeableStageId;
		UUIButtonComponent button = base.GetButton(8);
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

	// Token: 0x0601252B RID: 75051 RVA: 0x00567BD4 File Offset: 0x00565DD4
	private void RefreshRemainTime()
	{
		RoleTowerPrepareViewParams openParam = this.OpenParam;
		bool flag = openParam != null && openParam.IsInPrepare;
		RoleTowerPrepareViewParams openParam2 = this.OpenParam;
		bool flag2 = openParam2 != null && openParam2.IsCheckPoint;
		RoleTowerSaveData curChallengeSave = RoleTowerModel.Instance.GetCurChallengeSave();
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		long ms;
		if (flag2)
		{
			ms = RoleTowerModel.Instance.GetCheckPointRemainTime();
		}
		else if (flag)
		{
			ms = RoleTowerModel.Instance.GetDungeonRemainTime();
		}
		else if (curChallengeSave != null)
		{
			ms = curChallengeSave.DungeonRemainTime;
		}
		else
		{
			RoleTowerPrepareViewParams openParam3 = this.OpenParam;
			int id = (openParam3 != null) ? openParam3.LevelId : RoleTowerModel.Instance.CurSelectLevel;
			RoleTowerLevel? roleTowerLevel;
			ms = (long)((RoleTowerModel.Instance.GetLevelCfg(id) != null) ? roleTowerLevel.GetValueOrDefault().InitTime : 0);
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(RoleTowerTimeUtil.Format(ms), true);
	}

	// Token: 0x0601252C RID: 75052 RVA: 0x00567CB0 File Offset: 0x00565EB0
	private void RefreshAllPanels()
	{
		int curSelectStage = RoleTowerModel.Instance.CurSelectStage;
		RoleTowerPrepareViewParams openParam = this.OpenParam;
		bool isInPrepare = openParam != null && openParam.IsInPrepare;
		RoleTowerPrepareViewParams openParam2 = this.OpenParam;
		bool isCheckPoint = openParam2 != null && openParam2.IsCheckPoint;
		RoleTowerPrepareRightPanel rightPanel = this.RightPanel;
		if (rightPanel != null)
		{
			rightPanel.Refresh(curSelectStage);
		}
		RoleTowerPrepareBottomPanel bottomPanel = this.BottomPanel;
		if (bottomPanel == null)
		{
			return;
		}
		bottomPanel.Refresh(curSelectStage, isInPrepare, isCheckPoint);
	}

	// Token: 0x0601252D RID: 75053 RVA: 0x00567D13 File Offset: 0x00565F13
	private void OnStageSelectChanged(int stageId)
	{
		RoleTowerModel.Instance.CurSelectStage = stageId;
		this.RefreshStageList();
		this.RefreshAllPanels();
		if (this.IsDragging || this.InitScrollPending)
		{
			return;
		}
		this.ScrollToSelectStage(true);
	}

	// Token: 0x0601252E RID: 75054 RVA: 0x00567D44 File Offset: 0x00565F44
	private void SetStageNodeOffset(UUIItem item, int index, int totalCount, float stepOffset, float contentOffsetX)
	{
		if (totalCount - 1 <= 0)
		{
			return;
		}
		float num = ((float)index - stepOffset) * this.GetStepSpacingX();
		float inX = this.GetLeftEdgeX() + num - contentOffsetX;
		float inY = (this.StageXYCurve != null) ? this.StageXYCurve.GetFloatValue(num) : 0f;
		item.SetAnchorOffset(new FVector2D(inX, inY));
		this.ApplyStageNodeVisual(item, num);
	}

	// Token: 0x0601252F RID: 75055 RVA: 0x00567DA4 File Offset: 0x00565FA4
	private void ApplyStageNodeVisual(UUIItem item, float centerDistanceX)
	{
		if (this.StageAlphaCurve != null)
		{
			item.SetAlpha(this.StageAlphaCurve.GetFloatValue(centerDistanceX));
		}
		if (this.StageScaleCurve != null)
		{
			float floatValue = this.StageScaleCurve.GetFloatValue(centerDistanceX);
			item.SetRelativeScale3D(new FVector(floatValue, floatValue, floatValue));
		}
	}

	// Token: 0x06012530 RID: 75056 RVA: 0x00567DEE File Offset: 0x00565FEE
	private float GetStepSpacingX()
	{
		return ((this.StageUiItems.Count > 0) ? this.StageUiItems[0].GetWidth() : 0f) + 40f;
	}

	// Token: 0x06012531 RID: 75057 RVA: 0x00567E1C File Offset: 0x0056601C
	private float GetLeftEdgeX()
	{
		return this.GetViewportCenterX();
	}

	// Token: 0x06012532 RID: 75058 RVA: 0x00567E24 File Offset: 0x00566024
	private float GetViewportCenterX()
	{
		return this.ViewportWidth / 2f;
	}

	// Token: 0x06012533 RID: 75059 RVA: 0x00567E34 File Offset: 0x00566034
	private void UpdateStageNodesByCurve(float scrollProgress)
	{
		if (this.StageUiItems.Count == 0)
		{
			return;
		}
		int totalStepCount = this.StageUiItems.Count - 1;
		float maxStepOffset = this.GetMaxStepOffset(totalStepCount);
		float stepOffset = scrollProgress * Math.Max(maxStepOffset, 0f);
		float contentOffsetX = (this.ContentItem != null) ? this.ContentItem.GetAnchorOffsetX() : 0f;
		for (int i = 0; i < this.StageUiItems.Count; i++)
		{
			this.SetStageNodeOffset(this.StageUiItems[i], i, this.StageUiItems.Count, stepOffset, contentOffsetX);
		}
		this.UpdateCenterStageNode(scrollProgress);
	}

	// Token: 0x06012534 RID: 75060 RVA: 0x00567ED4 File Offset: 0x005660D4
	private void UpdateCenterStageNode(float scrollProgress)
	{
		if (!this.IsCenterTrackEnabled || this.StageNodes.Count == 0)
		{
			return;
		}
		int num = (int)Math.Round((double)(scrollProgress * (float)(this.StageNodes.Count - 1)));
		num = Math.Clamp(num, 0, this.StageNodes.Count - 1);
		for (int i = 0; i < this.StageNodes.Count; i++)
		{
			this.StageNodes[i].SetCentered(i == num);
		}
	}

	// Token: 0x06012535 RID: 75061 RVA: 0x00567F4F File Offset: 0x0056614F
	private void EnableCenterTrack()
	{
		if (this.IsCenterTrackEnabled)
		{
			return;
		}
		this.IsCenterTrackEnabled = true;
		this.UpdateCenterStageNode(this.DisplayScrollProgress);
	}

	// Token: 0x06012536 RID: 75062 RVA: 0x00567F70 File Offset: 0x00566170
	private void OnScrollValueChange(FVector2D progress)
	{
		if (this.StageXYCurve == null || this.StageUiItems.Count == 0 || this.ScrollView == null)
		{
			return;
		}
		float num = MathUtils.Instance.Clamp(this.ScrollView.Horizontal ? progress.X : progress.Y, 0f, 1f);
		float num2 = 1f - num;
		this.DisplayScrollProgress = num2;
		this.UpdateStageNodesByCurve(num2);
	}

	// Token: 0x06012537 RID: 75063 RVA: 0x00567FE4 File Offset: 0x005661E4
	private void ScrollToSelectStage(bool smooth = false)
	{
		if (this.StageUiItems.Count == 0 || this.ScrollView == null)
		{
			return;
		}
		int selectStageIndex = this.GetSelectStageIndex();
		float scrollProgressByIndex = this.GetScrollProgressByIndex(selectStageIndex);
		if (smooth)
		{
			this.StartSnapTween(scrollProgressByIndex);
			return;
		}
		this.IsSnapping = false;
		this.ApplyScrollProgress(scrollProgressByIndex);
	}

	// Token: 0x06012538 RID: 75064 RVA: 0x0056802F File Offset: 0x0056622F
	private void ApplyScrollProgress(float progress)
	{
		this.DisplayScrollProgress = progress;
		this.SyncScrollProgress(progress);
		this.UpdateStageNodesByCurve(progress);
	}

	// Token: 0x06012539 RID: 75065 RVA: 0x00568046 File Offset: 0x00566246
	private bool OnScrollBeginDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = true;
		this.InitScrollPending = false;
		this.EnableCenterTrack();
		this.WaitSnap = false;
		this.IsSnapping = false;
		return true;
	}

	// Token: 0x0601253A RID: 75066 RVA: 0x0056806B File Offset: 0x0056626B
	private bool OnScrollEndDrag(ULGUIPointerEventData _)
	{
		this.IsDragging = false;
		this.WaitSnap = true;
		return true;
	}

	// Token: 0x0601253B RID: 75067 RVA: 0x0056807C File Offset: 0x0056627C
	private void OnSnapTick(float delta)
	{
		if (this.InitScrollPending)
		{
			this.UpdateInitScroll(delta);
			return;
		}
		if (this.IsSnapping)
		{
			this.UpdateSnapTween(delta);
			return;
		}
		if (!this.WaitSnap || this.IsDragging || this.ScrollView == null)
		{
			return;
		}
		FVector2D velocity = this.ScrollView.GetVelocity();
		if (Math.Abs(this.ScrollView.Horizontal ? velocity.X : velocity.Y) >= 100f)
		{
			return;
		}
		this.WaitSnap = false;
		this.ScrollView.StopMovement();
		this.SnapToNearestStage();
	}

	// Token: 0x0601253C RID: 75068 RVA: 0x00568110 File Offset: 0x00566310
	private void UpdateInitScroll(float deltaMs)
	{
		this.InitScrollElapsedMs += deltaMs;
		this.InitScrollFrames++;
		UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
		float? num;
		if (scrollView == null)
		{
			num = null;
		}
		else
		{
			AUIBaseActor viewport = scrollView.GetViewport();
			if (viewport == null)
			{
				num = null;
			}
			else
			{
				UUIItem uiitem = viewport.GetUIItem();
				num = ((uiitem != null) ? new float?(uiitem.GetWidth()) : null);
			}
		}
		float? num2 = num;
		float valueOrDefault = num2.GetValueOrDefault();
		if (valueOrDefault > 0f && valueOrDefault != this.ViewportWidth)
		{
			this.ViewportWidth = valueOrDefault;
			this.RefreshContentWidth();
		}
		this.ScrollToSelectStage(false);
		if (this.InitScrollElapsedMs >= 300f && this.InitScrollFrames >= 5)
		{
			this.InitScrollPending = false;
			this.EnableCenterTrack();
		}
	}

	// Token: 0x0601253D RID: 75069 RVA: 0x005681D4 File Offset: 0x005663D4
	private void SnapToNearestStage()
	{
		int count = this.StageUiItems.Count;
		if (count == 0)
		{
			return;
		}
		int num = (int)Math.Round((double)(this.DisplayScrollProgress * (float)(count - 1)));
		num = Math.Clamp(num, 0, count - 1);
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = RoleTowerModel.Instance.GetStageCfgListByLevel(RoleTowerModel.Instance.CurSelectLevel);
		if (num < stageCfgListByLevel.Count && stageCfgListByLevel[num].Id != RoleTowerModel.Instance.CurSelectStage)
		{
			RoleTowerModel.Instance.SelectStage(stageCfgListByLevel[num].Id);
			return;
		}
		this.StartSnapTween(this.GetScrollProgressByIndex(num));
	}

	// Token: 0x0601253E RID: 75070 RVA: 0x00568270 File Offset: 0x00566470
	private void StartSnapTween(float targetProgress)
	{
		this.WaitSnap = false;
		UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.StopMovement();
		}
		if (Math.Abs(targetProgress - this.DisplayScrollProgress) < 0.0001f)
		{
			this.IsSnapping = false;
			this.ApplyScrollProgress(targetProgress);
			return;
		}
		this.SnapFromProgress = this.DisplayScrollProgress;
		this.SnapToProgress = targetProgress;
		this.SnapElapsed = 0f;
		this.IsSnapping = true;
	}

	// Token: 0x0601253F RID: 75071 RVA: 0x005682E0 File Offset: 0x005664E0
	private void UpdateSnapTween(float deltaMs)
	{
		this.SnapElapsed += deltaMs;
		float num = MathUtils.Instance.Clamp(this.SnapElapsed / 250f, 0f, 1f);
		float num2 = 1f - (1f - num) * (1f - num) * (1f - num);
		this.ApplyScrollProgress(this.SnapFromProgress + (this.SnapToProgress - this.SnapFromProgress) * num2);
		if (num >= 1f)
		{
			this.IsSnapping = false;
		}
	}

	// Token: 0x06012540 RID: 75072 RVA: 0x00568368 File Offset: 0x00566568
	private int GetSelectStageIndex()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int curSelectStage = RoleTowerModel.Instance.CurSelectStage;
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = RoleTowerModel.Instance.GetStageCfgListByLevel(curSelectLevel);
		for (int i = 0; i < stageCfgListByLevel.Count; i++)
		{
			if (stageCfgListByLevel[i].Id == curSelectStage)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x06012541 RID: 75073 RVA: 0x005683C0 File Offset: 0x005665C0
	private float GetScrollProgressByIndex(int targetIndex)
	{
		int num = this.StageUiItems.Count - 1;
		if (num <= 0)
		{
			return 0f;
		}
		float maxStepOffset = this.GetMaxStepOffset(num);
		if (maxStepOffset <= 0f)
		{
			return 0f;
		}
		float stepSpacingX = this.GetStepSpacingX();
		if (stepSpacingX <= 0f)
		{
			return 0f;
		}
		float num2 = (float)targetIndex - (this.GetViewportCenterX() - this.GetLeftEdgeX()) / stepSpacingX;
		return MathUtils.Instance.Clamp(num2 / maxStepOffset, 0f, 1f);
	}

	// Token: 0x06012542 RID: 75074 RVA: 0x0056843A File Offset: 0x0056663A
	private float GetMaxStepOffset(int totalStepCount)
	{
		if (totalStepCount <= 0)
		{
			return 0f;
		}
		return (float)totalStepCount;
	}

	// Token: 0x06012543 RID: 75075 RVA: 0x00568448 File Offset: 0x00566648
	private void SyncScrollProgress(float scrollProgress)
	{
		if (this.ScrollView == null)
		{
			return;
		}
		float num = MathUtils.Instance.Clamp(scrollProgress, 0f, 1f);
		float scrollProgress2 = this.ScrollView.Horizontal ? (1f - num) : num;
		this.ScrollView.SetScrollProgress(scrollProgress2);
	}

	// Token: 0x06012544 RID: 75076 RVA: 0x00568498 File Offset: 0x00566698
	private void OnClickTeamBuff()
	{
		if (RoleTowerModel.Instance.GetTeamRoleIds().Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerTeamEmpty", Array.Empty<object>());
			return;
		}
		RoleTowerPrepareViewParams openParam = this.OpenParam;
		bool flag;
		if (openParam == null || !openParam.IsInPrepare)
		{
			RoleTowerPrepareViewParams openParam2 = this.OpenParam;
			if (openParam2 == null || !openParam2.IsCheckPoint)
			{
				RoleTowerPrepareViewParams openParam3 = this.OpenParam;
				if (openParam3 == null || !openParam3.IsFromSave)
				{
					flag = RoleTowerModel.Instance.IsInRoleTowerDungeon();
					goto IL_6F;
				}
			}
		}
		flag = false;
		IL_6F:
		bool useInitInstData = flag;
		RoleTowerModel.Instance.OpenStarEchoView(ERoleTowerStarEchoTab.Star, useInitInstData);
	}

	// Token: 0x06012545 RID: 75077 RVA: 0x00568524 File Offset: 0x00566724
	private void OnClickCurrentStage()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int challengeableStageId = RoleTowerModel.Instance.GetChallengeableStageId(curSelectLevel);
		if (challengeableStageId <= 0)
		{
			return;
		}
		RoleTowerModel.Instance.SelectStage(challengeableStageId);
		this.FocusStageNode(challengeableStageId);
	}

	// Token: 0x06012546 RID: 75078 RVA: 0x00568560 File Offset: 0x00566760
	private void FocusStageNode(int stageId)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		foreach (RoleTowerStageNode roleTowerStageNode in this.StageNodes)
		{
			if (roleTowerStageNode.StageId == stageId)
			{
				UUIItem togUiItem = roleTowerStageNode.GetTogUiItem();
				if (togUiItem != null)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(togUiItem, true, false, false);
				}
				break;
			}
		}
	}

	// Token: 0x04009FC0 RID: 40896
	private const int STAGE_STEP_GAP_X = 40;

	// Token: 0x04009FC1 RID: 40897
	private const float CONTENT_WIDTH_PER_STAGE = 667f;

	// Token: 0x04009FC2 RID: 40898
	private const string AlphaCurveResId = "Curve_MowingTowerAlpha";

	// Token: 0x04009FC3 RID: 40899
	private const string ScaleCurveResId = "Curve_MowingTowerScale";

	// Token: 0x04009FC4 RID: 40900
	private const string XYCurveResId = "Curve_MowingTowerXY";

	// Token: 0x04009FC5 RID: 40901
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04009FC6 RID: 40902
	[Nullable(2)]
	private RoleTowerPrepareRightPanel RightPanel;

	// Token: 0x04009FC7 RID: 40903
	[Nullable(2)]
	private RoleTowerPrepareBottomPanel BottomPanel;

	// Token: 0x04009FC8 RID: 40904
	private readonly List<RoleTowerStageNode> StageNodes = new List<RoleTowerStageNode>();

	// Token: 0x04009FC9 RID: 40905
	private readonly List<UUIItem> StageUiItems = new List<UUIItem>();

	// Token: 0x04009FCA RID: 40906
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04009FCB RID: 40907
	[Nullable(2)]
	private UUIItem ContentItem;

	// Token: 0x04009FCC RID: 40908
	[Nullable(2)]
	private UCurveFloat StageXYCurve;

	// Token: 0x04009FCD RID: 40909
	[Nullable(2)]
	private UCurveFloat StageAlphaCurve;

	// Token: 0x04009FCE RID: 40910
	[Nullable(2)]
	private UCurveFloat StageScaleCurve;

	// Token: 0x04009FCF RID: 40911
	private float ViewportWidth;

	// Token: 0x04009FD0 RID: 40912
	private float DisplayScrollProgress;

	// Token: 0x04009FD1 RID: 40913
	private bool IsCenterTrackEnabled;

	// Token: 0x04009FD2 RID: 40914
	private bool InitScrollPending;

	// Token: 0x04009FD3 RID: 40915
	private float InitScrollElapsedMs;

	// Token: 0x04009FD4 RID: 40916
	private int InitScrollFrames;

	// Token: 0x04009FD5 RID: 40917
	private const float InitScrollHoldMs = 300f;

	// Token: 0x04009FD6 RID: 40918
	private const int InitScrollMinFrames = 5;

	// Token: 0x04009FD7 RID: 40919
	private const float SnapVelocityThreshold = 100f;

	// Token: 0x04009FD8 RID: 40920
	private const float SnapDurationMs = 250f;

	// Token: 0x04009FD9 RID: 40921
	private bool IsDragging;

	// Token: 0x04009FDA RID: 40922
	private bool WaitSnap;

	// Token: 0x04009FDB RID: 40923
	private bool IsSnapping;

	// Token: 0x04009FDC RID: 40924
	private float SnapFromProgress;

	// Token: 0x04009FDD RID: 40925
	private float SnapToProgress;

	// Token: 0x04009FDE RID: 40926
	private float SnapElapsed;

	// Token: 0x04009FDF RID: 40927
	private int SnapTickId = -1;

	// Token: 0x02007FF0 RID: 32752
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029643 RID: 169539
		public const int UiItemCaption = 0;

		// Token: 0x04029644 RID: 169540
		public const int PnlTopTime = 1;

		// Token: 0x04029645 RID: 169541
		public const int TxtTime = 2;

		// Token: 0x04029646 RID: 169542
		public const int BtnTeamBuff = 3;

		// Token: 0x04029647 RID: 169543
		public const int LevelItemScroll = 4;

		// Token: 0x04029648 RID: 169544
		public const int UiItemLevelItem = 5;

		// Token: 0x04029649 RID: 169545
		public const int PnlRightInfo = 6;

		// Token: 0x0402964A RID: 169546
		public const int PnlBottom = 7;

		// Token: 0x0402964B RID: 169547
		public const int CurrentStageBtn = 8;
	}
}
