using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC3 RID: 24003
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionMaker : ILevelConditionMaker
	{
		// Token: 0x17006EB2 RID: 28338
		// (get) Token: 0x0603A646 RID: 239174 RVA: 0x0107DBC1 File Offset: 0x0107BDC1
		// (set) Token: 0x0603A647 RID: 239175 RVA: 0x0107DBC9 File Offset: 0x0107BDC9
		public LevelConditionBase LevelCondition { get; set; }

		// Token: 0x17006EB3 RID: 28339
		// (get) Token: 0x0603A648 RID: 239176 RVA: 0x0107DBD2 File Offset: 0x0107BDD2
		// (set) Token: 0x0603A649 RID: 239177 RVA: 0x0107DBDA File Offset: 0x0107BDDA
		public List<EEventName> EventNames { get; set; } = new List<EEventName>();
	}
}
