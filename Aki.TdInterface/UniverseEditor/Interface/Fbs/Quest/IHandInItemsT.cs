using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E91 RID: 16017
	public class IHandInItemsT
	{
		// Token: 0x17006F28 RID: 28456
		// (get) Token: 0x0601699C RID: 92572 RVA: 0x00343D6E File Offset: 0x00341F6E
		// (set) Token: 0x0601699D RID: 92573 RVA: 0x00343D76 File Offset: 0x00341F76
		public List<IHandInItemT> Items { get; set; }

		// Token: 0x17006F29 RID: 28457
		// (get) Token: 0x0601699E RID: 92574 RVA: 0x00343D7F File Offset: 0x00341F7F
		// (set) Token: 0x0601699F RID: 92575 RVA: 0x00343D87 File Offset: 0x00341F87
		public IHandInGroupT GroupConfig { get; set; }

		// Token: 0x17006F2A RID: 28458
		// (get) Token: 0x060169A0 RID: 92576 RVA: 0x00343D90 File Offset: 0x00341F90
		// (set) Token: 0x060169A1 RID: 92577 RVA: 0x00343D98 File Offset: 0x00341F98
		public string TidTitleText { get; set; }

		// Token: 0x17006F2B RID: 28459
		// (get) Token: 0x060169A2 RID: 92578 RVA: 0x00343DA1 File Offset: 0x00341FA1
		// (set) Token: 0x060169A3 RID: 92579 RVA: 0x00343DA9 File Offset: 0x00341FA9
		public string TidDescText { get; set; }

		// Token: 0x17006F2C RID: 28460
		// (get) Token: 0x060169A4 RID: 92580 RVA: 0x00343DB2 File Offset: 0x00341FB2
		// (set) Token: 0x060169A5 RID: 92581 RVA: 0x00343DBA File Offset: 0x00341FBA
		public bool RepeatItems { get; set; }

		// Token: 0x17006F2D RID: 28461
		// (get) Token: 0x060169A6 RID: 92582 RVA: 0x00343DC3 File Offset: 0x00341FC3
		// (set) Token: 0x060169A7 RID: 92583 RVA: 0x00343DCB File Offset: 0x00341FCB
		public byte NullMask { get; set; }

		// Token: 0x060169A8 RID: 92584 RVA: 0x00343DD4 File Offset: 0x00341FD4
		public IHandInItemsT()
		{
			this.Items = null;
			this.GroupConfig = null;
			this.TidTitleText = null;
			this.TidDescText = null;
			this.RepeatItems = false;
			this.NullMask = 0;
		}
	}
}
