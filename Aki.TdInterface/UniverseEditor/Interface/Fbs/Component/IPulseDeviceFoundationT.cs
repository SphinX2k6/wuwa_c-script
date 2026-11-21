using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DBF RID: 23999
	public class IPulseDeviceFoundationT
	{
		// Token: 0x1700B0C3 RID: 45251
		// (get) Token: 0x06028022 RID: 163874 RVA: 0x00578CDA File Offset: 0x00576EDA
		// (set) Token: 0x06028023 RID: 163875 RVA: 0x00578CE2 File Offset: 0x00576EE2
		public EItemFoundation Type { get; set; }

		// Token: 0x06028024 RID: 163876 RVA: 0x00578CEB File Offset: 0x00576EEB
		public IPulseDeviceFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
