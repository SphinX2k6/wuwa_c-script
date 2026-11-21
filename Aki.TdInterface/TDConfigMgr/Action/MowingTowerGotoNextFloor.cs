using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002344 RID: 9028
	public class MowingTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600C494 RID: 50324 RVA: 0x001C2F74 File Offset: 0x001C1174
		public static MowingTowerGotoNextFloor Create([Nullable(2)] MowingTowerGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MowingTowerGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007507 RID: 29959
		[Nullable(2)]
		protected new MowingTowerGotoNextFloor FbInstance;
	}
}
