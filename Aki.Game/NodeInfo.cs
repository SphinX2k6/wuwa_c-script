using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D6E RID: 7534
[RequiredMember]
public class NodeInfo
{
	// Token: 0x0600E541 RID: 58689 RVA: 0x003601D1 File Offset: 0x0035E3D1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public NodeInfo()
	{
	}

	// Token: 0x040069A9 RID: 27049
	[Nullable(1)]
	[RequiredMember]
	public Aki.Protocol.NodeInfo Info;

	// Token: 0x040069AA RID: 27050
	[RequiredMember]
	public int NodeId;
}
