using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C53 RID: 15443
	public class ISpotlightTriggerShapeT
	{
		// Token: 0x17006A7E RID: 27262
		// (get) Token: 0x060155B1 RID: 87473 RVA: 0x00316DF1 File Offset: 0x00314FF1
		// (set) Token: 0x060155B2 RID: 87474 RVA: 0x00316DF9 File Offset: 0x00314FF9
		public ETriggerShape Type { get; set; }

		// Token: 0x17006A7F RID: 27263
		// (get) Token: 0x060155B3 RID: 87475 RVA: 0x00316E02 File Offset: 0x00315002
		// (set) Token: 0x060155B4 RID: 87476 RVA: 0x00316E0A File Offset: 0x0031500A
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006A80 RID: 27264
		// (get) Token: 0x060155B5 RID: 87477 RVA: 0x00316E13 File Offset: 0x00315013
		// (set) Token: 0x060155B6 RID: 87478 RVA: 0x00316E1B File Offset: 0x0031501B
		public int HalfAngle { get; set; }

		// Token: 0x17006A81 RID: 27265
		// (get) Token: 0x060155B7 RID: 87479 RVA: 0x00316E24 File Offset: 0x00315024
		// (set) Token: 0x060155B8 RID: 87480 RVA: 0x00316E2C File Offset: 0x0031502C
		public int Height { get; set; }

		// Token: 0x17006A82 RID: 27266
		// (get) Token: 0x060155B9 RID: 87481 RVA: 0x00316E35 File Offset: 0x00315035
		// (set) Token: 0x060155BA RID: 87482 RVA: 0x00316E3D File Offset: 0x0031503D
		public int Yaw { get; set; }

		// Token: 0x17006A83 RID: 27267
		// (get) Token: 0x060155BB RID: 87483 RVA: 0x00316E46 File Offset: 0x00315046
		// (set) Token: 0x060155BC RID: 87484 RVA: 0x00316E4E File Offset: 0x0031504E
		public int Pitch { get; set; }

		// Token: 0x17006A84 RID: 27268
		// (get) Token: 0x060155BD RID: 87485 RVA: 0x00316E57 File Offset: 0x00315057
		// (set) Token: 0x060155BE RID: 87486 RVA: 0x00316E5F File Offset: 0x0031505F
		public byte NullMask { get; set; }

		// Token: 0x060155BF RID: 87487 RVA: 0x00316E68 File Offset: 0x00315068
		public ISpotlightTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.HalfAngle = 0;
			this.Height = 0;
			this.Yaw = 0;
			this.Pitch = 0;
			this.NullMask = 0;
		}
	}
}
