using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A07 RID: 14855
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseResultUnlockTab
	{
		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x060263A0 RID: 156576 RVA: 0x00AB64FB File Offset: 0x00AB46FB
		// (set) Token: 0x060263A1 RID: 156577 RVA: 0x00AB6503 File Offset: 0x00AB4703
		public ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x060263A2 RID: 156578 RVA: 0x00AB650C File Offset: 0x00AB470C
		// (set) Token: 0x060263A3 RID: 156579 RVA: 0x00AB6514 File Offset: 0x00AB4714
		public List<ITrapDefenseResultUnlockInfo> DataList { get; set; }
	}
}
