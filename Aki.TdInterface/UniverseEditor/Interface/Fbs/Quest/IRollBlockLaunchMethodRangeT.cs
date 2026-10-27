using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040EF RID: 16623
	public class IRollBlockLaunchMethodRangeT
	{
		// Token: 0x1700752B RID: 29995
		// (get) Token: 0x060183A5 RID: 99237 RVA: 0x0037CFB8 File Offset: 0x0037B1B8
		// (set) Token: 0x060183A6 RID: 99238 RVA: 0x0037CFC0 File Offset: 0x0037B1C0
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x1700752C RID: 29996
		// (get) Token: 0x060183A7 RID: 99239 RVA: 0x0037CFC9 File Offset: 0x0037B1C9
		// (set) Token: 0x060183A8 RID: 99240 RVA: 0x0037CFD1 File Offset: 0x0037B1D1
		public int TargetId { get; set; }

		// Token: 0x060183A9 RID: 99241 RVA: 0x0037CFDA File Offset: 0x0037B1DA
		public IRollBlockLaunchMethodRangeT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
			this.TargetId = 0;
		}
	}
}
