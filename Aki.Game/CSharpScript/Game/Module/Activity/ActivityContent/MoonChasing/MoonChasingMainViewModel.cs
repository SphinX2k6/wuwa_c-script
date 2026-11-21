using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005409 RID: 21513
	public class MoonChasingMainViewModel
	{
		// Token: 0x0401C30A RID: 115466
		public EMoonChasingSkipDefine SkipTarget;

		// Token: 0x0401C30B RID: 115467
		public bool BuildingBackToBusiness;

		// Token: 0x0401C30C RID: 115468
		public int RefreshBuildingId;

		// Token: 0x0401C30D RID: 115469
		public bool IsInBuildingModule;

		// Token: 0x0401C30E RID: 115470
		public EMoonChasingTaskType TaskType = EMoonChasingTaskType.MainLine;

		// Token: 0x0401C30F RID: 115471
		public bool IsLastTask;
	}
}
