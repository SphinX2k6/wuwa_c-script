using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005241 RID: 21057
	public class IFightInteractComponentT
	{
		// Token: 0x17009A47 RID: 39495
		// (get) Token: 0x06022407 RID: 140295 RVA: 0x004C03A3 File Offset: 0x004BE5A3
		// (set) Token: 0x06022408 RID: 140296 RVA: 0x004C03AB File Offset: 0x004BE5AB
		public bool Disabled { get; set; }

		// Token: 0x17009A48 RID: 39496
		// (get) Token: 0x06022409 RID: 140297 RVA: 0x004C03B4 File Offset: 0x004BE5B4
		// (set) Token: 0x0602240A RID: 140298 RVA: 0x004C03BC File Offset: 0x004BE5BC
		public int LockRange { get; set; }

		// Token: 0x17009A49 RID: 39497
		// (get) Token: 0x0602240B RID: 140299 RVA: 0x004C03C5 File Offset: 0x004BE5C5
		// (set) Token: 0x0602240C RID: 140300 RVA: 0x004C03CD File Offset: 0x004BE5CD
		public IVectorInfoT LockOffset { get; set; }

		// Token: 0x17009A4A RID: 39498
		// (get) Token: 0x0602240D RID: 140301 RVA: 0x004C03D6 File Offset: 0x004BE5D6
		// (set) Token: 0x0602240E RID: 140302 RVA: 0x004C03DE File Offset: 0x004BE5DE
		public bool DisableLock { get; set; }

		// Token: 0x17009A4B RID: 39499
		// (get) Token: 0x0602240F RID: 140303 RVA: 0x004C03E7 File Offset: 0x004BE5E7
		// (set) Token: 0x06022410 RID: 140304 RVA: 0x004C03EF File Offset: 0x004BE5EF
		public IAutoLockControlT LockControl { get; set; }

		// Token: 0x17009A4C RID: 39500
		// (get) Token: 0x06022411 RID: 140305 RVA: 0x004C03F8 File Offset: 0x004BE5F8
		// (set) Token: 0x06022412 RID: 140306 RVA: 0x004C0400 File Offset: 0x004BE600
		public byte NullMask { get; set; }

		// Token: 0x06022413 RID: 140307 RVA: 0x004C0409 File Offset: 0x004BE609
		public IFightInteractComponentT()
		{
			this.Disabled = false;
			this.LockRange = 0;
			this.LockOffset = null;
			this.DisableLock = false;
			this.LockControl = null;
			this.NullMask = 0;
		}
	}
}
