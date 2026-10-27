using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B8A RID: 23434
	[NullableContext(1)]
	public interface IComicPanelOpenParam
	{
		// Token: 0x17008CD3 RID: 36051
		// (get) Token: 0x0603B4A4 RID: 242852
		// (set) Token: 0x0603B4A5 RID: 242853
		int ComicConfigId { get; set; }

		// Token: 0x17008CD4 RID: 36052
		// (get) Token: 0x0603B4A6 RID: 242854
		// (set) Token: 0x0603B4A7 RID: 242855
		Action OnSkip { get; set; }

		// Token: 0x17008CD5 RID: 36053
		// (get) Token: 0x0603B4A8 RID: 242856
		// (set) Token: 0x0603B4A9 RID: 242857
		Action OnComplete { get; set; }
	}
}
