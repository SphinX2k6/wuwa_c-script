using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB3 RID: 3763
	public class ISunSpiritPlayerBattleConfig
	{
		// Token: 0x060054DC RID: 21724 RVA: 0x000D0D55 File Offset: 0x000CEF55
		public static ISunSpiritPlayerBattleConfig Create(ISunSpiritPlayerBattleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritPlayerBattleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04003086 RID: 12422
		private ISunSpiritPlayerBattleConfig Instance;
	}
}
