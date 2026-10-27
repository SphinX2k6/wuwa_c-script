using System;
using System.Runtime.CompilerServices;

// Token: 0x020019D0 RID: 6608
[NullableContext(1)]
[Nullable(0)]
public class WorldNavigationConfig : IWorldNavigationConfig
{
	// Token: 0x17001024 RID: 4132
	// (get) Token: 0x0600C0F7 RID: 49399 RVA: 0x002B8960 File Offset: 0x002B6B60
	// (set) Token: 0x0600C0F8 RID: 49400 RVA: 0x002B8968 File Offset: 0x002B6B68
	public Vector SourcePosition { get; set; }

	// Token: 0x17001025 RID: 4133
	// (get) Token: 0x0600C0F9 RID: 49401 RVA: 0x002B8971 File Offset: 0x002B6B71
	// (set) Token: 0x0600C0FA RID: 49402 RVA: 0x002B8979 File Offset: 0x002B6B79
	public Vector DestPosition { get; set; }

	// Token: 0x17001026 RID: 4134
	// (get) Token: 0x0600C0FB RID: 49403 RVA: 0x002B8982 File Offset: 0x002B6B82
	// (set) Token: 0x0600C0FC RID: 49404 RVA: 0x002B898A File Offset: 0x002B6B8A
	public int MapId { get; set; }

	// Token: 0x17001027 RID: 4135
	// (get) Token: 0x0600C0FD RID: 49405 RVA: 0x002B8993 File Offset: 0x002B6B93
	// (set) Token: 0x0600C0FE RID: 49406 RVA: 0x002B899B File Offset: 0x002B6B9B
	[Nullable(2)]
	public BaseMoveComponent MoveComponent { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001028 RID: 4136
	// (get) Token: 0x0600C0FF RID: 49407 RVA: 0x002B89A4 File Offset: 0x002B6BA4
	// (set) Token: 0x0600C100 RID: 49408 RVA: 0x002B89AC File Offset: 0x002B6BAC
	public int? DistanceThreshold { get; set; }

	// Token: 0x17001029 RID: 4137
	// (get) Token: 0x0600C101 RID: 49409 RVA: 0x002B89B5 File Offset: 0x002B6BB5
	// (set) Token: 0x0600C102 RID: 49410 RVA: 0x002B89BD File Offset: 0x002B6BBD
	public int? TryFindPathTimes { get; set; }

	// Token: 0x1700102A RID: 4138
	// (get) Token: 0x0600C103 RID: 49411 RVA: 0x002B89C6 File Offset: 0x002B6BC6
	// (set) Token: 0x0600C104 RID: 49412 RVA: 0x002B89CE File Offset: 0x002B6BCE
	[Nullable(2)]
	public TWorldNavigationCallback Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
