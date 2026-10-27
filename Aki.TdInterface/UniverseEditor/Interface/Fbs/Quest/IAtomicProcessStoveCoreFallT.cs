using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D20 RID: 15648
	public class IAtomicProcessStoveCoreFallT
	{
		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x0601598B RID: 88459 RVA: 0x0031E4A7 File Offset: 0x0031C6A7
		// (set) Token: 0x0601598C RID: 88460 RVA: 0x0031E4AF File Offset: 0x0031C6AF
		public EAtomicProcess Type { get; set; }

		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x0601598D RID: 88461 RVA: 0x0031E4B8 File Offset: 0x0031C6B8
		// (set) Token: 0x0601598E RID: 88462 RVA: 0x0031E4C0 File Offset: 0x0031C6C0
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x0601598F RID: 88463 RVA: 0x0031E4C9 File Offset: 0x0031C6C9
		public IAtomicProcessStoveCoreFallT()
		{
			this.Type = EAtomicProcess.StoveCoreFall;
			this.SplineEntityIds = null;
		}
	}
}
