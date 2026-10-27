using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046BA RID: 18106
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneUiController : ControllerBase
	{
		// Token: 0x0602EB36 RID: 191286 RVA: 0x00ACEE00 File Offset: 0x00ACD000
		protected override bool OnInit()
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PostUpdateTick), "SceneUiController", ETickingGroup.TG_PostUpdateWork, true, 0, false);
			this.TickerId = ((ticker != null) ? new int?(ticker.Id) : null);
			return true;
		}

		// Token: 0x0602EB37 RID: 191287 RVA: 0x00ACEE4C File Offset: 0x00ACD04C
		protected override bool OnLeaveLevel()
		{
			this.Unsubscribe();
			this.ClearAll();
			return true;
		}

		// Token: 0x0602EB38 RID: 191288 RVA: 0x00ACEE5B File Offset: 0x00ACD05B
		protected override bool OnClear()
		{
			this.Unsubscribe();
			this.ClearAll();
			if (this.TickerId != null)
			{
				TickSystem.Instance.Remove(this.TickerId.Value);
				this.TickerId = null;
			}
			return true;
		}

		// Token: 0x0602EB39 RID: 191289 RVA: 0x00ACEE99 File Offset: 0x00ACD099
		private void PostUpdateTick(float delta)
		{
			this.EnsureSubscribed();
			this.UpdateAllFacing();
		}

		// Token: 0x0602EB3A RID: 191290 RVA: 0x00ACEEA8 File Offset: 0x00ACD0A8
		private void EnsureSubscribed()
		{
			if (this.SubscribedSubsystem != null && this.SubscribedSubsystem.IsValid())
			{
				return;
			}
			if (this.SubscribedSubsystem != null)
			{
				this.SubscribedSubsystem = null;
				this.ClearAll();
			}
			UWorld world = GlobalData.World;
			if (world == null || !world.IsValid())
			{
				return;
			}
			USceneUiAnchorSubsystem usceneUiAnchorSubsystem = USubsystemBlueprintLibrary.GetWorldSubsystem(world, USceneUiAnchorSubsystem.StaticClass()) as USceneUiAnchorSubsystem;
			if (usceneUiAnchorSubsystem == null || !usceneUiAnchorSubsystem.IsValid())
			{
				return;
			}
			usceneUiAnchorSubsystem.OnPreloadRequest.Add(new Action<ASceneUiAnchorActor, string>(this.OnPreloadRequest));
			usceneUiAnchorSubsystem.OnOpenRequest.Add(new Action<ASceneUiAnchorActor, string, string>(this.OnOpenRequest));
			usceneUiAnchorSubsystem.OnOpenWithMapRequest.Add(new Action<ASceneUiAnchorActor, string>(this.OnOpenWithMapRequest));
			usceneUiAnchorSubsystem.OnCloseRequest.Add(new Action<ASceneUiAnchorActor>(this.OnCloseRequest));
			usceneUiAnchorSubsystem.OnAnchorEndPlay.Add(new Action<ASceneUiAnchorActor>(this.OnAnchorEndPlay));
			this.SubscribedSubsystem = usceneUiAnchorSubsystem;
			Log.Instance.Info(ELogModule.Scene3dUi, ELogAuthor.HYF, "[SceneUiController]已订阅SceneUiAnchorSubsystem", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602EB3B RID: 191291 RVA: 0x00ACEFB0 File Offset: 0x00ACD1B0
		private void Unsubscribe()
		{
			USceneUiAnchorSubsystem subscribedSubsystem = this.SubscribedSubsystem;
			this.SubscribedSubsystem = null;
			if (subscribedSubsystem == null || !subscribedSubsystem.IsValid())
			{
				return;
			}
			subscribedSubsystem.OnPreloadRequest.Remove(new Action<ASceneUiAnchorActor, string>(this.OnPreloadRequest));
			subscribedSubsystem.OnOpenRequest.Remove(new Action<ASceneUiAnchorActor, string, string>(this.OnOpenRequest));
			subscribedSubsystem.OnOpenWithMapRequest.Remove(new Action<ASceneUiAnchorActor, string>(this.OnOpenWithMapRequest));
			subscribedSubsystem.OnCloseRequest.Remove(new Action<ASceneUiAnchorActor>(this.OnCloseRequest));
			subscribedSubsystem.OnAnchorEndPlay.Remove(new Action<ASceneUiAnchorActor>(this.OnAnchorEndPlay));
		}

		// Token: 0x0602EB3C RID: 191292 RVA: 0x00ACF04C File Offset: 0x00ACD24C
		private void ClearAll()
		{
			HashSet<SceneUiView>[] array = this.ClosingViewMap.Values.ToArray<HashSet<SceneUiView>>();
			SceneUiView[] array2;
			for (int i = 0; i < array.Length; i++)
			{
				array2 = array[i].ToArray<SceneUiView>();
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].SkipPlayingSequence();
				}
			}
			this.ClosingViewMap.Clear();
			array2 = this.AnchorViewMap.Values.ToArray<SceneUiView>();
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DestroyAsync().Forget<bool>();
			}
			this.AnchorViewMap.Clear();
			this.AnchorViewNameMap.Clear();
			this.CreatingAnchorSet.Clear();
		}

		// Token: 0x0602EB3D RID: 191293 RVA: 0x00ACF0EF File Offset: 0x00ACD2EF
		private void OnPreloadRequest([Nullable(2)] ASceneUiAnchorActor anchor, string viewName)
		{
			if (anchor == null)
			{
				return;
			}
			this.EnsureCreatedAsync(anchor, viewName, null).Forget<SceneUiView>();
		}

		// Token: 0x0602EB3E RID: 191294 RVA: 0x00ACF103 File Offset: 0x00ACD303
		private void OnOpenRequest([Nullable(2)] ASceneUiAnchorActor anchor, string viewName, string param)
		{
			if (anchor == null)
			{
				return;
			}
			this.OpenAsync(anchor, viewName, param).Forget();
		}

		// Token: 0x0602EB3F RID: 191295 RVA: 0x00ACF118 File Offset: 0x00ACD318
		private void OnOpenWithMapRequest([Nullable(2)] ASceneUiAnchorActor anchor, string viewName)
		{
			if (anchor == null)
			{
				return;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			TMap<string, string> pendingOpenParams = anchor.PendingOpenParams;
			if (pendingOpenParams != null)
			{
				int maxIndex = pendingOpenParams.GetMaxIndex();
				for (int i = 0; i < maxIndex; i++)
				{
					if (pendingOpenParams.IsValidIndex(i))
					{
						string key = pendingOpenParams.GetKey(i);
						if (key != null)
						{
							dictionary[key] = (pendingOpenParams.Get(key) ?? "");
						}
					}
				}
			}
			this.OpenAsync(anchor, viewName, dictionary).Forget();
		}

		// Token: 0x0602EB40 RID: 191296 RVA: 0x00ACF189 File Offset: 0x00ACD389
		[NullableContext(2)]
		private void OnCloseRequest(ASceneUiAnchorActor anchor)
		{
			if (anchor == null)
			{
				return;
			}
			SceneUiView valueOrDefault = this.AnchorViewMap.GetValueOrDefault(anchor);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.HideAsync().Forget<bool>();
		}

		// Token: 0x0602EB41 RID: 191297 RVA: 0x00ACF1AA File Offset: 0x00ACD3AA
		[NullableContext(2)]
		private void OnDestroyRequest(ASceneUiAnchorActor anchor)
		{
			if (anchor == null)
			{
				return;
			}
			this.DestroyAnchorUi(anchor, true);
		}

		// Token: 0x0602EB42 RID: 191298 RVA: 0x00ACF1B8 File Offset: 0x00ACD3B8
		[NullableContext(2)]
		private void OnAnchorEndPlay(ASceneUiAnchorActor anchor)
		{
			if (anchor == null)
			{
				return;
			}
			SceneUiView view = this.AnchorViewMap.GetValueOrDefault(anchor);
			this.AnchorViewMap.Remove(anchor);
			this.AnchorViewNameMap.Remove(anchor);
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.SkipClosingViews(anchor);
				SceneUiView view = view;
				if (view == null)
				{
					return;
				}
				view.DestroyAsync().Forget<bool>();
			}, null, null);
		}

		// Token: 0x0602EB43 RID: 191299 RVA: 0x00ACF238 File Offset: 0x00ACD438
		private UniTask OpenAsync(ASceneUiAnchorActor anchor, string viewName, [Nullable(2)] object param)
		{
			SceneUiController.<OpenAsync>d__19 <OpenAsync>d__;
			<OpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenAsync>d__.<>4__this = this;
			<OpenAsync>d__.anchor = anchor;
			<OpenAsync>d__.viewName = viewName;
			<OpenAsync>d__.param = param;
			<OpenAsync>d__.<>1__state = -1;
			<OpenAsync>d__.<>t__builder.Start<SceneUiController.<OpenAsync>d__19>(ref <OpenAsync>d__);
			return <OpenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB44 RID: 191300 RVA: 0x00ACF294 File Offset: 0x00ACD494
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<SceneUiView> EnsureCreatedAsync(ASceneUiAnchorActor anchor, string viewName, [Nullable(2)] object param)
		{
			SceneUiController.<EnsureCreatedAsync>d__20 <EnsureCreatedAsync>d__;
			<EnsureCreatedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SceneUiView>.Create();
			<EnsureCreatedAsync>d__.<>4__this = this;
			<EnsureCreatedAsync>d__.anchor = anchor;
			<EnsureCreatedAsync>d__.viewName = viewName;
			<EnsureCreatedAsync>d__.param = param;
			<EnsureCreatedAsync>d__.<>1__state = -1;
			<EnsureCreatedAsync>d__.<>t__builder.Start<SceneUiController.<EnsureCreatedAsync>d__20>(ref <EnsureCreatedAsync>d__);
			return <EnsureCreatedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB45 RID: 191301 RVA: 0x00ACF2EF File Offset: 0x00ACD4EF
		private void DestroyAnchorUi(ASceneUiAnchorActor anchor, bool playCloseSequence)
		{
			this.DestroyAnchorUiAsync(anchor, playCloseSequence).Forget();
		}

		// Token: 0x0602EB46 RID: 191302 RVA: 0x00ACF300 File Offset: 0x00ACD500
		private UniTask DestroyAnchorUiAsync(ASceneUiAnchorActor anchor, bool playCloseSequence)
		{
			SceneUiController.<DestroyAnchorUiAsync>d__22 <DestroyAnchorUiAsync>d__;
			<DestroyAnchorUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyAnchorUiAsync>d__.<>4__this = this;
			<DestroyAnchorUiAsync>d__.anchor = anchor;
			<DestroyAnchorUiAsync>d__.playCloseSequence = playCloseSequence;
			<DestroyAnchorUiAsync>d__.<>1__state = -1;
			<DestroyAnchorUiAsync>d__.<>t__builder.Start<SceneUiController.<DestroyAnchorUiAsync>d__22>(ref <DestroyAnchorUiAsync>d__);
			return <DestroyAnchorUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB47 RID: 191303 RVA: 0x00ACF354 File Offset: 0x00ACD554
		private void SkipClosingViews(AActor anchor)
		{
			HashSet<SceneUiView> source;
			if (!this.ClosingViewMap.TryGetValue(anchor, out source))
			{
				return;
			}
			SceneUiView[] array = source.ToArray<SceneUiView>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SkipPlayingSequence();
			}
		}

		// Token: 0x0602EB48 RID: 191304 RVA: 0x00ACF390 File Offset: 0x00ACD590
		private void UpdateAllFacing()
		{
			if (this.AnchorViewMap.Count == 0)
			{
				return;
			}
			CameraModelInstance mainModel = CameraController.Instance.MainModel;
			Rotator rotator = (mainModel != null) ? mainModel.CameraRotator : null;
			if (rotator == null)
			{
				return;
			}
			foreach (SceneUiView sceneUiView in this.AnchorViewMap.Values)
			{
				if (sceneUiView.FaceCamera)
				{
					sceneUiView.UpdateFacing(rotator.Yaw, rotator.Pitch);
				}
			}
		}

		// Token: 0x0602EB49 RID: 191305 RVA: 0x00ACF424 File Offset: 0x00ACD624
		private void UpdateViewFacing(SceneUiView view)
		{
			CameraModelInstance mainModel = CameraController.Instance.MainModel;
			Rotator rotator = (mainModel != null) ? mainModel.CameraRotator : null;
			if (rotator == null)
			{
				return;
			}
			if (view.FaceCamera)
			{
				view.UpdateFacing(rotator.Yaw, rotator.Pitch);
			}
		}

		// Token: 0x17007666 RID: 30310
		// (get) Token: 0x0602EB4A RID: 191306 RVA: 0x00ACF466 File Offset: 0x00ACD666
		public static SceneUiController Instance
		{
			get
			{
				return SceneUiController._Instance;
			}
		}

		// Token: 0x0602EB4B RID: 191307 RVA: 0x00ACF46D File Offset: 0x00ACD66D
		public static SceneUiController GetOrCreateInstance()
		{
			if (SceneUiController._Instance == null)
			{
				SceneUiController.CreateInstance();
			}
			return SceneUiController._Instance;
		}

		// Token: 0x0602EB4C RID: 191308 RVA: 0x00ACF481 File Offset: 0x00ACD681
		public static bool CreateInstance()
		{
			if (SceneUiController._Instance != null)
			{
				return true;
			}
			SceneUiController._Instance = new SceneUiController();
			return true;
		}

		// Token: 0x0602EB4D RID: 191309 RVA: 0x00ACF497 File Offset: 0x00ACD697
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB4E RID: 191310 RVA: 0x00ACF499 File Offset: 0x00ACD699
		public static void ResetStaticDefaultValue()
		{
			SceneUiController._Instance = null;
		}

		// Token: 0x0602EB4F RID: 191311 RVA: 0x00ACF4A1 File Offset: 0x00ACD6A1
		static SceneUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiController.CreateStaticDefaultValue), new Action(SceneUiController.ResetStaticDefaultValue));
		}

		// Token: 0x040196C9 RID: 104137
		private readonly Dictionary<AActor, SceneUiView> AnchorViewMap = new Dictionary<AActor, SceneUiView>();

		// Token: 0x040196CA RID: 104138
		private readonly Dictionary<AActor, string> AnchorViewNameMap = new Dictionary<AActor, string>();

		// Token: 0x040196CB RID: 104139
		private readonly HashSet<AActor> CreatingAnchorSet = new HashSet<AActor>();

		// Token: 0x040196CC RID: 104140
		private readonly Dictionary<AActor, HashSet<SceneUiView>> ClosingViewMap = new Dictionary<AActor, HashSet<SceneUiView>>();

		// Token: 0x040196CD RID: 104141
		[Nullable(2)]
		private USceneUiAnchorSubsystem SubscribedSubsystem;

		// Token: 0x040196CE RID: 104142
		private int? TickerId;

		// Token: 0x040196CF RID: 104143
		[Nullable(2)]
		private static SceneUiController _Instance;
	}
}
