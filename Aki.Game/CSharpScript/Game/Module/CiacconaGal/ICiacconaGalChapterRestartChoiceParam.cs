using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE7 RID: 23527
	[NullableContext(1)]
	public interface ICiacconaGalChapterRestartChoiceParam
	{
		// Token: 0x17008D64 RID: 36196
		// (get) Token: 0x0603B789 RID: 243593
		// (set) Token: 0x0603B78A RID: 243594
		ECiacconaGalChapterRestartChoiceType Type { get; set; }

		// Token: 0x17008D65 RID: 36197
		// (get) Token: 0x0603B78B RID: 243595
		// (set) Token: 0x0603B78C RID: 243596
		string Desc { get; set; }

		// Token: 0x17008D66 RID: 36198
		// (get) Token: 0x0603B78D RID: 243597
		// (set) Token: 0x0603B78E RID: 243598
		CiacconaGalChapterData ChapterData { get; set; }
	}
}
