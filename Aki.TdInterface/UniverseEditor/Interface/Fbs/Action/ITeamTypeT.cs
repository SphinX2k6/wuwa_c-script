using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B52 RID: 31570
	public class ITeamTypeT
	{
		// Token: 0x1700EC66 RID: 60518
		// (get) Token: 0x06038DA5 RID: 232869 RVA: 0x007AFCEE File Offset: 0x007ADEEE
		// (set) Token: 0x06038DA6 RID: 232870 RVA: 0x007AFCF6 File Offset: 0x007ADEF6
		public ETeamType Type { get; set; }

		// Token: 0x06038DA7 RID: 232871 RVA: 0x007AFCFF File Offset: 0x007ADEFF
		public ITeamTypeT()
		{
			this.Type = ETeamType.Current;
		}
	}
}
