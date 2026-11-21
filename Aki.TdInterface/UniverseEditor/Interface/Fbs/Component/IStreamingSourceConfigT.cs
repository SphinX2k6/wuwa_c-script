using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE2 RID: 24546
	public class IStreamingSourceConfigT
	{
		// Token: 0x1700B603 RID: 46595
		// (get) Token: 0x060295B6 RID: 169398 RVA: 0x005A568A File Offset: 0x005A388A
		// (set) Token: 0x060295B7 RID: 169399 RVA: 0x005A5692 File Offset: 0x005A3892
		public int StreamingSourceTargetEntityId { get; set; }

		// Token: 0x1700B604 RID: 46596
		// (get) Token: 0x060295B8 RID: 169400 RVA: 0x005A569B File Offset: 0x005A389B
		// (set) Token: 0x060295B9 RID: 169401 RVA: 0x005A56A3 File Offset: 0x005A38A3
		public bool IsNoRenderStreaming { get; set; }

		// Token: 0x1700B605 RID: 46597
		// (get) Token: 0x060295BA RID: 169402 RVA: 0x005A56AC File Offset: 0x005A38AC
		// (set) Token: 0x060295BB RID: 169403 RVA: 0x005A56B4 File Offset: 0x005A38B4
		public byte NullMask { get; set; }

		// Token: 0x060295BC RID: 169404 RVA: 0x005A56BD File Offset: 0x005A38BD
		public IStreamingSourceConfigT()
		{
			this.StreamingSourceTargetEntityId = 0;
			this.IsNoRenderStreaming = false;
			this.NullMask = 0;
		}
	}
}
