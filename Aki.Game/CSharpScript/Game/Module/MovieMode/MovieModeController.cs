using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004360 RID: 17248
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MovieModeController : UiControllerBase
	{
		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x0602B8D9 RID: 178393 RVA: 0x00C3CE1C File Offset: 0x00C3B01C
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0602B8DA RID: 178394 RVA: 0x00C3CE1F File Offset: 0x00C3B01F
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602B8DB RID: 178395 RVA: 0x00C3CE24 File Offset: 0x00C3B024
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.PlotSequenceStarted, new Action(this.PlotSequenceStarted));
			EventSystem.Instance.Add(EEventName.PlotSequenceEnd, new Action(this.PlotSequenceEnd));
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		}

		// Token: 0x0602B8DC RID: 178396 RVA: 0x00C3CE84 File Offset: 0x00C3B084
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.PlotSequenceStarted));
			EventSystem.Instance.Remove(EEventName.PlotSequenceEnd, new Action(this.PlotSequenceEnd));
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		}

		// Token: 0x0602B8DD RID: 178397 RVA: 0x00C3CEE2 File Offset: 0x00C3B0E2
		private void OnUiViewPortSizeChanged()
		{
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			if (movieModeAspectView == null)
			{
				return;
			}
			movieModeAspectView.UpdateTransform();
		}

		// Token: 0x0602B8DE RID: 178398 RVA: 0x00C3CEF4 File Offset: 0x00C3B0F4
		public int AddTick(Action<float> handle)
		{
			this.TickHandleId++;
			this.TickGroup[this.TickHandleId] = handle;
			return this.TickHandleId;
		}

		// Token: 0x0602B8DF RID: 178399 RVA: 0x00C3CF1C File Offset: 0x00C3B11C
		public void RemoveTick(int id)
		{
			this.TickGroup.Remove(id);
		}

		// Token: 0x0602B8E0 RID: 178400 RVA: 0x00C3CF2C File Offset: 0x00C3B12C
		protected override void OnTick(float delta)
		{
			if (this.TickGroup.Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<int, Action<float>> keyValuePair in this.TickGroup)
			{
				keyValuePair.Value(delta);
			}
		}

		// Token: 0x0602B8E1 RID: 178401 RVA: 0x00C3CF94 File Offset: 0x00C3B194
		public UniTask EnterMovieMode(IEnterMovieModeParams param, [Nullable(2)] Action<bool> callBack = null)
		{
			MovieModeController.<EnterMovieMode>d__15 <EnterMovieMode>d__;
			<EnterMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterMovieMode>d__.<>4__this = this;
			<EnterMovieMode>d__.param = param;
			<EnterMovieMode>d__.callBack = callBack;
			<EnterMovieMode>d__.<>1__state = -1;
			<EnterMovieMode>d__.<>t__builder.Start<MovieModeController.<EnterMovieMode>d__15>(ref <EnterMovieMode>d__);
			return <EnterMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E2 RID: 178402 RVA: 0x00C3CFE8 File Offset: 0x00C3B1E8
		private UniTask ExecuteEnter(IEnterMovieModeParams param)
		{
			MovieModeController.<ExecuteEnter>d__16 <ExecuteEnter>d__;
			<ExecuteEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEnter>d__.<>4__this = this;
			<ExecuteEnter>d__.param = param;
			<ExecuteEnter>d__.<>1__state = -1;
			<ExecuteEnter>d__.<>t__builder.Start<MovieModeController.<ExecuteEnter>d__16>(ref <ExecuteEnter>d__);
			return <ExecuteEnter>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E3 RID: 178403 RVA: 0x00C3D034 File Offset: 0x00C3B234
		public UniTask ExitMovieMode(IExitMovieModeParams param, [Nullable(2)] Action<bool> callBack = null)
		{
			MovieModeController.<ExitMovieMode>d__17 <ExitMovieMode>d__;
			<ExitMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitMovieMode>d__.<>4__this = this;
			<ExitMovieMode>d__.param = param;
			<ExitMovieMode>d__.callBack = callBack;
			<ExitMovieMode>d__.<>1__state = -1;
			<ExitMovieMode>d__.<>t__builder.Start<MovieModeController.<ExitMovieMode>d__17>(ref <ExitMovieMode>d__);
			return <ExitMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E4 RID: 178404 RVA: 0x00C3D088 File Offset: 0x00C3B288
		private UniTask ExecuteExit(IExitMovieModeParams param)
		{
			MovieModeController.<ExecuteExit>d__18 <ExecuteExit>d__;
			<ExecuteExit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteExit>d__.<>4__this = this;
			<ExecuteExit>d__.param = param;
			<ExecuteExit>d__.<>1__state = -1;
			<ExecuteExit>d__.<>t__builder.Start<MovieModeController.<ExecuteExit>d__18>(ref <ExecuteExit>d__);
			return <ExecuteExit>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E5 RID: 178405 RVA: 0x00C3D0D4 File Offset: 0x00C3B2D4
		public UniTask CreateAspectView(IEnterMovieModeParams param)
		{
			MovieModeController.<CreateAspectView>d__19 <CreateAspectView>d__;
			<CreateAspectView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAspectView>d__.<>4__this = this;
			<CreateAspectView>d__.param = param;
			<CreateAspectView>d__.<>1__state = -1;
			<CreateAspectView>d__.<>t__builder.Start<MovieModeController.<CreateAspectView>d__19>(ref <CreateAspectView>d__);
			return <CreateAspectView>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E6 RID: 178406 RVA: 0x00C3D120 File Offset: 0x00C3B320
		public UniTask RemoveAspectView(IExitMovieModeParams param)
		{
			MovieModeController.<RemoveAspectView>d__20 <RemoveAspectView>d__;
			<RemoveAspectView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveAspectView>d__.<>4__this = this;
			<RemoveAspectView>d__.param = param;
			<RemoveAspectView>d__.<>1__state = -1;
			<RemoveAspectView>d__.<>t__builder.Start<MovieModeController.<RemoveAspectView>d__20>(ref <RemoveAspectView>d__);
			return <RemoveAspectView>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E7 RID: 178407 RVA: 0x00C3D16C File Offset: 0x00C3B36C
		public UniTask CreateUiView(IEnterMovieModeParams param)
		{
			MovieModeController.<CreateUiView>d__21 <CreateUiView>d__;
			<CreateUiView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateUiView>d__.<>4__this = this;
			<CreateUiView>d__.param = param;
			<CreateUiView>d__.<>1__state = -1;
			<CreateUiView>d__.<>t__builder.Start<MovieModeController.<CreateUiView>d__21>(ref <CreateUiView>d__);
			return <CreateUiView>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8E8 RID: 178408 RVA: 0x00C3D1B7 File Offset: 0x00C3B3B7
		public void RemoveUiView()
		{
			MovieModeUiView movieModeUiView = this.MovieModeUiView;
			if (movieModeUiView != null)
			{
				movieModeUiView.Destroy(null);
			}
			this.MovieModeUiView = null;
		}

		// Token: 0x0602B8E9 RID: 178409 RVA: 0x00C3D1D2 File Offset: 0x00C3B3D2
		public bool IsHorizontalBlackBarsVisible()
		{
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			return movieModeAspectView != null && movieModeAspectView.IsHorizontalBlackBarsVisible();
		}

		// Token: 0x0602B8EA RID: 178410 RVA: 0x00C3D1E5 File Offset: 0x00C3B3E5
		[NullableContext(2)]
		public IMovieModeAspectOffset GetAspectOffset()
		{
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			if (movieModeAspectView == null)
			{
				return null;
			}
			return movieModeAspectView.GetAspectOffset();
		}

		// Token: 0x0602B8EB RID: 178411 RVA: 0x00C3D1F8 File Offset: 0x00C3B3F8
		private void CancelEnterMovieMode()
		{
			global::Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "取消进入电影模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			if (movieModeAspectView != null)
			{
				movieModeAspectView.FadeReverse();
			}
			this.CurrentState = EMovieModeState.CancelEnter;
		}

		// Token: 0x0602B8EC RID: 178412 RVA: 0x00C3D23C File Offset: 0x00C3B43C
		private void ReEnterMovieMode()
		{
			global::Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "重新进入电影模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			if (movieModeAspectView != null)
			{
				movieModeAspectView.FadeReverse();
			}
			this.CurrentState = EMovieModeState.Entering;
		}

		// Token: 0x0602B8ED RID: 178413 RVA: 0x00C3D280 File Offset: 0x00C3B480
		private unsafe void PlayMovieCamera(IEnterMovieModeParams param)
		{
			if (param.MovieCameraConfig == null)
			{
				global::Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "进入电影模式没有配置对应电影镜头", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IEnterMovieCameraType movieCameraType = param.MovieCameraConfig.MovieCameraType;
			if (movieCameraType.Type == EMovieCameraType.Common)
			{
				IEnterCommonMovieCamera enterCommonMovieCamera = movieCameraType as IEnterCommonMovieCamera;
				string rowName = enterCommonMovieCamera.RowName;
				int initialIndex = enterCommonMovieCamera.SpecElementIndex.GetValueOrDefault(-1);
				CameraModel.Instance.MainModel.PlayMovieCamera(rowName, initialIndex, delegate(bool success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.MovieMode;
					ELogAuthor author = ELogAuthor.CB;
					string message = "[电影镜头]通过MovieModeController进入常规电影镜头结果";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("success", success);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RowName", rowName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("InitialIndex", initialIndex);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				});
				return;
			}
			if (movieCameraType.Type == EMovieCameraType.Spec)
			{
				IEnterSpecMovieCamera enterSpecMovieCamera = movieCameraType as IEnterSpecMovieCamera;
				string rowName = enterSpecMovieCamera.RowName;
				CameraModel.Instance.MainModel.PlaySpecialMovieCamera(rowName, delegate(bool success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.MovieMode;
					ELogAuthor author = ELogAuthor.CB;
					string message = "[电影镜头]通过MovieModeController进入特殊电影镜头结果";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("success", success);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RowName", rowName);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				});
			}
		}

		// Token: 0x0602B8EE RID: 178414 RVA: 0x00C3D36C File Offset: 0x00C3B56C
		private UniTask StopMovieCamera()
		{
			MovieModeController.<StopMovieCamera>d__28 <StopMovieCamera>d__;
			<StopMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StopMovieCamera>d__.<>1__state = -1;
			<StopMovieCamera>d__.<>t__builder.Start<MovieModeController.<StopMovieCamera>d__28>(ref <StopMovieCamera>d__);
			return <StopMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8EF RID: 178415 RVA: 0x00C3D3A8 File Offset: 0x00C3B5A8
		public void ResumeMovieCamera()
		{
			CameraModel.Instance.MainModel.ResumeMovieCamera();
			global::Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "[电影镜头]通过MovieModeController恢复电影镜头播放", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B8F0 RID: 178416 RVA: 0x00C3D3E4 File Offset: 0x00C3B5E4
		public UniTask PlaySpecialMovieCamera(string specialRowName)
		{
			MovieModeController.<PlaySpecialMovieCamera>d__30 <PlaySpecialMovieCamera>d__;
			<PlaySpecialMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySpecialMovieCamera>d__.specialRowName = specialRowName;
			<PlaySpecialMovieCamera>d__.<>1__state = -1;
			<PlaySpecialMovieCamera>d__.<>t__builder.Start<MovieModeController.<PlaySpecialMovieCamera>d__30>(ref <PlaySpecialMovieCamera>d__);
			return <PlaySpecialMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8F1 RID: 178417 RVA: 0x00C3D427 File Offset: 0x00C3B627
		public bool IsPlayingSpecialMovieCamera(string specialRowName)
		{
			return CameraModel.Instance.MainModel.IsPlayingSpecialMovieCamera(specialRowName);
		}

		// Token: 0x0602B8F2 RID: 178418 RVA: 0x00C3D439 File Offset: 0x00C3B639
		public void ResetMovieModeHideUi(bool isHide)
		{
			if (MovieModeModel.Instance.IsFreezingUi)
			{
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.MovieModeHideUiChange, isHide);
			MovieModeUiView movieModeUiView = this.MovieModeUiView;
			if (movieModeUiView == null)
			{
				return;
			}
			movieModeUiView.ActivateTimer();
		}

		// Token: 0x0602B8F3 RID: 178419 RVA: 0x00C3D46C File Offset: 0x00C3B66C
		private void PlotSequenceStarted()
		{
			MovieModeUiView movieModeUiView = this.MovieModeUiView;
			if (movieModeUiView != null)
			{
				movieModeUiView.SetUiActive(false);
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "电影模式UI显示状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isActive", false);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.IsAutoExitInFlowSequence)
			{
				this.ExitMovieMode(new ExitMovieModeParams
				{
					BlendTime = 0f
				}, null).Forget();
				this.IsAutoExitInFlowSequence = false;
			}
		}

		// Token: 0x0602B8F4 RID: 178420 RVA: 0x00C3D4E8 File Offset: 0x00C3B6E8
		private void PlotSequenceEnd()
		{
			MovieModeUiView movieModeUiView = this.MovieModeUiView;
			if (movieModeUiView != null)
			{
				movieModeUiView.SetUiActive(true);
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "电影模式UI显示状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isActive", true);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602B8F5 RID: 178421 RVA: 0x00C3D536 File Offset: 0x00C3B736
		public void ClearViews()
		{
			if (this.MovieModeAspectView != null)
			{
				this.MovieModeAspectView.Destroy(null);
				this.MovieModeAspectView = null;
			}
			if (this.MovieModeUiView != null)
			{
				this.MovieModeUiView.Destroy(null);
				this.MovieModeUiView = null;
			}
			this.CurrentState = EMovieModeState.Idle;
		}

		// Token: 0x0602B8F6 RID: 178422 RVA: 0x00C3D575 File Offset: 0x00C3B775
		public bool IsInMovieMode()
		{
			return this.CurrentState > EMovieModeState.Idle;
		}

		// Token: 0x0602B8F7 RID: 178423 RVA: 0x00C3D580 File Offset: 0x00C3B780
		protected override bool OnClear()
		{
			this.ClearViews();
			this.TickGroup.Clear();
			return true;
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x0602B8F8 RID: 178424 RVA: 0x00C3D594 File Offset: 0x00C3B794
		public static MovieModeController Instance
		{
			get
			{
				return MovieModeController._Instance;
			}
		}

		// Token: 0x0602B8F9 RID: 178425 RVA: 0x00C3D59B File Offset: 0x00C3B79B
		public static MovieModeController GetOrCreateInstance()
		{
			if (MovieModeController._Instance == null)
			{
				MovieModeController.CreateInstance();
			}
			return MovieModeController._Instance;
		}

		// Token: 0x0602B8FA RID: 178426 RVA: 0x00C3D5AF File Offset: 0x00C3B7AF
		public static bool CreateInstance()
		{
			if (MovieModeController._Instance != null)
			{
				return true;
			}
			MovieModeController._Instance = new MovieModeController();
			return true;
		}

		// Token: 0x0602B8FB RID: 178427 RVA: 0x00C3D5C5 File Offset: 0x00C3B7C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B8FC RID: 178428 RVA: 0x00C3D5C7 File Offset: 0x00C3B7C7
		public static void ResetStaticDefaultValue()
		{
			MovieModeController._Instance = null;
		}

		// Token: 0x0602B8FD RID: 178429 RVA: 0x00C3D5CF File Offset: 0x00C3B7CF
		static MovieModeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MovieModeController.CreateStaticDefaultValue), new Action(MovieModeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401785D RID: 96349
		[Nullable(2)]
		private MovieModeAspectView MovieModeAspectView;

		// Token: 0x0401785E RID: 96350
		[Nullable(2)]
		private MovieModeUiView MovieModeUiView;

		// Token: 0x0401785F RID: 96351
		private int TickHandleId;

		// Token: 0x04017860 RID: 96352
		private readonly Dictionary<int, Action<float>> TickGroup = new Dictionary<int, Action<float>>();

		// Token: 0x04017861 RID: 96353
		private EMovieModeState CurrentState;

		// Token: 0x04017862 RID: 96354
		private bool IsAutoExitInFlowSequence;

		// Token: 0x04017863 RID: 96355
		[Nullable(2)]
		private static MovieModeController _Instance;
	}
}
