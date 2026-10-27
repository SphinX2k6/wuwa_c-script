using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A54 RID: 19028
	public interface ITrapDefensePauseInfo
	{
		// Token: 0x17007A6A RID: 31338
		// (get) Token: 0x060315D0 RID: 202192
		// (set) Token: 0x060315D1 RID: 202193
		ETrapDefensePauseInfoType Type { get; set; }

		// Token: 0x17007A6B RID: 31339
		// (get) Token: 0x060315D2 RID: 202194
		// (set) Token: 0x060315D3 RID: 202195
		int? Value { get; set; }

		// Token: 0x17007A6C RID: 31340
		// (get) Token: 0x060315D4 RID: 202196
		// (set) Token: 0x060315D5 RID: 202197
		int? MaxBatch { get; set; }
	}
}
