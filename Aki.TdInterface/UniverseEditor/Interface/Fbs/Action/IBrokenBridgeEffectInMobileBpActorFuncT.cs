using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006225 RID: 25125
	public class IBrokenBridgeEffectInMobileBpActorFuncT
	{
		// Token: 0x1700BB38 RID: 47928
		// (get) Token: 0x0602B4F2 RID: 177394 RVA: 0x005F6D3B File Offset: 0x005F4F3B
		// (set) Token: 0x0602B4F3 RID: 177395 RVA: 0x005F6D43 File Offset: 0x005F4F43
		public EBpActorFuncType Type { get; set; }

		// Token: 0x1700BB39 RID: 47929
		// (get) Token: 0x0602B4F4 RID: 177396 RVA: 0x005F6D4C File Offset: 0x005F4F4C
		// (set) Token: 0x0602B4F5 RID: 177397 RVA: 0x005F6D54 File Offset: 0x005F4F54
		public IActorRefT BpActor { get; set; }

		// Token: 0x0602B4F6 RID: 177398 RVA: 0x005F6D5D File Offset: 0x005F4F5D
		public IBrokenBridgeEffectInMobileBpActorFuncT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
			this.BpActor = null;
		}
	}
}
