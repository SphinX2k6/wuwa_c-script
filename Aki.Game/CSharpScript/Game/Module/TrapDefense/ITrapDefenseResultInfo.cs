using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A01 RID: 14849
	public interface ITrapDefenseResultInfo
	{
		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06026376 RID: 156534
		// (set) Token: 0x06026377 RID: 156535
		int Value { get; set; }

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x06026378 RID: 156536
		// (set) Token: 0x06026379 RID: 156537
		ETrapDefenseResultType Type { get; set; }

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x0602637A RID: 156538
		// (set) Token: 0x0602637B RID: 156539
		int? Total { get; set; }

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x0602637C RID: 156540
		// (set) Token: 0x0602637D RID: 156541
		int? History { get; set; }
	}
}
