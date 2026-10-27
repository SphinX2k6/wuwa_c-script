using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1F RID: 19743
	public class IWeaponLevelTypeT
	{
		// Token: 0x17008F27 RID: 36647
		// (get) Token: 0x0601F56C RID: 128364 RVA: 0x0045E9F6 File Offset: 0x0045CBF6
		// (set) Token: 0x0601F56D RID: 128365 RVA: 0x0045E9FE File Offset: 0x0045CBFE
		public EWeaponLevelType Type { get; set; }

		// Token: 0x0601F56E RID: 128366 RVA: 0x0045EA07 File Offset: 0x0045CC07
		public IWeaponLevelTypeT()
		{
			this.Type = EWeaponLevelType.SpecifyRole;
		}
	}
}
