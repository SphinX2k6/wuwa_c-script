using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DB RID: 987
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dBase_SetValue
	{
		// Token: 0x04000FBB RID: 4027
		public EGraph3dType Type;

		// Token: 0x04000FBC RID: 4028
		public List<IGraph3dNodeBase> Nodes;

		// Token: 0x04000FBD RID: 4029
		public List<IGraph3dEdgeBase> Edges;
	}
}
