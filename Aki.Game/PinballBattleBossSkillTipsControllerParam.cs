using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D7 RID: 2263
[NullableContext(1)]
[Nullable(0)]
internal class PinballBattleBossSkillTipsControllerParam : IPinballBattleBossSkillTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000CAB RID: 3243
	// (get) Token: 0x060064F1 RID: 25841 RVA: 0x001FB8AA File Offset: 0x001F9AAA
	// (set) Token: 0x060064F2 RID: 25842 RVA: 0x001FB8B2 File Offset: 0x001F9AB2
	public string TextId { get; set; } = "";

	// Token: 0x17000CAC RID: 3244
	// (get) Token: 0x060064F3 RID: 25843 RVA: 0x001FB8BB File Offset: 0x001F9ABB
	// (set) Token: 0x060064F4 RID: 25844 RVA: 0x001FB8C3 File Offset: 0x001F9AC3
	[Nullable(2)]
	public Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CAD RID: 3245
	// (get) Token: 0x060064F5 RID: 25845 RVA: 0x001FB8CC File Offset: 0x001F9ACC
	// (set) Token: 0x060064F6 RID: 25846 RVA: 0x001FB8D4 File Offset: 0x001F9AD4
	public bool? AddMask { get; set; }

	// Token: 0x17000CAE RID: 3246
	// (get) Token: 0x060064F7 RID: 25847 RVA: 0x001FB8DD File Offset: 0x001F9ADD
	// (set) Token: 0x060064F8 RID: 25848 RVA: 0x001FB8E5 File Offset: 0x001F9AE5
	public int? CloseTime { get; set; }

	// Token: 0x17000CAF RID: 3247
	// (get) Token: 0x060064F9 RID: 25849 RVA: 0x001FB8EE File Offset: 0x001F9AEE
	// (set) Token: 0x060064FA RID: 25850 RVA: 0x001FB8F6 File Offset: 0x001F9AF6
	public bool? MoveToBehind { get; set; }
}
