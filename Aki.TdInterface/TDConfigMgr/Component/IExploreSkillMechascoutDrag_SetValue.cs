using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000355 RID: 853
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillMechascoutDrag_SetValue
	{
		// Token: 0x04000E17 RID: 3607
		public EExploreSkillInteractType Type;

		// Token: 0x04000E18 RID: 3608
		public IMechascoutDragTypeBase DragType;

		// Token: 0x04000E19 RID: 3609
		public List<int> TriggerPointList;

		// Token: 0x04000E1A RID: 3610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishedActions;
	}
}
