using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F7 RID: 14839
	public interface ITrapDefenseDevelopPreviewLevelInfo
	{
		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x06026346 RID: 156486
		// (set) Token: 0x06026347 RID: 156487
		int Id { get; set; }

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06026348 RID: 156488
		// (set) Token: 0x06026349 RID: 156489
		bool IsCurLevel { get; set; }

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x0602634A RID: 156490
		// (set) Token: 0x0602634B RID: 156491
		bool? NeedAlpha { get; set; }
	}
}
