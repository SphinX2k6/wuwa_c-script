using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B38 RID: 19256
	public class IUnlockEntityForGmT
	{
		// Token: 0x1700870E RID: 34574
		// (get) Token: 0x0601D0DA RID: 119002 RVA: 0x00415293 File Offset: 0x00413493
		// (set) Token: 0x0601D0DB RID: 119003 RVA: 0x0041529B File Offset: 0x0041349B
		public EGmCommand Type { get; set; }

		// Token: 0x1700870F RID: 34575
		// (get) Token: 0x0601D0DC RID: 119004 RVA: 0x004152A4 File Offset: 0x004134A4
		// (set) Token: 0x0601D0DD RID: 119005 RVA: 0x004152AC File Offset: 0x004134AC
		public List<int> EntityIds { get; set; }

		// Token: 0x0601D0DE RID: 119006 RVA: 0x004152B5 File Offset: 0x004134B5
		public IUnlockEntityForGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityIds = null;
		}
	}
}
