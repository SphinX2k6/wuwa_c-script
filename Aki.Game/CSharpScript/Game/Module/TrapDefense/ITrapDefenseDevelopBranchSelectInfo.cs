using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F9 RID: 14841
	public interface ITrapDefenseDevelopBranchSelectInfo
	{
		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x06026353 RID: 156499
		// (set) Token: 0x06026354 RID: 156500
		int Id { get; set; }

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x06026355 RID: 156501
		// (set) Token: 0x06026356 RID: 156502
		bool IsCurLevel { get; set; }

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x06026357 RID: 156503
		// (set) Token: 0x06026358 RID: 156504
		bool IsSelected { get; set; }
	}
}
