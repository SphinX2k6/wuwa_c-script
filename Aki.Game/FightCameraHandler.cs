using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02002554 RID: 9556
public class FightCameraHandler : PhotoCameraHandler
{
	// Token: 0x0601341C RID: 78876 RVA: 0x004CA068 File Offset: 0x004C8268
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

	// Token: 0x0601341D RID: 78877 RVA: 0x004CA0E8 File Offset: 0x004C82E8
	public override void Clear()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.DesiredCamera.Fov = this.CameraInitializeFovInner;
		this.ClearInput();
	}

	// Token: 0x0601341E RID: 78878 RVA: 0x004CA114 File Offset: 0x004C8314
	public override float GetCameraInitializeFov()
	{
		return this.CameraInitializeFovInner;
	}

	// Token: 0x0601341F RID: 78879 RVA: 0x004CA11C File Offset: 0x004C831C
	public override void SetFov(float fov)
	{
		float fov2 = MathUtils.Instance.Clamp(fov, (float)this.MinFov, (float)this.MaxFov);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.DesiredCamera.Fov = fov2;
	}

	// Token: 0x06013420 RID: 78880 RVA: 0x004CA164 File Offset: 0x004C8364
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

	// Token: 0x06013421 RID: 78881 RVA: 0x004CA1BC File Offset: 0x004C83BC
	public override void AddYawInput(float yaw)
	{
		if (yaw == 0f)
		{
			return;
		}
		this.YawInput = yaw;
	}

	// Token: 0x06013422 RID: 78882 RVA: 0x004CA1D0 File Offset: 0x004C83D0
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

	// Token: 0x06013423 RID: 78883 RVA: 0x004CA254 File Offset: 0x004C8454
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

	// Token: 0x04009153 RID: 37203
	private float CameraInitializeFovInner;

	// Token: 0x04009154 RID: 37204
	private int MinFov = 60;

	// Token: 0x04009155 RID: 37205
	private int MaxFov = 90;

	// Token: 0x04009156 RID: 37206
	private float PitchInput;

	// Token: 0x04009157 RID: 37207
	private float YawInput;

	// Token: 0x04009158 RID: 37208
	private int SourceMaxPitch;

	// Token: 0x04009159 RID: 37209
	private int SourceMinPitch;
}
