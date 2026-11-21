using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002698 RID: 9880
[NullableContext(1)]
[Nullable(0)]
public class SkillBeginReplaceContext : ISkillBeginReplaceContext
{
	// Token: 0x1700273E RID: 10046
	// (get) Token: 0x06018BBA RID: 101306 RVA: 0x00781229 File Offset: 0x0077F429
	// (set) Token: 0x06018BBB RID: 101307 RVA: 0x00781231 File Offset: 0x0077F431
	public Skill SourceSkill { get; set; }

	// Token: 0x1700273F RID: 10047
	// (get) Token: 0x06018BBC RID: 101308 RVA: 0x0078123A File Offset: 0x0077F43A
	// (set) Token: 0x06018BBD RID: 101309 RVA: 0x00781242 File Offset: 0x0077F442
	public SSkillInfo SourceSkillInfo { get; set; }

	// Token: 0x17002740 RID: 10048
	// (get) Token: 0x06018BBE RID: 101310 RVA: 0x0078124B File Offset: 0x0077F44B
	// (set) Token: 0x06018BBF RID: 101311 RVA: 0x00781253 File Offset: 0x0077F453
	public ISkillParam SkillParam { get; set; }

	// Token: 0x17002741 RID: 10049
	// (get) Token: 0x06018BC0 RID: 101312 RVA: 0x0078125C File Offset: 0x0077F45C
	// (set) Token: 0x06018BC1 RID: 101313 RVA: 0x00781264 File Offset: 0x0077F464
	public IReadOnlyList<Skill> SkillsToInterrupt { get; set; }

	// Token: 0x17002742 RID: 10050
	// (get) Token: 0x06018BC2 RID: 101314 RVA: 0x0078126D File Offset: 0x0077F46D
	// (set) Token: 0x06018BC3 RID: 101315 RVA: 0x00781275 File Offset: 0x0077F475
	public Action InterruptSourceSkillTargets { get; set; }
}
