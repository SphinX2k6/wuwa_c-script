using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A5D RID: 19037
	public interface ITrapDefenseResultUnlockInfo
	{
		// Token: 0x17007A7C RID: 31356
		// (get) Token: 0x060315F7 RID: 202231
		// (set) Token: 0x060315F8 RID: 202232
		ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17007A7D RID: 31357
		// (get) Token: 0x060315F9 RID: 202233
		// (set) Token: 0x060315FA RID: 202234
		int Id { get; set; }

		// Token: 0x17007A7E RID: 31358
		// (get) Token: 0x060315FB RID: 202235
		// (set) Token: 0x060315FC RID: 202236
		bool? NeedUnlockBar { get; set; }

		// Token: 0x17007A7F RID: 31359
		// (get) Token: 0x060315FD RID: 202237
		// (set) Token: 0x060315FE RID: 202238
		bool? IsFinish { get; set; }

		// Token: 0x17007A80 RID: 31360
		// (get) Token: 0x060315FF RID: 202239
		// (set) Token: 0x06031600 RID: 202240
		bool? IsNewUnlock { get; set; }

		// Token: 0x17007A81 RID: 31361
		// (get) Token: 0x06031601 RID: 202241
		// (set) Token: 0x06031602 RID: 202242
		bool? ForShare { get; set; }
	}
}
