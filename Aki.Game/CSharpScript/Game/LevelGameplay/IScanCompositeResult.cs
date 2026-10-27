using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006987 RID: 27015
	[NullableContext(1)]
	public interface IScanCompositeResult
	{
		// Token: 0x17009842 RID: 38978
		// (get) Token: 0x060433D0 RID: 275408
		// (set) Token: 0x060433D1 RID: 275409
		List<GamePlayScan> ScanInfos { get; set; }

		// Token: 0x17009843 RID: 38979
		// (get) Token: 0x060433D2 RID: 275410
		// (set) Token: 0x060433D3 RID: 275411
		float Interval { get; set; }

		// Token: 0x17009844 RID: 38980
		// (get) Token: 0x060433D4 RID: 275412
		// (set) Token: 0x060433D5 RID: 275413
		GamePlayScanComposite ScanCompositeConfig { get; set; }
	}
}
