using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.UiComponent;
using UnrealEngine;

// Token: 0x02002C48 RID: 11336
[NullableContext(1)]
[Nullable(0)]
public class UiCameraControlRotationComponent : UiCameraComponent
{
	// Token: 0x06017A46 RID: 96838 RVA: 0x00603EB6 File Offset: 0x006020B6
	protected override void OnActivate()
	{
		base.EnableTick();
	}

	// Token: 0x06017A47 RID: 96839 RVA: 0x00603EBE File Offset: 0x006020BE
	protected override void OnDeactivate()
	{
		base.RemoveTick();
	}

	// Token: 0x06017A48 RID: 96840 RVA: 0x00603EC8 File Offset: 0x006020C8
	public void InitDataByConfig(SUiRoleCameraSetting config)
	{
		this.InitData(config.倍化手柄输入倍率, config.移动端旋转输入倍率, config.移动端缩放输入倍率, config.镜头Yaw灵敏度系数, config.镜头Pitch灵敏度系数, config.镜头缩放灵敏度系数, config.最小臂长, config.最大臂长, config.Pitch限制Min, config.Pitch限制Max, config.Yaw限制Min, config.Yaw限制Max, config.相机相对角色的最低高度, config.最大臂长时的光圈, config.最小臂长时的光圈);
	}

	// Token: 0x06017A49 RID: 96841 RVA: 0x00603F38 File Offset: 0x00602138
	public void InitData(float gamepadInputRate, float mobileRotateInputRate, float mobileZoomInputRate, float sensitivityYaw, float sensitivityPitch, float sensitivityZoom, float minArmLength, float maxArmLength, float pitchLimitMin, float pitchLimitMax, float yawLimitMin, float yawLimitMax, float cameraRelativeHeightLimitMin, float cameraMaxAperture, float cameraMinAperture)
	{
		this.GamepadInputRate = gamepadInputRate;
		this.MobileRotateInputRate = mobileRotateInputRate;
		this.MobileZoomInputRate = mobileZoomInputRate;
		this.SensitivityYaw = sensitivityYaw;
		this.SensitivityPitch = sensitivityPitch;
		this.SensitivityZoom = sensitivityZoom;
		this.CameraRelativeHeightLimitMin = cameraRelativeHeightLimitMin;
		UiCameraControlRotationComponent.VirtualCamera desiredCamera = this.DesiredCamera;
		desiredCamera.MinArmLength = minArmLength;
		desiredCamera.MaxArmLength = maxArmLength;
		desiredCamera.PitchLimitMin = pitchLimitMin;
		desiredCamera.PitchLimitMax = pitchLimitMax;
		desiredCamera.YawLimitMin = yawLimitMin;
		desiredCamera.YawLimitMax = yawLimitMax;
		this.CameraMaxAperture = cameraMaxAperture;
		this.CameraMinAperture = cameraMinAperture;
	}

	// Token: 0x06017A4A RID: 96842 RVA: 0x00603FC0 File Offset: 0x006021C0
	public void UpdateData(FVectorDouble sourceLocation, float cameraFloatMaxOffset, float cameraFloatMinOffset, float cameraFloatMaxArmLength, float cameraFloatMinArmLength)
	{
		UiCameraStructure cameraStructure = base.GetCameraStructure();
		if (cameraStructure == null)
		{
			return;
		}
		FVectorDouble actorLocation = cameraStructure.GetActorLocation();
		FRotator springRelativeRotation = cameraStructure.GetSpringRelativeRotation();
		this.DesiredCamera.ArmRotation.DeepCopy(springRelativeRotation);
		this.DesiredCamera.DefaultLookCenterLocation.DeepCopy(actorLocation);
		this.TempSourceLocation.DeepCopy(sourceLocation);
		this.TempCameraLocation.DeepCopy(actorLocation);
		double num = Vector.Dist2D(this.TempSourceLocation, this.TempCameraLocation);
		float num2 = MathCommon.DegreeToRadian(MathCommon.WrapAngle(springRelativeRotation.Pitch));
		double z = num * Math.Tan((double)num2) + this.TempCameraLocation.Z;
		this.TempLookCenterLocation.X = this.TempSourceLocation.X;
		this.TempLookCenterLocation.Y = this.TempSourceLocation.Y;
		this.TempLookCenterLocation.Z = z;
		this.DesiredCamera.LookCenterLocation.DeepCopy(this.TempLookCenterLocation);
		this.DesiredCamera.ArmLength = cameraStructure.GetSpringArmLength();
		this.DefaultCameraArmLength = cameraStructure.GetSpringArmLength();
		this.DesiredCamera.ArmHeight = (float)(this.TempLookCenterLocation.Z - this.TempSourceLocation.Z - (double)this.CameraRelativeHeightLimitMin);
		this.CameraFloatMaxOffset = cameraFloatMaxOffset;
		this.CameraFloatMinOffset = cameraFloatMinOffset;
		this.CameraFloatMaxArmLength = cameraFloatMaxArmLength;
		this.CameraFloatMinArmLength = cameraFloatMinArmLength;
		this.DesiredCamera.HeightOffset = 0f;
		this.DefaultCamera.DeepCopy(this.DesiredCamera);
		this.CurrentCamera.DeepCopy(this.DesiredCamera);
	}

