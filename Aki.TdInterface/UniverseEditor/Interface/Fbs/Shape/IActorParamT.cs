using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF3 RID: 16371
	public class IActorParamT
	{
		// Token: 0x17006EDE RID: 28382
		// (get) Token: 0x06016655 RID: 91733 RVA: 0x00335042 File Offset: 0x00333242
		// (set) Token: 0x06016656 RID: 91734 RVA: 0x0033504A File Offset: 0x0033324A
		public ETipsActorType Type { get; set; }

		// Token: 0x17006EDF RID: 28383
		// (get) Token: 0x06016657 RID: 91735 RVA: 0x00335053 File Offset: 0x00333253
		// (set) Token: 0x06016658 RID: 91736 RVA: 0x0033505B File Offset: 0x0033325B
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006EE0 RID: 28384
		// (get) Token: 0x06016659 RID: 91737 RVA: 0x00335064 File Offset: 0x00333264
		// (set) Token: 0x0601665A RID: 91738 RVA: 0x0033506C File Offset: 0x0033326C
		public byte NullMask { get; set; }

		// Token: 0x0601665B RID: 91739 RVA: 0x00335075 File Offset: 0x00333275
		public IActorParamT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.NullMask = 0;
		}
	}
}
