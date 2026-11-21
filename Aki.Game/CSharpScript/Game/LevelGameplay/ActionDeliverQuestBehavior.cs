using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AC0 RID: 23232
	public class ActionDeliverQuestBehavior : ActionParams
	{
		// Token: 0x0401E1D1 RID: 123345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHandInItem> Items;

		// Token: 0x0401E1D2 RID: 123346
		[Nullable(1)]
		public string DescText = "";

		// Token: 0x0401E1D3 RID: 123347
		public int EntityId;

		// Token: 0x0401E1D4 RID: 123348
		public bool? RepeatItems;
	}
}
