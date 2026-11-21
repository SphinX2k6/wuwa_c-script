using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC8 RID: 19400
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterRestartChoiceParam : ICiacconaGalChapterRestartChoiceParam
	{
		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x060306DA RID: 198362 RVA: 0x00D7EEA7 File Offset: 0x00D7D0A7
		// (set) Token: 0x060306DB RID: 198363 RVA: 0x00D7EEAF File Offset: 0x00D7D0AF
		public ECiacconaGalChapterRestartChoiceType Type { get; set; }

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x060306DC RID: 198364 RVA: 0x00D7EEB8 File Offset: 0x00D7D0B8
		// (set) Token: 0x060306DD RID: 198365 RVA: 0x00D7EEC0 File Offset: 0x00D7D0C0
		public string Desc { get; set; }

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x060306DE RID: 198366 RVA: 0x00D7EEC9 File Offset: 0x00D7D0C9
		// (set) Token: 0x060306DF RID: 198367 RVA: 0x00D7EED1 File Offset: 0x00D7D0D1
		public CiacconaGalChapterData ChapterData { get; set; }
	}
}
