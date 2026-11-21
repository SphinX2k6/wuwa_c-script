using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D9 RID: 2265
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleLevelStartTipsControllerParam : IPinballBattleLevelStartTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000CB5 RID: 3253
	// (get) Token: 0x06006507 RID: 25863 RVA: 0x001FB96F File Offset: 0x001F9B6F
	// (set) Token: 0x06006508 RID: 25864 RVA: 0x001FB977 File Offset: 0x001F9B77
	public int CurWave { get; set; }

	// Token: 0x17000CB6 RID: 3254
	// (get) Token: 0x06006509 RID: 25865 RVA: 0x001FB980 File Offset: 0x001F9B80
	// (set) Token: 0x0600650A RID: 25866 RVA: 0x001FB988 File Offset: 0x001F9B88
	public int MaxWave { get; set; }

	// Token: 0x17000CB7 RID: 3255
	// (get) Token: 0x0600650B RID: 25867 RVA: 0x001FB991 File Offset: 0x001F9B91
	// (set) Token: 0x0600650C RID: 25868 RVA: 0x001FB999 File Offset: 0x001F9B99
	public Action CloseCallback { get; set; }

	// Token: 0x17000CB8 RID: 3256
	// (get) Token: 0x0600650D RID: 25869 RVA: 0x001FB9A2 File Offset: 0x001F9BA2
	// (set) Token: 0x0600650E RID: 25870 RVA: 0x001FB9AA File Offset: 0x001F9BAA
	public bool? AddMask { get; set; }

	// Token: 0x17000CB9 RID: 3257
	// (get) Token: 0x0600650F RID: 25871 RVA: 0x001FB9B3 File Offset: 0x001F9BB3
	// (set) Token: 0x06006510 RID: 25872 RVA: 0x001FB9BB File Offset: 0x001F9BBB
	public int? CloseTime { get; set; }

	// Token: 0x17000CBA RID: 3258
	// (get) Token: 0x06006511 RID: 25873 RVA: 0x001FB9C4 File Offset: 0x001F9BC4
	// (set) Token: 0x06006512 RID: 25874 RVA: 0x001FB9CC File Offset: 0x001F9BCC
	public bool? MoveToBehind { get; set; }
}
