using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F6 RID: 16886
	[NullableContext(1)]
	public interface ICardDetailTaskData
	{
		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x0602AB2A RID: 174890
		// (set) Token: 0x0602AB2B RID: 174891
		string Desc { get; set; }

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x0602AB2C RID: 174892
		// (set) Token: 0x0602AB2D RID: 174893
		int CurrentProgress { get; set; }
	}
}
