using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002453 RID: 9299
	public class SettlementDungeon : ActionParams
	{
		// Token: 0x0600CA69 RID: 51817 RVA: 0x001CE416 File Offset: 0x001CC616
		public static SettlementDungeon Create([Nullable(2)] SettlementDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SettlementDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400780B RID: 30731
		[Nullable(2)]
		protected new SettlementDungeon FbInstance;
	}
}
