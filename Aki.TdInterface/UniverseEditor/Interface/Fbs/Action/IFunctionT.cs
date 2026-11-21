using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F09 RID: 28425
	public class IFunctionT
	{
		// Token: 0x1700D074 RID: 53364
		// (get) Token: 0x0603130F RID: 201487 RVA: 0x006AAA84 File Offset: 0x006A8C84
		// (set) Token: 0x06031310 RID: 201488 RVA: 0x006AAA8C File Offset: 0x006A8C8C
		public string Name { get; set; }

		// Token: 0x1700D075 RID: 53365
		// (get) Token: 0x06031311 RID: 201489 RVA: 0x006AAA95 File Offset: 0x006A8C95
		// (set) Token: 0x06031312 RID: 201490 RVA: 0x006AAA9D File Offset: 0x006A8C9D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06031313 RID: 201491 RVA: 0x006AAAA6 File Offset: 0x006A8CA6
		public IFunctionT()
		{
			this.Name = null;
			this.Actions = null;
		}
	}
}
