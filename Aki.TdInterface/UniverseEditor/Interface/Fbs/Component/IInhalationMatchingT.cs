using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005985 RID: 22917
	public class IInhalationMatchingT
	{
		// Token: 0x1700A677 RID: 42615
		// (get) Token: 0x060255C9 RID: 153033 RVA: 0x00520AD3 File Offset: 0x0051ECD3
		// (set) Token: 0x060255CA RID: 153034 RVA: 0x00520ADB File Offset: 0x0051ECDB
		public int InhalationStrength { get; set; }

		// Token: 0x1700A678 RID: 42616
		// (get) Token: 0x060255CB RID: 153035 RVA: 0x00520AE4 File Offset: 0x0051ECE4
		// (set) Token: 0x060255CC RID: 153036 RVA: 0x00520AEC File Offset: 0x0051ECEC
		public ICategoryMatchingConditionT EntityMatch { get; set; }

		// Token: 0x060255CD RID: 153037 RVA: 0x00520AF5 File Offset: 0x0051ECF5
		public IInhalationMatchingT()
		{
			this.InhalationStrength = 0;
			this.EntityMatch = null;
		}
	}
}
