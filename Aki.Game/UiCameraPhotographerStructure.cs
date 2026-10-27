using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002C50 RID: 11344
[NullableContext(2)]
[Nullable(0)]
public class UiCameraPhotographerStructure : UiCameraStructure
{
	// Token: 0x06017AA2 RID: 96930 RVA: 0x00605374 File Offset: 0x00603574
	protected override AActor OnSpawnStructureActor()
	{
		FQuat fquat = new FQuat(0f, 0f, 0f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		FTransformDouble transform = new FTransformDouble(ref fquat, ref fvectorDouble, ref fvector);
		this.Photographer = ActorSystem.Instance.Get<TsPhotographer>(TsPhotographer.StaticClass(), transform, null, true);
		this.Photographer.SetTickableWhenPaused(true);
		this.Photographer.SetActorTickEnabled(true);
		this.Photographer.Initialize();
		this.Photographer.CameraArm.SetTickableWhenPaused(true);
		return this.Photographer;
	}

	// Token: 0x06017AA3 RID: 96931 RVA: 0x00605444 File Offset: 0x00603644
	protected override USpringArmComponent OnSetSpringArmComponent()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return null;
		}
		return photographer.CameraArm;
	}

	// Token: 0x06017AA4 RID: 96932 RVA: 0x00605457 File Offset: 0x00603657
	protected override void OnDestroy()
	{
		this.DestroyPhotographer();
	}

	// Token: 0x06017AA5 RID: 96933 RVA: 0x00605460 File Offset: 0x00603660
	protected override void OnActivate()
	{
		AActor fightCameraActor = this.GetFightCameraActor();
		FightCameraLogicComponent fightCameraLogicComponent = this.GetFightCameraLogicComponent();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		fightCameraLogicComponent.SetIsDitherEffectEnable(false);
		baseCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
		FVectorDouble playerSourceLocation = baseCharacter.Mesh.D_GetSocketLocation(PhotographDefine.SPAWN_SOCKET_NAME);
		FTransformDouble cameraInitializeTransform = fightCameraActor.D_GetTransform();
		this.Photographer.SetPlayerSourceLocation(playerSourceLocation);
		this.Photographer.SetCameraInitializeTransform(cameraInitializeTransform);
		this.Photographer.ActivateCamera(this.CameraActor);
	}

	// Token: 0x06017AA6 RID: 96934 RVA: 0x006054D1 File Offset: 0x006036D1
	protected override void OnDeactivate()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.DeactivateCamera();
	}

	// Token: 0x06017AA7 RID: 96935 RVA: 0x006054E3 File Offset: 0x006036E3
	private void DestroyPhotographer()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer != null && photographer.IsValid())
		{
			this.Photographer.DeactivateCamera();
			ActorSystem.Instance.Put("UiCameraPhotographerStructure.DestroyPhotographer", this.Photographer, null);
		}
		this.Photographer = null;
	}

	// Token: 0x06017AA8 RID: 96936 RVA: 0x00605524 File Offset: 0x00603724
	private FightCameraLogicComponent GetFightCameraLogicComponent()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		return fightCamera.GetComponent<FightCameraLogicComponent>();
	}

	// Token: 0x06017AA9 RID: 96937 RVA: 0x0060554C File Offset: 0x0060374C
	private ACameraActor GetFightCameraActor()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		FightCameraDisplayComponent component = fightCamera.GetComponent<FightCameraDisplayComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component.CameraActor;
	}

	// Token: 0x06017AAA RID: 96938 RVA: 0x0060558E File Offset: 0x0060378E
	public void SetPlayerSourceLocation(FVectorDouble location)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetPlayerSourceLocation(location);
	}

	// Token: 0x06017AAB RID: 96939 RVA: 0x006055A1 File Offset: 0x006037A1
	public void SetCameraInitializeTransform(FTransformDouble transform)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetCameraInitializeTransform(transform);
	}

	// Token: 0x06017AAC RID: 96940 RVA: 0x006055B4 File Offset: 0x006037B4
	public FTransformDouble GetCameraInitializeTransform()
	{
		return this.Photographer.GetCameraInitializeTransform();
	}

	// Token: 0x06017AAD RID: 96941 RVA: 0x006055C1 File Offset: 0x006037C1
	public void SetCameraInitializeFov(int fov)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetCameraInitializeFov((float)fov);
	}

	// Token: 0x06017AAE RID: 96942 RVA: 0x006055D5 File Offset: 0x006037D5
	public float GetCameraInitialFov()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return 0f;
		}
		return photographer.GetCameraInitializeFov();
	}

	// Token: 0x06017AAF RID: 96943 RVA: 0x006055EC File Offset: 0x006037EC
	public void SetCameraTransform(FTransform transform)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetCameraTransform(transform);
	}

	// Token: 0x06017AB0 RID: 96944 RVA: 0x006055FF File Offset: 0x006037FF
	public void MoveUp(float addValue)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.MoveUp(addValue);
	}

	// Token: 0x06017AB1 RID: 96945 RVA: 0x00605612 File Offset: 0x00603812
	public void MoveRight(float addValue)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.MoveRight(addValue);
	}

	// Token: 0x06017AB2 RID: 96946 RVA: 0x00605625 File Offset: 0x00603825
	public void MoveForward(float addValue)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.MoveForward(addValue);
	}

	// Token: 0x06017AB3 RID: 96947 RVA: 0x00605638 File Offset: 0x00603838
	public void AddCameraArmPitchInput(float pitch)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.AddCameraArmPitchInput(pitch);
	}

	// Token: 0x06017AB4 RID: 96948 RVA: 0x0060564B File Offset: 0x0060384B
	public void AddCameraArmYawInput(float yaw)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.AddCameraArmYawInput(yaw);
	}

	// Token: 0x06017AB5 RID: 96949 RVA: 0x0060565E File Offset: 0x0060385E
	public void SetCameraArmRoll(float roll)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetCameraArmRoll(roll);
	}

	// Token: 0x06017AB6 RID: 96950 RVA: 0x00605671 File Offset: 0x00603871
	public void SetFov(int fov)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetFov((float)fov);
	}

	// Token: 0x06017AB7 RID: 96951 RVA: 0x00605685 File Offset: 0x00603885
	public float GetFov()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return 0f;
		}
		return photographer.GetFov();
	}

	// Token: 0x06017AB8 RID: 96952 RVA: 0x0060569C File Offset: 0x0060389C
	public void ResetCamera()
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.ResetCamera();
	}

	// Token: 0x06017AB9 RID: 96953 RVA: 0x006056AE File Offset: 0x006038AE
	public void SetCameraArmTargetOffset(FVectorDouble cameraLocation, bool isInit = false)
	{
		TsPhotographer photographer = this.Photographer;
		if (photographer == null)
		{
			return;
		}
		photographer.SetCameraArmTargetOffset(cameraLocation, isInit);
	}

	// Token: 0x06017ABA RID: 96954 RVA: 0x006056C2 File Offset: 0x006038C2
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

	// Token: 0x0400B069 RID: 45161
	private TsPhotographer Photographer;
}
