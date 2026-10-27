using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004643 RID: 17987
	public class IEquipGraduatedWeaponToTeamT
	{
		// Token: 0x17007FA0 RID: 32672
		// (get) Token: 0x0601B3EF RID: 111599 RVA: 0x003E09DE File Offset: 0x003DEBDE
		// (set) Token: 0x0601B3F0 RID: 111600 RVA: 0x003E09E6 File Offset: 0x003DEBE6
		public EGmCommand Type { get; set; }

		// Token: 0x0601B3F1 RID: 111601 RVA: 0x003E09EF File Offset: 0x003DEBEF
		public IEquipGraduatedWeaponToTeamT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
