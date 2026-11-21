using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F2 RID: 22258
	public class IEntityListComponentT
	{
		// Token: 0x1700A074 RID: 41076
		// (get) Token: 0x06023B8B RID: 146315 RVA: 0x004E9290 File Offset: 0x004E7490
		// (set) Token: 0x06023B8C RID: 146316 RVA: 0x004E9298 File Offset: 0x004E7498
		public bool Disabled { get; set; }

		// Token: 0x1700A075 RID: 41077
		// (get) Token: 0x06023B8D RID: 146317 RVA: 0x004E92A1 File Offset: 0x004E74A1
		// (set) Token: 0x06023B8E RID: 146318 RVA: 0x004E92A9 File Offset: 0x004E74A9
		public byte NullMask { get; set; }

		// Token: 0x06023B8F RID: 146319 RVA: 0x004E92B2 File Offset: 0x004E74B2
		public IEntityListComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
