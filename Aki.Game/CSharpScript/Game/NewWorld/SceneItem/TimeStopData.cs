using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007196 RID: 29078
	public class TimeStopData
	{
		// Token: 0x06047254 RID: 291412 RVA: 0x01211AF6 File Offset: 0x0120FCF6
		[NullableContext(1)]
		public TimeStopData(PawnTimeScaleComponent timeScaleComponent, int timeScaleId, bool isSceneItem)
		{
			this.TimeScaleComponent = timeScaleComponent;
			this.TimeScaleId = new int?(timeScaleId);
			this.IsSceneItem = isSceneItem;
		}

		// Token: 0x04025672 RID: 153202
		[Nullable(2)]
		public PawnTimeScaleComponent TimeScaleComponent;

		// Token: 0x04025673 RID: 153203
		public int? TimeScaleId;

		// Token: 0x04025674 RID: 153204
		public bool IsSceneItem;
	}
}
