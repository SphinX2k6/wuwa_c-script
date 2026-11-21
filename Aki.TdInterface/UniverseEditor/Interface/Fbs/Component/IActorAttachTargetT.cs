using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005365 RID: 21349
	public class IActorAttachTargetT
	{
		// Token: 0x170096BD RID: 38589
		// (get) Token: 0x060213F7 RID: 136183 RVA: 0x00496B0F File Offset: 0x00494D0F
		// (set) Token: 0x060213F8 RID: 136184 RVA: 0x00496B17 File Offset: 0x00494D17
		public EAttachType Type { get; set; }

		// Token: 0x170096BE RID: 38590
		// (get) Token: 0x060213F9 RID: 136185 RVA: 0x00496B20 File Offset: 0x00494D20
		// (set) Token: 0x060213FA RID: 136186 RVA: 0x00496B28 File Offset: 0x00494D28
		public IActorRefT ActorRef { get; set; }

		// Token: 0x060213FB RID: 136187 RVA: 0x00496B31 File Offset: 0x00494D31
		public IActorAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.ActorRef = null;
		}
	}
}
