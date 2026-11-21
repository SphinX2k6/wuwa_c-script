using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x02005239 RID: 21049
	public class IActivityPreWarmParam
	{
		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x060345B6 RID: 214454 RVA: 0x00EA66C4 File Offset: 0x00EA48C4
		// (set) Token: 0x060345B7 RID: 214455 RVA: 0x00EA66CC File Offset: 0x00EA48CC
		public int Id { get; set; }

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x060345B8 RID: 214456 RVA: 0x00EA66D5 File Offset: 0x00EA48D5
		// (set) Token: 0x060345B9 RID: 214457 RVA: 0x00EA66DD File Offset: 0x00EA48DD
		public bool IsParsing { get; set; }

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x060345BA RID: 214458 RVA: 0x00EA66E6 File Offset: 0x00EA48E6
		// (set) Token: 0x060345BB RID: 214459 RVA: 0x00EA66EE File Offset: 0x00EA48EE
		public int? ActivityId { get; set; }
	}
}
