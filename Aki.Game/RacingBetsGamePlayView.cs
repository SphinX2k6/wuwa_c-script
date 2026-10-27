using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002732 RID: 10034
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGamePlayView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x0601490F RID: 84239 RVA: 0x00532577 File Offset: 0x00530777
	public RacingBetsGamePlayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014910 RID: 84240 RVA: 0x005325AC File Offset: 0x005307AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 47;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(45, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 14;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickBulletScreenToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickTextBulletScreenButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickIconBulletScreenButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickDangoSkillButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickDangoTextBulletToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnClickTextBulletToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickSpeedButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(31, new Action(this.OnClickBulletScreenCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(32, new Action(this.OnClickBulletScreenSettingButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(35, new Action<float>(this.OnBulletScreenAlphaSliderValueChanged));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(36, new Action<EToggleState>(this.OnClickFullBulletScreenToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(37, new Action<EToggleState>(this.OnClickHalfBulletScreenToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(46, new Action(this.OnClickDetailButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014911 RID: 84241 RVA: 0x00532E18 File Offset: 0x00531018
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsGamePlayView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGamePlayView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014912 RID: 84242 RVA: 0x00532E5C File Offset: 0x0053105C
	private UniTask InitRacingBetsOrderList()
	{
		RacingBetsGamePlayView.<InitRacingBetsOrderList>d__23 <InitRacingBetsOrderList>d__;
		<InitRacingBetsOrderList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRacingBetsOrderList>d__.<>4__this = this;
		<InitRacingBetsOrderList>d__.<>1__state = -1;
		<InitRacingBetsOrderList>d__.<>t__builder.Start<RacingBetsGamePlayView.<InitRacingBetsOrderList>d__23>(ref <InitRacingBetsOrderList>d__);
		return <InitRacingBetsOrderList>d__.<>t__builder.Task;
	}

	// Token: 0x06014913 RID: 84243 RVA: 0x00532EA0 File Offset: 0x005310A0
	private UniTask InitRacingBetsDangoDiceList()
	{
		RacingBetsGamePlayView.<InitRacingBetsDangoDiceList>d__24 <InitRacingBetsDangoDiceList>d__;
		<InitRacingBetsDangoDiceList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRacingBetsDangoDiceList>d__.<>4__this = this;
		<InitRacingBetsDangoDiceList>d__.<>1__state = -1;
		<InitRacingBetsDangoDiceList>d__.<>t__builder.Start<RacingBetsGamePlayView.<InitRacingBetsDangoDiceList>d__24>(ref <InitRacingBetsDangoDiceList>d__);
		return <InitRacingBetsDangoDiceList>d__.<>t__builder.Task;
	}

	// Token: 0x06014914 RID: 84244 RVA: 0x00532EE4 File Offset: 0x005310E4
	private void InitBulletScreen()
	{
		this.ShowIconBulletScreenPanel = false;
		this.ShowTextBulletScreenPanel = false;
		this.ShowBulletScreenSettingPanel = false;
		base.GetItem(5).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetItem(33).SetUIActive(false);
		base.GetButton(31).RootUIComp.Get().SetUIActive(false);
		int racingBetsBulletScreenAlpha = RacingBetsModel.Instance.GetRacingBetsBulletScreenAlpha();
		UUISliderComponent slider = base.GetSlider(35);
		slider.MaxValue = 100f;
		slider.MinValue = 10f;
		slider.Value = (float)racingBetsBulletScreenAlpha;
		this.BulletScreenMovePanel.GetRootItem().SetAlpha((float)racingBetsBulletScreenAlpha / 100f);
		int racingBetsBulletScreenShowType = RacingBetsModel.Instance.GetRacingBetsBulletScreenShowType();
		bool flag = racingBetsBulletScreenShowType == 2;
		UUIExtendToggle extendToggle = base.GetExtendToggle(36);
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(37);
		extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		extendToggle.bLockStateOnSelect = true;
		extendToggle2.SetToggleStateForce(flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		extendToggle2.bLockStateOnSelect = true;
		this.BulletScreenMovePanel.SetBulletScreenShowType((ERacingBetsBulletScreenShowType)racingBetsBulletScreenShowType);
		UUIText text = base.GetText(34);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(racingBetsBulletScreenAlpha);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06014915 RID: 84245 RVA: 0x00533020 File Offset: 0x00531220
	private void RefreshUi()
	{
		bool isReplayDungeon = RacingBetsModel.Instance.IsReplayDungeon;
		base.GetItem(13).SetUIActive(false);
		base.GetExtendToggle(9).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		base.GetExtendToggle(10).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		this.ShowIconBulletScreenPanel = false;
		this.ShowTextBulletScreenPanel = false;
		base.GetItem(5).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetButton(22).RootUIComp.Get().SetUIActive(isReplayDungeon);
		UUISprite spriteComponent = base.GetSprite(45);
		spriteComponent.SetUIActive(false);
		string resourceId = isReplayDungeon ? "SP_RaceScheduleTitleBgRec" : "SP_RaceScheduleTitleBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, spriteComponent, false, null, delegate(bool success)
		{
			spriteComponent.SetUIActive(success);
		});
		if (isReplayDungeon)
		{
			float num = this.ReplaySpeedList[this.CurReplaySpeedIndex];
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, num);
			UUIText text = base.GetText(23);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("×");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num, "F1");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x06014916 RID: 84246 RVA: 0x00533168 File Offset: 0x00531368
	private void RefreshDangoOrderList(IReadOnlyList<DangoIdToDiceNum> dangoOrderList)
	{
		for (int i = 0; i < dangoOrderList.Count; i++)
		{
			this.DangoOrderItemList[i].Refresh(dangoOrderList[i], false, i);
			this.DangoOrderItemList[i].SetActive(true);
		}
		if (this.DangoOrderItemList.Count > dangoOrderList.Count)
		{
			for (int j = dangoOrderList.Count; j < this.DangoOrderItemList.Count; j++)
			{
				this.DangoOrderItemList[j].SetActive(false);
			}
		}
	}

	// Token: 0x06014917 RID: 84247 RVA: 0x005331F4 File Offset: 0x005313F4
	private void RefreshDangoDiceList(IReadOnlyList<DangoIdToDiceNum> dangoDiceList)
	{
		for (int i = 0; i < dangoDiceList.Count; i++)
		{
			this.DangoDiceItemList[i].Refresh(dangoDiceList[i], false, i);
			this.DangoDiceItemList[i].SetActive(true);
		}
		if (this.DangoDiceItemList.Count > dangoDiceList.Count)
		{
			for (int j = dangoDiceList.Count; j < this.DangoDiceItemList.Count; j++)
			{
				this.DangoDiceItemList[j].SetActive(false);
			}
		}
	}

	// Token: 0x06014918 RID: 84248 RVA: 0x00533280 File Offset: 0x00531480
	private void RefreshDangoSettingPanel(bool isShow)
	{
		if (this.ShowBulletScreenSettingPanel == isShow)
		{
			return;
		}
		this.ShowBulletScreenSettingPanel = isShow;
		if (isShow)
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("FuncHide03"))
			{
				this.UiViewSequence.StopSequenceByKey("FuncHide03", false, false);
			}
			base.PlaySequence("FuncShow03", null, false);
			return;
		}
		if (this.UiViewSequence.HasSequenceNameInPlaying("FuncShow03"))
		{
			this.UiViewSequence.StopSequenceByKey("FuncShow03", false, false);
		}
		base.PlaySequence("FuncHide03", null, false);
	}

	// Token: 0x06014919 RID: 84249 RVA: 0x00533304 File Offset: 0x00531504
	private void RefreshTextBulletScreenPanel(bool isShow)
	{
		if (this.ShowTextBulletScreenPanel == isShow)
		{
			return;
		}
		this.ShowTextBulletScreenPanel = isShow;
		if (isShow)
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("FuncHide02"))
			{
				this.UiViewSequence.StopSequenceByKey("FuncHide02", false, false);
			}
			base.PlaySequence("FuncShow02", null, false);
			return;
		}
		if (this.UiViewSequence.HasSequenceNameInPlaying("FuncShow02"))
		{
			this.UiViewSequence.StopSequenceByKey("FuncShow02", false, false);
		}
		base.PlaySequence("FuncHide02", null, false);
	}

	// Token: 0x0601491A RID: 84250 RVA: 0x00533388 File Offset: 0x00531588
	private void RefreshIconBulletScreenPanel(bool isShow)
	{
		if (this.ShowIconBulletScreenPanel == isShow)
		{
			return;
		}
		this.ShowIconBulletScreenPanel = isShow;
		if (isShow)
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("FuncHide01"))
			{
				this.UiViewSequence.StopSequenceByKey("FuncHide01", false, false);
			}
			base.PlaySequence("FuncShow01", null, false);
			return;
		}
		if (this.UiViewSequence.HasSequenceNameInPlaying("FuncShow01"))
		{
			this.UiViewSequence.StopSequenceByKey("FuncShow01", false, false);
		}
		base.PlaySequence("FuncHide01", null, false);
	}

	// Token: 0x0601491B RID: 84251 RVA: 0x0053340C File Offset: 0x0053160C
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle(viewName, new int?(viewId), true);
	}

	// Token: 0x0601491C RID: 84252 RVA: 0x00533420 File Offset: 0x00531620
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsDiceAnim, new Action<int, CustomPromise>(this.OnRacingBetsDiceAnim));
		EventSystem.Instance.Add<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
		EventSystem.Instance.Add<IReadOnlyList<int>, bool>(EEventName.OnRacingBetsPushBulletScreen, new Action<IReadOnlyList<int>, bool>(this.OnRacingBetsPushBulletScreen));
		EventSystem.Instance.Add<CustomPromise>(EEventName.OnRacingBetsDungeonDangoRankChange, new Action<CustomPromise>(this.OnRacingBetsDungeonDangoRankChange));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x0601491D RID: 84253 RVA: 0x005334BC File Offset: 0x005316BC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDiceAnim, new Action<int, CustomPromise>(this.OnRacingBetsDiceAnim));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPushBulletScreen, new Action<IReadOnlyList<int>, bool>(this.OnRacingBetsPushBulletScreen));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDungeonDangoRankChange, new Action<CustomPromise>(this.OnRacingBetsDungeonDangoRankChange));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x0601491E RID: 84254 RVA: 0x00533558 File Offset: 0x00531758
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.DeepCopyCamera(CameraController.Instance.MainModel.FreeCamera.DisplayComponent.CameraActor);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "RacingBetsGamePlayView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		UiCameraAnimationController.Instance.PopCameraHandle(viewName, stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x0601491F RID: 84255 RVA: 0x005335E0 File Offset: 0x005317E0
	protected override void OnBeforeDestroy()
	{
		UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, 1f);
	}

	// Token: 0x06014920 RID: 84256 RVA: 0x005335F1 File Offset: 0x005317F1
	private RacingBetsIconBulletScreenItem CreateIconBulletItem()
	{
		RacingBetsIconBulletScreenItem racingBetsIconBulletScreenItem = new RacingBetsIconBulletScreenItem();
		racingBetsIconBulletScreenItem.BindClickBulletScreenCallBack(new Action<RacingBetsBulletScreen>(this.OnClickBulletScreenItem));
		return racingBetsIconBulletScreenItem;
	}

	// Token: 0x06014921 RID: 84257 RVA: 0x0053360A File Offset: 0x0053180A
	private RacingBetsTextBulletScreenItem CreateTextBulletItem()
	{
		RacingBetsTextBulletScreenItem racingBetsTextBulletScreenItem = new RacingBetsTextBulletScreenItem();
		racingBetsTextBulletScreenItem.BindClickBulletScreenCallBack(new Action<RacingBetsBulletScreen>(this.OnClickBulletScreenItem));
		return racingBetsTextBulletScreenItem;
	}

	// Token: 0x06014922 RID: 84258 RVA: 0x00533623 File Offset: 0x00531823
	private void OnRacingBetsDangoOrderRefresh(int round, IReadOnlyList<DangoIdToDiceNum> dangoOrderList, CustomPromise promise)
	{
		this.RefreshDangoOrder(round, dangoOrderList, promise).Forget();
	}

	// Token: 0x06014923 RID: 84259 RVA: 0x00533634 File Offset: 0x00531834
	private UniTask RefreshDangoOrder(int round, IReadOnlyList<DangoIdToDiceNum> dangoOrderList, CustomPromise promise)
	{
		RacingBetsGamePlayView.<RefreshDangoOrder>d__40 <RefreshDangoOrder>d__;
		<RefreshDangoOrder>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDangoOrder>d__.<>4__this = this;
		<RefreshDangoOrder>d__.round = round;
		<RefreshDangoOrder>d__.dangoOrderList = dangoOrderList;
		<RefreshDangoOrder>d__.promise = promise;
		<RefreshDangoOrder>d__.<>1__state = -1;
		<RefreshDangoOrder>d__.<>t__builder.Start<RacingBetsGamePlayView.<RefreshDangoOrder>d__40>(ref <RefreshDangoOrder>d__);
		return <RefreshDangoOrder>d__.<>t__builder.Task;
	}

	// Token: 0x06014924 RID: 84260 RVA: 0x0053368F File Offset: 0x0053188F
	private void OnRacingBetsDiceAnim(int diceCount, CustomPromise promise)
	{
		this.PlayDiceAnim(diceCount, promise).Forget();
	}

	// Token: 0x06014925 RID: 84261 RVA: 0x005336A0 File Offset: 0x005318A0
	private UniTask PlayDiceAnim(int diceCount, CustomPromise promise)
	{
		RacingBetsGamePlayView.<PlayDiceAnim>d__42 <PlayDiceAnim>d__;
		<PlayDiceAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDiceAnim>d__.<>4__this = this;
		<PlayDiceAnim>d__.promise = promise;
		<PlayDiceAnim>d__.<>1__state = -1;
		<PlayDiceAnim>d__.<>t__builder.Start<RacingBetsGamePlayView.<PlayDiceAnim>d__42>(ref <PlayDiceAnim>d__);
		return <PlayDiceAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014926 RID: 84262 RVA: 0x005336EB File Offset: 0x005318EB
	private void OnRacingBetsPushBulletScreen(IReadOnlyList<int> bulletList, bool isSelf)
	{
		this.BulletScreenMovePanel.PushBulletScreen(bulletList, isSelf);
	}

	// Token: 0x06014927 RID: 84263 RVA: 0x005336FA File Offset: 0x005318FA
	private void OnRacingBetsDungeonDangoRankChange(CustomPromise promise)
	{
		this.RefreshDangoRank(promise).Forget();
	}

	// Token: 0x06014928 RID: 84264 RVA: 0x00533708 File Offset: 0x00531908
	private UniTask RefreshDangoRank(CustomPromise promise)
	{
		RacingBetsGamePlayView.<RefreshDangoRank>d__45 <RefreshDangoRank>d__;
		<RefreshDangoRank>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDangoRank>d__.<>4__this = this;
		<RefreshDangoRank>d__.promise = promise;
		<RefreshDangoRank>d__.<>1__state = -1;
		<RefreshDangoRank>d__.<>t__builder.Start<RacingBetsGamePlayView.<RefreshDangoRank>d__45>(ref <RefreshDangoRank>d__);
		return <RefreshDangoRank>d__.<>t__builder.Task;
	}

	// Token: 0x06014929 RID: 84265 RVA: 0x00533754 File Offset: 0x00531954
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiViewName.RacingBetsGamePlayView)
		{
			int gameplayMode = GameModeModel.Instance.InstanceDungeon.Value.GameplayMode;
			InstanceGameplayMode? gameplayModeConfig = InstanceDungeonConfig.Instance.GetGameplayModeConfig(gameplayMode);
			if (gameplayModeConfig != null)
			{
				CameraController.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(RacingBetsGamePlayView.ToFloatArray(gameplayModeConfig.Value.GetCameraParamsArray()));
			}
			UiCameraAnimationController.Instance.ExitUiCameraMode();
		}
	}

	// Token: 0x0601492A RID: 84266 RVA: 0x005337E0 File Offset: 0x005319E0
	private void OnClickBulletScreenToggle(EToggleState state)
	{
		this.BulletScreenMovePanel.SetActive(state != EToggleState.ETT_Checked);
	}

	// Token: 0x0601492B RID: 84267 RVA: 0x005337F4 File Offset: 0x005319F4
	private void OnClickTextBulletScreenButton()
	{
		bool flag = !this.ShowTextBulletScreenPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshTextBulletScreenPanel(flag);
		this.RefreshDangoSettingPanel(false);
		this.RefreshIconBulletScreenPanel(false);
	}

	// Token: 0x0601492C RID: 84268 RVA: 0x0053383C File Offset: 0x00531A3C
	private void OnClickIconBulletScreenButton()
	{
		bool flag = !this.ShowIconBulletScreenPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshIconBulletScreenPanel(flag);
		this.RefreshDangoSettingPanel(false);
		this.RefreshTextBulletScreenPanel(false);
	}

	// Token: 0x0601492D RID: 84269 RVA: 0x00533884 File Offset: 0x00531A84
	private void OnClickDangoTextBulletToggle(EToggleState state)
	{
		base.GetExtendToggle(9).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		base.GetExtendToggle(10).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		List<RacingBetsBulletScreen> racingBetsBulletScreen = RacingBetsModel.Instance.GetRacingBetsBulletScreen(ERacingBetsBulletScreenType.DangoText);
		this.TextBulletScroll.RefreshByData(racingBetsBulletScreen, null, false);
	}

	// Token: 0x0601492E RID: 84270 RVA: 0x005338D0 File Offset: 0x00531AD0
	private void OnClickTextBulletToggle(EToggleState state)
	{
		base.GetExtendToggle(9).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(10).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		List<RacingBetsBulletScreen> racingBetsBulletScreen = RacingBetsModel.Instance.GetRacingBetsBulletScreen(ERacingBetsBulletScreenType.Text);
		this.TextBulletScroll.RefreshByData(racingBetsBulletScreen, null, false);
	}

	// Token: 0x0601492F RID: 84271 RVA: 0x0053391C File Offset: 0x00531B1C
	private void OnClickSpeedButton()
	{
		this.CurReplaySpeedIndex = (this.CurReplaySpeedIndex + 1) % this.ReplaySpeedList.Count;
		float num = this.ReplaySpeedList[this.CurReplaySpeedIndex];
		UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, num);
		UUIText text = base.GetText(23);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted<float>(num, "F1");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06014930 RID: 84272 RVA: 0x00533998 File Offset: 0x00531B98
	private void OnClickBulletScreenCloseButton()
	{
		this.RefreshDangoSettingPanel(false);
		this.RefreshTextBulletScreenPanel(false);
		this.RefreshIconBulletScreenPanel(false);
		base.GetButton(31).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06014931 RID: 84273 RVA: 0x005339D8 File Offset: 0x00531BD8
	private void OnBulletScreenAlphaSliderValueChanged(float value)
	{
		int num = (int)Math.Floor((double)value);
		RacingBetsModel.Instance.SetRacingBetsBulletScreenAlpha(num);
		UUIText text = base.GetText(34);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		this.BulletScreenMovePanel.GetRootItem().SetAlpha((float)num / 100f);
	}

	// Token: 0x06014932 RID: 84274 RVA: 0x00533A44 File Offset: 0x00531C44
	private void OnClickBulletScreenSettingButton()
	{
		bool flag = !this.ShowBulletScreenSettingPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshDangoSettingPanel(flag);
		this.RefreshTextBulletScreenPanel(false);
		this.RefreshIconBulletScreenPanel(false);
	}

	// Token: 0x06014933 RID: 84275 RVA: 0x00533A8B File Offset: 0x00531C8B
	private void OnClickFullBulletScreenToggle(EToggleState state)
	{
		RacingBetsModel.Instance.SetRacingBetsBulletScreenShowType(2);
		this.BulletScreenMovePanel.SetBulletScreenShowType(ERacingBetsBulletScreenShowType.Full);
		base.GetExtendToggle(37).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014934 RID: 84276 RVA: 0x00533AB5 File Offset: 0x00531CB5
	private void OnClickHalfBulletScreenToggle(EToggleState state)
	{
		RacingBetsModel.Instance.SetRacingBetsBulletScreenShowType(1);
		this.BulletScreenMovePanel.SetBulletScreenShowType(ERacingBetsBulletScreenShowType.Half);
		base.GetExtendToggle(36).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014935 RID: 84277 RVA: 0x00533AE0 File Offset: 0x00531CE0
	private void OnClickCloseButton()
	{
		if (this.IsPrepareLeave)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_InGame_ExitError", Array.Empty<object>());
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsExitDungeonConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			RacingBetsModel.Instance.RacingBetsAbortDungeon();
			this.IsPrepareLeave = true;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06014936 RID: 84278 RVA: 0x00533B3C File Offset: 0x00531D3C
	private void OnClickDetailButton()
	{
		int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurLegMatchData().Id;
		List<int> param = new List<int>(RacingBetsConfig.Instance.GetRacingBetsLegMatches(id).Value.GetShowOrganListArray());
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoTerrainView, param, null);
	}

	// Token: 0x06014937 RID: 84279 RVA: 0x00533B90 File Offset: 0x00531D90
	private void OnClickDangoSkillButton()
	{
		RacingBetsDangoSkillViewParam param = new RacingBetsDangoSkillViewParam
		{
			DangoList = this.DungeonDangoSortList
		};
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoSkillView, param, null);
	}

	// Token: 0x06014938 RID: 84280 RVA: 0x00533BC0 File Offset: 0x00531DC0
	private void OnClickBulletScreenItem(RacingBetsBulletScreen data)
	{
		if (this.NextBulletScreenAvailableSendTime > (long)TimeUtil.Instance.GetServerTimeStamp())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_BulletChat_SendError", Array.Empty<object>());
			return;
		}
		this.NextBulletScreenAvailableSendTime = (long)TimeUtil.Instance.GetServerTimeStamp() + (long)this.BulletScreenSendInterval;
		RacingBetsController.Instance.RacingBetsBulletScreenRequest(data.Id);
	}

	// Token: 0x06014939 RID: 84281 RVA: 0x00533C20 File Offset: 0x00531E20
	private static float[] ToFloatArray(int[] intArray)
	{
		float[] array = new float[intArray.Length];
		for (int i = 0; i < intArray.Length; i++)
		{
			array[i] = (float)intArray[i];
		}
		return array;
	}

	// Token: 0x04009A93 RID: 39571
	private const int DANGO_ORDER_ITEM_START_INDEX = 24;

	// Token: 0x04009A94 RID: 39572
	private const int DANGO_ORDER_ITEM_COUNT = 7;

	// Token: 0x04009A95 RID: 39573
	private const int DANGO_DICE_ITEM_START_INDEX = 38;

	// Token: 0x04009A96 RID: 39574
	private const int DANGO_DICE_ITEM_COUNT = 7;

	// Token: 0x04009A97 RID: 39575
	private bool ShowIconBulletScreenPanel;

	// Token: 0x04009A98 RID: 39576
	private bool ShowTextBulletScreenPanel;

	// Token: 0x04009A99 RID: 39577
	private bool ShowBulletScreenSettingPanel;

	// Token: 0x04009A9A RID: 39578
	private int BulletScreenSendInterval;

	// Token: 0x04009A9B RID: 39579
	private long NextBulletScreenAvailableSendTime;

	// Token: 0x04009A9C RID: 39580
	private int CurReplaySpeedIndex;

	// Token: 0x04009A9D RID: 39581
	private bool IsPrepareLeave;

	// Token: 0x04009A9E RID: 39582
	private List<float> ReplaySpeedList = new List<float>();

	// Token: 0x04009A9F RID: 39583
	private RacingBetsBulletScreenPanel BulletScreenMovePanel;

	// Token: 0x04009AA0 RID: 39584
	private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

	// Token: 0x04009AA1 RID: 39585
	private RacingBetsDangoRankPanel DangoRankPanel;

	// Token: 0x04009AA2 RID: 39586
	private GenericScrollViewNew<RacingBetsIconBulletScreenItem, RacingBetsBulletScreen> IconBulletScroll;

	// Token: 0x04009AA3 RID: 39587
	private GenericScrollViewNew<RacingBetsTextBulletScreenItem, RacingBetsBulletScreen> TextBulletScroll;

	// Token: 0x04009AA4 RID: 39588
	private readonly List<RacingBetsDangoOrderItem> DangoOrderItemList = new List<RacingBetsDangoOrderItem>();

	// Token: 0x04009AA5 RID: 39589
	private readonly List<RacingBetsDangoDiceItem> DangoDiceItemList = new List<RacingBetsDangoDiceItem>();

	// Token: 0x02008D92 RID: 36242
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DF13 RID: 188179
		public const int DangoPanel = 0;

		// Token: 0x0402DF14 RID: 188180
		public const int DangoItem = 1;

		// Token: 0x0402DF15 RID: 188181
		public const int BulletScreenToggle = 2;

		// Token: 0x0402DF16 RID: 188182
		public const int TextBulletScreenButton = 3;

		// Token: 0x0402DF17 RID: 188183
		public const int IconBulletScreenButton = 4;

		// Token: 0x0402DF18 RID: 188184
		public const int IconBulletScreenPanel = 5;

		// Token: 0x0402DF19 RID: 188185
		public const int CloseButton = 6;

		// Token: 0x0402DF1A RID: 188186
		public const int DangoSkillButton = 7;

		// Token: 0x0402DF1B RID: 188187
		public const int TextBulletScreenPanel = 8;

		// Token: 0x0402DF1C RID: 188188
		public const int DangoTextBulletToggle = 9;

		// Token: 0x0402DF1D RID: 188189
		public const int TextBulletToggle = 10;

		// Token: 0x0402DF1E RID: 188190
		public const int TextBulletScrollView = 11;

		// Token: 0x0402DF1F RID: 188191
		public const int IconBulletScrollView = 12;

		// Token: 0x0402DF20 RID: 188192
		public const int DicePanel = 13;

		// Token: 0x0402DF21 RID: 188193
		public const int BulletScreenShowPanel = 14;

		// Token: 0x0402DF22 RID: 188194
		public const int DiceTexture = 15;

		// Token: 0x0402DF23 RID: 188195
		public const int DicePanelRoot = 16;

		// Token: 0x0402DF24 RID: 188196
		public const int DiceLayout = 17;

		// Token: 0x0402DF25 RID: 188197
		public const int DangoOrderPanel = 18;

		// Token: 0x0402DF26 RID: 188198
		public const int MaskPanel = 19;

		// Token: 0x0402DF27 RID: 188199
		public const int RoundText = 20;

		// Token: 0x0402DF28 RID: 188200
		public const int DangoOrderLayout = 21;

		// Token: 0x0402DF29 RID: 188201
		public const int SpeedButton = 22;

		// Token: 0x0402DF2A RID: 188202
		public const int SpeedText = 23;

		// Token: 0x0402DF2B RID: 188203
		public const int DangoOrderItem1 = 24;

		// Token: 0x0402DF2C RID: 188204
		public const int DangoOrderItem2 = 25;

		// Token: 0x0402DF2D RID: 188205
		public const int DangoOrderItem3 = 26;

		// Token: 0x0402DF2E RID: 188206
		public const int DangoOrderItem4 = 27;

		// Token: 0x0402DF2F RID: 188207
		public const int DangoOrderItem5 = 28;

		// Token: 0x0402DF30 RID: 188208
		public const int DangoOrderItem6 = 29;

		// Token: 0x0402DF31 RID: 188209
		public const int DangoOrderItem7 = 30;

		// Token: 0x0402DF32 RID: 188210
		public const int BulletScreenCloseButton = 31;

		// Token: 0x0402DF33 RID: 188211
		public const int BulletScreenSettingButton = 32;

		// Token: 0x0402DF34 RID: 188212
		public const int BulletScreenSettingPanel = 33;

		// Token: 0x0402DF35 RID: 188213
		public const int BulletScreenAlphaText = 34;

		// Token: 0x0402DF36 RID: 188214
		public const int BulletScreenAlphaSlider = 35;

		// Token: 0x0402DF37 RID: 188215
		public const int FullBulletScreenToggle = 36;

		// Token: 0x0402DF38 RID: 188216
		public const int HalfBulletScreenToggle = 37;

		// Token: 0x0402DF39 RID: 188217
		public const int DangoDiceItem1 = 38;

		// Token: 0x0402DF3A RID: 188218
		public const int DangoDiceItem2 = 39;

		// Token: 0x0402DF3B RID: 188219
		public const int DangoDiceItem3 = 40;

		// Token: 0x0402DF3C RID: 188220
		public const int DangoDiceItem4 = 41;

		// Token: 0x0402DF3D RID: 188221
		public const int DangoDiceItem5 = 42;

		// Token: 0x0402DF3E RID: 188222
		public const int DangoDiceItem6 = 43;

		// Token: 0x0402DF3F RID: 188223
		public const int DangoDiceItem7 = 44;

		// Token: 0x0402DF40 RID: 188224
		public const int LiveSprite = 45;

		// Token: 0x0402DF41 RID: 188225
		public const int DetailButton = 46;
	}
}
