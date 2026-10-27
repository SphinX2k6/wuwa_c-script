using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006964 RID: 26980
	public class ActionDeliverQuestBehavior : ActionParams
	{
		// Token: 0x04022FE7 RID: 143335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHandInItem> Items;

		// Token: 0x04022FE8 RID: 143336
		[Nullable(1)]
		public string DescText = "";

		// Token: 0x04022FE9 RID: 143337
		public int EntityId;

		// Token: 0x04022FEA RID: 143338
		public bool? RepeatItems;
	}
}
