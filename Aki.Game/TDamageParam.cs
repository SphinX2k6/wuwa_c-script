using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x020023C1 RID: 9153
[NullableContext(1)]
[Nullable(0)]
public class TDamageParam : DamageEventInfo
{
	// Token: 0x1700235D RID: 9053
	// (get) Token: 0x06016F24 RID: 93988 RVA: 0x006B3085 File Offset: 0x006B1285
	// (set) Token: 0x06016F25 RID: 93989 RVA: 0x006B308D File Offset: 0x006B128D
	public Damage DamageData { get; set; }

	// Token: 0x1700235E RID: 9054
	// (get) Token: 0x06016F26 RID: 93990 RVA: 0x006B3096 File Offset: 0x006B1296
	// (set) Token: 0x06016F27 RID: 93991 RVA: 0x006B309E File Offset: 0x006B129E
	public Entity DirectTarget { get; set; }

	// Token: 0x1700235F RID: 9055
	// (get) Token: 0x06016F28 RID: 93992 RVA: 0x006B30A7 File Offset: 0x006B12A7
	// (set) Token: 0x06016F29 RID: 93993 RVA: 0x006B30AF File Offset: 0x006B12AF
	public int SkillLevel { get; set; }

	// Token: 0x17002360 RID: 9056
	// (get) Token: 0x06016F2A RID: 93994 RVA: 0x006B30B8 File Offset: 0x006B12B8
	// (set) Token: 0x06016F2B RID: 93995 RVA: 0x006B30C0 File Offset: 0x006B12C0
	public bool IsAddEnergy { get; set; }

	// Token: 0x17002361 RID: 9057
	// (get) Token: 0x06016F2C RID: 93996 RVA: 0x006B30C9 File Offset: 0x006B12C9
	// (set) Token: 0x06016F2D RID: 93997 RVA: 0x006B30D1 File Offset: 0x006B12D1
	public bool IsCounterAttack { get; set; }

	// Token: 0x17002362 RID: 9058
	// (get) Token: 0x06016F2E RID: 93998 RVA: 0x006B30DA File Offset: 0x006B12DA
	// (set) Token: 0x06016F2F RID: 93999 RVA: 0x006B30E2 File Offset: 0x006B12E2
	public bool ForceCritical { get; set; }

	// Token: 0x17002363 RID: 9059
	// (get) Token: 0x06016F30 RID: 94000 RVA: 0x006B30EB File Offset: 0x006B12EB
	// (set) Token: 0x06016F31 RID: 94001 RVA: 0x006B30F3 File Offset: 0x006B12F3
	public bool IsBlocked { get; set; }

	// Token: 0x17002364 RID: 9060
	// (get) Token: 0x06016F32 RID: 94002 RVA: 0x006B30FC File Offset: 0x006B12FC
	// (set) Token: 0x06016F33 RID: 94003 RVA: 0x006B3104 File Offset: 0x006B1304
	public int PartId { get; set; }

	// Token: 0x17002365 RID: 9061
	// (get) Token: 0x06016F34 RID: 94004 RVA: 0x006B310D File Offset: 0x006B130D
	// (set) Token: 0x06016F35 RID: 94005 RVA: 0x006B3115 File Offset: 0x006B1315
	public float ExtraRate { get; set; }

	// Token: 0x17002366 RID: 9062
	// (get) Token: 0x06016F36 RID: 94006 RVA: 0x006B311E File Offset: 0x006B131E
	// (set) Token: 0x06016F37 RID: 94007 RVA: 0x006B3126 File Offset: 0x006B1326
	public DamageSourceType SourceType { get; set; }

	// Token: 0x17002367 RID: 9063
	// (get) Token: 0x06016F38 RID: 94008 RVA: 0x006B312F File Offset: 0x006B132F
	// (set) Token: 0x06016F39 RID: 94009 RVA: 0x006B3137 File Offset: 0x006B1337
	public float Accumulation { get; set; }

	// Token: 0x17002368 RID: 9064
	// (get) Token: 0x06016F3A RID: 94010 RVA: 0x006B3140 File Offset: 0x006B1340
	// (set) Token: 0x06016F3B RID: 94011 RVA: 0x006B3148 File Offset: 0x006B1348
	public EElementType Element { get; set; }

	// Token: 0x17002369 RID: 9065
	// (get) Token: 0x06016F3C RID: 94012 RVA: 0x006B3151 File Offset: 0x006B1351
	// (set) Token: 0x06016F3D RID: 94013 RVA: 0x006B3159 File Offset: 0x006B1359
	public int RandomSeed { get; set; }

	// Token: 0x1700236A RID: 9066
	// (get) Token: 0x06016F3E RID: 94014 RVA: 0x006B3162 File Offset: 0x006B1362
	// (set) Token: 0x06016F3F RID: 94015 RVA: 0x006B316A File Offset: 0x006B136A
	public long ContextId { get; set; }

	// Token: 0x1700236B RID: 9067
	// (get) Token: 0x06016F40 RID: 94016 RVA: 0x006B3173 File Offset: 0x006B1373
	// (set) Token: 0x06016F41 RID: 94017 RVA: 0x006B317B File Offset: 0x006B137B
	public long? SkillContextId { get; set; }

	// Token: 0x1700236C RID: 9068
	// (get) Token: 0x06016F42 RID: 94018 RVA: 0x006B3184 File Offset: 0x006B1384
	// (set) Token: 0x06016F43 RID: 94019 RVA: 0x006B318C File Offset: 0x006B138C
	public long? CounterSkillMessageId { get; set; }
}
