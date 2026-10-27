using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FC RID: 21500
	public class IInhalationConfigT
	{
		// Token: 0x17009E38 RID: 40504
		// (get) Token: 0x060234FB RID: 144635 RVA: 0x004E37F3 File Offset: 0x004E19F3
		// (set) Token: 0x060234FC RID: 144636 RVA: 0x004E37FB File Offset: 0x004E19FB
		public IInhalationMatchingT InhalationMatching { get; set; }

		// Token: 0x17009E39 RID: 40505
		// (get) Token: 0x060234FD RID: 144637 RVA: 0x004E3804 File Offset: 0x004E1A04
		// (set) Token: 0x060234FE RID: 144638 RVA: 0x004E380C File Offset: 0x004E1A0C
		public TInhalationPerformanceUnion InhalationPerformance { get; set; }

		// Token: 0x060234FF RID: 144639 RVA: 0x004E3815 File Offset: 0x004E1A15
		public IInhalationConfigT()
		{
			this.InhalationMatching = null;
			this.InhalationPerformance = null;
		}
	}
}
