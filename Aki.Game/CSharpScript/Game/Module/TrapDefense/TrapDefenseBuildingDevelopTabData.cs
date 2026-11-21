using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F3 RID: 14835
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopTabData : ITrapDefenseBuildingDevelopTabData
	{
		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x0602632F RID: 156463 RVA: 0x00AB62C1 File Offset: 0x00AB44C1
		// (set) Token: 0x06026330 RID: 156464 RVA: 0x00AB62C9 File Offset: 0x00AB44C9
		public ETrapDefenseBuildingDevelopTab TabType { get; set; }

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06026331 RID: 156465 RVA: 0x00AB62D2 File Offset: 0x00AB44D2
		// (set) Token: 0x06026332 RID: 156466 RVA: 0x00AB62DA File Offset: 0x00AB44DA
		public string Icon { get; set; } = "";

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06026333 RID: 156467 RVA: 0x00AB62E3 File Offset: 0x00AB44E3
		// (set) Token: 0x06026334 RID: 156468 RVA: 0x00AB62EB File Offset: 0x00AB44EB
		public string TabName { get; set; } = "";

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06026335 RID: 156469 RVA: 0x00AB62F4 File Offset: 0x00AB44F4
		// (set) Token: 0x06026336 RID: 156470 RVA: 0x00AB62FC File Offset: 0x00AB44FC
		public ERedDotName? RedDot { get; set; }
	}
}
