using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B75 RID: 23413
	public class IWellStreamingRenderPointConfigT
	{
		// Token: 0x1700B0F0 RID: 45296
		// (get) Token: 0x06028133 RID: 164147 RVA: 0x005826B1 File Offset: 0x005808B1
		// (set) Token: 0x06028134 RID: 164148 RVA: 0x005826B9 File Offset: 0x005808B9
		public IPortalRenderConfigT TargetConfig { get; set; }

		// Token: 0x1700B0F1 RID: 45297
		// (get) Token: 0x06028135 RID: 164149 RVA: 0x005826C2 File Offset: 0x005808C2
		// (set) Token: 0x06028136 RID: 164150 RVA: 0x005826CA File Offset: 0x005808CA
		public IRtSizeT RtSize { get; set; }

		// Token: 0x1700B0F2 RID: 45298
		// (get) Token: 0x06028137 RID: 164151 RVA: 0x005826D3 File Offset: 0x005808D3
		// (set) Token: 0x06028138 RID: 164152 RVA: 0x005826DB File Offset: 0x005808DB
		public bool IsRenderStreamingPointEntity { get; set; }

		// Token: 0x1700B0F3 RID: 45299
		// (get) Token: 0x06028139 RID: 164153 RVA: 0x005826E4 File Offset: 0x005808E4
		// (set) Token: 0x0602813A RID: 164154 RVA: 0x005826EC File Offset: 0x005808EC
		public string RtRenderRefPosActorKey { get; set; }

		// Token: 0x1700B0F4 RID: 45300
		// (get) Token: 0x0602813B RID: 164155 RVA: 0x005826F5 File Offset: 0x005808F5
		// (set) Token: 0x0602813C RID: 164156 RVA: 0x005826FD File Offset: 0x005808FD
		public string FallbackCubeMapTexturePath { get; set; }

		// Token: 0x1700B0F5 RID: 45301
		// (get) Token: 0x0602813D RID: 164157 RVA: 0x00582706 File Offset: 0x00580906
		// (set) Token: 0x0602813E RID: 164158 RVA: 0x0058270E File Offset: 0x0058090E
		public byte NullMask { get; set; }

		// Token: 0x0602813F RID: 164159 RVA: 0x00582717 File Offset: 0x00580917
		public IWellStreamingRenderPointConfigT()
		{
			this.TargetConfig = null;
			this.RtSize = null;
			this.IsRenderStreamingPointEntity = false;
			this.RtRenderRefPosActorKey = null;
			this.FallbackCubeMapTexturePath = null;
			this.NullMask = 0;
		}
	}
}
