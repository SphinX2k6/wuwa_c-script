using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.SeamlessTravel;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072AC RID: 29356
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class CameraController : ControllerBase
	{
		// Token: 0x17009F05 RID: 40709
		// (get) Token: 0x06048040 RID: 294976 RVA: 0x012757B0 File Offset: 0x012739B0
		public CameraModelInstance MainModel
		{
			get
			{
				return CameraModel.Instance.MainModel;
			}
		}

		// Token: 0x06048041 RID: 294977 RVA: 0x012757BC File Offset: 0x012739BC
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.BeforeLoadMap));
			EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.AfterLoadMap));
			return base.OnInit();
		}

		// Token: 0x06048042 RID: 294978 RVA: 0x01275824 File Offset: 0x01273A24
		public void OnPossess([Nullable(2)] APawn pawn, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			FightCamera fightCamera = separateCameraModel.FightCamera;
			if (fightCamera != null)
			{
				fightCamera.LogicComponent.SetPawn(pawn);
			}
			SequenceCamera sequenceCamera = separateCameraModel.SequenceCamera;
			if (sequenceCamera == null)
			{
				return;
			}
			sequenceCamera.PlayerComponent.SetPawn(pawn);
		}

		// Token: 0x06048043 RID: 294979 RVA: 0x0127586E File Offset: 0x01273A6E
		[return: Nullable(2)]
		public CameraModelInstance GetSeparateCameraModel(string cameraName)
		{
			return CameraModel.Instance.GetSeparateCameraModel(cameraName);
		}

		// Token: 0x06048044 RID: 294980 RVA: 0x0127587C File Offset: 0x01273A7C
		public CameraModelInstance InitSeparateCamera(string cameraName, [Nullable(2)] Vector2D initLocation = null, [Nullable(2)] Vector2D initSize = null, bool enableScissorOffset = false, bool enableLog = false)
		{
			if (enableLog)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[分屏相机]初始化分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			CameraModelInstance cameraModelInstance = CameraModel.Instance.CreateSeparateCameraModel(cameraName);
			if (cameraName != "MainCamera")
			{
				this.CacheAndDisableFrameGenCvars();
			}
			Vector2D viewLocation = initLocation ?? Vector2D.Create();
			Vector2D viewSize = initSize ?? Vector2D.Create();
			cameraModelInstance.SetViewInfo(viewLocation, viewSize, enableScissorOffset);
			return cameraModelInstance;
		}

		// Token: 0x06048045 RID: 294981 RVA: 0x012758E8 File Offset: 0x01273AE8
		private void CacheAndDisableFrameGenCvars()
		{
			if (this.CachedFrameGenCvarValues.Count > 0)
			{
				return;
			}
			foreach (string text in CameraController.SeparateCameraDisabledCvars)
			{
				int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue(text);
				this.CachedFrameGenCvarValues[text] = consoleVariableIntValue;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[分屏相机]缓存帧生成CVar";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(text, consoleVariableIntValue);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text + " 0", null);
			}
			GameSettingsDeviceRender.Instance.TemporaryDisableDLSSG("Separate_Camera");
		}

		// Token: 0x06048046 RID: 294982 RVA: 0x01275980 File Offset: 0x01273B80
		private void RestoreFrameGenCvars()
		{
			if (this.CachedFrameGenCvarValues.Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<string, int> keyValuePair in this.CachedFrameGenCvarValues)
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			this.CachedFrameGenCvarValues.Clear();
			GameSettingsDeviceRender.Instance.CancelTemporaryDisableDLSSG("Separate_Camera");
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[分屏相机]还原帧生成CVar", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06048047 RID: 294983 RVA: 0x01275A54 File Offset: 0x01273C54
		[NullableContext(2)]
		public void FadeSeparateCamera([Nullable(1)] string cameraName, float fadeTime, Vector2D targetViewLocation = null, Vector2D targetViewSize = null, bool enableScissorOffset = false, UCurveFloat curveFloat = null, Action callback = null, bool enableLog = false)
		{
			CameraModelInstance cameraModelInstance = CameraModel.Instance.CreateSeparateCameraModel(cameraName);
			Vector2D targetViewLocation2 = targetViewLocation ?? Vector2D.Create();
			Vector2D targetViewSize2 = targetViewSize ?? Vector2D.Create();
			if (enableLog)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[分屏相机]开始调整分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			cameraModelInstance.SetTargetViewInfo(fadeTime, targetViewLocation2, targetViewSize2, enableScissorOffset, curveFloat, delegate
			{
				if (enableLog)
				{
					Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[分屏相机]副屏调整结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x06048048 RID: 294984 RVA: 0x01275AD8 File Offset: 0x01273CD8
		[NullableContext(2)]
		public void DestroySeparateCameraModel([Nullable(1)] string cameraName, float fadeTime, Vector2D targetViewLocation = null, Vector2D targetViewSize = null, bool enableScissorOffset = false, UCurveFloat curveFloat = null, Action callback = null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[分屏相机]开始离开分屏";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.FadeSeparateCamera(cameraName, fadeTime, targetViewLocation, targetViewSize, enableScissorOffset, curveFloat, delegate
			{
				CameraModel.Instance.DestroySeparateCameraModel(cameraName);
				if (!CameraModel.Instance.HasSeparateCamera())
				{
					this.RestoreFrameGenCvars();
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "[分屏相机]结束离开分屏";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("cameraName", cameraName);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, false);
		}

		// Token: 0x06048049 RID: 294985 RVA: 0x01275B50 File Offset: 0x01273D50
		[NullableContext(2)]
		public unsafe void SetViewTarget(AActor newViewTarget, [Nullable(1)] string reason, float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, bool? bLockOutgoing = null, bool? bKuroEnableBlend = null, [Nullable(1)] string cameraName = "MainCamera", Action callback = null, UCurveFloat blendCurve = null)
		{
			if (newViewTarget == null || !newViewTarget.IsValid())
			{
				Log.Instance.Warn(ELogModule.Camera, ELogAuthor.LCZ, "Camera not valid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			APlayerController playerController = this.GetPlayerController();
			if (playerController == null)
			{
				return;
			}
			playerController.bShouldPerformFullTickWhenPaused = true;
			APlayerCameraManager playerCameraManager = this.GetPlayerCameraManager(cameraName);
			if (playerCameraManager == null || !playerCameraManager.IsValid())
			{
				return;
			}
			CameraModelInstance model = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (model == null)
			{
				return;
			}
			model.CurrentCameraActor = newViewTarget;
			model.CurrentCameraComponent = (newViewTarget.GetComponentByClass(UCameraComponent.StaticClass()) as UCameraComponent);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "绑定相机 SetViewTarget";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", newViewTarget);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendTime", blendTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			CameraController.ViewTargetTransitionParams.BlendTime = (CameraUtility.CharacterMovementBaseIsMoving() ? 0f : blendTime);
			CameraController.ViewTargetTransitionParams.BlendFunction = blendFunction;
			CameraController.ViewTargetTransitionParams.BlendExp = blendExp;
			CameraController.ViewTargetTransitionParams.bLockOutgoing = bLockOutgoing.GetValueOrDefault();
			CameraController.ViewTargetTransitionParams.bKuroEnableBlend = bKuroEnableBlend.GetValueOrDefault();
			CameraController.ViewTargetTransitionParams.BlendCurve = blendCurve;
			playerCameraManager.ResetViewTarget(newViewTarget, CameraController.ViewTargetTransitionParams);
			model.CurrentCameraComponent.bEnableScissorOffCenter = model.IsEnableScissorOffsetCenter();
			EventSystem.Instance.Emit<float, string>(EEventName.CameraViewTargetChanged, CameraUtility.CharacterMovementBaseIsMoving() ? 0f : blendTime, cameraName);
			if (blendTime > 0f)
			{
				model.IsInCameraModeBlending = true;
				TimerSystem.Instance.Delay(delegate(float _)
				{
					model.IsInCameraModeBlending = false;
					Action callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3();
				}, blendTime * 1000f, null, null, true, 1f);
				return;
			}
			model.IsInCameraModeBlending = false;
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}

		// Token: 0x0604804A RID: 294986 RVA: 0x01275D80 File Offset: 0x01273F80
		public void ResetViewTarget(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, string cameraName = "MainCamera", [Nullable(2)] UCurveFloat blendCurve = null)
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			CameraController.ViewTargetTransitionParams.BlendTime = blendTime;
			CameraController.ViewTargetTransitionParams.BlendFunction = blendFunction;
			CameraController.ViewTargetTransitionParams.BlendExp = blendExp;
			CameraController.ViewTargetTransitionParams.bLockOutgoing = true;
			CameraController.ViewTargetTransitionParams.bKuroEnableBlend = true;
			CameraController.ViewTargetTransitionParams.BlendCurve = blendCurve;
			separateCameraModel.PlayerCameraManager.ResetViewTarget(separateCameraModel.CurrentCameraActor, CameraController.ViewTargetTransitionParams);
			separateCameraModel.CurrentCameraComponent.bEnableScissorOffCenter = separateCameraModel.IsEnableScissorOffsetCenter();
		}

		// Token: 0x0604804B RID: 294987 RVA: 0x01275E0D File Offset: 0x0127400D
		protected override void OnTick(float delta)
		{
			this.UpdateCameraLayout(delta);
			this.UpdateCameraTransform();
			this.UpdateCameraDitherRadius();
		}

		// Token: 0x0604804C RID: 294988 RVA: 0x01275E24 File Offset: 0x01274024
		[NullableContext(2)]
		public unsafe bool EnterCameraMode(ECustomCameraMode mode, float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, Action callback = null, bool bMustCallback = false, [Nullable(1)] string cameraName = "MainCamera", UCurveFloat blendCurve = null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraMode]EnterCameraMode";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mode", mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendTime", blendTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendFunction", blendFunction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("blendExp", blendExp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("bMustCallback", bMustCallback);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			if (this.CameraModeMutex)
			{
				return this.PushPendingCameraModeRequest(true, mode, blendTime, blendFunction, blendExp, callback, bMustCallback, cameraName, blendCurve);
			}
			this.CameraModeMutex = true;
			bool result;
			try
			{
				result = this.EnterCameraModeInternal(mode, blendTime, blendFunction, blendExp, callback, bMustCallback, cameraName, blendCurve);
			}
			finally
			{
				this.CameraModeMutex = false;
			}
			this.DrainPendingCameraModeRequests();
			return result;
		}

		// Token: 0x0604804D RID: 294989 RVA: 0x01275F5C File Offset: 0x0127415C
		[NullableContext(2)]
		private unsafe bool EnterCameraModeInternal(ECustomCameraMode mode, float blendTime, EViewTargetBlendFunction blendFunction, float blendExp, Action callback, bool bMustCallback, [Nullable(1)] string cameraName, UCurveFloat blendCurve)
		{
			if (mode == ECustomCameraMode.LockOn)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CameraMode]战斗镜头不应主动切换，应由其他镜头退出时被动切换";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", cameraName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return false;
			}
			separateCameraModel.EnableMode(mode);
			if (separateCameraModel.IsInHigherMode(mode))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "[CameraMode]意图进入较低优先级的镜头";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentMode", separateCameraModel.CameraMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewMode", mode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Index", cameraName);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				if (bMustCallback && callback != null)
				{
					callback();
				}
				return false;
			}
			return this.SwitchCameraMode(mode, blendTime, blendFunction, blendExp, callback, cameraName, blendCurve);
		}

		// Token: 0x0604804E RID: 294990 RVA: 0x01276058 File Offset: 0x01274258
		[NullableContext(2)]
		public unsafe bool ExitCameraMode(ECustomCameraMode mode, float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, Action callback = null, [Nullable(1)] string cameraName = "MainCamera", UCurveFloat blendCurve = null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraMode]ExitCameraMode";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mode", mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendTime", blendTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendFunction", blendFunction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("blendExp", blendExp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (this.CameraModeMutex)
			{
				return this.PushPendingCameraModeRequest(false, mode, blendTime, blendFunction, blendExp, callback, true, cameraName, blendCurve);
			}
			this.CameraModeMutex = true;
			bool result;
			try
			{
				result = this.ExitCameraModeInternal(mode, blendTime, blendFunction, blendExp, callback, cameraName, blendCurve);
			}
			finally
			{
				this.CameraModeMutex = false;
			}
			this.DrainPendingCameraModeRequests();
			return result;
		}

		// Token: 0x0604804F RID: 294991 RVA: 0x0127616C File Offset: 0x0127436C
		[NullableContext(2)]
		private bool ExitCameraModeInternal(ECustomCameraMode mode, float blendTime, EViewTargetBlendFunction blendFunction, float blendExp, Action callback, [Nullable(1)] string cameraName, UCurveFloat blendCurve)
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return false;
			}
			if (mode == ECustomCameraMode.LockOn)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.WCL, "战斗镜头不应主动切换，应由其他镜头退出时被动切换", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			separateCameraModel.DisableMode(mode);
			return this.SwitchCameraMode(separateCameraModel.GetNextMode(), blendTime, blendFunction, blendExp, callback, cameraName, blendCurve);
		}

		// Token: 0x06048050 RID: 294992 RVA: 0x012761CC File Offset: 0x012743CC
		[NullableContext(2)]
		private unsafe bool PushPendingCameraModeRequest(bool isEnter, ECustomCameraMode mode, float blendTime, EViewTargetBlendFunction blendFunction, float blendExp, Action callback, bool bMustCallback, [Nullable(1)] string cameraName, UCurveFloat blendCurve)
		{
			if (this.PendingCameraModeRequests.Count >= 5)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CameraMode]镜头模式切换嵌套请求过多，疑似循环调用，丢弃本次请求";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsEnter", isEnter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Mode", mode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CameraName", cameraName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[CameraMode]PushPendingCameraModeRequest 镜头模式切换产生嵌套，加入队列待当前切换完成后执行";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IsEnter", isEnter);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("mode", mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("blendTime", blendTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("blendFunction", blendFunction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("blendExp", blendExp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("bMustCallback", bMustCallback);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("cameraName", cameraName);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
			this.PendingCameraModeRequests.Add(new CameraController.PendingCameraModeRequest
			{
				IsEnter = isEnter,
				Mode = mode,
				BlendTime = blendTime,
				BlendFunction = blendFunction,
				BlendExp = blendExp,
				Callback = callback,
				BMustCallback = bMustCallback,
				CameraName = cameraName,
				BlendCurve = blendCurve
			});
			return true;
		}

		// Token: 0x06048051 RID: 294993 RVA: 0x012763A4 File Offset: 0x012745A4
		private unsafe void DrainPendingCameraModeRequests()
		{
			if (this.IsDrainingCameraModeRequests)
			{
				return;
			}
			this.IsDrainingCameraModeRequests = true;
			try
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraMode]PushPendingCameraModeRequest 开始处理等待", default(ReadOnlySpan<ValueTuple<string, object>>));
				int num = 0;
				while (this.PendingCameraModeRequests.Count > 0)
				{
					if (++num > 5)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Camera;
						ELogAuthor author = ELogAuthor.LJM;
						string message = "[CameraMode]DrainPendingCameraModeRequests 镜头模式切换产生循环调用，丢弃剩余请求";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Remaining", this.PendingCameraModeRequests.Count);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.PendingCameraModeRequests.Clear();
						break;
					}
					CameraController.PendingCameraModeRequest pendingCameraModeRequest = this.PendingCameraModeRequests[0];
					this.PendingCameraModeRequests.RemoveAt(0);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Camera;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "[CameraMode]PushPendingCameraModeRequest 处理";
					<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", num - 1);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isEnter", pendingCameraModeRequest.IsEnter);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Mode", pendingCameraModeRequest.Mode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("isEnter", pendingCameraModeRequest.IsEnter);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("BlendTime", pendingCameraModeRequest.BlendTime);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("BlendFunction", pendingCameraModeRequest.BlendFunction);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("BlendExp", pendingCameraModeRequest.BlendExp);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("MustCallback", pendingCameraModeRequest.BMustCallback);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CameraName", pendingCameraModeRequest.CameraName);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
					if (pendingCameraModeRequest.IsEnter)
					{
						this.EnterCameraMode(pendingCameraModeRequest.Mode, pendingCameraModeRequest.BlendTime, pendingCameraModeRequest.BlendFunction, pendingCameraModeRequest.BlendExp, pendingCameraModeRequest.Callback, pendingCameraModeRequest.BMustCallback, pendingCameraModeRequest.CameraName, pendingCameraModeRequest.BlendCurve);
					}
					else
					{
						this.ExitCameraMode(pendingCameraModeRequest.Mode, pendingCameraModeRequest.BlendTime, pendingCameraModeRequest.BlendFunction, pendingCameraModeRequest.BlendExp, pendingCameraModeRequest.Callback, pendingCameraModeRequest.CameraName, pendingCameraModeRequest.BlendCurve);
					}
				}
			}
			finally
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraMode]PushPendingCameraModeRequest 结束处理等待", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.IsDrainingCameraModeRequests = false;
			}
		}

		// Token: 0x06048052 RID: 294994 RVA: 0x01276678 File Offset: 0x01274878
		public Rotator GetCameraRotation(Rotator outRotator, string cameraName = "MainCamera")
		{
			outRotator.Reset();
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return outRotator;
			}
			FightCamera fightCamera = separateCameraModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			ECustomCameraMode? cameraMode = separateCameraModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			if ((cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) && !separateCameraModel.IsInCameraModeBlending && fightCameraLogicComponent != null)
			{
				outRotator.FromUeRotator(fightCameraLogicComponent.CameraRotation);
			}
			else
			{
				FRotator cameraRotation = separateCameraModel.PlayerCameraManager.GetCameraRotation();
				outRotator.FromUeRotator(cameraRotation);
			}
			return outRotator;
		}

		// Token: 0x06048053 RID: 294995 RVA: 0x012766FC File Offset: 0x012748FC
		[NullableContext(2)]
		private bool SwitchCameraMode(ECustomCameraMode mode, float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, Action callback = null, [Nullable(1)] string cameraName = "MainCamera", UCurveFloat blendCurve = null)
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return false;
			}
			ECustomCameraMode? cameraMode = separateCameraModel.CameraMode;
			if (cameraMode.GetValueOrDefault() == mode & cameraMode != null)
			{
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraMode]CameraManager.SwitchCameraMode:切换镜头模式";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mode", mode);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			separateCameraModel.SetCameraMode(mode);
			if (mode == ECustomCameraMode.Sequence || mode == ECustomCameraMode.Scene)
			{
				Global.CharacterCameraManager.StopAllCameraShakes(true);
			}
			ACameraActor newViewTarget;
			switch (mode)
			{
			case ECustomCameraMode.LockOn:
				newViewTarget = separateCameraModel.FightCamera.DisplayComponent.CameraActor;
				break;
			case ECustomCameraMode.Sequence:
				newViewTarget = separateCameraModel.SequenceCamera.DisplayComponent.CineCamera;
				break;
			case ECustomCameraMode.Widget:
				newViewTarget = separateCameraModel.WidgetCamera.DisplayComponent.CineCamera;
				break;
			case ECustomCameraMode.Scene:
				newViewTarget = separateCameraModel.SceneCamera.DisplayComponent.CineCamera;
				break;
			case ECustomCameraMode.Orbital:
				newViewTarget = separateCameraModel.OrbitalCamera.DisplayComponent.CineCamera;
				break;
			case ECustomCameraMode.Free:
				newViewTarget = separateCameraModel.FreeCamera.DisplayComponent.CameraActor;
				break;
			default:
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "CameraManager.SwitchCameraMode: 错误的镜头模式 ";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("mode", mode);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			}
			float blendTime2 = blendTime * CharacterModel.Instance.SelfCenteredTimeDilation;
			this.SetViewTarget(newViewTarget, "SwitchMode", blendTime2, blendFunction, blendExp, new bool?(true), new bool?(true), cameraName, callback, blendCurve);
			return true;
		}

		// Token: 0x06048054 RID: 294996 RVA: 0x01276878 File Offset: 0x01274A78
		public void RefreshSequenceCamera(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			ECustomCameraMode? cameraMode = separateCameraModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Sequence;
			if (!(cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null))
			{
				return;
			}
			this.SetViewTarget(separateCameraModel.SequenceCamera.DisplayComponent.CineCamera, "RefreshMode", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), cameraName, null, null);
		}

		// Token: 0x06048055 RID: 294997 RVA: 0x012768E8 File Offset: 0x01274AE8
		public void EnterDialogueMode([Nullable(2)] Vector interactPoint, bool delayBlendInDialogueCamera = false, float? specificOffsetRate = null, float? specificHeightOffset = null, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.EnterSequenceDialogue(interactPoint, delayBlendInDialogueCamera, specificOffsetRate, specificHeightOffset);
		}

		// Token: 0x06048056 RID: 294998 RVA: 0x0127691C File Offset: 0x01274B1C
		public void ExitDialogMode(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.ExitSequenceDialogue();
		}

		// Token: 0x06048057 RID: 294999 RVA: 0x0127694C File Offset: 0x01274B4C
		public void EnterCameraExplore(int id, FVectorDouble? lookAt1, FVectorDouble? lookAt2, float prepTime, float fadeDistance, float armLengthMin, float armLengthMax, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.EnterCameraExplore(id, lookAt1, lookAt2, prepTime, fadeDistance, armLengthMin, armLengthMax);
		}

		// Token: 0x06048058 RID: 295000 RVA: 0x01276988 File Offset: 0x01274B88
		public void ExitCameraExplore(int id, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.ExitCameraExplore(id);
		}

		// Token: 0x06048059 RID: 295001 RVA: 0x012769B6 File Offset: 0x01274BB6
		public ACameraActor SpawnCameraActor()
		{
			ACameraActor acameraActor = this.SpawnActor<ACameraActor>(ACameraActor.StaticClass());
			acameraActor.CameraComponent.bConstrainAspectRatio = false;
			return acameraActor;
		}

		// Token: 0x0604805A RID: 295002 RVA: 0x012769D0 File Offset: 0x01274BD0
		public void SetInputEnable(object handler, bool bVisible, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.CameraInputController.SetInputEnable(handler, bVisible);
		}

		// Token: 0x0604805B RID: 295003 RVA: 0x01276A04 File Offset: 0x01274C04
		public BP_CineCamera_C SpawnCineCamera()
		{
			return this.SpawnActor<BP_CineCamera_C>(BP_CineCamera_C.StaticClass());
		}

		// Token: 0x0604805C RID: 295004 RVA: 0x01276A11 File Offset: 0x01274C11
		public T SpawnActor<[Nullable(0)] T>(UClassStackOnlyPtr type) where T : AActor
		{
			return (T)((object)ActorSystem.Instance.Get(type, MathUtils.Instance.DefaultTransformDouble, null, true));
		}

		// Token: 0x0604805D RID: 295005 RVA: 0x01276A2F File Offset: 0x01274C2F
		[NullableContext(2)]
		public ACharacter GetCharacter()
		{
			return Global.BaseCharacter;
		}

		// Token: 0x0604805E RID: 295006 RVA: 0x01276A36 File Offset: 0x01274C36
		[NullableContext(2)]
		public APlayerController GetPlayerController()
		{
			return Global.PlayerController;
		}

		// Token: 0x0604805F RID: 295007 RVA: 0x01276A40 File Offset: 0x01274C40
		public TArray<SCamera_Setting> GetCameraConfigs([Nullable(2)] UDataTable dataTable = null)
		{
			TArray<SCamera_Setting> result = new TArray<SCamera_Setting>();
			BPL_CameraUtility_C.DtGetCameraConfigs(ref result, dataTable, GlobalData.World);
			return result;
		}

		// Token: 0x06048060 RID: 295008 RVA: 0x01276A64 File Offset: 0x01274C64
		public TArray<SCameraConfig> GetCameraConfigList([Nullable(2)] UDataTable dataTable = null)
		{
			TArray<SCameraConfig> result = new TArray<SCameraConfig>();
			BPL_CameraUtility_C.DtGetCameraConfigList(ref result, dataTable, GlobalData.World);
			return result;
		}

		// Token: 0x06048061 RID: 295009 RVA: 0x01276A85 File Offset: 0x01274C85
		public APlayerCameraManager GetMainPlayerCameraManager()
		{
			return Global.CharacterCameraManager;
		}

		// Token: 0x06048062 RID: 295010 RVA: 0x01276A8C File Offset: 0x01274C8C
		[return: Nullable(2)]
		public APlayerCameraManager GetPlayerCameraManager(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return null;
			}
			return separateCameraModel.PlayerCameraManager;
		}

		// Token: 0x06048063 RID: 295011 RVA: 0x01276AA4 File Offset: 0x01274CA4
		public void SetTimeDilation(float timeDilation, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.SetTimeDilation(timeDilation);
			separateCameraModel.SequenceCamera.SetTimeDilation(timeDilation);
			separateCameraModel.WidgetCamera.SetTimeDilation(timeDilation);
			separateCameraModel.OrbitalCamera.SetTimeDilation(timeDilation);
			FreeCamera freeCamera = separateCameraModel.FreeCamera;
			if (freeCamera != null)
			{
				freeCamera.SetTimeDilation(timeDilation);
			}
			Global.CharacterCameraManager.CameraModifyCustomTimeDilation = timeDilation;
		}

		// Token: 0x06048064 RID: 295012 RVA: 0x01276B10 File Offset: 0x01274D10
		public void PlayWorldCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> shakeClass, FVectorDouble? location, float innerRadius, float outerRadius, float falloff, bool shakeTowardsEpicenter, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			if (this.IsSettlementCamera(cameraName) || this.IsSequenceCameraInCinematic(cameraName))
			{
				return;
			}
			if (separateCameraModel.ShakeModify > 0f)
			{
				UGameplayStatics.D_PlayWorldCameraShakeWithModifier(GlobalData.World, shakeClass, location.GetValueOrDefault(), innerRadius, outerRadius, falloff, shakeTowardsEpicenter, separateCameraModel.ShakeModify, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
			}
			this.PlayForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(shakeClass), cameraName);
		}

		// Token: 0x06048065 RID: 295013 RVA: 0x01276B88 File Offset: 0x01274D88
		public int PlayCameraShake([Nullable(2)] UClass shakeClass, float? scale = null, ECameraShakePlaySpace? playSpace = null, FRotator? userPlaySpaceRot = null, bool playForceFeedback = false, bool stopManually = false, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return -1;
			}
			if (!Global.CharacterCameraManager.IsValid())
			{
				return -1;
			}
			if (this.IsSettlementCamera(cameraName) || this.IsSequenceCameraInCinematic(cameraName))
			{
				return -1;
			}
			UCameraShakeBase ucameraShakeBase = Global.CharacterCameraManager.StartCameraShake(shakeClass, scale.GetValueOrDefault(1f), playSpace.GetValueOrDefault(), userPlaySpaceRot.GetValueOrDefault(), CharacterModel.Instance.InverseSelfCenteredTimeDilation);
			if (playForceFeedback)
			{
				this.PlayForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(shakeClass), cameraName);
			}
			if (stopManually && ucameraShakeBase != null)
			{
				Dictionary<int, UCameraShakeBase> cameraShakeMap = separateCameraModel.CameraShakeMap;
				CameraModelInstance cameraModelInstance = separateCameraModel;
				int num = cameraModelInstance.CameraShakeInstanceId + 1;
				cameraModelInstance.CameraShakeInstanceId = num;
				cameraShakeMap.Add(num, ucameraShakeBase);
			}
			return separateCameraModel.CameraShakeInstanceId;
		}

		// Token: 0x06048066 RID: 295014 RVA: 0x01276C44 File Offset: 0x01274E44
		public void StopCameraShake(int cameraShakeInstanceId, bool playForceFeedback = false, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			if (!Global.CharacterCameraManager.IsValid())
			{
				return;
			}
			if (!separateCameraModel.CameraShakeMap.ContainsKey(cameraShakeInstanceId))
			{
				return;
			}
			UCameraShakeBase ucameraShakeBase;
			if (separateCameraModel.CameraShakeMap.Remove(cameraShakeInstanceId, out ucameraShakeBase))
			{
				if (!ucameraShakeBase.IsValid())
				{
					return;
				}
				Global.CharacterCameraManager.StopCameraShake(ucameraShakeBase, true);
				if (playForceFeedback)
				{
					this.StopForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(ucameraShakeBase.GetClass()), cameraName);
				}
			}
		}

		// Token: 0x06048067 RID: 295015 RVA: 0x01276CBC File Offset: 0x01274EBC
		public void PlayForceFeedbackFromCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass = null, string cameraName = "MainCamera")
		{
			if (Info.Instance.IsInGamepad() && (shakeClass != null && shakeClass.GetValueOrDefault().IsChildOf(BP_CameraShakeAndForceFeedback_C.StaticClass())))
			{
				UKuroForceFeedbackEffect forceFeedbackEffect = (UKuroStaticLibrary.GetDefaultObject(shakeClass.Value) as BP_CameraShakeAndForceFeedback_C).ForceFeedbackEffect;
				if (forceFeedbackEffect != null)
				{
					GamepadController.Instance.PlayKuroForceFeedback(forceFeedbackEffect, null, false, false, false, "CameraController");
				}
			}
		}

		// Token: 0x06048068 RID: 295016 RVA: 0x01276D34 File Offset: 0x01274F34
		public void StopForceFeedbackFromCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass = null, string cameraName = "MainCamera")
		{
			if (Info.Instance.IsInGamepad() && (shakeClass != null && shakeClass.GetValueOrDefault().IsChildOf(BP_CameraShakeAndForceFeedback_C.StaticClass())))
			{
				UKuroForceFeedbackEffect forceFeedbackEffect = (UKuroStaticLibrary.GetDefaultObject(shakeClass.Value) as BP_CameraShakeAndForceFeedback_C).ForceFeedbackEffect;
				if (forceFeedbackEffect != null)
				{
					GamepadController.StopKuroForceFeedback(forceFeedbackEffect, FNameUtil.NONE);
				}
			}
		}

		// Token: 0x06048069 RID: 295017 RVA: 0x01276D9C File Offset: 0x01274F9C
		[NullableContext(2)]
		public void LoadCharacterCameraConfig(UDataTable dataTable)
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.FightCamera.LogicComponent.CameraConfigController.LoadCharacterConfig(dataTable);
			});
		}

		// Token: 0x0604806A RID: 295018 RVA: 0x01276DCC File Offset: 0x01274FCC
		public void UnloadCharacterCameraConfig([Nullable(2)] UDataTable dataTable, string cameraName = "MainCamera")
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.FightCamera.LogicComponent.CameraConfigController.UnloadCharacterConfig(dataTable);
			});
		}

		// Token: 0x0604806B RID: 295019 RVA: 0x01276DFC File Offset: 0x01274FFC
		public unsafe bool ReturnLockOnCameraMode(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, [Nullable(2)] Action callback = null, string cameraName = "MainCamera")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraMode]ReturnLockOnCameraMode";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("blendTime", blendTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendFunction", blendFunction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendExp", blendExp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (this.CameraModeMutex)
			{
				return this.PushPendingCameraModeRequest(true, ECustomCameraMode.LockOn, blendTime, blendFunction, blendExp, callback, true, cameraName, null);
			}
			this.CameraModeMutex = true;
			bool result;
			try
			{
				result = this.ReturnLockOnCameraModeInternal(blendTime, blendFunction, blendExp, callback, cameraName);
			}
			finally
			{
				this.CameraModeMutex = false;
			}
			this.DrainPendingCameraModeRequests();
			return result;
		}

		// Token: 0x0604806C RID: 295020 RVA: 0x01276EEC File Offset: 0x012750EC
		public bool ReturnLockOnCameraModeInternal(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, [Nullable(2)] Action callback = null, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return false;
			}
			ECustomCameraMode? ecustomCameraMode = separateCameraModel.CameraMode;
			ECustomCameraMode ecustomCameraMode2 = ECustomCameraMode.LockOn;
			if (ecustomCameraMode.GetValueOrDefault() == ecustomCameraMode2 & ecustomCameraMode != null)
			{
				return false;
			}
			ECustomCameraMode? cameraMode = separateCameraModel.CameraMode;
			for (;;)
			{
				ecustomCameraMode = cameraMode;
				ecustomCameraMode2 = ECustomCameraMode.LockOn;
				if (ecustomCameraMode.GetValueOrDefault() == ecustomCameraMode2 & ecustomCameraMode != null)
				{
					break;
				}
				if (cameraMode != null)
				{
					separateCameraModel.DisableMode(cameraMode.Value);
				}
				cameraMode = new ECustomCameraMode?(separateCameraModel.GetNextMode());
			}
			return this.SwitchCameraMode(cameraMode.Value, blendTime, blendFunction, blendExp, callback, cameraName, null);
		}

		// Token: 0x0604806D RID: 295021 RVA: 0x01276F84 File Offset: 0x01275184
		public bool IsSequenceCameraInCinematic(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent;
			if (separateCameraModel == null)
			{
				sequenceCameraPlayerComponent = null;
			}
			else
			{
				SequenceCamera sequenceCamera = separateCameraModel.SequenceCamera;
				sequenceCameraPlayerComponent = ((sequenceCamera != null) ? sequenceCamera.GetComponent<SequenceCameraPlayerComponent>() : null);
			}
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent2 = sequenceCameraPlayerComponent;
			return sequenceCameraPlayerComponent2 != null && sequenceCameraPlayerComponent2.Valid && sequenceCameraPlayerComponent2.GetIsInCinematic();
		}

		// Token: 0x0604806E RID: 295022 RVA: 0x01276FD0 File Offset: 0x012751D0
		private void UpdateCameraLayout(float deltaTime)
		{
			if (!CameraModel.Instance.HasSeparateCamera())
			{
				return;
			}
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.UpdateCameraLayout(deltaTime);
			});
		}

		// Token: 0x0604806F RID: 295023 RVA: 0x0127700D File Offset: 0x0127520D
		private void UpdateCameraTransform()
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				AActor currentCameraActor = cameraModelInstance.CurrentCameraActor;
				if (currentCameraActor == null || !currentCameraActor.IsValid())
				{
					return;
				}
				Vector cameraLocation = cameraModelInstance.CameraLocation;
				FVectorDouble fvectorDouble = cameraModelInstance.CurrentCameraActor.D_K2_GetActorLocation();
				cameraLocation.FromUeVector(fvectorDouble);
				Rotator cameraRotator = cameraModelInstance.CameraRotator;
				FRotator frotator = cameraModelInstance.CurrentCameraActor.K2_GetActorRotation();
				cameraRotator.DeepCopy(frotator);
				cameraModelInstance.CameraTransform = new FTransformDouble?(cameraModelInstance.CurrentCameraActor.D_GetTransform());
			});
		}

		// Token: 0x06048070 RID: 295024 RVA: 0x01277038 File Offset: 0x01275238
		public void UpdateCameraDitherRadius()
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.UpdateCameraDitherRadius();
			});
		}

		// Token: 0x06048071 RID: 295025 RVA: 0x01277064 File Offset: 0x01275264
		public bool IsSettlementCamera(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			bool flag;
			if (separateCameraModel == null)
			{
				flag = (null != null);
			}
			else
			{
				FightCamera fightCamera = separateCameraModel.FightCamera;
				if (fightCamera == null)
				{
					flag = (null != null);
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					flag = (((logicComponent != null) ? logicComponent.SettlementCamera : null) != null);
				}
			}
			return flag && separateCameraModel.FightCamera.LogicComponent.SettlementCamera.IsPlayingSettlementCamera();
		}

		// Token: 0x06048072 RID: 295026 RVA: 0x012770BA File Offset: 0x012752BA
		public void StopAllCameraShakes()
		{
			Global.CharacterCameraManager.StopAllCameraShakes(true);
		}

		// Token: 0x06048073 RID: 295027 RVA: 0x012770C8 File Offset: 0x012752C8
		public void SetHideHeadEnable(bool enable, EHideHeadEnum firstPersonType, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetHideHeadEnabled(enable, firstPersonType);
		}

		// Token: 0x06048074 RID: 295028 RVA: 0x012770F0 File Offset: 0x012752F0
		private void ConstrainAspectRatio(bool bConstrainAspectRatio, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			FightCamera fightCamera = separateCameraModel.FightCamera;
			ACameraActor acameraActor;
			if (fightCamera == null)
			{
				acameraActor = null;
			}
			else
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				acameraActor = ((logicComponent != null) ? logicComponent.CameraActor : null);
			}
			ACameraActor acameraActor2 = acameraActor;
			if (acameraActor2 == null || !acameraActor2.IsValid() || Global.CharacterController == null)
			{
				return;
			}
			if (acameraActor2.CameraComponent.bConstrainAspectRatio == bConstrainAspectRatio)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			Global.CharacterController.GetViewportSize(ref num, ref num2);
			double num3 = (double)((float)num);
			float num4 = (float)num2;
			if (num3 / (double)num4 >= 1.76)
			{
				return;
			}
			acameraActor2.CameraComponent.bConstrainAspectRatio = bConstrainAspectRatio;
		}

		// Token: 0x06048075 RID: 295029 RVA: 0x01277188 File Offset: 0x01275388
		public FViewTargetTransitionParams GetDefaultViewTargetTransitionParams()
		{
			CameraController.ViewTargetTransitionParams.BlendTime = 0f;
			CameraController.ViewTargetTransitionParams.BlendFunction = EViewTargetBlendFunction.VTBlend_Linear;
			CameraController.ViewTargetTransitionParams.BlendExp = 0f;
			CameraController.ViewTargetTransitionParams.bLockOutgoing = false;
			CameraController.ViewTargetTransitionParams.bKuroEnableBlend = false;
			CameraController.ViewTargetTransitionParams.BlendCurve = null;
			return CameraController.ViewTargetTransitionParams;
		}

		// Token: 0x06048076 RID: 295030 RVA: 0x012771EC File Offset: 0x012753EC
		public void RestoreSeparateCamera(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[分屏相机]RestoreSeparateCamera";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.InitSeparateCamera("MainCamera", Vector2D.Create(0.0, 0.0), Vector2D.Create(1.0, 1.0), false, true);
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				CameraModel.Instance.DestroySeparateCameraModel(cameraModelInstance.CameraName);
			});
			this.RestoreFrameGenCvars();
		}

		// Token: 0x06048077 RID: 295031 RVA: 0x0127728C File Offset: 0x0127548C
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (oldEntity != null && oldEntity.Valid)
			{
				BaseTagComponent component = oldEntity.Entity.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					component.RemoveTagAddOrRemoveListener(CameraController.ConstrainAspectRatioGameplayTag, new BaseTagComponent.TTagSwitchedCallback(this.OnConstrainAspectRatioGameplayTagChanged));
				}
			}
			if (newEntity.Valid)
			{
				BaseTagComponent component2 = newEntity.Entity.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					component2.AddTagAddOrRemoveListener(CameraController.ConstrainAspectRatioGameplayTag, new BaseTagComponent.TTagSwitchedCallback(this.OnConstrainAspectRatioGameplayTagChanged), null);
					this.ConstrainAspectRatio(component2.HasTag(CameraController.ConstrainAspectRatioGameplayTag), "MainCamera");
				}
			}
		}

		// Token: 0x06048078 RID: 295032 RVA: 0x0127731F File Offset: 0x0127551F
		private void OnConstrainAspectRatioGameplayTagChanged(int gameplayTagId, bool tagExist)
		{
			this.ConstrainAspectRatio(tagExist, "MainCamera");
		}

		// Token: 0x06048079 RID: 295033 RVA: 0x01277330 File Offset: 0x01275530
		private void BeforeLoadMap()
		{
			APlayerCameraManager playerCameraManager = this.GetPlayerCameraManager("MainCamera");
			ACameraActor acameraActor = (playerCameraManager != null) ? playerCameraManager.AnimCameraActor : null;
			if (acameraActor != null && acameraActor.IsValid())
			{
				SeamlessTravelModel.Instance.AddSeamlessTravelActor(acameraActor);
			}
			this.RestoreSeparateCamera("BeforeLoadMap");
		}

		// Token: 0x0604807A RID: 295034 RVA: 0x01277378 File Offset: 0x01275578
		private void AfterLoadMap()
		{
			APlayerCameraManager playerCameraManager = this.GetPlayerCameraManager("MainCamera");
			ACameraActor acameraActor = (playerCameraManager != null) ? playerCameraManager.AnimCameraActor : null;
			if (acameraActor != null && acameraActor.IsValid())
			{
				SeamlessTravelModel.Instance.RemoveSeamlessTravelActor(acameraActor);
			}
			this.RestoreSeparateCamera("AfterLoadMap");
		}

		// Token: 0x0604807B RID: 295035 RVA: 0x012773BF File Offset: 0x012755BF
		protected override bool OnLeaveLevel()
		{
			this.RestoreSeparateCamera("OnLeaveLevel");
			return true;
		}

		// Token: 0x0604807C RID: 295036 RVA: 0x012773CD File Offset: 0x012755CD
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.BeforeLoadMap));
			EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.AfterLoadMap));
			return base.OnClear();
		}

		// Token: 0x17009F06 RID: 40710
		// (get) Token: 0x0604807D RID: 295037 RVA: 0x0127740D File Offset: 0x0127560D
		public static CameraController Instance
		{
			get
			{
				return CameraController._Instance;
			}
		}

		// Token: 0x0604807E RID: 295038 RVA: 0x01277414 File Offset: 0x01275614
		public static CameraController GetOrCreateInstance()
		{
			if (CameraController._Instance == null)
			{
				CameraController.CreateInstance();
			}
			return CameraController._Instance;
		}

		// Token: 0x0604807F RID: 295039 RVA: 0x01277428 File Offset: 0x01275628
		public static bool CreateInstance()
		{
			if (CameraController._Instance != null)
			{
				return true;
			}
			CameraController._Instance = new CameraController();
			return true;
		}

		// Token: 0x06048080 RID: 295040 RVA: 0x0127743E File Offset: 0x0127563E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06048081 RID: 295041 RVA: 0x01277440 File Offset: 0x01275640
		public static void ResetStaticDefaultValue()
		{
			CameraController._Instance = null;
		}

		// Token: 0x06048082 RID: 295042 RVA: 0x01277448 File Offset: 0x01275648
		static CameraController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraController.CreateStaticDefaultValue), new Action(CameraController.ResetStaticDefaultValue));
		}

		// Token: 0x04025F9B RID: 155547
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x04025F9C RID: 155548
		private const double CONSTRAIN_ASPECT_RATIO = 1.76;

		// Token: 0x04025F9D RID: 155549
		private static readonly int ConstrainAspectRatioGameplayTag = GameplayTagDefine.EGameplayTagId["关卡.副本.跑酷副本.调节长宽比专用"];

		// Token: 0x04025F9E RID: 155550
		[StaticVariableRuleIgnore]
		private static readonly string[] SeparateCameraDisabledCvars = new string[]
		{
			"r.NGX.DLSS.Enable",
			"r.Streamline.DLSSG.Enable",
			"r.FidelityFX.FSR3.Enabled",
			"r.FidelityFX.FI.Enabled",
			"r.Xess.Enabled",
			"r.XeFG.Enabled",
			"r.VolumetricCloud.MinMaxDepth"
		};

		// Token: 0x04025F9F RID: 155551
		[StaticVariableRuleIgnore]
		public static readonly FViewTargetTransitionParams ViewTargetTransitionParams = new FViewTargetTransitionParams();

		// Token: 0x04025FA0 RID: 155552
		private const bool CameraModeDebug = true;

		// Token: 0x04025FA1 RID: 155553
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D1 = Vector2D.Create();

		// Token: 0x04025FA2 RID: 155554
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D2 = Vector2D.Create();

		// Token: 0x04025FA3 RID: 155555
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D3 = Vector2D.Create();

		// Token: 0x04025FA4 RID: 155556
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D4 = Vector2D.Create();

		// Token: 0x04025FA5 RID: 155557
		private readonly Dictionary<string, int> CachedFrameGenCvarValues = new Dictionary<string, int>();

		// Token: 0x04025FA6 RID: 155558
		private bool CameraModeMutex;

		// Token: 0x04025FA7 RID: 155559
		private List<CameraController.PendingCameraModeRequest> PendingCameraModeRequests = new List<CameraController.PendingCameraModeRequest>();

		// Token: 0x04025FA8 RID: 155560
		private const int CAMERA_MODE_MAX_PENDING_COUNT = 5;

		// Token: 0x04025FA9 RID: 155561
		private bool IsDrainingCameraModeRequests;

		// Token: 0x04025FAA RID: 155562
		[Nullable(2)]
		private static CameraController _Instance;

		// Token: 0x0200CFBF RID: 53183
		[NullableContext(2)]
		[Nullable(0)]
		private class PendingCameraModeRequest
		{
			// Token: 0x0403E79D RID: 255901
			public bool IsEnter;

			// Token: 0x0403E79E RID: 255902
			public ECustomCameraMode Mode;

			// Token: 0x0403E79F RID: 255903
			public float BlendTime;

			// Token: 0x0403E7A0 RID: 255904
			public EViewTargetBlendFunction BlendFunction;

			// Token: 0x0403E7A1 RID: 255905
			public float BlendExp;

			// Token: 0x0403E7A2 RID: 255906
			public Action Callback;

			// Token: 0x0403E7A3 RID: 255907
			public bool BMustCallback;

			// Token: 0x0403E7A4 RID: 255908
			[Nullable(1)]
			public string CameraName = "MainCamera";

			// Token: 0x0403E7A5 RID: 255909
			public UCurveFloat BlendCurve;
		}
	}
}
