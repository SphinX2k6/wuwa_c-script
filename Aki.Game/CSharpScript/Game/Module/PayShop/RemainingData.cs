using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004331 RID: 17201
	[NullableContext(1)]
	[Nullable(0)]
	public class RemainingData : IRemainingData
	{
		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x0602B6EB RID: 177899 RVA: 0x00C356F2 File Offset: 0x00C338F2
		// (set) Token: 0x0602B6EC RID: 177900 RVA: 0x00C356FA File Offset: 0x00C338FA
		public string TextId { get; set; }

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x0602B6ED RID: 177901 RVA: 0x00C35703 File Offset: 0x00C33903
		// (set) Token: 0x0602B6EE RID: 177902 RVA: 0x00C3570B File Offset: 0x00C3390B
		public int Count { get; set; }

		// Token: 0x0602B6EF RID: 177903 RVA: 0x00C35714 File Offset: 0x00C33914
		public RemainingData(string textId, int count)
		{
			this.TextId = textId;
			this.Count = count;
		}
	}
}
