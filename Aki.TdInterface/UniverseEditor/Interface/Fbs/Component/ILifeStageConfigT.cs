using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FB RID: 21755
	public class ILifeStageConfigT
	{
		// Token: 0x1700A08B RID: 41099
		// (get) Token: 0x06023EA1 RID: 147105 RVA: 0x004F7128 File Offset: 0x004F5328
		// (set) Token: 0x06023EA2 RID: 147106 RVA: 0x004F7130 File Offset: 0x004F5330
		public float PerformDuration { get; set; }

		// Token: 0x1700A08C RID: 41100
		// (get) Token: 0x06023EA3 RID: 147107 RVA: 0x004F7139 File Offset: 0x004F5339
		// (set) Token: 0x06023EA4 RID: 147108 RVA: 0x004F7141 File Offset: 0x004F5341
		public byte NullMask { get; set; }

		// Token: 0x06023EA5 RID: 147109 RVA: 0x004F714A File Offset: 0x004F534A
		public ILifeStageConfigT()
		{
			this.PerformDuration = 0f;
			this.NullMask = 0;
		}
	}
}
