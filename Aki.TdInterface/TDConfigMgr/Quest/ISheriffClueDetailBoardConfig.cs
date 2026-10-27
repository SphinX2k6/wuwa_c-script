using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001130 RID: 4400
	public class ISheriffClueDetailBoardConfig
	{
		// Token: 0x060063F8 RID: 25592 RVA: 0x000F0AFE File Offset: 0x000EECFE
		[NullableContext(1)]
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

		// Token: 0x04003C23 RID: 15395
		[Nullable(2)]
		protected ISheriffClueDetailBoardConfig FbInstance;
	}
}
