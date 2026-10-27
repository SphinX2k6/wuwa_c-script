using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A7 RID: 6567
	public class IDisableBattleSkillOptions_SetValue
	{
		// Token: 0x04005774 RID: 22388
		public bool? IsDisablePhantomSkill;

		// Token: 0x04005775 RID: 22389
		public bool? IsDisableCharacterSkill;

		// Token: 0x04005776 RID: 22390
		[Nullable(2)]
		public IDisableCharacterSectionalSkillOption IsDisableCharacterSectionalSkill;
	}
}
