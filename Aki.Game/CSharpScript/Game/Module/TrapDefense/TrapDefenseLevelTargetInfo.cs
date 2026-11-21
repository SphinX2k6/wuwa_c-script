using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A0F RID: 14863
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetInfo : ITrapDefenseLevelTargetInfo
	{
		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x060263CE RID: 156622 RVA: 0x00AB665C File Offset: 0x00AB485C
		// (set) Token: 0x060263CF RID: 156623 RVA: 0x00AB6664 File Offset: 0x00AB4864
		public ETrapDefenseLevelTarget TargetType { get; set; }

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x060263D0 RID: 156624 RVA: 0x00AB666D File Offset: 0x00AB486D
		// (set) Token: 0x060263D1 RID: 156625 RVA: 0x00AB6675 File Offset: 0x00AB4875
		public string NameKey { get; set; } = "";

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x060263D2 RID: 156626 RVA: 0x00AB667E File Offset: 0x00AB487E
		// (set) Token: 0x060263D3 RID: 156627 RVA: 0x00AB6686 File Offset: 0x00AB4886
		public string IconKey { get; set; } = "";
	}
}
