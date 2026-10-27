using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006389 RID: 25481
	public class IClearPlayBubbleT
	{
		// Token: 0x1700BDF8 RID: 48632
		// (get) Token: 0x0602C134 RID: 180532 RVA: 0x0060DCC1 File Offset: 0x0060BEC1
		// (set) Token: 0x0602C135 RID: 180533 RVA: 0x0060DCC9 File Offset: 0x0060BEC9
		public List<int> EntityIds { get; set; }

		// Token: 0x1700BDF9 RID: 48633
		// (get) Token: 0x0602C136 RID: 180534 RVA: 0x0060DCD2 File Offset: 0x0060BED2
		// (set) Token: 0x0602C137 RID: 180535 RVA: 0x0060DCDA File Offset: 0x0060BEDA
		public bool OnlyClearRedDot { get; set; }

		// Token: 0x1700BDFA RID: 48634
		// (get) Token: 0x0602C138 RID: 180536 RVA: 0x0060DCE3 File Offset: 0x0060BEE3
		// (set) Token: 0x0602C139 RID: 180537 RVA: 0x0060DCEB File Offset: 0x0060BEEB
		public byte NullMask { get; set; }

		// Token: 0x0602C13A RID: 180538 RVA: 0x0060DCF4 File Offset: 0x0060BEF4
		public IClearPlayBubbleT()
		{
			this.EntityIds = null;
			this.OnlyClearRedDot = false;
			this.NullMask = 0;
		}
	}
}
