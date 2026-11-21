using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

// Token: 0x02000211 RID: 529
internal class GazeParams
{
	// Token: 0x06002152 RID: 8530 RVA: 0x000B82C8 File Offset: 0x000B64C8
	[NullableContext(1)]
	public GazeParams(GrapplingHookPointComponent grapplingPoint, bool useGaze2 = false)
	{
		if (useGaze2)
		{
			IGazeNextPointAfterInteract gazeNextPointAfterInteract = grapplingPoint.GazeNextPointAfterInteract;
			this.LockCamera = ((gazeNextPointAfterInteract != null) ? gazeNextPointAfterInteract.GazePerformance.LockCamera : null).GetValueOrDefault();
			IGazeNextPointAfterInteract gazeNextPointAfterInteract2 = grapplingPoint.GazeNextPointAfterInteract;
			this.FadeInTime = ((gazeNextPointAfterInteract2 != null) ? gazeNextPointAfterInteract2.GazePerformance.FadeInTime : 0f);
			IGazeNextPointAfterInteract gazeNextPointAfterInteract3 = grapplingPoint.GazeNextPointAfterInteract;
			this.FadeOutTime = new float?(((gazeNextPointAfterInteract3 != null) ? gazeNextPointAfterInteract3.GazePerformance.FadeOutTime : null).GetValueOrDefault());
			IGazeNextPointAfterInteract gazeNextPointAfterInteract4 = grapplingPoint.GazeNextPointAfterInteract;
			this.StayTime = ((gazeNextPointAfterInteract4 != null) ? gazeNextPointAfterInteract4.GazePerformance.StayTime : 0f);
			return;
		}
		ICameraGaze cameraGaze = grapplingPoint.CameraGaze;
		this.LockCamera = ((cameraGaze != null) ? cameraGaze.LockCamera : null).GetValueOrDefault();
		ICameraGaze cameraGaze2 = grapplingPoint.CameraGaze;
		this.FadeInTime = ((cameraGaze2 != null) ? cameraGaze2.FadeInTime : 0f);
		ICameraGaze cameraGaze3 = grapplingPoint.CameraGaze;
		this.FadeOutTime = ((cameraGaze3 != null) ? cameraGaze3.FadeOutTime : null);
		ICameraGaze cameraGaze4 = grapplingPoint.CameraGaze;
		this.StayTime = ((cameraGaze4 != null) ? cameraGaze4.StayTime : 0f);
	}

	// Token: 0x040014E8 RID: 5352
	public bool LockCamera;

	// Token: 0x040014E9 RID: 5353
	public float FadeInTime;

	// Token: 0x040014EA RID: 5354
	public float? FadeOutTime;

	// Token: 0x040014EB RID: 5355
	public float StayTime;
}
