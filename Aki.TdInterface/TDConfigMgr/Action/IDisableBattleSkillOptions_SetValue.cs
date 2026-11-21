using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2E RID: 6958
	public class IDisableBattleSkillOptions_SetValue
	{
		// Token: 0x04005BBD RID: 23485
		public bool? IsDisablePhantomSkill;

		// Token: 0x04005BBE RID: 23486
		public bool? IsDisableCharacterSkill;

		// Token: 0x04005BBF RID: 23487
		[Nullable(2)]
		public IDisableCharacterSectionalSkillOption IsDisableCharacterSectionalSkill;
	}
}