	// Token: 0x06017A4B RID: 96843 RVA: 0x00604143 File Offset: 0x00602343
	protected override void OnTick(float delta)
	{
		if (!this.IsFading)
		{
			this.UpdateInput(delta);
		}
		this.UpdateYaw();
		this.UpdatePitch();
		this.UpdateArmLength();
		this.UpdateFading(delta);
		this.UpdateCameraTransform();
		this.UpdateFloorReflectionSetting();
	}

	// Token: 0x06017A4C RID: 96844 RVA: 0x00604179 File Offset: 0x00602379
	private void ResetInput()
	{
		this.YawInput = 0f;
		this.PitchInput = 0f;
		this.ZoomInput = 0f;
	}

	// Token: 0x06017A4D RID: 96845 RVA: 0x0060419C File Offset: 0x0060239C
	private void UpdateInput(float deltaTime)
	{
		float num = this.YawInput;
		float num2 = this.PitchInput;
		float num3 = this.ZoomInput;
		this.ResetInput();
		if (Info.Instance.IsInGamepad())
		{
			num *= this.GamepadInputRate;
			num2 *= this.GamepadInputRate;
		}
		else if (Info.Instance.IsInTouch())
		{
			num *= this.MobileRotateInputRate;
			num2 *= this.MobileRotateInputRate;
			num3 *= this.MobileZoomInputRate;
		}
		num = num * this.SensitivityYaw * deltaTime;
		num2 = num2 * this.SensitivityPitch * deltaTime;
		num3 = num3 * this.SensitivityZoom * deltaTime;
		if (!MathUtils.Instance.IsNearlyZero((double)num, null))
		{
			this.DesiredCamera.ArmRotation.Yaw += num;
		}
		if (!MathUtils.Instance.IsNearlyZero((double)num2, null))
		{
			this.DesiredCamera.ArmRotation.Pitch += num2;
		}
		if (!MathUtils.Instance.IsNearlyZero((double)num3, null))
		{
			this.DesiredCamera.ArmLength += num3;
		}
	}

	// Token: 0x06017A4E RID: 96846 RVA: 0x006042B4 File Offset: 0x006024B4
	private void UpdateYaw()
	{
		float num = this.DesiredCamera.ArmRotation.Yaw;
		num %= 360f;
		num = ((num > 180f) ? (num - 360f) : num);
		if (Math.Abs(this.DesiredCamera.YawLimitMin) + Math.Abs(this.DesiredCamera.YawLimitMax) < 360f)
		{
			num = MathUtils.Instance.Clamp(num, this.DesiredCamera.YawLimitMin, this.DesiredCamera.YawLimitMax);
		}
		this.DesiredCamera.ArmRotation.Yaw = num;
	}

	// Token: 0x06017A4F RID: 96847 RVA: 0x00604348 File Offset: 0x00602548
	private void UpdatePitch()
	{
		float num = this.DesiredCamera.ArmRotation.Pitch;
		num %= 360f;
		num = ((num > 180f) ? (num - 360f) : num);
		num = MathUtils.Instance.Clamp(num, this.DesiredCamera.PitchLimitMin, this.DesiredCamera.PitchLimitMax);
		this.DesiredCamera.ArmRotation.Pitch = num;
	}

