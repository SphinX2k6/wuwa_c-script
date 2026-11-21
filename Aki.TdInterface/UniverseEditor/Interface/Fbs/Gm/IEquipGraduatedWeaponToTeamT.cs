using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAB RID: 19115
	public class IEquipGraduatedWeaponToTeamT
	{
		// Token: 0x170085E1 RID: 34273
		// (get) Token: 0x0601CBC4 RID: 117700 RVA: 0x0040CC7A File Offset: 0x0040AE7A
		// (set) Token: 0x0601CBC5 RID: 117701 RVA: 0x0040CC82 File Offset: 0x0040AE82
		public EGmCommand Type { get; set; }

		// Token: 0x0601CBC6 RID: 117702 RVA: 0x0040CC8B File Offset: 0x0040AE8B
		public IEquipGraduatedWeaponToTeamT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
