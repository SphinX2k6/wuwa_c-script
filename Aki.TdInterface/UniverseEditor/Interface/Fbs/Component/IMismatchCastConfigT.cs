using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005555 RID: 21845
	public class IMismatchCastConfigT
	{
		// Token: 0x1700A154 RID: 41300
		// (get) Token: 0x060241E7 RID: 147943 RVA: 0x004FD543 File Offset: 0x004FB743
		// (set) Token: 0x060241E8 RID: 147944 RVA: 0x004FD54B File Offset: 0x004FB74B
		public List<IMismatchSequenceT> MismatchSequence { get; set; }

		// Token: 0x1700A155 RID: 41301
		// (get) Token: 0x060241E9 RID: 147945 RVA: 0x004FD554 File Offset: 0x004FB754
		// (set) Token: 0x060241EA RID: 147946 RVA: 0x004FD55C File Offset: 0x004FB75C
		public byte NullMask { get; set; }

		// Token: 0x060241EB RID: 147947 RVA: 0x004FD565 File Offset: 0x004FB765
		public IMismatchCastConfigT()
		{
			this.MismatchSequence = null;
			this.NullMask = 0;
		}
	}
}
