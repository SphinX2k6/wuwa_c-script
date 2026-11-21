using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007861 RID: 30817
	public class ISetTimeLockStateT
	{
		// Token: 0x1700E20D RID: 57869
		// (get) Token: 0x0603633A RID: 222010 RVA: 0x00742BA2 File Offset: 0x00740DA2
		// (set) Token: 0x0603633B RID: 222011 RVA: 0x00742BAA File Offset: 0x00740DAA
		public ELockState LockState { get; set; }

		// Token: 0x0603633C RID: 222012 RVA: 0x00742BB3 File Offset: 0x00740DB3
		public ISetTimeLockStateT()
		{
			this.LockState = ELockState.Lock;
		}
	}
}
