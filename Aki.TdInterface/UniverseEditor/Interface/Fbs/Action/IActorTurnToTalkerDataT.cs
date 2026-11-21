using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006770 RID: 26480
	public class IActorTurnToTalkerDataT
	{
		// Token: 0x1700C085 RID: 49285
		// (get) Token: 0x0602CE1C RID: 183836 RVA: 0x00622FF6 File Offset: 0x006211F6
		// (set) Token: 0x0602CE1D RID: 183837 RVA: 0x00622FFE File Offset: 0x006211FE
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602CE1E RID: 183838 RVA: 0x00623007 File Offset: 0x00621207
		public IActorTurnToTalkerDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
