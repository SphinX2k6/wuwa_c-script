using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E7D RID: 3709
[NullableContext(2)]
public interface IKscEntityParam
{
	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x06005A74 RID: 23156
	// (set) Token: 0x06005A75 RID: 23157
	long CreatureId { get; set; }

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x06005A76 RID: 23158
	// (set) Token: 0x06005A77 RID: 23159
	int SimpleCombatId { get; set; }

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x06005A78 RID: 23160
	// (set) Token: 0x06005A79 RID: 23161
	[Nullable(1)]
	string AssetPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x06005A7A RID: 23162
	// (set) Token: 0x06005A7B RID: 23163
	int PropertyId { get; set; }

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x06005A7C RID: 23164
	// (set) Token: 0x06005A7D RID: 23165
	FTransformDouble Transform { get; set; }

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x06005A7E RID: 23166
	// (set) Token: 0x06005A7F RID: 23167
	USplineComponent Spline { get; set; }

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x06005A80 RID: 23168
	// (set) Token: 0x06005A81 RID: 23169
	Dictionary<int, int> Buffs { get; set; }

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x06005A82 RID: 23170
	// (set) Token: 0x06005A83 RID: 23171
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06005A84 RID: 23172
	// (set) Token: 0x06005A85 RID: 23173
	EKSC_Faction? Faction { get; set; }

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x06005A86 RID: 23174
	// (set) Token: 0x06005A87 RID: 23175
	AActor RenderActor { get; set; }

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x06005A88 RID: 23176
	// (set) Token: 0x06005A89 RID: 23177
	bool? IsPreview { get; set; }

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x06005A8A RID: 23178
	// (set) Token: 0x06005A8B RID: 23179
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<AKSC_Entity> OnEntityAdd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x06005A8C RID: 23180
	// (set) Token: 0x06005A8D RID: 23181
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<AKSC_Entity> FinishCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x06005A8E RID: 23182
	// (set) Token: 0x06005A8F RID: 23183
	UniTask? WaitToBegin { get; set; }
}
