using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125E RID: 4702
	public class ISheriffClueDetailBoardConfig
	{
		// Token: 0x060069F3 RID: 27123 RVA: 0x000FDC72 File Offset: 0x000FBE72
		public static ISheriffClueDetailBoardConfig Create([Nullable(2)] ISheriffClueDetailBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffClueDetailBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x04003F71 RID: 16241
		[Nullable(2)]
		protected ISheriffClueDetailBoardConfig FbInstance;
	}
}
