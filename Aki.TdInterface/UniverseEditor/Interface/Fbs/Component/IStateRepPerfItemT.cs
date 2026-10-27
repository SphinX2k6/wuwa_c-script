using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B7 RID: 22967
	public class IStateRepPerfItemT
	{
		// Token: 0x1700AC58 RID: 44120
		// (get) Token: 0x06026EA1 RID: 159393 RVA: 0x0055AAAF File Offset: 0x00558CAF
		// (set) Token: 0x06026EA2 RID: 159394 RVA: 0x0055AAB7 File Offset: 0x00558CB7
		public string StateTag { get; set; }

		// Token: 0x1700AC59 RID: 44121
		// (get) Token: 0x06026EA3 RID: 159395 RVA: 0x0055AAC0 File Offset: 0x00558CC0
		// (set) Token: 0x06026EA4 RID: 159396 RVA: 0x0055AAC8 File Offset: 0x00558CC8
		public TStateRepPerfUnion ReplacePerformance { get; set; }

		// Token: 0x06026EA5 RID: 159397 RVA: 0x0055AAD1 File Offset: 0x00558CD1
		public IStateRepPerfItemT()
		{
			this.StateTag = null;
			this.ReplacePerformance = null;
		}
	}
}
