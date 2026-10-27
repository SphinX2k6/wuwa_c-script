using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DCB RID: 15819
	public class IDateTimeT
	{
		// Token: 0x17006D33 RID: 27955
		// (get) Token: 0x06016141 RID: 90433 RVA: 0x0033124C File Offset: 0x0032F44C
		// (set) Token: 0x06016142 RID: 90434 RVA: 0x00331254 File Offset: 0x0032F454
		public int Hours { get; set; }

		// Token: 0x17006D34 RID: 27956
		// (get) Token: 0x06016143 RID: 90435 RVA: 0x0033125D File Offset: 0x0032F45D
		// (set) Token: 0x06016144 RID: 90436 RVA: 0x00331265 File Offset: 0x0032F465
		public int Minutes { get; set; }

		// Token: 0x17006D35 RID: 27957
		// (get) Token: 0x06016145 RID: 90437 RVA: 0x0033126E File Offset: 0x0032F46E
		// (set) Token: 0x06016146 RID: 90438 RVA: 0x00331276 File Offset: 0x0032F476
		public int Days { get; set; }

		// Token: 0x17006D36 RID: 27958
		// (get) Token: 0x06016147 RID: 90439 RVA: 0x0033127F File Offset: 0x0032F47F
		// (set) Token: 0x06016148 RID: 90440 RVA: 0x00331287 File Offset: 0x0032F487
		public byte NullMask { get; set; }

		// Token: 0x06016149 RID: 90441 RVA: 0x00331290 File Offset: 0x0032F490
		public IDateTimeT()
		{
			this.Hours = 0;
			this.Minutes = 0;
			this.Days = 0;
			this.NullMask = 0;
		}
	}
}
