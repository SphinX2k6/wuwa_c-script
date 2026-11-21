using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023B9 RID: 9145
[NullableContext(1)]
[Nullable(0)]
public class BulletDamageParams : IBulletDamageParam
{
	// Token: 0x1700233D RID: 9021
	// (get) Token: 0x06016EDD RID: 93917 RVA: 0x006B2E93 File Offset: 0x006B1093
	// (set) Token: 0x06016EDE RID: 93918 RVA: 0x006B2E9B File Offset: 0x006B109B
	public long DamageDataId { get; set; }

	// Token: 0x1700233E RID: 9022
	// (get) Token: 0x06016EDF RID: 93919 RVA: 0x006B2EA4 File Offset: 0x006B10A4
	// (set) Token: 0x06016EE0 RID: 93920 RVA: 0x006B2EAC File Offset: 0x006B10AC
	public long? BulletId { get; set; }

	// Token: 0x1700233F RID: 9023
	// (get) Token: 0x06016EE1 RID: 93921 RVA: 0x006B2EB5 File Offset: 0x006B10B5
	// (set) Token: 0x06016EE2 RID: 93922 RVA: 0x006B2EBD File Offset: 0x006B10BD
	public Entity Attacker { get; set; }

	// Token: 0x17002340 RID: 9024
	// (get) Token: 0x06016EE3 RID: 93923 RVA: 0x006B2EC6 File Offset: 0x006B10C6
	// (set) Token: 0x06016EE4 RID: 93924 RVA: 0x006B2ECE File Offset: 0x006B10CE
	public Entity DirectTarget { get; set; }

	// Token: 0x17002341 RID: 9025
	// (get) Token: 0x06016EE5 RID: 93925 RVA: 0x006B2ED7 File Offset: 0x006B10D7
	// (set) Token: 0x06016EE6 RID: 93926 RVA: 0x006B2EDF File Offset: 0x006B10DF
	public int SkillLevel { get; set; }

	// Token: 0x17002342 RID: 9026
	// (get) Token: 0x06016EE7 RID: 93927 RVA: 0x006B2EE8 File Offset: 0x006B10E8
	// (set) Token: 0x06016EE8 RID: 93928 RVA: 0x006B2EF0 File Offset: 0x006B10F0
	public FVectorDouble HitPosition { get; set; }

	// Token: 0x17002343 RID: 9027
	// (get) Token: 0x06016EE9 RID: 93929 RVA: 0x006B2EF9 File Offset: 0x006B10F9
	// (set) Token: 0x06016EEA RID: 93930 RVA: 0x006B2F01 File Offset: 0x006B1101
	public float ExtraRate { get; set; }

	// Token: 0x17002344 RID: 9028
	// (get) Token: 0x06016EEB RID: 93931 RVA: 0x006B2F0A File Offset: 0x006B110A
	// (set) Token: 0x06016EEC RID: 93932 RVA: 0x006B2F12 File Offset: 0x006B1112
	public bool IsAddEnergy { get; set; }

	// Token: 0x17002345 RID: 9029
	// (get) Token: 0x06016EED RID: 93933 RVA: 0x006B2F1B File Offset: 0x006B111B
	// (set) Token: 0x06016EEE RID: 93934 RVA: 0x006B2F23 File Offset: 0x006B1123
	public bool IsCounterAttack { get; set; }

	// Token: 0x17002346 RID: 9030
	// (get) Token: 0x06016EEF RID: 93935 RVA: 0x006B2F2C File Offset: 0x006B112C
	// (set) Token: 0x06016EF0 RID: 93936 RVA: 0x006B2F34 File Offset: 0x006B1134
	public bool ForceCritical { get; set; }

	// Token: 0x17002347 RID: 9031
	// (get) Token: 0x06016EF1 RID: 93937 RVA: 0x006B2F3D File Offset: 0x006B113D
	// (set) Token: 0x06016EF2 RID: 93938 RVA: 0x006B2F45 File Offset: 0x006B1145
	public bool IsBlocked { get; set; }

	// Token: 0x17002348 RID: 9032
	// (get) Token: 0x06016EF3 RID: 93939 RVA: 0x006B2F4E File Offset: 0x006B114E
	// (set) Token: 0x06016EF4 RID: 93940 RVA: 0x006B2F56 File Offset: 0x006B1156
	public int PartId { get; set; }

	// Token: 0x17002349 RID: 9033
	// (get) Token: 0x06016EF5 RID: 93941 RVA: 0x006B2F5F File Offset: 0x006B115F
	// (set) Token: 0x06016EF6 RID: 93942 RVA: 0x006B2F67 File Offset: 0x006B1167
	public long? CounterSkillMessageId { get; set; }

	// Token: 0x1700234A RID: 9034
	// (get) Token: 0x06016EF7 RID: 93943 RVA: 0x006B2F70 File Offset: 0x006B1170
	// (set) Token: 0x06016EF8 RID: 93944 RVA: 0x006B2F78 File Offset: 0x006B1178
	public long? CounterSkillId { get; set; }

	// Token: 0x1700234B RID: 9035
	// (get) Token: 0x06016EF9 RID: 93945 RVA: 0x006B2F81 File Offset: 0x006B1181
	// (set) Token: 0x06016EFA RID: 93946 RVA: 0x006B2F89 File Offset: 0x006B1189
	public ECounterAttackType? CounterType { get; set; }
}
