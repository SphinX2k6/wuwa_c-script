using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4F RID: 27727
	public class IOverrideAbpAnimSchemeT
	{
		// Token: 0x1700CE83 RID: 52867
		// (get) Token: 0x06030DA1 RID: 200097 RVA: 0x006A2D29 File Offset: 0x006A0F29
		// (set) Token: 0x06030DA2 RID: 200098 RVA: 0x006A2D31 File Offset: 0x006A0F31
		public List<IOverrideAbpAnimSchemeConfigT> OverrideConfigs { get; set; }

		// Token: 0x06030DA3 RID: 200099 RVA: 0x006A2D3A File Offset: 0x006A0F3A
		public IOverrideAbpAnimSchemeT()
		{
			this.OverrideConfigs = null;
		}
	}
}
