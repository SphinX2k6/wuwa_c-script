using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x0200625C RID: 25180
	public class KuroSplineConstrainedDragFactory
	{
		// Token: 0x0603CC1F RID: 248863 RVA: 0x01171D68 File Offset: 0x0116FF68
		[NullableContext(1)]
		public static TsKuroSplineConstrainedDragImpl Create(IKuroSplineConstrainedDragParam param)
		{
			return new TsKuroSplineConstrainedDragImpl(param);
		}
	}
}
