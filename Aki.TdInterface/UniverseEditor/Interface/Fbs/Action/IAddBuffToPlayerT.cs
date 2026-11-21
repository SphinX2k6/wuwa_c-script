using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006785 RID: 26501
	public class IAddBuffToPlayerT
	{
		// Token: 0x1700C0B1 RID: 49329
		// (get) Token: 0x0602CEF4 RID: 184052 RVA: 0x00624832 File Offset: 0x00622A32
		// (set) Token: 0x0602CEF5 RID: 184053 RVA: 0x0062483A File Offset: 0x00622A3A
		public List<long> BuffIds { get; set; }

		// Token: 0x1700C0B2 RID: 49330
		// (get) Token: 0x0602CEF6 RID: 184054 RVA: 0x00624843 File Offset: 0x00622A43
		// (set) Token: 0x0602CEF7 RID: 184055 RVA: 0x0062484B File Offset: 0x00622A4B
		public List<long> PersistOnDestroyBuffIds { get; set; }

		// Token: 0x1700C0B3 RID: 49331
		// (get) Token: 0x0602CEF8 RID: 184056 RVA: 0x00624854 File Offset: 0x00622A54
		// (set) Token: 0x0602CEF9 RID: 184057 RVA: 0x0062485C File Offset: 0x00622A5C
		public byte NullMask { get; set; }

		// Token: 0x0602CEFA RID: 184058 RVA: 0x00624865 File Offset: 0x00622A65
		public IAddBuffToPlayerT()
		{
			this.BuffIds = null;
			this.PersistOnDestroyBuffIds = null;
			this.NullMask = 0;
		}
	}
}
