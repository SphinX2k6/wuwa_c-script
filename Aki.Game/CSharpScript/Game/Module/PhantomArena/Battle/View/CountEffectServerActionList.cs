using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200421A RID: 16922
	[NullableContext(1)]
	[Nullable(0)]
	public class CountEffectServerActionList : ICountEffectServerActionList, IServerAction
	{
		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x0602AC26 RID: 175142 RVA: 0x00C09369 File Offset: 0x00C07569
		// (set) Token: 0x0602AC27 RID: 175143 RVA: 0x00C09371 File Offset: 0x00C07571
		public List<TServerAction> ActionList { get; set; }

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x0602AC28 RID: 175144 RVA: 0x00C0937A File Offset: 0x00C0757A
		// (set) Token: 0x0602AC29 RID: 175145 RVA: 0x00C09382 File Offset: 0x00C07582
		public EServerActionType Type { get; set; }

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x0602AC2A RID: 175146 RVA: 0x00C0938B File Offset: 0x00C0758B
		// (set) Token: 0x0602AC2B RID: 175147 RVA: 0x00C09393 File Offset: 0x00C07593
		public List<int> CardIdList { get; set; }
	}
}
