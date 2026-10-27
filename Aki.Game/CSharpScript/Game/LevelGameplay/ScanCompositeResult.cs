using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006989 RID: 27017
	[NullableContext(1)]
	[Nullable(0)]
	public class ScanCompositeResult : IScanCompositeResult
	{
		// Token: 0x17009845 RID: 38981
		// (get) Token: 0x060433EE RID: 275438 RVA: 0x01064A33 File Offset: 0x01062C33
		// (set) Token: 0x060433EF RID: 275439 RVA: 0x01064A3B File Offset: 0x01062C3B
		public List<GamePlayScan> ScanInfos { get; set; } = new List<GamePlayScan>();

		// Token: 0x17009846 RID: 38982
		// (get) Token: 0x060433F0 RID: 275440 RVA: 0x01064A44 File Offset: 0x01062C44
		// (set) Token: 0x060433F1 RID: 275441 RVA: 0x01064A4C File Offset: 0x01062C4C
		public float Interval { get; set; }

		// Token: 0x17009847 RID: 38983
		// (get) Token: 0x060433F2 RID: 275442 RVA: 0x01064A55 File Offset: 0x01062C55
		// (set) Token: 0x060433F3 RID: 275443 RVA: 0x01064A5D File Offset: 0x01062C5D
		public GamePlayScanComposite ScanCompositeConfig { get; set; }
	}
}
