using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E72 RID: 24178
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotCircles : AutoPilotDefine.IAutoPilotCircles
	{
		// Token: 0x17008E80 RID: 36480
		// (get) Token: 0x0603D7E7 RID: 251879 RVA: 0x00ED7491 File Offset: 0x00ED5691
		// (set) Token: 0x0603D7E8 RID: 251880 RVA: 0x00ED7499 File Offset: 0x00ED5699
		public List<int> RoadBuildIdArray { get; set; } = new List<int>();

		// Token: 0x17008E81 RID: 36481
		// (get) Token: 0x0603D7E9 RID: 251881 RVA: 0x00ED74A2 File Offset: 0x00ED56A2
		// (set) Token: 0x0603D7EA RID: 251882 RVA: 0x00ED74AA File Offset: 0x00ED56AA
		public List<int> CircleIds { get; set; } = new List<int>();
	}
}
