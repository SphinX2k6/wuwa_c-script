using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CD RID: 29133
	[NullableContext(1)]
	public interface IPathDrivenSplinePrepareData
	{
		// Token: 0x17009DE3 RID: 40419
		// (get) Token: 0x060474D3 RID: 292051
		// (set) Token: 0x060474D4 RID: 292052
		int SplineEntityId { get; set; }

		// Token: 0x17009DE4 RID: 40420
		// (get) Token: 0x060474D5 RID: 292053
		// (set) Token: 0x060474D6 RID: 292054
		ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x17009DE5 RID: 40421
		// (get) Token: 0x060474D7 RID: 292055
		// (set) Token: 0x060474D8 RID: 292056
		List<string> CurvePaths { get; set; }
	}
}
