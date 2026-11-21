using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006998 RID: 27032
	public class IChangeTargetEntityPrefabPerformanceT
	{
		// Token: 0x1700C701 RID: 50945
		// (get) Token: 0x0602E5EC RID: 189932 RVA: 0x00654409 File Offset: 0x00652609
		// (set) Token: 0x0602E5ED RID: 189933 RVA: 0x00654411 File Offset: 0x00652611
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700C702 RID: 50946
		// (get) Token: 0x0602E5EE RID: 189934 RVA: 0x0065441A File Offset: 0x0065261A
		// (set) Token: 0x0602E5EF RID: 189935 RVA: 0x00654422 File Offset: 0x00652622
		public int EntityId { get; set; }

		// Token: 0x1700C703 RID: 50947
		// (get) Token: 0x0602E5F0 RID: 189936 RVA: 0x0065442B File Offset: 0x0065262B
		// (set) Token: 0x0602E5F1 RID: 189937 RVA: 0x00654433 File Offset: 0x00652633
		public string PerformanceTag { get; set; }

		// Token: 0x0602E5F2 RID: 189938 RVA: 0x0065443C File Offset: 0x0065263C
		public IChangeTargetEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.EntityId = 0;
			this.PerformanceTag = null;
		}
	}
}
