using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000660 RID: 1632
	public class IPasserbyNpcSpline_SetValue
	{
		// Token: 0x04001813 RID: 6163
		public int SplineEntityId;

		// Token: 0x04001814 RID: 6164
		public int SpawnWeight;

		// Token: 0x04001815 RID: 6165
		public bool? IsLoop;

		// Token: 0x04001816 RID: 6166
		[Nullable(2)]
		public IPasserbyNpcMoveState MoveState;

		// Token: 0x04001817 RID: 6167
		public bool? IsIkEnabled;
	}
}
