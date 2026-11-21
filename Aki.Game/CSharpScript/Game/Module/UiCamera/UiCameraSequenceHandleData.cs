using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003999 RID: 14745
	[NullableContext(2)]
	[Nullable(0)]
	public class UiCameraSequenceHandleData : UiCameraConfigHandleData
	{
		// Token: 0x06025FA8 RID: 155560 RVA: 0x00AA8AA3 File Offset: 0x00AA6CA3
		[NullableContext(1)]
		internal void SetSequenceCameraData(SeqCameraThings sequenceCameraData)
		{
			this.SequenceCameraData = sequenceCameraData;
			this.SequenceHandleName = base.GetHandleName();
			this.SequenceFocalRegion = 0f;
			this.SequencePostProcessBlendWeight = null;
		}

		// Token: 0x06025FA9 RID: 155561 RVA: 0x00AA8ACF File Offset: 0x00AA6CCF
		internal void ClearSequenceCameraData()
		{
			this.SequenceCameraData = null;
			this.SequenceHandleName = string.Empty;
			this.SequenceFocalRegion = 0f;
			this.SequencePostProcessBlendWeight = null;
			this.ReplaceCameraComponent = null;
		}

		// Token: 0x06025FAA RID: 155562 RVA: 0x00AA8B04 File Offset: 0x00AA6D04
		internal bool RefreshCameraSequenceData(ACameraActor cameraActor, UCineCameraComponent cameraComponent)
		{
			if (cameraActor == null || !cameraActor.IsValid() || (cameraComponent == null || !cameraComponent.IsValid()))
			{
				return false;
			}
			SeqCameraThings sequenceCameraData = new SeqCameraThings
			{
				CameraLocation = cameraActor.D_K2_GetActorLocation(),
				CameraRotation = cameraActor.K2_GetActorRotation(),
				FieldOfView = cameraComponent.FieldOfView,
				FocusSettings = cameraComponent.FocusSettings,
				CurrentAperture = cameraComponent.CurrentAperture,
				CurrentFocalLength = cameraComponent.CurrentFocalLength
			};
			this.SetSequenceCameraData(sequenceCameraData);
			this.SequenceFocalRegion = cameraComponent.CurrentFocalRegion;
			this.SequencePostProcessBlendWeight = new float?(cameraComponent.PostProcessBlendWeight);
			return true;
		}

		// Token: 0x06025FAB RID: 155563 RVA: 0x00AA8BA8 File Offset: 0x00AA6DA8
		public SeqCameraThings GetSequenceCameraData()
		{
			if (this.SequenceHandleName != base.GetHandleName())
			{
				return null;
			}
			return this.SequenceCameraData;
		}

		// Token: 0x06025FAC RID: 155564 RVA: 0x00AA8BC8 File Offset: 0x00AA6DC8
		[NullableContext(1)]
		public override bool Refresh(UiCameraModel model)
		{
			if (this.SequenceHandleName != base.GetHandleName())
			{
				this.ClearSequenceCameraData();
			}
			if (!base.RefreshConfigData(model))
			{
				return false;
			}
			this.ReplaceCameraComponent = this.FindReplaceCameraComponent();
			if (base.CameraSettings == null || this.SequenceCameraData == null)
			{
				return false;
			}
			base.RefreshCommonCameraData(base.CameraSettings);
			base.Location = this.SequenceCameraData.CameraLocation;
			base.Rotation = this.SequenceCameraData.CameraRotation;
			base.ArmLength = 0f;
			base.ArmOffsetLocation = FVectorDouble.ZeroVector;
			base.ArmOffsetRotation = FRotator.ZeroRotator;
			base.ArmCollisionTest = false;
			base.FieldOfView = this.SequenceCameraData.FieldOfView;
			FCameraFocusSettings focusSettings = this.SequenceCameraData.FocusSettings;
			base.FocalDistance = ((focusSettings != null) ? focusSettings.ManualFocusDistance : base.CameraSettings.FocalDistance);
			base.Aperture = this.SequenceCameraData.CurrentAperture;
			base.FocalRegion = this.SequenceFocalRegion;
			if (this.SequencePostProcessBlendWeight != null)
			{
				base.PostProcessBlendWeight = this.SequencePostProcessBlendWeight.Value;
			}
			else
			{
				UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
				if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
				{
					base.PostProcessBlendWeight = this.ReplaceCameraComponent.PostProcessBlendWeight;
				}
			}
			return true;
		}

		// Token: 0x06025FAD RID: 155565 RVA: 0x00AA8D10 File Offset: 0x00AA6F10
		private UCineCameraComponent FindReplaceCameraComponent()
		{
			SUiCameraAnimationSettings cameraSettings = base.CameraSettings;
			string text = (cameraSettings != null) ? cameraSettings.ReplaceCameraTag : null;
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClassWithTag(GlobalData.World, ACineCameraActor.StaticClass(), FNameUtil.GetDynamicFName(text).Value, ref tarray);
			if (tarray == null || tarray.Num() <= 0)
			{
				return null;
			}
			ACineCameraActor acineCameraActor = tarray.Get(0) as ACineCameraActor;
			if (acineCameraActor == null)
			{
				return null;
			}
			return acineCameraActor.GetCineCameraComponent();
		}

		// Token: 0x04014E19 RID: 85529
		private SeqCameraThings SequenceCameraData;

		// Token: 0x04014E1A RID: 85530
		private UCineCameraComponent ReplaceCameraComponent;

		// Token: 0x04014E1B RID: 85531
		[Nullable(1)]
		private string SequenceHandleName = string.Empty;

		// Token: 0x04014E1C RID: 85532
		private float SequenceFocalRegion;

		// Token: 0x04014E1D RID: 85533
		private float? SequencePostProcessBlendWeight;
	}
}
