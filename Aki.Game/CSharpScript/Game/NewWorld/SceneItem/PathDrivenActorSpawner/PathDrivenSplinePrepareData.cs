using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006283 RID: 25219
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenSplinePrepareData : IPathDrivenSplinePrepareData
	{
		// Token: 0x1700733D RID: 29501
		// (get) Token: 0x0603CDDB RID: 249307 RVA: 0x0117BAF5 File Offset: 0x01179CF5
		// (set) Token: 0x0603CDDC RID: 249308 RVA: 0x0117BAFD File Offset: 0x01179CFD
		public int SplineEntityId { get; set; }

		// Token: 0x1700733E RID: 29502
		// (get) Token: 0x0603CDDD RID: 249309 RVA: 0x0117BB06 File Offset: 0x01179D06
		// (set) Token: 0x0603CDDE RID: 249310 RVA: 0x0117BB0E File Offset: 0x01179D0E
		public ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x1700733F RID: 29503
		// (get) Token: 0x0603CDDF RID: 249311 RVA: 0x0117BB17 File Offset: 0x01179D17
		// (set) Token: 0x0603CDE0 RID: 249312 RVA: 0x0117BB1F File Offset: 0x01179D1F
		public List<string> CurvePaths { get; set; }
	}
}
