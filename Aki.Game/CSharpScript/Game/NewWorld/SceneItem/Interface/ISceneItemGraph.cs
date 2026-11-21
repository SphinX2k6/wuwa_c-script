using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062AC RID: 25260
	[NullableContext(1)]
	public interface ISceneItemGraph
	{
		// Token: 0x0603CFB0 RID: 249776
		void DebugDraw(int debugLevel);

		// Token: 0x0603CFB1 RID: 249777
		[NullableContext(2)]
		Vector GetNodeLocation(int nodeId);

		// Token: 0x0603CFB2 RID: 249778
		int? GetNodeIdAtLocation(Vector location, double radius);

		// Token: 0x0603CFB3 RID: 249779
		List<int> GetNeighborNodeIds(int nodeId);

		// Token: 0x0603CFB4 RID: 249780
		[NullableContext(0)]
		ValueTuple<int, int>? GetCurrentEdge([Nullable(1)] Vector location);

		// Token: 0x0603CFB5 RID: 249781
		double? GetNearestNodeDistSquared(Vector location);
	}
}
