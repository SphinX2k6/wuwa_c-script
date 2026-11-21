using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B0 RID: 17840
	public interface IFetterStarLvData
	{
		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x0602CF04 RID: 184068
		// (set) Token: 0x0602CF05 RID: 184069
		int StageLv { get; set; }

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x0602CF06 RID: 184070
		// (set) Token: 0x0602CF07 RID: 184071
		int StageStarLv { get; set; }

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x0602CF08 RID: 184072
		// (set) Token: 0x0602CF09 RID: 184073
		int CurrentLv { get; set; }

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x0602CF0A RID: 184074
		// (set) Token: 0x0602CF0B RID: 184075
		int MaxLv { get; set; }
	}
}
