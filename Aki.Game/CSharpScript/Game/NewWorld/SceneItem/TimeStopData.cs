using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200624B RID: 25163
	public class TimeStopData
	{
		// Token: 0x0603CB3D RID: 248637 RVA: 0x0116C058 File Offset: 0x0116A258
		[NullableContext(1)]
		public TimeStopData(PawnTimeScaleComponent timeScaleComponent, int timeScaleId, bool isSceneItem)
		{
			this.TimeScaleComponent = timeScaleComponent;
			this.TimeScaleId = new int?(timeScaleId);
			this.IsSceneItem = isSceneItem;
		}

		// Token: 0x040202E2 RID: 131810
		[Nullable(2)]
		public PawnTimeScaleComponent TimeScaleComponent;

		// Token: 0x040202E3 RID: 131811
		public int? TimeScaleId;

		// Token: 0x040202E4 RID: 131812
		public bool IsSceneItem;
	}
}
