using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006896 RID: 26774
	public class IBrokenBridgeEffectInMobileBpActorFuncT
	{
		// Token: 0x1700C4C0 RID: 50368
		// (get) Token: 0x0602DC53 RID: 187475 RVA: 0x00641B43 File Offset: 0x0063FD43
		// (set) Token: 0x0602DC54 RID: 187476 RVA: 0x00641B4B File Offset: 0x0063FD4B
		public EBpActorFuncType Type { get; set; }

		// Token: 0x1700C4C1 RID: 50369
		// (get) Token: 0x0602DC55 RID: 187477 RVA: 0x00641B54 File Offset: 0x0063FD54
		// (set) Token: 0x0602DC56 RID: 187478 RVA: 0x00641B5C File Offset: 0x0063FD5C
		public IActorRefT BpActor { get; set; }

		// Token: 0x0602DC57 RID: 187479 RVA: 0x00641B65 File Offset: 0x0063FD65
		public IBrokenBridgeEffectInMobileBpActorFuncT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
			this.BpActor = null;
		}
	}
}
