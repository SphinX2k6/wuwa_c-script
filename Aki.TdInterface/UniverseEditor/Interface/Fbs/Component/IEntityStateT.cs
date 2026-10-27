using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B1 RID: 20913
	public class IEntityStateT
	{
		// Token: 0x170098D9 RID: 39129
		// (get) Token: 0x06021DB1 RID: 138673 RVA: 0x004B22CE File Offset: 0x004B04CE
		// (set) Token: 0x06021DB2 RID: 138674 RVA: 0x004B22D6 File Offset: 0x004B04D6
		public string Type { get; set; }

		// Token: 0x170098DA RID: 39130
		// (get) Token: 0x06021DB3 RID: 138675 RVA: 0x004B22DF File Offset: 0x004B04DF
		// (set) Token: 0x06021DB4 RID: 138676 RVA: 0x004B22E7 File Offset: 0x004B04E7
		public string State { get; set; }

		// Token: 0x06021DB5 RID: 138677 RVA: 0x004B22F0 File Offset: 0x004B04F0
		public IEntityStateT()
		{
			this.Type = null;
			this.State = null;
		}
	}
}
