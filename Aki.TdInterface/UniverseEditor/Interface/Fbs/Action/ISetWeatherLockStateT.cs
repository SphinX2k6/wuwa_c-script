using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200787F RID: 30847
	public class ISetWeatherLockStateT
	{
		// Token: 0x1700E236 RID: 57910
		// (get) Token: 0x0603642B RID: 222251 RVA: 0x00744825 File Offset: 0x00742A25
		// (set) Token: 0x0603642C RID: 222252 RVA: 0x0074482D File Offset: 0x00742A2D
		public ELockState LockState { get; set; }

		// Token: 0x1700E237 RID: 57911
		// (get) Token: 0x0603642D RID: 222253 RVA: 0x00744836 File Offset: 0x00742A36
		// (set) Token: 0x0603642E RID: 222254 RVA: 0x0074483E File Offset: 0x00742A3E
		public List<int> AreaIds { get; set; }

		// Token: 0x1700E238 RID: 57912
		// (get) Token: 0x0603642F RID: 222255 RVA: 0x00744847 File Offset: 0x00742A47
		// (set) Token: 0x06036430 RID: 222256 RVA: 0x0074484F File Offset: 0x00742A4F
		public byte NullMask { get; set; }

		// Token: 0x06036431 RID: 222257 RVA: 0x00744858 File Offset: 0x00742A58
		public ISetWeatherLockStateT()
		{
			this.LockState = ELockState.Lock;
			this.AreaIds = null;
			this.NullMask = 0;
		}
	}
}
