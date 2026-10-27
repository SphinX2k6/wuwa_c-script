using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC7 RID: 19143
	public class ICheckLordGymFinishConditionT
	{
		// Token: 0x17008ACA RID: 35530
		// (get) Token: 0x0601E0F0 RID: 123120 RVA: 0x00437AD0 File Offset: 0x00435CD0
		// (set) Token: 0x0601E0F1 RID: 123121 RVA: 0x00437AD8 File Offset: 0x00435CD8
		public ECondition Type { get; set; }

		// Token: 0x17008ACB RID: 35531
		// (get) Token: 0x0601E0F2 RID: 123122 RVA: 0x00437AE1 File Offset: 0x00435CE1
		// (set) Token: 0x0601E0F3 RID: 123123 RVA: 0x00437AE9 File Offset: 0x00435CE9
		public int LordGymId { get; set; }

		// Token: 0x0601E0F4 RID: 123124 RVA: 0x00437AF2 File Offset: 0x00435CF2
		public ICheckLordGymFinishConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.LordGymId = 0;
		}
	}
}
