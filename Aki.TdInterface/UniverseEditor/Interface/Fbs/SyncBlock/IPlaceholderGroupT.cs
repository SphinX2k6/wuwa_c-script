using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F84 RID: 16260
	public class IPlaceholderGroupT
	{
		// Token: 0x17006E0A RID: 28170
		// (get) Token: 0x06016283 RID: 90755 RVA: 0x0032D953 File Offset: 0x0032BB53
		// (set) Token: 0x06016284 RID: 90756 RVA: 0x0032D95B File Offset: 0x0032BB5B
		public int FragmentId { get; set; }

		// Token: 0x17006E0B RID: 28171
		// (get) Token: 0x06016285 RID: 90757 RVA: 0x0032D964 File Offset: 0x0032BB64
		// (set) Token: 0x06016286 RID: 90758 RVA: 0x0032D96C File Offset: 0x0032BB6C
		public List<IPlaceholderT> Placeholders { get; set; }

		// Token: 0x06016287 RID: 90759 RVA: 0x0032D975 File Offset: 0x0032BB75
		public IPlaceholderGroupT()
		{
			this.FragmentId = 0;
			this.Placeholders = null;
		}
	}
}
