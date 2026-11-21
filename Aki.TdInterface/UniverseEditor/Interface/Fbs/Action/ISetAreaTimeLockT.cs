using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776F RID: 30575
	public class ISetAreaTimeLockT
	{
		// Token: 0x1700E016 RID: 57366
		// (get) Token: 0x06035AA3 RID: 219811 RVA: 0x00731115 File Offset: 0x0072F315
		// (set) Token: 0x06035AA4 RID: 219812 RVA: 0x0073111D File Offset: 0x0072F31D
		public ESetAreaTime Type { get; set; }

		// Token: 0x1700E017 RID: 57367
		// (get) Token: 0x06035AA5 RID: 219813 RVA: 0x00731126 File Offset: 0x0072F326
		// (set) Token: 0x06035AA6 RID: 219814 RVA: 0x0073112E File Offset: 0x0072F32E
		public List<int> AreaIds { get; set; }

		// Token: 0x1700E018 RID: 57368
		// (get) Token: 0x06035AA7 RID: 219815 RVA: 0x00731137 File Offset: 0x0072F337
		// (set) Token: 0x06035AA8 RID: 219816 RVA: 0x0073113F File Offset: 0x0072F33F
		public IFixedTimeT LockTime { get; set; }

		// Token: 0x06035AA9 RID: 219817 RVA: 0x00731148 File Offset: 0x0072F348
		public ISetAreaTimeLockT()
		{
			this.Type = ESetAreaTime.Lock;
			this.AreaIds = null;
			this.LockTime = null;
		}
	}
}
