using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Utils.LockingHandler
{
	// Token: 0x0200012C RID: 300
	[NullableContext(1)]
	[Nullable(0)]
	public class UniqueLockingHandler<[Nullable(2)] TLockReason>
	{
		// Token: 0x06000AD2 RID: 2770 RVA: 0x00034A35 File Offset: 0x00032C35
		public void Lock(TLockReason lockReason)
		{
			this.LockSet.Add(lockReason);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00034A44 File Offset: 0x00032C44
		public void Unlock(TLockReason lockReason)
		{
			if (!this.LockSet.Contains(lockReason))
			{
				return;
			}
			this.LockSet.Remove(lockReason);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00034A62 File Offset: 0x00032C62
		public bool IsLocked()
		{
			return this.LockSet.Count > 0;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00034A72 File Offset: 0x00032C72
		public bool IsUnlocked()
		{
			return this.LockSet.Count <= 0;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00034A85 File Offset: 0x00032C85
		public bool HasLock(TLockReason lockReason)
		{
			return this.LockSet.Contains(lockReason);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00034A93 File Offset: 0x00032C93
		public void Clear()
		{
			this.LockSet.Clear();
		}

		// Token: 0x040006B1 RID: 1713
		private readonly HashSet<TLockReason> LockSet = new HashSet<TLockReason>();
	}
}
