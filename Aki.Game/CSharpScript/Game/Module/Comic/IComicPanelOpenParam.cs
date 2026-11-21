using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B6A RID: 19306
	[NullableContext(1)]
	public interface IComicPanelOpenParam
	{
		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x060303F1 RID: 197617
		// (set) Token: 0x060303F2 RID: 197618
		int ComicConfigId { get; set; }

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x060303F3 RID: 197619
		// (set) Token: 0x060303F4 RID: 197620
		Action OnSkip { get; set; }

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x060303F5 RID: 197621
		// (set) Token: 0x060303F6 RID: 197622
		Action OnComplete { get; set; }
	}
}
