using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF9 RID: 19449
	public class IEntitiesStateT
	{
		// Token: 0x170089AC RID: 35244
		// (get) Token: 0x0601DB60 RID: 121696 RVA: 0x0042B181 File Offset: 0x00429381
		// (set) Token: 0x0601DB61 RID: 121697 RVA: 0x0042B189 File Offset: 0x00429389
		public List<IEntityStateT> Entities { get; set; }

		// Token: 0x170089AD RID: 35245
		// (get) Token: 0x0601DB62 RID: 121698 RVA: 0x0042B192 File Offset: 0x00429392
		// (set) Token: 0x0601DB63 RID: 121699 RVA: 0x0042B19A File Offset: 0x0042939A
		public int LevelId { get; set; }

		// Token: 0x170089AE RID: 35246
		// (get) Token: 0x0601DB64 RID: 121700 RVA: 0x0042B1A3 File Offset: 0x004293A3
		// (set) Token: 0x0601DB65 RID: 121701 RVA: 0x0042B1AB File Offset: 0x004293AB
		public byte NullMask { get; set; }

		// Token: 0x0601DB66 RID: 121702 RVA: 0x0042B1B4 File Offset: 0x004293B4
		public IEntitiesStateT()
		{
			this.Entities = null;
			this.LevelId = 0;
			this.NullMask = 0;
		}
	}
}
