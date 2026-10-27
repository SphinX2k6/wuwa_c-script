using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEC RID: 27372
	public class IMonsterStandByConfigT
	{
		// Token: 0x1700CB0F RID: 51983
		// (get) Token: 0x0602FFAC RID: 196524 RVA: 0x00686141 File Offset: 0x00684341
		// (set) Token: 0x0602FFAD RID: 196525 RVA: 0x00686149 File Offset: 0x00684349
		public string Tag { get; set; }

		// Token: 0x1700CB10 RID: 51984
		// (get) Token: 0x0602FFAE RID: 196526 RVA: 0x00686152 File Offset: 0x00684352
		// (set) Token: 0x0602FFAF RID: 196527 RVA: 0x0068615A File Offset: 0x0068435A
		public float Duration { get; set; }

		// Token: 0x1700CB11 RID: 51985
		// (get) Token: 0x0602FFB0 RID: 196528 RVA: 0x00686163 File Offset: 0x00684363
		// (set) Token: 0x0602FFB1 RID: 196529 RVA: 0x0068616B File Offset: 0x0068436B
		public int RepeatTimes { get; set; }

		// Token: 0x1700CB12 RID: 51986
		// (get) Token: 0x0602FFB2 RID: 196530 RVA: 0x00686174 File Offset: 0x00684374
		// (set) Token: 0x0602FFB3 RID: 196531 RVA: 0x0068617C File Offset: 0x0068437C
		public int EmotionId { get; set; }

		// Token: 0x1700CB13 RID: 51987
		// (get) Token: 0x0602FFB4 RID: 196532 RVA: 0x00686185 File Offset: 0x00684385
		// (set) Token: 0x0602FFB5 RID: 196533 RVA: 0x0068618D File Offset: 0x0068438D
		public byte NullMask { get; set; }

		// Token: 0x0602FFB6 RID: 196534 RVA: 0x00686196 File Offset: 0x00684396
		public IMonsterStandByConfigT()
		{
			this.Tag = null;
			this.Duration = 0f;
			this.RepeatTimes = 0;
			this.EmotionId = 0;
			this.NullMask = 0;
		}
	}
}
