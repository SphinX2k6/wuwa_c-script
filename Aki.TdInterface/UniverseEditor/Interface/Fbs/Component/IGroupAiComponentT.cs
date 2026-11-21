using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B7 RID: 22711
	public class IGroupAiComponentT
	{
		// Token: 0x1700A4AD RID: 42157
		// (get) Token: 0x06024DEB RID: 151019 RVA: 0x00510540 File Offset: 0x0050E740
		// (set) Token: 0x06024DEC RID: 151020 RVA: 0x00510548 File Offset: 0x0050E748
		public bool Disabled { get; set; }

		// Token: 0x1700A4AE RID: 42158
		// (get) Token: 0x06024DED RID: 151021 RVA: 0x00510551 File Offset: 0x0050E751
		// (set) Token: 0x06024DEE RID: 151022 RVA: 0x00510559 File Offset: 0x0050E759
		public List<int> Entities { get; set; }

		// Token: 0x1700A4AF RID: 42159
		// (get) Token: 0x06024DEF RID: 151023 RVA: 0x00510562 File Offset: 0x0050E762
		// (set) Token: 0x06024DF0 RID: 151024 RVA: 0x0051056A File Offset: 0x0050E76A
		public TGroupAiOptionUnion Option { get; set; }

		// Token: 0x1700A4B0 RID: 42160
		// (get) Token: 0x06024DF1 RID: 151025 RVA: 0x00510573 File Offset: 0x0050E773
		// (set) Token: 0x06024DF2 RID: 151026 RVA: 0x0051057B File Offset: 0x0050E77B
		public List<string> SyncTags { get; set; }

		// Token: 0x1700A4B1 RID: 42161
		// (get) Token: 0x06024DF3 RID: 151027 RVA: 0x00510584 File Offset: 0x0050E784
		// (set) Token: 0x06024DF4 RID: 151028 RVA: 0x0051058C File Offset: 0x0050E78C
		public byte NullMask { get; set; }

		// Token: 0x06024DF5 RID: 151029 RVA: 0x00510595 File Offset: 0x0050E795
		public IGroupAiComponentT()
		{
			this.Disabled = false;
			this.Entities = null;
			this.Option = null;
			this.SyncTags = null;
			this.NullMask = 0;
		}
	}
}
