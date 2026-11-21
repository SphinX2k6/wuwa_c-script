using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B5 RID: 30901
	public class IShowSpecificEntitiesT
	{
		// Token: 0x1700E2AF RID: 58031
		// (get) Token: 0x06036615 RID: 222741 RVA: 0x00747BC7 File Offset: 0x00745DC7
		// (set) Token: 0x06036616 RID: 222742 RVA: 0x00747BCF File Offset: 0x00745DCF
		public List<int> EntityIds { get; set; }

		// Token: 0x1700E2B0 RID: 58032
		// (get) Token: 0x06036617 RID: 222743 RVA: 0x00747BD8 File Offset: 0x00745DD8
		// (set) Token: 0x06036618 RID: 222744 RVA: 0x00747BE0 File Offset: 0x00745DE0
		public bool DelayShow { get; set; }

		// Token: 0x06036619 RID: 222745 RVA: 0x00747BE9 File Offset: 0x00745DE9
		public IShowSpecificEntitiesT()
		{
			this.EntityIds = null;
			this.DelayShow = false;
		}
	}
}
