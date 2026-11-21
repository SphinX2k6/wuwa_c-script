using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F9 RID: 31225
	public class ISubtitleStyleBaseT
	{
		// Token: 0x1700E4E2 RID: 58594
		// (get) Token: 0x06037060 RID: 225376 RVA: 0x0075AEB6 File Offset: 0x007590B6
		// (set) Token: 0x06037061 RID: 225377 RVA: 0x0075AEBE File Offset: 0x007590BE
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06037062 RID: 225378 RVA: 0x0075AEC7 File Offset: 0x007590C7
		public ISubtitleStyleBaseT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
