using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E3 RID: 8419
	public class MowingTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600B90A RID: 47370 RVA: 0x001ABE98 File Offset: 0x001AA098
		[NullableContext(1)]
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

		// Token: 0x04006ED6 RID: 28374
		[Nullable(2)]
		protected new MowingTowerGotoNextFloor FbInstance;
	}
}
