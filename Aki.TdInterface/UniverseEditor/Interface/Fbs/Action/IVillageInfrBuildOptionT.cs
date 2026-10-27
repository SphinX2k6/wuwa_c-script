using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753F RID: 30015
	public class IVillageInfrBuildOptionT
	{
		// Token: 0x1700E3C1 RID: 58305
		// (get) Token: 0x060369CC RID: 223692 RVA: 0x0076B632 File Offset: 0x00769832
		// (set) Token: 0x060369CD RID: 223693 RVA: 0x0076B63A File Offset: 0x0076983A
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x060369CE RID: 223694 RVA: 0x0076B643 File Offset: 0x00769843
		public IVillageInfrBuildOptionT()
		{
			this.Type = EVillageInfrBuildType.Village;
		}
	}
}
