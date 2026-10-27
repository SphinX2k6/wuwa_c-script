using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE9 RID: 20457
	public class IConditionalStreamingSourceT
	{
		// Token: 0x17009435 RID: 37941
		// (get) Token: 0x06020B19 RID: 133913 RVA: 0x0048BBF3 File Offset: 0x00489DF3
		// (set) Token: 0x06020B1A RID: 133914 RVA: 0x0048BBFB File Offset: 0x00489DFB
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x17009436 RID: 37942
		// (get) Token: 0x06020B1B RID: 133915 RVA: 0x0048BC04 File Offset: 0x00489E04
		// (set) Token: 0x06020B1C RID: 133916 RVA: 0x0048BC0C File Offset: 0x00489E0C
		public List<IConditionalStreamingSourceConfigT> StreamingSourceConfigs { get; set; }

		// Token: 0x06020B1D RID: 133917 RVA: 0x0048BC15 File Offset: 0x00489E15
		public IConditionalStreamingSourceT()
		{
			this.Type = EStreamingSourceMode.Fixed;
			this.StreamingSourceConfigs = null;
		}
	}
}
