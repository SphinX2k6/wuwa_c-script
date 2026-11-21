using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC0 RID: 19136
	public class IGetAllGraduatedWeaponT
	{
		// Token: 0x17008612 RID: 34322
		// (get) Token: 0x0601CC80 RID: 117888 RVA: 0x0040E01E File Offset: 0x0040C21E
		// (set) Token: 0x0601CC81 RID: 117889 RVA: 0x0040E026 File Offset: 0x0040C226
		public EGmCommand Type { get; set; }

		// Token: 0x0601CC82 RID: 117890 RVA: 0x0040E02F File Offset: 0x0040C22F
		public IGetAllGraduatedWeaponT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
