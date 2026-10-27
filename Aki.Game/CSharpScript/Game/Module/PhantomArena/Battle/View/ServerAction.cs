using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005249 RID: 21065
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerAction : IServerAction
	{
		// Token: 0x1700825A RID: 33370
		// (get) Token: 0x06035D26 RID: 220454 RVA: 0x00CBBCAF File Offset: 0x00CB9EAF
		// (set) Token: 0x06035D27 RID: 220455 RVA: 0x00CBBCB7 File Offset: 0x00CB9EB7
		public List<TServerAction> ActionList { get; set; }

		// Token: 0x1700825B RID: 33371
		// (get) Token: 0x06035D28 RID: 220456 RVA: 0x00CBBCC0 File Offset: 0x00CB9EC0
		// (set) Token: 0x06035D29 RID: 220457 RVA: 0x00CBBCC8 File Offset: 0x00CB9EC8
		public EServerActionType Type { get; set; }
	}
}
