using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002171 RID: 8561
	public class RogueGotoNextFloor : ActionParams
	{
		// Token: 0x0600BC46 RID: 48198 RVA: 0x001B2331 File Offset: 0x001B0531
		[NullableContext(1)]
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

		// Token: 0x04007077 RID: 28791
		[Nullable(2)]
		protected new RogueGotoNextFloor FbInstance;
	}
}
