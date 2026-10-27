using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007548 RID: 30024
	public class IVillageInfrVillageLevelT
	{
		// Token: 0x1700E3CC RID: 58316
		// (get) Token: 0x06036A04 RID: 223748 RVA: 0x0076BB54 File Offset: 0x00769D54
		// (set) Token: 0x06036A05 RID: 223749 RVA: 0x0076BB5C File Offset: 0x00769D5C
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x1700E3CD RID: 58317
		// (get) Token: 0x06036A06 RID: 223750 RVA: 0x0076BB65 File Offset: 0x00769D65
		// (set) Token: 0x06036A07 RID: 223751 RVA: 0x0076BB6D File Offset: 0x00769D6D
		public int Level { get; set; }

		// Token: 0x06036A08 RID: 223752 RVA: 0x0076BB76 File Offset: 0x00769D76
		public IVillageInfrVillageLevelT()
		{
			this.Type = EVillageInfrBuildType.Village;
			this.Level = 0;
		}
	}
}
