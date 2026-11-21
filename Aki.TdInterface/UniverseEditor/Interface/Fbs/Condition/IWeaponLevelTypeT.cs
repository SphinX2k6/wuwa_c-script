using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200521B RID: 21019
	public class IWeaponLevelTypeT
	{
		// Token: 0x17009660 RID: 38496
		// (get) Token: 0x060211B3 RID: 135603 RVA: 0x00492986 File Offset: 0x00490B86
		// (set) Token: 0x060211B4 RID: 135604 RVA: 0x0049298E File Offset: 0x00490B8E
		public EWeaponLevelType Type { get; set; }

		// Token: 0x060211B5 RID: 135605 RVA: 0x00492997 File Offset: 0x00490B97
		public IWeaponLevelTypeT()
		{
			this.Type = EWeaponLevelType.SpecifyRole;
		}
	}
}
