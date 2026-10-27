using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C5 RID: 25029
	public class RoadBookLevelData : IRoadBookLevelData
	{
		// Token: 0x17009222 RID: 37410
		// (get) Token: 0x0603F3A4 RID: 258980 RVA: 0x00F470A7 File Offset: 0x00F452A7
		// (set) Token: 0x0603F3A5 RID: 258981 RVA: 0x00F470AF File Offset: 0x00F452AF
		public int Id { get; set; }

		// Token: 0x17009223 RID: 37411
		// (get) Token: 0x0603F3A6 RID: 258982 RVA: 0x00F470B8 File Offset: 0x00F452B8
		// (set) Token: 0x0603F3A7 RID: 258983 RVA: 0x00F470C0 File Offset: 0x00F452C0
		public int Level { get; set; }

		// Token: 0x17009224 RID: 37412
		// (get) Token: 0x0603F3A8 RID: 258984 RVA: 0x00F470C9 File Offset: 0x00F452C9
		// (set) Token: 0x0603F3A9 RID: 258985 RVA: 0x00F470D1 File Offset: 0x00F452D1
		public int AccumulateExp { get; set; }

		// Token: 0x17009225 RID: 37413
		// (get) Token: 0x0603F3AA RID: 258986 RVA: 0x00F470DA File Offset: 0x00F452DA
		// (set) Token: 0x0603F3AB RID: 258987 RVA: 0x00F470E2 File Offset: 0x00F452E2
		public int TargetExp { get; set; }
	}
}
