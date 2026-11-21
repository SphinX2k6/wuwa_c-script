using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200048D RID: 1165
	internal enum CausalityRelation
	{
		// Token: 0x04000FA7 RID: 4007
		AssignDelegate,
		// Token: 0x04000FA8 RID: 4008
		Join,
		// Token: 0x04000FA9 RID: 4009
		Choice,
		// Token: 0x04000FAA RID: 4010
		Cancel,
		// Token: 0x04000FAB RID: 4011
		Error
	}
}
