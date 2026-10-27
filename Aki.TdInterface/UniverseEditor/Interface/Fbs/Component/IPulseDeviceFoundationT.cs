using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B8 RID: 22456
	public class IPulseDeviceFoundationT
	{
		// Token: 0x1700A79F RID: 42911
		// (get) Token: 0x06025B02 RID: 154370 RVA: 0x00532B4E File Offset: 0x00530D4E
		// (set) Token: 0x06025B03 RID: 154371 RVA: 0x00532B56 File Offset: 0x00530D56
		public EItemFoundation Type { get; set; }

		// Token: 0x06025B04 RID: 154372 RVA: 0x00532B5F File Offset: 0x00530D5F
		public IPulseDeviceFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
