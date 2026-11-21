using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006544 RID: 25924
	public class IStreamingGroupT
	{
		// Token: 0x1700BF3B RID: 48955
		// (get) Token: 0x0602C326 RID: 181030 RVA: 0x00604D9B File Offset: 0x00602F9B
		// (set) Token: 0x0602C327 RID: 181031 RVA: 0x00604DA3 File Offset: 0x00602FA3
		public int EntityId { get; set; }

		// Token: 0x1700BF3C RID: 48956
		// (get) Token: 0x0602C328 RID: 181032 RVA: 0x00604DAC File Offset: 0x00602FAC
		// (set) Token: 0x0602C329 RID: 181033 RVA: 0x00604DB4 File Offset: 0x00602FB4
		public List<IActorRefT> RefData { get; set; }

		// Token: 0x0602C32A RID: 181034 RVA: 0x00604DBD File Offset: 0x00602FBD
		public IStreamingGroupT()
		{
			this.EntityId = 0;
			this.RefData = null;
		}
	}
}
