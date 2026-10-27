using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004658 RID: 18008
	public class IGetAllGraduatedWeaponT
	{
		// Token: 0x17007FD1 RID: 32721
		// (get) Token: 0x0601B4AB RID: 111787 RVA: 0x003E1D82 File Offset: 0x003DFF82
		// (set) Token: 0x0601B4AC RID: 111788 RVA: 0x003E1D8A File Offset: 0x003DFF8A
		public EGmCommand Type { get; set; }

		// Token: 0x0601B4AD RID: 111789 RVA: 0x003E1D93 File Offset: 0x003DFF93
		public IGetAllGraduatedWeaponT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
