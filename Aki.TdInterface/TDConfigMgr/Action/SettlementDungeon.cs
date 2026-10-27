using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E8 RID: 8680
	public class SettlementDungeon : ActionParams
	{
		// Token: 0x0600BEAD RID: 48813 RVA: 0x001B6D8A File Offset: 0x001B4F8A
		[NullableContext(1)]
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

		// Token: 0x040071C2 RID: 29122
		[Nullable(2)]
		protected new SettlementDungeon FbInstance;
	}
}
