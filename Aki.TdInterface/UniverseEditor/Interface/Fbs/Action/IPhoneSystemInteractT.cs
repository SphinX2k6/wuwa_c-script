using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007422 RID: 29730
	public class IPhoneSystemInteractT
	{
		// Token: 0x1700DA63 RID: 55907
		// (get) Token: 0x0603404E RID: 213070 RVA: 0x00702C71 File Offset: 0x00700E71
		// (set) Token: 0x0603404F RID: 213071 RVA: 0x00702C79 File Offset: 0x00700E79
		public TPhoneSystemInteractUnion InteractType { get; set; }

		// Token: 0x06034050 RID: 213072 RVA: 0x00702C82 File Offset: 0x00700E82
		public IPhoneSystemInteractT()
		{
			this.InteractType = null;
		}
	}
}
