using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02001A3F RID: 6719
public class FightCameraHandler : PhotoCameraHandler
{
	// Token: 0x060108FC RID: 67836 RVA: 0x004D8BE8 File Offset: 0x004D6DE8
	[NullableContext(1)]
	public void Init(ACameraActor cameraActor)
	{
		UCameraComponent cameraComponent = cameraActor.CameraComponent;
		this.CameraInitializeFovInner = cameraComponent.FieldOfView;
		this.SourceMaxPitch = ConfigCommonParamById.GetIntConfig("CameraSourceMaxPitch").Value;
		this.SourceMinPitch = ConfigCommonParamById.GetIntConfig("CameraSourceMinPitch").Value;
		this.MinFov = ConfigCommonParamById.GetIntConfig("CaptureCollectCameraMinFov").Value;
		this.MaxFov = ConfigCommonParamById.GetIntConfig("CaptureCollectCameraMaxFov").Value;
	}

	// Token: 0x060108FD RID: 67837 RVA: 0x004D8C68 File Offset: 0x004D6E68
	public override void Clear()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.DesiredCamera.Fov = this.CameraInitializeFovInner;
		this.ClearInput();
	}

	// Token: 0x060108FE RID: 67838 RVA: 0x004D8C94 File Offset: 0x004D6E94
	public override float GetCameraInitializeFov()
	{
		return this.CameraInitializeFovInner;
	}

	// Token: 0x060108FF RID: 67839 RVA: 0x004D8C9C File Offset: 0x004D6E9C
	public override void SetFov(float fov)
	{
		float fov2 = MathUtils.Instance.Clamp(fov, (float)this.MinFov, (float)this.MaxFov);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.DesiredCamera.Fov = fov2;
	}

	// Token: 0x06010900 RID: 67840 RVA: 0x004D8CE4 File Offset: 0x004D6EE4
	public override void AddPitchInput(float pitch)
	{
		if (pitch == 0f)
		{
			return;
		}
		float pitch2 = CameraController.Instance.GetMainPlayerCameraManager().GetCameraRotation().Pitch;
		if (pitch > 0f && pitch2 >= (float)this.SourceMaxPitch)
		{
			return;
		}
		if (pitch < 0f && pitch2 <= (float)this.SourceMinPitch)
		{
			return;
		}
		this.PitchInput = pitch;
	}

	// Token: 0x06010901 RID: 67841 RVA: 0x004D8D3C File Offset: 0x004D6F3C
	public override void AddYawInput(float yaw)
	{
		if (yaw == 0f)
		{
			return;
		}
		this.YawInput = yaw;
	}

	// Token: 0x06010902 RID: 67842 RVA: 0x004D8D50 File Offset: 0x004D6F50
	public override void ApplyCameraDelta()
	{
		if (this.PitchInput == 0f && this.YawInput == 0f)
		{
			return;
		}
		if (Global.BaseCharacter == null)
		{
			return;
		}
		Entity entityNoBlueprint = Global.BaseCharacter.GetEntityNoBlueprint();
		CharacterInputComponent characterInputComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterInputComponent>() : null;
		if (characterInputComponent != null)
		{
			characterInputComponent.HandleInputAxis(EInputAxis.LookUp, -this.PitchInput);
			characterInputComponent.HandleInputAxis(EInputAxis.Turn, this.YawInput);
		}
		this.PitchInput = 0f;
		this.YawInput = 0f;
	}

	// Token: 0x06010903 RID: 67843 RVA: 0x004D8DD4 File Offset: 0x004D6FD4
	public override void ClearInput()
	{
		this.PitchInput = 0f;
		this.YawInput = 0f;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterInputComponent characterInputComponent;
		if (baseCharacter == null)
		{
			characterInputComponent = null;
		}
		else
		{
			Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
			characterInputComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterInputComponent>() : null);
		}
		CharacterInputComponent characterInputComponent2 = characterInputComponent;
		if (characterInputComponent2 != null)
		{
			characterInputComponent2.ClearSingleAxisInput(EInputAxis.LookUp, false);
			characterInputComponent2.ClearSingleAxisInput(EInputAxis.Turn, false);
		}
	}

	// Token: 0x040092AC RID: 37548
	private float CameraInitializeFovInner;

	// Token: 0x040092AD RID: 37549
	private int MinFov = 60;

	// Token: 0x040092AE RID: 37550
	private int MaxFov = 90;

	// Token: 0x040092AF RID: 37551
	private float PitchInput;

	// Token: 0x040092B0 RID: 37552
	private float YawInput;

	// Token: 0x040092B1 RID: 37553
	private int SourceMaxPitch;

	// Token: 0x040092B2 RID: 37554
	private int SourceMinPitch;
}
