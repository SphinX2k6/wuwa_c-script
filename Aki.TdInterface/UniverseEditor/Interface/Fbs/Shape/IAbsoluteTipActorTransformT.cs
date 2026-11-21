using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FEA RID: 16362
	public class IAbsoluteTipActorTransformT
	{
		// Token: 0x17006EC7 RID: 28359
		// (get) Token: 0x06016601 RID: 91649 RVA: 0x00334614 File Offset: 0x00332814
		// (set) Token: 0x06016602 RID: 91650 RVA: 0x0033461C File Offset: 0x0033281C
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006EC8 RID: 28360
		// (get) Token: 0x06016603 RID: 91651 RVA: 0x00334625 File Offset: 0x00332825
		// (set) Token: 0x06016604 RID: 91652 RVA: 0x0033462D File Offset: 0x0033282D
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006EC9 RID: 28361
		// (get) Token: 0x06016605 RID: 91653 RVA: 0x00334636 File Offset: 0x00332836
		// (set) Token: 0x06016606 RID: 91654 RVA: 0x0033463E File Offset: 0x0033283E
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06016607 RID: 91655 RVA: 0x00334647 File Offset: 0x00332847
		public IAbsoluteTipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
