using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF9 RID: 15353
	public class IBoxTriggerTipShapeT
	{
		// Token: 0x1700696D RID: 26989
		// (get) Token: 0x06015215 RID: 86549 RVA: 0x0030FC84 File Offset: 0x0030DE84
		// (set) Token: 0x06015216 RID: 86550 RVA: 0x0030FC8C File Offset: 0x0030DE8C
		public ETriggerTipShape Type { get; set; }

		// Token: 0x1700696E RID: 26990
		// (get) Token: 0x06015217 RID: 86551 RVA: 0x0030FC95 File Offset: 0x0030DE95
		// (set) Token: 0x06015218 RID: 86552 RVA: 0x0030FC9D File Offset: 0x0030DE9D
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700696F RID: 26991
		// (get) Token: 0x06015219 RID: 86553 RVA: 0x0030FCA6 File Offset: 0x0030DEA6
		// (set) Token: 0x0601521A RID: 86554 RVA: 0x0030FCAE File Offset: 0x0030DEAE
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006970 RID: 26992
		// (get) Token: 0x0601521B RID: 86555 RVA: 0x0030FCB7 File Offset: 0x0030DEB7
		// (set) Token: 0x0601521C RID: 86556 RVA: 0x0030FCBF File Offset: 0x0030DEBF
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x0601521D RID: 86557 RVA: 0x0030FCC8 File Offset: 0x0030DEC8
		public IBoxTriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
