using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C14 RID: 19476
	public class IEntityListT
	{
		// Token: 0x17008A08 RID: 35336
		// (get) Token: 0x0601DCDC RID: 122076 RVA: 0x0042E3BF File Offset: 0x0042C5BF
		// (set) Token: 0x0601DCDD RID: 122077 RVA: 0x0042E3C7 File Offset: 0x0042C5C7
		public int EntityListId { get; set; }

		// Token: 0x17008A09 RID: 35337
		// (get) Token: 0x0601DCDE RID: 122078 RVA: 0x0042E3D0 File Offset: 0x0042C5D0
		// (set) Token: 0x0601DCDF RID: 122079 RVA: 0x0042E3D8 File Offset: 0x0042C5D8
		public List<IEntityListElementT> Entities { get; set; }

		// Token: 0x0601DCE0 RID: 122080 RVA: 0x0042E3E1 File Offset: 0x0042C5E1
		public IEntityListT()
		{
			this.EntityListId = 0;
			this.Entities = null;
		}
	}
}
