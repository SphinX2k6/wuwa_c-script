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
	// Token: 0x02005E78 RID: 24184
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class AutoPilotView : UiPanelBase, IExtraShowCursor
	{
		// Token: 0x17008E84 RID: 36484
		// (get) Token: 0x0603D822 RID: 251938 RVA: 0x00ED82BF File Offset: 0x00ED64BF
		// (set) Token: 0x0603D821 RID: 251937 RVA: 0x00ED828F File Offset: 0x00ED648F
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

		// Token: 0x17008E85 RID: 36485
		// (get) Token: 0x0603D824 RID: 251940 RVA: 0x00ED82DF File Offset: 0x00ED64DF
		// (set) Token: 0x0603D823 RID: 251939 RVA: 0x00ED82C7 File Offset: 0x00ED64C7
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

		// Token: 0x0603D825 RID: 251941 RVA: 0x00ED82E8 File Offset: 0x00ED64E8
		protected override UniTask OnBeforeStartAsync()
		{
			AutoPilotView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AutoPilotView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D826 RID: 251942 RVA: 0x00ED832B File Offset: 0x00ED652B
		protected override void OnStart()
		{
			this.AddTick();
			this.InitUi();
			this.RefreshUiVisible();
			this.AddEvents();
		}

		// Token: 0x0603D827 RID: 251943 RVA: 0x00ED8345 File Offset: 0x00ED6545
		protected virtual void InitUi()
		{
			this.InitSkipBtn();
			this.InitExitBtn();
			this.InitMovieBtn();
			this.InitRideShareBtn();
			this.InitPhotoBtn();
			EventSystem.Instance.Emit<bool>(EEventName.OnAutoPilotTrackMarkVisibleChanged, true);
		}

		// Token: 0x0603D828 RID: 251944 RVA: 0x00ED8378 File Offset: 0x00ED6578
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

		// Token: 0x0603D829 RID: 251945 RVA: 0x00ED8444 File Offset: 0x00ED6644
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

		// Token: 0x0603D82A RID: 251946
		protected abstract int GetSkipBtnCompId();

		// Token: 0x0603D82B RID: 251947 RVA: 0x00ED8504 File Offset: 0x00ED6704
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

		// Token: 0x0603D82C RID: 251948
		protected abstract int GetRideShareBtnCompId();

		// Token: 0x0603D82D RID: 251949 RVA: 0x00ED8570 File Offset: 0x00ED6770
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

		// Token: 0x0603D82E RID: 251950
		protected abstract int GetExitBtnCompId();

		// Token: 0x0603D82F RID: 251951 RVA: 0x00ED8621 File Offset: 0x00ED6821
		private void InitExitBtn()
		{
			this.ExitBtn = base.GetButton(this.GetExitBtnCompId());
			if (this.ExitBtn == null)
			{
				return;
			}
			this.ExitBtn.OnClickCallBack.Bind(new Action(this.OnClickExitBtn));
		}

		// Token: 0x0603D830 RID: 251952
		protected abstract int GetMovieBtnCompId();

		// Token: 0x0603D831 RID: 251953
		protected abstract int GetMovieBtnProgressCompId();

		// Token: 0x0603D832 RID: 251954 RVA: 0x00ED865C File Offset: 0x00ED685C
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

		// Token: 0x0603D833 RID: 251955
		protected abstract int GetPhotoBtnCompId();

		// Token: 0x0603D834 RID: 251956 RVA: 0x00ED8732 File Offset: 0x00ED6932
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

		// Token: 0x0603D835 RID: 251957 RVA: 0x00ED8767 File Offset: 0x00ED6967
		private void AddTick()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "AutoPilotView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0603D836 RID: 251958 RVA: 0x00ED8793 File Offset: 0x00ED6993
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			this.UpdateRideShareProgress(0f);
		}

		// Token: 0x0603D837 RID: 251959 RVA: 0x00ED87BA File Offset: 0x00ED69BA
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0603D838 RID: 251960 RVA: 0x00ED87D6 File Offset: 0x00ED69D6
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

		// Token: 0x0603D839 RID: 251961 RVA: 0x00ED87FE File Offset: 0x00ED69FE
		private void OnClickSkipBtn()
		{
			this.HandleClickSkipBtn();
		}

		// Token: 0x0603D83A RID: 251962
		protected abstract void HandleClickSkipBtn();

		// Token: 0x0603D83B RID: 251963 RVA: 0x00ED8806 File Offset: 0x00ED6A06
		private void OnClickExitBtn()
		{
			this.HandleClickExitBtn().Forget();
		}

		// Token: 0x0603D83C RID: 251964 RVA: 0x00ED8814 File Offset: 0x00ED6A14
		private UniTask HandleClickExitBtn()
		{
			AutoPilotView.<HandleClickExitBtn>d__45 <HandleClickExitBtn>d__;
			<HandleClickExitBtn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleClickExitBtn>d__.<>4__this = this;
			<HandleClickExitBtn>d__.<>1__state = -1;
			<HandleClickExitBtn>d__.<>t__builder.Start<AutoPilotView.<HandleClickExitBtn>d__45>(ref <HandleClickExitBtn>d__);
			return <HandleClickExitBtn>d__.<>t__builder.Task;
		}

		// Token: 0x0603D83D RID: 251965 RVA: 0x00ED8857 File Offset: 0x00ED6A57
		private void OnPointDownMovieBtn()
		{
			this.EnterMovieMode();
		}

		// Token: 0x0603D83E RID: 251966 RVA: 0x00ED8860 File Offset: 0x00ED6A60
		private void OnPointUpMovieBtn()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			if (instance != null && instance.GetIsInMovieMode())
			{
				return;
			}
			this.ExitMovieMode(null).Forget();
		}

		// Token: 0x0603D83F RID: 251967 RVA: 0x00ED8895 File Offset: 0x00ED6A95
		private void OnPointDownRideShareBtn()
		{
			this.IsRideSharePressed = true;
		}

		// Token: 0x0603D840 RID: 251968 RVA: 0x00ED889E File Offset: 0x00ED6A9E
		private void OnPointUpRideShareBtn()
		{
			this.IsRideSharePressed = false;
		}

		// Token: 0x0603D841 RID: 251969 RVA: 0x00ED88A8 File Offset: 0x00ED6AA8
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

		// Token: 0x0603D842 RID: 251970 RVA: 0x00ED88F8 File Offset: 0x00ED6AF8
		private UniTask OpenRideShareViewWithRequest()
		{
			AutoPilotView.<OpenRideShareViewWithRequest>d__51 <OpenRideShareViewWithRequest>d__;
			<OpenRideShareViewWithRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRideShareViewWithRequest>d__.<>4__this = this;
			<OpenRideShareViewWithRequest>d__.<>1__state = -1;
			<OpenRideShareViewWithRequest>d__.<>t__builder.Start<AutoPilotView.<OpenRideShareViewWithRequest>d__51>(ref <OpenRideShareViewWithRequest>d__);
			return <OpenRideShareViewWithRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603D843 RID: 251971 RVA: 0x00ED893C File Offset: 0x00ED6B3C
		private UniTask OpenRideShareView()
		{
			AutoPilotView.<OpenRideShareView>d__52 <OpenRideShareView>d__;
			<OpenRideShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRideShareView>d__.<>4__this = this;
			<OpenRideShareView>d__.<>1__state = -1;
			<OpenRideShareView>d__.<>t__builder.Start<AutoPilotView.<OpenRideShareView>d__52>(ref <OpenRideShareView>d__);
			return <OpenRideShareView>d__.<>t__builder.Task;
		}

		// Token: 0x0603D844 RID: 251972 RVA: 0x00ED897F File Offset: 0x00ED6B7F
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

		// Token: 0x0603D845 RID: 251973 RVA: 0x00ED89A0 File Offset: 0x00ED6BA0
		private UniTask AwaitRideShareCamera()
		{
			AutoPilotView.<AwaitRideShareCamera>d__54 <AwaitRideShareCamera>d__;
			<AwaitRideShareCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitRideShareCamera>d__.<>1__state = -1;
			<AwaitRideShareCamera>d__.<>t__builder.Start<AutoPilotView.<AwaitRideShareCamera>d__54>(ref <AwaitRideShareCamera>d__);
			return <AwaitRideShareCamera>d__.<>t__builder.Task;
		}

		// Token: 0x0603D846 RID: 251974 RVA: 0x00ED89DC File Offset: 0x00ED6BDC
		private UniTask AwaitEnterRideShare()
		{
			AutoPilotView.<AwaitEnterRideShare>d__55 <AwaitEnterRideShare>d__;
			<AwaitEnterRideShare>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitEnterRideShare>d__.<>1__state = -1;
			<AwaitEnterRideShare>d__.<>t__builder.Start<AutoPilotView.<AwaitEnterRideShare>d__55>(ref <AwaitEnterRideShare>d__);
			return <AwaitEnterRideShare>d__.<>t__builder.Task;
		}

		// Token: 0x0603D847 RID: 251975 RVA: 0x00ED8A18 File Offset: 0x00ED6C18
		private UniTask AwaitExitRideShare()
		{
			AutoPilotView.<AwaitExitRideShare>d__56 <AwaitExitRideShare>d__;
			<AwaitExitRideShare>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitExitRideShare>d__.<>1__state = -1;
			<AwaitExitRideShare>d__.<>t__builder.Start<AutoPilotView.<AwaitExitRideShare>d__56>(ref <AwaitExitRideShare>d__);
			return <AwaitExitRideShare>d__.<>t__builder.Task;
		}

		// Token: 0x0603D848 RID: 251976 RVA: 0x00ED8A54 File Offset: 0x00ED6C54
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

		// Token: 0x0603D849 RID: 251977 RVA: 0x00ED8AA8 File Offset: 0x00ED6CA8
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

		// Token: 0x0603D84A RID: 251978 RVA: 0x00ED8B8C File Offset: 0x00ED6D8C
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

		// Token: 0x0603D84B RID: 251979 RVA: 0x00ED8BD8 File Offset: 0x00ED6DD8
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

		// Token: 0x0603D84C RID: 251980 RVA: 0x00ED8C40 File Offset: 0x00ED6E40
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

		// Token: 0x0603D84D RID: 251981 RVA: 0x00ED8CA4 File Offset: 0x00ED6EA4
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

		// Token: 0x0603D84E RID: 251982 RVA: 0x00ED8CF0 File Offset: 0x00ED6EF0
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

		// Token: 0x0603D84F RID: 251983 RVA: 0x00ED8D30 File Offset: 0x00ED6F30
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

		// Token: 0x0603D850 RID: 251984 RVA: 0x00ED8D68 File Offset: 0x00ED6F68
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

		// Token: 0x0603D851 RID: 251985 RVA: 0x00ED8DA0 File Offset: 0x00ED6FA0
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

		// Token: 0x0603D852 RID: 251986 RVA: 0x00ED8DEC File Offset: 0x00ED6FEC
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

		// Token: 0x0603D853 RID: 251987 RVA: 0x00ED8E18 File Offset: 0x00ED7018
		protected virtual void RefreshUiVisible()
		{
			this.RefreshRideShareBtnVisible();
			this.RefreshMovieBtnVisible();
			this.RefreshSkipBtnVisible();
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
		}

		// Token: 0x0603D854 RID: 251988 RVA: 0x00ED8E38 File Offset: 0x00ED7038
		protected virtual void RefreshUiByIsMovieModeHideUi()
		{
			this.RefreshSkipBtnVisible();
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
			this.RefreshRideShareBtnVisible();
		}

		// Token: 0x0603D855 RID: 251989 RVA: 0x00ED8E52 File Offset: 0x00ED7052
		protected virtual void RefreshUiByIsInMovieMode()
		{
			this.RefreshMovieBtnVisible();
			this.RefreshRideShareBtnVisible();
			this.RefreshAutoPilotStateViewVisible();
		}

		// Token: 0x0603D856 RID: 251990 RVA: 0x00ED8E66 File Offset: 0x00ED7066
		[NullableContext(1)]
		private bool LockShortCutKeyDelegate(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return AutoPilotModel.Instance.GetIsInMovieMode() || actionName != "地图";
		}

		// Token: 0x0603D857 RID: 251991 RVA: 0x00ED8E81 File Offset: 0x00ED7081
		[NullableContext(1)]
		private void ExitAutoPilotByInput(string axisName, float value, InputIdentification inputIdentification)
		{
			if (value == 0f)
			{
				return;
			}
			AutoPilotController.Instance.ExitAutoPilot("ExitAutoPilotByInput", false).Forget();
		}

		// Token: 0x0603D858 RID: 251992 RVA: 0x00ED8EA4 File Offset: 0x00ED70A4
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

		// Token: 0x0603D859 RID: 251993 RVA: 0x00ED8EFD File Offset: 0x00ED70FD
		private void OnMovieModeHideUiChange(bool isHide)
		{
			this.HandleMovieModeHideUiChange(isHide).Forget();
		}

		// Token: 0x0603D85A RID: 251994 RVA: 0x00ED8F0C File Offset: 0x00ED710C
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

		// Token: 0x0603D85B RID: 251995 RVA: 0x00ED8F58 File Offset: 0x00ED7158
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

		// Token: 0x0603D85C RID: 251996 RVA: 0x00ED901F File Offset: 0x00ED721F
		protected virtual void UpdateRideShareProgress(float progress)
		{
			AutoPilotModel.Instance.RideShareBtnProgress = progress;
		}

		// Token: 0x0603D85D RID: 251997 RVA: 0x00ED902C File Offset: 0x00ED722C
		private void UpdateMovieBtnProgress(float progress)
		{
			UUITexture movieBtnProgress = this.MovieBtnProgress;
			if (movieBtnProgress == null)
			{
				return;
			}
			movieBtnProgress.SetFillAmount(progress);
		}

		// Token: 0x0603D85E RID: 251998 RVA: 0x00ED903F File Offset: 0x00ED723F
		public bool IsShowCursor()
		{
			return InputDistributeModel.Instance.GetNotAllowFightInputViewNameSet().Count > 0 || (AutoPilotModel.Instance.GetIsInMovieMode() && !this.IsMovieModeHideUi);
		}

		// Token: 0x0603D85F RID: 251999 RVA: 0x00ED906C File Offset: 0x00ED726C
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

		// Token: 0x0603D860 RID: 252000 RVA: 0x00ED909C File Offset: 0x00ED729C
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x0603D861 RID: 252001 RVA: 0x00ED90BF File Offset: 0x00ED72BF
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

		// Token: 0x0402019B RID: 131483
		private AutoPilotStateView AutoPilotStateView;

		// Token: 0x0402019C RID: 131484
		private int TickId = -1;

		// Token: 0x0402019D RID: 131485
		private UUITexture MovieBtnProgress;

		// Token: 0x0402019E RID: 131486
		private UUIButtonComponent SkipBtn;

		// Token: 0x0402019F RID: 131487
		private UUIButtonComponent MovieBtn;

		// Token: 0x040201A0 RID: 131488
		private UUIButtonComponent RideShareBtn;

		// Token: 0x040201A1 RID: 131489
		private UUIButtonComponent ExitBtn;

		// Token: 0x040201A2 RID: 131490
		protected UUIButtonComponent PhotoBtn;

		// Token: 0x040201A3 RID: 131491
		protected bool IsMovieModeHideUi;

		// Token: 0x040201A4 RID: 131492
		private bool IsRideSharePressed;

		// Token: 0x040201A5 RID: 131493
		private float RideSharePressedTime;

		// Token: 0x040201A6 RID: 131494
		private float RideSharePressConfigTime;

		// Token: 0x040201A7 RID: 131495
		private float EnterMovieModeConfigTime;

		// Token: 0x040201A8 RID: 131496
		private float ExitMovieModeConfigTime;

		// Token: 0x040201A9 RID: 131497
		private bool IsCanShowMovieBtnInner;

		// Token: 0x040201AA RID: 131498
		private bool IsCanShowSkipBtnInner;
	}
}
