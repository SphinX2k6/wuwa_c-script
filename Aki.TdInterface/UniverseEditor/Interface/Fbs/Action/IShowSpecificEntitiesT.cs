using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E9 RID: 28905
	public class IShowSpecificEntitiesT
	{
		// Token: 0x1700D6CC RID: 54988
		// (get) Token: 0x06033373 RID: 209779 RVA: 0x006E75BB File Offset: 0x006E57BB
		// (set) Token: 0x06033374 RID: 209780 RVA: 0x006E75C3 File Offset: 0x006E57C3
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D6CD RID: 54989
		// (get) Token: 0x06033375 RID: 209781 RVA: 0x006E75CC File Offset: 0x006E57CC
		// (set) Token: 0x06033376 RID: 209782 RVA: 0x006E75D4 File Offset: 0x006E57D4
		public bool DelayShow { get; set; }

		// Token: 0x06033377 RID: 209783 RVA: 0x006E75DD File Offset: 0x006E57DD
		public IShowSpecificEntitiesT()
		{
			this.EntityIds = null;
			this.DelayShow = false;
		}
	}
}
