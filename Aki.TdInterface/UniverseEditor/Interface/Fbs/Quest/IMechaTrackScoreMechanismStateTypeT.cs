using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2A RID: 16170
	public class IMechaTrackScoreMechanismStateTypeT
	{
		// Token: 0x1700706E RID: 28782
		// (get) Token: 0x06016F70 RID: 94064 RVA: 0x003503C5 File Offset: 0x0034E5C5
		// (set) Token: 0x06016F71 RID: 94065 RVA: 0x003503CD File Offset: 0x0034E5CD
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x1700706F RID: 28783
		// (get) Token: 0x06016F72 RID: 94066 RVA: 0x003503D6 File Offset: 0x0034E5D6
		// (set) Token: 0x06016F73 RID: 94067 RVA: 0x003503DE File Offset: 0x0034E5DE
		public string State { get; set; }

		// Token: 0x17007070 RID: 28784
		// (get) Token: 0x06016F74 RID: 94068 RVA: 0x003503E7 File Offset: 0x0034E5E7
		// (set) Token: 0x06016F75 RID: 94069 RVA: 0x003503EF File Offset: 0x0034E5EF
		public int ScoreId { get; set; }

		// Token: 0x06016F76 RID: 94070 RVA: 0x003503F8 File Offset: 0x0034E5F8
		public IMechaTrackScoreMechanismStateTypeT()
		{
			this.EntitiyMatch = null;
			this.State = null;
			this.ScoreId = 0;
		}
	}
}
