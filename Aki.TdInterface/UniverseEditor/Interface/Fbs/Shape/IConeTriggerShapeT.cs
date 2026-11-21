using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004011 RID: 16401
	public class IConeTriggerShapeT
	{
		// Token: 0x17006F36 RID: 28470
		// (get) Token: 0x0601678B RID: 92043 RVA: 0x00337AA3 File Offset: 0x00335CA3
		// (set) Token: 0x0601678C RID: 92044 RVA: 0x00337AAB File Offset: 0x00335CAB
		public ETriggerShape Type { get; set; }

		// Token: 0x17006F37 RID: 28471
		// (get) Token: 0x0601678D RID: 92045 RVA: 0x00337AB4 File Offset: 0x00335CB4
		// (set) Token: 0x0601678E RID: 92046 RVA: 0x00337ABC File Offset: 0x00335CBC
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006F38 RID: 28472
		// (get) Token: 0x0601678F RID: 92047 RVA: 0x00337AC5 File Offset: 0x00335CC5
		// (set) Token: 0x06016790 RID: 92048 RVA: 0x00337ACD File Offset: 0x00335CCD
		public int Radius { get; set; }

		// Token: 0x17006F39 RID: 28473
		// (get) Token: 0x06016791 RID: 92049 RVA: 0x00337AD6 File Offset: 0x00335CD6
		// (set) Token: 0x06016792 RID: 92050 RVA: 0x00337ADE File Offset: 0x00335CDE
		public int Height { get; set; }

		// Token: 0x06016793 RID: 92051 RVA: 0x00337AE7 File Offset: 0x00335CE7
		public IConeTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}
