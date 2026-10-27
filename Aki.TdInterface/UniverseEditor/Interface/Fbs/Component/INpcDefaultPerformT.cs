using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005621 RID: 22049
	public class INpcDefaultPerformT
	{
		// Token: 0x1700A323 RID: 41763
		// (get) Token: 0x0602498D RID: 149901 RVA: 0x0050C923 File Offset: 0x0050AB23
		// (set) Token: 0x0602498E RID: 149902 RVA: 0x0050C92B File Offset: 0x0050AB2B
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x1700A324 RID: 41764
		// (get) Token: 0x0602498F RID: 149903 RVA: 0x0050C934 File Offset: 0x0050AB34
		// (set) Token: 0x06024990 RID: 149904 RVA: 0x0050C93C File Offset: 0x0050AB3C
		public byte NullMask { get; set; }

		// Token: 0x06024991 RID: 149905 RVA: 0x0050C945 File Offset: 0x0050AB45
		public INpcDefaultPerformT()
		{
			this.BuffEffectIds = null;
			this.NullMask = 0;
		}
	}
}
