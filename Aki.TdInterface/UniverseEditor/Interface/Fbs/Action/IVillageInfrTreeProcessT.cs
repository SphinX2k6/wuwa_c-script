using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007545 RID: 30021
	public class IVillageInfrTreeProcessT
	{
		// Token: 0x1700E3C7 RID: 58311
		// (get) Token: 0x060369EE RID: 223726 RVA: 0x0076B954 File Offset: 0x00769B54
		// (set) Token: 0x060369EF RID: 223727 RVA: 0x0076B95C File Offset: 0x00769B5C
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x1700E3C8 RID: 58312
		// (get) Token: 0x060369F0 RID: 223728 RVA: 0x0076B965 File Offset: 0x00769B65
		// (set) Token: 0x060369F1 RID: 223729 RVA: 0x0076B96D File Offset: 0x00769B6D
		public int Id { get; set; }

		// Token: 0x060369F2 RID: 223730 RVA: 0x0076B976 File Offset: 0x00769B76
		public IVillageInfrTreeProcessT()
		{
			this.Type = EVillageInfrBuildType.Village;
			this.Id = 0;
		}
	}
}
