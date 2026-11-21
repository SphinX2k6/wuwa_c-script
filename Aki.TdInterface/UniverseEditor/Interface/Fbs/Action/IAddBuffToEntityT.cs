using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677F RID: 26495
	public class IAddBuffToEntityT
	{
		// Token: 0x1700C0A1 RID: 49313
		// (get) Token: 0x0602CEA4 RID: 183972 RVA: 0x00623F45 File Offset: 0x00622145
		// (set) Token: 0x0602CEA5 RID: 183973 RVA: 0x00623F4D File Offset: 0x0062214D
		public int EntityId { get; set; }

		// Token: 0x1700C0A2 RID: 49314
		// (get) Token: 0x0602CEA6 RID: 183974 RVA: 0x00623F56 File Offset: 0x00622156
		// (set) Token: 0x0602CEA7 RID: 183975 RVA: 0x00623F5E File Offset: 0x0062215E
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C0A3 RID: 49315
		// (get) Token: 0x0602CEA8 RID: 183976 RVA: 0x00623F67 File Offset: 0x00622167
		// (set) Token: 0x0602CEA9 RID: 183977 RVA: 0x00623F6F File Offset: 0x0062216F
		public List<long> BuffIds { get; set; }

		// Token: 0x1700C0A4 RID: 49316
		// (get) Token: 0x0602CEAA RID: 183978 RVA: 0x00623F78 File Offset: 0x00622178
		// (set) Token: 0x0602CEAB RID: 183979 RVA: 0x00623F80 File Offset: 0x00622180
		public List<long> PersistOnOfflineBuffIds { get; set; }

		// Token: 0x1700C0A5 RID: 49317
		// (get) Token: 0x0602CEAC RID: 183980 RVA: 0x00623F89 File Offset: 0x00622189
		// (set) Token: 0x0602CEAD RID: 183981 RVA: 0x00623F91 File Offset: 0x00622191
		public byte NullMask { get; set; }

		// Token: 0x0602CEAE RID: 183982 RVA: 0x00623F9A File Offset: 0x0062219A
		public IAddBuffToEntityT()
		{
			this.EntityId = 0;
			this.EntityIds = null;
			this.BuffIds = null;
			this.PersistOnOfflineBuffIds = null;
			this.NullMask = 0;
		}
	}
}
