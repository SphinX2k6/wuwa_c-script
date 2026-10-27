using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A67 RID: 19047
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetInfo : ITrapDefenseLevelTargetInfo
	{
		// Token: 0x17007AA5 RID: 31397
		// (get) Token: 0x0603163E RID: 202302 RVA: 0x00B726D8 File Offset: 0x00B708D8
		// (set) Token: 0x0603163F RID: 202303 RVA: 0x00B726E0 File Offset: 0x00B708E0
		public ETrapDefenseLevelTarget TargetType { get; set; }

		// Token: 0x17007AA6 RID: 31398
		// (get) Token: 0x06031640 RID: 202304 RVA: 0x00B726E9 File Offset: 0x00B708E9
		// (set) Token: 0x06031641 RID: 202305 RVA: 0x00B726F1 File Offset: 0x00B708F1
		public string NameKey { get; set; } = "";

		// Token: 0x17007AA7 RID: 31399
		// (get) Token: 0x06031642 RID: 202306 RVA: 0x00B726FA File Offset: 0x00B708FA
		// (set) Token: 0x06031643 RID: 202307 RVA: 0x00B72702 File Offset: 0x00B70902
		public string IconKey { get; set; } = "";
	}
}
