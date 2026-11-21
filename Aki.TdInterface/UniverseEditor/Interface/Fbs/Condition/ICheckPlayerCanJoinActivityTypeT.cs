using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB1 RID: 20401
	public class ICheckPlayerCanJoinActivityTypeT
	{
		// Token: 0x170091EB RID: 37355
		// (get) Token: 0x0601FCC3 RID: 130243 RVA: 0x0046AEAC File Offset: 0x004690AC
		// (set) Token: 0x0601FCC4 RID: 130244 RVA: 0x0046AEB4 File Offset: 0x004690B4
		public ECheckPlayerCanJoinActivityType Type { get; set; }

		// Token: 0x170091EC RID: 37356
		// (get) Token: 0x0601FCC5 RID: 130245 RVA: 0x0046AEBD File Offset: 0x004690BD
		// (set) Token: 0x0601FCC6 RID: 130246 RVA: 0x0046AEC5 File Offset: 0x004690C5
		public bool CanJoin { get; set; }

		// Token: 0x0601FCC7 RID: 130247 RVA: 0x0046AECE File Offset: 0x004690CE
		public ICheckPlayerCanJoinActivityTypeT()
		{
			this.Type = ECheckPlayerCanJoinActivityType.Rogue;
			this.CanJoin = false;
		}
	}
}
