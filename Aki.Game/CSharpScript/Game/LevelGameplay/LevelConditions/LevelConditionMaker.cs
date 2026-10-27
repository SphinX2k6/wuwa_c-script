using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C4A RID: 27722
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionMaker : ILevelConditionMaker
	{
		// Token: 0x170099AF RID: 39343
		// (get) Token: 0x060444EE RID: 279790 RVA: 0x010D3D11 File Offset: 0x010D1F11
		// (set) Token: 0x060444EF RID: 279791 RVA: 0x010D3D19 File Offset: 0x010D1F19
		public LevelConditionBase LevelCondition { get; set; }

		// Token: 0x170099B0 RID: 39344
		// (get) Token: 0x060444F0 RID: 279792 RVA: 0x010D3D22 File Offset: 0x010D1F22
		// (set) Token: 0x060444F1 RID: 279793 RVA: 0x010D3D2A File Offset: 0x010D1F2A
		public List<EEventName> EventNames { get; set; } = new List<EEventName>();
	}
}
