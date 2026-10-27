using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005568 RID: 21864
	public interface IMarkShowState
	{
		// Token: 0x17008603 RID: 34307
		// (get) Token: 0x06037C02 RID: 228354
		// (set) Token: 0x06037C03 RID: 228355
		int Id { get; set; }

		// Token: 0x17008604 RID: 34308
		// (get) Token: 0x06037C04 RID: 228356
		// (set) Token: 0x06037C05 RID: 228357
		bool NeedFocus { get; set; }

		// Token: 0x17008605 RID: 34309
		// (get) Token: 0x06037C06 RID: 228358
		// (set) Token: 0x06037C07 RID: 228359
		MapMarkShowFlag ShowFlag { get; set; }
	}
}
