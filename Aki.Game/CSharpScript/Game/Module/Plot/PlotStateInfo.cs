using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FAD RID: 16301
	public class PlotStateInfo
	{
		// Token: 0x0602941F RID: 168991 RVA: 0x00B9767E File Offset: 0x00B9587E
		public PlotStateInfo()
		{
			this.StateMap = new Dictionary<int, PlayFlow>();
		}

		// Token: 0x06029420 RID: 168992 RVA: 0x00B97691 File Offset: 0x00B95891
		public void Reset()
		{
			this.StateMap.Clear();
		}

		// Token: 0x0401674B RID: 91979
		[Nullable(1)]
		public Dictionary<int, PlayFlow> StateMap;
	}
}
