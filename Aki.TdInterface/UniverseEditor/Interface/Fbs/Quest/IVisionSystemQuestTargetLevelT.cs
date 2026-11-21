using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046DA RID: 18138
	public class IVisionSystemQuestTargetLevelT
	{
		// Token: 0x17007F01 RID: 32513
		// (get) Token: 0x0601AA98 RID: 109208 RVA: 0x003CA334 File Offset: 0x003C8534
		// (set) Token: 0x0601AA99 RID: 109209 RVA: 0x003CA33C File Offset: 0x003C853C
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x17007F02 RID: 32514
		// (get) Token: 0x0601AA9A RID: 109210 RVA: 0x003CA345 File Offset: 0x003C8545
		// (set) Token: 0x0601AA9B RID: 109211 RVA: 0x003CA34D File Offset: 0x003C854D
		public int TargetLevel { get; set; }

		// Token: 0x0601AA9C RID: 109212 RVA: 0x003CA356 File Offset: 0x003C8556
		public IVisionSystemQuestTargetLevelT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
			this.TargetLevel = 0;
		}
	}
}
