using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005921 RID: 22817
	public class ISkyboxGlobalTriggerT
	{
		// Token: 0x1700AB26 RID: 43814
		// (get) Token: 0x06026958 RID: 158040 RVA: 0x005507AA File Offset: 0x0054E9AA
		// (set) Token: 0x06026959 RID: 158041 RVA: 0x005507B2 File Offset: 0x0054E9B2
		public ETriggerMode Type { get; set; }

		// Token: 0x0602695A RID: 158042 RVA: 0x005507BB File Offset: 0x0054E9BB
		public ISkyboxGlobalTriggerT()
		{
			this.Type = ETriggerMode.Distance;
		}
	}
}
