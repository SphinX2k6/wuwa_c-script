using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072FF RID: 29439
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Logic)]
	public class PhotoCameraLogicComponent : PhotoCameraComponentBase
	{
		// Token: 0x060483F2 RID: 295922 RVA: 0x0128FE5A File Offset: 0x0128E05A
		protected override void OnActivate()
		{
			this.RefreshGravityQuat();
		}

		// Token: 0x060483F3 RID: 295923 RVA: 0x0128FE62 File Offset: 0x0128E062
		[NullableContext(2)]
		protected override void OnCharacterChanged(TsBaseCharacter character)
		{
			this.RefreshGravityQuat();
		}

		// Token: 0x060483F4 RID: 295924 RVA: 0x0128FE6C File Offset: 0x0128E06C
		protected override void OnModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
			this.RefreshGravityQuat();
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			this.InitFromConfig(currentConfig, true);
			this.ApplyToWorld();
		}

		// Token: 0x060483F5 RID: 295925 RVA: 0x0128FE9D File Offset: 0x0128E09D
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			this.ApplyAspectCompensate();
		}

		// Token: 0x060483F6 RID: 295926 RVA: 0x0128FEA8 File Offset: 0x0128E0A8
		private void RefreshGravityQuat()
		{
			GravityUtils instance = GravityUtils.Instance;
			IPhotoCameraHost host = this.Host;
			BaseActorComponent actorComp;
			if (host == null)
			{
				actorComp = null;
			}
			else
			{
				TsBaseCharacter character = host.Character;
				actorComp = ((character != null) ? character.CharacterActorComponent : null);
			}
			instance.GetBaseQuatInGravityForActor(actorComp, this.GravityQuat);
			this.GravityQuat.Inverse(this.GravityInverseQuat);
		}

		// Token: 0x060483F7 RID: 295927 RVA: 0x0128FEF4 File Offset: 0x0128E0F4
		protected override void OnTick(float deltaTime)
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			PhotoCameraInputComponent component = this.Host.GetComponent<PhotoCameraInputComponent>(EPhotoCameraComponent.Input);
			IPhotoInputSnapshot photoInputSnapshot = (component != null) ? component.GetSnapshot() : null;
			if (photoInputSnapshot == null)
			{
				return;
			}
			SPhotoCameraCommonConfig commonConfig = currentConfig.CommonConfig;
			if (currentConfig.IsOpenDebugChangeConfigPreview)
			{
				Vector pivotToCameraOffset = this.Host.VirtualCamera.PivotToCameraOffset;
				FVector initPosition = commonConfig.InitPosition;
				pivotToCameraOffset.FromUeVector(initPosition);
			}
			this.AccumulateOffset(currentConfig, photoInputSnapshot, deltaTime);
			this.AccumulateRotation(currentConfig, photoInputSnapshot, deltaTime);
			this.AccumulateFov(commonConfig, photoInputSnapshot, deltaTime);
			this.UpdatePivot(commonConfig);
			this.ApplyToWorld();
			this.ApplyAspectCompensate();
		}

		// Token: 0x060483F8 RID: 295928 RVA: 0x0128FF8C File Offset: 0x0128E18C
		private void InitFromConfig(BP_PhotoCameraConfig_C config, bool useInheritedPose)
		{
			SPhotoCameraCommonConfig commonConfig = config.CommonConfig;
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.MoveOffset.Set(0.0, 0.0, 0.0);
			virtualCamera.Fov = commonConfig.InitFov;
			this.SetRollValueInternal(commonConfig.InitRotation.Z);
			bool flag = useInheritedPose && commonConfig.IsInheritPrevModeCamera;
			if (flag)
			{
				this.CalcInheritedEntryPose(commonConfig);
			}
			PhotoCameraEntryPose photoCameraEntryPose = flag ? this.Host.InheritedEntryPose : null;
			if (photoCameraEntryPose != null)
			{
				virtualCamera.PivotToCameraOffset.Set((double)(-(double)photoCameraEntryPose.ArmLength), 0.0, 0.0);
				this.PitchValue = photoCameraEntryPose.Pitch;
				this.YawValue = photoCameraEntryPose.Yaw;
			}
			else
			{
				Vector pivotToCameraOffset = virtualCamera.PivotToCameraOffset;
				FVector initPosition = commonConfig.InitPosition;
				pivotToCameraOffset.FromUeVector(initPosition);
				this.PitchValue = commonConfig.InitRotation.X;
				this.YawValue = commonConfig.InitRotation.Y;
			}
			this.ApplyPendingLens(config);
			this.UpdatePivot(commonConfig);
		}

		// Token: 0x060483F9 RID: 295929 RVA: 0x0129009C File Offset: 0x0128E29C
		private void CalcInheritedEntryPose(SPhotoCameraCommonConfig common)
		{
			if (this.Host.InheritedEntryPose != null)
			{
				return;
			}
			Vector pendingInheritWorldLocation = this.Host.PendingInheritWorldLocation;
			if (pendingInheritWorldLocation == null)
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			this.PitchValue = 0f;
			this.YawValue = 0f;
			this.UpdatePivot(common);
			virtualCamera.Pivot.Subtraction(pendingInheritWorldLocation, this.InheritDir);
			float num = (float)this.InheritDir.Size();
			if (MathUtils.Instance.IsNearlyZero((double)num, null))
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照继承位姿:偏移后与轴心重合,退回DA初值", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.InheritDir.Rotation(this.InheritDirRotator);
			GravityUtils.Instance.GetRotatorInGravity(this.InheritDirRotator, this.GravityInverseQuat, this.InheritDirInGravity);
			GravityUtils.Instance.GetRotatorInGravity(virtualCamera.PivotRotation, this.GravityInverseQuat, this.InheritBaseInGravity);
			float currentValue = Rotator.NormalizeAxis(this.InheritDirInGravity.Pitch - this.InheritBaseInGravity.Pitch);
			float num2 = Rotator.NormalizeAxis(this.InheritDirInGravity.Yaw - this.InheritBaseInGravity.Yaw);
			float pitch = MathUtils.Instance.Clamp(currentValue, common.PitchRange.X, common.PitchRange.Y);
			float yaw = MathUtils.Instance.IsNearlyEqual((double)(common.YawRange.Y - common.YawRange.X), 360.0, null) ? num2 : MathUtils.Instance.Clamp(num2, common.YawRange.X, common.YawRange.Y);
			this.Host.SetInheritedEntryPose(new PhotoCameraEntryPose
			{
				ArmLength = num,
				Pitch = pitch,
				Yaw = yaw
			});
		}

		// Token: 0x060483FA RID: 295930 RVA: 0x0129027C File Offset: 0x0128E47C
		private void ApplyPendingLens(BP_PhotoCameraConfig_C config)
		{
			PhotoCameraLensState pendingLens = this.Host.PendingLens;
			if (pendingLens == null)
			{
				return;
			}
			SPhotoCameraCommonConfig commonConfig = config.CommonConfig;
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.Fov = MathUtils.Instance.Clamp(pendingLens.Fov, commonConfig.FovRange.X, commonConfig.FovRange.Y);
			this.PitchValue = MathUtils.Instance.Clamp(pendingLens.Pitch, commonConfig.PitchRange.X, commonConfig.PitchRange.Y);
			this.YawValue = (MathUtils.Instance.IsNearlyEqual((double)(commonConfig.YawRange.Y - commonConfig.YawRange.X), 360.0, null) ? pendingLens.Yaw : MathUtils.Instance.Clamp(pendingLens.Yaw, commonConfig.YawRange.X, commonConfig.YawRange.Y));
			this.SetRollValueInternal(MathUtils.Instance.Clamp(pendingLens.Roll, commonConfig.RollRange.X, commonConfig.RollRange.Y));
			if (config.Type != PhotoCameraType.Normal && config.Type != PhotoCameraType.Drone)
			{
				return;
			}
			SPhotoCameraMoveConfig moveConfig = config.MoveConfig;
			virtualCamera.MoveOffset.Set((double)MathUtils.Instance.Clamp(pendingLens.MoveOffsetX, moveConfig.ForwardAndBackDistanceRange.X, moveConfig.ForwardAndBackDistanceRange.Y), (double)MathUtils.Instance.Clamp(pendingLens.MoveOffsetY, moveConfig.LeftAndRightDistanceRange.X, moveConfig.LeftAndRightDistanceRange.Y), (double)MathUtils.Instance.Clamp(pendingLens.MoveOffsetZ, moveConfig.UpAndDownDistanceRange.X, moveConfig.UpAndDownDistanceRange.Y));
		}

		// Token: 0x060483FB RID: 295931 RVA: 0x0129044C File Offset: 0x0128E64C
		public PhotoCameraLensState GetLensState()
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			return new PhotoCameraLensState
			{
				Fov = virtualCamera.Fov,
				MoveOffsetX = (float)virtualCamera.MoveOffset.X,
				MoveOffsetY = (float)virtualCamera.MoveOffset.Y,
				MoveOffsetZ = (float)virtualCamera.MoveOffset.Z,
				Pitch = this.PitchValue,
				Yaw = this.YawValue,
				Roll = this.RollValue
			};
		}

		// Token: 0x060483FC RID: 295932 RVA: 0x012904D0 File Offset: 0x0128E6D0
		public void RefreshFromCurrentConfig()
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			this.InitFromConfig(currentConfig, true);
			this.ApplyToWorld();
		}

		// Token: 0x060483FD RID: 295933 RVA: 0x012904FC File Offset: 0x0128E6FC
		public void RefreshFromTemplate()
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			this.InitFromConfig(currentConfig, false);
			this.ApplyToWorld();
		}

		// Token: 0x060483FE RID: 295934 RVA: 0x01290528 File Offset: 0x0128E728
		private void SetRollValueInternal(float value)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.RollValue, (double)value, null))
			{
				return;
			}
			this.RollValue = value;
			this.Host.NotifyTiltRollChanged(value);
		}

		// Token: 0x060483FF RID: 295935 RVA: 0x01290568 File Offset: 0x0128E768
		public void SetTiltRoll(float roll)
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			SPhotoCameraCommonConfig commonConfig = currentConfig.CommonConfig;
			this.SetRollValueInternal(MathUtils.Instance.Clamp(roll, commonConfig.RollRange.X, commonConfig.RollRange.Y));
		}

		// Token: 0x06048400 RID: 295936 RVA: 0x012905B4 File Offset: 0x0128E7B4
		public void ResetTiltRoll()
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			this.SetRollValueInternal(currentConfig.CommonConfig.InitRotation.Z);
		}

		// Token: 0x06048401 RID: 295937 RVA: 0x012905E8 File Offset: 0x0128E7E8
		private void AccumulateOffset(BP_PhotoCameraConfig_C config, IPhotoInputSnapshot snapshot, float deltaTime)
		{
			if (config.Type != PhotoCameraType.Normal && config.Type != PhotoCameraType.Drone)
			{
				return;
			}
			SPhotoCameraMoveConfig moveConfig = config.MoveConfig;
			Vector moveOffset = this.Host.VirtualCamera.MoveOffset;
			moveOffset.X = MathUtils.Instance.Clamp(moveOffset.X + (double)(snapshot.MoveForward * moveConfig.ForwardAndBackSpeed * deltaTime), (double)moveConfig.ForwardAndBackDistanceRange.X, (double)moveConfig.ForwardAndBackDistanceRange.Y);
			moveOffset.Y = MathUtils.Instance.Clamp(moveOffset.Y + (double)(snapshot.MoveRight * moveConfig.LeftAndRightSpeed * deltaTime), (double)moveConfig.LeftAndRightDistanceRange.X, (double)moveConfig.LeftAndRightDistanceRange.Y);
			moveOffset.Z = MathUtils.Instance.Clamp(moveOffset.Z + (double)(snapshot.MoveUp * moveConfig.UpAndDownSpeed * deltaTime), (double)moveConfig.UpAndDownDistanceRange.X, (double)moveConfig.UpAndDownDistanceRange.Y);
		}

		// Token: 0x06048402 RID: 295938 RVA: 0x012906F4 File Offset: 0x0128E8F4
		private void AccumulateRotation(BP_PhotoCameraConfig_C config, IPhotoInputSnapshot snapshot, float deltaTime)
		{
			SPhotoCameraCommonConfig commonConfig = config.CommonConfig;
			this.PitchValue = MathUtils.Instance.Clamp(this.PitchValue + snapshot.Pitch * commonConfig.PitchRotateSpeed * deltaTime, commonConfig.PitchRange.X, commonConfig.PitchRange.Y);
			float num = this.YawValue + snapshot.Yaw * commonConfig.YawRotateSpeed * deltaTime;
			float num2 = num;
			if (!MathUtils.Instance.IsNearlyEqual((double)(commonConfig.YawRange.Y - commonConfig.YawRange.X), 360.0, null))
			{
				num2 = MathUtils.Instance.Clamp(num, commonConfig.YawRange.X, commonConfig.YawRange.Y);
			}
			this.YawValue = num2;
			if (config.Type == PhotoCameraType.FirstPerson || config.Type == PhotoCameraType.Selfie)
			{
				this.RotateCharacterByYawOverflow(num - num2);
			}
			this.SetRollValueInternal(MathUtils.Instance.Clamp(this.RollValue + snapshot.Roll * commonConfig.RollRotateSpeed * deltaTime, commonConfig.RollRange.X, commonConfig.RollRange.Y));
		}

		// Token: 0x06048403 RID: 295939 RVA: 0x01290828 File Offset: 0x0128EA28
		private void RotateCharacterByYawOverflow(float overflowDegree)
		{
			if (MathUtils.Instance.IsNearlyZero((double)overflowDegree, null))
			{
				return;
			}
			TsBaseCharacter character = this.Host.Character;
			CharacterActorComponent characterActorComponent = (character != null) ? character.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				return;
			}
			this.TmpVector.DeepCopy(characterActorComponent.ActorUpProxy);
			Quat.ConstructorByAxisAngle(this.TmpVector, overflowDegree * 0.017453292f, this.TmpQuat);
			this.TmpQuat.Multiply(characterActorComponent.ActorQuatProxy, this.TmpQuat2);
			this.TmpQuat2.Rotator(this.TmpRotator);
			characterActorComponent.SetActorRotation(this.TmpRotator.ToUeRotator(), "PhotoCamera.SelfieYawOverflow", false);
		}

		// Token: 0x06048404 RID: 295940 RVA: 0x012908D4 File Offset: 0x0128EAD4
		private void AccumulateFov(SPhotoCameraCommonConfig common, IPhotoInputSnapshot snapshot, float deltaTime)
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.Fov = MathUtils.Instance.Clamp(virtualCamera.Fov + snapshot.Fov * common.ZoomSpeed * deltaTime, common.FovRange.X, common.FovRange.Y);
		}

		// Token: 0x06048405 RID: 295941 RVA: 0x0129092C File Offset: 0x0128EB2C
		private void UpdatePivot(SPhotoCameraCommonConfig common)
		{
			TsBaseCharacter character = this.Host.Character;
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			if (character != null && character.IsValid())
			{
				FName inSocketName = FNameUtil.GetDynamicFName(common.CenterLocationSocketName) ?? CharacterNameDefines.Instance.ROOT;
				USkeletalMeshComponent mesh = character.Mesh;
				if (mesh != null && mesh.IsValid())
				{
					Vector pivot = virtualCamera.Pivot;
					FVectorDouble fvectorDouble = character.Mesh.D_GetSocketLocation(inSocketName);
					pivot.FromUeVector(fvectorDouble);
				}
				else
				{
					Vector pivot2 = virtualCamera.Pivot;
					FVectorDouble fvectorDouble = character.D_K2_GetActorLocation();
					pivot2.FromUeVector(fvectorDouble);
				}
				Rotator pivotRotation = virtualCamera.PivotRotation;
				FRotator frotator = character.K2_GetActorRotation();
				pivotRotation.FromUeRotator(frotator);
			}
			Vector tmpVector = this.TmpVector;
			FVector initCenterOffset = common.InitCenterOffset;
			tmpVector.FromUeVector(initCenterOffset);
			virtualCamera.PivotRotation.Quaternion(this.TmpQuat);
			this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector2);
			virtualCamera.Pivot.AdditionEqual(this.TmpVector2);
			this.ApplyRotationOffsetInGravity(virtualCamera.PivotRotation);
			virtualCamera.PivotRotation.Quaternion(this.TmpQuat);
			this.TmpQuat.RotateVector(virtualCamera.MoveOffset, this.TmpVector2);
			virtualCamera.CameraCenter.DeepCopy(virtualCamera.Pivot);
			virtualCamera.CameraCenter.AdditionEqual(this.TmpVector2);
		}

		// Token: 0x06048406 RID: 295942 RVA: 0x01290A90 File Offset: 0x0128EC90
		private void ApplyRotationOffsetInGravity(Rotator inOutRotation)
		{
			GravityUtils.Instance.GetRotatorInGravity(inOutRotation, this.GravityInverseQuat, this.TmpRotatorInGravity);
			this.TmpRotatorInGravity.Pitch += this.PitchValue;
			this.TmpRotatorInGravity.Yaw += this.YawValue;
			this.TmpRotatorInGravity.Roll += this.RollValue;
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotatorInGravity, this.GravityQuat, inOutRotation);
		}

		// Token: 0x06048407 RID: 295943 RVA: 0x01290B18 File Offset: 0x0128ED18
		private void ApplyToWorld()
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.PivotRotation.Quaternion(this.TmpQuat);
			this.TmpQuat.RotateVector(virtualCamera.PivotToCameraOffset, virtualCamera.DesiredWorldLocation);
			virtualCamera.DesiredWorldLocation.AdditionEqual(virtualCamera.CameraCenter);
			virtualCamera.DesiredWorldRotation.DeepCopy(virtualCamera.PivotRotation);
		}

		// Token: 0x06048408 RID: 295944 RVA: 0x01290B80 File Offset: 0x0128ED80
		private unsafe void ApplyAspectCompensate()
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			SPhotoCameraCompositionConfig compositionConfig = currentConfig.CompositionConfig;
			if (compositionConfig == null || !compositionConfig.Enable || compositionConfig.BaseAspectRatio <= 0f)
			{
				return;
			}
			float viewportAspectRatio = this.GetViewportAspectRatio();
			if (viewportAspectRatio <= 0f)
			{
				return;
			}
			if (MathUtils.Instance.IsNearlyEqual((double)viewportAspectRatio, (double)compositionConfig.BaseAspectRatio, new double?(0.0001)))
			{
				if (this.Host.IsDebugEnable)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhotoCamera;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "拍照构图补偿:未生效(等于基准宽高比)";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("aspect", viewportAspectRatio.ToString("F4"));
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			if (virtualCamera.Fov <= 0f)
			{
				return;
			}
			Vector anchorLocalOffset = this.AnchorLocalOffset;
			FVectorDouble anchorOffset = compositionConfig.AnchorOffset;
			anchorLocalOffset.FromUeVector(anchorOffset);
			virtualCamera.DesiredWorldRotation.Quaternion(this.CameraQuat);
			this.CameraQuat.RotateVector(this.AnchorLocalOffset, this.PivotToAnchorOffset);
			virtualCamera.Pivot.Addition(this.PivotToAnchorOffset, this.AnchorWorldLocation);
			this.AnchorWorldLocation.Subtraction(virtualCamera.DesiredWorldLocation, this.CameraToAnchor);
			this.CameraQuat.UnRotateVector(this.CameraToAnchor, this.AnchorInCameraSpace);
			if (this.AnchorInCameraSpace.X < (double)compositionConfig.MinAnchorDistance)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PhotoCamera;
				ELogAuthor author2 = ELogAuthor.CXJ;
				string message2 = "拍照构图补偿:锚点距离过近或在相机身后，已跳过";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("anchorDistance", this.AnchorInCameraSpace.X.ToString("F2"));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("minAnchorDistance", compositionConfig.MinAnchorDistance.ToString("F2"));
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			double num = this.AnchorInCameraSpace.Y / this.AnchorInCameraSpace.X;
			double num2 = Math.Tan(MathUtils.Instance.VerticalFovToHorizontally((double)virtualCamera.Fov, (double)compositionConfig.BaseAspectRatio) / 2.0 * 0.01745329238474369);
			double num3 = Math.Tan(MathUtils.Instance.VerticalFovToHorizontally((double)virtualCamera.Fov, (double)viewportAspectRatio) / 2.0 * 0.01745329238474369);
			if (MathUtils.Instance.IsNearlyZero(num2, null) || MathUtils.Instance.IsNearlyZero(num3, null))
			{
				return;
			}
			double num4 = num / num2;
			double num5 = Math.Atan(num4 * num3);
			float num6 = (float)((Math.Atan(num) - num5) * 57.295780181884766);
			num6 = MathUtils.Instance.Clamp(num6, -compositionConfig.MaxCompensateDegree, compositionConfig.MaxCompensateDegree);
			this.CameraQuat.RotateVector(Vector.UpVectorProxy, this.CameraUp);
			this.RotateAround(this.CameraUp, num6, virtualCamera.DesiredWorldRotation);
			if (this.Host.IsDebugEnable)
			{
				this.LogCompensateResult(virtualCamera, viewportAspectRatio, num, num3, num6, num4);
			}
		}

		// Token: 0x06048409 RID: 295945 RVA: 0x01290EA4 File Offset: 0x0128F0A4
		private unsafe void LogCompensateResult(VirtualPhotoCamera virtualCamera, float aspectRatio, double tanAnchorYaw, double tanHalfHFovCurrent, float compensateYawDeg, double screenXRatio)
		{
			virtualCamera.DesiredWorldRotation.Quaternion(this.VerifyQuat);
			this.AnchorWorldLocation.Subtraction(virtualCamera.DesiredWorldLocation, this.CameraToAnchor);
			this.VerifyQuat.UnRotateVector(this.CameraToAnchor, this.AnchorInCameraSpace);
			double num = (this.AnchorInCameraSpace.X > 0.0) ? (this.AnchorInCameraSpace.Y / this.AnchorInCameraSpace.X / tanHalfHFovCurrent) : 0.0;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "拍照构图补偿";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("aspect", aspectRatio.ToString("F4"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("anchorYaw", (Math.Atan(tanAnchorYaw) * 57.295780181884766).ToString("F2"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("compensateYaw", compensateYawDeg.ToString("F2"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("screenXRatio", screenXRatio.ToString("F4"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("screenXRatioAfter", num.ToString("F4"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x0604840A RID: 295946 RVA: 0x01291014 File Offset: 0x0128F214
		private void RotateAround(Vector axis, float degree, Rotator outRotation)
		{
			Quat.ConstructorByAxisAngle(axis, degree * 0.017453292f, this.CompensateQuat);
			this.CompensateQuat.Multiply(this.CameraQuat, this.CompensateTempQuat);
			this.CompensateTempQuat.Rotator(outRotation);
		}

		// Token: 0x0604840B RID: 295947 RVA: 0x01291050 File Offset: 0x0128F250
		private float GetViewportAspectRatio()
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return 0f;
			}
			int num = 0;
			int num2 = 0;
			characterController.GetViewportSize(ref num, ref num2);
			if (num <= 0 || num2 <= 0)
			{
				return 0f;
			}
			return (float)num / (float)num2;
		}

		// Token: 0x040262B0 RID: 156336
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262B1 RID: 156337
		private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262B2 RID: 156338
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x040262B3 RID: 156339
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x040262B4 RID: 156340
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x040262B5 RID: 156341
		private readonly Quat GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262B6 RID: 156342
		private readonly Quat GravityInverseQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262B7 RID: 156343
		private readonly Rotator TmpRotatorInGravity = Rotator.Create();

		// Token: 0x040262B8 RID: 156344
		private readonly Quat CameraQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262B9 RID: 156345
		private readonly Quat CompensateQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262BA RID: 156346
		private readonly Quat CompensateTempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262BB RID: 156347
		private readonly Quat VerifyQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262BC RID: 156348
		private readonly Vector AnchorWorldLocation = Vector.Create();

		// Token: 0x040262BD RID: 156349
		private readonly Vector AnchorLocalOffset = Vector.Create();

		// Token: 0x040262BE RID: 156350
		private readonly Vector PivotToAnchorOffset = Vector.Create();

		// Token: 0x040262BF RID: 156351
		private readonly Vector CameraToAnchor = Vector.Create();

		// Token: 0x040262C0 RID: 156352
		private readonly Vector AnchorInCameraSpace = Vector.Create();

		// Token: 0x040262C1 RID: 156353
		private readonly Vector CameraUp = Vector.Create();

		// Token: 0x040262C2 RID: 156354
		private readonly Vector InheritDir = Vector.Create();

		// Token: 0x040262C3 RID: 156355
		private readonly Rotator InheritDirRotator = Rotator.Create();

		// Token: 0x040262C4 RID: 156356
		private readonly Rotator InheritDirInGravity = Rotator.Create();

		// Token: 0x040262C5 RID: 156357
		private readonly Rotator InheritBaseInGravity = Rotator.Create();

		// Token: 0x040262C6 RID: 156358
		private const double ASPECT_RATIO_TOLERANCE = 0.0001;

		// Token: 0x040262C7 RID: 156359
		private float PitchValue;

		// Token: 0x040262C8 RID: 156360
		private float YawValue;

		// Token: 0x040262C9 RID: 156361
		private float RollValue;
	}
}
