using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B6 RID: 5558
	public enum EEndSkillReason
	{
		// Token: 0x0400BC7F RID: 48255
		[OriginalName("EEndSkillReason_Default")]
		Default,
		// Token: 0x0400BC80 RID: 48256
		[OriginalName("EEndSkillReason_BeginOtherSkill")]
		BeginOtherSkill,
		// Token: 0x0400BC81 RID: 48257
		[OriginalName("EEndSkillReason_BeHit")]
		BeHit,
		// Token: 0x0400BC82 RID: 48258
		[OriginalName("EEndSkillReason_BeCounter")]
		BeCounter
	}
}
