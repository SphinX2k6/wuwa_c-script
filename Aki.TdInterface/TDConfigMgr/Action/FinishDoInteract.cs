using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189D RID: 6301
	public class FinishDoInteract : ActionParams
	{
		// Token: 0x06008445 RID: 33861 RVA: 0x0013BF4B File Offset: 0x0013A14B
		public static FinishDoInteract Create([Nullable(2)] FinishDoInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDoInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400543A RID: 21562
		[Nullable(2)]
		protected new FinishDoInteract FbInstance;
	}
}
