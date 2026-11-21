using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675E RID: 26462
	public class IActorTurnToDataT
	{
		// Token: 0x1700C070 RID: 49264
		// (get) Token: 0x0602CDA6 RID: 183718 RVA: 0x006224F2 File Offset: 0x006206F2
		// (set) Token: 0x0602CDA7 RID: 183719 RVA: 0x006224FA File Offset: 0x006206FA
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602CDA8 RID: 183720 RVA: 0x00622503 File Offset: 0x00620703
		public IActorTurnToDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
