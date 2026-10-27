using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F81 RID: 16257
	public class IPhotographConditionT
	{
		// Token: 0x1700717A RID: 29050
		// (get) Token: 0x06017366 RID: 95078 RVA: 0x00359759 File Offset: 0x00357959
		// (set) Token: 0x06017367 RID: 95079 RVA: 0x00359761 File Offset: 0x00357961
		public string TidTip { get; set; }

		// Token: 0x1700717B RID: 29051
		// (get) Token: 0x06017368 RID: 95080 RVA: 0x0035976A File Offset: 0x0035796A
		// (set) Token: 0x06017369 RID: 95081 RVA: 0x00359772 File Offset: 0x00357972
		public TPhotographTargetUnion Target { get; set; }

		// Token: 0x1700717C RID: 29052
		// (get) Token: 0x0601736A RID: 95082 RVA: 0x0035977B File Offset: 0x0035797B
		// (set) Token: 0x0601736B RID: 95083 RVA: 0x00359783 File Offset: 0x00357983
		public List<TPhotographSubTargetUnion> SubTargets { get; set; }

		// Token: 0x1700717D RID: 29053
		// (get) Token: 0x0601736C RID: 95084 RVA: 0x0035978C File Offset: 0x0035798C
		// (set) Token: 0x0601736D RID: 95085 RVA: 0x00359794 File Offset: 0x00357994
		public byte NullMask { get; set; }

		// Token: 0x0601736E RID: 95086 RVA: 0x0035979D File Offset: 0x0035799D
		public IPhotographConditionT()
		{
			this.TidTip = null;
			this.Target = null;
			this.SubTargets = null;
			this.NullMask = 0;
		}
	}
}
