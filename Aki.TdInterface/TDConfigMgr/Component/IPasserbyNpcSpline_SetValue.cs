using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D1 RID: 1489
	public class IPasserbyNpcSpline_SetValue
	{
		// Token: 0x04001642 RID: 5698
		public int SplineEntityId;

		// Token: 0x04001643 RID: 5699
		public int SpawnWeight;

		// Token: 0x04001644 RID: 5700
		public bool? IsLoop;

		// Token: 0x04001645 RID: 5701
		[Nullable(2)]
		public IPasserbyNpcMoveState MoveState;

		// Token: 0x04001646 RID: 5702
		public bool? IsIkEnabled;
	}
}
