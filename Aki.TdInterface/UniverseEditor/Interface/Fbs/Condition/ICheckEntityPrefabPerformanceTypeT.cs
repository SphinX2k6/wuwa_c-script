using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A13 RID: 18963
	public class ICheckEntityPrefabPerformanceTypeT
	{
		// Token: 0x17008947 RID: 35143
		// (get) Token: 0x0601DAB7 RID: 121527 RVA: 0x0042CC3F File Offset: 0x0042AE3F
		// (set) Token: 0x0601DAB8 RID: 121528 RVA: 0x0042CC47 File Offset: 0x0042AE47
		public ECondition Type { get; set; }

		// Token: 0x17008948 RID: 35144
		// (get) Token: 0x0601DAB9 RID: 121529 RVA: 0x0042CC50 File Offset: 0x0042AE50
		// (set) Token: 0x0601DABA RID: 121530 RVA: 0x0042CC58 File Offset: 0x0042AE58
		public int EntityId { get; set; }

		// Token: 0x17008949 RID: 35145
		// (get) Token: 0x0601DABB RID: 121531 RVA: 0x0042CC61 File Offset: 0x0042AE61
		// (set) Token: 0x0601DABC RID: 121532 RVA: 0x0042CC69 File Offset: 0x0042AE69
		public string PerformanceTag { get; set; }

		// Token: 0x1700894A RID: 35146
		// (get) Token: 0x0601DABD RID: 121533 RVA: 0x0042CC72 File Offset: 0x0042AE72
		// (set) Token: 0x0601DABE RID: 121534 RVA: 0x0042CC7A File Offset: 0x0042AE7A
		public ECompare Compare { get; set; }

		// Token: 0x0601DABF RID: 121535 RVA: 0x0042CC83 File Offset: 0x0042AE83
		public ICheckEntityPrefabPerformanceTypeT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.PerformanceTag = null;
			this.Compare = ECompare.Eq;
		}
	}
}
