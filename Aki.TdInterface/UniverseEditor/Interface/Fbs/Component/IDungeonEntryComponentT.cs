using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C4 RID: 20676
	public class IDungeonEntryComponentT
	{
		// Token: 0x17009677 RID: 38519
		// (get) Token: 0x0602141F RID: 136223 RVA: 0x0049EC20 File Offset: 0x0049CE20
		// (set) Token: 0x06021420 RID: 136224 RVA: 0x0049EC28 File Offset: 0x0049CE28
		public bool Disabled { get; set; }

		// Token: 0x17009678 RID: 38520
		// (get) Token: 0x06021421 RID: 136225 RVA: 0x0049EC31 File Offset: 0x0049CE31
		// (set) Token: 0x06021422 RID: 136226 RVA: 0x0049EC39 File Offset: 0x0049CE39
		public byte NullMask { get; set; }

		// Token: 0x06021423 RID: 136227 RVA: 0x0049EC42 File Offset: 0x0049CE42
		public IDungeonEntryComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
