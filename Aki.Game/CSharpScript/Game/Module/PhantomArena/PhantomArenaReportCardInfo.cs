using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004107 RID: 16647
	public class PhantomArenaReportCardInfo
	{
		// Token: 0x0602A065 RID: 172133 RVA: 0x00BE168E File Offset: 0x00BDF88E
		public PhantomArenaReportCardInfo(int cost)
		{
		}

		// Token: 0x04016EF3 RID: 93939
		[Nullable(1)]
		public List<int> CardIdList = new List<int>();

		// Token: 0x04016EF4 RID: 93940
		public int Cost = cost;
	}
}
