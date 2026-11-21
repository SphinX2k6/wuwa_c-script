using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693B RID: 26939
	public class IChangeActorTalkerT
	{
		// Token: 0x1700C652 RID: 50770
		// (get) Token: 0x0602E2C6 RID: 189126 RVA: 0x0064EE80 File Offset: 0x0064D080
		// (set) Token: 0x0602E2C7 RID: 189127 RVA: 0x0064EE88 File Offset: 0x0064D088
		public int ActorIndex { get; set; }

		// Token: 0x1700C653 RID: 50771
		// (get) Token: 0x0602E2C8 RID: 189128 RVA: 0x0064EE91 File Offset: 0x0064D091
		// (set) Token: 0x0602E2C9 RID: 189129 RVA: 0x0064EE99 File Offset: 0x0064D099
		public int Talker { get; set; }

		// Token: 0x0602E2CA RID: 189130 RVA: 0x0064EEA2 File Offset: 0x0064D0A2
		public IChangeActorTalkerT()
		{
			this.ActorIndex = 0;
			this.Talker = 0;
		}
	}
}
