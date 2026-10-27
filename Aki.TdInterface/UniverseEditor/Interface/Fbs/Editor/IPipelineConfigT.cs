using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004899 RID: 18585
	public class IPipelineConfigT
	{
		// Token: 0x170086C9 RID: 34505
		// (get) Token: 0x0601D014 RID: 118804 RVA: 0x00418F47 File Offset: 0x00417147
		// (set) Token: 0x0601D015 RID: 118805 RVA: 0x00418F4F File Offset: 0x0041714F
		public List<int> VoxelLevels { get; set; }

		// Token: 0x170086CA RID: 34506
		// (get) Token: 0x0601D016 RID: 118806 RVA: 0x00418F58 File Offset: 0x00417158
		// (set) Token: 0x0601D017 RID: 118807 RVA: 0x00418F60 File Offset: 0x00417160
		public byte NullMask { get; set; }

		// Token: 0x0601D018 RID: 118808 RVA: 0x00418F69 File Offset: 0x00417169
		public IPipelineConfigT()
		{
			this.VoxelLevels = null;
			this.NullMask = 0;
		}
	}
}
