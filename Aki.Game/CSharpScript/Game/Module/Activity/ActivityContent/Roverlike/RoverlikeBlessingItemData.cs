using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006185 RID: 24965
	public class RoverlikeBlessingItemData : IRoverlikeBlessingItemData
	{
		// Token: 0x170091C8 RID: 37320
		// (get) Token: 0x0603F174 RID: 258420 RVA: 0x00F3F0A9 File Offset: 0x00F3D2A9
		// (set) Token: 0x0603F175 RID: 258421 RVA: 0x00F3F0B1 File Offset: 0x00F3D2B1
		public int BlessId { get; set; }

		// Token: 0x170091C9 RID: 37321
		// (get) Token: 0x0603F176 RID: 258422 RVA: 0x00F3F0BA File Offset: 0x00F3D2BA
		// (set) Token: 0x0603F177 RID: 258423 RVA: 0x00F3F0C2 File Offset: 0x00F3D2C2
		public int? IncId { get; set; }

		// Token: 0x170091CA RID: 37322
		// (get) Token: 0x0603F178 RID: 258424 RVA: 0x00F3F0CB File Offset: 0x00F3D2CB
		// (set) Token: 0x0603F179 RID: 258425 RVA: 0x00F3F0D3 File Offset: 0x00F3D2D3
		public bool? AllowToggleInteract { get; set; }

		// Token: 0x170091CB RID: 37323
		// (get) Token: 0x0603F17A RID: 258426 RVA: 0x00F3F0DC File Offset: 0x00F3D2DC
		// (set) Token: 0x0603F17B RID: 258427 RVA: 0x00F3F0E4 File Offset: 0x00F3D2E4
		public bool? IsUp { get; set; }

		// Token: 0x170091CC RID: 37324
		// (get) Token: 0x0603F17C RID: 258428 RVA: 0x00F3F0ED File Offset: 0x00F3D2ED
		// (set) Token: 0x0603F17D RID: 258429 RVA: 0x00F3F0F5 File Offset: 0x00F3D2F5
		public bool? CheckSameSlot { get; set; }

		// Token: 0x170091CD RID: 37325
		// (get) Token: 0x0603F17E RID: 258430 RVA: 0x00F3F0FE File Offset: 0x00F3D2FE
		// (set) Token: 0x0603F17F RID: 258431 RVA: 0x00F3F106 File Offset: 0x00F3D306
		public bool? ShowRecommend { get; set; }
	}
}
