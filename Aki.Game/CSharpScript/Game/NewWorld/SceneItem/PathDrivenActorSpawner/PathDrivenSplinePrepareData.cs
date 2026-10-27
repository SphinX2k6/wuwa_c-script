using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CE RID: 29134
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenSplinePrepareData : IPathDrivenSplinePrepareData
	{
		// Token: 0x17009DE6 RID: 40422
		// (get) Token: 0x060474D9 RID: 292057 RVA: 0x01221CBE File Offset: 0x0121FEBE
		// (set) Token: 0x060474DA RID: 292058 RVA: 0x01221CC6 File Offset: 0x0121FEC6
		public int SplineEntityId { get; set; }

		// Token: 0x17009DE7 RID: 40423
		// (get) Token: 0x060474DB RID: 292059 RVA: 0x01221CCF File Offset: 0x0121FECF
		// (set) Token: 0x060474DC RID: 292060 RVA: 0x01221CD7 File Offset: 0x0121FED7
		public ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x17009DE8 RID: 40424
		// (get) Token: 0x060474DD RID: 292061 RVA: 0x01221CE0 File Offset: 0x0121FEE0
		// (set) Token: 0x060474DE RID: 292062 RVA: 0x01221CE8 File Offset: 0x0121FEE8
		public List<string> CurvePaths { get; set; }
	}
}
