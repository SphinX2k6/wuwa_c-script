using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F79 RID: 28537
	public class ISendSceneActorEventT
	{
		// Token: 0x1700D3FA RID: 54266
		// (get) Token: 0x060326B4 RID: 206516 RVA: 0x006CE4ED File Offset: 0x006CC6ED
		// (set) Token: 0x060326B5 RID: 206517 RVA: 0x006CE4F5 File Offset: 0x006CC6F5
		public TSceneActorEventUnion ActorEvent { get; set; }

		// Token: 0x060326B6 RID: 206518 RVA: 0x006CE4FE File Offset: 0x006CC6FE
		public ISendSceneActorEventT()
		{
			this.ActorEvent = null;
		}
	}
}
