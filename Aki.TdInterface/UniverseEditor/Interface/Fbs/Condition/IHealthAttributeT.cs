using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C3B RID: 19515
	public class IHealthAttributeT
	{
		// Token: 0x17008DC6 RID: 36294
		// (get) Token: 0x0601EEE5 RID: 126693 RVA: 0x00453D4A File Offset: 0x00451F4A
		// (set) Token: 0x0601EEE6 RID: 126694 RVA: 0x00453D52 File Offset: 0x00451F52
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x17008DC7 RID: 36295
		// (get) Token: 0x0601EEE7 RID: 126695 RVA: 0x00453D5B File Offset: 0x00451F5B
		// (set) Token: 0x0601EEE8 RID: 126696 RVA: 0x00453D63 File Offset: 0x00451F63
		public ECompare Compare { get; set; }

		// Token: 0x17008DC8 RID: 36296
		// (get) Token: 0x0601EEE9 RID: 126697 RVA: 0x00453D6C File Offset: 0x00451F6C
		// (set) Token: 0x0601EEEA RID: 126698 RVA: 0x00453D74 File Offset: 0x00451F74
		public float Value { get; set; }

		// Token: 0x0601EEEB RID: 126699 RVA: 0x00453D7D File Offset: 0x00451F7D
		public IHealthAttributeT()
		{
			this.Type = EPlayerAttributeType.Health;
			this.Compare = ECompare.Eq;
			this.Value = 0f;
		}
	}
}
