using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004743 RID: 18243
	public class IMontagesConfigT
	{
		// Token: 0x170082E8 RID: 33512
		// (get) Token: 0x0601C135 RID: 114997 RVA: 0x003FA5BD File Offset: 0x003F87BD
		// (set) Token: 0x0601C136 RID: 114998 RVA: 0x003FA5C5 File Offset: 0x003F87C5
		public List<IMontageConfigT> Montages { get; set; }

		// Token: 0x0601C137 RID: 114999 RVA: 0x003FA5CE File Offset: 0x003F87CE
		public IMontagesConfigT()
		{
			this.Montages = null;
		}
	}
}
