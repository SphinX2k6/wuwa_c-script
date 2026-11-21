using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AE3 RID: 23267
	[NullableContext(1)]
	public interface IScanCompositeResult
	{
		// Token: 0x17006D22 RID: 27938
		// (get) Token: 0x06039408 RID: 234504
		// (set) Token: 0x06039409 RID: 234505
		List<GamePlayScan> ScanInfos { get; set; }

		// Token: 0x17006D23 RID: 27939
		// (get) Token: 0x0603940A RID: 234506
		// (set) Token: 0x0603940B RID: 234507
		float Interval { get; set; }

		// Token: 0x17006D24 RID: 27940
		// (get) Token: 0x0603940C RID: 234508
		// (set) Token: 0x0603940D RID: 234509
		GamePlayScanComposite ScanCompositeConfig { get; set; }
	}
}
