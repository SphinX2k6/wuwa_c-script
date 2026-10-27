using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007296 RID: 29334
	public class ITalkBackgroundCleanT
	{
		// Token: 0x1700D992 RID: 55698
		// (get) Token: 0x060340B3 RID: 213171 RVA: 0x006FF356 File Offset: 0x006FD556
		// (set) Token: 0x060340B4 RID: 213172 RVA: 0x006FF35E File Offset: 0x006FD55E
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x060340B5 RID: 213173 RVA: 0x006FF367 File Offset: 0x006FD567
		public ITalkBackgroundCleanT()
		{
			this.Type = ETalkBackgroundType.Clean;
		}
	}
}