	// Token: 0x06017A50 RID: 96848 RVA: 0x006043B4 File Offset: 0x006025B4
	private void UpdateArmLength()
	{
		this.DesiredCamera.ArmLength = MathUtils.Instance.Clamp(this.DesiredCamera.ArmLength, this.DesiredCamera.MinArmLength, this.DesiredCamera.MaxArmLength);
	}

	// Token: 0x06017A51 RID: 96849 RVA: 0x006043EC File Offset: 0x006025EC
	public void StartFade(float duration, UCurveFloat fadeCurve, bool fadeArmLength, bool fadeArmRotationPitch, bool fadeArmRotationYaw, bool fadeArmRotationRoll)
	{
		this.LastCamera.DeepCopy(this.CurrentCamera);
		this.FadeArmLength = fadeArmLength;
		this.FadeArmRotationPitch = fadeArmRotationPitch;
		this.FadeArmRotationYaw = fadeArmRotationYaw;
		this.FadeArmRotationRoll = fadeArmRotationRoll;
		this.IsFading = true;
		this.FadeDuration = duration;
		this.FadeElapse = 0f;
		this.FadeCurve = fadeCurve;
	}

	// Token: 0x06017A52 RID: 96850 RVA: 0x0060444C File Offset: 0x0060264C
	private void UpdateFading(float deltaTime)
	{
		if (!this.IsFading || this.FadeCurve == null)
		{
			this.CurrentCamera.DeepCopy(this.DesiredCamera);
			return;
		}
		this.FadeElapse += deltaTime;
		if (this.FadeElapse >= this.FadeDuration)
		{
			this.IsFading = false;
			this.FadeCurve = null;
			this.CurrentCamera.DeepCopy(this.DesiredCamera);
			return;
		}
		float floatValue = this.FadeCurve.GetFloatValue(this.FadeElapse / this.FadeDuration);
		if (this.FadeArmLength)
		{
			this.CurrentCamera.ArmLength = MathUtils.Instance.Lerp(this.LastCamera.ArmLength, this.DesiredCamera.ArmLength, floatValue);
		}
		if (this.FadeArmRotationPitch)
		{
			this.CurrentCamera.ArmRotation.Pitch = MathUtils.Instance.Lerp(this.LastCamera.ArmRotation.Pitch, this.DesiredCamera.ArmRotation.Pitch, floatValue);
		}
		if (this.FadeArmRotationYaw)
		{
			this.CurrentCamera.ArmRotation.Yaw = MathUtils.Instance.Lerp(this.LastCamera.ArmRotation.Yaw, this.DesiredCamera.ArmRotation.Yaw, floatValue);
		}
		if (this.FadeArmRotationRoll)
		{
			this.CurrentCamera.ArmRotation.Roll = MathUtils.Instance.Lerp(this.LastCamera.ArmRotation.Roll, this.DesiredCamera.ArmRotation.Roll, floatValue);
		}
	}

