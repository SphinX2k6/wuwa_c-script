using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9D RID: 7581
	public class IRemovePreloadResourcePhantomCharacter_SetValue
	{
		// Token: 0x04006195 RID: 24981
		public ERemovePreloadResourceObjectType Type;

		// Token: 0x04006196 RID: 24982
		public int Id;

		// Token: 0x04006197 RID: 24983
		[Nullable(2)]
		public IDelayRemoveAfterSkillFinish DelayReMove;
	}
}
