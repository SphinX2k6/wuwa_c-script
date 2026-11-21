using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035EB RID: 13803
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneUiController : ControllerBase
	{
		// Token: 0x06023282 RID: 144002 RVA: 0x009FD6D4 File Offset: 0x009FB8D4
		protected override bool OnInit()
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PostUpdateTick), "SceneUiController", ETickingGroup.TG_PostUpdateWork, true, 0, false);
			this.TickerId = ((ticker != null) ? new int?(ticker.Id) : null);
			return true;
		}

		// Token: 0x06023283 RID: 144003 RVA: 0x009FD720 File Offset: 0x009FB920
		protected override bool OnLeaveLevel()
		{
			this.Unsubscribe();
			this.ClearAll();
			return true;
		}

		// Token: 0x06023284 RID: 144004 RVA: 0x009FD72F File Offset: 0x009FB92F
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

		// Token: 0x06023285 RID: 144005 RVA: 0x009FD76D File Offset: 0x009FB96D
		private void PostUpdateTick(float delta)
		{
			this.EnsureSubscribed();
			this.UpdateAllFacing();
		}

		// Token: 0x06023286 RID: 144006 RVA: 0x009FD77C File Offset: 0x009FB97C
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

		// Token: 0x06023287 RID: 144007 RVA: 0x009FD884 File Offset: 0x009FBA84
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

		// Token: 0x06023288 RID: 144008 RVA: 0x009FD920 File Offset: 0x009FBB20
		private void ClearAll()
		{
			HashSet<SceneUiView>[] array = new HashSet<SceneUiView>[this.ClosingViewMap.Count];
			this.ClosingViewMap.Values.CopyTo(array, 0);
			SceneUiView[] array4;
			foreach (HashSet<SceneUiView> hashSet in array)
			{
				SceneUiView[] array3 = new SceneUiView[hashSet.Count];
				hashSet.CopyTo(array3, 0);
				array4 = array3;
				for (int j = 0; j < array4.Length; j++)
				{
					array4[j].SkipPlayingSequence();
				}
			}
			this.ClosingViewMap.Clear();
			SceneUiView[] array5 = new SceneUiView[this.AnchorViewMap.Count];
			this.AnchorViewMap.Values.CopyTo(array5, 0);
			array4 = array5;
			for (int i = 0; i < array4.Length; i++)
			{
				array4[i].DestroyAsync().Forget<bool>();
			}
			this.AnchorViewMap.Clear();
			this.AnchorViewNameMap.Clear();
			this.CreatingAnchorSet.Clear();
		}

		// Token: 0x06023289 RID: 144009 RVA: 0x009FDA08 File Offset: 0x009FBC08
		private void OnPreloadRequest([Nullable(2)] ASceneUiAnchorActor anchor, string viewName)
		{
			if (anchor == null)
			{
				return;
			}
			this.EnsureCreatedAsync(anchor, viewName, null).Forget<SceneUiView>();
		}

		// Token: 0x0602328A RID: 144010 RVA: 0x009FDA1C File Offset: 0x009FBC1C
		private void OnOpenRequest([Nullable(2)] ASceneUiAnchorActor anchor, string viewName, string param)
		{
			if (anchor == null)
			{
				return;
			}
			this.OpenAsync(anchor, viewName, param).Forget();
		}

		// Token: 0x0602328B RID: 144011 RVA: 0x009FDA30 File Offset: 0x009FBC30
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

		// Token: 0x0602328C RID: 144012 RVA: 0x009FDAA1 File Offset: 0x009FBCA1
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

		// Token: 0x0602328D RID: 144013 RVA: 0x009FDAC2 File Offset: 0x009FBCC2
		[NullableContext(2)]
		private void OnDestroyRequest(ASceneUiAnchorActor anchor)
		{
			if (anchor == null)
			{
				return;
			}
			this.DestroyAnchorUi(anchor, true);
		}

		// Token: 0x0602328E RID: 144014 RVA: 0x009FDAD0 File Offset: 0x009FBCD0
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

		// Token: 0x0602328F RID: 144015 RVA: 0x009FDB50 File Offset: 0x009FBD50
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

		// Token: 0x06023290 RID: 144016 RVA: 0x009FDBAC File Offset: 0x009FBDAC
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

		// Token: 0x06023291 RID: 144017 RVA: 0x009FDC07 File Offset: 0x009FBE07
		private void DestroyAnchorUi(ASceneUiAnchorActor anchor, bool playCloseSequence)
		{
			this.DestroyAnchorUiAsync(anchor, playCloseSequence).Forget();
		}

		// Token: 0x06023292 RID: 144018 RVA: 0x009FDC18 File Offset: 0x009FBE18
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

		// Token: 0x06023293 RID: 144019 RVA: 0x009FDC6C File Offset: 0x009FBE6C
		private void SkipClosingViews(AActor anchor)
		{
			HashSet<SceneUiView> hashSet;
			if (!this.ClosingViewMap.TryGetValue(anchor, out hashSet))
			{
				return;
			}
			SceneUiView[] array = new SceneUiView[hashSet.Count];
			hashSet.CopyTo(array, 0);
			SceneUiView[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].SkipPlayingSequence();
			}
		}

		// Token: 0x06023294 RID: 144020 RVA: 0x009FDCB8 File Offset: 0x009FBEB8
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

		// Token: 0x06023295 RID: 144021 RVA: 0x009FDD4C File Offset: 0x009FBF4C
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

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x06023296 RID: 144022 RVA: 0x009FDD8E File Offset: 0x009FBF8E
		public static SceneUiController Instance
		{
			get
			{
				return SceneUiController._Instance;
			}
		}

		// Token: 0x06023297 RID: 144023 RVA: 0x009FDD95 File Offset: 0x009FBF95
		public static SceneUiController GetOrCreateInstance()
		{
			if (SceneUiController._Instance == null)
			{
				SceneUiController.CreateInstance();
			}
			return SceneUiController._Instance;
		}

		// Token: 0x06023298 RID: 144024 RVA: 0x009FDDA9 File Offset: 0x009FBFA9
		public static bool CreateInstance()
		{
			if (SceneUiController._Instance != null)
			{
				return true;
			}
			SceneUiController._Instance = new SceneUiController();
			return true;
		}

		// Token: 0x06023299 RID: 144025 RVA: 0x009FDDBF File Offset: 0x009FBFBF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602329A RID: 144026 RVA: 0x009FDDC1 File Offset: 0x009FBFC1
		public static void ResetStaticDefaultValue()
		{
			SceneUiController._Instance = null;
		}

		// Token: 0x0602329B RID: 144027 RVA: 0x009FDDC9 File Offset: 0x009FBFC9
		static SceneUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiController.CreateStaticDefaultValue), new Action(SceneUiController.ResetStaticDefaultValue));
		}

		// Token: 0x04013D6E RID: 81262
		private readonly Dictionary<AActor, SceneUiView> AnchorViewMap = new Dictionary<AActor, SceneUiView>();

		// Token: 0x04013D6F RID: 81263
		private readonly Dictionary<AActor, string> AnchorViewNameMap = new Dictionary<AActor, string>();

		// Token: 0x04013D70 RID: 81264
		private readonly HashSet<AActor> CreatingAnchorSet = new HashSet<AActor>();

		// Token: 0x04013D71 RID: 81265
		private readonly Dictionary<AActor, HashSet<SceneUiView>> ClosingViewMap = new Dictionary<AActor, HashSet<SceneUiView>>();

		// Token: 0x04013D72 RID: 81266
		[Nullable(2)]
		private USceneUiAnchorSubsystem SubscribedSubsystem;

		// Token: 0x04013D73 RID: 81267
		private int? TickerId;

		// Token: 0x04013D74 RID: 81268
		[Nullable(2)]
		private static SceneUiController _Instance;
	}
}
