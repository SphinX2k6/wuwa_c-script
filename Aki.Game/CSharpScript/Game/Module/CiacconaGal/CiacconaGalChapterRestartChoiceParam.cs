using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE8 RID: 23528
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterRestartChoiceParam : ICiacconaGalChapterRestartChoiceParam
	{
		// Token: 0x17008D67 RID: 36199
		// (get) Token: 0x0603B78F RID: 243599 RVA: 0x00E2EB97 File Offset: 0x00E2CD97
		// (set) Token: 0x0603B790 RID: 243600 RVA: 0x00E2EB9F File Offset: 0x00E2CD9F
		public ECiacconaGalChapterRestartChoiceType Type { get; set; }

		// Token: 0x17008D68 RID: 36200
		// (get) Token: 0x0603B791 RID: 243601 RVA: 0x00E2EBA8 File Offset: 0x00E2CDA8
		// (set) Token: 0x0603B792 RID: 243602 RVA: 0x00E2EBB0 File Offset: 0x00E2CDB0
		public string Desc { get; set; }

		// Token: 0x17008D69 RID: 36201
		// (get) Token: 0x0603B793 RID: 243603 RVA: 0x00E2EBB9 File Offset: 0x00E2CDB9
		// (set) Token: 0x0603B794 RID: 243604 RVA: 0x00E2EBC1 File Offset: 0x00E2CDC1
		public CiacconaGalChapterData ChapterData { get; set; }
	}
}
