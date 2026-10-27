using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A55 RID: 19029
	public class TrapDefensePauseInfo : ITrapDefensePauseInfo
	{
		// Token: 0x17007A6D RID: 31341
		// (get) Token: 0x060315D6 RID: 202198 RVA: 0x00B72458 File Offset: 0x00B70658
		// (set) Token: 0x060315D7 RID: 202199 RVA: 0x00B72460 File Offset: 0x00B70660
		public ETrapDefensePauseInfoType Type { get; set; }

		// Token: 0x17007A6E RID: 31342
		// (get) Token: 0x060315D8 RID: 202200 RVA: 0x00B72469 File Offset: 0x00B70669
		// (set) Token: 0x060315D9 RID: 202201 RVA: 0x00B72471 File Offset: 0x00B70671
		public int? Value { get; set; }

		// Token: 0x17007A6F RID: 31343
		// (get) Token: 0x060315DA RID: 202202 RVA: 0x00B7247A File Offset: 0x00B7067A
		// (set) Token: 0x060315DB RID: 202203 RVA: 0x00B72482 File Offset: 0x00B70682
		public int? MaxBatch { get; set; }
	}
}
