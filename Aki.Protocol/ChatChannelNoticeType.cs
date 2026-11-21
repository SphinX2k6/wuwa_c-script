using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015EF RID: 5615
	public enum ChatChannelNoticeType
	{
		// Token: 0x0400AB3A RID: 43834
		[OriginalName("None")]
		None,
		// Token: 0x0400AB3B RID: 43835
		[OriginalName("EnterTeam")]
		EnterTeam,
		// Token: 0x0400AB3C RID: 43836
		[OriginalName("ExitTeam")]
		ExitTeam,
		// Token: 0x0400AB3D RID: 43837
		[OriginalName("ClearMessages")]
		ClearMessages
	}
}
