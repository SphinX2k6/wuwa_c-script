using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432F RID: 17199
	public class IKurotatoSystemConfigT
	{
		// Token: 0x170075B6 RID: 30134
		// (get) Token: 0x06018318 RID: 99096 RVA: 0x00372F07 File Offset: 0x00371107
		// (set) Token: 0x06018319 RID: 99097 RVA: 0x00372F0F File Offset: 0x0037110F
		public EEnableSystemType Type { get; set; }

		// Token: 0x170075B7 RID: 30135
		// (get) Token: 0x0601831A RID: 99098 RVA: 0x00372F18 File Offset: 0x00371118
		// (set) Token: 0x0601831B RID: 99099 RVA: 0x00372F20 File Offset: 0x00371120
		public List<IKurotatoSystemVarT> Vars { get; set; }

		// Token: 0x0601831C RID: 99100 RVA: 0x00372F29 File Offset: 0x00371129
		public IKurotatoSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
