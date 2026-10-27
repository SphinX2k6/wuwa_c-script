using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005968 RID: 22888
	public interface IGiantSystemQuestOpenParam
	{
		// Token: 0x17008B2E RID: 35630
		// (get) Token: 0x0603A124 RID: 237860
		// (set) Token: 0x0603A125 RID: 237861
		GiantEcoNetType EcoType { get; set; }

		// Token: 0x17008B2F RID: 35631
		// (get) Token: 0x0603A126 RID: 237862
		// (set) Token: 0x0603A127 RID: 237863
		bool? GuideOnly { get; set; }
	}
}
