using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006969 RID: 26985
	public class ActionPlotInterludeAction : ActionParams
	{
		// Token: 0x04022FFA RID: 143354
		public float FadeInTime;

		// Token: 0x04022FFB RID: 143355
		public float FadeOutTime;

		// Token: 0x04022FFC RID: 143356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ActionList;
	}
}
