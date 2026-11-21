using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF6 RID: 16374
	public class IActorRefVolumeT
	{
		// Token: 0x17006EE3 RID: 28387
		// (get) Token: 0x0601666B RID: 91755 RVA: 0x00335212 File Offset: 0x00333412
		// (set) Token: 0x0601666C RID: 91756 RVA: 0x0033521A File Offset: 0x0033341A
		public ETriggerShape Type { get; set; }

		// Token: 0x0601666D RID: 91757 RVA: 0x00335223 File Offset: 0x00333423
		public IActorRefVolumeT()
		{
			this.Type = ETriggerShape.Box;
		}
	}
}
