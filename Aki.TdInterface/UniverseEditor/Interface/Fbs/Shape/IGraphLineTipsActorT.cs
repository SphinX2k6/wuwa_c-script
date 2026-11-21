using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004020 RID: 16416
	public class IGraphLineTipsActorT
	{
		// Token: 0x17006F6B RID: 28523
		// (get) Token: 0x06016831 RID: 92209 RVA: 0x00338EF6 File Offset: 0x003370F6
		// (set) Token: 0x06016832 RID: 92210 RVA: 0x00338EFE File Offset: 0x003370FE
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F6C RID: 28524
		// (get) Token: 0x06016833 RID: 92211 RVA: 0x00338F07 File Offset: 0x00337107
		// (set) Token: 0x06016834 RID: 92212 RVA: 0x00338F0F File Offset: 0x0033710F
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F6D RID: 28525
		// (get) Token: 0x06016835 RID: 92213 RVA: 0x00338F18 File Offset: 0x00337118
		// (set) Token: 0x06016836 RID: 92214 RVA: 0x00338F20 File Offset: 0x00337120
		public IVectorInfoT Start { get; set; }

		// Token: 0x17006F6E RID: 28526
		// (get) Token: 0x06016837 RID: 92215 RVA: 0x00338F29 File Offset: 0x00337129
		// (set) Token: 0x06016838 RID: 92216 RVA: 0x00338F31 File Offset: 0x00337131
		public IVectorInfoT End { get; set; }

		// Token: 0x17006F6F RID: 28527
		// (get) Token: 0x06016839 RID: 92217 RVA: 0x00338F3A File Offset: 0x0033713A
		// (set) Token: 0x0601683A RID: 92218 RVA: 0x00338F42 File Offset: 0x00337142
		public float Thickness { get; set; }

		// Token: 0x17006F70 RID: 28528
		// (get) Token: 0x0601683B RID: 92219 RVA: 0x00338F4B File Offset: 0x0033714B
		// (set) Token: 0x0601683C RID: 92220 RVA: 0x00338F53 File Offset: 0x00337153
		public byte NullMask { get; set; }

		// Token: 0x0601683D RID: 92221 RVA: 0x00338F5C File Offset: 0x0033715C
		public IGraphLineTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Start = null;
			this.End = null;
			this.Thickness = 0f;
			this.NullMask = 0;
		}
	}
}
