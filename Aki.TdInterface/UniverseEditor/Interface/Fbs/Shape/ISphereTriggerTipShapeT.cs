using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004056 RID: 16470
	public class ISphereTriggerTipShapeT
	{
		// Token: 0x17007007 RID: 28679
		// (get) Token: 0x06016A45 RID: 92741 RVA: 0x0033CDE1 File Offset: 0x0033AFE1
		// (set) Token: 0x06016A46 RID: 92742 RVA: 0x0033CDE9 File Offset: 0x0033AFE9
		public ETriggerTipShape Type { get; set; }

		// Token: 0x17007008 RID: 28680
		// (get) Token: 0x06016A47 RID: 92743 RVA: 0x0033CDF2 File Offset: 0x0033AFF2
		// (set) Token: 0x06016A48 RID: 92744 RVA: 0x0033CDFA File Offset: 0x0033AFFA
		public IVectorInfoT Center { get; set; }

		// Token: 0x17007009 RID: 28681
		// (get) Token: 0x06016A49 RID: 92745 RVA: 0x0033CE03 File Offset: 0x0033B003
		// (set) Token: 0x06016A4A RID: 92746 RVA: 0x0033CE0B File Offset: 0x0033B00B
		public int Radius { get; set; }

		// Token: 0x06016A4B RID: 92747 RVA: 0x0033CE14 File Offset: 0x0033B014
		public ISphereTriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
			this.Center = null;
			this.Radius = 0;
		}
	}
}
