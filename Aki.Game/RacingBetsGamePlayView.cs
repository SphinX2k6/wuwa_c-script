using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C1D RID: 7197
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGamePlayView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06011DF1 RID: 73201 RVA: 0x0054128B File Offset: 0x0053F48B
	public RacingBetsGamePlayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DF2 RID: 73202 RVA: 0x005412C0 File Offset: 0x0053F4C0
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

	// Token: 0x06011DF3 RID: 73203 RVA: 0x00541B2C File Offset: 0x0053FD2C
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsGamePlayView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGamePlayView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011DF4 RID: 73204 RVA: 0x00541B70 File Offset: 0x0053FD70
	private UniTask InitRacingBetsOrderList()
	{
		RacingBetsGamePlayView.<InitRacingBetsOrderList>d__23 <InitRacingBetsOrderList>d__;
		<InitRacingBetsOrderList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRacingBetsOrderList>d__.<>4__this = this;
		<InitRacingBetsOrderList>d__.<>1__state = -1;
		<InitRacingBetsOrderList>d__.<>t__builder.Start<RacingBetsGamePlayView.<InitRacingBetsOrderList>d__23>(ref <InitRacingBetsOrderList>d__);
		return <InitRacingBetsOrderList>d__.<>t__builder.Task;
	}

	// Token: 0x06011DF5 RID: 73205 RVA: 0x00541BB4 File Offset: 0x0053FDB4
	private UniTask InitRacingBetsDangoDiceList()
	{
		RacingBetsGamePlayView.<InitRacingBetsDangoDiceList>d__24 <InitRacingBetsDangoDiceList>d__;
		<InitRacingBetsDangoDiceList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRacingBetsDangoDiceList>d__.<>4__this = this;
		<InitRacingBetsDangoDiceList>d__.<>1__state = -1;
		<InitRacingBetsDangoDiceList>d__.<>t__builder.Start<RacingBetsGamePlayView.<InitRacingBetsDangoDiceList>d__24>(ref <InitRacingBetsDangoDiceList>d__);
		return <InitRacingBetsDangoDiceList>d__.<>t__builder.Task;
	}

	// Token: 0x06011DF6 RID: 73206 RVA: 0x00541BF8 File Offset: 0x0053FDF8
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

	// Token: 0x06011DF7 RID: 73207 RVA: 0x00541D34 File Offset: 0x0053FF34
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

	// Token: 0x06011DF8 RID: 73208 RVA: 0x00541E7C File Offset: 0x0054007C
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

	// Token: 0x06011DF9 RID: 73209 RVA: 0x00541F08 File Offset: 0x00540108
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

	// Token: 0x06011DFA RID: 73210 RVA: 0x00541F94 File Offset: 0x00540194
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

	// Token: 0x06011DFB RID: 73211 RVA: 0x00542018 File Offset: 0x00540218
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

	// Token: 0x06011DFC RID: 73212 RVA: 0x0054209C File Offset: 0x0054029C
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

	// Token: 0x06011DFD RID: 73213 RVA: 0x00542120 File Offset: 0x00540320
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView(viewName, viewId, EUiCameraHandleOperationType.Blend);
	}

	// Token: 0x06011DFE RID: 73214 RVA: 0x00542130 File Offset: 0x00540330
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsDiceAnim, new Action<int, CustomPromise>(this.OnRacingBetsDiceAnim));
		EventSystem.Instance.Add<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
		EventSystem.Instance.Add<IReadOnlyList<int>, bool>(EEventName.OnRacingBetsPushBulletScreen, new Action<IReadOnlyList<int>, bool>(this.OnRacingBetsPushBulletScreen));
		EventSystem.Instance.Add<CustomPromise>(EEventName.OnRacingBetsDungeonDangoRankChange, new Action<CustomPromise>(this.OnRacingBetsDungeonDangoRankChange));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06011DFF RID: 73215 RVA: 0x005421CC File Offset: 0x005403CC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDiceAnim, new Action<int, CustomPromise>(this.OnRacingBetsDiceAnim));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPushBulletScreen, new Action<IReadOnlyList<int>, bool>(this.OnRacingBetsPushBulletScreen));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDungeonDangoRankChange, new Action<CustomPromise>(this.OnRacingBetsDungeonDangoRankChange));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06011E00 RID: 73216 RVA: 0x00542268 File Offset: 0x00540468
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.DeepCopyCamera(CameraController.Instance.MainModel.FreeCamera.DisplayComponent.CameraActor);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraModel.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "RacingBetsGamePlayView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		UiCameraController.Instance.PopCameraHandleByCloseView(viewName, nextViewName, closeViewId, operationType);
	}

	// Token: 0x06011E01 RID: 73217 RVA: 0x005422F0 File Offset: 0x005404F0
	protected override void OnBeforeDestroy()
	{
		UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, 1f);
	}

	// Token: 0x06011E02 RID: 73218 RVA: 0x00542301 File Offset: 0x00540501
	private RacingBetsIconBulletScreenItem CreateIconBulletItem()
	{
		RacingBetsIconBulletScreenItem racingBetsIconBulletScreenItem = new RacingBetsIconBulletScreenItem();
		racingBetsIconBulletScreenItem.BindClickBulletScreenCallBack(new Action<RacingBetsBulletScreen>(this.OnClickBulletScreenItem));
		return racingBetsIconBulletScreenItem;
	}

	// Token: 0x06011E03 RID: 73219 RVA: 0x0054231A File Offset: 0x0054051A
	private RacingBetsTextBulletScreenItem CreateTextBulletItem()
	{
		RacingBetsTextBulletScreenItem racingBetsTextBulletScreenItem = new RacingBetsTextBulletScreenItem();
		racingBetsTextBulletScreenItem.BindClickBulletScreenCallBack(new Action<RacingBetsBulletScreen>(this.OnClickBulletScreenItem));
		return racingBetsTextBulletScreenItem;
	}

	// Token: 0x06011E04 RID: 73220 RVA: 0x00542333 File Offset: 0x00540533
	private void OnRacingBetsDangoOrderRefresh(int round, IReadOnlyList<DangoIdToDiceNum> dangoOrderList, CustomPromise promise)
	{
		this.RefreshDangoOrder(round, dangoOrderList, promise).Forget();
	}

	// Token: 0x06011E05 RID: 73221 RVA: 0x00542344 File Offset: 0x00540544
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

	// Token: 0x06011E06 RID: 73222 RVA: 0x0054239F File Offset: 0x0054059F
	private void OnRacingBetsDiceAnim(int diceCount, CustomPromise promise)
	{
		this.PlayDiceAnim(diceCount, promise).Forget();
	}

	// Token: 0x06011E07 RID: 73223 RVA: 0x005423B0 File Offset: 0x005405B0
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

	// Token: 0x06011E08 RID: 73224 RVA: 0x005423FB File Offset: 0x005405FB
	private void OnRacingBetsPushBulletScreen(IReadOnlyList<int> bulletList, bool isSelf)
	{
		this.BulletScreenMovePanel.PushBulletScreen(bulletList, isSelf);
	}

	// Token: 0x06011E09 RID: 73225 RVA: 0x0054240A File Offset: 0x0054060A
	private void OnRacingBetsDungeonDangoRankChange(CustomPromise promise)
	{
		this.RefreshDangoRank(promise).Forget();
	}

	// Token: 0x06011E0A RID: 73226 RVA: 0x00542418 File Offset: 0x00540618
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

	// Token: 0x06011E0B RID: 73227 RVA: 0x00542464 File Offset: 0x00540664
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiViewName.RacingBetsGamePlayView)
		{
			int gameplayMode = GameModeModel.Instance.InstanceDungeon.Value.GameplayMode;
			InstanceGameplayMode? gameplayModeConfig = InstanceDungeonConfig.Instance.GetGameplayModeConfig(gameplayMode);
			if (gameplayModeConfig != null)
			{
				CameraController.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(RacingBetsGamePlayView.ToFloatArray(gameplayModeConfig.Value.GetCameraParamsArray()));
			}
			UiCameraController.Instance.ExitUiCameraMode();
		}
	}

	// Token: 0x06011E0C RID: 73228 RVA: 0x005424F0 File Offset: 0x005406F0
	private void OnClickBulletScreenToggle(EToggleState state)
	{
		this.BulletScreenMovePanel.SetActive(state != EToggleState.ETT_Checked);
	}

	// Token: 0x06011E0D RID: 73229 RVA: 0x00542504 File Offset: 0x00540704
	private void OnClickTextBulletScreenButton()
	{
		bool flag = !this.ShowTextBulletScreenPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshTextBulletScreenPanel(flag);
		this.RefreshDangoSettingPanel(false);
		this.RefreshIconBulletScreenPanel(false);
	}

	// Token: 0x06011E0E RID: 73230 RVA: 0x0054254C File Offset: 0x0054074C
	private void OnClickIconBulletScreenButton()
	{
		bool flag = !this.ShowIconBulletScreenPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshIconBulletScreenPanel(flag);
		this.RefreshDangoSettingPanel(false);
		this.RefreshTextBulletScreenPanel(false);
	}

	// Token: 0x06011E0F RID: 73231 RVA: 0x00542594 File Offset: 0x00540794
	private void OnClickDangoTextBulletToggle(EToggleState state)
	{
		base.GetExtendToggle(9).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		base.GetExtendToggle(10).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		List<RacingBetsBulletScreen> racingBetsBulletScreen = RacingBetsModel.Instance.GetRacingBetsBulletScreen(ERacingBetsBulletScreenType.DangoText);
		this.TextBulletScroll.RefreshByData(racingBetsBulletScreen, null, false);
	}

	// Token: 0x06011E10 RID: 73232 RVA: 0x005425E0 File Offset: 0x005407E0
	private void OnClickTextBulletToggle(EToggleState state)
	{
		base.GetExtendToggle(9).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(10).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		List<RacingBetsBulletScreen> racingBetsBulletScreen = RacingBetsModel.Instance.GetRacingBetsBulletScreen(ERacingBetsBulletScreenType.Text);
		this.TextBulletScroll.RefreshByData(racingBetsBulletScreen, null, false);
	}

	// Token: 0x06011E11 RID: 73233 RVA: 0x0054262C File Offset: 0x0054082C
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

	// Token: 0x06011E12 RID: 73234 RVA: 0x005426A8 File Offset: 0x005408A8
	private void OnClickBulletScreenCloseButton()
	{
		this.RefreshDangoSettingPanel(false);
		this.RefreshTextBulletScreenPanel(false);
		this.RefreshIconBulletScreenPanel(false);
		base.GetButton(31).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06011E13 RID: 73235 RVA: 0x005426E8 File Offset: 0x005408E8
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

	// Token: 0x06011E14 RID: 73236 RVA: 0x00542754 File Offset: 0x00540954
	private void OnClickBulletScreenSettingButton()
	{
		bool flag = !this.ShowBulletScreenSettingPanel;
		base.GetButton(31).RootUIComp.Get().SetUIActive(flag);
		this.RefreshDangoSettingPanel(flag);
		this.RefreshTextBulletScreenPanel(false);
		this.RefreshIconBulletScreenPanel(false);
	}

	// Token: 0x06011E15 RID: 73237 RVA: 0x0054279B File Offset: 0x0054099B
	private void OnClickFullBulletScreenToggle(EToggleState state)
	{
		RacingBetsModel.Instance.SetRacingBetsBulletScreenShowType(2);
		this.BulletScreenMovePanel.SetBulletScreenShowType(ERacingBetsBulletScreenShowType.Full);
		base.GetExtendToggle(37).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011E16 RID: 73238 RVA: 0x005427C5 File Offset: 0x005409C5
	private void OnClickHalfBulletScreenToggle(EToggleState state)
	{
		RacingBetsModel.Instance.SetRacingBetsBulletScreenShowType(1);
		this.BulletScreenMovePanel.SetBulletScreenShowType(ERacingBetsBulletScreenShowType.Half);
		base.GetExtendToggle(36).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011E17 RID: 73239 RVA: 0x005427F0 File Offset: 0x005409F0
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

	// Token: 0x06011E18 RID: 73240 RVA: 0x0054284C File Offset: 0x00540A4C
	private void OnClickDetailButton()
	{
		int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurLegMatchData().Id;
		List<int> param = new List<int>(RacingBetsConfig.Instance.GetRacingBetsLegMatches(id).Value.GetShowOrganListArray());
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoTerrainView, param, null);
	}

	// Token: 0x06011E19 RID: 73241 RVA: 0x005428A0 File Offset: 0x00540AA0
	private void OnClickDangoSkillButton()
	{
		RacingBetsDangoSkillViewParam param = new RacingBetsDangoSkillViewParam
		{
			DangoList = this.DungeonDangoSortList
		};
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoSkillView, param, null);
	}

	// Token: 0x06011E1A RID: 73242 RVA: 0x005428D0 File Offset: 0x00540AD0
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

	// Token: 0x06011E1B RID: 73243 RVA: 0x00542930 File Offset: 0x00540B30
	private static float[] ToFloatArray(int[] intArray)
	{
		float[] array = new float[intArray.Length];
		for (int i = 0; i < intArray.Length; i++)
		{
			array[i] = (float)intArray[i];
		}
		return array;
	}

	// Token: 0x04009BEB RID: 39915
	private const int DANGO_ORDER_ITEM_START_INDEX = 24;

	// Token: 0x04009BEC RID: 39916
	private const int DANGO_ORDER_ITEM_COUNT = 7;

	// Token: 0x04009BED RID: 39917
	private const int DANGO_DICE_ITEM_START_INDEX = 38;

	// Token: 0x04009BEE RID: 39918
	private const int DANGO_DICE_ITEM_COUNT = 7;

	// Token: 0x04009BEF RID: 39919
	private bool ShowIconBulletScreenPanel;

	// Token: 0x04009BF0 RID: 39920
	private bool ShowTextBulletScreenPanel;

	// Token: 0x04009BF1 RID: 39921
	private bool ShowBulletScreenSettingPanel;

	// Token: 0x04009BF2 RID: 39922
	private int BulletScreenSendInterval;

	// Token: 0x04009BF3 RID: 39923
	private long NextBulletScreenAvailableSendTime;

	// Token: 0x04009BF4 RID: 39924
	private int CurReplaySpeedIndex;

	// Token: 0x04009BF5 RID: 39925
	private bool IsPrepareLeave;

	// Token: 0x04009BF6 RID: 39926
	private List<float> ReplaySpeedList = new List<float>();

	// Token: 0x04009BF7 RID: 39927
	private RacingBetsBulletScreenPanel BulletScreenMovePanel;

	// Token: 0x04009BF8 RID: 39928
	private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

	// Token: 0x04009BF9 RID: 39929
	private RacingBetsDangoRankPanel DangoRankPanel;

	// Token: 0x04009BFA RID: 39930
	private GenericScrollViewNew<RacingBetsIconBulletScreenItem, RacingBetsBulletScreen> IconBulletScroll;

	// Token: 0x04009BFB RID: 39931
	private GenericScrollViewNew<RacingBetsTextBulletScreenItem, RacingBetsBulletScreen> TextBulletScroll;

	// Token: 0x04009BFC RID: 39932
	private readonly List<RacingBetsDangoOrderItem> DangoOrderItemList = new List<RacingBetsDangoOrderItem>();

	// Token: 0x04009BFD RID: 39933
	private readonly List<RacingBetsDangoDiceItem> DangoDiceItemList = new List<RacingBetsDangoDiceItem>();

	// Token: 0x02007F1A RID: 32538
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029229 RID: 168489
		public const int DangoPanel = 0;

		// Token: 0x0402922A RID: 168490
		public const int DangoItem = 1;

		// Token: 0x0402922B RID: 168491
		public const int BulletScreenToggle = 2;

		// Token: 0x0402922C RID: 168492
		public const int TextBulletScreenButton = 3;

		// Token: 0x0402922D RID: 168493
		public const int IconBulletScreenButton = 4;

		// Token: 0x0402922E RID: 168494
		public const int IconBulletScreenPanel = 5;

		// Token: 0x0402922F RID: 168495
		public const int CloseButton = 6;

		// Token: 0x04029230 RID: 168496
		public const int DangoSkillButton = 7;

		// Token: 0x04029231 RID: 168497
		public const int TextBulletScreenPanel = 8;

		// Token: 0x04029232 RID: 168498
		public const int DangoTextBulletToggle = 9;

		// Token: 0x04029233 RID: 168499
		public const int TextBulletToggle = 10;

		// Token: 0x04029234 RID: 168500
		public const int TextBulletScrollView = 11;

		// Token: 0x04029235 RID: 168501
		public const int IconBulletScrollView = 12;

		// Token: 0x04029236 RID: 168502
		public const int DicePanel = 13;

		// Token: 0x04029237 RID: 168503
		public const int BulletScreenShowPanel = 14;

		// Token: 0x04029238 RID: 168504
		public const int DiceTexture = 15;

		// Token: 0x04029239 RID: 168505
		public const int DicePanelRoot = 16;

		// Token: 0x0402923A RID: 168506
		public const int DiceLayout = 17;

		// Token: 0x0402923B RID: 168507
		public const int DangoOrderPanel = 18;

		// Token: 0x0402923C RID: 168508
		public const int MaskPanel = 19;

		// Token: 0x0402923D RID: 168509
		public const int RoundText = 20;

		// Token: 0x0402923E RID: 168510
		public const int DangoOrderLayout = 21;

		// Token: 0x0402923F RID: 168511
		public const int SpeedButton = 22;

		// Token: 0x04029240 RID: 168512
		public const int SpeedText = 23;

		// Token: 0x04029241 RID: 168513
		public const int DangoOrderItem1 = 24;

		// Token: 0x04029242 RID: 168514
		public const int DangoOrderItem2 = 25;

		// Token: 0x04029243 RID: 168515
		public const int DangoOrderItem3 = 26;

		// Token: 0x04029244 RID: 168516
		public const int DangoOrderItem4 = 27;

		// Token: 0x04029245 RID: 168517
		public const int DangoOrderItem5 = 28;

		// Token: 0x04029246 RID: 168518
		public const int DangoOrderItem6 = 29;

		// Token: 0x04029247 RID: 168519
		public const int DangoOrderItem7 = 30;

		// Token: 0x04029248 RID: 168520
		public const int BulletScreenCloseButton = 31;

		// Token: 0x04029249 RID: 168521
		public const int BulletScreenSettingButton = 32;

		// Token: 0x0402924A RID: 168522
		public const int BulletScreenSettingPanel = 33;

		// Token: 0x0402924B RID: 168523
		public const int BulletScreenAlphaText = 34;

		// Token: 0x0402924C RID: 168524
		public const int BulletScreenAlphaSlider = 35;

		// Token: 0x0402924D RID: 168525
		public const int FullBulletScreenToggle = 36;

		// Token: 0x0402924E RID: 168526
		public const int HalfBulletScreenToggle = 37;

		// Token: 0x0402924F RID: 168527
		public const int DangoDiceItem1 = 38;

		// Token: 0x04029250 RID: 168528
		public const int DangoDiceItem2 = 39;

		// Token: 0x04029251 RID: 168529
		public const int DangoDiceItem3 = 40;

		// Token: 0x04029252 RID: 168530
		public const int DangoDiceItem4 = 41;

		// Token: 0x04029253 RID: 168531
		public const int DangoDiceItem5 = 42;

		// Token: 0x04029254 RID: 168532
		public const int DangoDiceItem6 = 43;

		// Token: 0x04029255 RID: 168533
		public const int DangoDiceItem7 = 44;

		// Token: 0x04029256 RID: 168534
		public const int LiveSprite = 45;

		// Token: 0x04029257 RID: 168535
		public const int DetailButton = 46;
	}
}
