using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002176 RID: 8566
	public class RoleTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600BC58 RID: 48216 RVA: 0x001B2512 File Offset: 0x001B0712
		[NullableContext(1)]
		public static RoleTowerGotoNextFloor Create([Nullable(2)] RoleTowerGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoleTowerGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007080 RID: 28800
		[Nullable(2)]
		protected new RoleTowerGotoNextFloor FbInstance;
	}
}
