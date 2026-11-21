using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200406A RID: 16490
	[NullableContext(1)]
	[Nullable(0)]
	public class TalkRecord
	{
		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x06029D0A RID: 171274 RVA: 0x00BCFDF3 File Offset: 0x00BCDFF3
		// (set) Token: 0x06029D0B RID: 171275 RVA: 0x00BCFDFB File Offset: 0x00BCDFFB
		public ITalkItem TalkItem { get; set; }

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x06029D0C RID: 171276 RVA: 0x00BCFE04 File Offset: 0x00BCE004
		// (set) Token: 0x06029D0D RID: 171277 RVA: 0x00BCFE0C File Offset: 0x00BCE00C
		public bool IsOption { get; set; }

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x06029D0E RID: 171278 RVA: 0x00BCFE15 File Offset: 0x00BCE015
		// (set) Token: 0x06029D0F RID: 171279 RVA: 0x00BCFE1D File Offset: 0x00BCE01D
		public int? OptionIndex { get; set; }
	}
}
