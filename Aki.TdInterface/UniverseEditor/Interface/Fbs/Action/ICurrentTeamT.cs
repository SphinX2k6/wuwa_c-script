using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5B RID: 27483
	public class ICurrentTeamT
	{
		// Token: 0x1700C9C2 RID: 51650
		// (get) Token: 0x0602F4BD RID: 193725 RVA: 0x00674D2E File Offset: 0x00672F2E
		// (set) Token: 0x0602F4BE RID: 193726 RVA: 0x00674D36 File Offset: 0x00672F36
		public ETeamType Type { get; set; }

		// Token: 0x0602F4BF RID: 193727 RVA: 0x00674D3F File Offset: 0x00672F3F
		public ICurrentTeamT()
		{
			this.Type = ETeamType.Current;
		}
	}
}
