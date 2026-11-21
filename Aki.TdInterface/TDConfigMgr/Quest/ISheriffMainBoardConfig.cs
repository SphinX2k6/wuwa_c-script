using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125F RID: 4703
	public class ISheriffMainBoardConfig
	{
		// Token: 0x060069F5 RID: 27125 RVA: 0x000FDC8D File Offset: 0x000FBE8D
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

		// Token: 0x04003F72 RID: 16242
		[Nullable(2)]
		protected ISheriffMainBoardConfig FbInstance;
	}
}
