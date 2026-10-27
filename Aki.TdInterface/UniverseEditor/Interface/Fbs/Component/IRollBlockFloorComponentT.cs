using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005886 RID: 22662
	public class IRollBlockFloorComponentT
	{
		// Token: 0x1700A97A RID: 43386
		// (get) Token: 0x060262F6 RID: 156406 RVA: 0x005438D0 File Offset: 0x00541AD0
		// (set) Token: 0x060262F7 RID: 156407 RVA: 0x005438D8 File Offset: 0x00541AD8
		public bool Disabled { get; set; }

		// Token: 0x1700A97B RID: 43387
		// (get) Token: 0x060262F8 RID: 156408 RVA: 0x005438E1 File Offset: 0x00541AE1
		// (set) Token: 0x060262F9 RID: 156409 RVA: 0x005438E9 File Offset: 0x00541AE9
		public byte NullMask { get; set; }

		// Token: 0x060262FA RID: 156410 RVA: 0x005438F2 File Offset: 0x00541AF2
		public IRollBlockFloorComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
