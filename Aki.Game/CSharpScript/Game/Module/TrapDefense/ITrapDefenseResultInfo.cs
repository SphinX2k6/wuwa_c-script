using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A59 RID: 19033
	public interface ITrapDefenseResultInfo
	{
		// Token: 0x17007A74 RID: 31348
		// (get) Token: 0x060315E6 RID: 202214
		// (set) Token: 0x060315E7 RID: 202215
		int Value { get; set; }

		// Token: 0x17007A75 RID: 31349
		// (get) Token: 0x060315E8 RID: 202216
		// (set) Token: 0x060315E9 RID: 202217
		ETrapDefenseResultType Type { get; set; }

		// Token: 0x17007A76 RID: 31350
		// (get) Token: 0x060315EA RID: 202218
		// (set) Token: 0x060315EB RID: 202219
		int? Total { get; set; }

		// Token: 0x17007A77 RID: 31351
		// (get) Token: 0x060315EC RID: 202220
		// (set) Token: 0x060315ED RID: 202221
		int? History { get; set; }
	}
}
