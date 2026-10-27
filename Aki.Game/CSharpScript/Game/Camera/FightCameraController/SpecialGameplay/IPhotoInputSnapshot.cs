using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F0 RID: 29424
	public interface IPhotoInputSnapshot
	{
		// Token: 0x17009F4C RID: 40780
		// (get) Token: 0x0604834D RID: 295757
		// (set) Token: 0x0604834E RID: 295758
		float MoveForward { get; set; }

		// Token: 0x17009F4D RID: 40781
		// (get) Token: 0x0604834F RID: 295759
		// (set) Token: 0x06048350 RID: 295760
		float MoveRight { get; set; }

		// Token: 0x17009F4E RID: 40782
		// (get) Token: 0x06048351 RID: 295761
		// (set) Token: 0x06048352 RID: 295762
		float MoveUp { get; set; }

		// Token: 0x17009F4F RID: 40783
		// (get) Token: 0x06048353 RID: 295763
		// (set) Token: 0x06048354 RID: 295764
		float Pitch { get; set; }

		// Token: 0x17009F50 RID: 40784
		// (get) Token: 0x06048355 RID: 295765
		// (set) Token: 0x06048356 RID: 295766
		float Yaw { get; set; }

		// Token: 0x17009F51 RID: 40785
		// (get) Token: 0x06048357 RID: 295767
		// (set) Token: 0x06048358 RID: 295768
		float Roll { get; set; }

		// Token: 0x17009F52 RID: 40786
		// (get) Token: 0x06048359 RID: 295769
		// (set) Token: 0x0604835A RID: 295770
		float Fov { get; set; }
	}
}
