using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x0200648B RID: 25739
	public class MoonChasingMainViewModel
	{
		// Token: 0x040219D9 RID: 137689
		public EMoonChasingSkipDefine SkipTarget;

		// Token: 0x040219DA RID: 137690
		public bool BuildingBackToBusiness;

		// Token: 0x040219DB RID: 137691
		public int RefreshBuildingId;

		// Token: 0x040219DC RID: 137692
		public bool IsInBuildingModule;

		// Token: 0x040219DD RID: 137693
		public EMoonChasingTaskType TaskType = EMoonChasingTaskType.MainLine;

		// Token: 0x040219DE RID: 137694
		public bool IsLastTask;
	}
}
