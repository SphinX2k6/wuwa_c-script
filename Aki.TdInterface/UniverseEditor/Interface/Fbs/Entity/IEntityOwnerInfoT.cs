using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047BE RID: 18366
	public class IEntityOwnerInfoT
	{
		// Token: 0x170083EF RID: 33775
		// (get) Token: 0x0601C5C3 RID: 116163 RVA: 0x0040382E File Offset: 0x00401A2E
		// (set) Token: 0x0601C5C4 RID: 116164 RVA: 0x00403836 File Offset: 0x00401A36
		public EEntityOwnerType Type { get; set; }

		// Token: 0x0601C5C5 RID: 116165 RVA: 0x0040383F File Offset: 0x00401A3F
		public IEntityOwnerInfoT()
		{
			this.Type = EEntityOwnerType.Quest;
		}
	}
}
