using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC1 RID: 27585
	public class IDeadeyeEnergyConfigT
	{
		// Token: 0x1700CA69 RID: 51817
		// (get) Token: 0x0602F7CC RID: 194508 RVA: 0x00679EA2 File Offset: 0x006780A2
		// (set) Token: 0x0602F7CD RID: 194509 RVA: 0x00679EAA File Offset: 0x006780AA
		public int MaxEnergy { get; set; }

		// Token: 0x1700CA6A RID: 51818
		// (get) Token: 0x0602F7CE RID: 194510 RVA: 0x00679EB3 File Offset: 0x006780B3
		// (set) Token: 0x0602F7CF RID: 194511 RVA: 0x00679EBB File Offset: 0x006780BB
		public int BulletConsumption { get; set; }

		// Token: 0x1700CA6B RID: 51819
		// (get) Token: 0x0602F7D0 RID: 194512 RVA: 0x00679EC4 File Offset: 0x006780C4
		// (set) Token: 0x0602F7D1 RID: 194513 RVA: 0x00679ECC File Offset: 0x006780CC
		public int TimeConsumption { get; set; }

		// Token: 0x0602F7D2 RID: 194514 RVA: 0x00679ED5 File Offset: 0x006780D5
		public IDeadeyeEnergyConfigT()
		{
			this.MaxEnergy = 0;
			this.BulletConsumption = 0;
			this.TimeConsumption = 0;
		}
	}
}
