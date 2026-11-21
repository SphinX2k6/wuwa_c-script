using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006473 RID: 25715
	public interface IPhotoInputSnapshot
	{
		// Token: 0x170076EA RID: 30442
		// (get) Token: 0x0603E799 RID: 255897
		// (set) Token: 0x0603E79A RID: 255898
		float MoveForward { get; set; }

		// Token: 0x170076EB RID: 30443
		// (get) Token: 0x0603E79B RID: 255899
		// (set) Token: 0x0603E79C RID: 255900
		float MoveRight { get; set; }

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x0603E79D RID: 255901
		// (set) Token: 0x0603E79E RID: 255902
		float MoveUp { get; set; }

		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x0603E79F RID: 255903
		// (set) Token: 0x0603E7A0 RID: 255904
		float Pitch { get; set; }

		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x0603E7A1 RID: 255905
		// (set) Token: 0x0603E7A2 RID: 255906
		float Yaw { get; set; }

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x0603E7A3 RID: 255907
		// (set) Token: 0x0603E7A4 RID: 255908
		float Roll { get; set; }

		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x0603E7A5 RID: 255909
		// (set) Token: 0x0603E7A6 RID: 255910
		float Fov { get; set; }
	}
}
