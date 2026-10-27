using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A69 RID: 19049
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetItemData : ITrapDefenseLevelTargetItemData
	{
		// Token: 0x17007AAC RID: 31404
		// (get) Token: 0x06031649 RID: 202313 RVA: 0x00B72729 File Offset: 0x00B70929
		// (set) Token: 0x0603164A RID: 202314 RVA: 0x00B72731 File Offset: 0x00B70931
		public ITrapDefenseLevelTargetInfo Info { get; set; }

		// Token: 0x17007AAD RID: 31405
		// (get) Token: 0x0603164B RID: 202315 RVA: 0x00B7273A File Offset: 0x00B7093A
		// (set) Token: 0x0603164C RID: 202316 RVA: 0x00B72742 File Offset: 0x00B70942
		public int TargetValue { get; set; }

		// Token: 0x17007AAE RID: 31406
		// (get) Token: 0x0603164D RID: 202317 RVA: 0x00B7274B File Offset: 0x00B7094B
		// (set) Token: 0x0603164E RID: 202318 RVA: 0x00B72753 File Offset: 0x00B70953
		public int TargetStar { get; set; }

		// Token: 0x17007AAF RID: 31407
		// (get) Token: 0x0603164F RID: 202319 RVA: 0x00B7275C File Offset: 0x00B7095C
		// (set) Token: 0x06031650 RID: 202320 RVA: 0x00B72764 File Offset: 0x00B70964
		public bool IsFinish { get; set; }
	}
}
