using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005277 RID: 21111
	public class IFixedStreamingSourceT
	{
		// Token: 0x17009AB7 RID: 39607
		// (get) Token: 0x060225DD RID: 140765 RVA: 0x004C3A17 File Offset: 0x004C1C17
		// (set) Token: 0x060225DE RID: 140766 RVA: 0x004C3A1F File Offset: 0x004C1C1F
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x17009AB8 RID: 39608
		// (get) Token: 0x060225DF RID: 140767 RVA: 0x004C3A28 File Offset: 0x004C1C28
		// (set) Token: 0x060225E0 RID: 140768 RVA: 0x004C3A30 File Offset: 0x004C1C30
		public IStreamingSourceConfigT StreamingSourceConfig { get; set; }

		// Token: 0x060225E1 RID: 140769 RVA: 0x004C3A39 File Offset: 0x004C1C39
		public IFixedStreamingSourceT()
		{
			this.Type = EStreamingSourceMode.Fixed;
			this.StreamingSourceConfig = null;
		}
	}
}
