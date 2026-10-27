using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B1 RID: 20913
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailViewOpenParam : ICollectCardDetailViewOpenParam
	{
		// Token: 0x170081AB RID: 33195
		// (get) Token: 0x060358BD RID: 219325 RVA: 0x00CAF072 File Offset: 0x00CAD272
		// (set) Token: 0x060358BE RID: 219326 RVA: 0x00CAF07A File Offset: 0x00CAD27A
		public int CardId { get; set; }

		// Token: 0x170081AC RID: 33196
		// (get) Token: 0x060358BF RID: 219327 RVA: 0x00CAF083 File Offset: 0x00CAD283
		// (set) Token: 0x060358C0 RID: 219328 RVA: 0x00CAF08B File Offset: 0x00CAD28B
		public int ActivityId { get; set; }

		// Token: 0x170081AD RID: 33197
		// (get) Token: 0x060358C1 RID: 219329 RVA: 0x00CAF094 File Offset: 0x00CAD294
		// (set) Token: 0x060358C2 RID: 219330 RVA: 0x00CAF09C File Offset: 0x00CAD29C
		public Action<int> CallbackOnClose { get; set; }
	}
}
