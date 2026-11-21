using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554B RID: 21835
	public class IConditionalStreamingSourceConfigT
	{
		// Token: 0x17009C1B RID: 39963
		// (get) Token: 0x06022A4F RID: 141903 RVA: 0x004C5937 File Offset: 0x004C3B37
		// (set) Token: 0x06022A50 RID: 141904 RVA: 0x004C593F File Offset: 0x004C3B3F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C1C RID: 39964
		// (get) Token: 0x06022A51 RID: 141905 RVA: 0x004C5948 File Offset: 0x004C3B48
		// (set) Token: 0x06022A52 RID: 141906 RVA: 0x004C5950 File Offset: 0x004C3B50
		public IStreamingSourceConfigT StreamingSourceConfig { get; set; }

		// Token: 0x06022A53 RID: 141907 RVA: 0x004C5959 File Offset: 0x004C3B59
		public IConditionalStreamingSourceConfigT()
		{
			this.Condition = null;
			this.StreamingSourceConfig = null;
		}
	}
}
