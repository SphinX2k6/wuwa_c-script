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
	// Token: 0x0200537D RID: 21373
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MovieModeController : UiControllerBase
	{
		// Token: 0x17008361 RID: 33633
		// (get) Token: 0x06036993 RID: 223635 RVA: 0x00CEDEF4 File Offset: 0x00CEC0F4
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06036994 RID: 223636 RVA: 0x00CEDEF7 File Offset: 0x00CEC0F7
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036995 RID: 223637 RVA: 0x00CEDEFC File Offset: 0x00CEC0FC
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.PlotSequenceStarted, new Action(this.PlotSequenceStarted));
			EventSystem.Instance.Add(EEventName.PlotSequenceEnd, new Action(this.PlotSequenceEnd));
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		}

		// Token: 0x06036996 RID: 223638 RVA: 0x00CEDF5C File Offset: 0x00CEC15C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.PlotSequenceStarted));
			EventSystem.Instance.Remove(EEventName.PlotSequenceEnd, new Action(this.PlotSequenceEnd));
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		}

		// Token: 0x06036997 RID: 223639 RVA: 0x00CEDFBA File Offset: 0x00CEC1BA
		private void OnUiViewPortSizeChanged()
		{
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			if (movieModeAspectView == null)
			{
				return;
			}
			movieModeAspectView.UpdateTransform();
		}

		// Token: 0x06036998 RID: 223640 RVA: 0x00CEDFCC File Offset: 0x00CEC1CC
		public int AddTick(Action<float> handle)
		{
			this.TickHandleId++;
			this.TickGroup[this.TickHandleId] = handle;
			return this.TickHandleId;
		}

		// Token: 0x06036999 RID: 223641 RVA: 0x00CEDFF4 File Offset: 0x00CEC1F4
		public void RemoveTick(int id)
		{
			this.TickGroup.Remove(id);
		}

		// Token: 0x0603699A RID: 223642 RVA: 0x00CEE004 File Offset: 0x00CEC204
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

		// Token: 0x0603699B RID: 223643 RVA: 0x00CEE06C File Offset: 0x00CEC26C
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

		// Token: 0x0603699C RID: 223644 RVA: 0x00CEE0C0 File Offset: 0x00CEC2C0
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

		// Token: 0x0603699D RID: 223645 RVA: 0x00CEE10C File Offset: 0x00CEC30C
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

		// Token: 0x0603699E RID: 223646 RVA: 0x00CEE160 File Offset: 0x00CEC360
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

		// Token: 0x0603699F RID: 223647 RVA: 0x00CEE1AC File Offset: 0x00CEC3AC
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

		// Token: 0x060369A0 RID: 223648 RVA: 0x00CEE1F8 File Offset: 0x00CEC3F8
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

		// Token: 0x060369A1 RID: 223649 RVA: 0x00CEE244 File Offset: 0x00CEC444
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

		// Token: 0x060369A2 RID: 223650 RVA: 0x00CEE28F File Offset: 0x00CEC48F
		public void RemoveUiView()
		{
			MovieModeUiView movieModeUiView = this.MovieModeUiView;
			if (movieModeUiView != null)
			{
				movieModeUiView.Destroy(null);
			}
			this.MovieModeUiView = null;
		}

		// Token: 0x060369A3 RID: 223651 RVA: 0x00CEE2AA File Offset: 0x00CEC4AA
		public bool IsHorizontalBlackBarsVisible()
		{
			MovieModeAspectView movieModeAspectView = this.MovieModeAspectView;
			return movieModeAspectView != null && movieModeAspectView.IsHorizontalBlackBarsVisible();
		}

		// Token: 0x060369A4 RID: 223652 RVA: 0x00CEE2BD File Offset: 0x00CEC4BD
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

		// Token: 0x060369A5 RID: 223653 RVA: 0x00CEE2D0 File Offset: 0x00CEC4D0
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

		// Token: 0x060369A6 RID: 223654 RVA: 0x00CEE314 File Offset: 0x00CEC514
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

		// Token: 0x060369A7 RID: 223655 RVA: 0x00CEE358 File Offset: 0x00CEC558
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

		// Token: 0x060369A8 RID: 223656 RVA: 0x00CEE444 File Offset: 0x00CEC644
		private UniTask StopMovieCamera()
		{
			MovieModeController.<StopMovieCamera>d__28 <StopMovieCamera>d__;
			<StopMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StopMovieCamera>d__.<>1__state = -1;
			<StopMovieCamera>d__.<>t__builder.Start<MovieModeController.<StopMovieCamera>d__28>(ref <StopMovieCamera>d__);
			return <StopMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x060369A9 RID: 223657 RVA: 0x00CEE480 File Offset: 0x00CEC680
		public void ResumeMovieCamera()
		{
			CameraModel.Instance.MainModel.ResumeMovieCamera();
			global::Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "[电影镜头]通过MovieModeController恢复电影镜头播放", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060369AA RID: 223658 RVA: 0x00CEE4BC File Offset: 0x00CEC6BC
		public UniTask PlaySpecialMovieCamera(string specialRowName)
		{
			MovieModeController.<PlaySpecialMovieCamera>d__30 <PlaySpecialMovieCamera>d__;
			<PlaySpecialMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySpecialMovieCamera>d__.specialRowName = specialRowName;
			<PlaySpecialMovieCamera>d__.<>1__state = -1;
			<PlaySpecialMovieCamera>d__.<>t__builder.Start<MovieModeController.<PlaySpecialMovieCamera>d__30>(ref <PlaySpecialMovieCamera>d__);
			return <PlaySpecialMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x060369AB RID: 223659 RVA: 0x00CEE4FF File Offset: 0x00CEC6FF
		public bool IsPlayingSpecialMovieCamera(string specialRowName)
		{
			return CameraModel.Instance.MainModel.IsPlayingSpecialMovieCamera(specialRowName);
		}

		// Token: 0x060369AC RID: 223660 RVA: 0x00CEE511 File Offset: 0x00CEC711
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

		// Token: 0x060369AD RID: 223661 RVA: 0x00CEE544 File Offset: 0x00CEC744
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

		// Token: 0x060369AE RID: 223662 RVA: 0x00CEE5C0 File Offset: 0x00CEC7C0
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

		// Token: 0x060369AF RID: 223663 RVA: 0x00CEE60E File Offset: 0x00CEC80E
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

		// Token: 0x060369B0 RID: 223664 RVA: 0x00CEE64D File Offset: 0x00CEC84D
		public bool IsInMovieMode()
		{
			return this.CurrentState > EMovieModeState.Idle;
		}

		// Token: 0x060369B1 RID: 223665 RVA: 0x00CEE658 File Offset: 0x00CEC858
		protected override bool OnClear()
		{
			this.ClearViews();
			this.TickGroup.Clear();
			return true;
		}

		// Token: 0x17008362 RID: 33634
		// (get) Token: 0x060369B2 RID: 223666 RVA: 0x00CEE66C File Offset: 0x00CEC86C
		public static MovieModeController Instance
		{
			get
			{
				return MovieModeController._Instance;
			}
		}

		// Token: 0x060369B3 RID: 223667 RVA: 0x00CEE673 File Offset: 0x00CEC873
		public static MovieModeController GetOrCreateInstance()
		{
			if (MovieModeController._Instance == null)
			{
				MovieModeController.CreateInstance();
			}
			return MovieModeController._Instance;
		}

		// Token: 0x060369B4 RID: 223668 RVA: 0x00CEE687 File Offset: 0x00CEC887
		public static bool CreateInstance()
		{
			if (MovieModeController._Instance != null)
			{
				return true;
			}
			MovieModeController._Instance = new MovieModeController();
			return true;
		}

		// Token: 0x060369B5 RID: 223669 RVA: 0x00CEE69D File Offset: 0x00CEC89D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060369B6 RID: 223670 RVA: 0x00CEE69F File Offset: 0x00CEC89F
		public static void ResetStaticDefaultValue()
		{
			MovieModeController._Instance = null;
		}

		// Token: 0x060369B7 RID: 223671 RVA: 0x00CEE6A7 File Offset: 0x00CEC8A7
		static MovieModeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MovieModeController.CreateStaticDefaultValue), new Action(MovieModeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CDC5 RID: 118213
		[Nullable(2)]
		private MovieModeAspectView MovieModeAspectView;

		// Token: 0x0401CDC6 RID: 118214
		[Nullable(2)]
		private MovieModeUiView MovieModeUiView;

		// Token: 0x0401CDC7 RID: 118215
		private int TickHandleId;

		// Token: 0x0401CDC8 RID: 118216
		private readonly Dictionary<int, Action<float>> TickGroup = new Dictionary<int, Action<float>>();

		// Token: 0x0401CDC9 RID: 118217
		private EMovieModeState CurrentState;

		// Token: 0x0401CDCA RID: 118218
		private bool IsAutoExitInFlowSequence;

		// Token: 0x0401CDCB RID: 118219
		[Nullable(2)]
		private static MovieModeController _Instance;
	}
}
