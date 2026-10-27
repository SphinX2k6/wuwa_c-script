using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x0200534E RID: 21326
	[NullableContext(1)]
	[Nullable(0)]
	public class RemainingData : IRemainingData
	{
		// Token: 0x1700832B RID: 33579
		// (get) Token: 0x060367AA RID: 223146 RVA: 0x00CE69F2 File Offset: 0x00CE4BF2
		// (set) Token: 0x060367AB RID: 223147 RVA: 0x00CE69FA File Offset: 0x00CE4BFA
		public string TextId { get; set; }

		// Token: 0x1700832C RID: 33580
		// (get) Token: 0x060367AC RID: 223148 RVA: 0x00CE6A03 File Offset: 0x00CE4C03
		// (set) Token: 0x060367AD RID: 223149 RVA: 0x00CE6A0B File Offset: 0x00CE4C0B
		public int Count { get; set; }

		// Token: 0x060367AE RID: 223150 RVA: 0x00CE6A14 File Offset: 0x00CE4C14
		public RemainingData(string textId, int count)
		{
			this.TextId = textId;
			this.Count = count;
		}
	}
}
