using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004701 RID: 18177
	public class IRunningConditionDataT
	{
		// Token: 0x1700820F RID: 33295
		// (get) Token: 0x0601BDD3 RID: 114131 RVA: 0x003F31D7 File Offset: 0x003F13D7
		// (set) Token: 0x0601BDD4 RID: 114132 RVA: 0x003F31DF File Offset: 0x003F13DF
		public int RequestId { get; set; }

		// Token: 0x17008210 RID: 33296
		// (get) Token: 0x0601BDD5 RID: 114133 RVA: 0x003F31E8 File Offset: 0x003F13E8
		// (set) Token: 0x0601BDD6 RID: 114134 RVA: 0x003F31F0 File Offset: 0x003F13F0
		public List<bool> Result { get; set; }

		// Token: 0x0601BDD7 RID: 114135 RVA: 0x003F31F9 File Offset: 0x003F13F9
		public IRunningConditionDataT()
		{
			this.RequestId = 0;
			this.Result = null;
		}
	}
}
