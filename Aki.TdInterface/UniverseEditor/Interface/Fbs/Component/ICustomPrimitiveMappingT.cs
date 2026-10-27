using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200505E RID: 20574
	public class ICustomPrimitiveMappingT
	{
		// Token: 0x17009546 RID: 38214
		// (get) Token: 0x06020F95 RID: 135061 RVA: 0x0049528B File Offset: 0x0049348B
		// (set) Token: 0x06020F96 RID: 135062 RVA: 0x00495293 File Offset: 0x00493493
		public string KeyPrefix { get; set; }

		// Token: 0x17009547 RID: 38215
		// (get) Token: 0x06020F97 RID: 135063 RVA: 0x0049529C File Offset: 0x0049349C
		// (set) Token: 0x06020F98 RID: 135064 RVA: 0x004952A4 File Offset: 0x004934A4
		public int Index { get; set; }

		// Token: 0x06020F99 RID: 135065 RVA: 0x004952AD File Offset: 0x004934AD
		public ICustomPrimitiveMappingT()
		{
			this.KeyPrefix = null;
			this.Index = 0;
		}
	}
}
