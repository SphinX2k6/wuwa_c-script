using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A9 RID: 9897
	public class SettlementDungeon : ActionParams
	{
		// Token: 0x0600DD81 RID: 56705 RVA: 0x0020E72A File Offset: 0x0020C92A
		[NullableContext(1)]
		public static SettlementDungeon Create(ISettlementDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SettlementDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007B01 RID: 31489
		private ISettlementDungeon Instance;
	}
}
