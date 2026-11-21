using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD9 RID: 23769
	public class IPathDrivenActorInitialSpawnConfigT
	{
		// Token: 0x1700AEA8 RID: 44712
		// (get) Token: 0x06027761 RID: 161633 RVA: 0x005669A9 File Offset: 0x00564BA9
		// (set) Token: 0x06027762 RID: 161634 RVA: 0x005669B1 File Offset: 0x00564BB1
		public bool EnableInitialSpawn { get; set; }

		// Token: 0x1700AEA9 RID: 44713
		// (get) Token: 0x06027763 RID: 161635 RVA: 0x005669BA File Offset: 0x00564BBA
		// (set) Token: 0x06027764 RID: 161636 RVA: 0x005669C2 File Offset: 0x00564BC2
		public List<IPathDrivenActorInitialSpawnHandleT> InitialSpawnHandles { get; set; }

		// Token: 0x1700AEAA RID: 44714
		// (get) Token: 0x06027765 RID: 161637 RVA: 0x005669CB File Offset: 0x00564BCB
		// (set) Token: 0x06027766 RID: 161638 RVA: 0x005669D3 File Offset: 0x00564BD3
		public byte NullMask { get; set; }

		// Token: 0x06027767 RID: 161639 RVA: 0x005669DC File Offset: 0x00564BDC
		public IPathDrivenActorInitialSpawnConfigT()
		{
			this.EnableInitialSpawn = false;
			this.InitialSpawnHandles = null;
			this.NullMask = 0;
		}
	}
}
