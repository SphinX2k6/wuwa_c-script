using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020015E3 RID: 5603
[NullableContext(1)]
[Nullable(0)]
public class PhantomArenaDeckUpdateEvent : PlayerCommonLogData
{
	// Token: 0x170014DF RID: 5343
	// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x00417AE4 File Offset: 0x00415CE4
	// (set) Token: 0x0600DDD1 RID: 56785 RVA: 0x00417AEC File Offset: 0x00415CEC
	public override string event_id { get; set; } = "1703";

	// Token: 0x04007D88 RID: 32136
	public int i_activity_id;

	// Token: 0x04007D89 RID: 32137
	public int i_deck_order;

	// Token: 0x04007D8A RID: 32138
	public string s_deck_name = "";

	// Token: 0x04007D8B RID: 32139
	public int i_operation;

	// Token: 0x04007D8C RID: 32140
	public PhantomArenaReportCardInfo[] o_deck_info = Array.Empty<PhantomArenaReportCardInfo>();

	// Token: 0x04007D8D RID: 32141
	public string o_build_click = "";

	// Token: 0x04007D8E RID: 32142
	public int i_build_id;

	// Token: 0x04007D8F RID: 32143
	public int i_deck_status;

	// Token: 0x04007D90 RID: 32144
	public int i_special_effect;
}
