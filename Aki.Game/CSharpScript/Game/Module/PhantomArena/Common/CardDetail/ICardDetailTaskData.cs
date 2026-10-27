using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005226 RID: 21030
	[NullableContext(1)]
	public interface ICardDetailTaskData
	{
		// Token: 0x17008231 RID: 33329
		// (get) Token: 0x06035C2F RID: 220207
		// (set) Token: 0x06035C30 RID: 220208
		string Desc { get; set; }

		// Token: 0x17008232 RID: 33330
		// (get) Token: 0x06035C31 RID: 220209
		// (set) Token: 0x06035C32 RID: 220210
		int CurrentProgress { get; set; }
	}
}
