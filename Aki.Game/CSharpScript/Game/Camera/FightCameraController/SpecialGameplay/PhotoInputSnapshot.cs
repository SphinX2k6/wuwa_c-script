using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006474 RID: 25716
	public class PhotoInputSnapshot : IPhotoInputSnapshot
	{
		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x0603E7A7 RID: 255911 RVA: 0x0122F299 File Offset: 0x0122D499
		// (set) Token: 0x0603E7A8 RID: 255912 RVA: 0x0122F2A1 File Offset: 0x0122D4A1
		public float MoveForward { get; set; }

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x0603E7A9 RID: 255913 RVA: 0x0122F2AA File Offset: 0x0122D4AA
		// (set) Token: 0x0603E7AA RID: 255914 RVA: 0x0122F2B2 File Offset: 0x0122D4B2
		public float MoveRight { get; set; }

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x0603E7AB RID: 255915 RVA: 0x0122F2BB File Offset: 0x0122D4BB
		// (set) Token: 0x0603E7AC RID: 255916 RVA: 0x0122F2C3 File Offset: 0x0122D4C3
		public float MoveUp { get; set; }

		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x0603E7AD RID: 255917 RVA: 0x0122F2CC File Offset: 0x0122D4CC
		// (set) Token: 0x0603E7AE RID: 255918 RVA: 0x0122F2D4 File Offset: 0x0122D4D4
		public float Pitch { get; set; }

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x0603E7AF RID: 255919 RVA: 0x0122F2DD File Offset: 0x0122D4DD
		// (set) Token: 0x0603E7B0 RID: 255920 RVA: 0x0122F2E5 File Offset: 0x0122D4E5
		public float Yaw { get; set; }

		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x0603E7B1 RID: 255921 RVA: 0x0122F2EE File Offset: 0x0122D4EE
		// (set) Token: 0x0603E7B2 RID: 255922 RVA: 0x0122F2F6 File Offset: 0x0122D4F6
		public float Roll { get; set; }

		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x0603E7B3 RID: 255923 RVA: 0x0122F2FF File Offset: 0x0122D4FF
		// (set) Token: 0x0603E7B4 RID: 255924 RVA: 0x0122F307 File Offset: 0x0122D507
		public float Fov { get; set; }
	}
}
