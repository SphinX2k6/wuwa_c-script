using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x0200534D RID: 21325
	[NullableContext(1)]
	public interface IRemainingData
	{
		// Token: 0x17008329 RID: 33577
		// (get) Token: 0x060367A6 RID: 223142
		// (set) Token: 0x060367A7 RID: 223143
		string TextId { get; set; }

		// Token: 0x1700832A RID: 33578
		// (get) Token: 0x060367A8 RID: 223144
		// (set) Token: 0x060367A9 RID: 223145
		int Count { get; set; }
	}
}
