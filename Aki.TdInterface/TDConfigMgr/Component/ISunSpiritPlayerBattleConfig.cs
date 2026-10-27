using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000743 RID: 1859
	public class ISunSpiritPlayerBattleConfig
	{
		// Token: 0x0600281D RID: 10269 RVA: 0x0006A6CE File Offset: 0x000688CE
		[NullableContext(1)]
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

		// Token: 0x04001B04 RID: 6916
		[Nullable(2)]
		protected ISunSpiritPlayerBattleConfig FbInstance;
	}
}
