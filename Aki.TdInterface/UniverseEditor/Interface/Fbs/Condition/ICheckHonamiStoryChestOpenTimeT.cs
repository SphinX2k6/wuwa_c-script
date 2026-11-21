using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F1B RID: 20251
	public class ICheckHonamiStoryChestOpenTimeT
	{
		// Token: 0x1700909D RID: 37021
		// (get) Token: 0x0601F779 RID: 128889 RVA: 0x004617C8 File Offset: 0x0045F9C8
		// (set) Token: 0x0601F77A RID: 128890 RVA: 0x004617D0 File Offset: 0x0045F9D0
		public ECondition Type { get; set; }

		// Token: 0x1700909E RID: 37022
		// (get) Token: 0x0601F77B RID: 128891 RVA: 0x004617D9 File Offset: 0x0045F9D9
		// (set) Token: 0x0601F77C RID: 128892 RVA: 0x004617E1 File Offset: 0x0045F9E1
		public EHonamiStoryChestType ChestType { get; set; }

		// Token: 0x1700909F RID: 37023
		// (get) Token: 0x0601F77D RID: 128893 RVA: 0x004617EA File Offset: 0x0045F9EA
		// (set) Token: 0x0601F77E RID: 128894 RVA: 0x004617F2 File Offset: 0x0045F9F2
		public ECompare Compare { get; set; }

		// Token: 0x170090A0 RID: 37024
		// (get) Token: 0x0601F77F RID: 128895 RVA: 0x004617FB File Offset: 0x0045F9FB
		// (set) Token: 0x0601F780 RID: 128896 RVA: 0x00461803 File Offset: 0x0045FA03
		public int Time { get; set; }

		// Token: 0x0601F781 RID: 128897 RVA: 0x0046180C File Offset: 0x0045FA0C
		public ICheckHonamiStoryChestOpenTimeT()
		{
			this.Type = ECondition.CompareVar;
			this.ChestType = EHonamiStoryChestType.CommonChest;
			this.Compare = ECompare.Eq;
			this.Time = 0;
		}
	}
}
