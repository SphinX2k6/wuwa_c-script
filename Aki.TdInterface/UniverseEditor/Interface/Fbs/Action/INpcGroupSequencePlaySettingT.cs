using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731D RID: 29469
	public class INpcGroupSequencePlaySettingT
	{
		// Token: 0x1700D800 RID: 55296
		// (get) Token: 0x0603362D RID: 210477 RVA: 0x006EDAE5 File Offset: 0x006EBCE5
		// (set) Token: 0x0603362E RID: 210478 RVA: 0x006EDAED File Offset: 0x006EBCED
		public string Mark { get; set; }

		// Token: 0x1700D801 RID: 55297
		// (get) Token: 0x0603362F RID: 210479 RVA: 0x006EDAF6 File Offset: 0x006EBCF6
		// (set) Token: 0x06033630 RID: 210480 RVA: 0x006EDAFE File Offset: 0x006EBCFE
		public bool IsLoop { get; set; }

		// Token: 0x1700D802 RID: 55298
		// (get) Token: 0x06033631 RID: 210481 RVA: 0x006EDB07 File Offset: 0x006EBD07
		// (set) Token: 0x06033632 RID: 210482 RVA: 0x006EDB0F File Offset: 0x006EBD0F
		public bool IsWaitCurrentSequenceFinish { get; set; }

		// Token: 0x06033633 RID: 210483 RVA: 0x006EDB18 File Offset: 0x006EBD18
		public INpcGroupSequencePlaySettingT()
		{
			this.Mark = null;
			this.IsLoop = false;
			this.IsWaitCurrentSequenceFinish = false;
		}
	}
}
