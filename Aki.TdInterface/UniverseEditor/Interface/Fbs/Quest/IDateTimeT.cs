using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004206 RID: 16902
	public class IDateTimeT
	{
		// Token: 0x17007313 RID: 29459
		// (get) Token: 0x06017760 RID: 96096 RVA: 0x00359C50 File Offset: 0x00357E50
		// (set) Token: 0x06017761 RID: 96097 RVA: 0x00359C58 File Offset: 0x00357E58
		public int Hours { get; set; }

		// Token: 0x17007314 RID: 29460
		// (get) Token: 0x06017762 RID: 96098 RVA: 0x00359C61 File Offset: 0x00357E61
		// (set) Token: 0x06017763 RID: 96099 RVA: 0x00359C69 File Offset: 0x00357E69
		public int Minutes { get; set; }

		// Token: 0x17007315 RID: 29461
		// (get) Token: 0x06017764 RID: 96100 RVA: 0x00359C72 File Offset: 0x00357E72
		// (set) Token: 0x06017765 RID: 96101 RVA: 0x00359C7A File Offset: 0x00357E7A
		public int Days { get; set; }

		// Token: 0x17007316 RID: 29462
		// (get) Token: 0x06017766 RID: 96102 RVA: 0x00359C83 File Offset: 0x00357E83
		// (set) Token: 0x06017767 RID: 96103 RVA: 0x00359C8B File Offset: 0x00357E8B
		public byte NullMask { get; set; }

		// Token: 0x06017768 RID: 96104 RVA: 0x00359C94 File Offset: 0x00357E94
		public IDateTimeT()
		{
			this.Hours = 0;
			this.Minutes = 0;
			this.Days = 0;
			this.NullMask = 0;
		}
	}
}
