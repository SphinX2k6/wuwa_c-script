using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001628 RID: 5672
	public enum EEndSkillReason
	{
		// Token: 0x0400C172 RID: 49522
		[OriginalName("EEndSkillReason_Default")]
		Default,
		// Token: 0x0400C173 RID: 49523
		[OriginalName("EEndSkillReason_BeginOtherSkill")]
		BeginOtherSkill,
		// Token: 0x0400C174 RID: 49524
		[OriginalName("EEndSkillReason_BeHit")]
		BeHit,
		// Token: 0x0400C175 RID: 49525
		[OriginalName("EEndSkillReason_BeCounter")]
		BeCounter
	}
}
