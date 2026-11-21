using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003990 RID: 14736
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraLogicComponent : UiCameraComponent
	{
		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x06025EF7 RID: 155383 RVA: 0x00AA6625 File Offset: 0x00AA4825
		// (set) Token: 0x06025EF8 RID: 155384 RVA: 0x00AA662D File Offset: 0x00AA482D
		public FVectorDouble SourceLocation { get; private set; }

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x06025EF9 RID: 155385 RVA: 0x00AA6636 File Offset: 0x00AA4836
		// (set) Token: 0x06025EFA RID: 155386 RVA: 0x00AA663E File Offset: 0x00AA483E
		public FVectorDouble DesiredLocation { get; private set; }

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x06025EFB RID: 155387 RVA: 0x00AA6647 File Offset: 0x00AA4847
		// (set) Token: 0x06025EFC RID: 155388 RVA: 0x00AA664F File Offset: 0x00AA484F
		public FRotator DesiredRotation { get; private set; }

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x06025EFD RID: 155389 RVA: 0x00AA6658 File Offset: 0x00AA4858
		// (set) Token: 0x06025EFE RID: 155390 RVA: 0x00AA6660 File Offset: 0x00AA4860
		public float DesiredArmLength { get; private set; }

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x06025EFF RID: 155391 RVA: 0x00AA6669 File Offset: 0x00AA4869
		// (set) Token: 0x06025F00 RID: 155392 RVA: 0x00AA6671 File Offset: 0x00AA4871
		public FVectorDouble DesiredArmOffsetLocation { get; private set; }

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x06025F01 RID: 155393 RVA: 0x00AA667A File Offset: 0x00AA487A
		// (set) Token: 0x06025F02 RID: 155394 RVA: 0x00AA6682 File Offset: 0x00AA4882
		public FRotator DesiredArmOffsetRotation { get; private set; }

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06025F03 RID: 155395 RVA: 0x00AA668B File Offset: 0x00AA488B
		// (set) Token: 0x06025F04 RID: 155396 RVA: 0x00AA6693 File Offset: 0x00AA4893
		public bool DesiredArmCollisionTest { get; private set; }

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x06025F05 RID: 155397 RVA: 0x00AA669C File Offset: 0x00AA489C
		// (set) Token: 0x06025F06 RID: 155398 RVA: 0x00AA66A4 File Offset: 0x00AA48A4
		public float DesiredFieldOfView { get; private set; }

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x06025F07 RID: 155399 RVA: 0x00AA66AD File Offset: 0x00AA48AD
		// (set) Token: 0x06025F08 RID: 155400 RVA: 0x00AA66B5 File Offset: 0x00AA48B5
		public float DesiredFocalDistance { get; private set; }

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x06025F09 RID: 155401 RVA: 0x00AA66BE File Offset: 0x00AA48BE
		// (set) Token: 0x06025F0A RID: 155402 RVA: 0x00AA66C6 File Offset: 0x00AA48C6
		public float DesiredAperture { get; private set; }

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x06025F0B RID: 155403 RVA: 0x00AA66CF File Offset: 0x00AA48CF
		// (set) Token: 0x06025F0C RID: 155404 RVA: 0x00AA66D7 File Offset: 0x00AA48D7
		public float DesiredFocalRegion { get; private set; }

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x06025F0D RID: 155405 RVA: 0x00AA66E0 File Offset: 0x00AA48E0
		// (set) Token: 0x06025F0E RID: 155406 RVA: 0x00AA66E8 File Offset: 0x00AA48E8
		public float DesiredPostProcessBlendWeight { get; private set; }

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x06025F0F RID: 155407 RVA: 0x00AA66F1 File Offset: 0x00AA48F1
		// (set) Token: 0x06025F10 RID: 155408 RVA: 0x00AA66F9 File Offset: 0x00AA48F9
		public bool NeedFloorReflection { get; private set; }

		// Token: 0x06025F11 RID: 155409 RVA: 0x00AA6704 File Offset: 0x00AA4904
		public void InitDataByConfig(SUiRoleCameraSetting config)
		{
			this.GamepadInputRate = config.倍化手柄输入倍率;
			this.MobileRotateInputRate = config.移动端旋转输入倍率;
			this.MobileZoomInputRate = config.移动端缩放输入倍率;
			this.SensitivityYaw = config.镜头Yaw灵敏度系数;
			this.SensitivityPitch = config.镜头Pitch灵敏度系数;
			this.SensitivityZoom = config.镜头缩放灵敏度系数;
			this.MinArmLength = config.最小臂长;
			this.MaxArmLength = config.最大臂长;
			this.PitchLimitMin = config.Pitch限制Min;
			this.PitchLimitMax = config.Pitch限制Max;
			this.YawLimitMin = config.Yaw限制Min;
			this.YawLimitMax = config.Yaw限制Max;
			this.CameraRelativeHeightLimitMin = config.相机相对角色的最低高度;
			this.CameraMaxAperture = config.最大臂长时的光圈;
			this.CameraMinAperture = config.最小臂长时的光圈;
			this.InputConfigInitialized = true;
		}

		// Token: 0x06025F12 RID: 155410 RVA: 0x00AA67CC File Offset: 0x00AA49CC
		public void SetNeedFloorReflection(bool state)
		{
			this.NeedFloorReflection = state;
		}

		// Token: 0x06025F13 RID: 155411 RVA: 0x00AA67D5 File Offset: 0x00AA49D5
		public void UpdateData(FVector sourceLocation, float cameraFloatMaxOffset, float cameraFloatMinOffset, float cameraFloatMaxArmLength, float cameraFloatMinArmLength)
		{
			this.UpdateData(UKismetMathLibrary.Conv_VectorToVectorDouble(sourceLocation), cameraFloatMaxOffset, cameraFloatMinOffset, cameraFloatMaxArmLength, cameraFloatMinArmLength);
		}

		// Token: 0x06025F14 RID: 155412 RVA: 0x00AA67EC File Offset: 0x00AA49EC
		public void UpdateData(FVectorDouble sourceLocation, float cameraFloatMaxOffset, float cameraFloatMinOffset, float cameraFloatMaxArmLength, float cameraFloatMinArmLength)
		{
			this.SourceLocation = sourceLocation;
			this.DefaultArmOffsetRotation = this.DesiredArmOffsetRotation;
			this.DefaultArmLength = this.DesiredArmLength;
			this.RequestedArmLength = this.DesiredArmLength;
			this.CameraFloatMaxOffset = cameraFloatMaxOffset;
			this.CameraFloatMinOffset = cameraFloatMinOffset;
			this.CameraFloatMaxArmLength = cameraFloatMaxArmLength;
			this.CameraFloatMinArmLength = cameraFloatMinArmLength;
			double num = Math.Sqrt(Math.Pow(this.SourceLocation.X - this.TargetLocation.X, 2.0) + Math.Pow(this.SourceLocation.Y - this.TargetLocation.Y, 2.0));
			float num2 = UiCameraLogicComponent.WrapAngle(this.DesiredArmOffsetRotation.Pitch);
			double num3 = this.TargetLocation.Z + num * Math.Tan((double)num2 * 3.141592653589793 / 180.0);
			this.ArmHeight = Convert.ToSingle(num3 - this.SourceLocation.Z - (double)this.CameraRelativeHeightLimitMin);
			this.DynamicCameraInitialized = true;
			this.RefreshDynamicCameraState();
			this.MarkOutputChanged();
		}

		// Token: 0x06025F15 RID: 155413 RVA: 0x00AA6904 File Offset: 0x00AA4B04
		public void ApplyInput(float yaw, float pitch, float zoom, float deltaTime)
		{
			if (!this.InputConfigInitialized)
			{
				return;
			}
			if (MathUtils.Instance.IsNearlyZero((double)yaw, null) && MathUtils.Instance.IsNearlyZero((double)pitch, null) && MathUtils.Instance.IsNearlyZero((double)zoom, null))
			{
				return;
			}
			float num = deltaTime * (float)TimeUtil.Instance.InverseMillisecond;
			if (Info.Instance.IsInGamepad())
			{
				yaw *= this.GamepadInputRate;
				pitch *= this.GamepadInputRate;
			}
			else if (Info.Instance.IsInTouch())
			{
				yaw *= this.MobileRotateInputRate;
				pitch *= this.MobileRotateInputRate;
				zoom *= this.MobileZoomInputRate;
			}
			this.DesiredArmOffsetRotation = new FRotator(MathUtils.Instance.Clamp(this.DesiredArmOffsetRotation.Pitch + pitch * this.SensitivityPitch * num, this.PitchLimitMin, this.PitchLimitMax), this.ClampYaw(this.DesiredArmOffsetRotation.Yaw + yaw * this.SensitivityYaw * num), this.DesiredArmOffsetRotation.Roll);
			this.RequestedArmLength = MathUtils.Instance.Clamp(this.RequestedArmLength + zoom * this.SensitivityZoom * num, this.MinArmLength, this.MaxArmLength);
			this.RefreshDynamicCameraState();
			this.MarkOutputChanged();
		}

		// Token: 0x06025F16 RID: 155414 RVA: 0x00AA6A58 File Offset: 0x00AA4C58
		internal void ResetForNewHandle()
		{
			this.DynamicCameraInitialized = false;
			this.NeedFloorReflection = false;
		}

		// Token: 0x06025F17 RID: 155415 RVA: 0x00AA6A68 File Offset: 0x00AA4C68
		public void SetArmLength(float armLength)
		{
			this.RequestedArmLength = armLength;
			this.RefreshDynamicCameraState();
			this.MarkOutputChanged();
		}

		// Token: 0x06025F18 RID: 155416 RVA: 0x00AA6A7D File Offset: 0x00AA4C7D
		public void SetLocation(FVectorDouble location)
		{
			this.TargetLocation = location;
			this.DesiredLocation = location;
			this.MarkOutputChanged();
		}

		// Token: 0x06025F19 RID: 155417 RVA: 0x00AA6A93 File Offset: 0x00AA4C93
		public void SetRotation(FRotator rotation)
		{
			this.DesiredRotation = rotation;
			this.MarkOutputChanged();
		}

		// Token: 0x06025F1A RID: 155418 RVA: 0x00AA6AA2 File Offset: 0x00AA4CA2
		public void SetArmRotationByDefaultCamera()
		{
			this.DesiredArmOffsetRotation = this.DefaultArmOffsetRotation;
			this.MarkOutputChanged();
		}

		// Token: 0x06025F1B RID: 155419 RVA: 0x00AA6AB6 File Offset: 0x00AA4CB6
		public int GetStateVersion()
		{
			return this.StateVersion;
		}

		// Token: 0x06025F1C RID: 155420 RVA: 0x00AA6AC0 File Offset: 0x00AA4CC0
		public override void Apply(UiCameraHandleData data)
		{
			this.DynamicCameraInitialized = false;
			this.TargetLocation = data.GetTargetLocation();
			this.DesiredLocation = this.TargetLocation;
			this.DesiredRotation = data.GetTargetRotation();
			this.DesiredArmLength = data.GetTargetArmLength();
			this.RequestedArmLength = this.DesiredArmLength;
			this.DesiredArmOffsetLocation = data.GetTargetArmOffsetLocation();
			this.DesiredArmOffsetRotation = data.GetTargetArmOffsetRotation();
			this.DesiredArmCollisionTest = data.GetTargetArmCollisionTest();
			this.DesiredFieldOfView = data.GetTargetFieldOfView();
			this.DesiredFocalDistance = data.GetTargetFocalDistance();
			this.DesiredAperture = data.GetTargetAperture();
			this.DesiredFocalRegion = data.GetTargetFocalRegion();
			this.DesiredPostProcessBlendWeight = data.GetTargetPostProcessBlendWeight();
			this.MarkOutputChanged();
		}

		// Token: 0x06025F1D RID: 155421 RVA: 0x00AA6B76 File Offset: 0x00AA4D76
		public override void Tick(float deltaTime)
		{
			this.RefreshDynamicFieldOfView();
			this.RefreshFloorReflection();
		}

		// Token: 0x06025F1E RID: 155422 RVA: 0x00AA6B84 File Offset: 0x00AA4D84
		private void RefreshDynamicFieldOfView()
		{
			if (!base.Mode.GetComponent<UiCameraBlendComponent>().IsBlending)
			{
				return;
			}
			UiCameraReplaceActorHandleData uiCameraReplaceActorHandleData = base.Mode.TryGetLastAppliedData() as UiCameraReplaceActorHandleData;
			if (uiCameraReplaceActorHandleData == null)
			{
				return;
			}
			float desiredFieldOfView = this.DesiredFieldOfView;
			uiCameraReplaceActorHandleData.RefreshDynamicFieldOfView();
			float targetFieldOfView = uiCameraReplaceActorHandleData.GetTargetFieldOfView();
			if (MathUtils.Instance.IsNearlyEqual((double)desiredFieldOfView, (double)targetFieldOfView, new double?((double)0.0001f)))
			{
				return;
			}
			this.DesiredFieldOfView = targetFieldOfView;
			this.MarkOutputChanged();
		}

		// Token: 0x06025F1F RID: 155423 RVA: 0x00AA6BF6 File Offset: 0x00AA4DF6
		private void MarkOutputChanged()
		{
			this.StateVersion++;
		}

		// Token: 0x06025F20 RID: 155424 RVA: 0x00AA6C08 File Offset: 0x00AA4E08
		private float ClampYaw(float yaw)
		{
			yaw %= 360f;
			yaw = ((yaw > 180f) ? (yaw - 360f) : yaw);
			if (Math.Abs(this.YawLimitMin) + Math.Abs(this.YawLimitMax) >= 360f)
			{
				return yaw;
			}
			return MathUtils.Instance.Clamp(yaw, this.YawLimitMin, this.YawLimitMax);
		}

		// Token: 0x06025F21 RID: 155425 RVA: 0x00AA6C6C File Offset: 0x00AA4E6C
		private void RefreshDynamicCameraState()
		{
			if (!this.InputConfigInitialized)
			{
				this.DesiredArmLength = this.RequestedArmLength;
				return;
			}
			this.DesiredArmLength = MathUtils.Instance.Clamp(this.RequestedArmLength, this.MinArmLength, this.MaxArmLength);
			if (!this.DynamicCameraInitialized)
			{
				return;
			}
			float num = UiCameraLogicComponent.WrapAngle(this.DesiredArmOffsetRotation.Pitch);
			if (num > 0f && !MathUtils.Instance.IsNearlyZero((double)num, null))
			{
				float num2 = Convert.ToSingle(Math.Abs((double)this.ArmHeight / Math.Sin((double)num * 3.141592653589793 / 180.0)));
				num2 = MathUtils.Instance.Clamp(num2, this.MinArmLength, this.MaxArmLength);
				this.DesiredArmLength = MathUtils.Instance.Clamp(this.DesiredArmLength, this.MinArmLength, num2);
			}
			float num3 = (this.DesiredArmLength < this.DefaultArmLength) ? MathUtils.Instance.RangeClamp(this.DesiredArmLength, this.CameraFloatMinArmLength, this.DefaultArmLength, this.CameraFloatMinOffset, 0f) : MathUtils.Instance.RangeClamp(this.DesiredArmLength, this.DefaultArmLength, this.CameraFloatMaxArmLength, 0f, this.CameraFloatMaxOffset);
			FVectorDouble targetLocation = this.TargetLocation;
			targetLocation.Z = Math.Max(this.TargetLocation.Z + (double)num3, this.SourceLocation.Z + (double)this.CameraRelativeHeightLimitMin);
			this.DesiredLocation = targetLocation;
			this.DesiredAperture = MathUtils.Instance.RangeClamp(this.DesiredArmLength, this.CameraFloatMinArmLength, this.CameraFloatMaxArmLength, this.CameraMinAperture, this.CameraMaxAperture);
		}

		// Token: 0x06025F22 RID: 155426 RVA: 0x00AA6E18 File Offset: 0x00AA5018
		private void RefreshFloorReflection()
		{
			if (!this.NeedFloorReflection)
			{
				return;
			}
			FVectorDouble sourceLocation = this.SourceLocation;
			sourceLocation.Z += 30.0;
			bool flag = HudUnitUtils.PositionUtil.ProjectWorldToScreen(sourceLocation, this.ReflectionScreenPosition);
			if (flag)
			{
				UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
				flag = (uiRootItem != null && Math.Abs(this.ReflectionScreenPosition.X) <= (double)(uiRootItem.GetWidth() / 2f) && Math.Abs(this.ReflectionScreenPosition.Y) <= (double)(uiRootItem.GetHeight() / 2f));
			}
			UiSceneUtils.SetSceneFloorReflection(flag, false);
		}

		// Token: 0x06025F23 RID: 155427 RVA: 0x00AA6EB8 File Offset: 0x00AA50B8
		private static float WrapAngle(float angle)
		{
			angle %= 360f;
			if (angle <= 180f)
			{
				return angle;
			}
			return angle - 360f;
		}

		// Token: 0x04014DCC RID: 85452
		private float GamepadInputRate;

		// Token: 0x04014DCD RID: 85453
		private float MobileRotateInputRate;

		// Token: 0x04014DCE RID: 85454
		private float MobileZoomInputRate;

		// Token: 0x04014DCF RID: 85455
		private float SensitivityYaw;

		// Token: 0x04014DD0 RID: 85456
		private float SensitivityPitch;

		// Token: 0x04014DD1 RID: 85457
		private float SensitivityZoom;

		// Token: 0x04014DD2 RID: 85458
		private float MinArmLength;

		// Token: 0x04014DD3 RID: 85459
		private float MaxArmLength;

		// Token: 0x04014DD4 RID: 85460
		private float PitchLimitMin;

		// Token: 0x04014DD5 RID: 85461
		private float PitchLimitMax;

		// Token: 0x04014DD6 RID: 85462
		private float YawLimitMin;

		// Token: 0x04014DD7 RID: 85463
		private float YawLimitMax;

		// Token: 0x04014DD8 RID: 85464
		private float CameraRelativeHeightLimitMin;

		// Token: 0x04014DD9 RID: 85465
		private float CameraMaxAperture;

		// Token: 0x04014DDA RID: 85466
		private float CameraMinAperture;

		// Token: 0x04014DDB RID: 85467
		private float CameraFloatMaxOffset;

		// Token: 0x04014DDC RID: 85468
		private float CameraFloatMinOffset;

		// Token: 0x04014DDD RID: 85469
		private float CameraFloatMaxArmLength;

		// Token: 0x04014DDE RID: 85470
		private float CameraFloatMinArmLength;

		// Token: 0x04014DDF RID: 85471
		private float DefaultArmLength;

		// Token: 0x04014DE0 RID: 85472
		private float RequestedArmLength;

		// Token: 0x04014DE1 RID: 85473
		private float ArmHeight;

		// Token: 0x04014DE2 RID: 85474
		private FVectorDouble TargetLocation;

		// Token: 0x04014DE3 RID: 85475
		private FRotator DefaultArmOffsetRotation;

		// Token: 0x04014DE4 RID: 85476
		private readonly Vector2D ReflectionScreenPosition = Vector2D.Create();

		// Token: 0x04014DE5 RID: 85477
		private bool InputConfigInitialized;

		// Token: 0x04014DE6 RID: 85478
		private bool DynamicCameraInitialized;

		// Token: 0x04014DE7 RID: 85479
		private int StateVersion;
	}
}
