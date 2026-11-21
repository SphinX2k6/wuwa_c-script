using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023B7 RID: 9143
[NullableContext(1)]
[Nullable(0)]
public class BuffDamageParam : IBuffDamageParam
{
	// Token: 0x17002328 RID: 9000
	// (get) Token: 0x06016EB0 RID: 93872 RVA: 0x006B2DBA File Offset: 0x006B0FBA
	// (set) Token: 0x06016EB1 RID: 93873 RVA: 0x006B2DC2 File Offset: 0x006B0FC2
	public long? BuffId { get; set; }

	// Token: 0x17002329 RID: 9001
	// (get) Token: 0x06016EB2 RID: 93874 RVA: 0x006B2DCB File Offset: 0x006B0FCB
	// (set) Token: 0x06016EB3 RID: 93875 RVA: 0x006B2DD3 File Offset: 0x006B0FD3
	public long? BulletId { get; set; }

	// Token: 0x1700232A RID: 9002
	// (get) Token: 0x06016EB4 RID: 93876 RVA: 0x006B2DDC File Offset: 0x006B0FDC
	// (set) Token: 0x06016EB5 RID: 93877 RVA: 0x006B2DE4 File Offset: 0x006B0FE4
	public long DamageDataId { get; set; }

	// Token: 0x1700232B RID: 9003
	// (get) Token: 0x06016EB6 RID: 93878 RVA: 0x006B2DED File Offset: 0x006B0FED
	// (set) Token: 0x06016EB7 RID: 93879 RVA: 0x006B2DF5 File Offset: 0x006B0FF5
	public Entity Attacker { get; set; }

	// Token: 0x1700232C RID: 9004
	// (get) Token: 0x06016EB8 RID: 93880 RVA: 0x006B2DFE File Offset: 0x006B0FFE
	// (set) Token: 0x06016EB9 RID: 93881 RVA: 0x006B2E06 File Offset: 0x006B1006
	public int SkillLevel { get; set; }

	// Token: 0x1700232D RID: 9005
	// (get) Token: 0x06016EBA RID: 93882 RVA: 0x006B2E0F File Offset: 0x006B100F
	// (set) Token: 0x06016EBB RID: 93883 RVA: 0x006B2E17 File Offset: 0x006B1017
	public FVectorDouble HitPosition { get; set; }

	// Token: 0x06016EBC RID: 93884 RVA: 0x006B2E20 File Offset: 0x006B1020
	public BuffDamageParam()
	{
	}

	// Token: 0x06016EBD RID: 93885 RVA: 0x006B2E28 File Offset: 0x006B1028
	public BuffDamageParam(IBuffDamageParam source)
	{
		this.BuffId = source.BuffId;
		this.BulletId = source.BulletId;
		this.DamageDataId = source.DamageDataId;
		this.Attacker = source.Attacker;
		this.SkillLevel = source.SkillLevel;
		this.HitPosition = source.HitPosition;
	}

	// Token: 0x06016EBE RID: 93886 RVA: 0x006B2E83 File Offset: 0x006B1083
	public BuffDamageParam(IBuffDamageParam source, FVectorDouble hitPosition) : this(source)
	{
		this.HitPosition = hitPosition;
	}
}
