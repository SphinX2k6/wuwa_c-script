using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x0200210B RID: 8459
[NullableContext(1)]
[Nullable(0)]
public class PhantomArenaDeckUpdateEvent : PlayerCommonLogData
{
	// Token: 0x170014B1 RID: 5297
	// (get) Token: 0x0601095D RID: 67933 RVA: 0x0040B3B0 File Offset: 0x004095B0
	// (set) Token: 0x0601095E RID: 67934 RVA: 0x0040B3B8 File Offset: 0x004095B8
	public override string event_id { get; set; } = "1703";

	// Token: 0x04007C86 RID: 31878
	public int i_activity_id;

	// Token: 0x04007C87 RID: 31879
	public int i_deck_order;

	// Token: 0x04007C88 RID: 31880
	public string s_deck_name = "";

	// Token: 0x04007C89 RID: 31881
	public int i_operation;

	// Token: 0x04007C8A RID: 31882
	public PhantomArenaReportCardInfo[] o_deck_info = Array.Empty<PhantomArenaReportCardInfo>();

	// Token: 0x04007C8B RID: 31883
	public string o_build_click = "";

	// Token: 0x04007C8C RID: 31884
	public int i_build_id;

	// Token: 0x04007C8D RID: 31885
	public int i_deck_status;

	// Token: 0x04007C8E RID: 31886
	public int i_special_effect;
}
