using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CFE RID: 19710
	public class IPipelineConfigT
	{
		// Token: 0x17008D11 RID: 36113
		// (get) Token: 0x0601E801 RID: 124929 RVA: 0x004456E3 File Offset: 0x004438E3
		// (set) Token: 0x0601E802 RID: 124930 RVA: 0x004456EB File Offset: 0x004438EB
		public List<int> VoxelLevels { get; set; }

		// Token: 0x17008D12 RID: 36114
		// (get) Token: 0x0601E803 RID: 124931 RVA: 0x004456F4 File Offset: 0x004438F4
		// (set) Token: 0x0601E804 RID: 124932 RVA: 0x004456FC File Offset: 0x004438FC
		public byte NullMask { get; set; }

		// Token: 0x0601E805 RID: 124933 RVA: 0x00445705 File Offset: 0x00443905
		public IPipelineConfigT()
		{
			this.VoxelLevels = null;
			this.NullMask = 0;
		}
	}
}
