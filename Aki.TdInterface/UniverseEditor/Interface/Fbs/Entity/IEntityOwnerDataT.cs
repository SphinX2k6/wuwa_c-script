using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B8 RID: 18360
	public class IEntityOwnerDataT
	{
		// Token: 0x170083E1 RID: 33761
		// (get) Token: 0x0601C58D RID: 116109 RVA: 0x0040331D File Offset: 0x0040151D
		// (set) Token: 0x0601C58E RID: 116110 RVA: 0x00403325 File Offset: 0x00401525
		public int LevelId { get; set; }

		// Token: 0x170083E2 RID: 33762
		// (get) Token: 0x0601C58F RID: 116111 RVA: 0x0040332E File Offset: 0x0040152E
		// (set) Token: 0x0601C590 RID: 116112 RVA: 0x00403336 File Offset: 0x00401536
		public int EntityId { get; set; }

		// Token: 0x170083E3 RID: 33763
		// (get) Token: 0x0601C591 RID: 116113 RVA: 0x0040333F File Offset: 0x0040153F
		// (set) Token: 0x0601C592 RID: 116114 RVA: 0x00403347 File Offset: 0x00401547
		public List<TEntityOwnerUnion> Owner { get; set; }

		// Token: 0x0601C593 RID: 116115 RVA: 0x00403350 File Offset: 0x00401550
		public IEntityOwnerDataT()
		{
			this.LevelId = 0;
			this.EntityId = 0;
			this.Owner = null;
		}
	}
}
