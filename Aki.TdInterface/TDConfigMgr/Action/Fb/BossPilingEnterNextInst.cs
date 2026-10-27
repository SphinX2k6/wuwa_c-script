using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF8 RID: 11000
	public class BossPilingEnterNextInst : ActionParams
	{
		// Token: 0x0600F0FA RID: 61690 RVA: 0x0022F70C File Offset: 0x0022D90C
		[NullableContext(1)]
		public static BossPilingEnterNextInst Create(IBossPilingEnterNextInst? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingEnterNextInst
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400848C RID: 33932
		private IBossPilingEnterNextInst Instance;
	}
}
