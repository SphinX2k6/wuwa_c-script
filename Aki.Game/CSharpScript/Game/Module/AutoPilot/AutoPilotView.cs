using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E5D RID: 20061
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class AutoPilotView : UiPanelBase, IExtraShowCursor
	{
		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x060327B2 RID: 206770 RVA: 0x00E2984B File Offset: 0x00E27A4B
		// (set) Token: 0x060327B1 RID: 206769 RVA: 0x00E2981B File Offset: 0x00E27A1B
		private bool IsCanShowMovieBtn
		{
			get
			{
				return this.IsCanShowMovieBtnInner;
			}
			set
			{
				if (this.IsCanShowMovieBtnInner != value)
				{
					this.IsCanShowMovieBtnInner = value;
					this.RefreshMovieBtnVisible();
					if (value)
					{
						EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "ShowAutoPilotMovieBtn");
					}
				}
			}
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x060327B4 RID: 206772 RVA: 0x00E2986B File Offset: 0x00E27A6B
		// (set) Token: 0x060327B3 RID: 206771 RVA: 0x00E29853 File Offset: 0x00E27A53
		private bool IsCanShowSkipBtn
		{
			get
			{
				return this.IsCanShowSkipBtnInner;
			}
			set
			{
				if (this.IsCanShowSkipBtnInner != value)
				{
					this.IsCanShowSkipBtnInner = value;
					this.RefreshSkipBtnVisible();
				}
			}
		}

		// Token: 0x060327B5 RID: 206773 RVA: 0x00E29874 File Offset: 0x00E27A74
		protected override UniTask OnBeforeStartAsync()
		{
			AutoPilotView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AutoPilotView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060327B6 RID: 206774 RVA: 0x00E298B7 File Offset: 0x00E27AB7
		protected override void OnStart()
		{
			this.AddTick();
			this.InitUi();
			this.RefreshUiVisible();
			this.AddEvents();
		}

		// Token: 0x060327B7 RID: 206775 RVA: 0x00E298D1 File Offset: 0x00E27AD1
		protected virtual void InitUi()
		{
			this.InitSkipBtn();
			this.InitExitBtn();
			this.InitMovieBtn();
			this.InitRideShareBtn();
			this.InitPhotoBtn();
			EventSystem.Instance.Emit<bool>(EEventName.OnAutoPilotTrackMarkVisibleChanged, true);
		}

		// Token: 0x060327B8 RID: 206776 RVA: 0x00E29904 File Offset: 0x00E27B04
		private void AddEvents()
		{
			InputManager.Instance.RegisterLockShortcutKeyReason("AutoPilotView", new TLockShortcutKeyDelegate(this.LockShortCutKeyDelegate));
			if (AutoPilotModel.Instance.IsAllowExitByMove)
			{
				InputDistributeController.Instance.BindAxis("MotorMoveForward", new TInputHandle<float>(this.ExitAutoPilotByInput));
				InputDistributeController.Instance.BindAxis("MotorMoveRight", new TInputHandle<float>(this.ExitAutoPilotByInput));
			}
			EventSystem.Instance.Add<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnAspectOffsetUpdate));
			EventSystem.Instance.Add<bool>(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData("AutoPilotView", this);
		}

		// Token: 0x060327B9 RID: 206777 RVA: 0x00E299D0 File Offset: 0x00E27BD0
		private void RemoveEvents()
		{
			InputManager.Instance.RemoveLockShortcutKeyReason("AutoPilotView");
			if (AutoPilotModel.Instance.IsAllowExitByMove)
			{
				InputDistributeController.Instance.UnBindAxis("MotorMoveForward", new TInputHandle<float>(this.ExitAutoPilotByInput));
				InputDistributeController.Instance.UnBindAxis("MotorMoveRight", new TInputHandle<float>(this.ExitAutoPilotByInput));
			}
			EventSystem.Instance.Remove<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnAspectOffsetUpdate));
			EventSystem.Instance.Remove<bool>(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData("AutoPilotView");
		}

		// Token: 0x060327BA RID: 206778
		protected abstract int GetSkipBtnCompId();

		// Token: 0x060327BB RID: 206779 RVA: 0x00E29A90 File Offset: 0x00E27C90
		private void InitSkipBtn()
		{
			this.SkipBtn = base.GetButton(this.GetSkipBtnCompId());
			if (this.SkipBtn == null)
			{
				return;
			}
			if (AutoPilotModel.Instance.GetIsCanShowSkipBtn())
			{
				this.SkipBtn.OnClickCallBack.Bind(new Action(this.OnClickSkipBtn));
				return;
			}
			this.SkipBtn.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x060327BC RID: 206780
		protected abstract int GetRideShareBtnCompId();

		// Token: 0x060327BD RID: 206781 RVA: 0x00E29AFC File Offset: 0x00E27CFC
		private void InitRideShareBtn()
		{
			this.RideShareBtn = base.GetButton(this.GetRideShareBtnCompId());
			UUIButtonComponent rideShareBtn = this.RideShareBtn;
			if (rideShareBtn != null)
			{
				rideShareBtn.OnPointDownCallBack.Bind(new Action(this.OnPointDownRideShareBtn));
			}
			UUIButtonComponent rideShareBtn2 = this.RideShareBtn;
			if (rideShareBtn2 != null)
			{
				rideShareBtn2.OnPointUpCallBack.Bind(new Action(this.OnPointUpRideShareBtn));
			}
			UUIButtonComponent rideShareBtn3 = this.RideShareBtn;
			if (rideShareBtn3 != null)
			{
				rideShareBtn3.OnPointExitCallBack.Bind(new Action(this.OnPointUpRideShareBtn));
			}
			this.RideSharePressConfigTime = (float)ConfigCommonParamById.GetIntConfig("AutoPilotMovieModeRideShareLongPressTime").GetValueOrDefault(1);
			this.RideSharePressConfigTime *= 1000f;
		}

		// Token: 0x060327BE RID: 206782
		protected abstract int GetExitBtnCompId();

		// Token: 0x060327BF RID: 206783 RVA: 0x00E29BAD File Offset: 0x00E27DAD
		private void InitExitBtn()
		{
			this.ExitBtn = base.GetButton(this.GetExitBtnCompId());
			if (this.ExitBtn == null)
			{
				return;
			}
			this.ExitBtn.OnClickCallBack.Bind(new Action(this.OnClickExitBtn));
		}

		// Token: 0x060327C0 RID: 206784
		protected abstract int GetMovieBtnCompId();

		// Token: 0x060327C1 RID: 206785
		protected abstract int GetMovieBtnProgressCompId();

		// Token: 0x060327C2 RID: 206786 RVA: 0x00E29BE8 File Offset: 0x00E27DE8
		private void InitMovieBtn()
		{
			this.MovieBtn = base.GetButton(this.GetMovieBtnCompId());
			UUIButtonComponent movieBtn = this.MovieBtn;
			if (movieBtn != null)
			{
				movieBtn.OnPointDownCallBack.Bind(new Action(this.OnPointDownMovieBtn));
			}
			UUIButtonComponent movieBtn2 = this.MovieBtn;
			if (movieBtn2 != null)
			{
				movieBtn2.OnPointUpCallBack.Bind(new Action(this.OnPointUpMovieBtn));
			}
			UUIButtonComponent movieBtn3 = this.MovieBtn;
			if (movieBtn3 != null)
			{
				movieBtn3.OnPointExitCallBack.Bind(new Action(this.OnPointUpMovieBtn));
			}
			this.MovieBtnProgress = base.GetTexture(this.GetMovieBtnProgressCompId());
			this.UpdateMovieBtnProgress(0f);
			this.EnterMovieModeConfigTime = (float)ConfigCommonParamById.GetIntConfig("EnterMovieModeTimeThreshold").GetValueOrDefault(1);
			this.ExitMovieModeConfigTime = (float)ConfigCommonParamById.GetIntConfig("ExitMovieModeTimeThreshold").GetValueOrDefault(1);
		}

		// Token: 0x060327C3 RID: 206787
		protected abstract int GetPhotoBtnCompId();

		// Token: 0x060327C4 RID: 206788 RVA: 0x00E29CBE File Offset: 0x00E27EBE
		private void InitPhotoBtn()
		{
			this.PhotoBtn = base.GetButton(this.GetPhotoBtnCompId());
			UUIButtonComponent photoBtn = this.PhotoBtn;
			if (photoBtn == null)
			{
				return;
			}
			photoBtn.OnClickCallBack.Bind(new Action(this.OnClickPhotoBtn));
		}

		// Token: 0x060327C5 RID: 206789 RVA: 0x00E29CF3 File Offset: 0x00E27EF3
		private void AddTick()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "AutoPilotView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x060327C6 RID: 206790 RVA: 0x00E29D1F File Offset: 0x00E27F1F
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			this.UpdateRideShareProgress(0f);
		}

		// Token: 0x060327C7 RID: 206791 RVA: 0x00E29D46 File Offset: 0x00E27F46
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x060327C8 RID: 206792 RVA: 0x00E29D62 File Offset: 0x00E27F62
		private void OnTick(float deltaTime)
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			if (instance != null && instance.GetIsCanShowSkipBtn())
			{
				this.OnTickIsCanShowSkipBtn();
			}
			this.OnTickIsCanShowMovieBtn();
			this.OnTickRideShareProgress(deltaTime);
		}

		// Token: 0x060327C9 RID: 206793 RVA: 0x00E29D8A File Offset: 0x00E27F8A
		private void OnClickSkipBtn()
		{
			this.HandleClickSkipBtn();
		}

		// Token: 0x060327CA RID: 206794
		protected abstract void HandleClickSkipBtn();

		// Token: 0x060327CB RID: 206795 RVA: 0x00E29D92 File Offset: 0x00E27F92
		private void OnClickExitBtn()
		{
			this.HandleClickExitBtn().Forget();
		}

		// Token: 0x060327CC RID: 206796 RVA: 0x00E29DA0 File Offset: 0x00E27FA0
		private UniTask HandleClickExitBtn()
		{
			AutoPilotView.<HandleClickExitBtn>d__45 <HandleClickExitBtn>d__;
			<HandleClickExitBtn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleClickExitBtn>d__.<>4__this = this;
			<HandleClickExitBtn>d__.<>1__state = -1;
			<HandleClickExitBtn>d__.<>t__builder.Start<AutoPilotView.<HandleClickExitBtn>d__45>(ref <HandleClickExitBtn>d__);
			return <HandleClickExitBtn>d__.<>t__builder.Task;
		}

		// Token: 0x060327CD RID: 206797 RVA: 0x00E29DE3 File Offset: 0x00E27FE3
		private void OnPointDownMovieBtn()
		{
			this.EnterMovieMode();
		}

		// Token: 0x060327CE RID: 206798 RVA: 0x00E29DEC File Offset: 0x00E27FEC
		private void OnPointUpMovieBtn()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			if (instance != null && instance.GetIsInMovieMode())
			{
				return;
			}
			this.ExitMovieMode(null).Forget();
		}

		// Token: 0x060327CF RID: 206799 RVA: 0x00E29E21 File Offset: 0x00E28021
		private void OnPointDownRideShareBtn()
		{
			this.IsRideSharePressed = true;
		}

		// Token: 0x060327D0 RID: 206800 RVA: 0x00E29E2A File Offset: 0x00E2802A
		private void OnPointUpRideShareBtn()
		{
			this.IsRideSharePressed = false;
		}

		// Token: 0x060327D1 RID: 206801 RVA: 0x00E29E34 File Offset: 0x00E28034
		private void EnterRideShareMode()
		{
			MovieModeController.Instance.ResetMovieModeHideUi(true);
			MovieModeModel instance = MovieModeModel.Instance;
			if (instance != null)
			{
				instance.FreezeUi("EnterRideShareMode");
			}
			if (!ShipTogetherModel.Instance.IsInMovieRideSharingMode)
			{
				this.OpenRideShareViewWithRequest().Forget();
				return;
			}
			this.OpenRideShareView().Forget();
		}

		// Token: 0x060327D2 RID: 206802 RVA: 0x00E29E84 File Offset: 0x00E28084
		private UniTask OpenRideShareViewWithRequest()
		{
			AutoPilotView.<OpenRideShareViewWithRequest>d__51 <OpenRideShareViewWithRequest>d__;
			<OpenRideShareViewWithRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRideShareViewWithRequest>d__.<>4__this = this;
			<OpenRideShareViewWithRequest>d__.<>1__state = -1;
			<OpenRideShareViewWithRequest>d__.<>t__builder.Start<AutoPilotView.<OpenRideShareViewWithRequest>d__51>(ref <OpenRideShareViewWithRequest>d__);
			return <OpenRideShareViewWithRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060327D3 RID: 206803 RVA: 0x00E29EC8 File Offset: 0x00E280C8
		private UniTask OpenRideShareView()
		{
			AutoPilotView.<OpenRideShareView>d__52 <OpenRideShareView>d__;
			<OpenRideShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRideShareView>d__.<>4__this = this;
			<OpenRideShareView>d__.<>1__state = -1;
			<OpenRideShareView>d__.<>t__builder.Start<AutoPilotView.<OpenRideShareView>d__52>(ref <OpenRideShareView>d__);
			return <OpenRideShareView>d__.<>t__builder.Task;
		}

		// Token: 0x060327D4 RID: 206804 RVA: 0x00E29F0B File Offset: 0x00E2810B
		private void OpenMotorcycleTogetherView()
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleTogetherView, null, delegate(bool success, int _)
			{
				if (!success)
				{
					MovieModeModel instance = MovieModeModel.Instance;
					if (instance != null)
					{
						instance.UnFreezeUi("EnterRideShareMode");
					}
					this.UpdateRideShareProgress(0f);
				}
			});
		}

		// Token: 0x060327D5 RID: 206805 RVA: 0x00E29F2C File Offset: 0x00E2812C
		private UniTask AwaitRideShareCamera()
		{
			AutoPilotView.<AwaitRideShareCamera>d__54 <AwaitRideShareCamera>d__;
			<AwaitRideShareCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitRideShareCamera>d__.<>1__state = -1;
			<AwaitRideShareCamera>d__.<>t__builder.Start<AutoPilotView.<AwaitRideShareCamera>d__54>(ref <AwaitRideShareCamera>d__);
			return <AwaitRideShareCamera>d__.<>t__builder.Task;
		}

		// Token: 0x060327D6 RID: 206806 RVA: 0x00E29F68 File Offset: 0x00E28168
		private UniTask AwaitEnterRideShare()
		{
			AutoPilotView.<AwaitEnterRideShare>d__55 <AwaitEnterRideShare>d__;
			<AwaitEnterRideShare>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitEnterRideShare>d__.<>1__state = -1;
			<AwaitEnterRideShare>d__.<>t__builder.Start<AutoPilotView.<AwaitEnterRideShare>d__55>(ref <AwaitEnterRideShare>d__);
			return <AwaitEnterRideShare>d__.<>t__builder.Task;
		}

		// Token: 0x060327D7 RID: 206807 RVA: 0x00E29FA4 File Offset: 0x00E281A4
		private UniTask AwaitExitRideShare()
		{
			AutoPilotView.<AwaitExitRideShare>d__56 <AwaitExitRideShare>d__;
			<AwaitExitRideShare>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitExitRideShare>d__.<>1__state = -1;
			<AwaitExitRideShare>d__.<>t__builder.Start<AutoPilotView.<AwaitExitRideShare>d__56>(ref <AwaitExitRideShare>d__);
			return <AwaitExitRideShare>d__.<>t__builder.Task;
		}

		// Token: 0x060327D8 RID: 206808 RVA: 0x00E29FE0 File Offset: 0x00E281E0
		protected void OnClickPhotoBtn()
		{
			PhotographController.Instance.ScreenShot(new PhotoSaveViewParam
			{
				ScreenShot = true,
				PrepareFullScreenShot = false,
				IsHiddenBattleView = true,
				HandBookPhotoData = null,
				GachaData = null,
				FragmentMemory = null,
				RoleSkinData = null,
				ShareId = 1
			});
		}

		// Token: 0x060327D9 RID: 206809 RVA: 0x00E2A034 File Offset: 0x00E28234
		public void EnterMovieMode()
		{
			string randomItem = MathUtils.Instance.GetRandomItem<string>(AutoPilotModel.Instance.MovieModeCameraRowNameArray);
			if (randomItem == null)
			{
				global::Log.Instance.Error(ELogModule.AutoPilot, ELogAuthor.CB, "EnterMovieMode: rowName is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IEnterCommonMovieCamera movieCameraType = new IEnterCommonMovieCamera
			{
				Type = EMovieCameraType.Common,
				RowName = randomItem
			};
			IMovieCameraConfig movieCameraConfig = new IMovieCameraConfig
			{
				MovieCameraType = movieCameraType
			};
			EnterMovieModeParams param = new EnterMovieModeParams
			{
				BlendTime = this.EnterMovieModeConfigTime,
				MovieCameraConfig = movieCameraConfig,
				Parent = this,
				UiLayer = new ELayerType?(ELayerType.Pop),
				AdaptUiLayers = new ELayerType[]
				{
					ELayerType.Normal
				},
				IsIgnoreUiLayerVisible = new bool?(true),
				IsNeedMovieModeUi = new bool?(true)
			};
			MovieModeController.Instance.EnterMovieMode(param, delegate(bool success)
			{
				if (success)
				{
					BattleUiModel instance = BattleUiModel.Instance;
					if (instance != null)
					{
						instance.SetBattleUiAlpha(1f);
					}
					BattleUiModel instance2 = BattleUiModel.Instance;
					if (instance2 != null)
					{
						BattleUiChildViewData childViewData = instance2.ChildViewData;
						if (childViewData != null)
						{
							childViewData.SetChildrenVisible(EBattleUiVisibleReason.AutoPilot, new List<EBattleUiChild>
							{
								EBattleUiChild.MiniMap,
								EBattleUiChild.MotorcycleControlHud
							}, false, true, 0);
						}
					}
					EventSystem.Instance.Emit<bool>(EEventName.OnAutoPilotTrackMarkVisibleChanged, false);
					AutoPilotModel instance3 = AutoPilotModel.Instance;
					if (instance3 != null)
					{
						instance3.SetIsInMovieMode(true);
					}
					this.RefreshUiByIsInMovieMode();
					EventSystem.Instance.Emit(EEventName.RefreshCursor);
				}
			}).Forget();
		}

		// Token: 0x060327DA RID: 206810 RVA: 0x00E2A118 File Offset: 0x00E28318
		public UniTask ExitMovieMode(float? blendTime = null)
		{
			AutoPilotView.<ExitMovieMode>d__59 <ExitMovieMode>d__;
			<ExitMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitMovieMode>d__.<>4__this = this;
			<ExitMovieMode>d__.blendTime = blendTime;
			<ExitMovieMode>d__.<>1__state = -1;
			<ExitMovieMode>d__.<>t__builder.Start<AutoPilotView.<ExitMovieMode>d__59>(ref <ExitMovieMode>d__);
			return <ExitMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x060327DB RID: 206811 RVA: 0x00E2A164 File Offset: 0x00E28364
		private void OnTickIsCanShowMovieBtn()
		{
			double autoPilotTime = AutoPilotModel.Instance.GetAutoPilotTime();
			int enterMovieModeTimeThreshold = AutoPilotModel.Instance.GetEnterMovieModeTimeThreshold();
			if (autoPilotTime < (double)enterMovieModeTimeThreshold)
			{
				this.IsCanShowMovieBtn = false;
				return;
			}
			AutoPilotModel instance = AutoPilotModel.Instance;
			AutoPilotFindPathResult autoPilotFindPathResult = (instance != null) ? instance.GetFindPathResult() : null;
			if (autoPilotFindPathResult != null)
			{
				double enterMovieModeDistanceThreshold = AutoPilotModel.Instance.GetEnterMovieModeDistanceThreshold();
				if (autoPilotFindPathResult.GetDistSquaredPlayerToEndPoint() < enterMovieModeDistanceThreshold)
				{
					this.IsCanShowMovieBtn = false;
					return;
				}
			}
			this.IsCanShowMovieBtn = true;
		}

		// Token: 0x060327DC RID: 206812 RVA: 0x00E2A1CC File Offset: 0x00E283CC
		private void OnTickIsCanShowSkipBtn()
		{
			double autoPilotTime = AutoPilotModel.Instance.GetAutoPilotTime();
			int canSkipTimeThreshold = AutoPilotModel.Instance.GetCanSkipTimeThreshold();
			if (autoPilotTime < (double)canSkipTimeThreshold)
			{
				this.IsCanShowSkipBtn = false;
			}
			AutoPilotModel instance = AutoPilotModel.Instance;
			AutoPilotFindPathResult autoPilotFindPathResult = (instance != null) ? instance.GetFindPathResult() : null;
			if (autoPilotFindPathResult != null)
			{
				double canSkipDistanceThreshold = AutoPilotModel.Instance.GetCanSkipDistanceThreshold();
				if (autoPilotFindPathResult.GetDistSquaredPlayerToEndPoint() < canSkipDistanceThreshold)
				{
					this.IsCanShowSkipBtn = false;
				}
			}
			this.IsCanShowSkipBtn = true;
		}

		// Token: 0x060327DD RID: 206813 RVA: 0x00E2A230 File Offset: 0x00E28430
		private void RefreshMovieBtnVisible()
		{
			bool isInMovieMode = AutoPilotModel.Instance.GetIsInMovieMode();
			UUIButtonComponent movieBtn = this.MovieBtn;
			if (movieBtn == null)
			{
				return;
			}
			UUIItem uuiitem = movieBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.IsCanShowMovieBtn && !isInMovieMode);
		}

		// Token: 0x060327DE RID: 206814 RVA: 0x00E2A27C File Offset: 0x00E2847C
		private void RefreshSkipBtnVisible()
		{
			UUIButtonComponent skipBtn = this.SkipBtn;
			if (skipBtn == null)
			{
				return;
			}
			UUIItem uuiitem = skipBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!this.IsMovieModeHideUi && this.IsCanShowSkipBtn);
		}

		// Token: 0x060327DF RID: 206815 RVA: 0x00E2A2BC File Offset: 0x00E284BC
		private void RefreshExitBtnVisible()
		{
			UUIButtonComponent exitBtn = this.ExitBtn;
			if (exitBtn == null)
			{
				return;
			}
			UUIItem uuiitem = exitBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!this.IsMovieModeHideUi);
		}

		// Token: 0x060327E0 RID: 206816 RVA: 0x00E2A2F4 File Offset: 0x00E284F4
		protected virtual void RefreshPhotoBtnVisible()
		{
			UUIButtonComponent photoBtn = this.PhotoBtn;
			if (photoBtn == null)
			{
				return;
			}
			UUIItem uuiitem = photoBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!this.IsMovieModeHideUi);
		}

		// Token: 0x060327E1 RID: 206817 RVA: 0x00E2A32C File Offset: 0x00E2852C
		private void RefreshRideShareBtnVisible()
		{
			bool uiactive = AutoPilotModel.Instance.GetIsInMovieMode() && !this.IsMovieModeHideUi;
			UUIButtonComponent rideShareBtn = this.RideShareBtn;
			if (rideShareBtn == null)
			{
				return;
			}
			UUIItem uuiitem = rideShareBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x060327E2 RID: 206818 RVA: 0x00E2A378 File Offset: 0x00E28578
		private void RefreshAutoPilotStateViewVisible()
		{
			bool isInMovieMode = AutoPilotModel.Instance.GetIsInMovieMode();
			AutoPilotStateView autoPilotStateView = this.AutoPilotStateView;
			if (autoPilotStateView == null)
			{
				return;
			}
			autoPilotStateView.SetUiActive(!isInMovieMode);
		}

		// Token: 0x060327E3 RID: 206819 RVA: 0x00E2A3A4 File Offset: 0x00E285A4
		protected virtual void RefreshUiVisible()
		{
			this.RefreshRideShareBtnVisible();
			this.RefreshMovieBtnVisible();
			this.RefreshSkipBtnVisible();
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
		}

		// Token: 0x060327E4 RID: 206820 RVA: 0x00E2A3C4 File Offset: 0x00E285C4
		protected virtual void RefreshUiByIsMovieModeHideUi()
		{
			this.RefreshSkipBtnVisible();
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
			this.RefreshRideShareBtnVisible();
		}

		// Token: 0x060327E5 RID: 206821 RVA: 0x00E2A3DE File Offset: 0x00E285DE
		protected virtual void RefreshUiByIsInMovieMode()
		{
			this.RefreshMovieBtnVisible();
			this.RefreshRideShareBtnVisible();
			this.RefreshAutoPilotStateViewVisible();
		}

		// Token: 0x060327E6 RID: 206822 RVA: 0x00E2A3F2 File Offset: 0x00E285F2
		[NullableContext(1)]
		private bool LockShortCutKeyDelegate(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return AutoPilotModel.Instance.GetIsInMovieMode() || actionName != "地图";
		}

		// Token: 0x060327E7 RID: 206823 RVA: 0x00E2A40D File Offset: 0x00E2860D
		[NullableContext(1)]
		private void ExitAutoPilotByInput(string axisName, float value, InputIdentification inputIdentification)
		{
			if (value == 0f)
			{
				return;
			}
			AutoPilotController.Instance.ExitAutoPilot("ExitAutoPilotByInput", false).Forget();
		}

		// Token: 0x060327E8 RID: 206824 RVA: 0x00E2A430 File Offset: 0x00E28630
		[NullableContext(1)]
		private void OnAspectOffsetUpdate(IMovieModeAspectOffset aspectOffset)
		{
			if (AutoPilotModel.Instance.GetIsInMovieMode())
			{
				return;
			}
			this.UpdateMovieBtnProgress(aspectOffset.Progress);
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAlpha(1f - aspectOffset.Progress);
			}
			BattleUiModel.Instance.SetBattleUiAlpha(1f - aspectOffset.Progress);
		}

		// Token: 0x060327E9 RID: 206825 RVA: 0x00E2A489 File Offset: 0x00E28689
		private void OnMovieModeHideUiChange(bool isHide)
		{
			this.HandleMovieModeHideUiChange(isHide).Forget();
		}

		// Token: 0x060327EA RID: 206826 RVA: 0x00E2A498 File Offset: 0x00E28698
		private UniTask HandleMovieModeHideUiChange(bool isHide)
		{
			AutoPilotView.<HandleMovieModeHideUiChange>d__75 <HandleMovieModeHideUiChange>d__;
			<HandleMovieModeHideUiChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleMovieModeHideUiChange>d__.<>4__this = this;
			<HandleMovieModeHideUiChange>d__.isHide = isHide;
			<HandleMovieModeHideUiChange>d__.<>1__state = -1;
			<HandleMovieModeHideUiChange>d__.<>t__builder.Start<AutoPilotView.<HandleMovieModeHideUiChange>d__75>(ref <HandleMovieModeHideUiChange>d__);
			return <HandleMovieModeHideUiChange>d__.<>t__builder.Task;
		}

		// Token: 0x060327EB RID: 206827 RVA: 0x00E2A4E4 File Offset: 0x00E286E4
		private void OnTickRideShareProgress(float deltaTime)
		{
			if (!AutoPilotModel.Instance.GetIsInMovieMode() || this.IsMovieModeHideUi)
			{
				return;
			}
			if (this.RideSharePressedTime >= this.RideSharePressConfigTime)
			{
				if (ShipTogetherModel.Instance.CanEnterMotorcycleMovieRideSharingMode(true))
				{
					this.EnterRideShareMode();
				}
				this.RideSharePressedTime = 0f;
				this.IsRideSharePressed = false;
				this.UpdateRideShareProgress(0f);
				return;
			}
			if (this.IsRideSharePressed)
			{
				this.RideSharePressedTime = Math.Min(this.RideSharePressedTime + deltaTime, this.RideSharePressConfigTime);
			}
			else
			{
				if (this.RideSharePressedTime <= 0f)
				{
					return;
				}
				this.RideSharePressedTime = Math.Max(this.RideSharePressedTime - deltaTime, 0f);
			}
			float progress = this.RideSharePressedTime / this.RideSharePressConfigTime;
			this.UpdateRideShareProgress(progress);
		}

		// Token: 0x060327EC RID: 206828 RVA: 0x00E2A5AB File Offset: 0x00E287AB
		protected virtual void UpdateRideShareProgress(float progress)
		{
			AutoPilotModel.Instance.RideShareBtnProgress = progress;
		}

		// Token: 0x060327ED RID: 206829 RVA: 0x00E2A5B8 File Offset: 0x00E287B8
		private void UpdateMovieBtnProgress(float progress)
		{
			UUITexture movieBtnProgress = this.MovieBtnProgress;
			if (movieBtnProgress == null)
			{
				return;
			}
			movieBtnProgress.SetFillAmount(progress);
		}

		// Token: 0x060327EE RID: 206830 RVA: 0x00E2A5CB File Offset: 0x00E287CB
		public bool IsShowCursor()
		{
			return InputDistributeModel.Instance.GetNotAllowFightInputViewNameSet().Count > 0 || (AutoPilotModel.Instance.GetIsInMovieMode() && !this.IsMovieModeHideUi);
		}

		// Token: 0x060327EF RID: 206831 RVA: 0x00E2A5F8 File Offset: 0x00E287F8
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.MotorcycleTogetherView)
			{
				return;
			}
			MovieModeModel instance = MovieModeModel.Instance;
			if (instance != null)
			{
				instance.UnFreezeUi("EnterRideShareMode");
			}
			this.UpdateRideShareProgress(0f);
		}

		// Token: 0x060327F0 RID: 206832 RVA: 0x00E2A628 File Offset: 0x00E28828
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x060327F1 RID: 206833 RVA: 0x00E2A64B File Offset: 0x00E2884B
		protected override void OnBeforeDestroy()
		{
			BattleUiModel.Instance.SetBattleUiAlpha(1f);
			MovieModeModel instance = MovieModeModel.Instance;
			if (instance != null)
			{
				instance.UnFreezeUi("EnterRideShareMode");
			}
			this.RemoveTick();
			this.RemoveEvents();
		}

		// Token: 0x0401AC62 RID: 109666
		private AutoPilotStateView AutoPilotStateView;

		// Token: 0x0401AC63 RID: 109667
		private int TickId = -1;

		// Token: 0x0401AC64 RID: 109668
		private UUITexture MovieBtnProgress;

		// Token: 0x0401AC65 RID: 109669
		private UUIButtonComponent SkipBtn;

		// Token: 0x0401AC66 RID: 109670
		private UUIButtonComponent MovieBtn;

		// Token: 0x0401AC67 RID: 109671
		private UUIButtonComponent RideShareBtn;

		// Token: 0x0401AC68 RID: 109672
		private UUIButtonComponent ExitBtn;

		// Token: 0x0401AC69 RID: 109673
		protected UUIButtonComponent PhotoBtn;

		// Token: 0x0401AC6A RID: 109674
		protected bool IsMovieModeHideUi;

		// Token: 0x0401AC6B RID: 109675
		private bool IsRideSharePressed;

		// Token: 0x0401AC6C RID: 109676
		private float RideSharePressedTime;

		// Token: 0x0401AC6D RID: 109677
		private float RideSharePressConfigTime;

		// Token: 0x0401AC6E RID: 109678
		private float EnterMovieModeConfigTime;

		// Token: 0x0401AC6F RID: 109679
		private float ExitMovieModeConfigTime;

		// Token: 0x0401AC70 RID: 109680
		private bool IsCanShowMovieBtnInner;

		// Token: 0x0401AC71 RID: 109681
		private bool IsCanShowSkipBtnInner;
	}
}
