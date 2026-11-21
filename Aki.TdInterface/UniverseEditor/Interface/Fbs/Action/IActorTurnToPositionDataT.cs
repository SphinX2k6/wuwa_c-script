using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676D RID: 26477
	public class IActorTurnToPositionDataT
	{
		// Token: 0x1700C081 RID: 49281
		// (get) Token: 0x0602CE08 RID: 183816 RVA: 0x00622E37 File Offset: 0x00621037
		// (set) Token: 0x0602CE09 RID: 183817 RVA: 0x00622E3F File Offset: 0x0062103F
		public EActorTurnToMode Type { get; set; }

		// Token: 0x1700C082 RID: 49282
		// (get) Token: 0x0602CE0A RID: 183818 RVA: 0x00622E48 File Offset: 0x00621048
		// (set) Token: 0x0602CE0B RID: 183819 RVA: 0x00622E50 File Offset: 0x00621050
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602CE0C RID: 183820 RVA: 0x00622E59 File Offset: 0x00621059
		public IActorTurnToPositionDataT()
		{
			this.Type = EActorTurnToMode.Talker;
			this.Pos = null;
		}
	}
}
