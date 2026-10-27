using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001131 RID: 4401
	public class ISheriffMainBoardConfig
	{
		// Token: 0x060063FA RID: 25594 RVA: 0x000F0B19 File Offset: 0x000EED19
		[NullableContext(1)]
		public static ISheriffMainBoardConfig Create([Nullable(2)] ISheriffMainBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffMainBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x04003C24 RID: 15396
		[Nullable(2)]
		protected ISheriffMainBoardConfig FbInstance;
	}
}
