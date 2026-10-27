using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E8 RID: 22504
	public class IRandomInteractT
	{
		// Token: 0x1700A817 RID: 43031
		// (get) Token: 0x06025D14 RID: 154900 RVA: 0x005373AF File Offset: 0x005355AF
		// (set) Token: 0x06025D15 RID: 154901 RVA: 0x005373B7 File Offset: 0x005355B7
		public int RandomCount { get; set; }

		// Token: 0x1700A818 RID: 43032
		// (get) Token: 0x06025D16 RID: 154902 RVA: 0x005373C0 File Offset: 0x005355C0
		// (set) Token: 0x06025D17 RID: 154903 RVA: 0x005373C8 File Offset: 0x005355C8
		public List<IRandomInteractOptionT> Options { get; set; }

		// Token: 0x06025D18 RID: 154904 RVA: 0x005373D1 File Offset: 0x005355D1
		public IRandomInteractT()
		{
			this.RandomCount = 0;
			this.Options = null;
		}
	}
}
