using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039FD RID: 14845
	public class TrapDefensePauseInfo : ITrapDefensePauseInfo
	{
		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x06026366 RID: 156518 RVA: 0x00AB63DC File Offset: 0x00AB45DC
		// (set) Token: 0x06026367 RID: 156519 RVA: 0x00AB63E4 File Offset: 0x00AB45E4
		public ETrapDefensePauseInfoType Type { get; set; }

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x06026368 RID: 156520 RVA: 0x00AB63ED File Offset: 0x00AB45ED
		// (set) Token: 0x06026369 RID: 156521 RVA: 0x00AB63F5 File Offset: 0x00AB45F5
		public int? Value { get; set; }

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x0602636A RID: 156522 RVA: 0x00AB63FE File Offset: 0x00AB45FE
		// (set) Token: 0x0602636B RID: 156523 RVA: 0x00AB6406 File Offset: 0x00AB4606
		public int? MaxBatch { get; set; }
	}
}
