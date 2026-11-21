using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C02 RID: 19458
	public class IEntityConfigT
	{
		// Token: 0x170089C9 RID: 35273
		// (get) Token: 0x0601DBDE RID: 121822 RVA: 0x0042C221 File Offset: 0x0042A421
		// (set) Token: 0x0601DBDF RID: 121823 RVA: 0x0042C229 File Offset: 0x0042A429
		public string ComponentsByEntity { get; set; }

		// Token: 0x0601DBE0 RID: 121824 RVA: 0x0042C232 File Offset: 0x0042A432
		public IEntityConfigT()
		{
			this.ComponentsByEntity = null;
		}
	}
}
