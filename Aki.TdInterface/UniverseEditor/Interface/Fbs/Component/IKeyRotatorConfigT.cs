using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3C RID: 23100
	public class IKeyRotatorConfigT
	{
		// Token: 0x1700A7FE RID: 43006
		// (get) Token: 0x06025C4E RID: 154702 RVA: 0x0052D8C7 File Offset: 0x0052BAC7
		// (set) Token: 0x06025C4F RID: 154703 RVA: 0x0052D8CF File Offset: 0x0052BACF
		public ERotationType Type { get; set; }

		// Token: 0x1700A7FF RID: 43007
		// (get) Token: 0x06025C50 RID: 154704 RVA: 0x0052D8D8 File Offset: 0x0052BAD8
		// (set) Token: 0x06025C51 RID: 154705 RVA: 0x0052D8E0 File Offset: 0x0052BAE0
		public float Time { get; set; }

		// Token: 0x1700A800 RID: 43008
		// (get) Token: 0x06025C52 RID: 154706 RVA: 0x0052D8E9 File Offset: 0x0052BAE9
		// (set) Token: 0x06025C53 RID: 154707 RVA: 0x0052D8F1 File Offset: 0x0052BAF1
		public float Cd { get; set; }

		// Token: 0x1700A801 RID: 43009
		// (get) Token: 0x06025C54 RID: 154708 RVA: 0x0052D8FA File Offset: 0x0052BAFA
		// (set) Token: 0x06025C55 RID: 154709 RVA: 0x0052D902 File Offset: 0x0052BB02
		public string Curve { get; set; }

		// Token: 0x1700A802 RID: 43010
		// (get) Token: 0x06025C56 RID: 154710 RVA: 0x0052D90B File Offset: 0x0052BB0B
		// (set) Token: 0x06025C57 RID: 154711 RVA: 0x0052D913 File Offset: 0x0052BB13
		public IVectorInfoT KeyRotator { get; set; }

		// Token: 0x1700A803 RID: 43011
		// (get) Token: 0x06025C58 RID: 154712 RVA: 0x0052D91C File Offset: 0x0052BB1C
		// (set) Token: 0x06025C59 RID: 154713 RVA: 0x0052D924 File Offset: 0x0052BB24
		public byte NullMask { get; set; }

		// Token: 0x06025C5A RID: 154714 RVA: 0x0052D92D File Offset: 0x0052BB2D
		public IKeyRotatorConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.KeyRotator = null;
			this.NullMask = 0;
		}
	}
}
