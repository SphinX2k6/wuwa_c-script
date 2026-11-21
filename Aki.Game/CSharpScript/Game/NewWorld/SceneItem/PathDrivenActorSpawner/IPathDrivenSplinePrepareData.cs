using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006282 RID: 25218
	[NullableContext(1)]
	public interface IPathDrivenSplinePrepareData
	{
		// Token: 0x1700733A RID: 29498
		// (get) Token: 0x0603CDD5 RID: 249301
		// (set) Token: 0x0603CDD6 RID: 249302
		int SplineEntityId { get; set; }

		// Token: 0x1700733B RID: 29499
		// (get) Token: 0x0603CDD7 RID: 249303
		// (set) Token: 0x0603CDD8 RID: 249304
		ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x1700733C RID: 29500
		// (get) Token: 0x0603CDD9 RID: 249305
		// (set) Token: 0x0603CDDA RID: 249306
		List<string> CurvePaths { get; set; }
	}
}
