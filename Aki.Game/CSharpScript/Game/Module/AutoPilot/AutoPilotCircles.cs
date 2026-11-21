using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E57 RID: 20055
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotCircles : AutoPilotDefine.IAutoPilotCircles
	{
		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x06032777 RID: 206711 RVA: 0x00E28A1D File Offset: 0x00E26C1D
		// (set) Token: 0x06032778 RID: 206712 RVA: 0x00E28A25 File Offset: 0x00E26C25
		public List<int> RoadBuildIdArray { get; set; } = new List<int>();

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x06032779 RID: 206713 RVA: 0x00E28A2E File Offset: 0x00E26C2E
		// (set) Token: 0x0603277A RID: 206714 RVA: 0x00E28A36 File Offset: 0x00E26C36
		public List<int> CircleIds { get; set; } = new List<int>();
	}
}
