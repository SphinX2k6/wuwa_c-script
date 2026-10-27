using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005137 RID: 20791
	public class PhantomArenaReportCardInfo
	{
		// Token: 0x0603516C RID: 217452 RVA: 0x00C9427A File Offset: 0x00C9247A
		public PhantomArenaReportCardInfo(int cost)
		{
		}

		// Token: 0x0401C4BE RID: 115902
		[Nullable(1)]
		public List<int> CardIdList = new List<int>();

		// Token: 0x0401C4BF RID: 115903
		public int Cost = cost;
	}
}
