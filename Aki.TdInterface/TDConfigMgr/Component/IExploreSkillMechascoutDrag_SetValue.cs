using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039E RID: 926
	public class IExploreSkillMechascoutDrag_SetValue
	{
		// Token: 0x04000F0E RID: 3854
		public EExploreSkillInteractType Type;

		// Token: 0x04000F0F RID: 3855
		public IMechascoutDragTypeBase DragType;

		// Token: 0x04000F10 RID: 3856
		public List<int> TriggerPointList;

		// Token: 0x04000F11 RID: 3857
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishedActions;
	}
}
