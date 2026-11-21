using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Utils.LockingHandler
{
	// Token: 0x0200012D RID: 301
	[NullableContext(1)]
	[Nullable(0)]
	public class UniqueLockingHandler<[Nullable(2)] TLockReason>
	{
		// Token: 0x06000B29 RID: 2857 RVA: 0x000354A9 File Offset: 0x000336A9
		public void Lock(TLockReason lockReason)
		{
			this.LockSet.Add(lockReason);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000354B8 File Offset: 0x000336B8
		public void Unlock(TLockReason lockReason)
		{
			if (!this.LockSet.Contains(lockReason))
			{
				return;
			}
			this.LockSet.Remove(lockReason);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x000354D6 File Offset: 0x000336D6
		public bool IsLocked()
		{
			return this.LockSet.Count > 0;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000354E6 File Offset: 0x000336E6
		public bool IsUnlocked()
		{
			return this.LockSet.Count <= 0;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000354F9 File Offset: 0x000336F9
		public bool HasLock(TLockReason lockReason)
		{
			return this.LockSet.Contains(lockReason);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00035507 File Offset: 0x00033707
		public void Clear()
		{
			this.LockSet.Clear();
		}

		// Token: 0x040006BF RID: 1727
		private readonly HashSet<TLockReason> LockSet = new HashSet<TLockReason>();
	}
}
