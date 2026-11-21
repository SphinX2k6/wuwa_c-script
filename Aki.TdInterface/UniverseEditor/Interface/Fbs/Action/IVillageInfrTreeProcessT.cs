using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D3B RID: 32059
	public class IVillageInfrTreeProcessT
	{
		// Token: 0x1700EFF1 RID: 61425
		// (get) Token: 0x06039E04 RID: 237060 RVA: 0x007CEBFC File Offset: 0x007CCDFC
		// (set) Token: 0x06039E05 RID: 237061 RVA: 0x007CEC04 File Offset: 0x007CCE04
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x1700EFF2 RID: 61426
		// (get) Token: 0x06039E06 RID: 237062 RVA: 0x007CEC0D File Offset: 0x007CCE0D
		// (set) Token: 0x06039E07 RID: 237063 RVA: 0x007CEC15 File Offset: 0x007CCE15
		public int Id { get; set; }

		// Token: 0x06039E08 RID: 237064 RVA: 0x007CEC1E File Offset: 0x007CCE1E
		public IVillageInfrTreeProcessT()
		{
			this.Type = EVillageInfrBuildType.Village;
			this.Id = 0;
		}
	}
}
