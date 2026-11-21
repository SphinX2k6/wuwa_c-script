using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B23 RID: 19235
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFlowTextLogicData<[Nullable(2)] T> : ICommonFlowTextLogicData<T>
	{
		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x060301D8 RID: 197080 RVA: 0x00D6B8E4 File Offset: 0x00D69AE4
		// (set) Token: 0x060301D9 RID: 197081 RVA: 0x00D6B8EC File Offset: 0x00D69AEC
		public Func<ITalkItem, UUIText> GetTextComp { get; set; }

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x060301DA RID: 197082 RVA: 0x00D6B8F5 File Offset: 0x00D69AF5
		// (set) Token: 0x060301DB RID: 197083 RVA: 0x00D6B8FD File Offset: 0x00D69AFD
		public Action<ITalkItem, T> TextAnimStartDelegate { get; set; }

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x060301DC RID: 197084 RVA: 0x00D6B906 File Offset: 0x00D69B06
		// (set) Token: 0x060301DD RID: 197085 RVA: 0x00D6B90E File Offset: 0x00D69B0E
		public Action<ITalkItem, T> TextAnimFinishDelegate { get; set; }

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x060301DE RID: 197086 RVA: 0x00D6B917 File Offset: 0x00D69B17
		// (set) Token: 0x060301DF RID: 197087 RVA: 0x00D6B91F File Offset: 0x00D69B1F
		public Action ClearDelegate { get; set; }
	}
}
