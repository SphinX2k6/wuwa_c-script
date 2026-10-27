using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x020025A9 RID: 9641
public class PhotoLensPart : IPhotoSnapshotPart
{
	// Token: 0x06013850 RID: 79952 RVA: 0x004E0874 File Offset: 0x004DEA74
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

	// Token: 0x06013851 RID: 79953 RVA: 0x004E08DC File Offset: 0x004DEADC
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

	// Token: 0x06013852 RID: 79954 RVA: 0x004E0940 File Offset: 0x004DEB40
	public void Capture()
	{
		PhotoCameraLogicComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
		if (photoCameraComponent == null)
		{
			return;
		}
		this.FromLensState(photoCameraComponent.GetLensState());
	}

	// Token: 0x06013853 RID: 79955 RVA: 0x004E0969 File Offset: 0x004DEB69
	public void Apply()
	{
	}

	// Token: 0x0400935F RID: 37727
	public float Fov;

	// Token: 0x04009360 RID: 37728
	public float MoveOffsetX;

	// Token: 0x04009361 RID: 37729
	public float MoveOffsetY;

	// Token: 0x04009362 RID: 37730
	public float MoveOffsetZ;

	// Token: 0x04009363 RID: 37731
	public float Pitch;

	// Token: 0x04009364 RID: 37732
	public float Yaw;

	// Token: 0x04009365 RID: 37733
	public float Roll;
}
