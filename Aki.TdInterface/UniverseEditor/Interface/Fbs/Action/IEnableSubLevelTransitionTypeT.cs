using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200668B RID: 26251
	public class IEnableSubLevelTransitionTypeT
	{
		// Token: 0x1700C317 RID: 49943
		// (get) Token: 0x0602DA01 RID: 186881 RVA: 0x0063EC02 File Offset: 0x0063CE02
		// (set) Token: 0x0602DA02 RID: 186882 RVA: 0x0063EC0A File Offset: 0x0063CE0A
		public EEnableSubLevelTransitionType Type { get; set; }

		// Token: 0x0602DA03 RID: 186883 RVA: 0x0063EC13 File Offset: 0x0063CE13
		public IEnableSubLevelTransitionTypeT()
		{
			this.Type = EEnableSubLevelTransitionType.SceneCapture;
		}
	}
}
