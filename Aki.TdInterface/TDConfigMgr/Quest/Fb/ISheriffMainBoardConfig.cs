using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001571 RID: 5489
	public class ISheriffMainBoardConfig
	{
		// Token: 0x06007BAF RID: 31663 RVA: 0x001260DA File Offset: 0x001242DA
		public static ISheriffMainBoardConfig Create(ISheriffMainBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffMainBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04004743 RID: 18243
		private ISheriffMainBoardConfig Instance;
	}
}
