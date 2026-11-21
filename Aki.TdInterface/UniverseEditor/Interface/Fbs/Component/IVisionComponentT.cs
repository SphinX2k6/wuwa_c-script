using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006155 RID: 24917
	public class IVisionComponentT
	{
		// Token: 0x1700B994 RID: 47508
		// (get) Token: 0x0602A49E RID: 173214 RVA: 0x005C5196 File Offset: 0x005C3396
		// (set) Token: 0x0602A49F RID: 173215 RVA: 0x005C519E File Offset: 0x005C339E
		public bool Disabled { get; set; }

		// Token: 0x1700B995 RID: 47509
		// (get) Token: 0x0602A4A0 RID: 173216 RVA: 0x005C51A7 File Offset: 0x005C33A7
		// (set) Token: 0x0602A4A1 RID: 173217 RVA: 0x005C51AF File Offset: 0x005C33AF
		public int VisionId { get; set; }

		// Token: 0x1700B996 RID: 47510
		// (get) Token: 0x0602A4A2 RID: 173218 RVA: 0x005C51B8 File Offset: 0x005C33B8
		// (set) Token: 0x0602A4A3 RID: 173219 RVA: 0x005C51C0 File Offset: 0x005C33C0
		public byte NullMask { get; set; }

		// Token: 0x0602A4A4 RID: 173220 RVA: 0x005C51C9 File Offset: 0x005C33C9
		public IVisionComponentT()
		{
			this.Disabled = false;
			this.VisionId = 0;
			this.NullMask = 0;
		}
	}
}
