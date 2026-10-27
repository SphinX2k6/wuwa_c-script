using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020059FB RID: 23035
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseTerrainChangeTipsData : ITrapDefenseTerrainChangeTipsData
	{
		// Token: 0x17008BA8 RID: 35752
		// (get) Token: 0x0603A5FF RID: 239103 RVA: 0x00DE3E9B File Offset: 0x00DE209B
		// (set) Token: 0x0603A600 RID: 239104 RVA: 0x00DE3EA3 File Offset: 0x00DE20A3
		public Action Callback { get; set; }
	}
}
