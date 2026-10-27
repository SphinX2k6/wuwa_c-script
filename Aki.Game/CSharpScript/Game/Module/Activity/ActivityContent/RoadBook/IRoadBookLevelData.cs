using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C4 RID: 25028
	public interface IRoadBookLevelData
	{
		// Token: 0x1700921E RID: 37406
		// (get) Token: 0x0603F39C RID: 258972
		// (set) Token: 0x0603F39D RID: 258973
		int Id { get; set; }

		// Token: 0x1700921F RID: 37407
		// (get) Token: 0x0603F39E RID: 258974
		// (set) Token: 0x0603F39F RID: 258975
		int Level { get; set; }

		// Token: 0x17009220 RID: 37408
		// (get) Token: 0x0603F3A0 RID: 258976
		// (set) Token: 0x0603F3A1 RID: 258977
		int AccumulateExp { get; set; }

		// Token: 0x17009221 RID: 37409
		// (get) Token: 0x0603F3A2 RID: 258978
		// (set) Token: 0x0603F3A3 RID: 258979
		int TargetExp { get; set; }
	}
}
