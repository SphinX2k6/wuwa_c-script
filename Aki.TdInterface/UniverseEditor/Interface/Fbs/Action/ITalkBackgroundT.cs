using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007293 RID: 29331
	public class ITalkBackgroundT
	{
		// Token: 0x1700D98F RID: 55695
		// (get) Token: 0x060340A1 RID: 213153 RVA: 0x006FF1DE File Offset: 0x006FD3DE
		// (set) Token: 0x060340A2 RID: 213154 RVA: 0x006FF1E6 File Offset: 0x006FD3E6
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x060340A3 RID: 213155 RVA: 0x006FF1EF File Offset: 0x006FD3EF
		public ITalkBackgroundT()
		{
			this.Type = ETalkBackgroundType.Clean;
		}
	}
}
