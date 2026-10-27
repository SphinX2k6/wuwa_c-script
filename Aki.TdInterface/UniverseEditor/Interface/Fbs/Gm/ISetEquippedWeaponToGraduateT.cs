using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468E RID: 18062
	public class ISetEquippedWeaponToGraduateT
	{
		// Token: 0x17008038 RID: 32824
		// (get) Token: 0x0601B6C3 RID: 112323 RVA: 0x003E553A File Offset: 0x003E373A
		// (set) Token: 0x0601B6C4 RID: 112324 RVA: 0x003E5542 File Offset: 0x003E3742
		public EGmCommand Type { get; set; }

		// Token: 0x0601B6C5 RID: 112325 RVA: 0x003E554B File Offset: 0x003E374B
		public ISetEquippedWeaponToGraduateT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
