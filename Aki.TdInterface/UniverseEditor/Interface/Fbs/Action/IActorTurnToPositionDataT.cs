using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610B RID: 24843
	public class IActorTurnToPositionDataT
	{
		// Token: 0x1700B716 RID: 46870
		// (get) Token: 0x0602A727 RID: 173863 RVA: 0x005D8E8F File Offset: 0x005D708F
		// (set) Token: 0x0602A728 RID: 173864 RVA: 0x005D8E97 File Offset: 0x005D7097
		public EActorTurnToMode Type { get; set; }

		// Token: 0x1700B717 RID: 46871
		// (get) Token: 0x0602A729 RID: 173865 RVA: 0x005D8EA0 File Offset: 0x005D70A0
		// (set) Token: 0x0602A72A RID: 173866 RVA: 0x005D8EA8 File Offset: 0x005D70A8
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602A72B RID: 173867 RVA: 0x005D8EB1 File Offset: 0x005D70B1
		public IActorTurnToPositionDataT()
		{
			this.Type = EActorTurnToMode.Talker;
			this.Pos = null;
		}
	}
}
