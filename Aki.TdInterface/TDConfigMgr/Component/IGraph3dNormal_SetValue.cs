using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E7 RID: 999
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dNormal_SetValue
	{
		// Token: 0x04000FDD RID: 4061
		public EGraph3dType Type;

		// Token: 0x04000FDE RID: 4062
		public List<IGraph3dNodeBase> Nodes;

		// Token: 0x04000FDF RID: 4063
		public List<IGraph3dEdgeBase> Edges;
	}
}
