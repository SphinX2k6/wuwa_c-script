using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618B RID: 24971
	public class IWellStreamingRenderPointConfigT
	{
		// Token: 0x1700BA38 RID: 47672
		// (get) Token: 0x0602A6F7 RID: 173815 RVA: 0x005CA141 File Offset: 0x005C8341
		// (set) Token: 0x0602A6F8 RID: 173816 RVA: 0x005CA149 File Offset: 0x005C8349
		public IPortalRenderConfigT TargetConfig { get; set; }

		// Token: 0x1700BA39 RID: 47673
		// (get) Token: 0x0602A6F9 RID: 173817 RVA: 0x005CA152 File Offset: 0x005C8352
		// (set) Token: 0x0602A6FA RID: 173818 RVA: 0x005CA15A File Offset: 0x005C835A
		public IRtSizeT RtSize { get; set; }

		// Token: 0x1700BA3A RID: 47674
		// (get) Token: 0x0602A6FB RID: 173819 RVA: 0x005CA163 File Offset: 0x005C8363
		// (set) Token: 0x0602A6FC RID: 173820 RVA: 0x005CA16B File Offset: 0x005C836B
		public bool IsRenderStreamingPointEntity { get; set; }

		// Token: 0x1700BA3B RID: 47675
		// (get) Token: 0x0602A6FD RID: 173821 RVA: 0x005CA174 File Offset: 0x005C8374
		// (set) Token: 0x0602A6FE RID: 173822 RVA: 0x005CA17C File Offset: 0x005C837C
		public string RtRenderRefPosActorKey { get; set; }

		// Token: 0x1700BA3C RID: 47676
		// (get) Token: 0x0602A6FF RID: 173823 RVA: 0x005CA185 File Offset: 0x005C8385
		// (set) Token: 0x0602A700 RID: 173824 RVA: 0x005CA18D File Offset: 0x005C838D
		public string FallbackCubeMapTexturePath { get; set; }

		// Token: 0x1700BA3D RID: 47677
		// (get) Token: 0x0602A701 RID: 173825 RVA: 0x005CA196 File Offset: 0x005C8396
		// (set) Token: 0x0602A702 RID: 173826 RVA: 0x005CA19E File Offset: 0x005C839E
		public byte NullMask { get; set; }

		// Token: 0x0602A703 RID: 173827 RVA: 0x005CA1A7 File Offset: 0x005C83A7
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
