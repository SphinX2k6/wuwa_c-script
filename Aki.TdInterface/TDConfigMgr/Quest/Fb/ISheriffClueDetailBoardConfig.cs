using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141B RID: 5147
	public class ISheriffClueDetailBoardConfig
	{
		// Token: 0x060074F0 RID: 29936 RVA: 0x0011771D File Offset: 0x0011591D
		[NullableContext(1)]
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

		// Token: 0x040043B3 RID: 17331
		private ISheriffClueDetailBoardConfig Instance;
	}
}
