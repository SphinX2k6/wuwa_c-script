using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E4 RID: 2020
	public class ISunSpiritPlayerBattleConfig
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x00071876 File Offset: 0x0006FA76
		public static ISunSpiritPlayerBattleConfig Create([Nullable(2)] ISunSpiritPlayerBattleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritPlayerBattleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x04001D09 RID: 7433
		[Nullable(2)]
		protected ISunSpiritPlayerBattleConfig FbInstance;
	}
}
