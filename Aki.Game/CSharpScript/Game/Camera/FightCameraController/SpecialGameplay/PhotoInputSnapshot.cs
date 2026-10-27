using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F1 RID: 29425
	public class PhotoInputSnapshot : IPhotoInputSnapshot
	{
		// Token: 0x17009F53 RID: 40787
		// (get) Token: 0x0604835B RID: 295771 RVA: 0x0128C8E5 File Offset: 0x0128AAE5
		// (set) Token: 0x0604835C RID: 295772 RVA: 0x0128C8ED File Offset: 0x0128AAED
		public float MoveForward { get; set; }

		// Token: 0x17009F54 RID: 40788
		// (get) Token: 0x0604835D RID: 295773 RVA: 0x0128C8F6 File Offset: 0x0128AAF6
		// (set) Token: 0x0604835E RID: 295774 RVA: 0x0128C8FE File Offset: 0x0128AAFE
		public float MoveRight { get; set; }

		// Token: 0x17009F55 RID: 40789
		// (get) Token: 0x0604835F RID: 295775 RVA: 0x0128C907 File Offset: 0x0128AB07
		// (set) Token: 0x06048360 RID: 295776 RVA: 0x0128C90F File Offset: 0x0128AB0F
		public float MoveUp { get; set; }

		// Token: 0x17009F56 RID: 40790
		// (get) Token: 0x06048361 RID: 295777 RVA: 0x0128C918 File Offset: 0x0128AB18
		// (set) Token: 0x06048362 RID: 295778 RVA: 0x0128C920 File Offset: 0x0128AB20
		public float Pitch { get; set; }

		// Token: 0x17009F57 RID: 40791
		// (get) Token: 0x06048363 RID: 295779 RVA: 0x0128C929 File Offset: 0x0128AB29
		// (set) Token: 0x06048364 RID: 295780 RVA: 0x0128C931 File Offset: 0x0128AB31
		public float Yaw { get; set; }

		// Token: 0x17009F58 RID: 40792
		// (get) Token: 0x06048365 RID: 295781 RVA: 0x0128C93A File Offset: 0x0128AB3A
		// (set) Token: 0x06048366 RID: 295782 RVA: 0x0128C942 File Offset: 0x0128AB42
		public float Roll { get; set; }

		// Token: 0x17009F59 RID: 40793
		// (get) Token: 0x06048367 RID: 295783 RVA: 0x0128C94B File Offset: 0x0128AB4B
		// (set) Token: 0x06048368 RID: 295784 RVA: 0x0128C953 File Offset: 0x0128AB53
		public float Fov { get; set; }
	}
}
