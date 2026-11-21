using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x02001A94 RID: 6804
public class PhotoLensPart : IPhotoSnapshotPart
{
	// Token: 0x06010D32 RID: 68914 RVA: 0x004EF3A8 File Offset: 0x004ED5A8
	[NullableContext(1)]
	public PhotoCameraLensState ToLensState()
	{
		return new PhotoCameraLensState
		{
			Fov = this.Fov,
			MoveOffsetX = this.MoveOffsetX,
			MoveOffsetY = this.MoveOffsetY,
			MoveOffsetZ = this.MoveOffsetZ,
			Pitch = this.Pitch,
			Yaw = this.Yaw,
			Roll = this.Roll
		};
	}

	// Token: 0x06010D33 RID: 68915 RVA: 0x004EF410 File Offset: 0x004ED610
	[NullableContext(1)]
	public void FromLensState(PhotoCameraLensState state)
	{
		this.Fov = state.Fov;
		this.MoveOffsetX = state.MoveOffsetX;
		this.MoveOffsetY = state.MoveOffsetY;
		this.MoveOffsetZ = state.MoveOffsetZ;
		this.Pitch = state.Pitch;
		this.Yaw = state.Yaw;
		this.Roll = state.Roll;
	}

	// Token: 0x06010D34 RID: 68916 RVA: 0x004EF474 File Offset: 0x004ED674
	public void Capture()
	{
		PhotoCameraLogicComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
		if (photoCameraComponent == null)
		{
			return;
		}
		this.FromLensState(photoCameraComponent.GetLensState());
	}

	// Token: 0x06010D35 RID: 68917 RVA: 0x004EF49D File Offset: 0x004ED69D
	public void Apply()
	{
	}

	// Token: 0x040094B7 RID: 38071
	public float Fov;

	// Token: 0x040094B8 RID: 38072
	public float MoveOffsetX;

	// Token: 0x040094B9 RID: 38073
	public float MoveOffsetY;

	// Token: 0x040094BA RID: 38074
	public float MoveOffsetZ;

	// Token: 0x040094BB RID: 38075
	public float Pitch;

	// Token: 0x040094BC RID: 38076
	public float Yaw;

	// Token: 0x040094BD RID: 38077
	public float Roll;
}
