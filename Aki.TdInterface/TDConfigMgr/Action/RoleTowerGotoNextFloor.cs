using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D7 RID: 9175
	public class RoleTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600C7E6 RID: 51174 RVA: 0x001C96C6 File Offset: 0x001C78C6
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

		// Token: 0x040076B5 RID: 30389
		[Nullable(2)]
		protected new RoleTowerGotoNextFloor FbInstance;
	}
}
