using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC7 RID: 19399
	[NullableContext(1)]
	public interface ICiacconaGalChapterRestartChoiceParam
	{
		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x060306D4 RID: 198356
		// (set) Token: 0x060306D5 RID: 198357
		ECiacconaGalChapterRestartChoiceType Type { get; set; }

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x060306D6 RID: 198358
		// (set) Token: 0x060306D7 RID: 198359
		string Desc { get; set; }

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x060306D8 RID: 198360
		// (set) Token: 0x060306D9 RID: 198361
		CiacconaGalChapterData ChapterData { get; set; }
	}
}
