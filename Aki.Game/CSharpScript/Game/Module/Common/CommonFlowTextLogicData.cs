using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B42 RID: 23362
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFlowTextLogicData<[Nullable(2)] T> : ICommonFlowTextLogicData<T>
	{
		// Token: 0x17008C97 RID: 35991
		// (get) Token: 0x0603B266 RID: 242278 RVA: 0x00E1ABCC File Offset: 0x00E18DCC
		// (set) Token: 0x0603B267 RID: 242279 RVA: 0x00E1ABD4 File Offset: 0x00E18DD4
		public Func<ITalkItem, UUIText> GetTextComp { get; set; }

		// Token: 0x17008C98 RID: 35992
		// (get) Token: 0x0603B268 RID: 242280 RVA: 0x00E1ABDD File Offset: 0x00E18DDD
		// (set) Token: 0x0603B269 RID: 242281 RVA: 0x00E1ABE5 File Offset: 0x00E18DE5
		public Action<ITalkItem, T> TextAnimStartDelegate { get; set; }

		// Token: 0x17008C99 RID: 35993
		// (get) Token: 0x0603B26A RID: 242282 RVA: 0x00E1ABEE File Offset: 0x00E18DEE
		// (set) Token: 0x0603B26B RID: 242283 RVA: 0x00E1ABF6 File Offset: 0x00E18DF6
		public Action<ITalkItem, T> TextAnimFinishDelegate { get; set; }

		// Token: 0x17008C9A RID: 35994
		// (get) Token: 0x0603B26C RID: 242284 RVA: 0x00E1ABFF File Offset: 0x00E18DFF
		// (set) Token: 0x0603B26D RID: 242285 RVA: 0x00E1AC07 File Offset: 0x00E18E07
		public Action ClearDelegate { get; set; }
	}
}
