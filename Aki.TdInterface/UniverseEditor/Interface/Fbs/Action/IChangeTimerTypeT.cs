using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A1 RID: 27041
	public class IChangeTimerTypeT
	{
		// Token: 0x1700C710 RID: 50960
		// (get) Token: 0x0602E638 RID: 190008 RVA: 0x00654D82 File Offset: 0x00652F82
		// (set) Token: 0x0602E639 RID: 190009 RVA: 0x00654D8A File Offset: 0x00652F8A
		public EChangeTimerType Type { get; set; }

		// Token: 0x0602E63A RID: 190010 RVA: 0x00654D93 File Offset: 0x00652F93
		public IChangeTimerTypeT()
		{
			this.Type = EChangeTimerType.Add;
		}
	}
}
