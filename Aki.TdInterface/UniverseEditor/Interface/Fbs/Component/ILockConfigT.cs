using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550D RID: 21773
	public class ILockConfigT
	{
		// Token: 0x1700A0C4 RID: 41156
		// (get) Token: 0x06023F6D RID: 147309 RVA: 0x004F8A9A File Offset: 0x004F6C9A
		// (set) Token: 0x06023F6E RID: 147310 RVA: 0x004F8AA2 File Offset: 0x004F6CA2
		public bool IsInitLock { get; set; }

		// Token: 0x1700A0C5 RID: 41157
		// (get) Token: 0x06023F6F RID: 147311 RVA: 0x004F8AAB File Offset: 0x004F6CAB
		// (set) Token: 0x06023F70 RID: 147312 RVA: 0x004F8AB3 File Offset: 0x004F6CB3
		public ELockType LockType { get; set; }

		// Token: 0x1700A0C6 RID: 41158
		// (get) Token: 0x06023F71 RID: 147313 RVA: 0x004F8ABC File Offset: 0x004F6CBC
		// (set) Token: 0x06023F72 RID: 147314 RVA: 0x004F8AC4 File Offset: 0x004F6CC4
		public byte NullMask { get; set; }

		// Token: 0x06023F73 RID: 147315 RVA: 0x004F8ACD File Offset: 0x004F6CCD
		public ILockConfigT()
		{
			this.IsInitLock = false;
			this.LockType = ELockType.Default;
			this.NullMask = 0;
		}
	}
}
