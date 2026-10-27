using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047EE RID: 18414
	public class IRunningResetReviveInfoT
	{
		// Token: 0x17008458 RID: 33880
		// (get) Token: 0x0601C7B2 RID: 116658 RVA: 0x004077F4 File Offset: 0x004059F4
		// (set) Token: 0x0601C7B3 RID: 116659 RVA: 0x004077FC File Offset: 0x004059FC
		public List<IInstEntityDataT> ResetDatas { get; set; }

		// Token: 0x17008459 RID: 33881
		// (get) Token: 0x0601C7B4 RID: 116660 RVA: 0x00407805 File Offset: 0x00405A05
		// (set) Token: 0x0601C7B5 RID: 116661 RVA: 0x0040780D File Offset: 0x00405A0D
		public List<IInstEntityDataT> ReviveDatas { get; set; }

		// Token: 0x1700845A RID: 33882
		// (get) Token: 0x0601C7B6 RID: 116662 RVA: 0x00407816 File Offset: 0x00405A16
		// (set) Token: 0x0601C7B7 RID: 116663 RVA: 0x0040781E File Offset: 0x00405A1E
		public byte NullMask { get; set; }

		// Token: 0x0601C7B8 RID: 116664 RVA: 0x00407827 File Offset: 0x00405A27
		public IRunningResetReviveInfoT()
		{
			this.ResetDatas = null;
			this.ReviveDatas = null;
			this.NullMask = 0;
		}
	}
}
