using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

// Token: 0x02000233 RID: 563
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityDebugRecord : ICapabilityDebugRecord
{
	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000D9499 File Offset: 0x000D7699
	// (set) Token: 0x060022C2 RID: 8898 RVA: 0x000D94A1 File Offset: 0x000D76A1
	[RequiredMember]
	public int Seq { get; set; }

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000D94AA File Offset: 0x000D76AA
	// (set) Token: 0x060022C4 RID: 8900 RVA: 0x000D94B2 File Offset: 0x000D76B2
	[RequiredMember]
	public double Time { get; set; }

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000D94BB File Offset: 0x000D76BB
	// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000D94C3 File Offset: 0x000D76C3
	[RequiredMember]
	public CapabilityCommonDefine.ECapabilityDebugEvent Event { get; set; }

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000D94CC File Offset: 0x000D76CC
	// (set) Token: 0x060022C8 RID: 8904 RVA: 0x000D94D4 File Offset: 0x000D76D4
	[RequiredMember]
	public string CapabilityId { get; set; }

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000D94DD File Offset: 0x000D76DD
	// (set) Token: 0x060022CA RID: 8906 RVA: 0x000D94E5 File Offset: 0x000D76E5
	[RequiredMember]
	public string GameObjectId { get; set; }

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x060022CB RID: 8907 RVA: 0x000D94EE File Offset: 0x000D76EE
	// (set) Token: 0x060022CC RID: 8908 RVA: 0x000D94F6 File Offset: 0x000D76F6
	[RequiredMember]
	public string ClassName { get; set; }

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x060022CD RID: 8909 RVA: 0x000D94FF File Offset: 0x000D76FF
	// (set) Token: 0x060022CE RID: 8910 RVA: 0x000D9507 File Offset: 0x000D7707
	[Nullable(2)]
	public string Detail { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x060022CF RID: 8911 RVA: 0x000D9510 File Offset: 0x000D7710
	// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000D9518 File Offset: 0x000D7718
	public double? DurationMs { get; set; }

	// Token: 0x060022D1 RID: 8913 RVA: 0x000D9521 File Offset: 0x000D7721
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityDebugRecord()
	{
	}
}
