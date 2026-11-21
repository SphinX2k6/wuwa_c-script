using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A9 RID: 22953
	public class IInitStateDigitalT
	{
		// Token: 0x1700A6A8 RID: 42664
		// (get) Token: 0x060256BF RID: 153279 RVA: 0x005222B6 File Offset: 0x005204B6
		// (set) Token: 0x060256C0 RID: 153280 RVA: 0x005222BE File Offset: 0x005204BE
		public EInitStateType Type { get; set; }

		// Token: 0x060256C1 RID: 153281 RVA: 0x005222C7 File Offset: 0x005204C7
		public IInitStateDigitalT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
