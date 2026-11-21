using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004605 RID: 17925
	public class ITakePhotoPosConditionT
	{
		// Token: 0x17007D69 RID: 32105
		// (get) Token: 0x0601A362 RID: 107362 RVA: 0x003BBA8B File Offset: 0x003B9C8B
		// (set) Token: 0x0601A363 RID: 107363 RVA: 0x003BBA93 File Offset: 0x003B9C93
		public int RangeEntity { get; set; }

		// Token: 0x17007D6A RID: 32106
		// (get) Token: 0x0601A364 RID: 107364 RVA: 0x003BBA9C File Offset: 0x003B9C9C
		// (set) Token: 0x0601A365 RID: 107365 RVA: 0x003BBAA4 File Offset: 0x003B9CA4
		public string TidDescription { get; set; }

		// Token: 0x0601A366 RID: 107366 RVA: 0x003BBAAD File Offset: 0x003B9CAD
		public ITakePhotoPosConditionT()
		{
			this.RangeEntity = 0;
			this.TidDescription = null;
		}
	}
}
