using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E8F RID: 3727
[NullableContext(1)]
[Nullable(0)]
public class WorldNavigationConfig : IWorldNavigationConfig
{
	// Token: 0x17001049 RID: 4169
	// (get) Token: 0x06009504 RID: 38148 RVA: 0x002C392C File Offset: 0x002C1B2C
	// (set) Token: 0x06009505 RID: 38149 RVA: 0x002C3934 File Offset: 0x002C1B34
	public Vector SourcePosition { get; set; }

	// Token: 0x1700104A RID: 4170
	// (get) Token: 0x06009506 RID: 38150 RVA: 0x002C393D File Offset: 0x002C1B3D
	// (set) Token: 0x06009507 RID: 38151 RVA: 0x002C3945 File Offset: 0x002C1B45
	public Vector DestPosition { get; set; }

	// Token: 0x1700104B RID: 4171
	// (get) Token: 0x06009508 RID: 38152 RVA: 0x002C394E File Offset: 0x002C1B4E
	// (set) Token: 0x06009509 RID: 38153 RVA: 0x002C3956 File Offset: 0x002C1B56
	public int MapId { get; set; }

	// Token: 0x1700104C RID: 4172
	// (get) Token: 0x0600950A RID: 38154 RVA: 0x002C395F File Offset: 0x002C1B5F
	// (set) Token: 0x0600950B RID: 38155 RVA: 0x002C3967 File Offset: 0x002C1B67
	[Nullable(2)]
	public BaseMoveComponent MoveComponent { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700104D RID: 4173
	// (get) Token: 0x0600950C RID: 38156 RVA: 0x002C3970 File Offset: 0x002C1B70
	// (set) Token: 0x0600950D RID: 38157 RVA: 0x002C3978 File Offset: 0x002C1B78
	public int? DistanceThreshold { get; set; }

	// Token: 0x1700104E RID: 4174
	// (get) Token: 0x0600950E RID: 38158 RVA: 0x002C3981 File Offset: 0x002C1B81
	// (set) Token: 0x0600950F RID: 38159 RVA: 0x002C3989 File Offset: 0x002C1B89
	public int? TryFindPathTimes { get; set; }

	// Token: 0x1700104F RID: 4175
	// (get) Token: 0x06009510 RID: 38160 RVA: 0x002C3992 File Offset: 0x002C1B92
	// (set) Token: 0x06009511 RID: 38161 RVA: 0x002C399A File Offset: 0x002C1B9A
	[Nullable(2)]
	public TWorldNavigationCallback Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
