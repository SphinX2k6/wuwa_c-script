using System;
using System.Runtime.CompilerServices;

// Token: 0x02001423 RID: 5155
[NullableContext(1)]
[Nullable(0)]
internal class PinballBattleBossSkillTipsControllerParam : IPinballBattleBossSkillTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000C8B RID: 3211
	// (get) Token: 0x0600915C RID: 37212 RVA: 0x001F2D6E File Offset: 0x001F0F6E
	// (set) Token: 0x0600915D RID: 37213 RVA: 0x001F2D76 File Offset: 0x001F0F76
	public string TextId { get; set; } = "";

	// Token: 0x17000C8C RID: 3212
	// (get) Token: 0x0600915E RID: 37214 RVA: 0x001F2D7F File Offset: 0x001F0F7F
	// (set) Token: 0x0600915F RID: 37215 RVA: 0x001F2D87 File Offset: 0x001F0F87
	[Nullable(2)]
	public Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000C8D RID: 3213
	// (get) Token: 0x06009160 RID: 37216 RVA: 0x001F2D90 File Offset: 0x001F0F90
	// (set) Token: 0x06009161 RID: 37217 RVA: 0x001F2D98 File Offset: 0x001F0F98
	public bool? AddMask { get; set; }

	// Token: 0x17000C8E RID: 3214
	// (get) Token: 0x06009162 RID: 37218 RVA: 0x001F2DA1 File Offset: 0x001F0FA1
	// (set) Token: 0x06009163 RID: 37219 RVA: 0x001F2DA9 File Offset: 0x001F0FA9
	public int? CloseTime { get; set; }

	// Token: 0x17000C8F RID: 3215
	// (get) Token: 0x06009164 RID: 37220 RVA: 0x001F2DB2 File Offset: 0x001F0FB2
	// (set) Token: 0x06009165 RID: 37221 RVA: 0x001F2DBA File Offset: 0x001F0FBA
	public bool? MoveToBehind { get; set; }
}
