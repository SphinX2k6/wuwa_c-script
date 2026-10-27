using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FEC RID: 20460
	public class IConditionalStreamingSourceConfigT
	{
		// Token: 0x1700943A RID: 37946
		// (get) Token: 0x06020B2F RID: 133935 RVA: 0x0048BEE7 File Offset: 0x0048A0E7
		// (set) Token: 0x06020B30 RID: 133936 RVA: 0x0048BEEF File Offset: 0x0048A0EF
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700943B RID: 37947
		// (get) Token: 0x06020B31 RID: 133937 RVA: 0x0048BEF8 File Offset: 0x0048A0F8
		// (set) Token: 0x06020B32 RID: 133938 RVA: 0x0048BF00 File Offset: 0x0048A100
		public IStreamingSourceConfigT StreamingSourceConfig { get; set; }

		// Token: 0x06020B33 RID: 133939 RVA: 0x0048BF09 File Offset: 0x0048A109
		public IConditionalStreamingSourceConfigT()
		{
			this.Condition = null;
			this.StreamingSourceConfig = null;
		}
	}
}
