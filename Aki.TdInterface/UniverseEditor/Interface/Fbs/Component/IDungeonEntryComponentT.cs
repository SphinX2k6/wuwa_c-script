using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005629 RID: 22057
	public class IDungeonEntryComponentT
	{
		// Token: 0x17009E64 RID: 40548
		// (get) Token: 0x06023373 RID: 144243 RVA: 0x004D8BAC File Offset: 0x004D6DAC
		// (set) Token: 0x06023374 RID: 144244 RVA: 0x004D8BB4 File Offset: 0x004D6DB4
		public bool Disabled { get; set; }

		// Token: 0x17009E65 RID: 40549
		// (get) Token: 0x06023375 RID: 144245 RVA: 0x004D8BBD File Offset: 0x004D6DBD
		// (set) Token: 0x06023376 RID: 144246 RVA: 0x004D8BC5 File Offset: 0x004D6DC5
		public byte NullMask { get; set; }

		// Token: 0x06023377 RID: 144247 RVA: 0x004D8BCE File Offset: 0x004D6DCE
		public IDungeonEntryComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
