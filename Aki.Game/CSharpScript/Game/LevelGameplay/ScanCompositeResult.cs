using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AE5 RID: 23269
	[NullableContext(1)]
	[Nullable(0)]
	public class ScanCompositeResult : IScanCompositeResult
	{
		// Token: 0x17006D25 RID: 27941
		// (get) Token: 0x06039426 RID: 234534 RVA: 0x01008C9B File Offset: 0x01006E9B
		// (set) Token: 0x06039427 RID: 234535 RVA: 0x01008CA3 File Offset: 0x01006EA3
		public List<GamePlayScan> ScanInfos { get; set; } = new List<GamePlayScan>();

		// Token: 0x17006D26 RID: 27942
		// (get) Token: 0x06039428 RID: 234536 RVA: 0x01008CAC File Offset: 0x01006EAC
		// (set) Token: 0x06039429 RID: 234537 RVA: 0x01008CB4 File Offset: 0x01006EB4
		public float Interval { get; set; }

		// Token: 0x17006D27 RID: 27943
		// (get) Token: 0x0603942A RID: 234538 RVA: 0x01008CBD File Offset: 0x01006EBD
		// (set) Token: 0x0603942B RID: 234539 RVA: 0x01008CC5 File Offset: 0x01006EC5
		public GamePlayScanComposite ScanCompositeConfig { get; set; }
	}
}
