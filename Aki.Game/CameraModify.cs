using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02000220 RID: 544
[NullableContext(2)]
[Nullable(0)]
public class CameraModify
{
	// Token: 0x0600219C RID: 8604 RVA: 0x000BD890 File Offset: 0x000BBA90
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

	// Token: 0x04001582 RID: 5506
	[Nullable(1)]
	public string Name;

	// Token: 0x04001583 RID: 5507
	public float ArmLength;

	// Token: 0x04001584 RID: 5508
	public float ArmLengthAdditional;

	// Token: 0x04001585 RID: 5509
	[Nullable(1)]
	public Rotator ArmRotation;

	// Token: 0x04001586 RID: 5510
	[Nullable(1)]
	public Rotator ArmRotationAdditional;

	// Token: 0x04001587 RID: 5511
	public float CameraFov;

	// Token: 0x04001588 RID: 5512
	[Nullable(1)]
	public Vector CameraOffset;

	// Token: 0x04001589 RID: 5513
	[Nullable(1)]
	public Vector CameraOffsetAdditional;

	// Token: 0x0400158A RID: 5514
	public bool IsLockInput;

	// Token: 0x0400158B RID: 5515
	public bool IsModifiedArmLength;

	// Token: 0x0400158C RID: 5516
	public bool IsModifiedArmRotation;

	// Token: 0x0400158D RID: 5517
	public bool IsModifiedArmRotationPitch;

	// Token: 0x0400158E RID: 5518
	public bool IsModifiedArmRotationRoll;

	// Token: 0x0400158F RID: 5519
	public bool IsModifiedArmRotationYaw;

	// Token: 0x04001590 RID: 5520
	public bool IsModifiedCameraFov;

	// Token: 0x04001591 RID: 5521
	public bool IsModifiedCameraOffset;

	// Token: 0x04001592 RID: 5522
	public bool IsModifiedCameraOffsetX;

	// Token: 0x04001593 RID: 5523
	public bool IsModifiedCameraOffsetY;

	// Token: 0x04001594 RID: 5524
	public bool IsModifiedCameraOffsetZ;

	// Token: 0x04001595 RID: 5525
	public bool IsModifiedCameraLens;

	// Token: 0x04001596 RID: 5526
	public bool OverrideCameraInput;

	// Token: 0x04001597 RID: 5527
	public bool ResetFinalArmLength;

	// Token: 0x04001598 RID: 5528
	public bool IsResetFinalArmLengthToSpecificValue;

	// Token: 0x04001599 RID: 5529
	public float ResetFinalArmLengthToSpecificValue;

	// Token: 0x0400159A RID: 5530
	public bool IsResetFinalArmLengthToDynamicValue;

	// Token: 0x0400159B RID: 5531
	[Nullable(1)]
	public List<ResetFinalArmLengthToDynamicValueData> ResetFinalArmLengthToDynamicValueList = new List<ResetFinalArmLengthToDynamicValueData>();

	// Token: 0x0400159C RID: 5532
	public bool ResetFinalArmRotation;

	// Token: 0x0400159D RID: 5533
	public bool IsResetFinalArmRotationToSpecificPitch;

	// Token: 0x0400159E RID: 5534
	public float ResetFinalArmRotationToSpecificPitch;

	// Token: 0x0400159F RID: 5535
	public bool IsResetFinalArmRotationToSpecificYaw;

	// Token: 0x040015A0 RID: 5536
	public float ResetFinalArmRotationToSpecificYaw;

	// Token: 0x040015A1 RID: 5537
	public bool StopModifyOnMontageEnd;

	// Token: 0x040015A2 RID: 5538
	public bool StopModifyOnZoomInput;

	// Token: 0x040015A3 RID: 5539
	public bool IsLerpArmLocation;

	// Token: 0x040015A4 RID: 5540
	public bool IsSwitchModifier;

	// Token: 0x040015A5 RID: 5541
	public bool IsUseArmLengthFloatCurve;

	// Token: 0x040015A6 RID: 5542
	public CurveBase ArmLengthFloatCurve;

	// Token: 0x040015A7 RID: 5543
	public bool IsUseArmRotationFloatCurve;

	// Token: 0x040015A8 RID: 5544
	public CurveBase ArmRotationFloatCurve;

	// Token: 0x040015A9 RID: 5545
	public bool IsUseFovFloatCurve;

	// Token: 0x040015AA RID: 5546
	public CurveBase FovFloatCurve;

	// Token: 0x040015AB RID: 5547
	public bool IsUseLensFloatCurve;

	// Token: 0x040015AC RID: 5548
	public CurveBase LensFloatCurve;

	// Token: 0x040015AD RID: 5549
	public SCameraModifier_Lens CameraLens;

	// Token: 0x040015AE RID: 5550
	public bool IsForcePlayModify;

	// Token: 0x040015AF RID: 5551
	public bool IsUseCameraOffsetFloatCurve;

	// Token: 0x040015B0 RID: 5552
	public CurveBase CameraOffsetFloatCurve;

	// Token: 0x040015B1 RID: 5553
	public bool IsModifiedArmOffset;

	// Token: 0x040015B2 RID: 5554
	[Nullable(1)]
	public Vector ArmOffset = Vector.Create();

	// Token: 0x040015B3 RID: 5555
	public bool IsUseArmOffsetFloatCurve;

	// Token: 0x040015B4 RID: 5556
	public CurveBase ArmOffsetFloatCurve;

	// Token: 0x040015B5 RID: 5557
	public IModifyParamEvaluator ArmRotationPitchEval;

	// Token: 0x040015B6 RID: 5558
	public IModifyParamEvaluator ArmRotationYawEval;

	// Token: 0x040015B7 RID: 5559
	public IModifyParamEvaluator ArmRotationRollEval;

	// Token: 0x040015B8 RID: 5560
	public IModifyParamEvaluator ArmRotationAdditionalPitchEval;

	// Token: 0x040015B9 RID: 5561
	public IModifyParamEvaluator ArmRotationAdditionalYawEval;

	// Token: 0x040015BA RID: 5562
	public IModifyParamEvaluator ArmRotationAdditionalRollEval;

	// Token: 0x040015BB RID: 5563
	public IVectorParamEvaluator CameraOffsetEval;

	// Token: 0x040015BC RID: 5564
	public IVectorParamEvaluator CameraOffsetAdditionalEval;
}