	// Token: 0x06017A53 RID: 96851 RVA: 0x006045D0 File Offset: 0x006027D0
	private void UpdateCameraTransform()
	{
		Rotator armRotation = this.CurrentCamera.ArmRotation;
		this.TempLookCenterLocation.DeepCopy(this.CurrentCamera.LookCenterLocation);
		Vector tempLookCenterLocation = this.TempLookCenterLocation;
		float num = this.CurrentCamera.ArmLength;
		float pitch = this.CurrentCamera.ArmRotation.Pitch;
		if (pitch > 0f && !MathUtils.Instance.IsNearlyZero((double)pitch, null))
		{
			float num2 = MathCommon.DegreeToRadian(MathCommon.WrapAngle(pitch));
			float num3 = (float)Math.Abs((double)this.CurrentCamera.ArmHeight / Math.Sin((double)num2));
			num3 = MathUtils.Instance.Clamp(num3, this.CurrentCamera.MinArmLength, this.CurrentCamera.MaxArmLength);
			num = MathUtils.Instance.Clamp(num, this.CurrentCamera.MinArmLength, num3);
		}
		armRotation.Quaternion(null).RotateVector(Vector.ForwardVectorProxy, this.TempCameraForward);
		this.TempCameraForward.Multiply((double)(-(double)num), this.TempCameraVector);
		tempLookCenterLocation.Addition(this.TempCameraVector, this.TempCameraLocation);
		this.UpdateHeightOffset(num);
		this.UpdateAperture(num);
		Vector defaultLookCenterLocation = this.CurrentCamera.DefaultLookCenterLocation;
		this.TempCameraLocation.Z = defaultLookCenterLocation.Z + (double)this.CurrentCamera.HeightOffset;
		double num4 = tempLookCenterLocation.Z - (double)this.CurrentCamera.ArmHeight;
		if (this.TempCameraLocation.Z < num4)
		{
			this.TempCameraLocation.Z = num4;
		}
		this.TempCameraLocation.X = defaultLookCenterLocation.X;
		this.TempCameraLocation.Y = defaultLookCenterLocation.Y;
		UiCameraStructure cameraStructure = base.GetCameraStructure();
		if (cameraStructure == null)
		{
			return;
		}
		cameraStructure.SetSprintArmRelativeRotation(armRotation.ToUeRotator());
		cameraStructure.SetSpringArmLength(num);
		cameraStructure.SetActorLocation(this.TempCameraLocation.ToUeVector(false));
	}

	// Token: 0x06017A54 RID: 96852 RVA: 0x006047A8 File Offset: 0x006029A8
	public void UpdateHeightOffset(float armLength)
	{
		if (armLength < this.DefaultCameraArmLength)
		{
			this.CurrentCamera.HeightOffset = MathUtils.Instance.RangeClamp(armLength, this.CameraFloatMinArmLength, this.DefaultCameraArmLength, this.CameraFloatMinOffset, 0f);
			return;
		}
		this.CurrentCamera.HeightOffset = MathUtils.Instance.RangeClamp(armLength, this.DefaultCameraArmLength, this.CameraFloatMaxArmLength, 0f, this.CameraFloatMaxOffset);
	}

	// Token: 0x06017A55 RID: 96853 RVA: 0x0060481C File Offset: 0x00602A1C
	public void UpdateAperture(float armLength)
	{
		this.CurrentCamera.Aperture = MathUtils.Instance.RangeClamp(armLength, this.CameraFloatMinArmLength, this.CameraFloatMaxArmLength, this.CameraMinAperture, this.CameraMaxAperture);
		UiCameraPostEffectComponent uiCameraComponent = this.OwnerUiCamera.GetUiCameraComponent<UiCameraPostEffectComponent>();
		if (uiCameraComponent == null)
		{
			return;
		}
		uiCameraComponent.SetCameraAperture(this.CurrentCamera.Aperture);
	}

	// Token: 0x06017A56 RID: 96854 RVA: 0x00604878 File Offset: 0x00602A78
	public void UpdateFloorReflectionSetting()
	{
		if (!this.NeedCheckReflection)
		{
			return;
		}
		this.TempSourceLocation.Addition(this.SourceLocationOffset, this.ScreenReflectionPosition);
		FVectorDouble worldLocation = this.ScreenReflectionPosition.ToUeVector(false);
		bool flag = HudUnitUtils.PositionUtil.ProjectWorldToScreen(worldLocation, this.SourceScreenPos);
		if (flag)
		{
			Vector2D viewportSizeByPool = WorldMapUtil.GetViewportSizeByPool();
			flag = (Math.Abs(this.SourceScreenPos.X) <= viewportSizeByPool.X / 2.0 && Math.Abs(this.SourceScreenPos.Y) <= viewportSizeByPool.Y / 2.0);
		}
		UiSceneUtils.SetSceneFloorReflection(flag, false);
	}

	// Token: 0x06017A57 RID: 96855 RVA: 0x00604920 File Offset: 0x00602B20
	public void SetNeedFloorReflection(bool state)
	{
		this.NeedCheckReflection = state;
	}

