using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071A7 RID: 29095
	public class KuroSplineConstrainedDragFactory
	{
		// Token: 0x06047324 RID: 291620 RVA: 0x01217E64 File Offset: 0x01216064
		[NullableContext(1)]
		public static TsKuroSplineConstrainedDragImpl Create(IKuroSplineConstrainedDragParam param)
		{
			return new TsKuroSplineConstrainedDragImpl(param);
		}
	}
}
