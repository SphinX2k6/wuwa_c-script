using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004941 RID: 18753
	public interface IGiantSystemQuestOpenParam
	{
		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x0602F048 RID: 192584
		// (set) Token: 0x0602F049 RID: 192585
		GiantEcoNetType EcoType { get; set; }

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0602F04A RID: 192586
		// (set) Token: 0x0602F04B RID: 192587
		bool? GuideOnly { get; set; }
	}
}
