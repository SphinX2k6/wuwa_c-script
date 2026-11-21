using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000450 RID: 1104
	public class IGroupAiMonsterMember_SetValue
	{
		// Token: 0x04001134 RID: 4404
		public int EntityId;

		// Token: 0x04001135 RID: 4405
		public PosAndRot RelativeTransform;

		// Token: 0x04001136 RID: 4406
		[Nullable(2)]
		public IGroupAiMonsterMemberActionTagAttach ActionTagAttach;
	}
}
