using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694D RID: 26957
	public class IChangeElementalBoxStateTargetBoxIdT
	{
		// Token: 0x1700C670 RID: 50800
		// (get) Token: 0x0602E35C RID: 189276 RVA: 0x0064FDDC File Offset: 0x0064DFDC
		// (set) Token: 0x0602E35D RID: 189277 RVA: 0x0064FDE4 File Offset: 0x0064DFE4
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x1700C671 RID: 50801
		// (get) Token: 0x0602E35E RID: 189278 RVA: 0x0064FDED File Offset: 0x0064DFED
		// (set) Token: 0x0602E35F RID: 189279 RVA: 0x0064FDF5 File Offset: 0x0064DFF5
		public int TargetBoxId { get; set; }

		// Token: 0x0602E360 RID: 189280 RVA: 0x0064FDFE File Offset: 0x0064DFFE
		public IChangeElementalBoxStateTargetBoxIdT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
			this.TargetBoxId = 0;
		}
	}
}
