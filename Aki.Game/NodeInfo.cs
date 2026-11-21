using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001230 RID: 4656
[RequiredMember]
public class NodeInfo
{
	// Token: 0x0600B95F RID: 47455 RVA: 0x0036BE25 File Offset: 0x0036A025
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public NodeInfo()
	{
	}

	// Token: 0x04006A89 RID: 27273
	[Nullable(1)]
	[RequiredMember]
	public Aki.Protocol.NodeInfo Info;

	// Token: 0x04006A8A RID: 27274
	[RequiredMember]
	public int NodeId;
}
