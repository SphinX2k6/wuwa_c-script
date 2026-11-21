using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B22 RID: 19234
	[NullableContext(1)]
	public interface ICommonFlowTextLogicData<[Nullable(2)] T>
	{
		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x060301D0 RID: 197072
		// (set) Token: 0x060301D1 RID: 197073
		Func<ITalkItem, UUIText> GetTextComp { get; set; }

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x060301D2 RID: 197074
		// (set) Token: 0x060301D3 RID: 197075
		Action<ITalkItem, T> TextAnimStartDelegate { get; set; }

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x060301D4 RID: 197076
		// (set) Token: 0x060301D5 RID: 197077
		Action<ITalkItem, T> TextAnimFinishDelegate { get; set; }

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x060301D6 RID: 197078
		// (set) Token: 0x060301D7 RID: 197079
		Action ClearDelegate { get; set; }
	}
}
