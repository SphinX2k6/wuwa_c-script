using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005982 RID: 22914
	public class IInhalationConfigT
	{
		// Token: 0x1700A672 RID: 42610
		// (get) Token: 0x060255B3 RID: 153011 RVA: 0x0052081F File Offset: 0x0051EA1F
		// (set) Token: 0x060255B4 RID: 153012 RVA: 0x00520827 File Offset: 0x0051EA27
		public IInhalationMatchingT InhalationMatching { get; set; }

		// Token: 0x1700A673 RID: 42611
		// (get) Token: 0x060255B5 RID: 153013 RVA: 0x00520830 File Offset: 0x0051EA30
		// (set) Token: 0x060255B6 RID: 153014 RVA: 0x00520838 File Offset: 0x0051EA38
		public TInhalationPerformanceUnion InhalationPerformance { get; set; }

		// Token: 0x060255B7 RID: 153015 RVA: 0x00520841 File Offset: 0x0051EA41
		public IInhalationConfigT()
		{
			this.InhalationMatching = null;
			this.InhalationPerformance = null;
		}
	}
}
