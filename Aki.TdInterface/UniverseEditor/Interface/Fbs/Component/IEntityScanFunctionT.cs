using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005713 RID: 22291
	public class IEntityScanFunctionT
	{
		// Token: 0x1700A0C0 RID: 41152
		// (get) Token: 0x06023CE9 RID: 146665 RVA: 0x004EC02D File Offset: 0x004EA22D
		// (set) Token: 0x06023CEA RID: 146666 RVA: 0x004EC035 File Offset: 0x004EA235
		public int ScanId { get; set; }

		// Token: 0x1700A0C1 RID: 41153
		// (get) Token: 0x06023CEB RID: 146667 RVA: 0x004EC03E File Offset: 0x004EA23E
		// (set) Token: 0x06023CEC RID: 146668 RVA: 0x004EC046 File Offset: 0x004EA246
		public bool IsConcealed { get; set; }

		// Token: 0x1700A0C2 RID: 41154
		// (get) Token: 0x06023CED RID: 146669 RVA: 0x004EC04F File Offset: 0x004EA24F
		// (set) Token: 0x06023CEE RID: 146670 RVA: 0x004EC057 File Offset: 0x004EA257
		public IScanTraceEffectT TraceEffect { get; set; }

		// Token: 0x1700A0C3 RID: 41155
		// (get) Token: 0x06023CEF RID: 146671 RVA: 0x004EC060 File Offset: 0x004EA260
		// (set) Token: 0x06023CF0 RID: 146672 RVA: 0x004EC068 File Offset: 0x004EA268
		public ESpecificScanType SpecificScanType { get; set; }

		// Token: 0x1700A0C4 RID: 41156
		// (get) Token: 0x06023CF1 RID: 146673 RVA: 0x004EC071 File Offset: 0x004EA271
		// (set) Token: 0x06023CF2 RID: 146674 RVA: 0x004EC079 File Offset: 0x004EA279
		public byte NullMask { get; set; }

		// Token: 0x06023CF3 RID: 146675 RVA: 0x004EC082 File Offset: 0x004EA282
		public IEntityScanFunctionT()
		{
			this.ScanId = 0;
			this.IsConcealed = false;
			this.TraceEffect = null;
			this.SpecificScanType = ESpecificScanType.None;
			this.NullMask = 0;
		}
	}
}
