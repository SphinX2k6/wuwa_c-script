using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007775 RID: 30581
	public class ISetAreaTimeUnLockT
	{
		// Token: 0x1700E01F RID: 57375
		// (get) Token: 0x06035AD9 RID: 219865 RVA: 0x00731787 File Offset: 0x0072F987
		// (set) Token: 0x06035ADA RID: 219866 RVA: 0x0073178F File Offset: 0x0072F98F
		public ESetAreaTime Type { get; set; }

		// Token: 0x1700E020 RID: 57376
		// (get) Token: 0x06035ADB RID: 219867 RVA: 0x00731798 File Offset: 0x0072F998
		// (set) Token: 0x06035ADC RID: 219868 RVA: 0x007317A0 File Offset: 0x0072F9A0
		public List<int> AreaIds { get; set; }

		// Token: 0x06035ADD RID: 219869 RVA: 0x007317A9 File Offset: 0x0072F9A9
		public ISetAreaTimeUnLockT()
		{
			this.Type = ESetAreaTime.Lock;
			this.AreaIds = null;
		}
	}
}
