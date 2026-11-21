using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003991 RID: 14737
	public class UiCameraPhotographerComponent : UiCameraComponent
	{
		// Token: 0x06025F25 RID: 155429 RVA: 0x00AA6EE7 File Offset: 0x00AA50E7
		protected override void OnEnterMode()
		{
			this.InitializePhotographer();
			if (base.Owner.CameraActor != null)
			{
				TsPhotographer photographer = this.Photographer;
				if (photographer == null)
				{
					return;
				}
				photographer.ActivateCamera(base.Owner.CameraActor);
			}
		}

		// Token: 0x06025F26 RID: 155430 RVA: 0x00AA6F17 File Offset: 0x00AA5117
		protected override void OnExitMode()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer != null)
			{
				photographer.DeactivateCamera();
			}
			this.DestroyPhotographer();
		}

		// Token: 0x06025F27 RID: 155431 RVA: 0x00AA6F30 File Offset: 0x00AA5130
		public void SetActorTransform(FTransformDouble transform)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.D_K2_SetActorTransform(transform, false, null, false);
		}

		// Token: 0x06025F28 RID: 155432 RVA: 0x00AA6F48 File Offset: 0x00AA5148
		public void SetActorRotation(FRotator rotation)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.K2_SetActorRotation(rotation, false);
		}

		// Token: 0x06025F29 RID: 155433 RVA: 0x00AA6F5D File Offset: 0x00AA515D
		public void SetPlayerSourceLocation(FVectorDouble location)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetPlayerSourceLocation(location);
		}

		// Token: 0x06025F2A RID: 155434 RVA: 0x00AA6F70 File Offset: 0x00AA5170
		public void SetCameraInitializeTransform(FTransformDouble transform)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetCameraInitializeTransform(transform);
		}

		// Token: 0x06025F2B RID: 155435 RVA: 0x00AA6F83 File Offset: 0x00AA5183
		public FTransformDouble GetCameraInitializeTransform()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return new FTransformDouble();
			}
			return photographer.GetCameraInitializeTransform();
		}

		// Token: 0x06025F2C RID: 155436 RVA: 0x00AA6F9A File Offset: 0x00AA519A
		public void SetCameraInitializeFov(int fieldOfView)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetCameraInitializeFov((float)fieldOfView);
		}

		// Token: 0x06025F2D RID: 155437 RVA: 0x00AA6FAE File Offset: 0x00AA51AE
		public float GetCameraInitialFov()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return 0f;
			}
			return photographer.GetCameraInitializeFov();
		}

		// Token: 0x06025F2E RID: 155438 RVA: 0x00AA6FC5 File Offset: 0x00AA51C5
		public void SetCameraArmTargetOffset(FVectorDouble location, bool isInit = false)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetCameraArmTargetOffset(location, isInit);
		}

		// Token: 0x06025F2F RID: 155439 RVA: 0x00AA6FD9 File Offset: 0x00AA51D9
		public void AddCameraArmPitchInput(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.AddCameraArmPitchInput(value);
		}

		// Token: 0x06025F30 RID: 155440 RVA: 0x00AA6FEC File Offset: 0x00AA51EC
		public void AddCameraArmYawInput(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.AddCameraArmYawInput(value);
		}

		// Token: 0x06025F31 RID: 155441 RVA: 0x00AA6FFF File Offset: 0x00AA51FF
		public void SetCameraArmRoll(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetCameraArmRoll(value);
		}

		// Token: 0x06025F32 RID: 155442 RVA: 0x00AA7012 File Offset: 0x00AA5212
		public void SetSpringArmLength(float length)
		{
			TsPhotographer photographer = this.Photographer;
			if (((photographer != null) ? photographer.CameraArm : null) != null)
			{
				this.Photographer.CameraArm.TargetArmLength = length;
			}
		}

		// Token: 0x06025F33 RID: 155443 RVA: 0x00AA7039 File Offset: 0x00AA5239
		public void MoveUp(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.MoveUp(value);
		}

		// Token: 0x06025F34 RID: 155444 RVA: 0x00AA704C File Offset: 0x00AA524C
		public void MoveRight(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.MoveRight(value);
		}

		// Token: 0x06025F35 RID: 155445 RVA: 0x00AA705F File Offset: 0x00AA525F
		public void MoveForward(float value)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.MoveForward(value);
		}

		// Token: 0x06025F36 RID: 155446 RVA: 0x00AA7072 File Offset: 0x00AA5272
		public void SetFov(int fieldOfView)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetFov((float)fieldOfView);
		}

		// Token: 0x06025F37 RID: 155447 RVA: 0x00AA7086 File Offset: 0x00AA5286
		public float GetFov()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return 0f;
			}
			return photographer.GetFov();
		}

		// Token: 0x06025F38 RID: 155448 RVA: 0x00AA709D File Offset: 0x00AA529D
		public void ResetCamera()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.ResetCamera();
		}

		// Token: 0x06025F39 RID: 155449 RVA: 0x00AA70AF File Offset: 0x00AA52AF
		[NullableContext(1)]
		public void SetCameraLUT(string texturePath)
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer == null)
			{
				return;
			}
			photographer.SetCameraLUT(texturePath);
		}

		// Token: 0x06025F3A RID: 155450 RVA: 0x00AA70C4 File Offset: 0x00AA52C4
		private void InitializePhotographer()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer != null && photographer.IsValid())
			{
				return;
			}
			FQuat fquat = new FQuat(0f, 0f, 0f, 0f);
			FVector fvector = new FVector(0f);
			FVector fvector2 = new FVector(1f, 1f, 1f);
			FTransform ftransform = new FTransform(ref fquat, ref fvector, ref fvector2);
			this.Photographer = (UGameplayStatics.BeginDeferredActorSpawnFromClass(GlobalData.World, TsPhotographer.StaticClass(), ftransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as TsPhotographer);
			if (this.Photographer == null)
			{
				return;
			}
			this.Photographer.SetTickableWhenPaused(true);
			UGameplayStatics.FinishSpawningActor(this.Photographer, ftransform);
			this.Photographer.Initialize();
		}

		// Token: 0x06025F3B RID: 155451 RVA: 0x00AA717D File Offset: 0x00AA537D
		private void DestroyPhotographer()
		{
			TsPhotographer photographer = this.Photographer;
			if (photographer != null && photographer.IsValid())
			{
				ActorSystem.Instance.Put("UiCameraPhotographerComponent.Destroy", this.Photographer, null);
			}
			this.Photographer = null;
		}

		// Token: 0x04014DF5 RID: 85493
		[Nullable(2)]
		private TsPhotographer Photographer;
	}
}
