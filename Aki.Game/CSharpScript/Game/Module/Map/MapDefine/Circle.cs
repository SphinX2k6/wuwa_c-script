using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004521 RID: 17697
	public class Circle
	{
		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x0602CA5E RID: 182878 RVA: 0x00C863BB File Offset: 0x00C845BB
		// (set) Token: 0x0602CA5F RID: 182879 RVA: 0x00C863C3 File Offset: 0x00C845C3
		public float X { get; set; }

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x0602CA60 RID: 182880 RVA: 0x00C863CC File Offset: 0x00C845CC
		// (set) Token: 0x0602CA61 RID: 182881 RVA: 0x00C863D4 File Offset: 0x00C845D4
		public float Y { get; set; }

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x0602CA62 RID: 182882 RVA: 0x00C863DD File Offset: 0x00C845DD
		// (set) Token: 0x0602CA63 RID: 182883 RVA: 0x00C863E5 File Offset: 0x00C845E5
		public float R { get; set; }

		// Token: 0x0602CA64 RID: 182884 RVA: 0x00C863EE File Offset: 0x00C845EE
		public Circle(float x = 0f, float y = 0f, float r = 0f)
		{
			this.X = x;
			this.Y = y;
			this.R = r;
		}
	}
}
