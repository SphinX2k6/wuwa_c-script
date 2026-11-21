using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B69 RID: 19305
	public class IRunningConditionDataT
	{
		// Token: 0x17008850 RID: 34896
		// (get) Token: 0x0601D5A8 RID: 120232 RVA: 0x0041F473 File Offset: 0x0041D673
		// (set) Token: 0x0601D5A9 RID: 120233 RVA: 0x0041F47B File Offset: 0x0041D67B
		public int RequestId { get; set; }

		// Token: 0x17008851 RID: 34897
		// (get) Token: 0x0601D5AA RID: 120234 RVA: 0x0041F484 File Offset: 0x0041D684
		// (set) Token: 0x0601D5AB RID: 120235 RVA: 0x0041F48C File Offset: 0x0041D68C
		public List<bool> Result { get; set; }

		// Token: 0x0601D5AC RID: 120236 RVA: 0x0041F495 File Offset: 0x0041D695
		public IRunningConditionDataT()
		{
			this.RequestId = 0;
			this.Result = null;
		}
	}
}
