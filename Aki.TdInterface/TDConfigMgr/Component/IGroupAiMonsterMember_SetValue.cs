using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F7 RID: 1015
	public class IGroupAiMonsterMember_SetValue
	{
		// Token: 0x04001012 RID: 4114
		public int EntityId;

		// Token: 0x04001013 RID: 4115
		[Nullable(1)]
		public PosAndRot RelativeTransform;

		// Token: 0x04001014 RID: 4116
		[Nullable(2)]
		public IGroupAiMonsterMemberActionTagAttach ActionTagAttach;
	}
}
