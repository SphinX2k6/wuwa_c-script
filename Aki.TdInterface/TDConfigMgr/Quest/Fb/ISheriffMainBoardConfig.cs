using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141A RID: 5146
	public class ISheriffMainBoardConfig
	{
		// Token: 0x060074EE RID: 29934 RVA: 0x001176F6 File Offset: 0x001158F6
		[NullableContext(1)]
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

		// Token: 0x040043B2 RID: 17330
		private ISheriffMainBoardConfig Instance;
	}
}
