using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B6 RID: 29622
	public class IOverrideAbpAnimSchemeT
	{
		// Token: 0x1700D99E RID: 55710
		// (get) Token: 0x06033CFC RID: 212220 RVA: 0x006FD229 File Offset: 0x006FB429
		// (set) Token: 0x06033CFD RID: 212221 RVA: 0x006FD231 File Offset: 0x006FB431
		public List<IOverrideAbpAnimSchemeConfigT> OverrideConfigs { get; set; }

		// Token: 0x06033CFE RID: 212222 RVA: 0x006FD23A File Offset: 0x006FB43A
		public IOverrideAbpAnimSchemeT()
		{
			this.OverrideConfigs = null;
		}
	}
}
