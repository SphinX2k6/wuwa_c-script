using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200400E RID: 16398
	public class IConeTipsActorT
	{
		// Token: 0x17006F2C RID: 28460
		// (get) Token: 0x0601676B RID: 92011 RVA: 0x003376EA File Offset: 0x003358EA
		// (set) Token: 0x0601676C RID: 92012 RVA: 0x003376F2 File Offset: 0x003358F2
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F2D RID: 28461
		// (get) Token: 0x0601676D RID: 92013 RVA: 0x003376FB File Offset: 0x003358FB
		// (set) Token: 0x0601676E RID: 92014 RVA: 0x00337703 File Offset: 0x00335903
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F2E RID: 28462
		// (get) Token: 0x0601676F RID: 92015 RVA: 0x0033770C File Offset: 0x0033590C
		// (set) Token: 0x06016770 RID: 92016 RVA: 0x00337714 File Offset: 0x00335914
		public float Radius { get; set; }

		// Token: 0x17006F2F RID: 28463
		// (get) Token: 0x06016771 RID: 92017 RVA: 0x0033771D File Offset: 0x0033591D
		// (set) Token: 0x06016772 RID: 92018 RVA: 0x00337725 File Offset: 0x00335925
		public float Height { get; set; }

		// Token: 0x17006F30 RID: 28464
		// (get) Token: 0x06016773 RID: 92019 RVA: 0x0033772E File Offset: 0x0033592E
		// (set) Token: 0x06016774 RID: 92020 RVA: 0x00337736 File Offset: 0x00335936
		public byte NullMask { get; set; }

		// Token: 0x06016775 RID: 92021 RVA: 0x0033773F File Offset: 0x0033593F
		public IConeTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
