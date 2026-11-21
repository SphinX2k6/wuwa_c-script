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
	// Token: 0x0200642B RID: 25643
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class CameraController : ControllerBase
	{
		// Token: 0x1700766A RID: 30314
		// (get) Token: 0x0603E409 RID: 254985 RVA: 0x01216750 File Offset: 0x01214950
		public CameraModelInstance MainModel
		{
			get
			{
				return CameraModel.Instance.MainModel;
			}
		}

		// Token: 0x0603E40A RID: 254986 RVA: 0x0121675C File Offset: 0x0121495C
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.BeforeLoadMap));
			EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.AfterLoadMap));
			return base.OnInit();
		}

		// Token: 0x0603E40B RID: 254987 RVA: 0x012167C4 File Offset: 0x012149C4
		public void OnPossess([Nullable(2)] APawn pawn, string cameraName = "MainCamera")
		{
			CameraModel instance = CameraModel.Instance;
			if (instance == null)
			{
				return;
			}
			CameraModelInstance separateCameraModel = instance.GetSeparateCameraModel(cameraName);
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

		// Token: 0x0603E40C RID: 254988 RVA: 0x01216814 File Offset: 0x01214A14
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

		// Token: 0x0603E40D RID: 254989 RVA: 0x012168AC File Offset: 0x01214AAC
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

		// Token: 0x0603E40E RID: 254990 RVA: 0x01216980 File Offset: 0x01214B80
		public CameraModelInstance InitSeparateCamera(string cameraName, [Nullable(2)] Vector2D initLocation = null, [Nullable(2)] Vector2D initSize = null, bool enableScissorOffset = false, bool enableLog = false)
		{
			CameraModelInstance cameraModelInstance = CameraModel.Instance.CreateSeparateCameraModel(cameraName);
			if (cameraName != "MainCamera")
			{
				this.CacheAndDisableFrameGenCvars();
			}
			if (enableLog)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[分屏相机]初始化分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			Vector2D viewLocation = initLocation ?? Vector2D.Create();
			Vector2D viewSize = initSize ?? Vector2D.Create();
			cameraModelInstance.SetViewInfo(viewLocation, viewSize, enableScissorOffset);
			return cameraModelInstance;
		}

		// Token: 0x0603E40F RID: 254991 RVA: 0x012169EB File Offset: 0x01214BEB
		[return: Nullable(2)]
		public CameraModelInstance GetSeparateCameraModel(string cameraName)
		{
			return CameraModel.Instance.GetSeparateCameraModel(cameraName);
		}

		// Token: 0x0603E410 RID: 254992 RVA: 0x012169F8 File Offset: 0x01214BF8
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

		// Token: 0x0603E411 RID: 254993 RVA: 0x01216A7C File Offset: 0x01214C7C
		[NullableContext(2)]
		public void DestroySeparateCameraModel([Nullable(1)] string cameraName, float fadeTime = 0f, Vector2D targetViewLocation = null, Vector2D targetViewSize = null, bool enableScissorOffset = false, UCurveFloat curveFloat = null, Action callback = null)
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

		// Token: 0x0603E412 RID: 254994 RVA: 0x01216AF2 File Offset: 0x01214CF2
		[return: Nullable(2)]
		public CameraModelInstance DetachSeparateCameraModel(string cameraName)
		{
			return CameraModel.Instance.DetachSeparateCameraModel(cameraName);
		}

		// Token: 0x0603E413 RID: 254995 RVA: 0x01216B00 File Offset: 0x01214D00
		public void DestroyDetachedSeparateCameraModel(CameraModelInstance cameraModel)
		{
			cameraModel.Clear();
			CameraModel instance = CameraModel.Instance;
			if (instance != null && !instance.HasSeparateCamera())
			{
				this.RestoreFrameGenCvars();
			}
		}

		// Token: 0x0603E414 RID: 254996 RVA: 0x01216B2B File Offset: 0x01214D2B
		public void DestroySeparateCameraModelImmediately(string cameraName)
		{
			if (cameraName == "MainCamera")
			{
				return;
			}
			CameraModel.Instance.DestroySeparateCameraModel(cameraName);
			if (!CameraModel.Instance.HasSeparateCamera())
			{
				this.RestoreFrameGenCvars();
			}
		}

		// Token: 0x0603E415 RID: 254997 RVA: 0x01216B58 File Offset: 0x01214D58
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", newViewTarget.GetName());
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

		// Token: 0x0603E416 RID: 254998 RVA: 0x01216D90 File Offset: 0x01214F90
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

		// Token: 0x0603E417 RID: 254999 RVA: 0x01216E1D File Offset: 0x0121501D
		protected override void OnTick(float delta)
		{
			this.UpdateCameraLayout(delta);
			this.UpdateCameraTransform();
			this.UpdateCameraDitherRadius();
		}

		// Token: 0x0603E418 RID: 255000 RVA: 0x01216E34 File Offset: 0x01215034
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

		// Token: 0x0603E419 RID: 255001 RVA: 0x01216F6C File Offset: 0x0121516C
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

		// Token: 0x0603E41A RID: 255002 RVA: 0x01217068 File Offset: 0x01215268
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

		// Token: 0x0603E41B RID: 255003 RVA: 0x0121717C File Offset: 0x0121537C
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

		// Token: 0x0603E41C RID: 255004 RVA: 0x012171DC File Offset: 0x012153DC
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

		// Token: 0x0603E41D RID: 255005 RVA: 0x012173B4 File Offset: 0x012155B4
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

		// Token: 0x0603E41E RID: 255006 RVA: 0x01217688 File Offset: 0x01215888
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

		// Token: 0x0603E41F RID: 255007 RVA: 0x0121770C File Offset: 0x0121590C
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

		// Token: 0x0603E420 RID: 255008 RVA: 0x01217888 File Offset: 0x01215A88
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

		// Token: 0x0603E421 RID: 255009 RVA: 0x012178F8 File Offset: 0x01215AF8
		public void EnterDialogueMode(Vector interactPoint, bool delayBlendInDialogueCamera = false, float? specificOffsetRate = null, float? specificHeightOffset = null, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.EnterSequenceDialogue(interactPoint, delayBlendInDialogueCamera, specificOffsetRate, specificHeightOffset);
		}

		// Token: 0x0603E422 RID: 255010 RVA: 0x0121792C File Offset: 0x01215B2C
		public void ExitDialogMode(string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.ExitSequenceDialogue();
		}

		// Token: 0x0603E423 RID: 255011 RVA: 0x0121795C File Offset: 0x01215B5C
		public void EnterCameraExplore(int id, FVectorDouble? lookAt1, FVectorDouble? lookAt2, float prepTime, float fadeDistance, float armLengthMin, float armLengthMax, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.EnterCameraExplore(id, lookAt1, lookAt2, prepTime, fadeDistance, armLengthMin, armLengthMax);
		}

		// Token: 0x0603E424 RID: 255012 RVA: 0x01217998 File Offset: 0x01215B98
		public void ExitCameraExplore(int id, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.ExitCameraExplore(id);
		}

		// Token: 0x0603E425 RID: 255013 RVA: 0x012179C6 File Offset: 0x01215BC6
		public ACameraActor SpawnCameraActor()
		{
			ACameraActor acameraActor = this.SpawnActor<ACameraActor>(ACameraActor.StaticClass());
			acameraActor.CameraComponent.bConstrainAspectRatio = false;
			return acameraActor;
		}

		// Token: 0x0603E426 RID: 255014 RVA: 0x012179E0 File Offset: 0x01215BE0
		public void SetInputEnable(object handler, bool bVisible, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.CameraInputController.SetInputEnable(handler, bVisible);
		}

		// Token: 0x0603E427 RID: 255015 RVA: 0x01217A14 File Offset: 0x01215C14
		public BP_CineCamera_C SpawnCineCamera()
		{
			return this.SpawnActor<BP_CineCamera_C>(BP_CineCamera_C.StaticClass());
		}

		// Token: 0x0603E428 RID: 255016 RVA: 0x01217A21 File Offset: 0x01215C21
		public T SpawnActor<[Nullable(0)] T>(UClassStackOnlyPtr type) where T : AActor
		{
			return (T)((object)ActorSystem.Instance.Get(type, MathUtils.Instance.DefaultTransformDouble, null, true));
		}

		// Token: 0x0603E429 RID: 255017 RVA: 0x01217A3F File Offset: 0x01215C3F
		[NullableContext(2)]
		public ACharacter GetCharacter()
		{
			return Global.BaseCharacter;
		}

		// Token: 0x0603E42A RID: 255018 RVA: 0x01217A46 File Offset: 0x01215C46
		[NullableContext(2)]
		public APlayerController GetPlayerController()
		{
			return Global.PlayerController;
		}

		// Token: 0x0603E42B RID: 255019 RVA: 0x01217A50 File Offset: 0x01215C50
		public TArray<SCamera_Setting> GetCameraConfigs([Nullable(2)] UDataTable dataTable = null)
		{
			TArray<SCamera_Setting> result = new TArray<SCamera_Setting>();
			BPL_CameraUtility_C.DtGetCameraConfigs(ref result, dataTable, GlobalData.World);
			return result;
		}

		// Token: 0x0603E42C RID: 255020 RVA: 0x01217A74 File Offset: 0x01215C74
		public TArray<SCameraConfig> GetCameraConfigList([Nullable(2)] UDataTable dataTable = null)
		{
			TArray<SCameraConfig> result = new TArray<SCameraConfig>();
			BPL_CameraUtility_C.DtGetCameraConfigList(ref result, dataTable, GlobalData.World);
			return result;
		}

		// Token: 0x0603E42D RID: 255021 RVA: 0x01217A95 File Offset: 0x01215C95
		public APlayerCameraManager GetMainPlayerCameraManager()
		{
			return Global.CharacterCameraManager;
		}

		// Token: 0x0603E42E RID: 255022 RVA: 0x01217A9C File Offset: 0x01215C9C
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

		// Token: 0x0603E42F RID: 255023 RVA: 0x01217AB4 File Offset: 0x01215CB4
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

		// Token: 0x0603E430 RID: 255024 RVA: 0x01217B20 File Offset: 0x01215D20
		public void PlayWorldCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass, FVectorDouble? location, float innerRadius, float outerRadius, float falloff, bool shakeTowardsEpicenter, string cameraName = "MainCamera")
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
				UGameplayStatics.D_PlayWorldCameraShakeWithModifier(GlobalData.World, shakeClass.GetValueOrDefault(), location.GetValueOrDefault(), innerRadius, outerRadius, falloff, shakeTowardsEpicenter, separateCameraModel.ShakeModify, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
			}
			this.PlayForceFeedbackFromCameraShake(shakeClass, cameraName);
		}

		// Token: 0x0603E431 RID: 255025 RVA: 0x01217B98 File Offset: 0x01215D98
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

		// Token: 0x0603E432 RID: 255026 RVA: 0x01217C54 File Offset: 0x01215E54
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

		// Token: 0x0603E433 RID: 255027 RVA: 0x01217CCC File Offset: 0x01215ECC
		public void PlayForceFeedbackFromCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass = null, string cameraName = "MainCamera")
		{
			if (Info.Instance.IsInGamepad() && (shakeClass != null && shakeClass.GetValueOrDefault().IsChildOf(BP_CameraShakeAndForceFeedback_C.StaticClass())))
			{
				UKuroForceFeedbackEffect forceFeedbackEffect = (UKuroStaticLibrary.GetDefaultObject(shakeClass.Value) as BP_CameraShakeAndForceFeedback_C).ForceFeedbackEffect;
				if (forceFeedbackEffect != null && Global.CharacterController != null)
				{
					GamepadController.Instance.PlayKuroForceFeedback(forceFeedbackEffect, null, false, false, false, "CameraController");
				}
			}
		}

		// Token: 0x0603E434 RID: 255028 RVA: 0x01217D4C File Offset: 0x01215F4C
		public void StopForceFeedbackFromCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass = null, string cameraName = "MainCamera")
		{
			if (Info.Instance.IsInGamepad() && (shakeClass != null && shakeClass.GetValueOrDefault().IsChildOf(BP_CameraShakeAndForceFeedback_C.StaticClass())))
			{
				UKuroForceFeedbackEffect forceFeedbackEffect = (UKuroStaticLibrary.GetDefaultObject(shakeClass.Value) as BP_CameraShakeAndForceFeedback_C).ForceFeedbackEffect;
				if (forceFeedbackEffect != null && Global.CharacterController != null)
				{
					GamepadController.StopKuroForceFeedback(forceFeedbackEffect, FNameUtil.NONE);
				}
			}
		}

		// Token: 0x0603E435 RID: 255029 RVA: 0x01217DB8 File Offset: 0x01215FB8
		[NullableContext(2)]
		public void LoadCharacterCameraConfig(UDataTable dataTable)
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.FightCamera.LogicComponent.CameraConfigController.LoadCharacterConfig(dataTable);
			});
		}

		// Token: 0x0603E436 RID: 255030 RVA: 0x01217DE8 File Offset: 0x01215FE8
		public void UnloadCharacterCameraConfig([Nullable(2)] UDataTable dataTable, string cameraName = "MainCamera")
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.FightCamera.LogicComponent.CameraConfigController.UnloadCharacterConfig(dataTable);
			});
		}

		// Token: 0x0603E437 RID: 255031 RVA: 0x01217E18 File Offset: 0x01216018
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

		// Token: 0x0603E438 RID: 255032 RVA: 0x01217F08 File Offset: 0x01216108
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

		// Token: 0x0603E439 RID: 255033 RVA: 0x01217FA0 File Offset: 0x012161A0
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

		// Token: 0x0603E43A RID: 255034 RVA: 0x01217FEC File Offset: 0x012161EC
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

		// Token: 0x0603E43B RID: 255035 RVA: 0x01218029 File Offset: 0x01216229
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

		// Token: 0x0603E43C RID: 255036 RVA: 0x01218054 File Offset: 0x01216254
		public void UpdateCameraDitherRadius()
		{
			CameraModel.Instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				cameraModelInstance.UpdateCameraDitherRadius();
			});
		}

		// Token: 0x0603E43D RID: 255037 RVA: 0x01218080 File Offset: 0x01216280
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

		// Token: 0x0603E43E RID: 255038 RVA: 0x012180D6 File Offset: 0x012162D6
		public void StopAllCameraShakes()
		{
			Global.CharacterCameraManager.StopAllCameraShakes(true);
		}

		// Token: 0x0603E43F RID: 255039 RVA: 0x012180E4 File Offset: 0x012162E4
		public void SetHideHeadEnable(bool enable, EHideHeadEnum firstPersonType, string cameraName = "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetHideHeadEnabled(enable, firstPersonType);
		}

		// Token: 0x0603E440 RID: 255040 RVA: 0x0121810C File Offset: 0x0121630C
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

		// Token: 0x0603E441 RID: 255041 RVA: 0x012181A4 File Offset: 0x012163A4
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

		// Token: 0x0603E442 RID: 255042 RVA: 0x01218208 File Offset: 0x01216408
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

		// Token: 0x0603E443 RID: 255043 RVA: 0x012182A8 File Offset: 0x012164A8
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

		// Token: 0x0603E444 RID: 255044 RVA: 0x0121833B File Offset: 0x0121653B
		private void OnConstrainAspectRatioGameplayTagChanged(int gameplayTagId, bool tagExist)
		{
			this.ConstrainAspectRatio(tagExist, "MainCamera");
		}

		// Token: 0x0603E445 RID: 255045 RVA: 0x0121834C File Offset: 0x0121654C
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

		// Token: 0x0603E446 RID: 255046 RVA: 0x01218394 File Offset: 0x01216594
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

		// Token: 0x0603E447 RID: 255047 RVA: 0x012183DB File Offset: 0x012165DB
		protected override bool OnLeaveLevel()
		{
			this.RestoreSeparateCamera("OnLeaveLevel");
			return true;
		}

		// Token: 0x0603E448 RID: 255048 RVA: 0x012183E9 File Offset: 0x012165E9
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.BeforeLoadMap));
			EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.AfterLoadMap));
			return base.OnClear();
		}

		// Token: 0x0603E449 RID: 255049 RVA: 0x0121842C File Offset: 0x0121662C
		public unsafe bool CreateSequenceSeparateCamera(FName cameraNameValue, FName sequenceCameraTag, FKuroSeparateCameraData layout, bool enableSequencePlayerLogic)
		{
			string text = cameraNameValue.ToString();
			string text2 = sequenceCameraTag.ToString();
			if (!this.IsValidSequenceSeparateCameraName(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏]CameraName 非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!this.IsValidSequenceCameraTag(text2))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.ZJL;
				string message2 = "[LevelSequence分屏]SequenceCameraTag 非法";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("sequenceCameraTag", text2);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (CameraModel.Instance == null)
			{
				return false;
			}
			SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
			ALevelSequenceActor alevelSequenceActor = (sequenceCamera != null) ? sequenceCamera.GetLevelSequenceActor() : null;
			if (alevelSequenceActor == null || !alevelSequenceActor.IsValid())
			{
				return false;
			}
			if (sequenceCamera.HasSeparateCameraTagBinding(sequenceCameraTag))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Camera;
				ELogAuthor author3 = ELogAuthor.ZJL;
				string message3 = "[LevelSequence分屏]SequenceCameraTag 已被其他副屏占用";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sequenceCameraTag", text2);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (CameraController.Instance.GetSeparateCameraModel(text) != null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Camera;
				ELogAuthor author4 = ELogAuthor.ZJL;
				string message4 = "[LevelSequence分屏]CameraName 已存在，拒绝接管";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("cameraName", text);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			CameraModelInstance cameraModelInstance = CameraController.Instance.InitSeparateCamera(text, Vector2D.Create(), Vector2D.Create(), false, false);
			if (cameraModelInstance == null)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Camera;
				ELogAuthor author5 = ELogAuthor.ZJL;
				string message5 = "[LevelSequence分屏]初始化副屏相机失败";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("cameraName", text);
				instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			BP_CineCamera_C bp_CineCamera_C = this.ConfigureSeparateSequenceCameraComponents(cameraModelInstance, text, enableSequencePlayerLogic);
			if (bp_CineCamera_C == null)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Camera;
				ELogAuthor author6 = ELogAuthor.ZJL;
				string message6 = "[LevelSequence分屏]配置SequenceCamera组件失败";
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("cameraName", text);
				instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				return this.RollbackSequenceSeparateCameraCreation(text);
			}
			if (!this.EnterSeparateSequenceCameraMode(cameraModelInstance, text, bp_CineCamera_C))
			{
				return this.RollbackSequenceSeparateCameraCreation(text);
			}
			if (!this.BindSequenceCamera(alevelSequenceActor, text, sequenceCameraTag, bp_CineCamera_C))
			{
				return this.RollbackSequenceSeparateCameraCreation(text);
			}
			sequenceCamera.RegisterSeparateCameraBinding(text, sequenceCameraTag, bp_CineCamera_C, cameraModelInstance);
			this.ApplySequenceCameraLayout(text, layout);
			return true;
		}

		// Token: 0x0603E44A RID: 255050 RVA: 0x0121864C File Offset: 0x0121684C
		public void UpdateSequenceSeparateCamera(FName cameraNameValue, FKuroSeparateCameraData layout)
		{
			if (CameraModel.Instance == null)
			{
				return;
			}
			string cameraName = cameraNameValue.ToString();
			this.ApplySequenceCameraLayout(cameraName, layout);
		}

		// Token: 0x0603E44B RID: 255051 RVA: 0x01218678 File Offset: 0x01216878
		public void DestroySequenceSeparateCamera(FName cameraNameValue)
		{
			string cameraName = cameraNameValue.ToString();
			if (!this.IsValidSequenceSeparateCameraName(cameraName) || CameraModel.Instance == null)
			{
				return;
			}
			if (CameraController.Instance.GetSeparateCameraModel(cameraName) == null)
			{
				return;
			}
			SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
			if (sequenceCamera != null)
			{
				sequenceCamera.RemoveSeparateCameraBinding(cameraName);
			}
			CameraController.Instance.DestroySeparateCameraModelImmediately(cameraName);
		}

		// Token: 0x0603E44C RID: 255052 RVA: 0x012186D8 File Offset: 0x012168D8
		public void UpdateSequenceMainCamera(FKuroSeparateCameraData layout)
		{
			if (!layout.bEnabled || CameraModel.Instance == null)
			{
				return;
			}
			this.ApplySequenceCameraLayout("MainCamera", layout);
			SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
			if (sequenceCamera == null)
			{
				return;
			}
			sequenceCamera.MarkMainCameraLayoutOverridden();
		}

		// Token: 0x0603E44D RID: 255053 RVA: 0x0121870F File Offset: 0x0121690F
		public void ResetSequenceMainCamera()
		{
			if (CameraModel.Instance == null)
			{
				return;
			}
			CameraController.Instance.MainModel.ResetMainCameraLayout();
			SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
			if (sequenceCamera == null)
			{
				return;
			}
			sequenceCamera.ClearMainCameraLayoutOverride();
		}

		// Token: 0x0603E44E RID: 255054 RVA: 0x01218744 File Offset: 0x01216944
		[return: Nullable(2)]
		private unsafe BP_CineCamera_C ConfigureSeparateSequenceCameraComponents(CameraModelInstance cameraModel, string cameraName, bool enableSequencePlayerLogic)
		{
			SequenceCamera sequenceCamera = cameraModel.SequenceCamera;
			BP_CineCamera_C bp_CineCamera_C;
			if (sequenceCamera == null)
			{
				bp_CineCamera_C = null;
			}
			else
			{
				SequenceCameraDisplayComponent displayComponent = sequenceCamera.DisplayComponent;
				bp_CineCamera_C = ((displayComponent != null) ? displayComponent.CineCamera : null);
			}
			BP_CineCamera_C bp_CineCamera_C2 = bp_CineCamera_C;
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent = (sequenceCamera != null) ? sequenceCamera.PlayerComponent : null;
			bool flag = bp_CineCamera_C2 != null && bp_CineCamera_C2.IsValid();
			bool flag2 = sequenceCameraPlayerComponent != null && sequenceCameraPlayerComponent.Valid;
			if (bp_CineCamera_C2 == null || sequenceCameraPlayerComponent == null || !flag || !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏]创建后Sequence相机组件无效，回滚分屏相机";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", cameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isCineCameraValid", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isPlayerComponentValid", flag2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			sequenceCameraPlayerComponent.SetSeparateSequencePlayerLogicEnabled(enableSequencePlayerLogic);
			return bp_CineCamera_C2;
		}

		// Token: 0x0603E44F RID: 255055 RVA: 0x01218824 File Offset: 0x01216A24
		private unsafe bool EnterSeparateSequenceCameraMode(CameraModelInstance cameraModel, string cameraName, BP_CineCamera_C cineCamera)
		{
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, delegate
			{
			}, false, cameraName, null);
			ECustomCameraMode? cameraMode = cameraModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Sequence;
			if (!(cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) || cameraModel.CurrentCameraActor != cineCamera)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏]切换SequenceMode失败，回滚分屏相机";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", cameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cameraMode", cameraModel.CameraMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isExpectedViewTarget", cameraModel.CurrentCameraActor == cineCamera);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return true;
		}

		// Token: 0x0603E450 RID: 255056 RVA: 0x01218918 File Offset: 0x01216B18
		private unsafe bool BindSequenceCamera(ALevelSequenceActor levelSequenceActor, string cameraName, FName sequenceCameraTag, BP_CineCamera_C cineCamera)
		{
			TArray<AActor> tarray = new TArray<AActor>();
			tarray.Empty(true);
			tarray.Add(cineCamera);
			levelSequenceActor.SetBindingByTag(sequenceCameraTag, tarray, false, true);
			TArray<UObject> bindingByTag = levelSequenceActor.GetBindingByTag(sequenceCameraTag, true);
			int num = bindingByTag.Num();
			if (num != 1 || bindingByTag.Get(0) != cineCamera)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏]绑定结果与目标CineCamera不一致，回滚分屏相机";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", cameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sequenceCameraTag", sequenceCameraTag.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingCount", num);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				levelSequenceActor.RemoveBindingByTag(sequenceCameraTag, cineCamera, true);
				return false;
			}
			return true;
		}

		// Token: 0x0603E451 RID: 255057 RVA: 0x012189F0 File Offset: 0x01216BF0
		private bool IsValidSequenceSeparateCameraName(string cameraName)
		{
			return cameraName.Length > 0 && cameraName != "None" && cameraName != "MainCamera";
		}

		// Token: 0x0603E452 RID: 255058 RVA: 0x01218A15 File Offset: 0x01216C15
		private bool IsValidSequenceCameraTag(string sequenceCameraTag)
		{
			return sequenceCameraTag.Length > 0 && sequenceCameraTag != "None";
		}

		// Token: 0x0603E453 RID: 255059 RVA: 0x01218A2D File Offset: 0x01216C2D
		private bool RollbackSequenceSeparateCameraCreation(string cameraName)
		{
			CameraController.Instance.DestroySeparateCameraModelImmediately(cameraName);
			return false;
		}

		// Token: 0x0603E454 RID: 255060 RVA: 0x01218A3C File Offset: 0x01216C3C
		private void ApplySequenceCameraLayout(string cameraName, FKuroSeparateCameraData layout)
		{
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetViewInfo(Vector2D.Create((double)layout.Location.X, (double)layout.Location.Y), Vector2D.Create((double)layout.Size.X, (double)layout.Size.Y), layout.bEnableScissorOffset);
		}

		// Token: 0x1700766B RID: 30315
		// (get) Token: 0x0603E455 RID: 255061 RVA: 0x01218A9E File Offset: 0x01216C9E
		private static Dictionary<string, EditorPreviewCameraOwnership> EditorPreviewCameraOwnerships
		{
			get
			{
				return CameraController._editorPreviewCameraOwnerships;
			}
		}

		// Token: 0x1700766C RID: 30316
		// (get) Token: 0x0603E456 RID: 255062 RVA: 0x01218AA5 File Offset: 0x01216CA5
		private static HashSet<string> RejectedEditorPreviewOwners
		{
			get
			{
				return CameraController._rejectedEditorPreviewOwners;
			}
		}

		// Token: 0x0603E457 RID: 255063 RVA: 0x01218AAC File Offset: 0x01216CAC
		public unsafe bool BeginEditorPreview(string ownerId)
		{
			if (string.IsNullOrEmpty(ownerId) || CameraModel.Instance == null || this.HasRuntimeLevelSequenceActor())
			{
				return false;
			}
			if (!string.IsNullOrEmpty(CameraController.ActiveEditorPreviewOwner) && CameraController.ActiveEditorPreviewOwner != ownerId)
			{
				if (!CameraController.RejectedEditorPreviewOwners.Contains(ownerId))
				{
					CameraController.RejectedEditorPreviewOwners.Add(ownerId);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.ZJL;
					string message = "[LevelSequence分屏预览]已有其他Sequencer占用预览";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activeOwner", CameraController.ActiveEditorPreviewOwner);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rejectedOwner", ownerId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return false;
			}
			this.ActivateEditorPreviewOwner(ownerId);
			return true;
		}

		// Token: 0x0603E458 RID: 255064 RVA: 0x01218B68 File Offset: 0x01216D68
		[return: Nullable(2)]
		public unsafe ACameraActor PrepareEditorPreviewMainCamera(string ownerId, FKuroSeparateCameraData layout)
		{
			if (!this.BeginEditorPreview(ownerId))
			{
				return null;
			}
			CameraModelInstance cameraModelInstance = CameraController.Instance.GetSeparateCameraModel("__EditorPreviewMainCamera");
			EditorPreviewCameraOwnership editorPreviewCameraOwnership;
			CameraController.EditorPreviewCameraOwnerships.TryGetValue("__EditorPreviewMainCamera", out editorPreviewCameraOwnership);
			if (cameraModelInstance != null && (((editorPreviewCameraOwnership != null) ? editorPreviewCameraOwnership.OwnerId : null) != ownerId || editorPreviewCameraOwnership.CameraModel != cameraModelInstance))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏预览]预览主屏已被其他流程占用";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ownerId", ownerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentOwner", ((editorPreviewCameraOwnership != null) ? editorPreviewCameraOwnership.OwnerId : null) ?? "RuntimeOrUnknown");
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return this.FailEditorPreviewMainCameraPreparation("预览主屏被其他流程占用");
			}
			if (cameraModelInstance == null)
			{
				cameraModelInstance = CameraController.Instance.InitSeparateCamera("__EditorPreviewMainCamera", Vector2D.Create(), Vector2D.Create(), false, false);
				if (cameraModelInstance == null)
				{
					return this.FailEditorPreviewMainCameraPreparation("创建预览主屏失败");
				}
				CameraController.EditorPreviewCameraOwnerships["__EditorPreviewMainCamera"] = new EditorPreviewCameraOwnership(ownerId, cameraModelInstance);
			}
			BP_CineCamera_C bp_CineCamera_C = this.ConfigureEditorPreviewSequenceCameraComponents(cameraModelInstance, "__EditorPreviewMainCamera", false);
			if (bp_CineCamera_C == null || !this.EnterEditorPreviewSequenceCameraMode(cameraModelInstance, "__EditorPreviewMainCamera", bp_CineCamera_C))
			{
				return this.FailEditorPreviewMainCameraPreparation("配置预览主屏失败");
			}
			if (layout.bEnabled)
			{
				this.ApplyEditorPreviewLayout("__EditorPreviewMainCamera", layout);
			}
			else
			{
				this.ResetCameraLayout("__EditorPreviewMainCamera");
			}
			if (!this.HideRealMainCameraLayout())
			{
				return this.FailEditorPreviewMainCameraPreparation("隐藏真实主屏失败");
			}
			CameraController.IsEditorPreviewMainCameraActive = true;
			return bp_CineCamera_C;
		}

		// Token: 0x0603E459 RID: 255065 RVA: 0x01218CE4 File Offset: 0x01216EE4
		[return: Nullable(2)]
		public unsafe ACameraActor PrepareEditorPreviewSeparateCamera(string ownerId, FName cameraNameValue, FKuroSeparateCameraData layout)
		{
			string text = cameraNameValue.ToString();
			if (!this.IsValidEditorPreviewSeparateCameraName(text) || !layout.bEnabled)
			{
				return null;
			}
			bool shouldRollbackActivePreview = CameraController.ActiveEditorPreviewOwner != ownerId;
			if (!this.BeginEditorPreview(ownerId))
			{
				return null;
			}
			CameraModelInstance cameraModelInstance = CameraController.Instance.GetSeparateCameraModel(text);
			EditorPreviewCameraOwnership editorPreviewCameraOwnership;
			CameraController.EditorPreviewCameraOwnerships.TryGetValue(text, out editorPreviewCameraOwnership);
			if (cameraModelInstance != null && (((editorPreviewCameraOwnership != null) ? editorPreviewCameraOwnership.OwnerId : null) != ownerId || editorPreviewCameraOwnership.CameraModel != cameraModelInstance))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏预览]副屏已被其他流程占用";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ownerId", ownerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cameraName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("currentOwner", ((editorPreviewCameraOwnership != null) ? editorPreviewCameraOwnership.OwnerId : null) ?? "RuntimeOrUnknown");
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return this.FailEditorPreviewSeparateCameraPreparation(ownerId, text, "副屏已被其他流程占用", shouldRollbackActivePreview);
			}
			if (cameraModelInstance == null)
			{
				cameraModelInstance = CameraController.Instance.InitSeparateCamera(text, Vector2D.Create(), Vector2D.Create(), false, false);
				if (cameraModelInstance == null)
				{
					return this.FailEditorPreviewSeparateCameraPreparation(ownerId, text, "创建预览副屏失败", shouldRollbackActivePreview);
				}
				CameraController.EditorPreviewCameraOwnerships[text] = new EditorPreviewCameraOwnership(ownerId, cameraModelInstance);
			}
			BP_CineCamera_C bp_CineCamera_C = this.ConfigureEditorPreviewSequenceCameraComponents(cameraModelInstance, text, false);
			if (bp_CineCamera_C == null || !this.EnterEditorPreviewSequenceCameraMode(cameraModelInstance, text, bp_CineCamera_C))
			{
				return this.FailEditorPreviewSeparateCameraPreparation(ownerId, text, "配置预览副屏失败", shouldRollbackActivePreview);
			}
			this.ApplyEditorPreviewLayout(text, layout);
			return bp_CineCamera_C;
		}

		// Token: 0x0603E45A RID: 255066 RVA: 0x01218E6A File Offset: 0x0121706A
		public void EndEditorPreview(string ownerId, bool deferCameraModelDestruction = false)
		{
			if (string.IsNullOrEmpty(ownerId) || CameraController.ActiveEditorPreviewOwner != ownerId)
			{
				return;
			}
			this.ReleaseActiveEditorPreview("Sequencer预览结束", deferCameraModelDestruction);
		}

		// Token: 0x0603E45B RID: 255067 RVA: 0x01218E8E File Offset: 0x0121708E
		public void RequestRuntimeTakeover(string reason)
		{
			AKuroSplitScreenPreviewController.RequestRuntimeTakeover(reason);
			this.ReleaseActiveEditorPreview(reason, false);
		}

		// Token: 0x0603E45C RID: 255068 RVA: 0x01218EA0 File Offset: 0x012170A0
		private void ActivateEditorPreviewOwner(string ownerId)
		{
			if (CameraController.ActiveEditorPreviewOwner == ownerId)
			{
				return;
			}
			this.ReleaseActiveEditorPreview("新的Sequencer预览接管", false);
			CameraController.ActiveEditorPreviewOwner = ownerId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[LevelSequence分屏预览]激活预览Owner";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ownerId", ownerId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603E45D RID: 255069 RVA: 0x01218EF4 File Offset: 0x012170F4
		[return: Nullable(2)]
		private ACameraActor FailEditorPreviewMainCameraPreparation(string reason)
		{
			this.ReleaseActiveEditorPreview(reason, false);
			return null;
		}

		// Token: 0x0603E45E RID: 255070 RVA: 0x01218EFF File Offset: 0x012170FF
		[return: Nullable(2)]
		private ACameraActor FailEditorPreviewSeparateCameraPreparation(string ownerId, string cameraName, string reason, bool shouldRollbackActivePreview)
		{
			if (shouldRollbackActivePreview)
			{
				this.ReleaseActiveEditorPreview(reason, false);
			}
			else
			{
				this.ReleaseEditorPreviewCamera(ownerId, cameraName);
			}
			return null;
		}

		// Token: 0x0603E45F RID: 255071 RVA: 0x01218F18 File Offset: 0x01217118
		private unsafe void ReleaseActiveEditorPreview(string reason, bool deferCameraModelDestruction = false)
		{
			string activeEditorPreviewOwner = CameraController.ActiveEditorPreviewOwner;
			if (string.IsNullOrEmpty(activeEditorPreviewOwner))
			{
				return;
			}
			List<EditorPreviewOwnedCamera> list = new List<EditorPreviewOwnedCamera>();
			foreach (KeyValuePair<string, EditorPreviewCameraOwnership> keyValuePair in new List<KeyValuePair<string, EditorPreviewCameraOwnership>>(CameraController.EditorPreviewCameraOwnerships))
			{
				string text;
				EditorPreviewCameraOwnership editorPreviewCameraOwnership;
				keyValuePair.Deconstruct(out text, out editorPreviewCameraOwnership);
				string text2 = text;
				EditorPreviewCameraOwnership editorPreviewCameraOwnership2 = editorPreviewCameraOwnership;
				if (editorPreviewCameraOwnership2.OwnerId == activeEditorPreviewOwner)
				{
					list.Add(new EditorPreviewOwnedCamera(text2, editorPreviewCameraOwnership2.CameraModel));
					CameraController.EditorPreviewCameraOwnerships.Remove(text2);
				}
			}
			bool isEditorPreviewMainCameraActive = CameraController.IsEditorPreviewMainCameraActive;
			EditorPreviewMainCameraLayoutSnapshot mainCameraLayoutSnapshot = CameraController.MainCameraLayoutSnapshot;
			CameraController.IsEditorPreviewMainCameraActive = false;
			CameraController.MainCameraLayoutSnapshot = null;
			CameraController.RejectedEditorPreviewOwners.Clear();
			CameraController.ActiveEditorPreviewOwner = null;
			if (CameraModel.Instance != null)
			{
				if (isEditorPreviewMainCameraActive)
				{
					this.RestoreRealMainCameraLayout(mainCameraLayoutSnapshot);
				}
				if (deferCameraModelDestruction)
				{
					List<CameraModelInstance> detachedCameraModels = new List<CameraModelInstance>();
					foreach (EditorPreviewOwnedCamera editorPreviewOwnedCamera in list)
					{
						CameraModelInstance cameraModelInstance = editorPreviewOwnedCamera.CameraModel;
						if (CameraController.Instance.GetSeparateCameraModel(editorPreviewOwnedCamera.CameraName) == editorPreviewOwnedCamera.CameraModel)
						{
							cameraModelInstance = (CameraController.Instance.DetachSeparateCameraModel(editorPreviewOwnedCamera.CameraName) ?? editorPreviewOwnedCamera.CameraModel);
						}
						cameraModelInstance.SetViewInfo(Vector2D.Create(1.0, 0.0), Vector2D.Create(0.0, 1.0), false);
						detachedCameraModels.Add(cameraModelInstance);
					}
					if (detachedCameraModels.Count > 0)
					{
						TimerSystem.Instance.Next(delegate(float _)
						{
							foreach (CameraModelInstance cameraModel in detachedCameraModels)
							{
								CameraController.Instance.DestroyDetachedSeparateCameraModel(cameraModel);
							}
						}, null, null);
					}
				}
				else
				{
					foreach (EditorPreviewOwnedCamera editorPreviewOwnedCamera2 in list)
					{
						if (CameraController.Instance.GetSeparateCameraModel(editorPreviewOwnedCamera2.CameraName) == editorPreviewOwnedCamera2.CameraModel)
						{
							CameraController.Instance.DestroySeparateCameraModelImmediately(editorPreviewOwnedCamera2.CameraName);
						}
						else
						{
							CameraController.Instance.DestroyDetachedSeparateCameraModel(editorPreviewOwnedCamera2.CameraModel);
						}
					}
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[LevelSequence分屏预览]释放预览Owner";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ownerId", activeEditorPreviewOwner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603E460 RID: 255072 RVA: 0x012191D4 File Offset: 0x012173D4
		private void ReleaseEditorPreviewCamera(string ownerId, string cameraName)
		{
			EditorPreviewCameraOwnership editorPreviewCameraOwnership;
			CameraController.EditorPreviewCameraOwnerships.TryGetValue(cameraName, out editorPreviewCameraOwnership);
			if (((editorPreviewCameraOwnership != null) ? editorPreviewCameraOwnership.OwnerId : null) != ownerId)
			{
				return;
			}
			CameraController.EditorPreviewCameraOwnerships.Remove(cameraName);
			if (CameraModel.Instance == null)
			{
				return;
			}
			if (CameraController.Instance.GetSeparateCameraModel(cameraName) == editorPreviewCameraOwnership.CameraModel)
			{
				CameraController.Instance.DestroySeparateCameraModelImmediately(cameraName);
				return;
			}
			CameraController.Instance.DestroyDetachedSeparateCameraModel(editorPreviewCameraOwnership.CameraModel);
		}

		// Token: 0x0603E461 RID: 255073 RVA: 0x01219247 File Offset: 0x01217447
		private bool HasRuntimeLevelSequenceActor()
		{
			SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
			return ((sequenceCamera != null) ? sequenceCamera.GetLevelSequenceActor() : null) != null;
		}

		// Token: 0x0603E462 RID: 255074 RVA: 0x01219268 File Offset: 0x01217468
		[return: Nullable(2)]
		private unsafe BP_CineCamera_C ConfigureEditorPreviewSequenceCameraComponents(CameraModelInstance cameraModel, string cameraName, bool enableSequencePlayerLogic)
		{
			SequenceCamera sequenceCamera = cameraModel.SequenceCamera;
			BP_CineCamera_C bp_CineCamera_C;
			if (sequenceCamera == null)
			{
				bp_CineCamera_C = null;
			}
			else
			{
				SequenceCameraDisplayComponent displayComponent = sequenceCamera.DisplayComponent;
				bp_CineCamera_C = ((displayComponent != null) ? displayComponent.CineCamera : null);
			}
			BP_CineCamera_C bp_CineCamera_C2 = bp_CineCamera_C;
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent = (sequenceCamera != null) ? sequenceCamera.PlayerComponent : null;
			bool flag = bp_CineCamera_C2 != null && bp_CineCamera_C2.IsValid();
			bool flag2 = sequenceCameraPlayerComponent != null && sequenceCameraPlayerComponent.Valid;
			if (bp_CineCamera_C2 == null || sequenceCameraPlayerComponent == null || !flag || !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏预览]创建后Sequence相机组件无效，回滚分屏相机";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", cameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isCineCameraValid", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isPlayerComponentValid", flag2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			sequenceCameraPlayerComponent.SetSeparateSequencePlayerLogicEnabled(enableSequencePlayerLogic);
			return bp_CineCamera_C2;
		}

		// Token: 0x0603E463 RID: 255075 RVA: 0x01219348 File Offset: 0x01217548
		private unsafe bool EnterEditorPreviewSequenceCameraMode(CameraModelInstance cameraModel, string cameraName, BP_CineCamera_C cineCamera)
		{
			ECustomCameraMode? cameraMode = cameraModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Sequence;
			if ((cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) && cameraModel.CurrentCameraActor == cineCamera)
			{
				return true;
			}
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, delegate
			{
			}, false, cameraName, null);
			cameraMode = cameraModel.CameraMode;
			ecustomCameraMode = ECustomCameraMode.Sequence;
			if (!(cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) || cameraModel.CurrentCameraActor != cineCamera)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[LevelSequence分屏预览]切换SequenceMode失败，回滚分屏相机";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cameraName", cameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cameraMode", cameraModel.CameraMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isExpectedViewTarget", cameraModel.CurrentCameraActor == cineCamera);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return true;
		}

		// Token: 0x0603E464 RID: 255076 RVA: 0x01219464 File Offset: 0x01217664
		private bool IsValidEditorPreviewSeparateCameraName(string cameraName)
		{
			return cameraName.Length > 0 && cameraName != "None" && cameraName != "MainCamera" && cameraName != "__EditorPreviewMainCamera";
		}

		// Token: 0x0603E465 RID: 255077 RVA: 0x01219498 File Offset: 0x01217698
		private void ApplyEditorPreviewLayout(string cameraName, FKuroSeparateCameraData layout)
		{
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetViewInfo(Vector2D.Create((double)layout.Location.X, (double)layout.Location.Y), Vector2D.Create((double)layout.Size.X, (double)layout.Size.Y), layout.bEnableScissorOffset);
		}

		// Token: 0x0603E466 RID: 255078 RVA: 0x012194FC File Offset: 0x012176FC
		private void ResetCameraLayout(string cameraName)
		{
			if (CameraModel.Instance == null)
			{
				return;
			}
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetViewInfo(Vector2D.Create(0.0, 0.0), Vector2D.Create(1.0, 1.0), false);
		}

		// Token: 0x0603E467 RID: 255079 RVA: 0x01219558 File Offset: 0x01217758
		private bool HideRealMainCameraLayout()
		{
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel("MainCamera");
			SeparateCameraLayout separateCameraLayout = (separateCameraModel != null) ? separateCameraModel.SeparateCameraLayout : null;
			if (separateCameraModel == null || separateCameraLayout == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.ZJL, "[LevelSequence分屏预览]隐藏真实主屏前无法读取布局", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (separateCameraLayout.CurrentBlendState != ESeparateBlendState.Stay)
			{
				Log.Instance.Warn(ELogModule.Camera, ELogAuthor.ZJL, "[LevelSequence分屏预览]真实主屏布局过渡期间拒绝启动预览", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!CameraController.IsEditorPreviewMainCameraActive)
			{
				CameraController.MainCameraLayoutSnapshot = new EditorPreviewMainCameraLayoutSnapshot(Vector2D.Create(separateCameraLayout.CurrentViewLocation.X, separateCameraLayout.CurrentViewLocation.Y), Vector2D.Create(separateCameraLayout.CurrentViewSize.X, separateCameraLayout.CurrentViewSize.Y), separateCameraLayout.EnableScissorOffset);
			}
			separateCameraModel.SetViewInfo(Vector2D.Create(1.0, 0.0), Vector2D.Create(0.0, 1.0), false);
			return true;
		}

		// Token: 0x0603E468 RID: 255080 RVA: 0x0121964F File Offset: 0x0121784F
		[NullableContext(2)]
		private void RestoreRealMainCameraLayout(EditorPreviewMainCameraLayoutSnapshot layoutSnapshot)
		{
			if (layoutSnapshot == null)
			{
				this.ResetCameraLayout("MainCamera");
				return;
			}
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel("MainCamera");
			if (separateCameraModel == null)
			{
				return;
			}
			separateCameraModel.SetViewInfo(layoutSnapshot.ViewLocation, layoutSnapshot.ViewSize, layoutSnapshot.EnableScissorOffset);
		}

		// Token: 0x1700766D RID: 30317
		// (get) Token: 0x0603E469 RID: 255081 RVA: 0x0121968B File Offset: 0x0121788B
		public static CameraController Instance
		{
			get
			{
				return CameraController._Instance;
			}
		}

		// Token: 0x0603E46A RID: 255082 RVA: 0x01219692 File Offset: 0x01217892
		public static CameraController GetOrCreateInstance()
		{
			if (CameraController._Instance == null)
			{
				CameraController.CreateInstance();
			}
			return CameraController._Instance;
		}

		// Token: 0x0603E46B RID: 255083 RVA: 0x012196A6 File Offset: 0x012178A6
		public static bool CreateInstance()
		{
			if (CameraController._Instance != null)
			{
				return true;
			}
			CameraController._Instance = new CameraController();
			return true;
		}

		// Token: 0x0603E46C RID: 255084 RVA: 0x012196BC File Offset: 0x012178BC
		public static void CreateStaticDefaultValue()
		{
			CameraController.OnCreateStaticDefaultValue();
		}

		// Token: 0x0603E46D RID: 255085 RVA: 0x012196C3 File Offset: 0x012178C3
		public static void ResetStaticDefaultValue()
		{
			CameraController._Instance = null;
			CameraController.OnResetStaticDefaultValue();
		}

		// Token: 0x0603E46E RID: 255086 RVA: 0x012196D0 File Offset: 0x012178D0
		private static void OnCreateStaticDefaultValue()
		{
			CameraController.ActiveEditorPreviewOwner = null;
			CameraController._editorPreviewCameraOwnerships = new Dictionary<string, EditorPreviewCameraOwnership>();
			CameraController._rejectedEditorPreviewOwners = new HashSet<string>();
			CameraController.IsEditorPreviewMainCameraActive = false;
			CameraController.MainCameraLayoutSnapshot = null;
		}

		// Token: 0x0603E46F RID: 255087 RVA: 0x012196F8 File Offset: 0x012178F8
		private static void OnResetStaticDefaultValue()
		{
			CameraController.ActiveEditorPreviewOwner = null;
			CameraController._editorPreviewCameraOwnerships = null;
			CameraController._rejectedEditorPreviewOwners = null;
			CameraController.IsEditorPreviewMainCameraActive = false;
			CameraController.MainCameraLayoutSnapshot = null;
		}

		// Token: 0x0603E470 RID: 255088 RVA: 0x01219718 File Offset: 0x01217918
		static CameraController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraController.CreateStaticDefaultValue), new Action(CameraController.ResetStaticDefaultValue));
		}

		// Token: 0x0402126E RID: 135790
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x0402126F RID: 135791
		private const double CONSTRAIN_ASPECT_RATIO = 1.76;

		// Token: 0x04021270 RID: 135792
		private static readonly int ConstrainAspectRatioGameplayTag = GameplayTagDefine.EGameplayTagId["关卡.副本.跑酷副本.调节长宽比专用"];

		// Token: 0x04021271 RID: 135793
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

		// Token: 0x04021272 RID: 135794
		[StaticVariableRuleIgnore]
		public static readonly FViewTargetTransitionParams ViewTargetTransitionParams = new FViewTargetTransitionParams();

		// Token: 0x04021273 RID: 135795
		private const bool CameraModeDebug = true;

		// Token: 0x04021274 RID: 135796
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D1 = Vector2D.Create();

		// Token: 0x04021275 RID: 135797
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D2 = Vector2D.Create();

		// Token: 0x04021276 RID: 135798
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D3 = Vector2D.Create();

		// Token: 0x04021277 RID: 135799
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D4 = Vector2D.Create();

		// Token: 0x04021278 RID: 135800
		private readonly Dictionary<string, int> CachedFrameGenCvarValues = new Dictionary<string, int>();

		// Token: 0x04021279 RID: 135801
		private bool CameraModeMutex;

		// Token: 0x0402127A RID: 135802
		private List<CameraController.PendingCameraModeRequest> PendingCameraModeRequests = new List<CameraController.PendingCameraModeRequest>();

		// Token: 0x0402127B RID: 135803
		private const int CAMERA_MODE_MAX_PENDING_COUNT = 5;

		// Token: 0x0402127C RID: 135804
		private bool IsDrainingCameraModeRequests;

		// Token: 0x0402127D RID: 135805
		private const string EDITOR_PREVIEW_MAIN_CAMERA = "__EditorPreviewMainCamera";

		// Token: 0x0402127E RID: 135806
		[Nullable(2)]
		private static string ActiveEditorPreviewOwner;

		// Token: 0x0402127F RID: 135807
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, EditorPreviewCameraOwnership> _editorPreviewCameraOwnerships;

		// Token: 0x04021280 RID: 135808
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<string> _rejectedEditorPreviewOwners;

		// Token: 0x04021281 RID: 135809
		private static bool IsEditorPreviewMainCameraActive;

		// Token: 0x04021282 RID: 135810
		[Nullable(2)]
		private static EditorPreviewMainCameraLayoutSnapshot MainCameraLayoutSnapshot;

		// Token: 0x04021283 RID: 135811
		[Nullable(2)]
		private static CameraController _Instance;

		// Token: 0x0200BB99 RID: 48025
		[NullableContext(2)]
		[Nullable(0)]
		private class PendingCameraModeRequest
		{
			// Token: 0x04039BD7 RID: 236503
			public bool IsEnter;

			// Token: 0x04039BD8 RID: 236504
			public ECustomCameraMode Mode;

			// Token: 0x04039BD9 RID: 236505
			public float BlendTime;

			// Token: 0x04039BDA RID: 236506
			public EViewTargetBlendFunction BlendFunction;

			// Token: 0x04039BDB RID: 236507
			public float BlendExp;

			// Token: 0x04039BDC RID: 236508
			public Action Callback;

			// Token: 0x04039BDD RID: 236509
			public bool BMustCallback;

			// Token: 0x04039BDE RID: 236510
			[Nullable(1)]
			public string CameraName = "MainCamera";

			// Token: 0x04039BDF RID: 236511
			public UCurveFloat BlendCurve;
		}
	}
}
