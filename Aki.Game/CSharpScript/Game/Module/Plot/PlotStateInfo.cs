using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE3 RID: 20451
	public class PlotStateInfo
	{
		// Token: 0x06034596 RID: 214422 RVA: 0x00C4D636 File Offset: 0x00C4B836
		public PlotStateInfo()
		{
			this.StateMap = new Dictionary<int, PlayFlow>();
		}

		// Token: 0x06034597 RID: 214423 RVA: 0x00C4D649 File Offset: 0x00C4B849
		public void Reset()
		{
			this.StateMap.Clear();
		}

		// Token: 0x0401BD70 RID: 114032
		[Nullable(1)]
		public Dictionary<int, PlayFlow> StateMap;
	}
}
