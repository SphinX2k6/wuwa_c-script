using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B81 RID: 27521
	public class LevelEventSetupSeqCamera : LevelEventBase
	{
		// Token: 0x0604426C RID: 279148 RVA: 0x010CAAED File Offset: 0x010C8CED
		public LevelEventSetupSeqCamera(int id) : base(id)
		{
		}

		// Token: 0x0604426D RID: 279149 RVA: 0x010CAAF8 File Offset: 0x010C8CF8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Sequence;
			if (!(cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null))
			{
				return;
			}
			ActionSetSeqCameraTransform actionSetSeqCameraTransform = inParams as ActionSetSeqCameraTransform;
			BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.SequenceCamera.GetComponent<SequenceCameraDisplayComponent>().CineCamera;
			UCineCameraComponent ucineCameraComponent = cineCamera.CameraComponent as UCineCameraComponent;
			if (!ObjectUtils.IsValid(cineCamera))
			{
				return;
			}
			AActor actor = cineCamera;
			FTransformDouble ftransformDouble = actionSetSeqCameraTransform.Transform.ToUeTransform();
			actor.D_K2_SetActorTransform(ftransformDouble, false, null, false);
			if (actionSetSeqCameraTransform.Aperture != null)
			{
				ucineCameraComponent.CurrentAperture = actionSetSeqCameraTransform.Aperture.Value;
			}
			if (actionSetSeqCameraTransform.FocalLength != null)
			{
				ucineCameraComponent.CurrentFocalLength = actionSetSeqCameraTransform.FocalLength.Value;
			}
			if (actionSetSeqCameraTransform.FocusDistance != null)
			{
				ucineCameraComponent.FocusSettings.ManualFocusDistance = actionSetSeqCameraTransform.FocusDistance.Value;
			}
		}
	}
}
