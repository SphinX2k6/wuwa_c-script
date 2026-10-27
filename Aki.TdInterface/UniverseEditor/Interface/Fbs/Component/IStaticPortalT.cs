using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C9 RID: 22985
	public class IStaticPortalT
	{
		// Token: 0x1700ACA2 RID: 44194
		// (get) Token: 0x06026FA6 RID: 159654 RVA: 0x0055D1E3 File Offset: 0x0055B3E3
		// (set) Token: 0x06026FA7 RID: 159655 RVA: 0x0055D1EB File Offset: 0x0055B3EB
		public EPortalType Type { get; set; }

		// Token: 0x1700ACA3 RID: 44195
		// (get) Token: 0x06026FA8 RID: 159656 RVA: 0x0055D1F4 File Offset: 0x0055B3F4
		// (set) Token: 0x06026FA9 RID: 159657 RVA: 0x0055D1FC File Offset: 0x0055B3FC
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700ACA4 RID: 44196
		// (get) Token: 0x06026FAA RID: 159658 RVA: 0x0055D205 File Offset: 0x0055B405
		// (set) Token: 0x06026FAB RID: 159659 RVA: 0x0055D20D File Offset: 0x0055B40D
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x1700ACA5 RID: 44197
		// (get) Token: 0x06026FAC RID: 159660 RVA: 0x0055D216 File Offset: 0x0055B416
		// (set) Token: 0x06026FAD RID: 159661 RVA: 0x0055D21E File Offset: 0x0055B41E
		public int LinkPortalEntityId { get; set; }

		// Token: 0x1700ACA6 RID: 44198
		// (get) Token: 0x06026FAE RID: 159662 RVA: 0x0055D227 File Offset: 0x0055B427
		// (set) Token: 0x06026FAF RID: 159663 RVA: 0x0055D22F File Offset: 0x0055B42F
		public bool IsStreamSource { get; set; }

		// Token: 0x1700ACA7 RID: 44199
		// (get) Token: 0x06026FB0 RID: 159664 RVA: 0x0055D238 File Offset: 0x0055B438
		// (set) Token: 0x06026FB1 RID: 159665 RVA: 0x0055D240 File Offset: 0x0055B440
		public byte NullMask { get; set; }

		// Token: 0x06026FB2 RID: 159666 RVA: 0x0055D249 File Offset: 0x0055B449
		public IStaticPortalT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
			this.LinkPortalEntityId = 0;
			this.IsStreamSource = false;
			this.NullMask = 0;
		}
	}
}
