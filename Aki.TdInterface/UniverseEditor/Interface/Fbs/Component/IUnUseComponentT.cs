using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006119 RID: 24857
	public class IUnUseComponentT
	{
		// Token: 0x1700B910 RID: 47376
		// (get) Token: 0x0602A24A RID: 172618 RVA: 0x005C0680 File Offset: 0x005BE880
		// (set) Token: 0x0602A24B RID: 172619 RVA: 0x005C0688 File Offset: 0x005BE888
		public bool Disabled { get; set; }

		// Token: 0x1700B911 RID: 47377
		// (get) Token: 0x0602A24C RID: 172620 RVA: 0x005C0691 File Offset: 0x005BE891
		// (set) Token: 0x0602A24D RID: 172621 RVA: 0x005C0699 File Offset: 0x005BE899
		public byte NullMask { get; set; }

		// Token: 0x0602A24E RID: 172622 RVA: 0x005C06A2 File Offset: 0x005BE8A2
		public IUnUseComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
