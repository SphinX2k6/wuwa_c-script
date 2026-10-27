using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF1 RID: 16113
	public class IKurotatoSystemConfigT
	{
		// Token: 0x17006FC7 RID: 28615
		// (get) Token: 0x06016CC1 RID: 93377 RVA: 0x00349D3B File Offset: 0x00347F3B
		// (set) Token: 0x06016CC2 RID: 93378 RVA: 0x00349D43 File Offset: 0x00347F43
		public EEnableSystemType Type { get; set; }

		// Token: 0x17006FC8 RID: 28616
		// (get) Token: 0x06016CC3 RID: 93379 RVA: 0x00349D4C File Offset: 0x00347F4C
		// (set) Token: 0x06016CC4 RID: 93380 RVA: 0x00349D54 File Offset: 0x00347F54
		public List<IKurotatoSystemVarT> Vars { get; set; }

		// Token: 0x06016CC5 RID: 93381 RVA: 0x00349D5D File Offset: 0x00347F5D
		public IKurotatoSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
