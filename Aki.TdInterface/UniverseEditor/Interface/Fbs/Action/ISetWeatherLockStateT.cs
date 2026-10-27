using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B3 RID: 28851
	public class ISetWeatherLockStateT
	{
		// Token: 0x1700D653 RID: 54867
		// (get) Token: 0x06033189 RID: 209289 RVA: 0x006E4219 File Offset: 0x006E2419
		// (set) Token: 0x0603318A RID: 209290 RVA: 0x006E4221 File Offset: 0x006E2421
		public ELockState LockState { get; set; }

		// Token: 0x1700D654 RID: 54868
		// (get) Token: 0x0603318B RID: 209291 RVA: 0x006E422A File Offset: 0x006E242A
		// (set) Token: 0x0603318C RID: 209292 RVA: 0x006E4232 File Offset: 0x006E2432
		public List<int> AreaIds { get; set; }

		// Token: 0x1700D655 RID: 54869
		// (get) Token: 0x0603318D RID: 209293 RVA: 0x006E423B File Offset: 0x006E243B
		// (set) Token: 0x0603318E RID: 209294 RVA: 0x006E4243 File Offset: 0x006E2443
		public byte NullMask { get; set; }

		// Token: 0x0603318F RID: 209295 RVA: 0x006E424C File Offset: 0x006E244C
		public ISetWeatherLockStateT()
		{
			this.LockState = ELockState.Lock;
			this.AreaIds = null;
			this.NullMask = 0;
		}
	}
}
