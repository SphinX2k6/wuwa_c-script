using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAC RID: 27564
	public class IDartGameplayT
	{
		// Token: 0x1700CA3B RID: 51771
		// (get) Token: 0x0602F70E RID: 194318 RVA: 0x00678B35 File Offset: 0x00676D35
		// (set) Token: 0x0602F70F RID: 194319 RVA: 0x00678B3D File Offset: 0x00676D3D
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CA3C RID: 51772
		// (get) Token: 0x0602F710 RID: 194320 RVA: 0x00678B46 File Offset: 0x00676D46
		// (set) Token: 0x0602F711 RID: 194321 RVA: 0x00678B4E File Offset: 0x00676D4E
		public int MachineEntityId { get; set; }

		// Token: 0x1700CA3D RID: 51773
		// (get) Token: 0x0602F712 RID: 194322 RVA: 0x00678B57 File Offset: 0x00676D57
		// (set) Token: 0x0602F713 RID: 194323 RVA: 0x00678B5F File Offset: 0x00676D5F
		public TDartInteractTypeUnion InteractType { get; set; }

		// Token: 0x0602F714 RID: 194324 RVA: 0x00678B68 File Offset: 0x00676D68
		public IDartGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.MachineEntityId = 0;
			this.InteractType = null;
		}
	}
}
