using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004181 RID: 16769
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailViewOpenParam : ICollectCardDetailViewOpenParam
	{
		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x0602A7B8 RID: 174008 RVA: 0x00BFC6AE File Offset: 0x00BFA8AE
		// (set) Token: 0x0602A7B9 RID: 174009 RVA: 0x00BFC6B6 File Offset: 0x00BFA8B6
		public int CardId { get; set; }

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x0602A7BA RID: 174010 RVA: 0x00BFC6BF File Offset: 0x00BFA8BF
		// (set) Token: 0x0602A7BB RID: 174011 RVA: 0x00BFC6C7 File Offset: 0x00BFA8C7
		public int ActivityId { get; set; }

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x0602A7BC RID: 174012 RVA: 0x00BFC6D0 File Offset: 0x00BFA8D0
		// (set) Token: 0x0602A7BD RID: 174013 RVA: 0x00BFC6D8 File Offset: 0x00BFA8D8
		public Action<int> CallbackOnClose { get; set; }
	}
}