	// Token: 0x06017A58 RID: 96856 RVA: 0x00604929 File Offset: 0x00602B29
	public void AddZoomInput(float zoomInput)
	{
		this.ZoomInput = zoomInput;
	}

	// Token: 0x06017A59 RID: 96857 RVA: 0x00604932 File Offset: 0x00602B32
	public void AddYawInput(float yawInput)
	{
		this.YawInput = yawInput;
	}

	// Token: 0x06017A5A RID: 96858 RVA: 0x0060493B File Offset: 0x00602B3B
	public void AddPitchInput(float pitchInput)
	{
		this.PitchInput = pitchInput;
	}

	// Token: 0x06017A5B RID: 96859 RVA: 0x00604944 File Offset: 0x00602B44
	public void DoMoveForward(float moveDistance, float duration, UCurveFloat curve)
	{
		this.DesiredCamera.ArmLength = this.DesiredCamera.ArmLength - moveDistance;
		this.StartFade(duration, curve, true, false, false, false);
	}

	// Token: 0x06017A5C RID: 96860 RVA: 0x0060496A File Offset: 0x00602B6A
	public void SetArmLength(float armLength)
	{
		this.DesiredCamera.ArmLength = armLength;
	}

	// Token: 0x06017A5D RID: 96861 RVA: 0x00604978 File Offset: 0x00602B78
	public void SetArmRotation(float pitch, float yaw, float roll)
	{
		this.DesiredCamera.ArmRotation.Pitch = pitch;
		this.DesiredCamera.ArmRotation.Yaw = yaw;
		this.DesiredCamera.ArmRotation.Roll = roll;
	}

	// Token: 0x06017A5E RID: 96862 RVA: 0x006049B0 File Offset: 0x00602BB0
	public void SetArmRotationByDefaultCamera()
	{
		Rotator armRotation = this.DefaultCamera.ArmRotation;
		this.SetArmRotation(armRotation.Pitch, armRotation.Yaw, armRotation.Roll);
	}

	// Token: 0x0400B02D RID: 45101
	public readonly UiCameraControlRotationComponent.VirtualCamera DefaultCamera = new UiCameraControlRotationComponent.VirtualCamera();

	// Token: 0x0400B02E RID: 45102
	public readonly UiCameraControlRotationComponent.VirtualCamera LastCamera = new UiCameraControlRotationComponent.VirtualCamera();

	// Token: 0x0400B02F RID: 45103
	public readonly UiCameraControlRotationComponent.VirtualCamera CurrentCamera = new UiCameraControlRotationComponent.VirtualCamera();

	// Token: 0x0400B030 RID: 45104
	public readonly UiCameraControlRotationComponent.VirtualCamera DesiredCamera = new UiCameraControlRotationComponent.VirtualCamera();

	// Token: 0x0400B031 RID: 45105
	public readonly Vector TempLookCenterLocation = Vector.Create();

	// Token: 0x0400B032 RID: 45106
	public readonly Vector TempCameraForward = Vector.Create();

	// Token: 0x0400B033 RID: 45107
	public readonly Vector TempCameraVector = Vector.Create();

	// Token: 0x0400B034 RID: 45108
	public readonly Vector TempCameraLocation = Vector.Create();

	// Token: 0x0400B035 RID: 45109
	public Vector TempSourceLocation = Vector.Create();

	// Token: 0x0400B036 RID: 45110
	private readonly Vector2D SourceScreenPos = new Vector2D();

	// Token: 0x0400B037 RID: 45111
	private readonly Vector SourceLocationOffset = new Vector(0.0, 0.0, 30.0);

	// Token: 0x0400B038 RID: 45112
	private readonly Vector ScreenReflectionPosition = Vector.Create();

	// Token: 0x0400B039 RID: 45113
	private bool NeedCheckReflection;

	// Token: 0x0400B03A RID: 45114
	private float GamepadInputRate;

	// Token: 0x0400B03B RID: 45115
	private float MobileRotateInputRate;

	// Token: 0x0400B03C RID: 45116
	private float MobileZoomInputRate;

	// Token: 0x0400B03D RID: 45117
	private float SensitivityYaw;

