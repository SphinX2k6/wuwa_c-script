using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004062 RID: 16482
	public class ISpotlightTriggerShapeT
	{
		// Token: 0x1700702F RID: 28719
		// (get) Token: 0x06016AC5 RID: 92869 RVA: 0x0033DC91 File Offset: 0x0033BE91
		// (set) Token: 0x06016AC6 RID: 92870 RVA: 0x0033DC99 File Offset: 0x0033BE99
		public ETriggerShape Type { get; set; }

		// Token: 0x17007030 RID: 28720
		// (get) Token: 0x06016AC7 RID: 92871 RVA: 0x0033DCA2 File Offset: 0x0033BEA2
		// (set) Token: 0x06016AC8 RID: 92872 RVA: 0x0033DCAA File Offset: 0x0033BEAA
		public IVectorInfoT Center { get; set; }

		// Token: 0x17007031 RID: 28721
		// (get) Token: 0x06016AC9 RID: 92873 RVA: 0x0033DCB3 File Offset: 0x0033BEB3
		// (set) Token: 0x06016ACA RID: 92874 RVA: 0x0033DCBB File Offset: 0x0033BEBB
		public int HalfAngle { get; set; }

		// Token: 0x17007032 RID: 28722
		// (get) Token: 0x06016ACB RID: 92875 RVA: 0x0033DCC4 File Offset: 0x0033BEC4
		// (set) Token: 0x06016ACC RID: 92876 RVA: 0x0033DCCC File Offset: 0x0033BECC
		public int Height { get; set; }

		// Token: 0x17007033 RID: 28723
		// (get) Token: 0x06016ACD RID: 92877 RVA: 0x0033DCD5 File Offset: 0x0033BED5
		// (set) Token: 0x06016ACE RID: 92878 RVA: 0x0033DCDD File Offset: 0x0033BEDD
		public int Yaw { get; set; }

		// Token: 0x17007034 RID: 28724
		// (get) Token: 0x06016ACF RID: 92879 RVA: 0x0033DCE6 File Offset: 0x0033BEE6
		// (set) Token: 0x06016AD0 RID: 92880 RVA: 0x0033DCEE File Offset: 0x0033BEEE
		public int Pitch { get; set; }

		// Token: 0x17007035 RID: 28725
		// (get) Token: 0x06016AD1 RID: 92881 RVA: 0x0033DCF7 File Offset: 0x0033BEF7
		// (set) Token: 0x06016AD2 RID: 92882 RVA: 0x0033DCFF File Offset: 0x0033BEFF
		public byte NullMask { get; set; }

		// Token: 0x06016AD3 RID: 92883 RVA: 0x0033DD08 File Offset: 0x0033BF08
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
