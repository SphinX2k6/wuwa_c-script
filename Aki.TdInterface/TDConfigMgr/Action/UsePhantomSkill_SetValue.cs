using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226C RID: 8812
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill_SetValue
	{
		// Token: 0x04007332 RID: 29490
		public EPhantomSkillType SkillType;

		// Token: 0x04007333 RID: 29491
		public ISkillBlackboardVector BlackboardPos;

		// Token: 0x04007334 RID: 29492
		public ISkillBlackboardVector BlackboardRot;
	}
}
