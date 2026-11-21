using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005548 RID: 21832
	public class IConditionalStreamingSourceT
	{
		// Token: 0x17009C16 RID: 39958
		// (get) Token: 0x06022A39 RID: 141881 RVA: 0x004C5643 File Offset: 0x004C3843
		// (set) Token: 0x06022A3A RID: 141882 RVA: 0x004C564B File Offset: 0x004C384B
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x17009C17 RID: 39959
		// (get) Token: 0x06022A3B RID: 141883 RVA: 0x004C5654 File Offset: 0x004C3854
		// (set) Token: 0x06022A3C RID: 141884 RVA: 0x004C565C File Offset: 0x004C385C
		public List<IConditionalStreamingSourceConfigT> StreamingSourceConfigs { get; set; }

		// Token: 0x06022A3D RID: 141885 RVA: 0x004C5665 File Offset: 0x004C3865
		public IConditionalStreamingSourceT()
		{
			this.Type = EStreamingSourceMode.Fixed;
			this.StreamingSourceConfigs = null;
		}
	}
}
