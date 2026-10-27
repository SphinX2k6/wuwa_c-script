using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A61 RID: 19041
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdProgressInfo : ITrapDefenseBdProgressInfo
	{
		// Token: 0x17007A8E RID: 31374
		// (get) Token: 0x06031619 RID: 202265 RVA: 0x00B725A1 File Offset: 0x00B707A1
		// (set) Token: 0x0603161A RID: 202266 RVA: 0x00B725A9 File Offset: 0x00B707A9
		public TrapDefenseBdData BdData { get; set; }

		// Token: 0x17007A8F RID: 31375
		// (get) Token: 0x0603161B RID: 202267 RVA: 0x00B725B2 File Offset: 0x00B707B2
		// (set) Token: 0x0603161C RID: 202268 RVA: 0x00B725BA File Offset: 0x00B707BA
		public bool IsActive { get; set; }

		// Token: 0x17007A90 RID: 31376
		// (get) Token: 0x0603161D RID: 202269 RVA: 0x00B725C3 File Offset: 0x00B707C3
		// (set) Token: 0x0603161E RID: 202270 RVA: 0x00B725CB File Offset: 0x00B707CB
		public bool IsShowQualityArrow { get; set; }

		// Token: 0x17007A91 RID: 31377
		// (get) Token: 0x0603161F RID: 202271 RVA: 0x00B725D4 File Offset: 0x00B707D4
		// (set) Token: 0x06031620 RID: 202272 RVA: 0x00B725DC File Offset: 0x00B707DC
		public ETrapDefenseResKey QualityArrowRes { get; set; }
	}
}
