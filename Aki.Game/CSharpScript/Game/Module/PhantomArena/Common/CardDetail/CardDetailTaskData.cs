using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F7 RID: 16887
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailTaskData : ICardDetailTaskData
	{
		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x0602AB2E RID: 174894 RVA: 0x00C06C27 File Offset: 0x00C04E27
		// (set) Token: 0x0602AB2F RID: 174895 RVA: 0x00C06C2F File Offset: 0x00C04E2F
		public string Desc { get; set; }

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x0602AB30 RID: 174896 RVA: 0x00C06C38 File Offset: 0x00C04E38
		// (set) Token: 0x0602AB31 RID: 174897 RVA: 0x00C06C40 File Offset: 0x00C04E40
		public int CurrentProgress { get; set; }
	}
}
