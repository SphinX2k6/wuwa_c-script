using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A0 RID: 5536
	public enum AttachTargetType
	{
		// Token: 0x0400A818 RID: 43032
		[OriginalName("AttachTargetNone")]
		AttachTargetNone,
		// Token: 0x0400A819 RID: 43033
		[OriginalName("AttachTargetEntity")]
		AttachTargetEntity,
		// Token: 0x0400A81A RID: 43034
		[OriginalName("AttachTargetActorPath")]
		AttachTargetActorPath
	}
}
