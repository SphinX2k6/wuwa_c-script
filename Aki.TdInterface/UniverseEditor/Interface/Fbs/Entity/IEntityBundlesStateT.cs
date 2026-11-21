using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFF RID: 19455
	public class IEntityBundlesStateT
	{
		// Token: 0x170089C4 RID: 35268
		// (get) Token: 0x0601DBC6 RID: 121798 RVA: 0x0042C001 File Offset: 0x0042A201
		// (set) Token: 0x0601DBC7 RID: 121799 RVA: 0x0042C009 File Offset: 0x0042A209
		public List<IEntityStateT> Entities { get; set; }

		// Token: 0x170089C5 RID: 35269
		// (get) Token: 0x0601DBC8 RID: 121800 RVA: 0x0042C012 File Offset: 0x0042A212
		// (set) Token: 0x0601DBC9 RID: 121801 RVA: 0x0042C01A File Offset: 0x0042A21A
		public int BundleId { get; set; }

		// Token: 0x170089C6 RID: 35270
		// (get) Token: 0x0601DBCA RID: 121802 RVA: 0x0042C023 File Offset: 0x0042A223
		// (set) Token: 0x0601DBCB RID: 121803 RVA: 0x0042C02B File Offset: 0x0042A22B
		public byte NullMask { get; set; }

		// Token: 0x0601DBCC RID: 121804 RVA: 0x0042C034 File Offset: 0x0042A234
		public IEntityBundlesStateT()
		{
			this.Entities = null;
			this.BundleId = 0;
			this.NullMask = 0;
		}
	}
}
