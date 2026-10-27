using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001579 RID: 5497
	public enum ChatChannelNoticeType
	{
		// Token: 0x0400A6AD RID: 42669
		[OriginalName("None")]
		None,
		// Token: 0x0400A6AE RID: 42670
		[OriginalName("EnterTeam")]
		EnterTeam,
		// Token: 0x0400A6AF RID: 42671
		[OriginalName("ExitTeam")]
		ExitTeam,
		// Token: 0x0400A6B0 RID: 42672
		[OriginalName("ClearMessages")]
		ClearMessages
	}
}
