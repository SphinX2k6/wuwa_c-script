using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF0 RID: 16368
	public class IActorCollisionTriggerShapeT
	{
		// Token: 0x17006ED8 RID: 28376
		// (get) Token: 0x0601663D RID: 91709 RVA: 0x00334DC3 File Offset: 0x00332FC3
		// (set) Token: 0x0601663E RID: 91710 RVA: 0x00334DCB File Offset: 0x00332FCB
		public ETriggerShape Type { get; set; }

		// Token: 0x17006ED9 RID: 28377
		// (get) Token: 0x0601663F RID: 91711 RVA: 0x00334DD4 File Offset: 0x00332FD4
		// (set) Token: 0x06016640 RID: 91712 RVA: 0x00334DDC File Offset: 0x00332FDC
		public IActorRefT ActorRef { get; set; }

		// Token: 0x06016641 RID: 91713 RVA: 0x00334DE5 File Offset: 0x00332FE5
		public IActorCollisionTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.ActorRef = null;
		}
	}
}
