using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA3 RID: 31651
	public class ITeleportTransitionWithMp4T
	{
		// Token: 0x1700ED08 RID: 60680
		// (get) Token: 0x06039065 RID: 233573 RVA: 0x007B4EB1 File Offset: 0x007B30B1
		// (set) Token: 0x06039066 RID: 233574 RVA: 0x007B4EB9 File Offset: 0x007B30B9
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ED09 RID: 60681
		// (get) Token: 0x06039067 RID: 233575 RVA: 0x007B4EC2 File Offset: 0x007B30C2
		// (set) Token: 0x06039068 RID: 233576 RVA: 0x007B4ECA File Offset: 0x007B30CA
		public string Mp4Path { get; set; }

		// Token: 0x1700ED0A RID: 60682
		// (get) Token: 0x06039069 RID: 233577 RVA: 0x007B4ED3 File Offset: 0x007B30D3
		// (set) Token: 0x0603906A RID: 233578 RVA: 0x007B4EDB File Offset: 0x007B30DB
		public bool IsFadeInScreenAfterTeleport { get; set; }

		// Token: 0x1700ED0B RID: 60683
		// (get) Token: 0x0603906B RID: 233579 RVA: 0x007B4EE4 File Offset: 0x007B30E4
		// (set) Token: 0x0603906C RID: 233580 RVA: 0x007B4EEC File Offset: 0x007B30EC
		public bool ReplayWhenReLogin { get; set; }

		// Token: 0x1700ED0C RID: 60684
		// (get) Token: 0x0603906D RID: 233581 RVA: 0x007B4EF5 File Offset: 0x007B30F5
		// (set) Token: 0x0603906E RID: 233582 RVA: 0x007B4EFD File Offset: 0x007B30FD
		public IMp4BackgroundColorT BackgroundColor { get; set; }

		// Token: 0x1700ED0D RID: 60685
		// (get) Token: 0x0603906F RID: 233583 RVA: 0x007B4F06 File Offset: 0x007B3106
		// (set) Token: 0x06039070 RID: 233584 RVA: 0x007B4F0E File Offset: 0x007B310E
		public EAfterTeleportScreenColor AfterTeleportScreenColor { get; set; }

		// Token: 0x1700ED0E RID: 60686
		// (get) Token: 0x06039071 RID: 233585 RVA: 0x007B4F17 File Offset: 0x007B3117
		// (set) Token: 0x06039072 RID: 233586 RVA: 0x007B4F1F File Offset: 0x007B311F
		public byte NullMask { get; set; }

		// Token: 0x06039073 RID: 233587 RVA: 0x007B4F28 File Offset: 0x007B3128
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
