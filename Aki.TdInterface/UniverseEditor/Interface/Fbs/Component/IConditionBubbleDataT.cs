using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FEF RID: 20463
	public class IConditionBubbleDataT
	{
		// Token: 0x1700943F RID: 37951
		// (get) Token: 0x06020B45 RID: 133957 RVA: 0x0048C1F3 File Offset: 0x0048A3F3
		// (set) Token: 0x06020B46 RID: 133958 RVA: 0x0048C1FB File Offset: 0x0048A3FB
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009440 RID: 37952
		// (get) Token: 0x06020B47 RID: 133959 RVA: 0x0048C204 File Offset: 0x0048A404
		// (set) Token: 0x06020B48 RID: 133960 RVA: 0x0048C20C File Offset: 0x0048A40C
		public IBubbleDataT Flow { get; set; }

		// Token: 0x06020B49 RID: 133961 RVA: 0x0048C215 File Offset: 0x0048A415
		public IConditionBubbleDataT()
		{
			this.Condition = null;
			this.Flow = null;
		}
	}
}
