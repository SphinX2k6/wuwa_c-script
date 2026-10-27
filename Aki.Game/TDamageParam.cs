using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002E6F RID: 11887
[NullableContext(1)]
[Nullable(0)]
public class TDamageParam : DamageEventInfo
{
	// Token: 0x170022DE RID: 8926
	// (get) Token: 0x0601965D RID: 104029 RVA: 0x0068CC91 File Offset: 0x0068AE91
	// (set) Token: 0x0601965E RID: 104030 RVA: 0x0068CC99 File Offset: 0x0068AE99
	public Damage DamageData { get; set; }

	// Token: 0x170022DF RID: 8927
	// (get) Token: 0x0601965F RID: 104031 RVA: 0x0068CCA2 File Offset: 0x0068AEA2
	// (set) Token: 0x06019660 RID: 104032 RVA: 0x0068CCAA File Offset: 0x0068AEAA
	public Entity DirectTarget { get; set; }

	// Token: 0x170022E0 RID: 8928
	// (get) Token: 0x06019661 RID: 104033 RVA: 0x0068CCB3 File Offset: 0x0068AEB3
	// (set) Token: 0x06019662 RID: 104034 RVA: 0x0068CCBB File Offset: 0x0068AEBB
	public int SkillLevel { get; set; }

	// Token: 0x170022E1 RID: 8929
	// (get) Token: 0x06019663 RID: 104035 RVA: 0x0068CCC4 File Offset: 0x0068AEC4
	// (set) Token: 0x06019664 RID: 104036 RVA: 0x0068CCCC File Offset: 0x0068AECC
	public bool IsAddEnergy { get; set; }

	// Token: 0x170022E2 RID: 8930
	// (get) Token: 0x06019665 RID: 104037 RVA: 0x0068CCD5 File Offset: 0x0068AED5
	// (set) Token: 0x06019666 RID: 104038 RVA: 0x0068CCDD File Offset: 0x0068AEDD
	public bool IsCounterAttack { get; set; }

	// Token: 0x170022E3 RID: 8931
	// (get) Token: 0x06019667 RID: 104039 RVA: 0x0068CCE6 File Offset: 0x0068AEE6
	// (set) Token: 0x06019668 RID: 104040 RVA: 0x0068CCEE File Offset: 0x0068AEEE
	public bool ForceCritical { get; set; }

	// Token: 0x170022E4 RID: 8932
	// (get) Token: 0x06019669 RID: 104041 RVA: 0x0068CCF7 File Offset: 0x0068AEF7
	// (set) Token: 0x0601966A RID: 104042 RVA: 0x0068CCFF File Offset: 0x0068AEFF
	public bool IsBlocked { get; set; }

	// Token: 0x170022E5 RID: 8933
	// (get) Token: 0x0601966B RID: 104043 RVA: 0x0068CD08 File Offset: 0x0068AF08
	// (set) Token: 0x0601966C RID: 104044 RVA: 0x0068CD10 File Offset: 0x0068AF10
	public int PartId { get; set; }

	// Token: 0x170022E6 RID: 8934
	// (get) Token: 0x0601966D RID: 104045 RVA: 0x0068CD19 File Offset: 0x0068AF19
	// (set) Token: 0x0601966E RID: 104046 RVA: 0x0068CD21 File Offset: 0x0068AF21
	public float ExtraRate { get; set; }

	// Token: 0x170022E7 RID: 8935
	// (get) Token: 0x0601966F RID: 104047 RVA: 0x0068CD2A File Offset: 0x0068AF2A
	// (set) Token: 0x06019670 RID: 104048 RVA: 0x0068CD32 File Offset: 0x0068AF32
	public DamageSourceType SourceType { get; set; }

	// Token: 0x170022E8 RID: 8936
	// (get) Token: 0x06019671 RID: 104049 RVA: 0x0068CD3B File Offset: 0x0068AF3B
	// (set) Token: 0x06019672 RID: 104050 RVA: 0x0068CD43 File Offset: 0x0068AF43
	public float Accumulation { get; set; }

	// Token: 0x170022E9 RID: 8937
	// (get) Token: 0x06019673 RID: 104051 RVA: 0x0068CD4C File Offset: 0x0068AF4C
	// (set) Token: 0x06019674 RID: 104052 RVA: 0x0068CD54 File Offset: 0x0068AF54
	public EElementType Element { get; set; }

	// Token: 0x170022EA RID: 8938
	// (get) Token: 0x06019675 RID: 104053 RVA: 0x0068CD5D File Offset: 0x0068AF5D
	// (set) Token: 0x06019676 RID: 104054 RVA: 0x0068CD65 File Offset: 0x0068AF65
	public int RandomSeed { get; set; }

	// Token: 0x170022EB RID: 8939
	// (get) Token: 0x06019677 RID: 104055 RVA: 0x0068CD6E File Offset: 0x0068AF6E
	// (set) Token: 0x06019678 RID: 104056 RVA: 0x0068CD76 File Offset: 0x0068AF76
	public long ContextId { get; set; }

	// Token: 0x170022EC RID: 8940
	// (get) Token: 0x06019679 RID: 104057 RVA: 0x0068CD7F File Offset: 0x0068AF7F
	// (set) Token: 0x0601967A RID: 104058 RVA: 0x0068CD87 File Offset: 0x0068AF87
	public long? SkillContextId { get; set; }

	// Token: 0x170022ED RID: 8941
	// (get) Token: 0x0601967B RID: 104059 RVA: 0x0068CD90 File Offset: 0x0068AF90
	// (set) Token: 0x0601967C RID: 104060 RVA: 0x0068CD98 File Offset: 0x0068AF98
	public long? CounterSkillMessageId { get; set; }
}
