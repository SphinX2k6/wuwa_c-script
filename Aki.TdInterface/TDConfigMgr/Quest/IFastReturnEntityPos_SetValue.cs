using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F68 RID: 3944
	public class IFastReturnEntityPos_SetValue
	{
		// Token: 0x040034FC RID: 13564
		public EFastReturnPosType Type;

		// Token: 0x040034FD RID: 13565
		public int EntityId;

		// Token: 0x040034FE RID: 13566
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;
	}
}
