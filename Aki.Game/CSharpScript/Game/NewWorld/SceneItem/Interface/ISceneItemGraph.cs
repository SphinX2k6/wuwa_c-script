using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071F7 RID: 29175
	[NullableContext(1)]
	public interface ISceneItemGraph
	{
		// Token: 0x060476A8 RID: 292520
		void DebugDraw(int debugLevel);

		// Token: 0x060476A9 RID: 292521
		[NullableContext(2)]
		Vector GetNodeLocation(int nodeId);

		// Token: 0x060476AA RID: 292522
		int? GetNodeIdAtLocation(Vector location, double radius);

		// Token: 0x060476AB RID: 292523
		List<int> GetNeighborNodeIds(int nodeId);

		// Token: 0x060476AC RID: 292524
		[NullableContext(0)]
		ValueTuple<int, int>? GetCurrentEdge([Nullable(1)] Vector location);

		// Token: 0x060476AD RID: 292525
		double? GetNearestNodeDistSquared(Vector location);
	}
}
