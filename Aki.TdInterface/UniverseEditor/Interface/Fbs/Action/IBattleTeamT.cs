using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686C RID: 26732
	public class IBattleTeamT
	{
		// Token: 0x1700C47C RID: 50300
		// (get) Token: 0x0602DB14 RID: 187156 RVA: 0x0063FA02 File Offset: 0x0063DC02
		// (set) Token: 0x0602DB15 RID: 187157 RVA: 0x0063FA0A File Offset: 0x0063DC0A
		public ETeamType Type { get; set; }

		// Token: 0x0602DB16 RID: 187158 RVA: 0x0063FA13 File Offset: 0x0063DC13
		public IBattleTeamT()
		{
			this.Type = ETeamType.Current;
		}
	}
}
