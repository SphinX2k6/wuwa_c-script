using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF6 RID: 19190
	public class ISetEquippedWeaponToGraduateT
	{
		// Token: 0x17008679 RID: 34425
		// (get) Token: 0x0601CE98 RID: 118424 RVA: 0x004117D6 File Offset: 0x0040F9D6
		// (set) Token: 0x0601CE99 RID: 118425 RVA: 0x004117DE File Offset: 0x0040F9DE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CE9A RID: 118426 RVA: 0x004117E7 File Offset: 0x0040F9E7
		public ISetEquippedWeaponToGraduateT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
