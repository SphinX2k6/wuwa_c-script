using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BC RID: 22716
	public class IGroupAiModeT
	{
		// Token: 0x1700A4B7 RID: 42167
		// (get) Token: 0x06024E10 RID: 151056 RVA: 0x0051085A File Offset: 0x0050EA5A
		// (set) Token: 0x06024E11 RID: 151057 RVA: 0x00510862 File Offset: 0x0050EA62
		public EGroupAiMode Type { get; set; }

		// Token: 0x06024E12 RID: 151058 RVA: 0x0051086B File Offset: 0x0050EA6B
		public IGroupAiModeT()
		{
			this.Type = EGroupAiMode.Default;
		}
	}
}
