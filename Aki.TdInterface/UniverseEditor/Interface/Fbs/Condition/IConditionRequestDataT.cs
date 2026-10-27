using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BED RID: 19437
	public class IConditionRequestDataT
	{
		// Token: 0x17008D2E RID: 36142
		// (get) Token: 0x0601EC51 RID: 126033 RVA: 0x0044F94D File Offset: 0x0044DB4D
		// (set) Token: 0x0601EC52 RID: 126034 RVA: 0x0044F955 File Offset: 0x0044DB55
		public int RequestId { get; set; }

		// Token: 0x17008D2F RID: 36143
		// (get) Token: 0x0601EC53 RID: 126035 RVA: 0x0044F95E File Offset: 0x0044DB5E
		// (set) Token: 0x0601EC54 RID: 126036 RVA: 0x0044F966 File Offset: 0x0044DB66
		public string Uid { get; set; }

		// Token: 0x17008D30 RID: 36144
		// (get) Token: 0x0601EC55 RID: 126037 RVA: 0x0044F96F File Offset: 0x0044DB6F
		// (set) Token: 0x0601EC56 RID: 126038 RVA: 0x0044F977 File Offset: 0x0044DB77
		public TConditionDebugDataUnion ConditionGroup { get; set; }

		// Token: 0x0601EC57 RID: 126039 RVA: 0x0044F980 File Offset: 0x0044DB80
		public IConditionRequestDataT()
		{
			this.RequestId = 0;
			this.Uid = null;
			this.ConditionGroup = null;
		}
	}
}
