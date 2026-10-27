using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB7 RID: 3511
	public class ISunSpiritPlayerBattleConfig
	{
		// Token: 0x06004FB7 RID: 20407 RVA: 0x000C5505 File Offset: 0x000C3705
		[NullableContext(1)]
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

		// Token: 0x04002DC0 RID: 11712
		private ISunSpiritPlayerBattleConfig Instance;
	}
}
