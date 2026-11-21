using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002629 RID: 9769
[NullableContext(2)]
[Nullable(0)]
public class SkillTargetImpl : ISkillTarget
{
	// Token: 0x17002646 RID: 9798
	// (get) Token: 0x0601863D RID: 99901 RVA: 0x0075C128 File Offset: 0x0075A328
	// (set) Token: 0x0601863E RID: 99902 RVA: 0x0075C130 File Offset: 0x0075A330
	public int? LockOnConfigId { get; set; }

	// Token: 0x17002647 RID: 9799
	// (get) Token: 0x0601863F RID: 99903 RVA: 0x0075C139 File Offset: 0x0075A339
	// (set) Token: 0x06018640 RID: 99904 RVA: 0x0075C141 File Offset: 0x0075A341
	public ESkillTargetPriority? SkillTargetPriority { get; set; }

	// Token: 0x17002648 RID: 9800
	// (get) Token: 0x06018641 RID: 99905 RVA: 0x0075C14A File Offset: 0x0075A34A
	// (set) Token: 0x06018642 RID: 99906 RVA: 0x0075C152 File Offset: 0x0075A352
	public bool? ShowTarget { get; set; }

	// Token: 0x17002649 RID: 9801
	// (get) Token: 0x06018643 RID: 99907 RVA: 0x0075C15B File Offset: 0x0075A35B
	// (set) Token: 0x06018644 RID: 99908 RVA: 0x0075C163 File Offset: 0x0075A363
	public bool? GlobalTarget { get; set; }

	// Token: 0x1700264A RID: 9802
	// (get) Token: 0x06018645 RID: 99909 RVA: 0x0075C16C File Offset: 0x0075A36C
	// (set) Token: 0x06018646 RID: 99910 RVA: 0x0075C174 File Offset: 0x0075A374
	public string BlackboardKey { get; set; }

	// Token: 0x1700264B RID: 9803
	// (get) Token: 0x06018647 RID: 99911 RVA: 0x0075C17D File Offset: 0x0075A37D
	// (set) Token: 0x06018648 RID: 99912 RVA: 0x0075C185 File Offset: 0x0075A385
	public double? SkillTargetRemainTime { get; set; }
}
