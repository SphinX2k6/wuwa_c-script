using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296C RID: 10604
	public class SettlementDungeon : ActionParams
	{
		// Token: 0x0600EB58 RID: 60248 RVA: 0x0022AECA File Offset: 0x002290CA
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

		// Token: 0x0400819E RID: 33182
		private ISettlementDungeon Instance;
	}
}
