using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078AF RID: 30895
	public class IShowMapMarkT
	{
		// Token: 0x1700E2A5 RID: 58021
		// (get) Token: 0x060365DF RID: 222687 RVA: 0x00747694 File Offset: 0x00745894
		// (set) Token: 0x060365E0 RID: 222688 RVA: 0x0074769C File Offset: 0x0074589C
		public EMapMarkState Type { get; set; }

		// Token: 0x1700E2A6 RID: 58022
		// (get) Token: 0x060365E1 RID: 222689 RVA: 0x007476A5 File Offset: 0x007458A5
		// (set) Token: 0x060365E2 RID: 222690 RVA: 0x007476AD File Offset: 0x007458AD
		public int MarkId { get; set; }

		// Token: 0x1700E2A7 RID: 58023
		// (get) Token: 0x060365E3 RID: 222691 RVA: 0x007476B6 File Offset: 0x007458B6
		// (set) Token: 0x060365E4 RID: 222692 RVA: 0x007476BE File Offset: 0x007458BE
		public bool IsFocusOnFirstShow { get; set; }

		// Token: 0x1700E2A8 RID: 58024
		// (get) Token: 0x060365E5 RID: 222693 RVA: 0x007476C7 File Offset: 0x007458C7
		// (set) Token: 0x060365E6 RID: 222694 RVA: 0x007476CF File Offset: 0x007458CF
		public byte NullMask { get; set; }

		// Token: 0x060365E7 RID: 222695 RVA: 0x007476D8 File Offset: 0x007458D8
		public IShowMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
			this.IsFocusOnFirstShow = false;
			this.NullMask = 0;
		}
	}
}
