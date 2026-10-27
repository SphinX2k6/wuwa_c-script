using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ADC RID: 19164
	public class ICheckPlayerCanJoinActivityTypeT
	{
		// Token: 0x17008AF4 RID: 35572
		// (get) Token: 0x0601E1AE RID: 123310 RVA: 0x00439200 File Offset: 0x00437400
		// (set) Token: 0x0601E1AF RID: 123311 RVA: 0x00439208 File Offset: 0x00437408
		public ECheckPlayerCanJoinActivityType Type { get; set; }

		// Token: 0x17008AF5 RID: 35573
		// (get) Token: 0x0601E1B0 RID: 123312 RVA: 0x00439211 File Offset: 0x00437411
		// (set) Token: 0x0601E1B1 RID: 123313 RVA: 0x00439219 File Offset: 0x00437419
		public bool CanJoin { get; set; }

		// Token: 0x0601E1B2 RID: 123314 RVA: 0x00439222 File Offset: 0x00437422
		public ICheckPlayerCanJoinActivityTypeT()
		{
			this.Type = ECheckPlayerCanJoinActivityType.Rogue;
			this.CanJoin = false;
		}
	}
}
