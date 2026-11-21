using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001572 RID: 5490
	public class ISheriffClueDetailBoardConfig
	{
		// Token: 0x06007BB1 RID: 31665 RVA: 0x00126101 File Offset: 0x00124301
		public static ISheriffClueDetailBoardConfig Create(ISheriffClueDetailBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffClueDetailBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04004744 RID: 18244
		private ISheriffClueDetailBoardConfig Instance;
	}
}