	// Token: 0x0400B03E RID: 45118
	private float SensitivityPitch;

	// Token: 0x0400B03F RID: 45119
	private float SensitivityZoom;

	// Token: 0x0400B040 RID: 45120
	private float CameraRelativeHeightLimitMin;

	// Token: 0x0400B041 RID: 45121
	private float CameraFloatMaxOffset;

	// Token: 0x0400B042 RID: 45122
	private float CameraFloatMinOffset;

	// Token: 0x0400B043 RID: 45123
	private float CameraFloatMinArmLength;

	// Token: 0x0400B044 RID: 45124
	private float CameraFloatMaxArmLength;

	// Token: 0x0400B045 RID: 45125
	private float CameraMaxAperture;

	// Token: 0x0400B046 RID: 45126
	private float CameraMinAperture;

	// Token: 0x0400B047 RID: 45127
	private float YawInput;

	// Token: 0x0400B048 RID: 45128
	private float PitchInput;

	// Token: 0x0400B049 RID: 45129
	private float ZoomInput;

	// Token: 0x0400B04A RID: 45130
	private float DefaultCameraArmLength;

	// Token: 0x0400B04B RID: 45131
	private bool IsFading;

	// Token: 0x0400B04C RID: 45132
	private float FadeDuration;

	// Token: 0x0400B04D RID: 45133
	private float FadeElapse;

	// Token: 0x0400B04E RID: 45134
	private UCurveFloat FadeCurve;

	// Token: 0x0400B04F RID: 45135
	private bool FadeArmLength;

	// Token: 0x0400B050 RID: 45136
	private bool FadeArmRotationPitch;

	// Token: 0x0400B051 RID: 45137
	private bool FadeArmRotationYaw;

	// Token: 0x0400B052 RID: 45138
	private bool FadeArmRotationRoll;

	// Token: 0x02009236 RID: 37430
	[Nullable(0)]
	public class VirtualCamera
	{
		// Token: 0x0604BE66 RID: 310886 RVA: 0x014020EC File Offset: 0x014002EC
		public void DeepCopy(UiCameraControlRotationComponent.VirtualCamera camera)
		{
			this.ArmLength = camera.ArmLength;
			this.MinArmLength = camera.MinArmLength;
			this.MaxArmLength = camera.MaxArmLength;
			this.YawLimitMin = camera.YawLimitMin;
			this.YawLimitMax = camera.YawLimitMax;
			this.PitchLimitMin = camera.PitchLimitMin;
			this.PitchLimitMax = camera.PitchLimitMax;
			this.HeightOffset = camera.HeightOffset;
			this.ArmHeight = camera.ArmHeight;
			this.Aperture = camera.Aperture;
			this.LookCenterLocation.DeepCopy(camera.LookCenterLocation);
			this.DefaultLookCenterLocation.DeepCopy(camera.DefaultLookCenterLocation);
			this.ArmRotation.DeepCopy(camera.ArmRotation);
		}

		// Token: 0x0402F4A2 RID: 193698
		public float ArmLength;

		// Token: 0x0402F4A3 RID: 193699
		public float MinArmLength;

		// Token: 0x0402F4A4 RID: 193700
		public float MaxArmLength;

		// Token: 0x0402F4A5 RID: 193701
		public float YawLimitMin;

		// Token: 0x0402F4A6 RID: 193702
		public float YawLimitMax;

		// Token: 0x0402F4A7 RID: 193703
		public float PitchLimitMin;

		// Token: 0x0402F4A8 RID: 193704
		public float PitchLimitMax;

		// Token: 0x0402F4A9 RID: 193705
		public float HeightOffset;

		// Token: 0x0402F4AA RID: 193706
		public float ArmHeight;

		// Token: 0x0402F4AB RID: 193707
		public float Aperture;

		// Token: 0x0402F4AC RID: 193708
		public Vector LookCenterLocation = Vector.Create();

		// Token: 0x0402F4AD RID: 193709
		public Vector DefaultLookCenterLocation = Vector.Create();

		// Token: 0x0402F4AE RID: 193710
		public Rotator ArmRotation = Rotator.Create();
	}
}
