using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A09 RID: 14857
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdProgressInfo : ITrapDefenseBdProgressInfo
	{
		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x060263A9 RID: 156585 RVA: 0x00AB6525 File Offset: 0x00AB4725
		// (set) Token: 0x060263AA RID: 156586 RVA: 0x00AB652D File Offset: 0x00AB472D
		public TrapDefenseBdData BdData { get; set; }

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x060263AB RID: 156587 RVA: 0x00AB6536 File Offset: 0x00AB4736
		// (set) Token: 0x060263AC RID: 156588 RVA: 0x00AB653E File Offset: 0x00AB473E
		public bool IsActive { get; set; }

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x060263AD RID: 156589 RVA: 0x00AB6547 File Offset: 0x00AB4747
		// (set) Token: 0x060263AE RID: 156590 RVA: 0x00AB654F File Offset: 0x00AB474F
		public bool IsShowQualityArrow { get; set; }

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x060263AF RID: 156591 RVA: 0x00AB6558 File Offset: 0x00AB4758
		// (set) Token: 0x060263B0 RID: 156592 RVA: 0x00AB6560 File Offset: 0x00AB4760
		public ETrapDefenseResKey QualityArrowRes { get; set; }
	}
}
