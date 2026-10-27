using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E7E RID: 3710
[NullableContext(2)]
[Nullable(0)]
public class KscEntityParam : IKscEntityParam
{
	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x06005A90 RID: 23184 RVA: 0x001086A1 File Offset: 0x001068A1
	// (set) Token: 0x06005A91 RID: 23185 RVA: 0x001086A9 File Offset: 0x001068A9
	public long CreatureId { get; set; }

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x06005A92 RID: 23186 RVA: 0x001086B2 File Offset: 0x001068B2
	// (set) Token: 0x06005A93 RID: 23187 RVA: 0x001086BA File Offset: 0x001068BA
	public int SimpleCombatId { get; set; }

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x06005A94 RID: 23188 RVA: 0x001086C3 File Offset: 0x001068C3
	// (set) Token: 0x06005A95 RID: 23189 RVA: 0x001086CB File Offset: 0x001068CB
	[Nullable(1)]
	public string AssetPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x06005A96 RID: 23190 RVA: 0x001086D4 File Offset: 0x001068D4
	// (set) Token: 0x06005A97 RID: 23191 RVA: 0x001086DC File Offset: 0x001068DC
	public int PropertyId { get; set; }

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x06005A98 RID: 23192 RVA: 0x001086E5 File Offset: 0x001068E5
	// (set) Token: 0x06005A99 RID: 23193 RVA: 0x001086ED File Offset: 0x001068ED
	public FTransformDouble Transform { get; set; }

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x06005A9A RID: 23194 RVA: 0x001086F6 File Offset: 0x001068F6
	// (set) Token: 0x06005A9B RID: 23195 RVA: 0x001086FE File Offset: 0x001068FE
	public USplineComponent Spline { get; set; }

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x06005A9C RID: 23196 RVA: 0x00108707 File Offset: 0x00106907
	// (set) Token: 0x06005A9D RID: 23197 RVA: 0x0010870F File Offset: 0x0010690F
	public Dictionary<int, int> Buffs { get; set; }

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06005A9E RID: 23198 RVA: 0x00108718 File Offset: 0x00106918
	// (set) Token: 0x06005A9F RID: 23199 RVA: 0x00108720 File Offset: 0x00106920
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x00108729 File Offset: 0x00106929
	// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x00108731 File Offset: 0x00106931
	public EKSC_Faction? Faction { get; set; }

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x0010873A File Offset: 0x0010693A
	// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x00108742 File Offset: 0x00106942
	public AActor RenderActor { get; set; }

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x0010874B File Offset: 0x0010694B
	// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x00108753 File Offset: 0x00106953
	public bool? IsPreview { get; set; }

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06005AA6 RID: 23206 RVA: 0x0010875C File Offset: 0x0010695C
	// (set) Token: 0x06005AA7 RID: 23207 RVA: 0x00108764 File Offset: 0x00106964
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AKSC_Entity> OnEntityAdd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x0010876D File Offset: 0x0010696D
	// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x00108775 File Offset: 0x00106975
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AKSC_Entity> FinishCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0010877E File Offset: 0x0010697E
	// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00108786 File Offset: 0x00106986
	public UniTask? WaitToBegin { get; set; }
}
