using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BC RID: 29628
	public class ITeleportTransitionWithMp4T
	{
		// Token: 0x1700E0F8 RID: 57592
		// (get) Token: 0x06035CCA RID: 220362 RVA: 0x00752971 File Offset: 0x00750B71
		// (set) Token: 0x06035CCB RID: 220363 RVA: 0x00752979 File Offset: 0x00750B79
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0F9 RID: 57593
		// (get) Token: 0x06035CCC RID: 220364 RVA: 0x00752982 File Offset: 0x00750B82
		// (set) Token: 0x06035CCD RID: 220365 RVA: 0x0075298A File Offset: 0x00750B8A
		public string Mp4Path { get; set; }

		// Token: 0x1700E0FA RID: 57594
		// (get) Token: 0x06035CCE RID: 220366 RVA: 0x00752993 File Offset: 0x00750B93
		// (set) Token: 0x06035CCF RID: 220367 RVA: 0x0075299B File Offset: 0x00750B9B
		public bool IsFadeInScreenAfterTeleport { get; set; }

		// Token: 0x1700E0FB RID: 57595
		// (get) Token: 0x06035CD0 RID: 220368 RVA: 0x007529A4 File Offset: 0x00750BA4
		// (set) Token: 0x06035CD1 RID: 220369 RVA: 0x007529AC File Offset: 0x00750BAC
		public bool ReplayWhenReLogin { get; set; }

		// Token: 0x1700E0FC RID: 57596
		// (get) Token: 0x06035CD2 RID: 220370 RVA: 0x007529B5 File Offset: 0x00750BB5
		// (set) Token: 0x06035CD3 RID: 220371 RVA: 0x007529BD File Offset: 0x00750BBD
		public IMp4BackgroundColorT BackgroundColor { get; set; }

		// Token: 0x1700E0FD RID: 57597
		// (get) Token: 0x06035CD4 RID: 220372 RVA: 0x007529C6 File Offset: 0x00750BC6
		// (set) Token: 0x06035CD5 RID: 220373 RVA: 0x007529CE File Offset: 0x00750BCE
		public EAfterTeleportScreenColor AfterTeleportScreenColor { get; set; }

		// Token: 0x1700E0FE RID: 57598
		// (get) Token: 0x06035CD6 RID: 220374 RVA: 0x007529D7 File Offset: 0x00750BD7
		// (set) Token: 0x06035CD7 RID: 220375 RVA: 0x007529DF File Offset: 0x00750BDF
		public byte NullMask { get; set; }

		// Token: 0x06035CD8 RID: 220376 RVA: 0x007529E8 File Offset: 0x00750BE8
		public ITeleportTransitionWithMp4T()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.Mp4Path = null;
			this.IsFadeInScreenAfterTeleport = false;
			this.ReplayWhenReLogin = false;
			this.BackgroundColor = new IMp4BackgroundColorT();
			this.AfterTeleportScreenColor = EAfterTeleportScreenColor.Black;
			this.NullMask = 0;
		}
	}
}
