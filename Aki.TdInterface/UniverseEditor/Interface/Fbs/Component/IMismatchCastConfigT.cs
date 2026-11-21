using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE7 RID: 23271
	public class IMismatchCastConfigT
	{
		// Token: 0x1700A9C8 RID: 43464
		// (get) Token: 0x06026382 RID: 156546 RVA: 0x0053CC2B File Offset: 0x0053AE2B
		// (set) Token: 0x06026383 RID: 156547 RVA: 0x0053CC33 File Offset: 0x0053AE33
		public List<IMismatchSequenceT> MismatchSequence { get; set; }

		// Token: 0x1700A9C9 RID: 43465
		// (get) Token: 0x06026384 RID: 156548 RVA: 0x0053CC3C File Offset: 0x0053AE3C
		// (set) Token: 0x06026385 RID: 156549 RVA: 0x0053CC44 File Offset: 0x0053AE44
		public byte NullMask { get; set; }

		// Token: 0x06026386 RID: 156550 RVA: 0x0053CC4D File Offset: 0x0053AE4D
		public IMismatchCastConfigT()
		{
			this.MismatchSequence = null;
			this.NullMask = 0;
		}
	}
}
