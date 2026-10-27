using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE4 RID: 15332
	public class IActorCollisionTriggerShapeT
	{
		// Token: 0x17006930 RID: 26928
		// (get) Token: 0x06015147 RID: 86343 RVA: 0x0030E23B File Offset: 0x0030C43B
		// (set) Token: 0x06015148 RID: 86344 RVA: 0x0030E243 File Offset: 0x0030C443
		public ETriggerShape Type { get; set; }

		// Token: 0x17006931 RID: 26929
		// (get) Token: 0x06015149 RID: 86345 RVA: 0x0030E24C File Offset: 0x0030C44C
		// (set) Token: 0x0601514A RID: 86346 RVA: 0x0030E254 File Offset: 0x0030C454
		public IActorRefT ActorRef { get; set; }

		// Token: 0x0601514B RID: 86347 RVA: 0x0030E25D File Offset: 0x0030C45D
		public IActorCollisionTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.ActorRef = null;
		}
	}
}
