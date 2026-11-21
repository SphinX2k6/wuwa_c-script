using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005059 RID: 20569
	public class ICheckVillageInfrLevelT
	{
		// Token: 0x1700933B RID: 37691
		// (get) Token: 0x06020289 RID: 131721 RVA: 0x00475B94 File Offset: 0x00473D94
		// (set) Token: 0x0602028A RID: 131722 RVA: 0x00475B9C File Offset: 0x00473D9C
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x1700933C RID: 37692
		// (get) Token: 0x0602028B RID: 131723 RVA: 0x00475BA5 File Offset: 0x00473DA5
		// (set) Token: 0x0602028C RID: 131724 RVA: 0x00475BAD File Offset: 0x00473DAD
		public int Level { get; set; }

		// Token: 0x0602028D RID: 131725 RVA: 0x00475BB6 File Offset: 0x00473DB6
		public ICheckVillageInfrLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Level = 0;
		}
	}
}
