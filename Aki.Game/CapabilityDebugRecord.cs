using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

// Token: 0x02000237 RID: 567
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityDebugRecord : ICapabilityDebugRecord
{
	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06002379 RID: 9081 RVA: 0x000DF959 File Offset: 0x000DDB59
	// (set) Token: 0x0600237A RID: 9082 RVA: 0x000DF961 File Offset: 0x000DDB61
	[RequiredMember]
	public int Seq { get; set; }

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x0600237B RID: 9083 RVA: 0x000DF96A File Offset: 0x000DDB6A
	// (set) Token: 0x0600237C RID: 9084 RVA: 0x000DF972 File Offset: 0x000DDB72
	[RequiredMember]
	public double Time { get; set; }

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x0600237D RID: 9085 RVA: 0x000DF97B File Offset: 0x000DDB7B
	// (set) Token: 0x0600237E RID: 9086 RVA: 0x000DF983 File Offset: 0x000DDB83
	[RequiredMember]
	public CapabilityCommonDefine.ECapabilityDebugEvent Event { get; set; }

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x0600237F RID: 9087 RVA: 0x000DF98C File Offset: 0x000DDB8C
	// (set) Token: 0x06002380 RID: 9088 RVA: 0x000DF994 File Offset: 0x000DDB94
	[RequiredMember]
	public string CapabilityId { get; set; }

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06002381 RID: 9089 RVA: 0x000DF99D File Offset: 0x000DDB9D
	// (set) Token: 0x06002382 RID: 9090 RVA: 0x000DF9A5 File Offset: 0x000DDBA5
	[RequiredMember]
	public string GameObjectId { get; set; }

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06002383 RID: 9091 RVA: 0x000DF9AE File Offset: 0x000DDBAE
	// (set) Token: 0x06002384 RID: 9092 RVA: 0x000DF9B6 File Offset: 0x000DDBB6
	[RequiredMember]
	public string ClassName { get; set; }

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06002385 RID: 9093 RVA: 0x000DF9BF File Offset: 0x000DDBBF
	// (set) Token: 0x06002386 RID: 9094 RVA: 0x000DF9C7 File Offset: 0x000DDBC7
	[Nullable(2)]
	public string Detail { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06002387 RID: 9095 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
	// (set) Token: 0x06002388 RID: 9096 RVA: 0x000DF9D8 File Offset: 0x000DDBD8
	public double? DurationMs { get; set; }

	// Token: 0x06002389 RID: 9097 RVA: 0x000DF9E1 File Offset: 0x000DDBE1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityDebugRecord()
	{
	}
}
