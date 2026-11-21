using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049D7 RID: 18903
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseTerrainChangeTipsData : ITrapDefenseTerrainChangeTipsData
	{
		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x0602F548 RID: 193864 RVA: 0x00D343EB File Offset: 0x00D325EB
		// (set) Token: 0x0602F549 RID: 193865 RVA: 0x00D343F3 File Offset: 0x00D325F3
		public Action Callback { get; set; }
	}
}
