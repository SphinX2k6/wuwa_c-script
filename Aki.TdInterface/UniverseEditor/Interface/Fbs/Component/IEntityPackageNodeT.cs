using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051AB RID: 20907
	public class IEntityPackageNodeT
	{
		// Token: 0x170098C8 RID: 39112
		// (get) Token: 0x06021D73 RID: 138611 RVA: 0x004B1BE1 File Offset: 0x004AFDE1
		// (set) Token: 0x06021D74 RID: 138612 RVA: 0x004B1BE9 File Offset: 0x004AFDE9
		public int EntityId { get; set; }

		// Token: 0x170098C9 RID: 39113
		// (get) Token: 0x06021D75 RID: 138613 RVA: 0x004B1BF2 File Offset: 0x004AFDF2
		// (set) Token: 0x06021D76 RID: 138614 RVA: 0x004B1BFA File Offset: 0x004AFDFA
		public List<IEntityPackageNodeT> Children { get; set; }

		// Token: 0x170098CA RID: 39114
		// (get) Token: 0x06021D77 RID: 138615 RVA: 0x004B1C03 File Offset: 0x004AFE03
		// (set) Token: 0x06021D78 RID: 138616 RVA: 0x004B1C0B File Offset: 0x004AFE0B
		public byte NullMask { get; set; }

		// Token: 0x06021D79 RID: 138617 RVA: 0x004B1C14 File Offset: 0x004AFE14
		public IEntityPackageNodeT()
		{
			this.EntityId = 0;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
