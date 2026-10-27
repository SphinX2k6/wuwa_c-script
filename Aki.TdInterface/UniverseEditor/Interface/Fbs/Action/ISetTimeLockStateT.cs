using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007095 RID: 28821
	public class ISetTimeLockStateT
	{
		// Token: 0x1700D62A RID: 54826
		// (get) Token: 0x06033098 RID: 209048 RVA: 0x006E2596 File Offset: 0x006E0796
		// (set) Token: 0x06033099 RID: 209049 RVA: 0x006E259E File Offset: 0x006E079E
		public ELockState LockState { get; set; }

		// Token: 0x0603309A RID: 209050 RVA: 0x006E25A7 File Offset: 0x006E07A7
		public ISetTimeLockStateT()
		{
			this.LockState = ELockState.Lock;
		}
	}
}
