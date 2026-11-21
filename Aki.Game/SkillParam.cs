using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002694 RID: 9876
[NullableContext(2)]
[Nullable(0)]
public class SkillParam : ISkillParam
{
	// Token: 0x1700272F RID: 10031
	// (get) Token: 0x06018B9F RID: 101279 RVA: 0x00781177 File Offset: 0x0077F377
	// (set) Token: 0x06018BA0 RID: 101280 RVA: 0x0078117F File Offset: 0x0077F37F
	public Entity Target { get; set; }

	// Token: 0x17002730 RID: 10032
	// (get) Token: 0x06018BA1 RID: 101281 RVA: 0x00781188 File Offset: 0x0077F388
	// (set) Token: 0x06018BA2 RID: 101282 RVA: 0x00781190 File Offset: 0x0077F390
	public AActor TargetActor { get; set; }

	// Token: 0x17002731 RID: 10033
	// (get) Token: 0x06018BA3 RID: 101283 RVA: 0x00781199 File Offset: 0x0077F399
	// (set) Token: 0x06018BA4 RID: 101284 RVA: 0x007811A1 File Offset: 0x0077F3A1
	public string SocketName { get; set; }

	// Token: 0x17002732 RID: 10034
	// (get) Token: 0x06018BA5 RID: 101285 RVA: 0x007811AA File Offset: 0x0077F3AA
	// (set) Token: 0x06018BA6 RID: 101286 RVA: 0x007811B2 File Offset: 0x0077F3B2
	public long? ContextId { get; set; }

	// Token: 0x17002733 RID: 10035
	// (get) Token: 0x06018BA7 RID: 101287 RVA: 0x007811BB File Offset: 0x0077F3BB
	// (set) Token: 0x06018BA8 RID: 101288 RVA: 0x007811C3 File Offset: 0x0077F3C3
	public string Reason { get; set; }

	// Token: 0x17002734 RID: 10036
	// (get) Token: 0x06018BA9 RID: 101289 RVA: 0x007811CC File Offset: 0x0077F3CC
	// (set) Token: 0x06018BAA RID: 101290 RVA: 0x007811D4 File Offset: 0x0077F3D4
	public int? MontageIndex { get; set; }

	// Token: 0x17002735 RID: 10037
	// (get) Token: 0x06018BAB RID: 101291 RVA: 0x007811DD File Offset: 0x0077F3DD
	// (set) Token: 0x06018BAC RID: 101292 RVA: 0x007811E5 File Offset: 0x0077F3E5
	public bool? CheckMultiSkill { get; set; }

	// Token: 0x17002736 RID: 10038
	// (get) Token: 0x06018BAD RID: 101293 RVA: 0x007811EE File Offset: 0x0077F3EE
	// (set) Token: 0x06018BAE RID: 101294 RVA: 0x007811F6 File Offset: 0x0077F3F6
	public int? NextSkillId { get; set; }

	// Token: 0x17002737 RID: 10039
	// (get) Token: 0x06018BAF RID: 101295 RVA: 0x007811FF File Offset: 0x0077F3FF
	// (set) Token: 0x06018BB0 RID: 101296 RVA: 0x00781207 File Offset: 0x0077F407
	public bool? IsAsync { get; set; }

	// Token: 0x17002738 RID: 10040
	// (get) Token: 0x06018BB1 RID: 101297 RVA: 0x00781210 File Offset: 0x0077F410
	// (set) Token: 0x06018BB2 RID: 101298 RVA: 0x00781218 File Offset: 0x0077F418
	public FVectorDouble? ExtraTargetLocation { get; set; }
}
