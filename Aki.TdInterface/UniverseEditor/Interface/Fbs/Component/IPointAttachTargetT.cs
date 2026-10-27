using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574F RID: 22351
	public class IPointAttachTargetT
	{
		// Token: 0x1700A6C5 RID: 42693
		// (get) Token: 0x06025753 RID: 153427 RVA: 0x0052B297 File Offset: 0x00529497
		// (set) Token: 0x06025754 RID: 153428 RVA: 0x0052B29F File Offset: 0x0052949F
		public EAttachType Type { get; set; }

		// Token: 0x1700A6C6 RID: 42694
		// (get) Token: 0x06025755 RID: 153429 RVA: 0x0052B2A8 File Offset: 0x005294A8
		// (set) Token: 0x06025756 RID: 153430 RVA: 0x0052B2B0 File Offset: 0x005294B0
		public IVectorInfoT RelativePoint { get; set; }

		// Token: 0x06025757 RID: 153431 RVA: 0x0052B2B9 File Offset: 0x005294B9
		public IPointAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.RelativePoint = null;
		}
	}
}
