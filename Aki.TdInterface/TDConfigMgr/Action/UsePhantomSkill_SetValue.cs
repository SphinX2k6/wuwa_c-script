using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024D9 RID: 9433
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill_SetValue
	{
		// Token: 0x0400797F RID: 31103
		public EPhantomSkillType SkillType;

		// Token: 0x04007980 RID: 31104
		public ISkillBlackboardVector BlackboardPos;

		// Token: 0x04007981 RID: 31105
		public ISkillBlackboardVector BlackboardRot;
	}
}
