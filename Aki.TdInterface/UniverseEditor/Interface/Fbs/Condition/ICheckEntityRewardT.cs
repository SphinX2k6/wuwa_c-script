using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A16 RID: 18966
	public class ICheckEntityRewardT
	{
		// Token: 0x1700894F RID: 35151
		// (get) Token: 0x0601DAD3 RID: 121555 RVA: 0x0042CEF2 File Offset: 0x0042B0F2
		// (set) Token: 0x0601DAD4 RID: 121556 RVA: 0x0042CEFA File Offset: 0x0042B0FA
		public ECondition Type { get; set; }

		// Token: 0x17008950 RID: 35152
		// (get) Token: 0x0601DAD5 RID: 121557 RVA: 0x0042CF03 File Offset: 0x0042B103
		// (set) Token: 0x0601DAD6 RID: 121558 RVA: 0x0042CF0B File Offset: 0x0042B10B
		public int EntityId { get; set; }

		// Token: 0x17008951 RID: 35153
		// (get) Token: 0x0601DAD7 RID: 121559 RVA: 0x0042CF14 File Offset: 0x0042B114
		// (set) Token: 0x0601DAD8 RID: 121560 RVA: 0x0042CF1C File Offset: 0x0042B11C
		public byte NullMask { get; set; }

		// Token: 0x0601DAD9 RID: 121561 RVA: 0x0042CF25 File Offset: 0x0042B125
		public ICheckEntityRewardT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
