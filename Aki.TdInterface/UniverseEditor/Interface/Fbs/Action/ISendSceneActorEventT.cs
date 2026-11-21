using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773F RID: 30527
	public class ISendSceneActorEventT
	{
		// Token: 0x1700DFC9 RID: 57289
		// (get) Token: 0x06035904 RID: 219396 RVA: 0x0072DEA5 File Offset: 0x0072C0A5
		// (set) Token: 0x06035905 RID: 219397 RVA: 0x0072DEAD File Offset: 0x0072C0AD
		public TSceneActorEventUnion ActorEvent { get; set; }

		// Token: 0x06035906 RID: 219398 RVA: 0x0072DEB6 File Offset: 0x0072C0B6
		public ISendSceneActorEventT()
		{
			this.ActorEvent = null;
		}
	}
}
