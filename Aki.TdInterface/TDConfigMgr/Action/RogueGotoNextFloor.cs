using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D2 RID: 9170
	public class RogueGotoNextFloor : ActionParams
	{
		// Token: 0x0600C7D4 RID: 51156 RVA: 0x001C94E5 File Offset: 0x001C76E5
		public static RogueGotoNextFloor Create([Nullable(2)] RogueGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x040076AC RID: 30380
		[Nullable(2)]
		protected new RogueGotoNextFloor FbInstance;
	}
}
