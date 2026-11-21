using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F6 RID: 17910
	public class ITakePhoto2TargetPlayMontageConditionT
	{
		// Token: 0x17007D50 RID: 32080
		// (get) Token: 0x0601A2E5 RID: 107237 RVA: 0x003BA9ED File Offset: 0x003B8BED
		// (set) Token: 0x0601A2E6 RID: 107238 RVA: 0x003BA9F5 File Offset: 0x003B8BF5
		public string MontagePath { get; set; }

		// Token: 0x0601A2E7 RID: 107239 RVA: 0x003BA9FE File Offset: 0x003B8BFE
		public ITakePhoto2TargetPlayMontageConditionT()
		{
			this.MontagePath = null;
		}
	}
}
