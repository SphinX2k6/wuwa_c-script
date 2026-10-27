using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x0200021C RID: 540
[NullableContext(2)]
[Nullable(0)]
public class CameraModify
{
	// Token: 0x060020EE RID: 8430 RVA: 0x000B6570 File Offset: 0x000B4770
	[NullableContext(1)]
	public CameraModify(SCameraModifier_Settings cameraModify)
	{
		this.Name = cameraModify.ModifySettingsAdditional.Name;
		this.ArmLength = cameraModify.ArmLength;
		this.ArmLengthAdditional = cameraModify.ArmLengthAdditional;
		this.ArmRotation = Rotator.Create(cameraModify.ArmRotation);
		this.ArmRotationAdditional = Rotator.Create(cameraModify.ArmRotationAdditional);
		this.CameraFov = cameraModify.CameraFov;
		this.CameraOffset = Vector.Create(cameraModify.CameraOffset);
		this.CameraOffsetAdditional = Vector.Create(cameraModify.CameraOffsetAdditional);
		this.IsLockInput = cameraModify.IsLockInput;
		this.IsModifiedArmLength = cameraModify.IsModifiedArmLength;
		this.IsModifiedArmRotation = cameraModify.IsModifiedArmRotation;
		this.IsModifiedArmRotationPitch = cameraModify.IsModifiedArmRotationPitch;
		this.IsModifiedArmRotationRoll = cameraModify.IsModifiedArmRotationRoll;
		this.IsModifiedArmRotationYaw = cameraModify.IsModifiedArmRotationYaw;
		this.IsModifiedCameraFov = cameraModify.IsModifiedCameraFov;
		this.IsModifiedCameraOffset = cameraModify.IsModifiedCameraOffset;
		this.IsModifiedCameraOffsetX = cameraModify.IsModifiedCameraOffsetX;
		this.IsModifiedCameraOffsetY = cameraModify.IsModifiedCameraOffsetY;
		this.IsModifiedCameraOffsetZ = cameraModify.IsModifiedCameraOffsetZ;
		this.IsModifiedCameraLens = cameraModify.ModifySettingsAdditional.IsModifiedCameraLens;
		this.OverrideCameraInput = cameraModify.OverrideCameraInput;
		this.ResetFinalArmLength = cameraModify.ResetFinalArmLength;
		this.IsResetFinalArmLengthToSpecificValue = cameraModify.IsResetFinalArmLengthToSpecificValue;
		this.ResetFinalArmLengthToSpecificValue = cameraModify.ResetFinalArmLengthToSpecificValue;
		this.IsResetFinalArmLengthToDynamicValue = cameraModify.IsResetFinalArmLengthToDynamicValue;
		this.ResetFinalArmLengthToDynamicValueList.Clear();
		for (int i = 0; i < cameraModify.ResetFinalArmLengthToDynamicValue.Num(); i++)
		{
			this.ResetFinalArmLengthToDynamicValueList.Add(new ResetFinalArmLengthToDynamicValueData(cameraModify.ResetFinalArmLengthToDynamicValue.Get(i)));
		}
		this.ResetFinalArmRotation = cameraModify.ResetFinalArmRotation;
		this.IsResetFinalArmRotationToSpecificPitch = cameraModify.IsResetFinalArmRotationToSpecificPitch;
		this.ResetFinalArmRotationToSpecificPitch = cameraModify.ResetFinalArmRotationToSpecificPitch;
		this.IsResetFinalArmRotationToSpecificYaw = cameraModify.IsResetFinalArmRotationToSpecificYaw;
		this.ResetFinalArmRotationToSpecificYaw = cameraModify.ResetFinalArmRotationToSpecificYaw;
		this.StopModifyOnMontageEnd = cameraModify.StopModifyOnMontageEnd;
		this.StopModifyOnZoomInput = cameraModify.StopModifyOnZoomInput;
		this.IsLerpArmLocation = cameraModify.IsLerpArmLocation;
		this.IsSwitchModifier = cameraModify.IsSwitchModifier;
		this.IsUseArmLengthFloatCurve = cameraModify.ModifySettingsAdditional.IsUseArmLengthFloatCurve;
		if (this.IsUseArmLengthFloatCurve)
		{
			this.ArmLengthFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.ArmLengthFloatCurve);
		}
		this.IsUseArmRotationFloatCurve = cameraModify.ModifySettingsAdditional.IsUseArmRotationFloatCurve;
		if (this.IsUseArmRotationFloatCurve)
		{
			this.ArmRotationFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.ArmRotationFloatCurve);
		}
		this.IsUseFovFloatCurve = cameraModify.ModifySettingsAdditional.IsUseFovFloatCurve;
		if (this.IsUseFovFloatCurve)
		{
			this.FovFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.FovFloatCurve);
		}
		this.IsUseLensFloatCurve = cameraModify.ModifySettingsAdditional.IsUseLensFloatCurve;
		if (this.IsUseLensFloatCurve)
		{
			this.LensFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.LensFloatCurve);
		}
		this.CameraLens = cameraModify.ModifySettingsAdditional.CameraLens;
		this.IsForcePlayModify = cameraModify.IsForcePlayModify;
		this.IsUseCameraOffsetFloatCurve = cameraModify.ModifySettingsAdditional.IsUseCameraOffsetFloatCurve;
		if (this.IsUseCameraOffsetFloatCurve)
		{
			this.CameraOffsetFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.CameraOffsetFloatCurve);
		}
		this.IsModifiedArmOffset = cameraModify.ModifySettingsAdditional.IsModifiedArmOffset;
		Vector armOffset = this.ArmOffset;
		FVector armOffset2 = cameraModify.ModifySettingsAdditional.ArmOffset;
		FVectorDouble fvectorDouble = armOffset2;
		armOffset.DeepCopy(fvectorDouble);
		this.IsUseArmOffsetFloatCurve = cameraModify.ModifySettingsAdditional.IsUseArmOffsetFloatCurve;
		if (this.IsUseArmOffsetFloatCurve)
		{
			this.ArmOffsetFloatCurve = CurveUtils.CreateCurveByStruct(cameraModify.ModifySettingsAdditional.ArmOffsetFloatCurve);
		}
		if (cameraModify.ArmRotationType == ECameraModifyParamType.曲线 && cameraModify.ArmRotationCurve != null)
		{
			this.ArmRotationPitchEval = new CurveFloatEvaluator(cameraModify.ArmRotationCurve, "Y");
			this.ArmRotationYawEval = new CurveFloatEvaluator(cameraModify.ArmRotationCurve, "Z");
			this.ArmRotationRollEval = new CurveFloatEvaluator(cameraModify.ArmRotationCurve, "X");
		}
		else
		{
			this.ArmRotationPitchEval = new ConstEvaluator(cameraModify.ArmRotation.Pitch);
			this.ArmRotationYawEval = new ConstEvaluator(cameraModify.ArmRotation.Yaw);
			this.ArmRotationRollEval = new ConstEvaluator(cameraModify.ArmRotation.Roll);
		}
		if (cameraModify.ArmRotationAdditionalType == ECameraModifyParamType.曲线 && cameraModify.ArmRotationAdditionalCurve != null)
		{
			this.ArmRotationAdditionalPitchEval = new CurveFloatEvaluator(cameraModify.ArmRotationAdditionalCurve, "Y");
			this.ArmRotationAdditionalYawEval = new CurveFloatEvaluator(cameraModify.ArmRotationAdditionalCurve, "Z");
			this.ArmRotationAdditionalRollEval = new CurveFloatEvaluator(cameraModify.ArmRotationAdditionalCurve, "X");
		}
		else
		{
			this.ArmRotationAdditionalPitchEval = new ConstEvaluator(cameraModify.ArmRotationAdditional.Pitch);
			this.ArmRotationAdditionalYawEval = new ConstEvaluator(cameraModify.ArmRotationAdditional.Yaw);
			this.ArmRotationAdditionalRollEval = new ConstEvaluator(cameraModify.ArmRotationAdditional.Roll);
		}
		if (cameraModify.CameraOffsetType == ECameraModifyParamType.曲线 && cameraModify.CameraOffsetCurve != null)
		{
			this.CameraOffsetEval = new CurveVectorEvaluator(cameraModify.CameraOffsetCurve);
		}
		else
		{
			this.CameraOffsetEval = new ConstVectorEvaluator(cameraModify.CameraOffset);
		}
		if (cameraModify.CameraOffsetAdditionalType == ECameraModifyParamType.曲线 && cameraModify.CameraOffsetAdditionalCurve != null)
		{
			this.CameraOffsetAdditionalEval = new CurveVectorEvaluator(cameraModify.CameraOffsetAdditionalCurve);
			return;
		}
		this.CameraOffsetAdditionalEval = new ConstVectorEvaluator(cameraModify.CameraOffsetAdditional);
	}

	// Token: 0x04001540 RID: 5440
	[Nullable(1)]
	public string Name;

	// Token: 0x04001541 RID: 5441
	public float ArmLength;

	// Token: 0x04001542 RID: 5442
	public float ArmLengthAdditional;

	// Token: 0x04001543 RID: 5443
	[Nullable(1)]
	public Rotator ArmRotation;

	// Token: 0x04001544 RID: 5444
	[Nullable(1)]
	public Rotator ArmRotationAdditional;

	// Token: 0x04001545 RID: 5445
	public float CameraFov;

	// Token: 0x04001546 RID: 5446
	[Nullable(1)]
	public Vector CameraOffset;

	// Token: 0x04001547 RID: 5447
	[Nullable(1)]
	public Vector CameraOffsetAdditional;

	// Token: 0x04001548 RID: 5448
	public bool IsLockInput;

	// Token: 0x04001549 RID: 5449
	public bool IsModifiedArmLength;

	// Token: 0x0400154A RID: 5450
	public bool IsModifiedArmRotation;

	// Token: 0x0400154B RID: 5451
	public bool IsModifiedArmRotationPitch;

	// Token: 0x0400154C RID: 5452
	public bool IsModifiedArmRotationRoll;

	// Token: 0x0400154D RID: 5453
	public bool IsModifiedArmRotationYaw;

	// Token: 0x0400154E RID: 5454
	public bool IsModifiedCameraFov;

	// Token: 0x0400154F RID: 5455
	public bool IsModifiedCameraOffset;

	// Token: 0x04001550 RID: 5456
	public bool IsModifiedCameraOffsetX;

	// Token: 0x04001551 RID: 5457
	public bool IsModifiedCameraOffsetY;

	// Token: 0x04001552 RID: 5458
	public bool IsModifiedCameraOffsetZ;

	// Token: 0x04001553 RID: 5459
	public bool IsModifiedCameraLens;

	// Token: 0x04001554 RID: 5460
	public bool OverrideCameraInput;

	// Token: 0x04001555 RID: 5461
	public bool ResetFinalArmLength;

	// Token: 0x04001556 RID: 5462
	public bool IsResetFinalArmLengthToSpecificValue;

	// Token: 0x04001557 RID: 5463
	public float ResetFinalArmLengthToSpecificValue;

	// Token: 0x04001558 RID: 5464
	public bool IsResetFinalArmLengthToDynamicValue;

	// Token: 0x04001559 RID: 5465
	[Nullable(1)]
	public List<ResetFinalArmLengthToDynamicValueData> ResetFinalArmLengthToDynamicValueList = new List<ResetFinalArmLengthToDynamicValueData>();

	// Token: 0x0400155A RID: 5466
	public bool ResetFinalArmRotation;

	// Token: 0x0400155B RID: 5467
	public bool IsResetFinalArmRotationToSpecificPitch;

	// Token: 0x0400155C RID: 5468
	public float ResetFinalArmRotationToSpecificPitch;

	// Token: 0x0400155D RID: 5469
	public bool IsResetFinalArmRotationToSpecificYaw;

	// Token: 0x0400155E RID: 5470
	public float ResetFinalArmRotationToSpecificYaw;

	// Token: 0x0400155F RID: 5471
	public bool StopModifyOnMontageEnd;

	// Token: 0x04001560 RID: 5472
	public bool StopModifyOnZoomInput;

	// Token: 0x04001561 RID: 5473
	public bool IsLerpArmLocation;

	// Token: 0x04001562 RID: 5474
	public bool IsSwitchModifier;

	// Token: 0x04001563 RID: 5475
	public bool IsUseArmLengthFloatCurve;

	// Token: 0x04001564 RID: 5476
	public CurveBase ArmLengthFloatCurve;

	// Token: 0x04001565 RID: 5477
	public bool IsUseArmRotationFloatCurve;

	// Token: 0x04001566 RID: 5478
	public CurveBase ArmRotationFloatCurve;

	// Token: 0x04001567 RID: 5479
	public bool IsUseFovFloatCurve;

	// Token: 0x04001568 RID: 5480
	public CurveBase FovFloatCurve;

	// Token: 0x04001569 RID: 5481
	public bool IsUseLensFloatCurve;

	// Token: 0x0400156A RID: 5482
	public CurveBase LensFloatCurve;

	// Token: 0x0400156B RID: 5483
	public SCameraModifier_Lens CameraLens;

	// Token: 0x0400156C RID: 5484
	public bool IsForcePlayModify;

	// Token: 0x0400156D RID: 5485
	public bool IsUseCameraOffsetFloatCurve;

	// Token: 0x0400156E RID: 5486
	public CurveBase CameraOffsetFloatCurve;

	// Token: 0x0400156F RID: 5487
	public bool IsModifiedArmOffset;

	// Token: 0x04001570 RID: 5488
	[Nullable(1)]
	public Vector ArmOffset = Vector.Create();

	// Token: 0x04001571 RID: 5489
	public bool IsUseArmOffsetFloatCurve;

	// Token: 0x04001572 RID: 5490
	public CurveBase ArmOffsetFloatCurve;

	// Token: 0x04001573 RID: 5491
	public IModifyParamEvaluator ArmRotationPitchEval;

	// Token: 0x04001574 RID: 5492
	public IModifyParamEvaluator ArmRotationYawEval;

	// Token: 0x04001575 RID: 5493
	public IModifyParamEvaluator ArmRotationRollEval;

	// Token: 0x04001576 RID: 5494
	public IModifyParamEvaluator ArmRotationAdditionalPitchEval;

	// Token: 0x04001577 RID: 5495
	public IModifyParamEvaluator ArmRotationAdditionalYawEval;

	// Token: 0x04001578 RID: 5496
	public IModifyParamEvaluator ArmRotationAdditionalRollEval;

	// Token: 0x04001579 RID: 5497
	public IVectorParamEvaluator CameraOffsetEval;

	// Token: 0x0400157A RID: 5498
	public IVectorParamEvaluator CameraOffsetAdditionalEval;
}
