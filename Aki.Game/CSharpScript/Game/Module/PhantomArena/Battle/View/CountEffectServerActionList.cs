using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200524A RID: 21066
	[NullableContext(1)]
	[Nullable(0)]
	public class CountEffectServerActionList : ICountEffectServerActionList, IServerAction
	{
		// Token: 0x1700825C RID: 33372
		// (get) Token: 0x06035D2B RID: 220459 RVA: 0x00CBBCD9 File Offset: 0x00CB9ED9
		// (set) Token: 0x06035D2C RID: 220460 RVA: 0x00CBBCE1 File Offset: 0x00CB9EE1
		public List<TServerAction> ActionList { get; set; }

		// Token: 0x1700825D RID: 33373
		// (get) Token: 0x06035D2D RID: 220461 RVA: 0x00CBBCEA File Offset: 0x00CB9EEA
		// (set) Token: 0x06035D2E RID: 220462 RVA: 0x00CBBCF2 File Offset: 0x00CB9EF2
		public EServerActionType Type { get; set; }

		// Token: 0x1700825E RID: 33374
		// (get) Token: 0x06035D2F RID: 220463 RVA: 0x00CBBCFB File Offset: 0x00CB9EFB
		// (set) Token: 0x06035D30 RID: 220464 RVA: 0x00CBBD03 File Offset: 0x00CB9F03
		public List<int> CardIdList { get; set; }
	}
}
