using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x0200636D RID: 25453
	public interface IPinballFormationViewData
	{
		// Token: 0x1700933E RID: 37694
		// (get) Token: 0x0604006A RID: 262250
		// (set) Token: 0x0604006B RID: 262251
		int LevelId { get; set; }

		// Token: 0x1700933F RID: 37695
		// (get) Token: 0x0604006C RID: 262252
		// (set) Token: 0x0604006D RID: 262253
		bool? IsRestart { get; set; }

		// Token: 0x17009340 RID: 37696
		// (get) Token: 0x0604006E RID: 262254
		// (set) Token: 0x0604006F RID: 262255
		bool? IfReturnToPinballMainView { get; set; }
	}
}
