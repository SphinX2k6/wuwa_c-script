using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB2 RID: 8114
	public class IRemovePreloadResourcePhantomCharacter_SetValue
	{
		// Token: 0x04006719 RID: 26393
		public ERemovePreloadResourceObjectType Type;

		// Token: 0x0400671A RID: 26394
		public int Id;

		// Token: 0x0400671B RID: 26395
		[Nullable(2)]
		public IDelayRemoveAfterSkillFinish DelayReMove;
	}
}
