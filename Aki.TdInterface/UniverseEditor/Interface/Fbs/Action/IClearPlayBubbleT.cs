using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FA RID: 27130
	public class IClearPlayBubbleT
	{
		// Token: 0x1700C780 RID: 51072
		// (get) Token: 0x0602E89E RID: 190622 RVA: 0x00658E15 File Offset: 0x00657015
		// (set) Token: 0x0602E89F RID: 190623 RVA: 0x00658E1D File Offset: 0x0065701D
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C781 RID: 51073
		// (get) Token: 0x0602E8A0 RID: 190624 RVA: 0x00658E26 File Offset: 0x00657026
		// (set) Token: 0x0602E8A1 RID: 190625 RVA: 0x00658E2E File Offset: 0x0065702E
		public bool OnlyClearRedDot { get; set; }

		// Token: 0x1700C782 RID: 51074
		// (get) Token: 0x0602E8A2 RID: 190626 RVA: 0x00658E37 File Offset: 0x00657037
		// (set) Token: 0x0602E8A3 RID: 190627 RVA: 0x00658E3F File Offset: 0x0065703F
		public byte NullMask { get; set; }

		// Token: 0x0602E8A4 RID: 190628 RVA: 0x00658E48 File Offset: 0x00657048
		public IClearPlayBubbleT()
		{
			this.EntityIds = null;
			this.OnlyClearRedDot = false;
			this.NullMask = 0;
		}
	}
}
