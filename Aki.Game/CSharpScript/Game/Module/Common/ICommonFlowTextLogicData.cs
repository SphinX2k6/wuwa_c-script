using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B41 RID: 23361
	[NullableContext(1)]
	public interface ICommonFlowTextLogicData<[Nullable(2)] T>
	{
		// Token: 0x17008C93 RID: 35987
		// (get) Token: 0x0603B25E RID: 242270
		// (set) Token: 0x0603B25F RID: 242271
		Func<ITalkItem, UUIText> GetTextComp { get; set; }

		// Token: 0x17008C94 RID: 35988
		// (get) Token: 0x0603B260 RID: 242272
		// (set) Token: 0x0603B261 RID: 242273
		Action<ITalkItem, T> TextAnimStartDelegate { get; set; }

		// Token: 0x17008C95 RID: 35989
		// (get) Token: 0x0603B262 RID: 242274
		// (set) Token: 0x0603B263 RID: 242275
		Action<ITalkItem, T> TextAnimFinishDelegate { get; set; }

		// Token: 0x17008C96 RID: 35990
		// (get) Token: 0x0603B264 RID: 242276
		// (set) Token: 0x0603B265 RID: 242277
		Action ClearDelegate { get; set; }
	}
}
